USE Library

INSERT INTO [Authors]
( 
	[Name], 
	[Last_Name], 
	[Email]
)
VALUES 
(
	'Jane', 
	'Austen', 
	'j.austey@gmail.com'
);


-- ==========
INSERT INTO [Authors]
( 
	[Name], 
	[Last_Name], 
	[Email]
)
VALUES 
(
	'Paulo', 
	'Coelho', 
	'p.coelho@gmail.com'
);


-- ==========
INSERT INTO [Authors]
( 
	[Name], 
	[Last_Name], 
	[Email]
)
VALUES 
(
	'William', 
	'Goldman', 
	'w.goldman@gmail.com'
);


-- ==========

INSERT INTO [Authors]
( 
	[Name], 
	[Last_Name], 
	[Email]
)
VALUES 
(
	'Miguel', 
	'Cervantes', 
	'm.cervantes@gmail.com'
);


-- ==========


INSERT INTO Books
(
	[Id_Author],
	[Title], 
	[Description], 
	[Section], 
	[Genre], 
	[Year], 
	[Publisher]
)
VALUES 
( 
	3,
	'The princess bride', 
	'The book combines elements of comedy and romance', 
	'Family', 
	'Romance', 
	'1973', 
	'Londom-Books'
);
-----===================================


INSERT INTO Books
(
	[Id_Author],
	[Title], 
	[Description], 
	[Section], 
	[Genre], 
	[Year], 
	[Publisher]
)
VALUES 
( 
	1,
	'Pride and Perjudice', 
	'Pride and Prejudice is a romantic novel by Jane Austen, first published in 1813.', 
	'Adults', 
	'Romance', 
	'1813', 
	'Thomas Egerton'
);
----------------------------================
INSERT INTO Books
(
	[Id_Author],
	[Title], 
	[Description], 
	[Section], 
	[Genre], 
	[Year], 
	[Publisher]
)
VALUES 
( 
	4,
	'Sir Quixote of La Mancha', 
	'Is a Spanish novel by Miguel de Cervantes Saavedra. ', 
	'Adventure', 
	'Novel', 
	'1605', 
	'Francisco de Robles'
);


-----------=============
----------------------------================
INSERT INTO Books
(
	[Id_Author],
	[Title], 
	[Description], 
	[Section], 
	[Genre], 
	[Year], 
	[Publisher]
)
VALUES 
( 
	4,
	'Don quijote de la Mancha', 
	'Novela mas influyente en la lengua española ', 
	'Adventura', 
	'Novela', 
	'1605', 
	'Francisco de Robles'
);


-----------=============

INSERT INTO Books
(
	[Id_Author],
	[Title], 
	[Description], 
	[Section], 
	[Genre], 
	[Year], 
	[Publisher]
)
VALUES 
( 
	2,
	'The darkest forest', 
	'Is a novel by Brazilian author Paulo Coelho which was first published in 1988. ', 
	'Adults', 
	'Fear', 
	'1988', 
	'Bright-Books'
);
SELECT * FROM [books];