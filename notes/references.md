# References

http://www.somelink.com

> Quote... [non-quoted part]

> Quote...

http://programmers.stackexchange.com/questions/44810/relationship-between-c-net-asp-asp-net-etc

> ASP.NET is the portion of the .NET library used for making web sites.

https://msdn.microsoft.com/en-us/vstudio/aa496123

> .NET is a general purpose development platform for any kind of app or workload, providing key capabilities for building high quality apps including automatic memory management and support for modern programming languages.

> .NET Core is a set of runtime, library and compiler components that allow you to create apps that run on Windows, Mac OS X and Linux.

https://msdn.microsoft.com/library/hh425099.aspx

> The .NET Framework is a runtime execution environment that manages applications that target the .NET Framework. It consists of the common language runtime... and an extensive class library...

> It consists of two major components: the common language runtime (CLR)... and the .NET Framework Class Library...

> The services that the .NET Framework provides to running applications include the following: Memory management... A common type system... An extensive class library... such as ASP.NET for web applications... Development frameworks and technologies... Language interoperability... Version compatibility... Side-by-side execution... Multitargeting...

> ...if you install an application that requires the .NET Framework, the application's setup program might install a specific version of the .NET Framework on your computer.

> Because the .NET Framework provides language independence and interoperability, you can interact with other .NET Framework applications and components regardless of the language with which they were developed.

https://msdn.microsoft.com/en-us/library/zw4w595w.aspx

> The .NET Framework is designed to fulfill the following objectives: ... To make the developer experience consistent across widely varying types of applications, such as Windows-based applications and Web-based applications.

> The .NET Framework consists of the common language runtime and the .NET Framework class library.

> **The common language runtime** is the foundation of the .NET Framework. You can think of the runtime as an agent that manages code at execution time, providing core services such as memory management, thread management, and remoting, while also enforcing strict type safety and other forms of code accuracy that promote security and robustness. In fact, the concept of code management is a fundamental principle of the runtime. **Code that targets the runtime is known as managed code, while code that does not target the runtime is known as unmanaged code.** [emphasis added]

> **The class library** is a comprehensive, **object-oriented collection of reusable types** that you can use to develop applications...

> The .NET Framework can be hosted by unmanaged components that load the common language runtime into their processes and initiate the execution of managed code... The .NET Framework... provides several runtime hosts... [and] supports the development of third-party runtime hosts. For example, **ASP.NET hosts the runtime**... Internet Explorer is an example of an unmanaged application that hosts the runtime... the runtime can be hosted by high-performance, server-side applications, such as Microsoft SQL Server and Internet Information Services (IIS)

> Features of the Common Language Runtime: manages memory, thread execution, code execution, code safety verification, compilation... trust... code access security... a strict type-and-code-verification infrastructure called the common type system (CTS)... interoperability... just-in-time (JIT) compiling enables all managed code to run in the native machine language of the system on which it is executing

> The .NET Framework class library is a collection of reusable types that tightly integrate with the common language runtime. .NET Framework types enable you to accomplish a range of common programming tasks, including tasks such as string management, data collection, database connectivity, and file access. In addition to these common tasks, the class library includes types that support a variety of specialized development scenarios. Console applications... Windows GUI applications... Windows Presentation Foundation... ASP.NET applications... Windows services... Windows Communication Foundation... Windows Workflow Foundation...

https://msdn.microsoft.com/en-us/library/gg145045%28v=VS.110%29.aspx

> .NET Framework Class Library [include but are not limited to] System... System.Collections... System.Linq... System.Net... System.Text... System.Web [for ASP.NET development]... System.Windows... System.Xml...

http://blogs.msdn.com/b/dotnet/archive/2014/12/04/introducing-net-core.aspx

> In this post, I’ll provide an overview of .NET Core, how we’re going to release it, how it relates to the .NET Framework, and what this means for cross-platform and open source development.

> [Motivating .NET Core] When we originally shipped the .NET Framework in 2002 there was only a single framework. Shortly after, we released the .NET Compact Framework which was a subset of the .NET Framework that fit within the footprint of smaller devices... The compact framework was a separate code base from the .NET Framework. **It included the entire vertical: a runtime, a framework, and an application model on top.** Since then, we’ve repeated this subsetting exercise many times: Silverlight, Windows Phone and most recently for Windows Store. This yields to fragmentation because the .NET Platform isn’t a single entity but a set of platforms, owned by different teams, and maintained independently. ...it becomes a problem if there is no systematic approach and specialization happens at every layer with little to no regards for corresponding layers in other verticals. The outcome is a set of platforms that only share APIs by the fact that they started off from a common code base. What is the problem with fragmentation? If you only target a single vertical then there really isn’t any problem. **The problem arises as soon as you want to target the horizontal, that is multiple verticals.** Now you have to... produce assets that work across the verticals you want to target. Today it’s extremely common to have applications that span devices: ... a back end that runs on the web server, ... an administrative front end that uses the Windows desktop, and a set of mobile applications... available for multiple devices. Thus, it’s critical to support developers in building components that can span all the .NET verticals.

