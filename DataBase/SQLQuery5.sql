INSERT INTO Suppliers (Id, SupplierName,City, Country) VALUES (6,'Norske Meierier','Lviv','Ukraine');
INSERT INTO Products (Id,SupplierID,ProductName,Price,CategoryID) values (6,(SELECT Suppliers.Id from Suppliers where Suppliers.SupplierName='Norske Meierier'),'Green tea',10,1);

