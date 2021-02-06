#region Copyright
//  Copyright 2016 Patrice Thivierge F.
// 
//  Licensed under the Apache License, Version 2.0 (the "License");
//  you may not use this file except in compliance with the License.
//  You may obtain a copy of the License at
// 
//     http://www.apache.org/licenses/LICENSE-2.0
// 
//  Unless required by applicable law or agreed to in writing, software
//  distributed under the License is distributed on an "AS IS" BASIS,
//  WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//  See the License for the specific language governing permissions and
//  limitations under the License.
#endregion
using System;
using System.IO;
using CommandLine;
using CommandLine.Text;
using log4net;
using NewApp.Core.Helpers;

namespace NewApp.CommandLine
{
    /// <summary>
    ///     Command line program "Main"
    ///     logs are both sent to the log file and in the console
    ///     This can be configured in CommandLine.Log4Net.cfg
    /// </summary>
    internal class Program
    {

        static ILog _logger = LogManager.GetLogger(typeof(Program));

        private static void Main(string[] args)
        {
           
            TextWriter writer = Console.Out;
            
            try
            {

                // build and configure command line parser instance
                var parser = Parser.Default;
                
                var parserResults = Parser.Default.ParseArguments<CommandLineOptions>(args)
                    .WithParsed(opts => RunOptions(opts))
                    .WithNotParsed(errs =>
                    {
                        Environment.Exit(1);
                    });

                Environment.Exit(0);
            }


            catch (Exception ex)
            {
                Console.SetOut(writer);
                Console.WriteLine("Error: " + ex);                
            }
        }

        private static void RunOptions(CommandLineOptions opts)
        {
            if (opts.RunOption != null)
            {

                _logger.Info("Command Line Started"); // you could delete this line ... 

                // your code here
                Console.Write(opts.RunOption);

            }
        }

    }
}