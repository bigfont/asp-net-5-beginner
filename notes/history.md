# Writeup

ASP.NET Core is the newest release of ASP.NET. It is open-source. That is because the software development community challenged Microsoft to release it as open-source, and because ASP.NET continues to meet customers’ challenges. If we want to understand something, we need to look at its history. Exploring the Core release over the past months, I have noted key challenges over time.

For those with some ASP.NET experience, here is my sense of the more important history points.

In 1980, Tim Berners-Lee starts to tinker with existing hypertext technology, in order to link together related documents at CERN. By 1991, the first web servers go online outside of CERN, to share documents over the Internet, using Berners-Lee’s technology.

In 1996, IIS 1.0 handles the heavy traffic to Microsoft.com which the EMWAC web server couldn’t manage. Later in 1996, ASP 1.0 dynamically generates web page to allow for HTML templates. Microsoft’s IIS/ASP stack is born!

In 2002, ASP.NET 1.0 harnesses the object-oriented power of the .NET Framework to manage web app complexity, and provides a familiar experience to help Windows Forms devs transition to web dev.

In 2009, ASP.NET MVC enables unit testing via separation of concerns, enhances search engine optimization via REST-based URLS, and empowers developers to write standard-compliant HTML. Developers now have an ASP.NET that is built for the Web.

In 2010, OWIN specifies how to decouple the application from the server, and paves the way for developers to run a faster, leaner ASP.NET (with or) without IIS. This in my humble opinion is the harbinger of ASP.NET Core.

In 2016, ASP.NET Core embraces the developer preference for open-source, provides abstractions that bring OWIN’s benefits while easing their use, supports cross-platform development and deployment, goes all package-based development to ease the sharing and re-use of code, unifies the stack to focus the efforts of the ASP.NET and .NET teams, (those two mean more frequent ASP.NET Core releases,) and drastically improves its performance to decrease the RAM and CPU cost of cloud hosting.

That is my (limited) understanding of the challenges that the ASP.NET team has met over the years. If you see anything that doesn’t look quite right or do not see something that I missed, let me know, and I would be happy to add it, with credit to you.

# History of ASP.NET Core

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

## 2010

[OWIN emerges][history-of-owin] to break the bonds between ASP.NET and IIS and thereby to make "fast and light-weight frameworks and servers."

## November 2015

Microsoft publishes ASP.NET Core 1.0 RC1.

1. Open source
1. Modular
1. Cross platfrom
1. Package-based development
1. Unified stack
1. Performance


[history-of-owin]: http://panesofglass.github.io/history-of-owin/#/3
[emwac]: http://windowsitpro.com/networking/build-your-own-web-site-less-hour
[forms-vs-mvc]: http://weblogs.asp.net/shijuvarghese/asp-net-mvc-vs-asp-net-web-form