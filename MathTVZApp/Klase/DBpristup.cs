using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Configuration;

namespace MathTVZApp.Klase
{
    public class DBpristup
    {
        public string KorisnikId { get; set; }
        public string Username { get; set; }
        public string Lozinka { get; set; }
        public bool OK { get; set; }
        private int _pocetniBodovi = 0;

        //Metode
        public void ProvjeraPrijaveKorisnika()
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["mycon"].ToString());
            OK = false;
            try
            {
                con.Open();
                var qry = "SELECT * FROM korisnici WHERE korisnicko_ime=@KorisnickoIme AND lozinka=@Lozinka;";
                SqlCommand cmd = new SqlCommand(qry, con);
                cmd.Parameters.AddWithValue("@KorisnickoIme", Username);
                cmd.Parameters.AddWithValue("@Lozinka", Lozinka);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read()) { OK = true; }
                con.Close();
            }
            catch (Exception ex)
            {
                //error poruka, logiranje
            }
        }

        public void ProvjeraZauzetostiImena()
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["mycon"].ToString());
            OK = true;
            try
            {
                con.Open();
                var qry = "SELECT * FROM korisnici WHERE korisnicko_ime=@KorisnickoIme;";
                SqlCommand cmd = new SqlCommand(qry, con);
                cmd.Parameters.AddWithValue("@KorisnickoIme", Username);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read()) { OK = false; }
                con.Close();
            }
            catch (Exception ex)
            {
                //error poruka, logiranje
            }
        }

        public void SpremiRegistraciju()
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["mycon"].ToString());
            OK = false;
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("insert into korisnici values(@KorisnickoIme, @Lozinka)", con);
                cmd.Parameters.AddWithValue("@KorisnickoIme", Username);
                cmd.Parameters.AddWithValue("@Lozinka", Lozinka);
                cmd.ExecuteNonQuery();
                con.Close();
                OK = true;
            }
            catch (Exception)
            {
                //error poruka i logiranje
            }
        }

        public void InsPocetniBodovi()
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["mycon"].ToString());
            OK = false;
            try
            {
                con.Open();
                var qry = "INSERT INTO bodovi(KOR_ID, UKUPNO) values(@KorisnikId, @UkupniBodovi);";
                SqlCommand cmd = new SqlCommand(qry, con);
                cmd.Parameters.AddWithValue("@KorisnikId", KorisnikId);
                cmd.Parameters.AddWithValue("@UkupniBodovi", _pocetniBodovi);
                cmd.ExecuteNonQuery();
                con.Close();
                OK = true;
            }
            catch (Exception ex)
            {
                //error poruka, logiranje
            }
        }

        public void GetKorisnikID()
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["mycon"].ToString());
            OK = false;
            try
            {
                con.Open();
                var qry = "SELECT id FROM korisnici WHERE korisnicko_ime=@KorisnickoIme;";
                SqlCommand cmd = new SqlCommand(qry, con);
                cmd.Parameters.AddWithValue("@KorisnickoIme", Username);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    KorisnikId = reader["id"].ToString();
                }
                if (KorisnikId.Length != 0) { OK = true; }
                con.Close();
            }
            catch (Exception ex)
            {
                //error poruka, logiranje
            }
        }
    }
}