Giberson-et-al.
===============


## Database Setup
1. Delete your existing Giberson Database
2. Run schema.sql
3. Run data.sql
4. Open the project using Giberson.sln file
5. Open Database.cs and change line 28: <code>builder.DataSource = "Your Server Name"</code>

### schema.sql
If schema.sql does not run on MS Sql Management Studio:
1. Create a new empty Giberson Database. 
2. Open schema.sql, copy the last half of the the sql file; starting with:<br/>
<pre>USE [Giberson]
GO
/****** Object: Table... ******/</pre>
