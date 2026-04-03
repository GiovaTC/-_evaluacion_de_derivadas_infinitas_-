using System;
using Oracle.ManagedDataAccess.Client;

class Program
{
    double numerador = 5;
    double denominador = 0.0000001;

    public string Resultado => DerivadaEvaluator.Evaluar(numerador, denominador);

    public void Guardar(string funcion, double punto, string derivada, string resultado)
    {
        string connectionString = "User Id=system;Password=Tapiero123;Data Source=localhost:1521/orcl";
        using var conn = new OracleConnection(connectionString);
        conn.Open();

        using var cmd = new OracleCommand("INSERTAR_DERIVADA", conn);
        cmd.CommandType = System.Data.CommandType.StoredProcedure;

        cmd.Parameters.Add("P_FUNCION", funcion);
        cmd.Parameters.Add("P_PUNTO", punto);
        cmd.Parameters.Add("P_DERIVADA", derivada);
        cmd.Parameters.Add("P_RESULTADO", resultado);

        cmd.ExecuteNonQuery();
    }
    static void Main()
    {
        Program program = new Program();
        Console.WriteLine($"Resultado: {program.Resultado}");
    }

}