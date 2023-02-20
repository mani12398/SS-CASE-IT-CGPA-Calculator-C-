use CGPA;

create table BS
(
	Course_Name varchar(250),
	Course_ID varchar(250),
	Course_Credit_Hours varchar(250),
	Course_Department varchar(250),
	Course_Semester varchar(250),
	Course_Student_Type varchar(250),

);

/*BS-CS*/

/*1st Semester*/

insert into BS values('Applied Physics','SC1201','3','CS','1','EM');
insert into BS values('Calculus & Analytic Geometry','SC1001','3','CS','1','E');
insert into BS values('English Composition & Comprehension','HU1002','3','CS','1','EM');
insert into BS values('Introduction to Information and Communication Technologies','CS1501','2','CS','1','EM');
insert into BS values('Programming Fundamentals','CS1001','4','CS','1','EM');
insert into BS values('Pre-Mathematics-I','PSC1001','3','CS','1','M');
insert into BS values('Pre-Mathematics-II','PSC1002','3','CS','1','M');

/*2nd Semester*/

insert into BS values('Communication & Presentation Skills','HU1003','3','CS','2','EM');
insert into BS values('Digital Logic and Design','CS1502','4','CS','2','EM');
insert into BS values('Islamic Studies','HU1101','2','CS','2','EM');
insert into BS values('Multivariate Calculus','SC1002','2','CS','2','E');
insert into BS values('Pakistan Studies','HU1102','2','CS','2','E');
insert into BS values('Discrete Structures','CS2301','3','CS','2','M');
insert into BS values('Programming Techniques','CS1002','2','CS','2','EM');
insert into BS values('Calculus & Analytic Geometry','SC1001','3','CS','2','M');

/*3rd Semester*/

insert into BS values('Computer Organization & Assembly Language','CS2503','4','CS','3','EM');
insert into BS values('Data Structure and Algorithms','CS2003','4','CS','3','EM');
insert into BS values('Differential Equations','SC2003','3','CS','3','EM');
insert into BS values('Pakistan Studies','HU1102','2','CS','3','M');
insert into BS values('Discrete Structures','CS2301','3','CS','3','E');
insert into BS values('Multivariate Calculus','SC1002','2','CS','3','M');
insert into BS values('Object Oriented Programming','CS2004','4','CS','3','EM');

/*4th Semester*/

insert into BS values('Visual Programming','CS2007','4','CS','4','EM');
insert into BS values('Introduction to Database Systems','CS2201','4','CS','4','EM');
insert into BS values('Operating Systems','CS2504','4','CS','4','EM');
insert into BS values('Probability and statistics','SC2004','3','CS','4','EM');
insert into BS values('Software Engineering','CS2101','3','CS','4','EM');

/*5th Semester*/

insert into BS values('CS Elective – II','','3','CS','5','EM');
insert into BS values('Artificial Intelligence','CS4303','4','CS','5','EM');
insert into BS values('CS Elective–III','','3','CS','5','EM');
insert into BS values('Design & Analysis of Algorithms','CS3005','3','CS','5','EM');
insert into BS values('Linear Algebra','SC3005','3','CS','5','EM');
insert into BS values('Theory of Automata and Formal Languages','CS3302','3','CS','5','EM');

/*6th Semester*/

insert into BS values('Computer Communication and Networks','CS3401','4','CS','6','EM');
insert into BS values('CS Elective-IV','','4','CS','6','EM');
insert into BS values('Numerical Computing','SC3006','2','CS','6','EM');
insert into BS values('Technical & Business Writing','HU3004','3','CS','6','EM');
insert into BS values('University Elective-I','','3','CS','6','EM');

/*7th Semester*/

insert into BS values('CS Elective-V','','3','CS','7','EM');
insert into BS values('Compiler Construction','CS4006','3','CS','7','EM');
insert into BS values('Parallel & Distributed Computing','CS4405','3','CS','7','EM');
insert into BS values('Senior Design Project-I','CS4111','2','CS','7','EM');
insert into BS values('University Elective-II','','3','CS','7','EM');

/*8th Semester*/

