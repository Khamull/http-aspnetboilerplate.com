# http-aspnetboilerplate.com
http://aspnetboilerplate.com/Templates/Create - Template Creatred from the website

# This Part comes on the website when we request a download
Thank you!
Your project is being created and downloaded in a few seconds...

After download
Open your solution on Visual Studio 2013 or later.
Select the 'Web' project as startup project.
Open Package Manager Console, select 'EntityFramework' project as Default project and run the EntityFramework's 'Update-Database' command. This will create the database
Run the application. User name is 'admin' and password is '123qwe' as default.
Multi-tenancy is enabled by default. You can disable it from 'Core' project.

If you want to change the database connection string, go to web.config and edit the following line:

<add name="Default" connectionString="Server=localhost; Database=sample; Trusted_Connection=True;" providerName="System.Data.SqlClient" />
What's next?
You can read the documentation to learn more...