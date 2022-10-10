# Telthemweb Library

Telthemweb is a simple, fast, and powerful open source Database Manager for .NET framework which allows developer to connect to many database providers like Mysql,Sql Server, Sqlite, Oracle,Postgres and Access Database.

# Table of contents
1. [Installation](#Installation)
2. [Usage](#How-to-use-Telthemweb)
3. [Databases](#Databases)

# Installation
```bash
   NuGet\Install-Package Telthemweb -Version 1.0.0
   ```
Or Clone it

```bash
$ git clone https://github.com/telthemweb/Telthemweblib.git
```
# How to usen Telthemweb

  After installing, You should set database credentials. To do this Telthemweb come with form to help you with form to enter server name ,database type, username,password and port(optional);

  It also encrypt all credentials so that noone will see them

  To use form you should first add 

```code

    TelthemwebLib telthem = new TelthemwebLib(); // IMPORT THIS Using Telthemweb

    to use form you simply add this 

    telthem.telshowConfigurationForm(true) //true to trigger form

    This form can also help to create database for you,automatically

 ```

 # Insert Record

 ```code
 //To insert Record into database Table

    string sql ="INSERT INTO table(name,surname) VALUES('Innocent','Tauzeni')";

    bool result = telthem.TelInsert(sql);

    if(result==true){
    	Console.Write("Success");
    }
    else{
    	Console.Write("Fail");
    }
 ```

 # Update Record

 ```code
  string sql ="UPDATE table SET name='Telthem',surname='web'";

    bool result = telthem.TelUpdate(sql);

    if(result==true){
    	Console.Write("Updated");
    }
    else{
    	Console.Write("Fail to update");
    }
 ```

 # Retrieve Records

 ```code
   string sql ="SELECT id,name,surnume FROM table";
   DataTable results = telthem.TelRetrieve(sql)
   Datagrid1.Rows.Clear();
   foreach (DataRow row in results.Rows)
    { 
        Datagrid1.Rows.Add(row[0], row[1], row[2]);
    }
 ``` 

# Delete Record

```code
	string sql ="DELETE * FROM table WHERE id=1";

	bool result = telthem.TelDelete(sql);
	if(result==true){
    	Console.Write("Deleted");
    }
    else{
    	Console.Write("Fail to delete");
    }
```


# Check If Record is already Exist
```code
	string sql ="SELECT * FROM table WHERE id=1";

	bool result = telthem.TelCheckExist(sql);
	if(result==true){
    	Console.Write("Exist");
    }
    else{
    	Console.Write("Fail to delete");
    }
```

# Encrypt password or anything

```code
 var hashpass ="password";
  string hashpassword = telthem.TelEncriptHash(hashpass);
```


# Decrypt password or anything

```code
  string ecrypedpassword = telthem.TelDecriptHash(ecrypedpassword);
```



# Databases
1. [MySQL](#MySQL) ✅
2. [MSSQL](#Microsoft-SqlServer) ✅
3. [ORACLE](#ORACLE)✅
4. [POSTGRES](#POSTGRESQL) ✅
5. [SQLITE](#SQLITE) ✅
6. [DB2](#DB2) ✅
7. [CLOUD DATABASE](#Heroku) ✅

#Others
1. [Contributing](#contributing)
2. [Special Thanks To](#special-thanks-to)
3. [Sponsorship](#sponsorship)
4. [Question and Answer](#question-and-answer)



# Contributing
For any contribution please contact me or whatsapp me at +263 774 914 150
or like Innocent Tauzeni Facebook Page

# Special Thanks To
1. To you all for choosing our libray

# Sponsorship
If you love Telthemweb, you can really help us by sponsoring us.




# app.config will have credentils like this

 ```code
 <appSettings>
    <add key="databaseType" value="dNO2jZpR67E=" />
    <add key="databasename" value="nfF0dqAS3kU=" />
    <add key="constring" value="EA6WHnuSMJcLUiLcEvTCqPJsp7ro0WDXLbmmmRXHb7Q1wXVdillzQq7z8FQfjlnRzW8fF9g+SsuZoEcoaQL5WZPjhuX/teWuVdI5UEgSarZCgZMzE1FnWzTLRFrTYAwy2HZPtsm5Ang=" />
    <add key="servername" value="rdIYsmwMRDoNoXDpNd0zqA==" />
    <add key="serverusername" value="hVHZHhiShRg=" />
    <add key="serverpassword" value="MFsawtPUB1ZrvdMlioLrTw==" />
  </appSettings>
 ```

  ALL Information will be encripted