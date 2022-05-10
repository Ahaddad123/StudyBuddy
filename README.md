How to run the system from executable file:  
1. Clone the repository 
2. Navigate to project\src\Nathan Sandvig\Study Buddy\bin\Debug 
3. Run the Studdy Buddy.exe file 

How to build and run the system using Visual Studio: 
1. Clone the repository if you haven’t already 
2. Navigate to project\src\Nathan Sandvig  
3. Open Nathan Sandvig.sln using Visual Studio 2022 
4. Build the solution 
5. Run the solution 

How to Regenerate Test Coverage Results 
1. Open the project in Visual Studio 2022 Enterprise. 
2. Build the project under Build -> Build Solution. 
3. Go to Test -> Analyze Code Coverage for All Tests 
4. Test coverage results will be shown in the Code Coverage Results window. 

Known Bugs:
Our system has no known bugs. 

Known Design Deficiencies: 
The Presentation folder is organized into three MVC subfolders.  Each form represents the view, and each view has a corresponding controller class.  The only real Model classes, however, are the graph classes.  The controllers largely just obtain data directly from the AccountController.  The primary reason this was not addressed was the fact that it just seemed like overkill to implement an entire additional class for some of the datasets we would be modeling.  

As we intended courses to have a priority attribute, we developed the system accordingly.  As we ran out of time to properly implement the priority functionality into the study hour algorithm, we effectively cut any reference to priority from our GUI.  However, as priority was fully implemented in the Course and Course Builder classes, as well as the database- we chose to leave it in our deployment implementation.  A course’s priority is always set to 0 and is never altered or referenced.  While less than ideal, this allows the possibility of simply re-implementing the front-end functionality if we were to enhance the application in the future. 

The AddCourseBox and EditCourseBox user controls contain logic that would ideally be contained in the parent form’s controller (namely that it directly contacts the AccountController).  Since we use the add and edit course functionalities on multiple forms, creating a common user control seemed like the most logical way to be able to reuse code.  This was quickly implemented with the intent of later segregating this functionality to better fit the MVC pattern, but we simply ran out of time to move it. 

The btnAddCourse_Click() method in both these classes is extremely long as it has to perform a series of validation checks for all 7 days of the week.  This would ideally be refactored into one “validateDay” method that could be called for multiple days; but we reached the point where the existing code worked properly and we didn’t want to risk creating unnecessary bugs by tampering with it. 
