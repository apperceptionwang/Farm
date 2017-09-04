using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.IO;

namespace Farm.ToolClass
{
    class DBfun
    {
        static string str = @"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\1234\Desktop\C#实训\Farm\Farm\Farm.mdf;Integrated Security=True;User Instance=True";
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        public DBfun()
        {
            con = new SqlConnection(str);//定义连接对象，打开数据库
            con.Open();
            //SqlCommand cmd = new SqlCommand(sql, con);//定义查询命令:表示对数据库执行一个SQL语句或存储过程    
            cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "";
            //dr = cmd.ExecuteReader();//执行查询:提供一种读取数据库行的方式
        }
        public bool connect(string sql)
        {
            con.Close();
            con.Open();
            cmd.CommandText = sql;
            dr = cmd.ExecuteReader(); //执行查询:提供一种读取数据库行的方式
            if (dr.Read())
            {
                dr.Close();
                con.Close();
                //dr.GetOrdinal("Seed_MkMn");
                //string pwd = dr.GetString(dr.GetOrdinal("PassWord")).Trim();
                return true;
            }
            else
            {
                dr.Close();
                con.Close();
                return false;
            }

        }
        public int getData(string sql)
        {
            int S_Money = 0;
            con.Close();
            con.Open();
            cmd.CommandText = sql;
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                S_Money = dr.GetInt32(dr.GetOrdinal("Seed_MkMn"));
            }
            //con.Close();
            dr.Close();
            return S_Money;

        }
        //public string getImageLocation(string sql)
        //{
        //    string S_Image="";
        //    con.Close();
        //    con.Open();
        //    cmd.CommandText = sql;
        //    dr = cmd.ExecuteReader();
        //    if (dr.Read())
        //    {
        //        S_Image = dr.GetString(dr.GetOrdinal("Seed_Image"));
        //    }
        //    //con.Close();
        //    dr.Close();
        //    return S_Image;
        //}
    }
}
