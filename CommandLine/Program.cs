using System;
using System.IO;
using CommandLine;
using log4net;

namespace NewApp.CommandLine
{
    /// <summary>
    ///     Command line program "Main"
    ///     logs are both sent to the log file and in the console
    ///     This can be configured in CommandLine.Log4Net.cfg
    /// </summary>
    internal class Program
    {
        private static void Main(string[] args)
        {
            ILog _logger = LogManager.GetLogger(typeof (Program));
            TextWriter writer = Console.Out;

            try
            {
                _logger.Info("Command Line Started"); // you could delete this line ... 

                var options = new CommandLineOptions();

                if (Parser.Default.ParseArguments(args, options))
                {
                    if (options.TestOption != null)
                    {
                        // your code here
                        Console.Write(options.TestOption);
                    }


                    // exit ok
                    Environment.Exit(0);
                }
                else
                {
                    // exit with error
                    Environment.Exit(1);
                }
            }


            catch (Exception ex)
            {
                Console.SetOut(writer);
                Console.WriteLine("Error: " + ex);
            }
        }
    }
}