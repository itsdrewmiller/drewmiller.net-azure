# drewmiller.net-azure
Trying to make my site on azure / .NET instead of node

## Architectural Notes

* Either I am not ready for .NET 5, or .NET 5 is not ready for me
* It is super annoying that I can't keep Entity Framework out of the web project.  I wanted to limit it to the Model library.
* Given that I have to put EF in the web project anyway, it probably isn't really valuable to have separate DTOs for things.  I should probably write a blog post about DTOs being stupid anyway.
* Maybe I should write a blog post about unit tests being stupid too.