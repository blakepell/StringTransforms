String Transforms ASP.Net Core / Vue Site
=========================================

This is a sample ASP.Net Core site and Vue application to execute various string transforms via C#.  The list of transforms are dynamically included via reflection so that no additional plumbing needs to be created when a new transform is added.

Note: The build will currently fail due to a private NuGet package that is in use for various utility methods.  This library will be factored out with the code included here.