> [Portable Class Libraries] Originally, the .NET Framework was designed around the assumption that it’s always deployed as a single unit, so factoring was not a concern. The very core assembly that everything else depends on is mscorlib. The mscorlib provided by the .NET Framework contains many features that that can’t be supported everywhere... **This forces each vertical to subset even the very core of the platform.** This made it very complicated to tool a class library experience that lets you target multiple verticals. We’re using contracts to model API sets across all verticals. The verticals can then simply pick and choose which contracts they want to support. **The important aspect is that verticals must support a contract either wholesale or not at all.** In other words, they can’t subset the contents of a contract. This allows reasoning about the API differences between verticals at the assembly level, as opposed to the individual API level that we had before. This aspect enabled us to provide a class library experience that can target multiple verticals, also known as portable class libraries. [In other words, shared class libraries are assemblies that work accross multiple verticles.]

> [Portable class libraries share contracts across verticles.] However, we still have different implementations – or forks – of the .NET platform. [An] ongoing challenge [is that] APIs are only portable when the implementation is moved forward [simultaneously] across all the verticals but... that’s... expensive and...subject to (re-)prioritization. **A much better approach is unifying the implementations:** instead of only providing a well factored view, we should provide a well factored implementation. This would allow verticals to simply share the same implementation.

> Another interesting challenge has to do with how the .NET Framework is deployed. **The .NET Framework is a machine-wide framework.** Any changes made to it affect all applications taking a dependency on it. Having a machine-wide framework was a deliberate decision because it solves those issues: ... centralized servicing, reduces the disk space, allows sharing native images between applications. [It] also comes with a cost. For one, **it’s complicated for application developers to take a dependency on a recently released framework.** You either have to take a dependency on the latest OS or provide an application installer that is able to install the .NET Framework when the application is installed. If you’re a web developer you might not even have this option as the IT department tells you which version you’re allowed to use. And if you’re a mobile developer you really don’t have choice but the OS you target. ...even if you’re willing to go through the trouble of providing an installer in order to chain in the .NET Framework setup you may find that upgrading the .NET Framework can break other applications. **[To prevent compatibilities problems], it takes us a while to release a new version of the .NET Framework.** [We have] started to ship libraries on NuGet. Since we didn’t add those libraries to the .NET Framework we refer to them as "out-of-band". Out-of-band libraries don't suffer from the problem we just discussed because they are application-local... the libraries are deployed as if they were part of your application. [In other words, the machine-wide deployment of .NET slowed down release updates.]

> All these aspects caused us to rethink and change the approach of modelling the .NET platform moving forward. This resulted in the creation of .NET Core: .NET Core is a modular implementation that can be used in a wide variety of verticals, scaling from the data center to touch based devices, is available as open source, and is supported by Microsoft on Windows, Linux and Mac OSX.

> Unified implementation for .NET Native and ASP.NET [Though] the scenarios of .NET Native (touch based devices) and ASP.NET 5 (server side web development) are quite different, we were able to provide a unified Base Class Library (BCL). [Both essentially merge the framework with the application and shake-the-tree to minimize the size of the framework that ships along with the application.] The API surface area for the .NET Core BCL is identical for both .NET Native as well ASP.NET 5. At the bottom of the BCL we have a very thin layer that is specific to the .NET runtime. We’ve currently two implementations: one is specific to the .NET Native runtime and one that is specific to CoreCLR, which is used by ASP.NET 5. [The] APIs don’t just look the same – they share the same implementation. On top of the BCL, there are app-model specific APIs. For instance, the .NET Native side provides APIs that are specific to Windows client development, such as WinRT interop. ASP.NET 5 adds APIs such as MVC that are specific to server- side web development. [See image dotNetNativeAndAspDotNet.png] **We think of .NET Core as not being specific to either .NET Native nor ASP.NET 5 – the BCL and the runtimes are general purpose and designed to be modular. As such, it forms the foundation for all future .NET verticals.**

> In contrast to the .NET Framework, the .NET Core platform will be delivered as a set of NuGet packages... it's a set of fine grained NuGet packages. For the BCL layer, we’ll have a 1-to-1 relationship between assemblies and NuGet packages... the NuGet package will have the same name as the assembly... the version number will align with the assembly version. [This has four advantages: NuGet package discovery, partial updates to Base Class Library assemblies, management of 1st and 3rd party dependencies, and avoidance of compatibiity bugs by keeping the framework app-local.]

> Enterprise ready... notion of a .NET Core distribution [that is] Microsoft tested. Distributions will not have [a package compatibility] problem because all components [of the distribution] are tested in combination. [Microsoft will ship distributions about four times a year. This is less frequent than the package shipping is. So, we will have two options: install .NET Core from NuGet packages or from a distribution.] 

> TODO Foundation for open source and cross platform

> TODO .NET Framework 4.6

> TODO Mono

> TODO Windows Store & Windows Phone

> TODO Sharing code between .NET Core and other .NET platforms

http://docs.asp.net/en/latest/conceptual-overview/aspnet.html

http://www.hanselman.com/blog/ASPNET5AndNETCoreRC1InContextPlusAllTheConnect2015News.aspx

https://en.wikipedia.org/wiki/.NET_Framework

http://www.asp.net

http://windowsitpro.com/networking/build-your-own-web-site-less-hour 

https://en.wikipedia.org/wiki/Windows_NT_3.51

https://en.wikipedia.org/wiki/Windows_NT_4.0

https://en.wikipedia.org/wiki/Internet_Information_Services

http://weblogs.asp.net/shijuvarghese/asp-net-mvc-vs-asp-net-web-form

http://weblogs.asp.net/scottgu/introducing-asp-net-5