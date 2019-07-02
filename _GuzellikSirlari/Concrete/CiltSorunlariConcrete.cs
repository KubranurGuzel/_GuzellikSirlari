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
    public class CiltSorunlariConcrete : IDataBusiness<CiltSorunlari>
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-JMR7LFH\\SQLEXPRESS;Initial Catalog=GuzellikSirlari;Integrated Security=true;");
        public void DeleteData(CiltSorunlari data)
        {
            conn.Open();
            SqlCommand command = new SqlCommand("Sp_CiltSorunlariSil", conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@CiltSorunlariId", data.CiltSorunlariId);
            command.ExecuteNonQuery();
            conn.Close();
            conn.Dispose();
            command.Dispose();
        }

        public void InsertData(CiltSorunlari data)
        {
            conn.Open();
            SqlCommand command = new SqlCommand("Sp_CiltSorunlariEkle", conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@CiltSorunlariAdi", data.CiltSorunlariAdi);
            command.Parameters.AddWithValue("@CiltSorunlariAciklama", data.CiltSorunlariAciklama);
            command.ExecuteNonQuery();
            conn.Close();
            conn.Dispose();
            command.Dispose();
        }

        public List<CiltSorunlari> ListData()
        {
            conn.Open();
            SqlCommand command = new SqlCommand("Sp_CiltSorunlariList", conn);
            command.CommandType = CommandType.StoredProcedure;
            List<CiltSorunlari> ciltsorunlari = new List<CiltSorunlari>();
            SqlDataReader dr = command.ExecuteReader();
            while (dr.Read())
            {
                ciltsorunlari.Add(new CiltSorunlari
                {
                    CiltSorunlariId = Convert.ToInt32(dr[0]),
                    CiltSorunlariAdi = dr[1].ToString(),
                    CiltSorunlariAciklama = dr[2].ToString()
                });
            }
            conn.Close();
            conn.Dispose();
            command.Dispose();
            return ciltsorunlari;
        }

        public CiltSorunlari Sec(int CiltSorunlariId)
        {
            SqlDataAdapter adapter = new SqlDataAdapter("[Sp_CiltSorunlariSec]", conn);
            adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            adapter.SelectCommand.Parameters.AddWithValue("@CiltSorunlariId", CiltSorunlariId);
            DataTable dt = new DataTable(); 
            adapter.Fill(dt);
            CiltSorunlari p = new CiltSorunlari
            {
                CiltSorunlariId = Convert.ToInt32(dt.Rows[0][0]),
                CiltSorunlariAdi = dt.Rows[0][1].ToString(),
                CiltSorunlariAciklama = dt.Rows[0][2].ToString()
            };
            return p;
        }

        public void UpdateData(CiltSorunlari data)
        {
            throw new NotImplementedException();
        }
    }
}