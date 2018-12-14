/* Drill 7 */
IF EXISTS (SELECT 1 FROM INFORMATION_SCHEMA.TABLES tbl_student)
	DROP TABLE tbl_student, tbl_homeroom
;

CREATE TABLE tbl_homeroom (
	homeroom_id INT PRIMARY KEY NOT NULL IDENTITY (0, 1),
	homeroom_name VARCHAR(50)
);

INSERT INTO tbl_homeroom
	(homeroom_name)
	VALUES
	('Jones'),
	('Smith'),
	('McFromnich')
;

CREATE TABLE tbl_student (
	student_id INT PRIMARY KEY NOT NULL IDENTITY (0, 1),
	student_fname VARCHAR(50) NOT NULL,
	student_lname VARCHAR(50) NOT NULL,
	student_homeroom INT NOT NULL CONSTRAINT fk_student_homeroom FOREIGN KEY REFERENCES tbl_homeroom(homeroom_id) ON UPDATE CASCADE ON DELETE CASCADE
);

INSERT INTO tbl_student
	(student_fname, student_lname, student_homeroom)
	VALUES
	('Kyle', 'Gooseman', 2),
	('Serena', 'Housen', 2),
	('Chance', 'Opzan', 1),
	('Jaquelin', 'Norris', 0),
	('Daisy', 'Smith', 1),
	('Horrace', 'Michaelson', 0)
;

SELECT
	a1.student_fname AS 'First Name:', a1.student_lname AS 'Last Name:', a2.homeroom_name AS 'Homeroom:'
	FROM tbl_student a1
	INNER JOIN tbl_homeroom a2 ON a2.homeroom_id = a1.student_homeroom
;