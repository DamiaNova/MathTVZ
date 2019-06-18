﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Configuration;

namespace MathTVZApp.Klase
{
    public class DBpristup
    {
        public int? KorisnikId { get; set; }
        public string Username { get; set; }
        public string Lozinka { get; set; }
        public bool OK { get; set; }

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
                cmd.Parameters.AddWithValue("KorisnickoIme", Username);
                cmd.Parameters.AddWithValue("Lozinka", Lozinka);
                cmd.ExecuteNonQuery();
                con.Close();
                OK = true;
            }
            catch (Exception)
            {
                //error poruka i logiranje
            }
        }
    }
}