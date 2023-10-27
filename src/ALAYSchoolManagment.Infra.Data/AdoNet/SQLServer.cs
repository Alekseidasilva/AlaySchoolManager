using System.Data;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;

namespace ALAYSchoolManager.Infra.Data.AdoNet;

public class SQLServer
{
    SqlConnection PegarConexao()
    {
        var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();
        return new SqlConnection(config.GetConnectionString("SQLServerConnectionStrings"));
    }
    private readonly SqlParameterCollection _sqlParameterCollection = new SqlCommand().Parameters;
    public void LimparParametro()
    {
        _sqlParameterCollection.Clear();
    }
    public void AdicionarParametros(string nomeParametro, object valorParametro, SqlDbType SqlTipo = SqlDbType.NVarChar, string TypeName = null)
    {
        SqlParameter parameter = new SqlParameter(nomeParametro, valorParametro);
        parameter.SqlDbType = SqlDbType.Structured;
        parameter.TypeName = TypeName;
        _sqlParameterCollection.Add(new SqlParameter(nomeParametro, valorParametro));
    }
    public object ExecutarManipulacao(CommandType commandType, string nomeStoredProcedureOuTextSql)
    {
        SqlConnection sqlConnection = PegarConexao();
        try
        {
            sqlConnection.Open();
            using (SqlCommand sqlcommand = sqlConnection.CreateCommand())
            {
                sqlcommand.CommandType = commandType;
                sqlcommand.CommandText = nomeStoredProcedureOuTextSql;
                sqlcommand.CommandTimeout = 7200;
                foreach (SqlParameter sqlParameter in _sqlParameterCollection)
                {
                    sqlcommand.Parameters.Add(new SqlParameter(sqlParameter.ParameterName, sqlParameter.Value));
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
        SqlConnection sqlConnection = PegarConexao();
        try
        {
            sqlConnection.Open();
            DataTable datatable = new DataTable();
            using (SqlCommand sqlcommand = sqlConnection.CreateCommand())
            {
                sqlcommand.CommandType = commandType;
                sqlcommand.CommandText = nomeStoredProcedureOuTextSql;
                sqlcommand.CommandTimeout = 7200;
                foreach (SqlParameter sqlParameter in _sqlParameterCollection)
                {
                    sqlcommand.Parameters.Add(new SqlParameter(sqlParameter.ParameterName, sqlParameter.Value));
                }
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlcommand);
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