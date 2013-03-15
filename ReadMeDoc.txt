his is a simple .net asp.net mvc4 app which accesses a database and displays the information about employees, there log
in and logout times plus their categories of employment.

My database is a database first model 
created on Mssql. The scripts are attached to this solution in solution items as Emplyee Database EAD CA3.sql. This database
has three tables Employee, log and CompanyPosition as shown in the model. Employee shows the details of each employee,
log shows the login and log out times and finally CompanyPosition details what type of position does the employee hold. There
are relationships between the tables concerned. The principle of this project is that a security guard can track the login and
logout times of each employee in the log table and amend each employees status in the other tables. I have changed the html,
css, headings to gave the feel of a actual application.
	I therefore added three controllers Employee, CompanyPosition and Log. I heavily commented the controller for CompanyPosition
and its index view. Although i did not get time to comment other controllers or views, they are very similar. The one difference
i should at least clarify is the use of the viewbag object in the log controller. The viewbag object is used to pass data
from the controller to the view. 
	Finally there is the unit tests. I created test classes for each of the controllers. The test methods are listed in
sequence in the test view. I did no tests on the entity objects partly due to time plus there is no logic in those classes, they 
are simply constructors. All tests got 100% coverage. I mainly tested by creating tets objects, inserting them , deleting them
etc. Please be careful if rerunning tests that you use an id of a object whoich exists in the database. Trying to delete
something already deleted will cause a error.