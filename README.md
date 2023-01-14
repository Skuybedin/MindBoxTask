# Задача на C#

*Напишите на C# библиотеку для поставки внешним клиентам, которая умеет вычислять площадь круга по радиусу и треугольника по трем сторонам. Дополнительно к работоспособности оценим:*

 *- Юнит-тесты*
 
 *- Легкость добавления других фигур*
 
 *- Вычисление площади фигуры без знания типа фигуры*
 
 *- Проверку на то, является ли треугольник прямоугольным"*
 
 ### Решение задачи:
Тут находится сам класс [ТЫК](https://github.com/Skuybedin/MindBoxTask/blob/master/MindBoxLib/CalcSquare.cs)

А тут Unit тесты [ТЫК](https://github.com/Skuybedin/MindBoxTask/blob/master/MindBoxLib.Tests/CalcSquareTest.cs)

# Задача на SQL

*В базе данных MS SQL Server есть продукты и категории. Одному продукту может соответствовать много категорий, в одной категории может быть много продуктов. Напишите SQL запрос для выбора всех пар «Имя продукта – Имя категории». Если у продукта нет категорий, то его имя все равно должно выводиться.*

###  Сначала создадим структуру БД:
    CREATE TABLE Products(
    id INT PRIMARY KEY IDENTITY, 
    name VARCHAR(255) NOT NULL);
    
    CREATE TABLE Category(
    id INT PRIMARY KEY IDENTITY,
    name VARCHAR(255) NOT NULL);
    
    CREATE TABLE ProdCat(
    products_id INT NOT NULL,
    category_id INT NOT NULL,
    FOREIGN KEY(products_id) REFERENCES Products(id) ON DELETE CASCADE,
    FOREIGN KEY(category_id) REFERENCES Category(id) ON DELETE CASCADE);
    
    CREATE UNIQUE INDEX prod_cat ON ProdCat(products_id, category_id);

###  Заполним базы данных:
    INSERT INTO Products VALUES('Бумага'), ('Ножницы'), ('Ложка');
    INSERT INTO Category VALUES('Канцелярия'), ('Столовые приборы');
    INSERT INTO ProdCat VALUES(1, 1), (2, 1), (3, 2);

### Решение задачи:
    SELECT p.name AS product, c.name AS category FROM Products AS p
    LEFT JOIN ProdCat AS pc ON p.id = pc.products_id
    INNER JOIN Category AS c ON c.id = pc.category_id
    ORDER BY product;
