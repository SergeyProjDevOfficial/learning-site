# learning-site

# Installation:

	1. Execute command: git clone https://github.com/SergeyProjDevOfficial/learning-site.git
  
	2. Connect to IIS:
		2.1 Open IIS
		2.2 Click "Add Site"
		2.3 Select path ~\learning-site\learning-site
		2.4 Click "Ok"
    
	3. Configure IIS:
		3.1 RBC on site -> Edit permissions... -> Security -> Edit -> Add...
		3.2 Type "iis_iusrs" -> Ok
		3.3 Type "iusr" -> Ok
		3.4 Apply
    
	4. Attech DB to your server via SQL Managment Studio
		DB contains in ~\learning-site\database MS SQL
		Don't forget to give your user permissions to read/write/own database
    
	5. Add conncetion string to web.config: 
		<add name="umbracoDbDSN" connectionString="server=SERVERNAME;database=learning-site;user id=USER;password='PASSWORD'" providerName="System.Data.SqlClient"/>
		where:
			SERVERNAME - your server name
			USER - your DB user name
			PASSWORD - your DB password
        
	6. Run site.

# Login: dev@gmail.com
# Password: 1234567890
