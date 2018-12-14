-- Creating Database named db_libManageSys --
CREATE DATABASE db_libManageSys

USE db_libManageSys
GO

-- Creating Tables
CREATE TABLE tbl_libBranch (
	libBranch_id INT PRIMARY KEY NOT NULL IDENTITY (0, 1),
	libBranch_name VARCHAR(50) NOT NULL,
	libBranch_address VARCHAR(50) NOT NULL,
);

CREATE TABLE tbl_publisher (
	publisher_name VARCHAR(50) PRIMARY KEY NOT NULL,
	publisher_address VARCHAR(50) NOT NULL,
	publisher_phone VARCHAR(50) NOT NULL,
);

CREATE TABLE tbl_books (
	books_id INT PRIMARY KEY NOT NULL IDENTITY (0, 1),
	books_title VARCHAR(50) NOT NULL,
	books_publisher VARCHAR(50) NOT NULL CONSTRAINT fk_books_publisher FOREIGN KEY REFERENCES tbl_publisher(publisher_name) ON UPDATE CASCADE ON DELETE CASCADE
);

CREATE TABLE tbl_borrower (
	borrower_cardNo INT PRIMARY KEY NOT NULL IDENTITY (0, 1),
	borrower_name VARCHAR(50) NOT NULL,
	borrower_address VARCHAR(50) NOT NULL,
	borrower_phone VARCHAR(50) NOT NULL
);

CREATE TABLE tbl_bookAuthors (
	bookAuthors_bookId INT NOT NULL CONSTRAINT fk_bookAuthors_bookId FOREIGN KEY REFERENCES tbl_books(books_id) ON UPDATE CASCADE ON DELETE CASCADE,
	bookAuthors_name VARCHAR(50) NOT NULL
);

CREATE TABLE tbl_bookCopies (
	bookCopies_bookId INT NOT NULL CONSTRAINT fk_bookCopies_bookId FOREIGN KEY REFERENCES tbl_books(books_id) ON UPDATE CASCADE ON DELETE CASCADE,
	bookCopies_branchId INT NOT NULL CONSTRAINT fk_bookCopies_branchId FOREIGN KEY REFERENCES tbl_libBranch(libBranch_id) ON UPDATE CASCADE ON DELETE CASCADE,
	bookCopies_amount INT NOT NULL
);

CREATE TABLE tbl_bookLoans (
	bookLoans_bookId INT NOT NULL CONSTRAINT fk_bookLoans_bookId FOREIGN KEY REFERENCES tbl_books(books_id) ON UPDATE CASCADE ON DELETE CASCADE,
	bookLoans_branchId INT NOT NULL CONSTRAINT fk_bookLoans_branchId FOREIGN KEY REFERENCES tbl_libBranch(libBranch_id) ON UPDATE CASCADE ON DELETE CASCADE,
	bookLoans_cardNo INT NOT NULL CONSTRAINT fk_bookLoans_cardNo FOREIGN KEY REFERENCES tbl_borrower(borrower_cardNo) ON UPDATE CASCADE ON DELETE CASCADE,
	bookLoans_dateOut DATE NOT NULL,
	bookLoans_dateDue DATE NOT NULL	
);

-- Populate Tables
INSERT INTO tbl_libBranch -- These are made up, only by coincidence would they be actual places/addresses.
	(libBranch_name, libBranch_address)
	VALUES
	('Sharptown', '9999 S Sharpest ST, Sharptown OR'),
	('Central', '9987 S Mosty RD, Central OR'),
	('Beaches', '9990 W Pacific ST, Beaches OR'),
	('North Grove', '9992 Bushes AVE, North Grove OR')
;
SELECT * FROM tbl_libBranch;

INSERT INTO tbl_publisher -- These are made up, only by coincidence would they be actual publishers/addresses/phone numbers.
	(publisher_name, publisher_address, publisher_phone)
	VALUES
	('GoodBooks', '8070 Cortan RD, Doaking TX', '+1-123-456-7890'),
	('CentralPublishing', '8394 S 3rd ST, Central OR', '(124)356-7890')
