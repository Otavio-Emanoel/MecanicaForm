using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace MecanicaForm
{
    /// <summary>
    /// Inicializa o banco MySQL ao iniciar o app: cria o database e as tabelas se não existirem.
    /// Configuração via variáveis de ambiente (recomendado) ou padrões locais:
    ///  - MYSQL_HOST (padrão: localhost)
    ///  - MYSQL_PORT (padrão: 3306)
    ///  - MYSQL_USER (padrão: root)
    ///  - MYSQL_PASSWORD (padrão: vazio)
    ///  - MYSQL_DATABASE (padrão: mecanica_db)
    /// </summary>
    internal static class DatabaseInitializer
    {
        private static string Host => Environment.GetEnvironmentVariable("MYSQL_HOST") ?? "localhost";
        private static string Port => Environment.GetEnvironmentVariable("MYSQL_PORT") ?? "3306";
        private static string User => Environment.GetEnvironmentVariable("MYSQL_USER") ?? "root";
        private static string Password => Environment.GetEnvironmentVariable("MYSQL_PASSWORD") ?? "";
        private static string Database => Environment.GetEnvironmentVariable("MYSQL_DATABASE") ?? "mecanica_db";

        // Conexão sem database para criar o schema
        private static string ServerConnectionString =>
            new MySqlConnectionStringBuilder
            {
                Server = Host,
                Port = uint.TryParse(Port, out var p) ? p : 3306,
                UserID = User,
                Password = Password,
                SslMode = MySqlSslMode.Disabled,
                AllowUserVariables = true,
                DefaultCommandTimeout = 15,
                ConnectionTimeout = 10
            }.ConnectionString;

        // Conexão já apontando para o database
        internal static string AppConnectionString =>
            new MySqlConnectionStringBuilder
            {
                Server = Host,
                Port = uint.TryParse(Port, out var p) ? p : 3306,
                UserID = User,
                Password = Password,
                Database = Database,
                SslMode = MySqlSslMode.Disabled,
                AllowUserVariables = true,
                DefaultCommandTimeout = 15,
                ConnectionTimeout = 10
            }.ConnectionString;

        public static void EnsureDatabaseAndTables()
        {
            try
            {
                // 1) Criar database se não existir
                using (var conn = new MySqlConnection(ServerConnectionString))
                {
                    conn.Open();
                    using var cmd = conn.CreateCommand();
                    // Usa collation compatível com MySQL 5.7/MariaDB
                    cmd.CommandText = $"CREATE DATABASE IF NOT EXISTS `{Database}` CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci";
                    cmd.ExecuteNonQuery();
                }

                // 2) Criar tabelas se não existirem
                using (var conn = new MySqlConnection(AppConnectionString))
                {
                    conn.Open();
                    using var cmd = conn.CreateCommand();

                    // Tabela base correspondente aos campos do InserirForm
                                        cmd.CommandText = @"
                        CREATE TABLE IF NOT EXISTS registros (
                          Id INT AUTO_INCREMENT PRIMARY KEY,
                          Responsavel VARCHAR(100) NOT NULL,
                          Nome VARCHAR(200) NOT NULL,
                          Valor DECIMAL(10,2) NULL,
                          Detalhes TEXT NULL,
                          Tipo VARCHAR(20) NOT NULL,
                                                    CriadoEm TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP
                                                ) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;";
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                // Mostra uma mensagem amigável e permite continuar com a aplicação (sem DB)
                MessageBox.Show(
                    "Não foi possível inicializar o banco de dados MySQL.\n" +
                    "Verifique se o servidor MySQL está em execução e as credenciais estão corretas.\n\n" +
                    $"Host: {Host}:{Port}\nUsuário: {User}\nDatabase: {Database}\n\n" +
                    $"Detalhes: {ex.Message}",
                    "Erro ao inicializar banco",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}
