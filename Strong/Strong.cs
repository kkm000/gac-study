using System.Reflection;

[assembly: AssemblyTitle("Strong"),
           AssemblyVersion("1.0.0.0"),
           AssemblyFileVersion("1.0.0.0")]

public class StrongType {
  public string Variant =
#if GAC_VERSION
    "I am a version that should be in GAC.";
#else
    "I am a version NOT intended to be in GAC.";
#endif
  public Assembly MyAssy => Assembly.GetExecutingAssembly();
};

