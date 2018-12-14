
--This Code just brings up all the info reqired to contact anyone, and takes in a first name and a last name,
--or neither, but that will return everything.
CREATE PROC dbo.findContactInfo
@fname VARCHAR(50) = NULL, @lname VARCHAR(50) = NULL
AS
BEGIN
	SELECT
	a1.BusinessEntityID, a1.FirstName AS 'First Name:', a1.LastName AS 'Last Name:',
	a2.EmailAddress AS 'Email Address:', a3.PhoneNumber AS 'Phone Number:', 
	a4.Name AS 'Phone Type:', a6.AddressLine1 AS 'Address Line 1:',
	a6.City AS 'City:', a8.Name AS 'State/Province:',
	a9.Name AS 'Country:', a7.Name AS 'Address Type:'
	FROM Person.Person a1
	INNER JOIN Person.EmailAddress a2 ON a2.BusinessEntityID = a1.BusinessEntityID
	INNER JOIN Person.PersonPhone a3 ON a3.BusinessEntityID = a1.BusinessEntityID
	INNER JOIN Person.PhoneNumberType a4 ON a4.PhoneNumberTypeID = a3.PhoneNumberTypeID
	INNER JOIN Person.BusinessEntityAddress a5 ON a5.BusinessEntityID = a1.BusinessEntityID
	INNER JOIN Person.Address a6 ON a6.AddressID = a5.AddressID
	INNER JOIN Person.AddressType a7 ON a7.AddressTypeID = a5.AddressTypeID
	INNER JOIN Person.StateProvince a8 ON a8.StateProvinceID = a6.StateProvinceID
	INNER JOIN Person.CountryRegion a9 ON a9.CountryRegionCode = a8.CountryRegionCode
	WHERE a1.FirstName LIKE ISNULL(@fname + '%', a1.FirstName) AND a1.LastName LIKE ISNULL(@lname + '%', a1.LastName)
	ORDER BY a1.BusinessEntityID
	;
END
;