insert into BS values('CS Elective-VI','','3','CS','8','EM');
insert into BS values('Information Security','CS4406','3','CS','8','EM');
insert into BS values('Senior Design Project-II','CS4112','4','CS','8','EM');
insert into BS values('University Elective- III','','3','CS','8','EM');
insert into BS values('University Elective- IV','','3','CS','8','EM');

/*BS-SE*/

/*1st Semester*/

insert into BS values('Introduction to Information and Communication Technologies','CS1501','2','SE','1','EM');
insert into BS values('Programming Fundamentals','CS1001','4','SE','1','EM');
insert into BS values('Calculus & Analytic Geometry','SC1001','3','SE','1','E');
insert into BS values('Applied Physics','SC1201','3','SE','1','EM');
insert into BS values('English Composition & Comprehension','HU1002','3','SE','1','EM');
insert into BS values('Pre-Mathematics-I','PSC1001','3','SE','1','M');
insert into BS values('Pre-Mathematics-II','PSC1002','3','SE','1','M');

/*2nd Semester*/

insert into BS values('Communication & Presentation Skills','HU1003','3','SE','2','EM');
insert into BS values('Discrete Structures','CS2301','3','SE','2','EM');
insert into BS values('Islamic Studies','HU1101','2','SE','2','E');
insert into BS values('Pakistan Studies','HU1102','2','SE','2','EM');
insert into BS values('Programming Techniques','CS1002','2','SE','2','EM');
insert into BS values('Software Engineering','SE2101','3','SE','2','EM');
insert into BS values('Calculus & Analytic Geometry','SC1001','3','SE','2','M');

/*3rd Semester*/

insert into BS values('Data Structure and Algorithms','CS2003','4','SE','3','EM');
insert into BS values('Linear Algebra','SC2005','3','SE','3','EM');
insert into BS values('Object Oriented Programming','CS2004','4','SE','3','EM');
insert into BS values('Software Requirement Engineering','SE2119','3','SE','3','EM');
insert into BS values('Leadership & Team Management','MS3803','3','SE','3','EM');

/*4th Semester*/

insert into BS values('Introduction to Database Systems','CS2201','4','SE','4','EM');
insert into BS values('Operating Systems','CS2504','4','SE','4','EM');
insert into BS values('Probability and statistics','SC2004','3','SE','4','EM');
insert into BS values('Software Design and Architecture','SE2102','3','SE','4','EM');
insert into BS values('Entrepreneurship & Technology','MS3801','3','SE','4','EM');

/*5th Semester*/

insert into BS values('SE-Elective-','','3','SE','5','EM');
insert into BS values('SE-Elective-II','','3','SE','5','EM');
insert into BS values('SE-Supporting-I','','3','SE','5','EM');
insert into BS values('Software Construction and Development','SE3117','3','SE','5','EM');
insert into BS values('University Elective-III','','3','SE','5','EM');
insert into BS values('Web Engineering','CS3008','3','SE','5','EM');

/*6th Semester*/

insert into BS values('Computer Communication and Networks','CS3401','4','SE','6','EM');
insert into BS values('Professional Practices','HU3106','3','SE','6','EM');
insert into BS values('SE-Supporting-II','','3','SE','6','EM');
insert into BS values('Software Quality Engineering','SE3107','3','SE','6','EM');
insert into BS values('Software Re Engineering','SE3118','3','SE','6','EM');
insert into BS values('Technical & Business Writing','HU3004','3','SE','6','EM');

/*7th Semester*/

insert into BS values('Human Computer Interaction','CS3105','3','SE','7','EM');
insert into BS values('SE-Elective- III','','3','SE','7','EM');
insert into BS values('SE-Elective-IV','','3','SE','7','EM');
insert into BS values('Senior Design Project-I','SE4111','2','SE','7','EM');
insert into BS values('Software Project Management','SE3109','3','SE','7','EM');
insert into BS values('Islamic Studies','HU1101','2','SE','7','M');

/*8th Semester*/

insert into BS values('Information Security','CS4406','3','SE','8','EM');
insert into BS values('SE-Elective-V','','3','SE','8','EM');
insert into BS values('Senior Design Project-II','SE4112','4','SE','8','EM');
insert into BS values('SE-Supporting-III','','3','SE','8','EM');
insert into BS values('University-Elective-IV','','3','SE','8','EM');

