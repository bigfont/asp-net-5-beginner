# The History of ASP.NET [Shaun]

This will be in slides, hosted in Office 365

* Web Forms
* MVC
* ASP.NET Core

# Anatomy of a Project [Shaun]

    New Project > ASP.NET 5 MVC

This is what you get out of the box... it's a familiar albeit different experience. What are all of these things?

    project.json
    config.json
    projectName.xproj
    wwwroot
    etc

# Let's build this up [Anthony]

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
    
# Pre-built solution

A kitchen sink application to show a few extra features if there is time, or use as an aid when answering questions.

* ASP.NET + MVC
* Class library
* Unit tests
* Client side packages with NPM or Bower
* Gulp/grunt for copying assets to wwwroot (and bundle/minify?)
* Custom tag helper
* Entity Framework? (probably not)

# .NET Framework Publish Options [Optional]

    ASP.NET 5
        Full Framework (MSFT)
        Full Framework (Mono)
        Core (MSFT)

# Other Optional Topics / Ideas

* Client side resource building using Node.js
* Publish to a USB stick and run on Mac.
* Or commit project to github and pull it back down on a Mac to edit/run
* Other?
