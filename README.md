# MauiBasicsAndXAML

This week was supposed to be a short introdcution to the basic components of XAML that exist and are commonly used in MAUI.
I accomplished that goal in record time, maybe about 3 hours.
What took up the rest of my time was getting a MAUI app to run on physical devices, something called publishing.

### Lessons
The main lesson to take away from this week is to always use .NET 7.0 instead of .NET 6.0
While 6 is listed as LTS or long term support, that is not the case in MAUI, currently support for 6.0 is being phased out for 7.0
This added another knot in my plans to publish my app, because 6.0 apps have lots of trouble building and packaging.

Getting the .apk file for an android device was simple, just a settings tweak learned by following the docs
Getting the .pkg file for a mac was much worse. For starters, it has to be compiled on a mac device, something it does not share with android. That mac also has to have all the relevant installations including xCode and up to date .NET installations.

Nevertheless, I did eventually get it. I look foward to seeing how to run an app on an IOS device, and what sort of struggle that will be.

#### Important Sources

https://www.youtube.com/watch?v=CMyyImzULZk - A video where I got the majority of the component syntax from
https://learn.microsoft.com/en-us/dotnet/maui/ - the .NET MAUI docs. You can go under deployment, then publish, then your platform to find instructions on how to publish an app on any supported platform.
