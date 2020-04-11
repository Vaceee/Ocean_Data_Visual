﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Data_Visual
{
    public partial class 用户信息 : Form
    {
        public 用户信息()
        {
            InitializeComponent();
        }
        SqlConnection myconn = new SqlConnection(@"Data Source=" + sql_source.dt_source + " ;Initial Catalog=OT_user ; Integrated Security=true");
        string mysql;
        DataSet mydataset = new DataSet();

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Close();
            Owner.Show();
        }

        private void 用户信息_Load(object sender, EventArgs e)
        {
            mysql = "select umail, uname, sex, desire, u_status, describe from user_info";
            SqlDataAdapter myadapter = new SqlDataAdapter(mysql, myconn);
            mydataset.Clear();
            myadapter.Fill(mydataset, "info");
            ListViewInit();

            for (int i = 0; i < mydataset.Tables["info"].Rows.Count; i++)
            {
                ListViewItem lt = new ListViewItem();
                lt.Text = mydataset.Tables["info"].Rows[i][0].ToString();
                for (int j = 0; j < 5; j++)
                    lt.SubItems.Add(mydataset.Tables["info"].Rows[i][j].ToString());
                listView1.Items.Add(lt);
            }
            this.listView1.View = System.Windows.Forms.View.Details;
        }

        void ListViewInit()
        {
            listView1.Columns.Add("用户邮箱", 80);
            listView1.Columns.Add("用户名", 70);
            listView1.Columns.Add("性别", 70);
            listView1.Columns.Add("兴趣", 70);
            listView1.Columns.Add("身份", 70);
            listView1.Columns.Add("描述", 200);
        }


        /// <summary>
        /// 根据用户名查找用户邮箱；需要在listView1已被填充后调用
        /// </summary>
        /// <param name="uname">用户名</param>
        private string SearchUser(string uname)
        {
            ListViewItem res = listView1.FindItemWithText(uname, true, 0, true);
            string umail = res.SubItems[0].Text;
            return umail;
        }

        /// <summary>根据用户邮箱封禁用户</summary>
        /// <param name="umail">用户邮箱</param>
        private void DisableUser(string umail)
        {
            string sql = "update user_info set enabled='N' where umail='" + umail + "'";
            SqlCommand mycmd = new SqlCommand(sql, myconn);
            myconn.Open();
            try
            {
                mycmd.ExecuteNonQuery();
                MessageBox.Show("已禁用用户"+umail, "OceanTracer");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            myconn.Close();
        }

        /// <summary>根据用户邮箱解封用户</summary>
        /// <param name="umail">用户邮箱</param>
        private void EnableUser(string umail)
        {
            string sql = "update user_info set enabled='Y' where umail='" + umail + "'";
            SqlCommand mycmd = new SqlCommand(sql, myconn);
            myconn.Open();
            try
            {
                mycmd.ExecuteNonQuery();
                MessageBox.Show("已启用用户" + umail, "OceanTracer");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            myconn.Close();
        }

        /// <summary>统计科普收藏量</summary>
        /// 本函数将<科普ID,收藏人数>的键值对储存在了一个字典中并返回，可以利用字典中的数据实现各种展示；
        /// 实际使用时直接用DataSet的SQL查询结果也可以，字典只是将前后端分离的中转站（实际上也有将查询结果转换为合理类型储存、避免多次查询的作用）
        private Dictionary<int, int> CollectCount()
        {
            Dictionary<int, int> collects = new Dictionary<int, int>();
            string sql = @"select collect_num, count(*) as 'count' from collect group by collect_num UNION
            select collect_num, 0 as 'count' from collect_info where collect_num not in(select collect_num from collect)";
            SqlDataAdapter myadapter = new SqlDataAdapter(sql, myconn);
            mydataset.Clear();
            myadapter.Fill(mydataset, "count");
            for (int i = 0; i < mydataset.Tables["count"].Rows.Count; i++)
            {
                int collect_num = Convert.ToInt32(mydataset.Tables["info"].Rows[i][0]);
                int count = Convert.ToInt32(mydataset.Tables["info"].Rows[i][1]);
                collects[collect_num] = count;
            }
            return collects;
            /*eg: how to access the data in a Dictionary*/
            //foreach(KeyValuePair<int, int> clct in collects)
            //{
            //    Console.Write("科普ID："+clct.Key+" 收藏数量："+clct.Value);
            //}
        }

        /// <summary>统计不同兴趣数量</summary>
        /// 本函数将<兴趣,人数>的键值对储存在了一个字典中并返回，可以利用字典中的数据实现各种展示；
        /// 与上一个函数不同的是，因为desire属性在数据库中合并储存，因此必须手动分割计数，不能直接用DataSet的结果
        private Dictionary<string, int> DesireCount()
        {
            Dictionary<string, int> desires = new Dictionary<string, int>();
            string sql = "select desire from user_info";
            SqlDataAdapter myadapter = new SqlDataAdapter(sql, myconn);
            mydataset.Clear();
            myadapter.Fill(mydataset, "count");
            for (int i = 0; i < mydataset.Tables["count"].Rows.Count; i++)
            {
                string des = mydataset.Tables["info"].Rows[i][0].ToString();
                string[] splits = des.Split(',');
                foreach (string s in splits)
                    if (!desires.ContainsKey(s))
                        desires[s] = 1;
                    else
                        desires[s]++;
            }
            return desires;
            /*eg: how to access the data in a Dictionary*/
            //foreach(KeyValuePair<string, int> dsr in collects)
            //{
            //    Console.Write("兴趣："+dsr.Key+" 人数："+dsr.Value);
            //}
        }


        /// <summary>向指定用户发送通知</summary>
        /// <param name="umail">用户邮箱</param>
        /// <param name="notice_content">通知内容，最大长度400(中文字符长度为2)</param>
        private void SendNotice(string umail, string notice_content)
        {
            string sql = "insert into notice values('" + umail + "','" + notice_content + "',GETDATE())";
            SqlCommand mycmd = new SqlCommand(sql, myconn);
            myconn.Open();
            try
            {
                mycmd.ExecuteNonQuery();
                MessageBox.Show("通知发送成功", "OceanTracer");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            myconn.Close();
        }

        /// <summary>向所有用户群发通知</summary>
        /// <param name="notice_content">通知内容，最大长度400(中文字符长度为2)</param>
        private void SendGroupNotice(string notice_content)
        {
            SqlCommand mycmd = new SqlCommand("groupNotice", myconn);   //利用数据库的存储过程实现
            mycmd.CommandType = CommandType.StoredProcedure;
            SqlParameter content = new SqlParameter("@notice_content ", SqlDbType.VarChar, 400);
            mycmd.Parameters.Add(content);
            content.Value = notice_content;
            myconn.Open();
            try
            {
                mycmd.ExecuteNonQuery();
                MessageBox.Show("通知群发成功", "OceanTracer");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            myconn.Close();
        }

        ///<summary>用户查询收到的通知</summary>
        ///<param name="umail">用户邮箱</param>
        ///本函数将[通知内容,通知时间]的二元组按通知时间倒序储存在了一个List中并返回，可以用List中的数据实现各种展示；
        ///实际使用时也可以直接用DataSet的查询结果输出
        private List<string[]> GetNotice(string umail)
        {
            List<string[]> noticeList = new List<string[]>();
            //按时间倒序查询此用户收到的通知
            string sql = "select notice_content, notice_time from notice where umail='" + umail + "'order by notice_time desc";
            string ntc_content, ntc_time;
            SqlDataAdapter myadapter = new SqlDataAdapter(sql, myconn);
            mydataset.Clear();
            myadapter.Fill(mydataset, "notice");
            for (int i = 0; i < mydataset.Tables["notice"].Rows.Count; i++)
            {
                ntc_content = mydataset.Tables["notice"].Rows[i][0].ToString();
                ntc_time = mydataset.Tables["notice"].Rows[i][1].ToString();
                string[] ntc = new string[] { ntc_content, ntc_time};
                noticeList.Add(ntc);
            }
            return noticeList;
            /*eg: how to access the data in a List<string[]>*/
            //for(int i=0;i<noticeList.Count;i++)
            //    Console.Write("通知内容：" + noticeList[i][0] + " 时间：" + noticeList[i][1]);
        }
    }
}
