
# OWIN, Where Does It Fit?

OWIN inspired Katana. Katana inspired ASP.NET Core. MSFT will continue to support both OWIN and Katana and will focus most future development on ASP.NET Core.

MSFT liked OWIN's philosphy. OWIN brought a lean, modular HTTP pipeline, which contrasted against the monolithic, entangled `System.Web` pipeline. OWIN also decoupled the application from the server, which contrasted against the tight integration of `System.Web` and IIS. While appreciating the benefits, MSFT found OWIN's specification to be more low-level (and thereby complex) than most developers wanted. The solution: build Katana at a higher level of abstraction while keeping OWIN's benefits. Katana has evolved into ASP.NET Core.

In some sense, ASP.NET Core replaces OWIN while continuing to support it. ASP.NET Core has its own middleware abstractions. They are not OWIN middleware; rather, they are an evolution of Katana's middleware. ASP.NET Core also has its own self-hosting. It is not OWIN hosting; it is an evolution of the self-hosting possible with Katana. At the middleware level, we can choose to use ASP.NET Core Middleware, to use OWIN middleware or to use both in the same running application. At the hosting level, we can choose to run our application with the ASP.NET Core hosting or the OWIN hosting.

While ASP.NET Core pushes ito the future, in ASP.NET 4.x Katana middleware continues to exist alongside `System.Web`. This hybrid pipeline lets ASP.NET 4.x developers augment the `System.Web` pipeline with Katana middleware. In this way, Katana is an adapter. It lets developers connect Katana middleware, such as ASP.NET Identity, into an application that uses Web Forms and IIS.

ASP.NET Core middleware is an evolution of Katana middleware. While both will continue development, they will not be automatically compatible. Middleware for Katana will not automatically fit into the ASP.NET Core pipeline, and the ASP.NET Core middleware will not automatically fit into the Katana pipeline. If a team develops middleware for Katana, they will have to manually port it to ASP.NET Core and vice versa. 

OWIN inspired Katana. Katana evolved into the ASP.NET Core stack. While Microsoft will continue to support OWIN, the expectation is that most development will choose ASP.NET Core middleware and hosting.