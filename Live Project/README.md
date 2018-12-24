# MVC-Code-First-Snippets

These are snippets of my code on an MVC Code First Project, due to the nature of the project I will not be able to release its entirety here. However, I will thoroughly explain the purpose of each snippet within this README.

Synopsis of the project at hand: It's a website, or a dashboard, to help students attending The Tech Academy Bootcamp to keep track of their Job hunting progress and process. Of course, this project will have changed since I worked on it, so this code is likely out of date.

The images are screenshots of the various pages I worked on, I've added custom notes in dark boxes with white arial text and arrows.

Here is a rundown of the files (Note: the names of some files have been changed for the purpose of personal organization):

+ _Carousel.cshtml - This is a partial View. The bootstrap carousel itself was added by someone else, but it wasn't scrolling through all of the recent hires, So I added the script at the bottom to allow it slide through them all. I also replaced a lot of styling that was in this page with classes of which the details of were placed in an external styling sheet.
+ JPApplicationsController.cs This is a Controller. The View "JPApplications-StudentIndex.cshtml" is a view belonging to this controller. Within this file I added additional sorting functionality to the two new properties "Interview" and "HeardBack."
+ JPApplications-StudentIndex.cshtml - This is a View. This webpage has the task of displaying every application a student has submitted on a visual table. I made the addition of the "Interview" and "HeardBack" columns and added sorting functionality in the JPApplicationsController.
+ JPHire.cs - This is a database model, it exisited with most of its properties before I worked on it, but I added the property "JPJobType" to this, I also pushed a database migration after I had finished the task.
+ JPHires-Create.cshtml - This is a View. This webpage allowed a non-admin registered user to create a Hire for themself (Hire is a database model, and what is used to track what kinds of jobs the applicant is getting hired for) My additions was styling, the buttons needed to stay on opposite sides of the same row.
+ JPJobLeadSource.cs - This is a simple C# Enum used within the code to translate a database INT with relative ease into a part of a webpage. Specifically the Job's lead source.
+ JPStudentRundownController.cs - This is a controller. I added sorting functionality for the "Ready To Graduate" sortparm. On the View "JPStudentRundown-Index.cshtml" a list of students is displayed as well as basic contact information and work related information. There was a button on that page that already existed and I needed to add functionality to it, so I made the sorting code where it takes all students in the database and only displays them on the list if they have 35 or more applications and have all 6 items on the checklist completed (the checklist section uses a function which I did not make).
+ JPStudentRundown-Index.cshtml - I didn't work on this, I've just included it because the code from the JPStudentRundownController.cs controller was what I did work on, and that controller changes up this view.

Note: I made many other smaller changes to the project I didn't feel like they were important enough for mention here. Just simple styling changes like changing the font color of text, or resizing icons so they fit better on the page, or remain consistent with the rest of the project.