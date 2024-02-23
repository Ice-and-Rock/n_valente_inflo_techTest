## n_valente_inflo_techTest

# User Management Technical Exercise

The exercise is an ASP.NET Core web application backed by Entity Framework Core, which faciliates management of some fictional users.
We recommend that you use [Visual Studio (Community Edition)](https://visualstudio.microsoft.com/downloads) or [Visual Studio Code](https://code.visualstudio.com/Download) to run and modify the application. 

**The application uses an in-memory database, so changes will not be persisted between executions.**

## The Exercise
Complete as many of the tasks below as you can. These are split into 3 levels of difficulty 
* **Standard** - Functionality that is common when working as a web developer
* **Advanced** - Slightly more technical tasks and problem solving
* **Expert** - Tasks with a higher level of problem solving and architecture needed

### 1. Filters Section (Standard)

The users page contains 3 buttons below the user listing - **Show All**, **Active Only** and **Non Active**. Show All has already been implemented. Implement the remaining buttons using the following logic:
* Active Only – This should show only users where their `IsActive` property is set to `true` ✅
* Non Active – This should show only users where their `IsActive` property is set to `false` ✅

<container>

    **Plan**
    - Locate the PageModel containing that renders the class and data
        - using UsersController.cs (retrieves the data and sets it to the class models)

    - Add new Controllers for Active && NonActive
        - using FilterByActive() in UserServices.cs
            - Add new definition for the method to be used 
    - Add new PageViews for the new Lists: Active && NonActive
        - use the existing template of the List (GetAll)
    - Update the buttons to filter the results of the get request (all three PageViews)
        - asp-controller - define which controller is to be used
        - asp-action - define the action
    - start the development server to check the results: dotnet run
</container>

</br>

### 2. User Model Properties (Standard)

Add a new property to the `User` class in the system called `DateOfBirth` which is to be used and displayed in relevant sections of the app. ✅

<container>
    - Locate User class and add DateOfBirth with type DateTime
    - Update the <UserListItemViewModel> -> UserListViewModel
    - Add the new field to the viewPages (List, ActiveList, NonActiveList)
    - update the data being seeded in DataContext
        - DateOfBirth = new System.DateTime(int, int, int)
    - check the new DataCOntect is being rendered 
        Edit - Added a shortening tool for the DateTime, .ToShortStringDate()
</container>

### 3. Actions Section (Standard)

Create the code and UI flows for the following actions
* **Add** – A screen that allows you to create a new user and return to the list

<container>
    **Plan**
    - create a UserViewModel to the data transfer betwwen views and controllers
        - similar format to UserListViewModel with same fields
    - define a new public controller action (Add)
    - write a POST request containing a UserViewModel()
        - populated by the new AddUser fields from an AddUser.cshtml
    - create AddUser.cshtml
        - contains html Form type="submit" and appropriate fields matching UserViewModel
</container>

* **View** - A screen that displays the information about a user
* **Edit** – A screen that allows you to edit a selected user from the list  
* **Delete** – A screen that allows you to delete a selected user from the list

Each of these screens should contain appropriate data validation, which is communicated to the end user.

### 4. Data Logging (Advanced)

Extend the system to capture log information regarding primary actions performed on each user in the app.
* In the **View** screen there should be a list of all actions that have been performed against that user. 
* There should be a new **Logs** page, containing a list of log entries across the application.
* In the Logs page, the user should be able to click into each entry to see more detail about it.
* In the Logs page, think about how you can provide a good user experience - even when there are many log entries.

### 5. Extend the Application (Expert)

Make a significant architectural change that improves the application.
Structurally, the user management application is very simple, and there are many ways it can be made more maintainable, scalable or testable.
Some ideas are:
* Re-implement the UI using a client side framework connecting to an API. Use of Blazor is preferred, but if you are more familiar with other frameworks, feel free to use them.
* Update the data access layer to support asynchronous operations.
* Implement authentication and login based on the users being stored.
* Implement bundling of static assets.
* Update the data access layer to use a real database, and implement database schema migrations.

## Additional Notes

* Please feel free to change or refactor any code that has been supplied within the solution and think about clean maintainable code and architecture when extending the project.
* If any additional packages, tools or setup are required to run your completed version, please document these thoroughly.


