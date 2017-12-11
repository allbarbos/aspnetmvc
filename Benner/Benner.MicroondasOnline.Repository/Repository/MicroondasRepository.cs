using System.Collections.Generic;
using Benner.MicroondasOnline.Domain.Entities;
using Benner.MicroondasOnline.Domain.Interfaces.Repository;
using Dapper;

namespace Benner.MicroondasOnline.Repository.Repository
{
  public class MicroondasRepository : IMicroondasRepository
  {
    private readonly string _cnx = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True";


    public IEnumerable<Programa> BuscaProgramas()
    {
      const string sql = @"SELECT * FROM Programas;";

      using (var cnx = new System.Data.SqlClient.SqlConnection(_cnx))
      {
        var programas = cnx.Query<Programa>(sql);

        return programas;
      }
    }
  }
}
