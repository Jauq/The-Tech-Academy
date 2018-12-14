USE db_zooTes2
GO

/* Drill 1 */
SELECT * FROM tbl_habitat;

/* Drill 2 */
SELECT species_name FROM tbl_species WHERE species_order = 3;

/* Drill 3 */
SELECT nutrition_type FROM tbl_nutrition WHERE nutrition_cost <= 600;

/* Drill 4 */
SELECT species_name FROM tbl_species WHERE species_nutrition BETWEEN 2202 AND 2206;

/* Drill 5 */
SELECT 
	a1.species_name AS 'Species Name:', a2.nutrition_type AS 'Nutrition Type:'
	FROM tbl_species a1
	INNER JOIN tbl_nutrition a2 ON a2.nutrition_id = a1.species_nutrition
;

/* Drill 6 */
SELECT 
	a1.specialist_fname, a1.specialist_lname, a1.specialist_contact 
	FROM tbl_specialist a1, tbl_care a2, tbl_species a3
	WHERE 
		a1.specialist_id = a2.care_specialist AND 
		a2.care_id = a3.species_care AND
		a3.species_name = 'penguin'
;

SELECT 
	a3.specialist_fname, a3.specialist_lname, a3.specialist_contact 
	FROM tbl_species a1
	INNER JOIN tbl_care a2 ON a2.care_id = a1.species_care
	INNER JOIN tbl_specialist a3 ON a3.specialist_id = a2.care_specialist
	WHERE a1.species_name = 'penguin'
;

SELECT * FROM tbl_specialist;
SELECT * FROM tbl_care;
SELECT * FROM tbl_species;