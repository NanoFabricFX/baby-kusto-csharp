﻿// See https://aka.ms/new-console-template for more information
using KustoExecutionEngine.Core;

var query = @"
MyTable
| where a > 1
| summarize by a
";

var playground = new ParserPlayground();

playground.DumpTree(query);


var engine = new SterlingEngine();
engine.Evaluate(query);


Console.WriteLine("Done");
