using System;
using System.Data;
using MySqlConnector;

namespace WinFormsApp2
{
    public static class Db
    {
        private const string ConnectionString =
            "Server=cfif31.ru;Database=ISPr25-24_KuzminAO_exam_pipeline_inspection_db;User=ISPr25-24_KuzminAO;Password=ISPr25-24_KuzminAO;";

        public static DataTable QueryTable(string sql, params MySqlParameter[] parameters)
        {
            using var conn = new MySqlConnection(ConnectionString);
            using var cmd = new MySqlCommand(sql, conn);
            if (parameters != null) cmd.Parameters.AddRange(parameters);

            var da = new MySqlDataAdapter(cmd);
            var dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public static object Scalar(string sql, params MySqlParameter[] parameters)
        {
            using var conn = new MySqlConnection(ConnectionString);
            using var cmd = new MySqlCommand(sql, conn);
            if (parameters != null) cmd.Parameters.AddRange(parameters);

            conn.Open();
            return cmd.ExecuteScalar();
        }

        public static void Exec(string sql, params MySqlParameter[] parameters)
        {
            using var conn = new MySqlConnection(ConnectionString);
            using var cmd = new MySqlCommand(sql, conn);
            if (parameters != null) cmd.Parameters.AddRange(parameters);

            conn.Open();
            cmd.ExecuteNonQuery();
        }
    }
}