;
SELECT * FROM tbl_publisher;

INSERT INTO tbl_books -- I found a lot of these books by just searching randomly, I am unaware if any of these books are inappropriate.
	(books_title, books_publisher)
	VALUES
	('The Lost Tribe', 'GoodBooks'), ('It', 'GoodBooks'), ('The Shining', 'GoodBooks'), ('Silver', 'CentralPublishing'),
	('The Merchant of Death (Pendragon)', 'GoodBooks'), ('The Lost City of Faar (Pendragon)', 'GoodBooks'),
	('The Never War (Pendragon)', 'GoodBooks'), ('The Reality Bug (Pendragon)', 'GoodBooks'), ('Black Water (Pendragon)', 'GoodBooks'),
	('The Rivers of Zadaa (Pendragon)', 'GoodBooks'), ('The Quillan Games (Pendragon)', 'GoodBooks'),
	('The Pilgrims of Rayne (Pendragon)', 'GoodBooks'), ('Raven Rise (Pendragon)', 'GoodBooks'),
	('The Soldiers of Halla (Pendragon)', 'GoodBooks'), ('Adventures of Huckleberry Finn', 'GoodBooks'),
	('Covert Game', 'CentralPublishing'), ('Dragon''s Code', 'CentralPublishing'), ('Search Image', 'CentralPublishing'),
	('Moderan', 'CentralPublishing'), ('Salvation', 'CentralPublishing'), ('Terra Incognita', 'CentralPublishing')
;
SELECT * FROM tbl_books

INSERT INTO tbl_bookAuthors
	(bookAuthors_bookId, bookAuthors_name)
	VALUES
	(0, 'Mark Lee'), (1, 'Stephen King'), (2, 'Stephen King'), (3, 'Chris Wooding'), (4, 'D.J.MacHale'),
	(5, 'D.J.MacHale'), (6, 'D.J.MacHale'), (7, 'D.J.MacHale'), (8, 'D.J.MacHale'), (9, 'D.J.MacHale'),
	(10, 'D.J.MacHale'), (11, 'D.J.MacHale'), (12, 'D.J.MacHale'), (13, 'D.J.MacHale'), (14, 'Mark Twain'),
	(15, 'Christine Feehan'), (16, 'Gigi McCaffrey'), (17, 'Julie E. Czerneda'), (18, 'David R. Bunch'),
	(19, 'Peter F. Hamilton'), (20, 'Connie Willis')
;
SELECT * FROM tbl_bookAuthors;

INSERT INTO tbl_borrower -- These are made up, only by coincidence would they be actual people/addresses/phone numbers.
	(borrower_name, borrower_address, borrower_phone)
	VALUES
	('Samuel Richardson', '7757 Crusade DR, Beaches OR', '(125)346-0900'),
	('Archibald LaStau', '7324 Zap ST, Central OR', '(125)346-0877'),
	('Elisabeth LaStau', '7324 Zap ST, Central OR', 'N/A'),
	('Esteban Luis Dillo', '7128 W Pacific ST, Beaches OR', '(125)346-9088'),
	('Tim C. Cross', '7800 Hot Water ST, Sharptown OR', '(125)346-7800'),
	('Billy Hodgeson', '7543 Creature RD NE, North Grove OR', '(125)346-8777'),
	('Caroline Quinton', '7504 Flow Side ST, Gravity OR', '(125)346-0088'),
	('Opal Faith Deep-Stone', '7003 Stupor CT, Sharptown OR', '(125)346-9780'),
	('Jack DeNorth-Whall', '7442 Country RD, Central OR', '(125)346-9997'),
	('Mystery Hamsmith', '7209 Handle ST, Sharptown OR', '(125)346-7889')
;
SELECT * FROM tbl_borrower;

