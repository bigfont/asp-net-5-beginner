
# Unified Controllers

The unification includes: 

* the base class
* the routes

## The Base Class

Controller

    public MyController : System.Web.MVC.Controller
    {}

Web Api Controller

    public MyController : System.Web.Http.ApiController
    {}

Unified Controller

    public MyController : Microsoft.AspNet.Mvc.Controller
    {
        public IActionResult MyAction() 
        {}
    }

## The Routes

Both Controllers and ApiControllers supported defining routes by convention and by attributes. Convention based routes let us define a set of route patterns (or conventions) in our Startup class using the `RouteCollection` class. Attribute based routes let us define routes on our controllers and actions by using the `RoutePrefixAttribute` and `RouteAttribute` respectively. Both methods of defining routes added them to the static `RouteTable.Routes` collection.

There were two differences. One difference was the ApiController support of a RESTful convention. Prefixing an ApiController Action with an HTTP verb prefix such as `GetMovie()` or `PutMovie()` would be enough to expose that Action to a GET or PUT at a `MovieController`. A second difference was that despite the similarities, separate teams at Microsoft wrote separate code for the Controller routing and ApiController routing.

With ASP.NET 5 

* MVC and Web Api share a routing code base. There is no difference in routing implementation or feature set.
* MVC comes with automatic default routes. The `{controller}/{action}/{id}` route is part of the framework.
* Convention and attribute routing are both available and both provide options for contraints and parameters.
* Routes do not need MVC. We can create a custom implementation of `IRouter`.

Sources

http://stephenwalther.com/archive/2015/02/24/top-10-changes-in-asp-net-5-and-mvc-6