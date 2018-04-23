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
        private static void Main(string[] args)
        {
            ILog _logger = LogManager.GetLogger(typeof (Program));
            TextWriter writer = Console.Out;

            try
            {
                _logger.Info("Command Line Started"); // you could delete this line ... 

                // build and configure command line parser instance
                var parser = new Parser(with => with.EnableDashDash = true);
                
                parser.ParseArguments<CommandLineOptions>(args)
                    .WithParsed(opts => RunOptions(opts))
                    .WithNotParsed(errs =>
                    {
                        // exit with error
                        _logger.Error(errs);
                        Environment.Exit(1);
                    } );

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
            if (opts.TestOption != null)
            {
                // your code here
                Console.Write(opts.TestOption);

            }
        }
    }
}