INSERT INTO tbl_bookCopies
	(bookCopies_bookId, bookCopies_branchId, bookCopies_amount)
	VALUES
	( 0, 0, 4), ( 0, 1, 2), ( 0, 2, 2), ( 0, 3, 0),
	( 1, 0, 2), ( 1, 1, 2), ( 1, 2, 2), ( 1, 3, 2),
	( 2, 0, 2), ( 2, 1, 2), ( 2, 2, 2), ( 2, 3, 2),
	( 3, 0, 0), ( 3, 1, 2), ( 3, 2, 0), ( 3, 3, 0),
	( 4, 0, 2), ( 4, 1, 3), ( 4, 2, 2), ( 4, 3, 2),
	( 5, 0, 2), ( 5, 1, 3), ( 5, 2, 2), ( 5, 3, 2),
	( 6, 0, 2), ( 6, 1, 3), ( 6, 2, 2), ( 6, 3, 2),
	( 7, 0, 2), ( 7, 1, 3), ( 7, 2, 2), ( 7, 3, 2),
	( 8, 0, 2), ( 8, 1, 3), ( 8, 2, 2), ( 8, 3, 2),
	( 9, 0, 2), ( 9, 1, 3), ( 9, 2, 2), ( 9, 3, 2),
	(10, 0, 2), (10, 1, 3), (10, 2, 2), (10, 3, 2),
	(11, 0, 2), (11, 1, 3), (11, 2, 2), (11, 3, 2),
	(12, 0, 2), (12, 1, 3), (12, 2, 2), (12, 3, 2),
	(13, 0, 2), (13, 1, 2), (13, 2, 2), (13, 3, 2),
	(14, 0, 4), (14, 1, 5), (14, 2, 2), (14, 3, 3),
	(15, 0, 0), (15, 1, 2), (15, 2, 2), (15, 3, 2),
	(16, 0, 2), (16, 1, 2), (16, 2, 0), (16, 3, 0),
	(17, 0, 0), (17, 1, 2), (17, 2, 0), (17, 3, 0),
	(18, 0, 0), (18, 1, 2),	(18, 2, 2), (18, 3, 0),
	(19, 0, 2),	(19, 1, 2),	(19, 2, 0),	(19, 3, 2),
	(20, 0, 2), (20, 1, 3), (20, 2, 2), (20, 3, 2)
;
SELECT bookCopies_branchId, bookCopies_bookId, bookCopies_amount FROM tbl_bookCopies ORDER BY bookCopies_branchId, bookCopies_bookId;

SELECT 
	a3.books_id AS 'ID', a3.books_title AS 'Title', a1.bookAuthors_name AS 'Author'
	FROM tbl_bookAuthors a1
	INNER JOIN tbl_books a3 ON a3.books_id = a1.bookAuthors_bookId
;
SELECT borrower_cardNo AS 'ID', borrower_name AS 'Name', borrower_address AS 'Address' FROM tbl_borrower;
SELECT libBranch_id AS 'ID', libBranch_name AS 'Name' FROM tbl_libBranch;

