using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using _GuzellikSirlari.Models;
using _GuzellikSirlari.Abstract;
using System.Data.SqlClient;
using System.Data;

namespace _GuzellikSirlari.Concrete
{
    public class CiltBakimiConcrete : IDataBusiness<CiltBakimi>
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-JMR7LFH\\SQLEXPRESS;Initial Catalog=GuzellikSirlari;Integrated Security=true;");

        public void DeleteData(CiltBakimi data)
        {
            conn.Open();
            SqlCommand command = new SqlCommand("Sp_CiltBakimiSil", conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@CiltBakimiId", data.CiltBakimiId);
            command.ExecuteNonQuery();
            conn.Close();
            conn.Dispose();
            command.Dispose();
        }

        public void InsertData(CiltBakimi data)
        {
            conn.Open();
            SqlCommand command = new SqlCommand("Sp_CiltBakimiEkle", conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@CiltBakimiAdi", data.CiltBakimiAdi);
            command.Parameters.AddWithValue("@CiltBakimiAciklama", data.CiltBakimiAciklama);
            command.ExecuteNonQuery();
            conn.Close();
            conn.Dispose();
            command.Dispose();
        }

        public List<CiltBakimi> ListData()
        {
            conn.Open();
            SqlCommand command = new SqlCommand("Sp_CiltBakimiList", conn);
            command.CommandType = CommandType.StoredProcedure;
            List<CiltBakimi> ciltbakimi = new List<CiltBakimi>();
            SqlDataReader dr = command.ExecuteReader();
            while (dr.Read())
            {
                ciltbakimi.Add(new CiltBakimi
                {
                    CiltBakimiId = Convert.ToInt32(dr[0]),
                    CiltBakimiAdi = dr[1].ToString(),
                    CiltBakimiAciklama = dr[2].ToString()
                });
            }
            conn.Close();
            conn.Dispose();
            command.Dispose();
            return ciltbakimi;
        }

        public CiltBakimi Sec(int CiltBakimiId) 
        {
            SqlDataAdapter adapter = new SqlDataAdapter("[Sp_CiltBakimiSec]", conn);
            adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            adapter.SelectCommand.Parameters.AddWithValue("@CiltBakimiId", CiltBakimiId);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            CiltBakimi p = new CiltBakimi
            {
                CiltBakimiId = Convert.ToInt32(dt.Rows[0][0]),
                CiltBakimiAdi = dt.Rows[0][1].ToString(),
                CiltBakimiAciklama = dt.Rows[0][2].ToString()
            };
            return p;
        }

        public void UpdateData(CiltBakimi data)
        {
            throw new NotImplementedException();
        }
    }
}