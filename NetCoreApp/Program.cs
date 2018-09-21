using CommandLine;
using System;
using NetCoreLibrary;
using System.Diagnostics;

namespace NetCoreApp
{
    class Program
    {
        static void PrintOptions(Options opts)
        {
            DoSomethingUseful dsu = new DoSomethingUseful();
            dsu.Organization = opts.Organization;
            dsu.ProjectName = opts.ProjectName;
            Debug.WriteLine(dsu.ToString());
        }

        static void Main(string[] args)
        {
            var result = Parser.Default.ParseArguments<Options>(args)
                .WithParsed<Options>(opts => PrintOptions(opts));
        }
    }
}
