
# ASP.NET Core Choice Points

ASP.NET Core provides us with choices. Here are most of them.

## Middleware

* ASP.NET Core Middleware (not equal to Katana Middleware)
* OWIN Middleware

The two middlewares can live side-by-side in the same application (especially when we're using ASP.NET Hosting.)

## Dev Tooling

* Command Line Interface with a text editor (Vim, Sublime, Visual Studio Code...)
* Visual Studio 2015

Visual Studio works on in Windows while Visual Studio Code works also on Linux and OSX.

## Runtime / Framework / Operating System / Hosting / Server

The remaining choices fit nicely into a grid. 

```
DNX                   clr                  mono                coreclr

Framework             .NET Framework       Mono                .NET Core            

Operating System      Windows              Windows             Windows
                      -                    Ubuntu              Ubuntu
                      -                    Debian              Debian
                      -                    Mac                 Mac
                      -                    Docker              Docker
                      -                    CentOS              CentOS (soon)
                      -                    Fedora              Fedora (soon)

Hosting               IIS                  ?                   ASP.NET Host
                      -                    ?                   OWIN Host 
                      
Server                IIS                  ?                   Kestrel (behind IIS or NGINX)
                                                               OWIN Server (e.g. Nowin)
```