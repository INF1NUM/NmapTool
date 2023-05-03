// See https://aka.ms/new-console-template for more information
using NmapTool;

var result = NmapReport.Read(args[0]);

Console.WriteLine(result.args);