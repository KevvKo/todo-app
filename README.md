# ToDo-Webapplication
##Table of Contents
[Requirements](##requirements)
[Getting started](##getting-started)
[Examples](##examples)
[Coming feature](##Coming-feature)
## Requirements
- c#
- .NET Core
- ASP.NET

## Getting started
To use and run the application, just download the repository, direct the terminal in the project-directory and run the following command in your terminal:

```
dotnet run
```
**Note:** If the program runs, enter the Web-App about the localhost: https://localhost:5001/

## Examples
### Default UI
This example shows the default layout from the ToDo-App with some entrys.

![alt text](/examples/default.png "Default UI")

### Add To Do
On click at the arrow, below the list, you can add a new To Do with a date, where the ToDo must be done. Also, you can add a ToDo just with a date and no given description.

![alt text](/examples/add.png "Add a new To Do")

**Hint:** To delete a ToDo, tick off the checkbox in the status column for the ToDo and it will be deleted.

### Edit To Do's
Further, if you want to edit an ToDo, just click on the Edit-Link and you will be redirected to the edit-page, where you can do small changes on your ToDo.

![alt text](/examples/edit.png "Edit an existing To Do")

### Details
The details-overview shows you just the ToDo and the date, nothing more.

![alt text](/examples/details.png "Show details about a To Do")

## Coming feature
Extended UI, which shows the to do's for single weekday (sorted by date).
Options to switch between **all to do's** or **to do's for a weekday**