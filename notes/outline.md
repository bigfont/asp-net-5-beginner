# Who are We?

* Hi. I am Shaun and I am a...
* Hi. I am Anthony and I am a...

# Brief History of ASP.NET [Shaun]

This will be in slides, hosted in Office 365.

* Tim Berners-Lee & EMWAC
* IIS
* ASP
* ASP.NET 1.0
* ASP.NET MVC
* OWIN
* ASP.NET Core
* See also: http://www.webnotwar.ca/opensource/release-asp-net-meets-challenge/

# Gifts: Awesome things that just work [Shaun]

This is also in slides. 

* Open source
* 2300% performance improvement.
* Command line interface. 
* Cross Platform
* Out-of-band shipping.
* Side-by-side deployment
* Built-in dependency injection
* Modular (more frequent & relevant releases - this is really part of Middleware & packages)

# Duties  & demos: Things we (developers) must learn [Shaun & Antony]

These are part slides and part demos. 

Introduction: This is what you get out of the box... it's a familiar albeit different experience. What are all of these things?

    Visual Studio > New Project > ASP.NET 5 MVC
    
      project.json
      config.json
      projectName.xproj
      wwwroot
      etc
    
After the Introduction:

    var topics = new Topic[] { Installation, ProjectSystem, NuGet, ClientSideTooling, Middleware, HostingModel };
    foreach(var t in topics)
    {
        Shaun.Present(Theory);
        Anthony.Present(Demo);
    }

# Let's build this up, no IDE [Shaun]

* With the command line and notepad, 
* Shaun will hand code a minimal ASP.NET Core project. 

# Let's build this up, with IDE [Anthony]

    New Project > Empty

Question and answer... Okay, so it says Hello World... what now?!

    Middleware / Dependency Injection
        Simple custom middleware to show pipeline
        Diagnostics
        Static Files
        Error Page
        MVC
    Configuration
        json
        environment variables
    Logging
    Unified Controllers
        Routing
        MVC
    Razor changes
        await
        dependency injection
    Tag Helpers
        HTML Helpers vs Tag Helpers
        Basic demo
        Custom Tag Helpers demo (maybe use pre-built solution for this)
        
# Optional Topics
    
## Pre-built solution

A kitchen sink application to show a few extra features if there is time, or use as an aid when answering questions.

* ASP.NET + MVC
* Class library
* Unit tests
* Client side packages with NPM or Bower
* Gulp/grunt for copying assets to wwwroot (and bundle/minify?)
* Custom tag helper
* Entity Framework? (probably not)

## .NET Framework Publish Options [Optional]

    ASP.NET 5
        Full Framework (MSFT)
        Full Framework (Mono)
        Core (MSFT)

## Misc

* Client side resource building using Node.js
* Publish to a USB stick and run on Mac.
* Or commit project to github and pull it back down on a Mac to edit/run
* Other?