/*BS-AI*/

/*1st Semester*/

insert into BS values('Introduction to Information and Communication Technologies','CS1501','2','AI','1','EM');
insert into BS values('Programming Fundamentals','CS1001','4','AI','1','EM');
insert into BS values('Calculus & Analytic Geometry','SC1001','3','AI','1','E');
insert into BS values('Applied Physics','SC1201','3','AI','1','EM');
insert into BS values('English Composition & Comprehension','HU1002','3','AI','1','EM');
insert into BS values('Pre-Mathematics-I','PSC1001','3','AI','1','M');
insert into BS values('Pre-Mathematics-II','PSC1002','3','AI','1','M');

/*2nd Semester*/

insert into BS values('Programming Techniques','CS1002','2','AI','2','EM');
insert into BS values('Data Structure and Algorithms','CS2003','4','AI','2','EM');
insert into BS values('Digital Logic and Design','CS1502','4','AI','2','EM');
insert into BS values('Linear Algebra','SC2005','3','AI','2','E');
insert into BS values('Probability and statistics','SC2004','3','AI','2','EM');
insert into BS values('Communication & Presentation Skills','HU1003','3','AI','2','EM');
insert into BS values('Calculus & Analytic Geometry','SC1001','3','AI','2','M');

/*3rd Semester*/

insert into BS values('Object Oriented Programming','CS2004','4','AI','3','EM');
insert into BS values('AI Elec 1 (Ex:Advance Statistics)','AI 2007','3','AI','3','EM');
insert into BS values('Artificial Intelligence','AI2303','4','AI','3','EM');
insert into BS values('Discrete Structures','CS2301','3','AI','3','EM');
insert into BS values('Database Systems','AI2201','4','AI','3','EM');

/*4th Semester*/

insert into BS values('Machine Learning','AI2202','4','AI','4','EM');
insert into BS values('Computer Org. & Assembly Language','AI2503','4','AI','4','EM');
insert into BS values('Software Engineering','SE2101','3','AI','4','EM');
insert into BS values('Differential Equations','AI2504','3','AI','4','EM');
insert into BS values('Knowledge Representation & Reasoning','AI2203','3','AI','4','EM');

/*5th Semester*/

insert into BS values('Operating System','CS3504','4','AI','5','EM');
insert into BS values('Artificial Neural Networks','AI3204','3','AI','5','EM');
insert into BS values('Analysis Of Algorithms','AI3005','3','AI','5','EM');
insert into BS values('UnivElec 1 (Ex:Economy Related)','','3','AI','5','EM');
insert into BS values('AI Elective 2. (Ex: Theory of automata/ intelligent web design and development)','AI3008','3','AI','5','EM');
insert into BS values('Linear Algebra','SC1005','3','AI','5','M');

/*6th Semester*/

insert into BS values('Islamic Studies/Ethics','HU3101','2','AI','6','EM');
insert into BS values('Computing vision','AI3206','3','AI','6','EM');
insert into BS values('Computer Networks','AI3401','4','AI','6','EM');
insert into BS values('AI Elec 3 (Ex: Data Mining)','AI3207','3','AI','6','EM');
insert into BS values('AI Elec 4 (Ex: Deep Learning)','AI3208','3','AI','6','EM');
insert into BS values('Natural Language Processing','AI3205','3','AI','6','EM');

/*7th Semester*/

insert into BS values('Final Year Project-I','AI4111','2','AI','7','EM');
insert into BS values('Information Security','CS4406','3','AI','7','EM');
insert into BS values('University Elective-2 (Ex: Management Rel.)','','3','AI','7','EM');
insert into BS values('Technical & Business Writing','HU4004','3','AI','7','EM');
insert into BS values('Parallel & Distributed Computing','AI4405','3','AI','7','EM');
insert into BS values('Pakistan Studies','HU3102','2','AI','7','EM');

/*8th Semester*/

insert into BS values('Final Year Project-II','AI4112','4','AI','8','EM');
insert into BS values('University Elective- 3(Ex:Management Rel.)','AI2503','3','AI','8','EM');
insert into BS values('Professional Practices','HU4005','3','AI','8','EM');
insert into BS values('University Elective- 4(Ex: Management Rel.)','AI2504','3','AI','8','EM');


