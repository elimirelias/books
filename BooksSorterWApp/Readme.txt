/*-----------------------------------
Prova HBSIS

28/11/2015
Elimir Elias C Lima
elimirelias@gmail.com
Desenvolvedor .NET / Android / Java
+55 (31) 97544-2493
skype: elimir.lima
Linkedin: https://www.linkedin.com/in/elimirelias 
-----------------------------------*/

TECNOLOGIAS UTILIZADAS
======================

ASP.NET MVC 5.0 / C#
.Net Framework 4.5.1
Entity Framework 6.0
WebApi2 REST
Unit Testing
Route (WebApi)

AngularJS v1.4.8
bootstrap.js v3.0.0
Jquery-1.10.2
Modernizr v2.6.2
angular-datatables - v0.4.3
toastr.js

Microsoft Windows 10 - 64bits
Visual Studio Ultimate 2013
MySQL 5.0
ReSharper 10
Astah Communit (UML)

Microsoft.AspNet.Mvc" version="5.0.0" targetFramework="net451"
Microsoft.AspNet.Razor" version="3.0.0" targetFramework="net451"
Microsoft.AspNet.WebPages" version="3.0.0" targetFramework="net451"
Microsoft.Web.Infrastructure" version="1.0.0.0" targetFramework="net451"
Newtonsoft.Json" version="5.0.6" targetFramework="net451"

-----------------------------------
//Script Banco de Dados MySQL
ALTER TABLE book DROP PRIMARY KEY ;

DROP TABLE book;

CREATE TABLE book ( 
	IDBook 	int(11) AUTO_INCREMENT NOT NULL,
	Title  	varchar(400) NOT NULL,
	Author 	varchar(200) NOT NULL,
	Edition	int(11) NOT NULL 
	)
ENGINE = InnoDB;

INSERT INTO book(IDBook, Title, Author, Edition) VALUES(1, 'Java How to Program', 'Deitel & Deitel', 2007);
INSERT INTO book(IDBook, Title, Author, Edition) VALUES(2, 'Patterns of Enterprise Application', 'Martin Fowler', 2002);
INSERT INTO book(IDBook, Title, Author, Edition) VALUES(3, 'Head First Design Patterns', 'Elisabeth Freeman', 2004);
INSERT INTO book(IDBook, Title, Author, Edition) VALUES(4, 'Internet & World Wide Web: How to Program', 'Deitel & Deitel', 2007);

ALTER TABLE book ADD PRIMARY KEY (IDBook);
-----------------------------------