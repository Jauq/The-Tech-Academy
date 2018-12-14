USE db_zoo

CREATE TABLE tbl_animalia (
	animalia_id INT PRIMARY KEY NOT NULL IDENTITY (1, 1),
	animalia_type VARCHAR(50) NOT NULL
);


INSERT INTO tbl_animalia
	(animalia_type)
	VALUES
	('vertebrate'),
	('invertebrate')
;

SELECT * FROM tbl_animalia;

CREATE TABLE tbl_class (
	class_id INT PRIMARY KEY NOT NULL IDENTITY (100, 1),
	class_type VARCHAR(50) NOT NULL
);

INSERT INTO tbl_class
	(class_type)
	VALUES
	('bird'),
	('reptilian'),
	('mammal'),
	('arthropod'),
	('fish'),
	('worm'),
	('cnidaria'),
	('echinoderm')
;
SELECT * FROM tbl_class;

SELECT REPLACE(class_type, 'bird', 'birds') FROM tbl_class;

SELECT UPPER(class_type) FROM tbl_class WHERE class_type = 'bird';
SELECT COUNT(class_type) FROM tbl_class WHERE class_type = 'bird';

CREATE TABLE tbl_persons (
	persons_id INT PRIMARY KEY NOT NULL IDENTITY (1, 1),
	persons_fname VARCHAR(50) NOT NULL,
	persons_lname VARCHAR(50) NOT NULL,
	persons_contact VARCHAR(50) NOT NULL
);
INSERT INTO tbl_persons
	(persons_fname, persons_lname, persons_contact)
	VALUES
	('bob', 'smith', '124-124-1242'),
	('mary', 'ann', '124-124-1242'),
	('tex', 'burns', '124-124-1242'),
	('gerry', 'kerns', '124-124-1242'),
	('sally', 'fields', '124-124-1242')
;

UPDATE tbl_persons SET persons_fname = 'mars' WHERE persons_fname = 'bob';

SELECT * FROM tbl_persons;
SELECT persons_fname, persons_lname, persons_contact FROM tbl_persons WHERE persons_lname LIKE '_u%s';
SELECT persons_fname AS 'First Name', persons_lname AS 'Last Name', persons_contact As 'Phone:' FROM tbl_persons WHERE persons_fname LIKE 'm%' ORDER BY persons_lname DESC;

DELETE FROM tbl_persons WHERE persons_lname = 'smith';

DROP TABLE tbl_persons;