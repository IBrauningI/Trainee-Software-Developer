select Suppliers.SupplierName
from Suppliers,Products,Categories
where Suppliers.Id = Products.SupplierID and Categories.Id = Products.CategoryID and Categories.CategoryName = 'Condiments' 