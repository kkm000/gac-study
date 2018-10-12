using System;
using System.IO;
using System.Reflection;
using static System.Console;

class Program {
  static Program() {
    WriteLine("=== Assemblies already loaded in the AppDomain ===");
    foreach (var asm in AppDomain.CurrentDomain.GetAssemblies())
      WriteLine($"  {asm.FullName}");
    WriteLine("--------------------------------------------------");

    var myPath = Assembly.GetExecutingAssembly().ManifestModule.FullyQualifiedName;
    var asmpath = Path.GetFullPath(Path.Combine(myPath, "../Strong.dll"));
    var a = Assembly.LoadFrom(asmpath);
    WriteLine( $"Preload attempt  : {asmpath}");
    WriteLine($@"Preloaded        : {
      a.ManifestModule.FullyQualifiedName} ({
      a.ManifestModule.ModuleVersionId})");
  }

  static void Main(string[] args) {
#if !DONT_EVEN_CALL
    var inst = new StrongType();
    WriteLine($@"
Instance says   : {inst.Variant}
Its assembly is : {inst.MyAssy}
Maifest module  : {inst.MyAssy.ManifestModule.FullyQualifiedName}
Maifest MVID    : {inst.MyAssy.ManifestModule.ModuleVersionId}
");
#endif
  }
};
