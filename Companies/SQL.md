= Mindtree (Github user)
 EmpID	    		EmpName	    	DeptName	  DeptID	Salary
	1		  Noah		Engineering	    100		10000
	2		  Sophia	Engineering	    100		20000
	3		  Liam		Engineering	    100		30000
	4		  Emma		HR				200		10000
	5		  Jacob		HR				200		10000
	6		  Olivia	HR				200		10000
	7		  Mason		Executive		300		50000
	8		  Ava		Marketing		400		15000
	9		  Ethan		Marketing		400		10000

Get Max Salary By DeptName DeptName MaxSalary

Get List of Employee with 2nd Highest Salary By DeptName EmpName DeptName DeptID Salary

Given an array nums containing n+1 intergers. where each integer is between 1 and n (inclusive). Find the duplicate number Example 1 : Input: [1, 3, 4, 2, 2] Output: 2


=> RateGain
============
Customer - ID Name Adderss Country
Order Detail - OrderId CutomerId Details

1. Find all employees who have no order (using only joins)
2. Get customer of countries ahvinf costomer count >1000

=> Mphais
===========
- Integrated security in Database Connection
 
R systems
=========
- Diff btw Rank & Row number & Dense_Rank()
- Cursors and when to use them

-MIRKIT
========
- Difing multiple indexes on table ex 100 col in a table, we have defined indexs on all, which operation will be impacted : insert/update/delete

S&P Global
==========
- which index changes the underlining physical data?
- Non clustered indexed data is physical data or not (i it changes the physical data)
- > Query
Question : in a table where i have a soft delete columne such as IsActive. I dont want to insert a duplicate Email address
if that email address is already present in database with IsActive as true but if IasActive is set to false i
should be able to insert the duplicate email address. which SQL constraint can be used here?
- name the constantraint directly from SQL which can be used here 
Ans : 
you can use a filtered unique index to enforce the constraint that a duplicate email address can only be inserted if it has an IsActive value of false.

CREATE UNIQUE INDEX idx_Email ON MyTable (Email) WHERE IsActive = 1;

INSERT INTO MyTable (Email, IsActive) VALUES ('example@email.com', 0);

KEKA
=====
- Explain the database design of the workflow visualizer in your application. Explain all the models and all the properties. Explain how the flow is happening from the frontend to backend to database.
	
