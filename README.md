### Задача №2
Для решения задачи №2 необходимо организовать связь многие ко многим, 
для этого потребуется дополнительная таблица(ProductCategory) которая будет хранить эти связи.
### Тестовые данные

#### Products

| id |    name    |
|----|------------|
|  1 | prod1      |
|  2 | prod2      |
|  3 | prod3      |
|  4 | emptyProd4 |

#### Category

| id | name |
|----|------|
|  1 | cat1 |
|  2 | cat2 |

#### ProductCategory

| products_id | category_id |
|-------------|-------------|
|           1 |           2 |
|           2 |           1 |
|           3 |           2 |

### Итоговый SQL выглядит так:
```SQL
SELECT p.name Product, c.name Category 
FROM Products AS p
LEFT JOIN ProductCategory AS pc ON p.id = pc.products_id
LEFT JOIN Category AS c ON c.id = pc.category_id
```
### Вывод:
|  Product   | Category |
|------------|----------|
| prod1      | cat2     |
| prod2      | cat1     |
| prod3      | cat2     |
| emptyProd4 | NULL     |
