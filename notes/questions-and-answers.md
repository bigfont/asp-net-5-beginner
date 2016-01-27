
# Questions and Answers

Q: What is the difference between .NET and ASP.NET?

.NET is for building all kinds of applications whereas ASP.NET is for building web applications. ASP.NET is built on and includes all of the features of .NET.

Q: Does ASP.NET use .NET?

Yes. ASP.NET is built on the .NET framework and includes all the features of .NET.

Q: What are the features of .NET?

.NET includes the Command Language Runtine (CLR), the Framework Class Library (FCL), and the Base Class Library (BLC). The CLR is executes .NET applications, the FCL includes all class libraries that ship with .NET, and the BCL is the part of the FCL that is the basic API into the CRL. 

Q: Where does ASP.NET fit in to the .NET framework. 

ASP.NET is part of the Framework Class Library. The FCL also includes LINQ, WCF, WinForms, et cetera.

```
.NET Framework
    CLR
        JIT Compiler
    FLC
        BCL
        ASP.NET        
        LINQ
        WCF
        Window Forms
        ... 
```

Q: What is .NET Core?

.NET Core is an implementation of the .NET Framework that is: free, open-source, cross-platform. It includes CoreCLR and CoreFX. 

```
.NET Core
    CoreCLR
        RyuJIT
    CoreFX
        ASP.NET 5
        .NET Native
```

Q: What is different among .NET Core and the .NET Framework

* Deploy with application vs deploy to machine. This avoids breaking changes which occur when a machine updates in .NET version.
* 

Q: How does .NET 5 differ from .NET Core, if at all?

When you hear .NET 5 you can translate this into .NET Core 5. The .NET Framework (aka the full framework) will continue development on the 4.x track whereas .NET Core will continue development on the 5.x track. 

Q: How does ASP.NET 5 differ from ASP.NET 4?

TODO

Q: Can we use .NET 5 without using ASP.NET 5?

TODO

Q: What use cases are appropriate for .NET/ASP.NET 5?

TODO

Q: What is .NET Native?

.NET Native is for mobile applications. 

Q: What motivated the creation of .NET 5?