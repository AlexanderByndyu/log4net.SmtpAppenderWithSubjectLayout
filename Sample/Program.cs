namespace Sample
{
    using log4net;
    using log4net.Config;

    internal class Program
    {
        private static void Main(string[] args)
        {
            XmlConfigurator.Configure();
            ILog logger = LogManager.GetLogger("logger");
            logger.Error("Some error");
        }
    }
}