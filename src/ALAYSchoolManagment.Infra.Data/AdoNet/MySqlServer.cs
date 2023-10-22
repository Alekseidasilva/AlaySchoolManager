using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using MySqlConnector;
using System.Data;

namespace ALAYSchoolManagment.Infra.Data.AdoNet;

public class MySqlServer
{
    public MySqlConnection CriarConexao()
    {
        var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();
        return new MySqlConnection(config.GetConnectionString("MySQLConnectionStrings"));
    }
    private MySqlParameterCollection sqlParameterCollection = new MySqlCommand().Parameters;
    public void LimparParametro()
    {
        sqlParameterCollection.Clear();
    }
    public void AdicionarParametros(string nomeParametro, object valorParametro)
    {
        sqlParameterCollection.Add(new MySqlParameter(nomeParametro, valorParametro));
    }
    public object ExecutarManipulacao(CommandType commandType, string nomeStoredProcedureOUTextSql)
    {
        MySqlConnection sqlConnection = CriarConexao();
        try
        {
            sqlConnection.Open();
            using (MySqlCommand sqlcommand = sqlConnection.CreateCommand())
            {
                sqlcommand.CommandType = commandType;
                sqlcommand.CommandText = nomeStoredProcedureOUTextSql;
                sqlcommand.CommandTimeout = 7200;
                foreach (MySqlParameter sqlParameter in sqlParameterCollection)
                {
                    sqlcommand.Parameters.Add(new MySqlParameter(sqlParameter.ParameterName, sqlParameter.Value));
                }
                return sqlcommand.ExecuteScalar();

            }
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);

        }
        finally
        {
            sqlConnection.Close();
        }
    }
    public DataTable ExecutarConsulta(CommandType commandType, String nomeStoredProcedureOuTextSql)
    {
        MySqlConnection sqlConnection = CriarConexao();
        try
        {
            sqlConnection.Open();
            DataTable datatable = new DataTable();
            using (MySqlCommand sqlcommand = sqlConnection.CreateCommand())
            {
                sqlcommand.CommandType = commandType;
                sqlcommand.CommandText = nomeStoredProcedureOuTextSql;
                sqlcommand.CommandTimeout = 7200;
                foreach (SqlParameter sqlParameter in sqlParameterCollection)
                {
                    sqlcommand.Parameters.Add(new SqlParameter(sqlParameter.ParameterName, sqlParameter.Value));
                }
                MySqlDataAdapter sqlDataAdapter = new MySqlDataAdapter(sqlcommand);
                sqlDataAdapter.Fill(datatable);
            }
            return datatable;
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
        finally
        {
            sqlConnection.Close();
        }


    }

}