INSERT INTO tbl_bookLoans -- Dates will be read as though today is May 25th 2018
	(bookLoans_bookId, bookLoans_branchId, bookLoans_cardNo, bookLoans_dateOut, bookLoans_dateDue)
	VALUES
	(0, 2, 0, '2018-05-23', '2018-06-12'),
	(4, 2, 0, '2018-05-23', '2018-06-12'),
	(5, 2, 0, '2018-05-23', '2018-06-12'),
	(6, 2, 0, '2018-05-23', '2018-06-12'),
	(7, 2, 0, '2018-05-23', '2018-06-12'),
	(8, 2, 0, '2018-05-23', '2018-06-12'),
	(15, 2, 0, '2018-05-14', '2018-06-03'),
	(0, 1, 1, '2018-05-18', '2018-06-07'),
	(1, 1, 1, '2018-05-18', '2018-06-07'),
	(2, 1, 1, '2018-05-18', '2018-06-07'), -- 10th
	(14, 1, 1, '2018-05-18', '2018-06-07'),
	(20, 1, 1, '2018-05-18', '2018-06-07'),
	(4, 1, 2, '2018-05-18', '2018-06-07'),
	(16, 1, 2, '2018-05-18', '2018-06-07'),
	(1, 1, 2, '2018-05-19', '2018-06-08'),
	(0, 2, 3, '2018-05-25', '2018-06-14'),
	(1, 2, 3, '2018-05-25', '2018-06-14'),
	(2, 2, 3, '2018-05-25', '2018-06-14'),
	(17, 2, 3, '2018-05-25', '2018-06-14'),
	(18, 2, 3, '2018-05-25', '2018-06-14'), -- 20th
	(19, 2, 3, '2018-05-25', '2018-06-14'),
	(0, 0, 4, '2018-03-02', '2018-03-22'),
	(0, 1, 4, '2018-05-09', '2018-05-29'),
	(3, 1, 4, '2018-05-09', '2018-05-29'),
	(4, 3, 5, '2018-05-18', '2018-06-07'),
	(5, 3, 5, '2018-05-18', '2018-06-07'),
	(6, 3, 5, '2018-05-18', '2018-06-07'),
	(7, 3, 5, '2018-05-18', '2018-06-07'),
	(8, 3, 5, '2018-05-18', '2018-06-07'),
	(9, 3, 5, '2018-05-18', '2018-06-07'), -- 30th
	(10, 3, 5, '2018-05-18', '2018-06-07'),
	(11, 3, 5, '2018-05-18', '2018-06-07'),
	(12, 3, 5, '2018-05-18', '2018-06-07'),
	(13, 3, 5, '2018-05-18', '2018-06-07'),
	(15, 3, 5, '2018-05-18', '2018-06-07'),
	(17, 3, 5, '2018-05-18', '2018-06-07'),
	(18, 3, 5, '2018-05-18', '2018-06-07'),
	(19, 3, 5, '2018-05-18', '2018-06-07'),
	(0, 0, 6, '2018-05-10', '2018-05-30'),
	(1, 0, 6, '2018-05-10', '2018-05-30'), -- 40th
	(2, 0, 6, '2018-05-17', '2018-06-06'),
	(7, 0, 6, '2018-05-17', '2018-06-06'),
	(8, 0, 6, '2018-05-24', '2018-06-13'),
	(9, 0, 6, '2018-05-24', '2018-06-13'),
	(0, 0, 7, '2018-05-10', '2018-05-30'),
	(1, 0, 7, '2018-05-10', '2018-05-30'),
	(2, 0, 7, '2018-05-17', '2018-06-06'),
	(7, 0, 7, '2018-05-17', '2018-06-06'),
	(8, 0, 7, '2018-05-24', '2018-06-13'),
	(9, 0, 7, '2018-05-24', '2018-06-13'), -- 50th
	(0, 0, 9, '2018-05-05', '2018-05-25'),
	(4, 0, 9, '2018-05-05', '2018-05-25')
;
SELECT * FROM tbl_bookLoans

-- Creating Stored Procedures
--
-- These need to be done one at a time. The first one gives me a red underline error despite actually working, so I won't do anything
--
-- 1.) How many copies of the book titled "The Lost Tribe" are owned by the library branch whose name is "Sharpstown"?

CREATE PROC dbo.getTheLostTribeBookCountInSharptown
AS
BEGIN
	SELECT
	a3.books_title AS 'Title', a2.libBranch_name AS 'Branch Name', a1.bookCopies_amount AS 'Amount'
	FROM tbl_bookCopies a1
	INNER JOIN tbl_libBranch a2 ON a2.libBranch_id = a1.bookCopies_branchId
	INNER JOIN tbl_books a3 ON a3.books_id = a1.bookCopies_bookId
	WHERE a3.books_title = 'The Lost Tribe' AND a2.libBranch_name = 'Sharptown'
	;
END
;

