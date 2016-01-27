# History of ASP.NET Core 1.0

Dates are approximate.

## 1980

Berners-Lee starts to tinker with existing hypertext technology, to link together related documents at CERN.

## 1991

The first web servers go online outside of CERN, to share documents over the Internet. 

## 1996

Microsoft releases IIS 1.0, to replace the EMWAC web server, which can no longer handle the trafic to microsoft.com. [This article from 1995][emwac] explains how to host a website with EMWAC!

## 1996

Microsoft releases ASP 1.0, to dynamically generate web pages instead of serving only static HTML files.

## 2002

Microsoft releases ASP.NET 1.0. It provides:

1. a familiar experience for Windows developers via  Controls, View State, Postback, and Events,
1. object-oriented programming, compilation, and multi-language support by leveraging the brand new .NET Framework.

## 2009

Microsoft releases ASP.NET MVC 1.0. It provides: 

1. test-driven-development via clean separation of concerns
1. search engine optimization by using REST based URLs
1. control over the HTML by using HTML template views

ASP.NET MVC let us use the power of the .NET Framework with a development model that fits the Web. [Here is a terrific article][forms-vs-mvc] about the motivation behind MVC.

## November 2015

Microsoft publishes ASP.NET Core 1.0 RC1.

**Modular.** `System.Web.dll` has become a set of granular NuGet packages. This lets us use only the parts of it that we need instead of the entire kitchen sink. The advantages: security by reducing application surface area, maintenance by having fewer parts to update, and performance by removing unessential steps in the HTTP request pipeline. 

**Flexible hosting.** Our app can live in IIS or self-host. The advantage: Microsoft no longer has a monopoly on hosting ASP.NET applications. We can expand our hosting horizons into the world of Linux.

**Framework options.** Our app can target the .NET Framework 4.6 for a full-featured, supported framework on Windows; target Mono for the full-featured framework on Linux and Mac; or target .NET Core for side-by-side application versioning and a host of other features. The advantage: choice between three powerful options.

**NuGet shipping & support.** Shipping via NuGet packages allows Microsoft to adopt a more rapid release schedule. Microsoft has built NuGet support right into the project.json file. The advantage: faster, more granular releases.

**Unified controllers.** [TODO]

**Cloud-ready.** It includes environment-based configuration and build-in dependency injection. [Why is dependency injection considered cloud-ready?]

**Open-source.** The community can contribute, view the source, and create custom builds; Microsoft can push small changes to the source before publishing more stable releases to NuGet and before releasing a complete distribution. The advantage is better code faster.

**Client-side friendly.** This includes tooling and syntax. The advantage: client-side developers can use familiar, industry standard tools more easily; client-side standards and libraries can be more easily implemented alongside server-side instructions.

* **Tooling.** Industry standard client-side development tools such as NodeJS, Gulp, Grunt, and Bower replace Microsoft's bundling and minification.
* **Syntax.** Tag helpers replace `HtmlHelpers` to let ASP.NET code coexist more easily with other HTML attributes such as `class`, `ng-model`, and other attributes we might want to add.

**Flexible, cross-platform development.** We can develop on Mac, Linux, or Windows. The advantage: c'mon. I know soooo many people who would like to develop on a Mac.

**Command-line interface.** More choice in how we develop. While we can still use Visual Studio and its magic, we can also drop down to the command line for more fine-grained control. Some people like the command line.

**Lighter project system.** The project system is opt-in. Everthing in the projects root folder is included in the build unless we explicitly *exclude* it from the project. The advantage: a pithy project file that is easier to manage. Think version control.

[emwac]: http://windowsitpro.com/networking/build-your-own-web-site-less-hour
[forms-vs-mvc]: http://weblogs.asp.net/shijuvarghese/asp-net-mvc-vs-asp-net-web-form