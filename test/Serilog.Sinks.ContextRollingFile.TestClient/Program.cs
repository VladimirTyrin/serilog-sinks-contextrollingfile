namespace Serilog.Sinks.ContextRollingFile.TestClient
{
    class Program
    {
        static void Main(string[] args)
        {
            var logger = new LoggerConfiguration()
                .WriteTo.ContextRollingFile("{Context:l}.txt")
                .CreateLogger();

            logger.Information("This logs to the {Context} context", "Foo");
            logger.Information("This logs to the {Context} context", "Bar");
        }
    }
}
