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
    public class CiltSagligiConcrete : IDataBusiness<CiltSagligi>
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-JMR7LFH\\SQLEXPRESS;Initial Catalog=GuzellikSirlari;Integrated Security=true;");
        public void DeleteData(CiltSagligi data)
        {
            conn.Open();
            SqlCommand command = new SqlCommand("Sp_CiltSagligiSil", conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@CiltSagligiId", data.CiltSagligiId);
            command.ExecuteNonQuery();
            conn.Close();
            conn.Dispose();
            command.Dispose();
        }

        public void InsertData(CiltSagligi data)
        {
            conn.Open();
            SqlCommand command = new SqlCommand("Sp_CiltSagligiEkle", conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@CiltSagligiAdi", data.CiltSagligiAdi);
            command.Parameters.AddWithValue("@CiltSagligiAciklama", data.CiltSagligiAciklama);
            command.ExecuteNonQuery();
            conn.Close();
            conn.Dispose();
            command.Dispose();
        }

        public List<CiltSagligi> ListData()
        {
            conn.Open();
            SqlCommand command = new SqlCommand("Sp_CiltSagligiList", conn);
            command.CommandType = CommandType.StoredProcedure;
            List<CiltSagligi> ciltsagligi = new List<CiltSagligi>();
            SqlDataReader dr = command.ExecuteReader();
            while (dr.Read())
            {
                ciltsagligi.Add(new CiltSagligi
                {
                    CiltSagligiId = Convert.ToInt32(dr[0]),
                    CiltSagligiAdi = dr[1].ToString(),
                    CiltSagligiAciklama = dr[2].ToString()
                });
            }
            conn.Close();
            conn.Dispose();
            command.Dispose();
            return ciltsagligi;
        }

        public CiltSagligi Sec(int CiltSagligiId)
        {
            SqlDataAdapter adapter = new SqlDataAdapter("[Sp_CiltSagligiSec]", conn);
            adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            adapter.SelectCommand.Parameters.AddWithValue("@CiltSagligiId", CiltSagligiId);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            CiltSagligi p = new CiltSagligi
            {
                CiltSagligiId = Convert.ToInt32(dt.Rows[0][0]),
                CiltSagligiAdi = dt.Rows[0][1].ToString(),
                CiltSagligiAciklama = dt.Rows[0][2].ToString()
            };
            return p;
        }

        public void UpdateData(CiltSagligi data)
        {
            throw new NotImplementedException();
        }
    }
}