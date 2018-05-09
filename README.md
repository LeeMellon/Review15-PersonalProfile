# Phake Pholio

Phake Pholio is a C#/.NET bog/portfolio exercise done for Epicodus bootcamp. It incorporates the built-in ASP.NET Core nav bar, AJAX routing and requests, Entity Framework Code-First SQL database, user authentication, and customised registration, and custom CSS.



## Current Functionality

* Login/Logout
* Write blog posts and incorporate images.
* Useres can respond to blog posts. 
* Add photos to custom photo library.
* About Section.
* Contact Section.
* AJAX Routing .
* Entity Framework code first SQL databse.

## Future Functionality

* User Rolls
* API calls
* Better CSS/Design



## Database Setup

In the *appsettings.json* file look for *DefaultConnection*. Here you will find the name for the database which is currently *portfolio* want to make changes to the database name, and more importantly the password and user id this is where you would do that.

Install and run MAMP which can be found here

Documentation can be found here

Launch MAMP, click on preferences and under the Ports tab, set the MySql port to 8889.

From the terminal go into the root folder of your project directory and navigate to the folder that contains your .csproj file, and type: dotnet ef database update.

From here you database should be up and running and ready for you to add the products you create.


## Known Bugs
Everything at this point is a feature.

## Repository Info
[Click here to go to the git repository](https://github.com/LeeMellon/Review15-PersonalProfile)

## License Information
MIT License

Copyright (c) 2018 Ian Goodrich

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.