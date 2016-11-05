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
using CommandLine;
using CommandLine.Text;

namespace NewApp.CommandLine
{
    /// <summary>
    ///     see http://commandline.codeplex.com/
    ///     see https://github.com/gsscoder/commandline/wiki
    /// </summary>
    internal class CommandLineOptions
    {
        [Option('t', "test", HelpText = "Pass a string to print to command line")]
        public string TestOption { get; set; }

        // examples
        //[Option(null, "lenght", DefaultValue = -1, HelpText = "The maximum number of bytes to process.")]
        //public int MaximumLenght { get; set; }

        //[Option("v", null, HelpText = "Print details during execution.")]
        //public bool Verbose { get; set; }


        [HelpOption]
        public string GetUsage()
        {
            return HelpText.AutoBuild(this,
                (HelpText current) => HelpText.DefaultParsingErrorsHandler(this, current));
        }
    }
}