/*BS-CYS*/

/*1st Semester*/

insert into BS values('Introduction to Information and Communication Technologies','CS1501','2','CYS','1','EM');
insert into BS values('Programming Fundamentals','CS1001','4','CYS','1','EM');
insert into BS values('Calculus & Analytic Geometry','SC1001','3','CYS','1','E');
insert into BS values('Applied Physics','SC1211','3','CYS','1','EM');
insert into BS values('English Composition & Comprehension','HU1002','3','CYS','1','EM');
insert into BS values('Pre-Mathematics-I','PSC1001','3','CYS','1','M');
insert into BS values('Pre-Mathematics-II','PSC1002','3','CYS','1','M');

/*2nd Semester*/

insert into BS values('Calculus & Analytic Geometry','SC1001','3','CYS','2','M');
insert into BS values('Data Structure and Algorithms','CS2003','4','CYS','2','EM');
insert into BS values('Digital Logic and Design','CS1502','4','CYS','2','EM');
insert into BS values('Linear Algebra','SC1005','3','CYS','2','E');
insert into BS values('Probability and statistics','SC1004','3','CYS','2','EM');
insert into BS values('Communication & Presentation Skills','HU1003','3','CYS','2','EM');

/*3rd Semester*/

insert into BS values('Object Oriented Programming','CS2005','4','CYS','3','EM');
insert into BS values('Information Security','CS2406','3','CYS','3','EM');
insert into BS values('Computer Org. & Assembly Language','CS2503','4','CYS','3','EM');
insert into BS values('Introduction to Database Systems','CS2201','4','CYS','3','EM');
insert into BS values('Discrete Structures','CS2301','3','CYS','3','EM');

/*4th Semester*/

insert into BS values('Computer Communication and Networks','CS2401','4','CYS','4','EM');
insert into BS values('Islamic Ideology','HU2101','2','CYS','4','EM');
insert into BS values('Differential Equations','SC2003','3','CYS','4','EM');
insert into BS values('Introduction to Cyber Security','CY2801','3','CYS','4','EM');
insert into BS values('Linear Algebra','SC1005','3','CYS','4','M');
insert into BS values('CYS Elective-1','CS2008','3','CYS','4','EM');

/*5th Semester*/

insert into BS values('Software Engineering','SE2101','3','CYS','5','EM');
insert into BS values('Artificial Intelligence','CS2303','4','CYS','5','EM');
insert into BS values('Information Assurance','CY3816','3','CYS','5','EM');
insert into BS values('Design & Analysis of Algorithms','CS2005','3','CYS','5','EM');
insert into BS values('Operating System','CS3504','4','CYS','5','EM');

/*6th Semester*/

insert into BS values('CYSElective-2','CS3407','3','CYS','6','EM');
insert into BS values('Network Security','CY3802','3','CYS','6','EM');
insert into BS values('UniversityElective-1','','3','CYS','6','EM');
insert into BS values('Secure Software Design and Dev.','CY3817','3','CYS','6','EM');
insert into BS values('Vulnerability Assessment &Reverse Engg.','CY3818','3','CYS','6','EM');
insert into BS values('Technical & Business Writing','HU4004','3','CYS','6','EM');

/*7th Semester*/

insert into BS values('Final Year Project - I ','CY4111','2','CYS','7','EM');
insert into BS values('CYSElective-3','','3','CYS','7','EM');
insert into BS values('Pakistan Studies','HU3102','2','CYS','7','EM');
insert into BS values('Digital Forensics','CY3815','3','CYS','7','EM');
insert into BS values('Parallel & Distributed Computing','CS4405','3','CYS','7','EM');
insert into BS values('University Elective-2','','3','CYS','7','EM');

/*8th Semester*/

insert into BS values('Final Year Project - II','CY4112','4','CYS','8','EM');
insert into BS values('CYSElective-4','','3','CYS','8','EM');
insert into BS values('UniversityElective-3','','2','CYS','8','EM');
insert into BS values('CYSElective-5','','3','CYS','8','EM');
insert into BS values('UniversityElective-4','','3','CYS','8','EM');


