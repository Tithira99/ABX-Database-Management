CREATE DATABASE abx_furniture;

USE abx_furniture;

CREATE TABLE Product
(
productID INT NOT NULL,
Prod_Des VARCHAR(50),
S_UnitPrice INT,
B_UnitPrice INT,
Available_quty INT,
CONSTRAINT pk_pid PRIMARY KEY(productID),
CONSTRAINT chk_Bs CHECK (S_UnitPrice>B_UnitPrice)
);
DROP TABLE Product;

CREATE TABLE Customer
(
CustomerID VARCHAR(10) NOT NULL,
CustomerName VARCHAR(40),
Cust_Address VARCHAR(40),
Tel_No VARCHAR(10),
CONSTRAINT pk_cid PRIMARY KEY(CustomerID)
);

DROP TABLE Customer;

CREATE TABLE OrderResult
(
ResultID VARCHAR(10),
SubTotal INT,
TotalDiscount INT,
Total INT,
CONSTRAINT pk_rid PRIMARY KEY(ResultID)
);

DROP TABLE OrderResult;




CREATE TABLE Employee
(
EmployeeID VARCHAR(10) NOT NULL,
EmployeeName VARCHAR(30),
CONSTRAINT pk_eid PRIMARY KEY(EmployeeID)
);

DROP TABLE Employee;


CREATE TABLE Supplier
(
SupplierID VARCHAR(10) NOT NULL,
Sup_Name VARCHAR(30),
Sup_Address VARCHAR(50)
CONSTRAINT pk_sid PRIMARY KEY(SupplierID)
);

DROP TABLE Supplier;




CREATE TABLE Order_details
(
OrderID VARCHAR(10) NOT NULL,
ProductID INT NOT NULL,
CustomerID VARCHAR(10) NOT NULL,
OrderDate DATE,
Quantity INT,
Prod_Discount INT,
CONSTRAINT pk_oid_prod PRIMARY KEY(OrderID, ProductID),
CONSTRAINT fk_pid FOREIGN KEY(productID) REFERENCES Product(productID),
CONSTRAINT fk_cid FOREIGN KEY(customerID) REFERENCES Customer(customerID),
);

DROP TABLE Order_details;


	


 
CREATE TABLE GRN_details
(
GRN_No VARCHAR(10) NOT NULL,
productID INT NOT NULL,
ReceivedBy VARCHAR(10) NOT NULL,
CheckedBy VARCHAR(10) NOT NULL,
SupplierID VARCHAR(10) NOT NULL,
purchase_quty INT,
Requested_Date DATETIME,
Delevered_Date DATETIME,
CONSTRAINT pk_grnNO_pid PRIMARY KEY(GRN_No, productID),
CONSTRAINT fk_pid1 FOREIGN KEY(productID) REFERENCES Product(productID),
CONSTRAINT fk_r1 FOREIGN KEY(ReceivedBy) REFERENCES Employee(EmployeeID),
CONSTRAINT fk_c1 FOREIGN KEY(CheckedBy) REFERENCES Employee(EmployeeID),
CONSTRAINT fk_sid FOREIGN KEY(SupplierID) REFERENCES Supplier(SupplierID)
);

DROP TABLE GRN_details;


SELECT * FROM Product;





SELECT * FROM Employee;

SELECT * FROM Supplier;


CREATE TRIGGER Updatestock1
ON GRN_details 
FOR INSERT,UPDATE
AS
BEGIN
UPDATE Product 
SET Available_quty =p.Available_quty + g.purchase_quty
FROM Product p, GRN_details g
WHERE p.ProductID=g.ProductID
END

CREATE TRIGGER Updatestock
ON Order_details 
FOR INSERT,UPDATE
AS
BEGIN
UPDATE Product 
SET Available_quty =p.Available_quty-o.Quantity
FROM Product p, Order_details o
WHERE p.ProductID=o.ProductID
END
UPDATE Product SET Available_quty=0 WHERE ProductID=127;

