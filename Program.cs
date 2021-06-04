using Microsoft.Data.SqlClient;
using System;

namespace Lab_18
{
    class Program
    {
        public static string ConnStr = @"Data Source=HOME;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public static void AddPerson (string name, string surname, string date)
        {
            SqlConnection cn = new SqlConnection(ConnStr);
            SqlCommand cmd;
            cn.Open();
            cmd = cn.CreateCommand();
            cmd.CommandText = $"INSERT INTO [Lab18].[dbo].[Persons] VALUES('{name}', '{surname}', '{date}')";
            cmd.ExecuteNonQuery();
            cn.Close();
        }

        public static void AddAirport(string name)
        {
            SqlConnection cn = new SqlConnection(ConnStr);
            SqlCommand cmd;
            cn.Open();
            cmd = cn.CreateCommand();
            cmd.CommandText = $"INSERT INTO [Lab18].[dbo].[Airports] VALUES('{name}')";
            cmd.ExecuteNonQuery();
            cn.Close();
        }

        public static void AddTiket (int timeDepart, string derartPort, string arriverPort, string person)
        {
            SqlConnection cn = new SqlConnection(ConnStr);
            SqlCommand cmd;
            cn.Open();
            cmd = cn.CreateCommand();
            cmd.CommandText = $"INSERT INTO [Lab18].[dbo].[PlaneTikets] VALUES({timeDepart},'{derartPort}','{arriverPort}','{person}')";
            cmd.ExecuteNonQuery();
            cn.Close();
        }

        static void Main(string[] args)
        {
            AddPerson("Viktor", "Shekhovtsov", "20.10.2001");
            AddPerson("Makar", "Fomenko", "22.02.2002");
            AddPerson("Pavel", "Ruzavin", "13.10.2001");

            AddAirport("Khrabrovo");
            AddAirport("Domodedovo");
            AddAirport("Pulkovo");
            AddAirport("Sheremetevo");

            AddTiket(1100, "Khrabrovo", "Domodedovo", "Viktor Shekhovtsov");
            AddTiket(1200, "Khrabrovo", "Pulkovo", "Makar Fomenko");
            AddTiket(1130, "Khrabrovo", "Sheremetevo", "Ruzavin Pavel");

        }
    }
}
