# SAMP.NET
C# / .NET bindings for SA:MP

## About
This is an archive of a project I wrote back in my college days in 2012. It introduced .NET bindings for the SA:MP Pawn API. As such, the code is not up to standards that I feel are "good" these days, and much of this project was a learning experiment.

I have zero intention to ever continue this project, but this repository shall be public, read-only, and archived, for the forseeable future. I am hoping someone may benefit from this.

## How it works
SA:MP gamemodes are written in an extremely primitive language called Pawn. While Pawn is not very powerful, it does allow you to call into native code. The way this project works is Pawn will hook SA:MP events and functions, call into C++ code, which then itself uses Mono to invoke .NET methods - essentially giving you the ability to write gamemodes in C# / VB / any .NET language.
