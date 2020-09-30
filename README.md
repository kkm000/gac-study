# gac-study

I, kkm, the author, dedicate this repository to the public domain. Use it
however you want.

### A study of order of assembly resolution on Mono vs. Windows

I wrote this sample to diagnose a tricky issue with the differences of loading
strong-named assemblies between .NET Framework and Mono on windows. The
solution builds a strong-named assembly, and a main program that is loading it.

There are three solution configurations, called `GAC`, `NonGAC` and `DontCall`.
The differences are:
* `DontCall`: The preprocessor symbol  `DONT_EVEN_CALL` defined during 
  compilation of the main program. The assembly is not accessed in this case.
* `GAC`: the `GAC_VERSION` is defined when compiling the assembly. It does not
  put the assembly into the GAC; use the gacutil for that. Only the static
  string member message in the class in the library is affected, so that you
  can see which library you nave loaded (if, of course, you put the `GAC`
  build in the `GAC`, and do not put the `NonGAC` build there. There is not
  any embedded accident protection).
  
Unfortunately, I do not remember what the problem was and how this helped me.
If the unlikely case you find it useful, please do.

I'm disabling "Issues", as there can be none by definition, but PRs are open,
so please extend it if you're adding checks or output fighting some tricky
GAC-realted bug.

Wiki is open for editing by anyone. Feel free to put any related notes there.
