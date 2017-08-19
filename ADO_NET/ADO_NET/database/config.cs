using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using ADO_NET.entities;
namespace ADO_NET.database
{
    public class config
    {
        private string strCon = @"Data Source=PHILHEATH\SQLEXPRESS;Initial Catalog=bookstore;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False";
        /*
         Insert , Update , Delete record
         */
        public void ExecuteNonQuery(string strSQL)
        {
            using (SqlConnection conn = new SqlConnection(strCon))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(strSQL, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }

        /*  Read data from a table */
        public DataTable getListData(string strSQL)
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(strCon))
            {
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter(strSQL, conn);
                da.Fill(dt);
                conn.Close();
                return dt;
            }
        }

        public Category getARecord(long id)
        {
            Category cate = new Category();
            using (SqlConnection conn = new SqlConnection(strCon))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM [Category] WHERE ID = '" + id + "'", conn);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cate.ID = long.Parse(dr["ID"].ToString());
                    cate.Name = dr["Name"].ToString();
                    cate.Description = dr["Description"].ToString();
                    cate.Detail = dr["Detail"].ToString();
                    cate.ImagePath = dr["ImagePath"].ToString();
                    cate.Meta_Keyword = dr["Meta_Keyword"].ToString();
                    cate.Meta_Description = dr["Meta_Description"].ToString();
                    cate.Status = bool.Parse(dr["Status"].ToString());
                    cate.ShowOnHome = bool.Parse(dr["ShowOnHome"].ToString());
                }
                return cate;
            }
        }
    }
}