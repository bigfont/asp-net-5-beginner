
# What does X do? 

## Server

TODO

## .NET Executable

1. contains the compiled .NET application that a developer wrote
2. includes metadata and a list of DLL references
3. execution starts with the creation of a process
4. the Windows loader (ntdll.dll) loads the EXE into RAM
5. and handles linked library loading/addressing
6. execution passes to mscoree.dll
7. which loads the common language runtime (CLR), and
8. invokes the application managed entry point

## CLR Native Host

* start the common language runtime (CLR)
* call the managed entry point

## Common Language Runtime (CLR)

* mediate between native and managed code

## Managed entry point

* set up the loading of assemblies
* call the application entry point

## WebHostBuilder

* 

## Host (generally speaking)

* start the application
* invoke its entry point
* stop the application

## Middleware

TODO

<!-- References -->

[hosting01]: https://msdn.microsoft.com/en-us/library/ms730158%28v=vs.110%29.aspx

[net-executable01]: http://stackoverflow.com/questions/6605956/what-happens-when-a-net-application-is-started

[net-executable02]: https://msdn.microsoft.com/en-us/library/xh0859k0.aspx

[dnx01]: https://github.com/aspnet/Home/wiki/DNX-structure