/*BS-CS*/

/*1st Semester*/

select * from BS where Course_Department ='CS'and Course_Semester='1' and Course_Student_Type in('EM','E'); 
select * from BS where Course_Department ='CS'and Course_Semester='1' and Course_Student_Type in('EM','M'); 

/*2nd Semester*/

select * from BS where Course_Department ='CS'and Course_Semester='2' and Course_Student_Type in('EM','E'); 
select * from BS where Course_Department ='CS'and Course_Semester='2' and Course_Student_Type in('EM','M'); 

/*3rd Semester*/

select * from BS where Course_Department ='CS'and Course_Semester='3' and Course_Student_Type in('EM','E'); 
select * from BS where Course_Department ='CS'and Course_Semester='3' and Course_Student_Type in('EM','M');

/*4th Semester*/

select * from BS where Course_Department ='CS'and Course_Semester='4' and Course_Student_Type in('EM','E'); 
select * from BS where Course_Department ='CS'and Course_Semester='4' and Course_Student_Type in('EM','M');

/*5th Semester*/

select * from BS where Course_Department ='CS'and Course_Semester='5' and Course_Student_Type in('EM','E'); 
select * from BS where Course_Department ='CS'and Course_Semester='5' and Course_Student_Type in('EM','M');

/*6th Semester*/

select * from BS where Course_Department ='CS'and Course_Semester='6' and Course_Student_Type in('EM','E'); 
select * from BS where Course_Department ='CS'and Course_Semester='6' and Course_Student_Type in('EM','M');

/*7th Semester*/

select * from BS where Course_Department ='CS'and Course_Semester='7' and Course_Student_Type in('EM','E'); 
select * from BS where Course_Department ='CS'and Course_Semester='7' and Course_Student_Type in('EM','M');

/*8th Semester*/

select * from BS where Course_Department ='CS'and Course_Semester='8' and Course_Student_Type in('EM','E'); 
select * from BS where Course_Department ='CS'and Course_Semester='8' and Course_Student_Type in('EM','M');

/*BS-SE*/

/*1st Semester*/

select * from BS where Course_Department ='SE'and Course_Semester='1' and Course_Student_Type in('EM','E'); 
select * from BS where Course_Department ='SE'and Course_Semester='1' and Course_Student_Type in('EM','M'); 

/*2nd Semester*/

select * from BS where Course_Department ='SE'and Course_Semester='2' and Course_Student_Type in('EM','E'); 
select * from BS where Course_Department ='SE'and Course_Semester='2' and Course_Student_Type in('EM','M');

/*3rd Semester*/

select * from BS where Course_Department ='SE'and Course_Semester='3' and Course_Student_Type in('EM','E'); 
select * from BS where Course_Department ='SE'and Course_Semester='3' and Course_Student_Type in('EM','M'); 

/*4th Semester*/

select * from BS where Course_Department ='SE'and Course_Semester='4' and Course_Student_Type in('EM','E'); 
select * from BS where Course_Department ='SE'and Course_Semester='4' and Course_Student_Type in('EM','M');

/*5th Semester*/

select * from BS where Course_Department ='SE'and Course_Semester='5' and Course_Student_Type in('EM','E'); 
select * from BS where Course_Department ='SE'and Course_Semester='5' and Course_Student_Type in('EM','M');

/*6th Semester*/

select * from BS where Course_Department ='SE'and Course_Semester='6' and Course_Student_Type in('EM','E'); 
select * from BS where Course_Department ='SE'and Course_Semester='6' and Course_Student_Type in('EM','M');

/*7th Semester*/

select * from BS where Course_Department ='SE'and Course_Semester='7' and Course_Student_Type in('EM','E'); 
select * from BS where Course_Department ='SE'and Course_Semester='7' and Course_Student_Type in('EM','M');

/*8th Semester*/

select * from BS where Course_Department ='SE'and Course_Semester='8' and Course_Student_Type in('EM','E'); 
select * from BS where Course_Department ='SE'and Course_Semester='8' and Course_Student_Type in('EM','M');

/*BS-AI*/

/*1st Semester*/

