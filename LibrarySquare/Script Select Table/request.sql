Create table Product(
	id_Product bigint primary key,
	NameProduct text not null
);
create table Category(
	id_Category bigint primary key,
	NameCategory text not null
);
Create table Category_Product(
	id_Category_Product bigint primary key,
	Category_id bigint,
	Product_id bigint not null,
	foreign key (Category_id) references Category (id_Category) ON DELETE CASCADE,
	foreign key (Product_id) references Product (id_Product) ON DELETE CASCADE
);

INSERT INTO Product (id_Product, NameProduct) VALUES
(1, 'Product 1'),
(2, 'Product 2'),
(3, 'Product 3');

INSERT INTO Category (id_Category, NameCategory) VALUES
(1, 'Category 1'),
(2, 'Category 2'),
(3, 'Category 3');

INSERT INTO Category_Product (id_Category_Product, Category_id, Product_id) VALUES
(1, 1, 1),
(2, null, 2),
(3, 3, 3);

SELECT Product.NameProduct, Category.NameCategory 
FROM Category_Product 
LEFT JOIN Product ON Category_Product.Product_id = Product.id_Product 
LEFT JOIN Category ON Category_Product.Category_id = Category.id_Category;
