using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
  class Program
  {
    static void Main(string[] args)
    {
      string connStr = "server=my01.winhost.com;user id=mihaela;password=batran11;persistsecurityinfo=True;database=mysql_76431_mihaela";
      MySqlConnection conn = new MySqlConnection(connStr);
      try
      {
        Console.WriteLine("Connecting to MySQL...");
        string sql = "select * from wp_terms;";
        MySqlCommand cmd = new MySqlCommand(sql, conn);
        conn.Open();
        MySqlDataReader rdr = cmd.ExecuteReader();

        while (rdr.Read())
        {
          Console.WriteLine(rdr[0] + " -- " + rdr[1]);
        }
        rdr.Close();
        // Perform database operations
      }
      catch (Exception ex)
      {
        Console.WriteLine(ex.ToString());
      }
      conn.Close();
      Console.WriteLine("Done.");
    }
  }
}
