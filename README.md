# IT2030Fall2023EdwardMalyovany. LAB 7,9,11,14,16

**LAB 7:** In Lab 7, I was tasked with creating a product page that displays product information, including the product name, price, and description. The page also featured navigation options to return to the home page and view more details about each product. Despite encountering several errors and bugs during this lab, I successfully completed it. 
       Notably, this project marked my initial exposure to Razor syntax.

**LAB 9:** Lab 9 revolved around working with tools and frequently asked questions (FAQs). It presented me with the opportunity to delve into session state management for the first time, making it a valuable learning experience.

**LAB 11:** In Lab 11, we introduced a new "Events" tab that showcased upcoming events and provided information on how to participate in them.

**LAB 14:**  I had a lot of problems with this lab. I had to start over and follow every step precisely and debug all my errors and I still contact view ProductDB and ContactDB. I believe it might have been since I use VSC as my IDE.

**LAB 16:**
1.  I learned the following three key concepts:

       1. Model-View-Controller (MVC) Architecture: Helps in creating organized web applications by separating data (Model), user interface (View), and user interactions (Controller).
       2. Routing and URL Mapping: I gained knowledge in configuring clean and user-friendly URLs by defining custom routes and handling parameters effectively in ASP.NET Core MVC.
       3. Middleware and Dependency Injection: I understood the use of middleware for tasks like authentication and error handling, along with the importance of dependency injection for creating modular and testable components in ASP.NET Core development.

2. Three features that I could add to my web application would be:

       1. Since my webpage is all about hiking, I could integrate a hiking and weather API to locate local hiking trails and provide nearby weather information.
       
       2. If this were a real webpage, I would need to consider that it should be global. One thing I would add is support for different languages and compliance with ADA accessibility standards.
       
       3. Create a user profile dashboard where users can view their hiking statistics and progress over time.
       
       I added the first one. I did not use an API for this. I used an external application where you can find trails near you. I added a "Find Trails Near Me" option that redirects users to another application where they can discover hiking trails in their vicinity. The code for this feature can be found in the layout.cshtml file.


4. Style Changes (All changes done in WWWROOT/CSS/CUSTOM.CSS)

       1. Made NAV Bar/Header Dark Green: The header's color was updated to a dark green to align with the hiking theme.
       
       2. Changed NAV Bar Font: The font of the navigation bar was modified to Arial.
       
       3. Text Transform: The text-transform property was applied to capitalize all navigation items.
       
       4. Hover Color and Background: On hover, the link color transitions to a lighter green (#ddf2d8), and a subtle white background emerges, with smooth transitions for both color and background.