-- 2.)  How many copies of the book titled "The Lost Tribe" are owned by each library branch?
CREATE PROC dbo.getTheLostTribeBookCount
AS
BEGIN
	SELECT
	a3.books_title AS 'Title', a2.libBranch_name AS 'Branch Name', a1.bookCopies_amount AS 'Amount'
	FROM tbl_bookCopies a1
	INNER JOIN tbl_libBranch a2 ON a2.libBranch_id = a1.bookCopies_branchId
	INNER JOIN tbl_books a3 ON a3.books_id = a1.bookCopies_bookId
	WHERE a3.books_title = 'The Lost Tribe'
	;
END
;

-- 3.) Retrieve the names of all borrowers who do not have any books checked out.
CREATE PROC dbo.getAllWhoBorrowNone
AS
BEGIN
	SELECT a1.borrower_name AS 'Name'
	FROM tbl_borrower a1
	WHERE NOT EXISTS (
		SELECT *
		FROM tbl_bookLoans a2
		WHERE a1.borrower_cardNo = a2.bookLoans_cardNo)
	;
END
;

-- 4.) For each book that is loaned out from the "Sharpstown" branch and whose DueDate is today,
-- retrieve the book title, the borrower's name, and the borrower's address.
CREATE PROC dbo.dueTodayFromSharptown
@today DATE = '2018-05-25'
AS
BEGIN
	SELECT a2.books_title AS 'Title', a3.borrower_name AS 'Name', a3.borrower_address AS 'Address'
	FROM tbl_bookLoans a1
	INNER JOIN tbl_books a2 ON a2.books_id = a1.bookLoans_bookId
	INNER JOIN tbl_borrower a3 ON a3.borrower_cardNo = a1.bookLoans_cardNo
	WHERE a1.bookLoans_dateDue = @today AND a1.bookLoans_branchId = '0'
	;
END
;

-- 5.) For each library branch, retrieve the branch name and the total number of books loaned out from that branch.
CREATE PROC dbo.loanedBooksFromEachBranch
AS
BEGIN
	SELECT a1.libBranch_name AS 'Branch Name', COUNT(a2.bookLoans_branchId) AS 'Count'
	FROM tbl_libBranch a1
	LEFT JOIN tbl_bookLoans a2 ON a2.bookLoans_branchId = a1.libBranch_id
	GROUP BY a1.libBranch_name
	;
END
;

-- 6.) Retrieve the names, addresses, and the number of books checked out for all borrowers who have more than five books checked out.
CREATE PROC dbo.loanedBooksFromEachBorrowerWithFiveOrMore
AS
BEGIN
	SELECT a1.borrower_name AS 'Name', a1.borrower_address AS 'Address', COUNT(a2.bookLoans_branchId) AS 'Count'
	FROM tbl_borrower a1
	LEFT JOIN tbl_bookLoans a2 ON a2.bookLoans_cardNo = a1.borrower_cardNo
	GROUP BY a1.borrower_name, a1.borrower_address
	HAVING COUNT(a2.bookLoans_branchId) >= 5
	;
END
;

-- For each book authored (or co-authored) by "Stephen King", retrieve the title and the number of copies
-- owned by the library branch whose name is "Central".
CREATE PROC dbo.copiesOfBooksByStephenKingFromCentral
AS
BEGIN
	SELECT a2.books_title AS 'title', a3.bookCopies_amount AS 'Count'
	FROM tbl_bookAuthors a1
	INNER JOIN tbl_books a2 ON a2.books_id = a1.bookAuthors_bookId
	LEFT JOIN tbl_bookCopies a3 ON a3.bookCopies_bookId = a1.bookAuthors_bookId
	WHERE a1.bookAuthors_name = 'Stephen King' AND a3.bookCopies_branchId = 1
	;
END
;

[dbo].[getTheLostTribeBookCountInSharptown];
[dbo].[getTheLostTribeBookCount];
[dbo].[getAllWhoBorrowNone];
[dbo].[dueTodayFromSharptown];
[dbo].[loanedBooksFromEachBranch];
[dbo].[loanedBooksFromEachBorrowerWithFiveOrMore];
[dbo].[copiesOfBooksByStephenKingFromCentral];