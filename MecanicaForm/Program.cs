namespace MecanicaForm
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            // Inicializa e garante a existência do banco MySQL e suas tabelas
            DatabaseInitializer.EnsureDatabaseAndTables();
            Application.Run(new SplashForm());
        }
    }
}