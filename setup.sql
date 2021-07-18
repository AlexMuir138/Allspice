CREATE table Ingredients(
  id INT NOT NULL AUTO_INCREMENT,
  title VARCHAR (255) NOT NULL,
  imgUrl VARCHAR (255),
  PRIMARY KEY (id)
);

INSERT INTO Ingredients(title, imgUrl) VALUES ("Cimmanin", "https://m.media-amazon.com/images/I/81sr2AD3FjL._SL1500_.jpg");
INSERT INTO Ingredients(title, imgUrl) VALUES ("Pepper", "https://cdn11.bigcommerce.com/s-huvlpt80bj/images/stencil/1280x1280/products/39/5/Black_Pepper__49501.1526734150.JPG?c=2");

SELECT id, title, imgUrl From Ingredients;

SELECT * FROM Ingredients WHERE id = 1;
UPDATE Ingredients Set title = "black pepper" WHERE id = 2;

DELETE FROM Ingredients WHERE id = 1;