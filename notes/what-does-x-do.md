
# What does X do?

## Summary

* A server is a *running program* that responds to client requests.
* A network host is a *physical machine* with a network address.

## Server (and HTTP server)

* A server is a daemon (waiting process)
* that performs a service for a requester (client)
* and which often runs on a computer other 
* than the one that sent the request.
* An HTTP server serves content using HTTP.
* The term server often includes the machine on which it runs, 
* though strictly speaking the machine is the host.
* https://en.wikipedia.org/wiki/Server_(computing)

## Network Host

* A network host is a physical machine
* that is connected to a network
* and that has a network address.
* It may host a server process.

## Host in MSFT Jargon

**Host Process** starts, manages, and shuts down another process.

**Runtime Host (aka Native CRL Host)** boots the CLR, calls the managed entry point, and shuts down the CLR. 

**Application Host** resolves application dependencies, ...

**ASP.NET Core Hosting Layer** 

* finds the web server on which to run, 
* finds the applications startup logic,
* hosts the application on the server,
* [what does it mean to host an application on a server?] 
* cleans up on application shutdown. 

**ASP.NET Core Hosting Model**

* Relies on an HTTP server
* that will surface each request
* as a set of feature interfaces
* that ASP.NET can compose into an `HttpContext`.

**"Host Your Application""



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
* i.e. a process, in which an application or server executes

## Middleware

TODO

<!-- References -->

[hosting01]: https://msdn.microsoft.com/en-us/library/ms730158%28v=vs.110%29.aspx

[net-executable01]: http://stackoverflow.com/questions/6605956/what-happens-when-a-net-application-is-started

[net-executable02]: https://msdn.microsoft.com/en-us/library/xh0859k0.aspx

[dnx01]: https://github.com/aspnet/Home/wiki/DNX-structure