select * from BS where Course_Department ='AI'and Course_Semester='1' and Course_Student_Type in('EM','E'); 
select * from BS where Course_Department ='AI'and Course_Semester='1' and Course_Student_Type in('EM','M'); 

/*2nd Semester*/

select * from BS where Course_Department ='AI'and Course_Semester='2' and Course_Student_Type in('EM','E'); 
select * from BS where Course_Department ='AI'and Course_Semester='2' and Course_Student_Type in('EM','M'); 

/*3rd Semester*/

select * from BS where Course_Department ='AI'and Course_Semester='3' and Course_Student_Type in('EM','E'); 
select * from BS where Course_Department ='AI'and Course_Semester='3' and Course_Student_Type in('EM','M'); 

/*4th Semester*/

select * from BS where Course_Department ='AI'and Course_Semester='4' and Course_Student_Type in('EM','E'); 
select * from BS where Course_Department ='AI'and Course_Semester='4' and Course_Student_Type in('EM','M');

/*5th Semester*/

select * from BS where Course_Department ='AI'and Course_Semester='5' and Course_Student_Type in('EM','E'); 
select * from BS where Course_Department ='AI'and Course_Semester='5' and Course_Student_Type in('EM','M');

/*6th Semester*/

select * from BS where Course_Department ='AI'and Course_Semester='6' and Course_Student_Type in('EM','E'); 
select * from BS where Course_Department ='AI'and Course_Semester='6' and Course_Student_Type in('EM','M');

/*7th Semester*/

select * from BS where Course_Department ='AI'and Course_Semester='7' and Course_Student_Type in('EM','E'); 
select * from BS where Course_Department ='AI'and Course_Semester='7' and Course_Student_Type in('EM','M');

/*8th Semester*/

select * from BS where Course_Department ='AI'and Course_Semester='8' and Course_Student_Type in('EM','E'); 
select * from BS where Course_Department ='AI'and Course_Semester='8' and Course_Student_Type in('EM','M');

/*BS-CYS*/

/*1st Semester*/

select * from BS where Course_Department ='CYS'and Course_Semester='1' and Course_Student_Type in('EM','E'); 
select * from BS where Course_Department ='CYS'and Course_Semester='1' and Course_Student_Type in('EM','M'); 

/*2nd Semester*/

select * from BS where Course_Department ='CYS'and Course_Semester='2' and Course_Student_Type in('EM','E'); 
select * from BS where Course_Department ='CYS'and Course_Semester='2' and Course_Student_Type in('EM','M'); 

/*3rd Semester*/

select * from BS where Course_Department ='CYS'and Course_Semester='3' and Course_Student_Type in('EM','E'); 
select * from BS where Course_Department ='CYS'and Course_Semester='3' and Course_Student_Type in('EM','M'); 

/*4th Semester*/

select * from BS where Course_Department ='CYS'and Course_Semester='4' and Course_Student_Type in('EM','E'); 
select * from BS where Course_Department ='CYS'and Course_Semester='4' and Course_Student_Type in('EM','M'); 

/*5th Semester*/

select * from BS where Course_Department ='CYS'and Course_Semester='5' and Course_Student_Type in('EM','E'); 
select * from BS where Course_Department ='CYS'and Course_Semester='5' and Course_Student_Type in('EM','M'); 

/*6th Semester*/

select * from BS where Course_Department ='CYS'and Course_Semester='6' and Course_Student_Type in('EM','E'); 
select * from BS where Course_Department ='CYS'and Course_Semester='6' and Course_Student_Type in('EM','M'); 

/*7th Semester*/

select * from BS where Course_Department ='CYS'and Course_Semester='7' and Course_Student_Type in('EM','E'); 
select * from BS where Course_Department ='CYS'and Course_Semester='7' and Course_Student_Type in('EM','M'); 

/*8th Semester*/

select * from BS where Course_Department ='CYS'and Course_Semester='8' and Course_Student_Type in('EM','E'); 
select * from BS where Course_Department ='CYS'and Course_Semester='8' and Course_Student_Type in('EM','M'); 

select * from BS;

delete from BS;

drop table BS;


update BS set Course_Credit_Hours='4' where Course_Name='Programming Techniques';

update BS set Course_Name='Probability and Statistics' where Course_Name='Probability and statistics';