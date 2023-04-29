
using System.Reflection;

AppDomain domain = AppDomain.CurrentDomain;
Console.WriteLine($"Name:\t{domain.FriendlyName}");
Console.WriteLine($"Base Dir:\t{domain.BaseDirectory}");
Console.WriteLine();

Assembly[] assemblies = domain.GetAssemblies();
foreach (Assembly assembly in assemblies)
    Console.WriteLine(assembly.GetName().Name);