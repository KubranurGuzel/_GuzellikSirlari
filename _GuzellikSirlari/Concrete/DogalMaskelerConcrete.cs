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
    public class DogalMaskelerConcrete : IDataBusiness<DogalMaskeler>
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-JMR7LFH\\SQLEXPRESS;Initial Catalog=GuzellikSirlari;Integrated Security=true;");
        public void DeleteData(DogalMaskeler data)
        {
            conn.Open();
            SqlCommand command = new SqlCommand("Sp_DogalMaskelerSil", conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@DogalMaskelerId", data.DogalMaskelerId);
            command.ExecuteNonQuery();
            conn.Close();
            conn.Dispose();
            command.Dispose();
        }

        public void InsertData(DogalMaskeler data)
        {
            conn.Open();
            SqlCommand command = new SqlCommand("Sp_DogalMaskelerEkle", conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@DogalMaskelerAdi", data.DogalMaskelerAdi);
            command.Parameters.AddWithValue("@DogalMaskelerAciklama", data.DogalMaskelerAciklama);
            command.ExecuteNonQuery();
            conn.Close();
            conn.Dispose();
            command.Dispose();
        }

        public List<DogalMaskeler> ListData()
        {
            conn.Open();
            SqlCommand command = new SqlCommand("Sp_DogalMaskelerList", conn);
            command.CommandType = CommandType.StoredProcedure;
            List<DogalMaskeler> dogalmaskeler = new List<DogalMaskeler>();
            SqlDataReader dr = command.ExecuteReader();
            while (dr.Read())
            {
                dogalmaskeler.Add(new DogalMaskeler
                {
                    DogalMaskelerId = Convert.ToInt32(dr[0]),
                    DogalMaskelerAdi = dr[1].ToString(),
                    DogalMaskelerAciklama = dr[2].ToString()
                });
            }
            conn.Close();
            conn.Dispose();
            command.Dispose();
            return dogalmaskeler;
        }

        public DogalMaskeler Sec(int DogalMaskelerId) 
        {
            SqlDataAdapter adapter = new SqlDataAdapter("[Sp_DogalMaskelerSec]", conn);
            adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            adapter.SelectCommand.Parameters.AddWithValue("@DogalMaskelerId", DogalMaskelerId);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            DogalMaskeler p = new DogalMaskeler
            {
                DogalMaskelerId = Convert.ToInt32(dt.Rows[0][0]),
                DogalMaskelerAdi = dt.Rows[0][1].ToString(),
                DogalMaskelerAciklama = dt.Rows[0][2].ToString()
            };
            return p;
        }

        public void UpdateData(DogalMaskeler data)
        {
            throw new NotImplementedException();
        }
    }
}