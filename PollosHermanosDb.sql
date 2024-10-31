drop DATABASE polloshermanosdb;

create database polloshermanosdb;
use polloshermanosdb;




    

CREATE TABLE Platillos (
    ID INT auto_increment PRIMARY KEY,
    Nombre VARCHAR(255),
    Precio FLOAT,
    Tipo VARCHAR(255),
    Caracteristica VARCHAR(255),
    Descripcion VARCHAR(255),
    Activo smallint not null default 1
);



CREATE TABLE Bebidas (
    ID INT auto_increment PRIMARY KEY,
    Nombre VARCHAR(255),
    Precio FLOAT,
    Tipo VARCHAR(255),
	caracteristica VARCHAR(255),
    Descripcion VARCHAR(255),
    Activo smallint not null  default 1
);

CREATE TABLE FUNCIONARIO (
    ID INT auto_increment PRIMARY KEY,
    Nombre VARCHAR(255) not null unique,
    tipo varchar(255) not null,
	sueldo DECIMAL(10, 2) NOT NULL,
    contrasena VARCHAR(255),
    Activo smallint not null default 1
);
CREATE TABLE Mesa (
    ID INT AUTO_INCREMENT PRIMARY KEY,
    NoMesa varchar(25),
    Area  varchar(1) not null, 
    Activo smallint default 1,
    mesero int,
    FOREIGN KEY (mesero) REFERENCES funcionario(id));
    
    
UPDATE MESA SET ACTIVO = 0, mesero = 1  WHERE ID = 2;


CREATE TABLE Pedido (
    ID int auto_increment PRIMARY KEY,
    NumeroMesa int,
    Cliente VARCHAR(255),
    detallesPedido JSON,
    fecha date,
    Mesero INT,
    Total_a_pagar DECIMAL(10, 2),
    metodo_de_Pago varchar(15),
    Activo varchar(1) not null  default 1,
    FOREIGN KEY (NumeroMesa) REFERENCES Mesa(id),
    FOREIGN KEY (mesero) REFERENCES funcionario(id));


select id from funcionario where nombre= "Christian";


CREATE TABLE Pago_efectivo (
    ID INT auto_increment PRIMARY KEY,
    Pedido INT,
    Total FLOAT,
    Cliente VARCHAR(255),
    FOREIGN KEY (pedido) REFERENCES Pedido(id)
);

CREATE TABLE Pago_tarjeta (
    ID INT auto_increment PRIMARY KEY,
    Tipo INT,
    pedido INT,
    Total FLOAT,
    Cliente VARCHAR(255),
    DUI_cliente varchar(10),
    FOREIGN KEY (pedido) REFERENCES Pedido(ID)
);

-- Inserción en la tabla Platillos
INSERT INTO Platillos (Nombre, Precio, Tipo, caracteristica, Descripcion, activo)
VALUES
('Pollo Frito Hermanos', 12.99, 'Alimento', 'Plato Fuerte', 'Pollo frito con la receta secreta', 1),
('Tacos de Pollo', 8.99, 'Alimento', 'Plato Fuerte', 'Tacos rellenos de pollo y guacamole', 1),
('Burrito de Pollo Picante', 9.99, 'Alimento', 'Plato Fuerte', 'Burrito relleno de pollo y salsa picante', 1),
('Ensalada César con Pollo', 7.99, 'Alimento', 'Plato Entrada', 'Ensalada fresca con pollo a la parrilla', 1),
('Quesadilla de Pollo', 6.99, 'Alimento', 'Plato Entrada', 'Quesadilla rellena de pollo y queso fundido', 1),
('Nachos Hermanos', 5.99, 'Alimento', 'Plato Entrada', 'Nachos con pollo, queso y guacamole', 1),
('Alitas de Pollo Buffalo', 10.99, 'Alimento', 'Plato Fuerte', 'Alitas de pollo bañadas en salsa buffalo', 1),
('Pollo Asado con Papas', 11.99, 'Alimento', 'Plato Fuerte', 'Pollo asado con papas fritas', 1),
('Empanadas de Pollo', 4.99, 'Alimento', 'Plato Entrada', 'Empanadas rellenas de pollo y especias', 1),
('Flan de Cajeta', 3.99, 'Alimento', 'Postre', 'Flan con un toque de cajeta', 1);

-- Inserción en la tabla Bebidas
INSERT INTO Bebidas (Nombre, Precio, Tipo, caracteristica, Descripcion, activo)
VALUES
('Limonada Hermanos', 2.99, 'Bebida', 'Bebida Fría', 'Limonada fresca con menta', 1),
('Margarita Tradicional', 5.99, 'Bebida', 'Bebida Fría', 'Margarita clásica con sal', 1),
('Café Negro', 1.99, 'Bebida', 'Bebida Caliente', 'Café negro recién hecho', 1),
('Té Helado', 2.49, 'Bebida', 'Bebida Fría', 'Té helado con un toque de limón', 1),
('Chocolate Caliente', 3.49, 'Bebida', 'Bebida Caliente', 'Chocolate caliente cremoso', 1),
('Agua Mineral', 1.49, 'Bebida', 'Bebida Fría', 'Agua mineral con gas', 1),
('Jugo de Naranja', 2.99, 'Bebida', 'Bebida Fría', 'Jugo de naranja natural', 1),
('Michelada Hermanos', 4.99, 'Bebida', 'Bebida Fría', 'Cerveza con jugo de limón, salsa y especias', 1),
('Cappuccino', 3.99, 'Bebida', 'Bebida Caliente', 'Cappuccino con espuma de leche', 1),
('Batido de Fresa', 4.49, 'Bebida', 'Bebida Fría', 'Batido de fresa con crema batida', 1);

INSERT INTO FUNCIONARIO (Nombre, tipo, contrasena, activo, sueldo)
VALUES
('Juan Pérez', 'Mesero', '123', 1, 500.00),
('Ana Gómez', 'Cocinero', '456', 1, 500.00),
('Carlos Martínez', 'Gerente', '789', 1, 500.00),
('Christian  Carcamo', 'Mesero', '7885', 1, 500.00);
INSERT INTO Mesa (NoMesa, area, activo)
VALUES 
('Para Llevar', 'A', 0),
('A1', 'A', 1),
('A2', 'A', 1),
('A3', 'A', 1),
('A4', 'A', 1),
('A5', 'A', 1),
('A6', 'A', 1),
('A7', 'A', 1),
('A8', 'A', 1),
('A9', 'A', 1),
('A10', 'A', 1),

('B1', 'B', 1),
('B2', 'B', 1),
('B3', 'B', 1),
('B4', 'B', 1),
('B5', 'B', 1),
('B6', 'B', 1),
('B7', 'B', 1),
('B8', 'B', 1),
('B9', 'B', 1),
('B10', 'B', 1),

('C1', 'C', 1),
('C2', 'C', 1),
('C3', 'C', 1),
('C4', 'C', 1),
('C5', 'C', 1),
('C6', 'C', 1),
('C7', 'C', 1),
('C8', 'C', 1),
('C9', 'C', 1),
('C10', 'C', 1),

('D1', 'D', 1),
('D2', 'D', 1),
('D3', 'D', 1),
('D4', 'D', 1),
('D5', 'D', 1),
('D6', 'D', 1),
('D7', 'D', 1),
('D8', 'D', 1),
('D9', 'D', 1),
('D10', 'D', 1),

('E1', 'E', 1),
('E2', 'E', 1),
('E3', 'E', 1),
('E4', 'E', 1),
('E5', 'E', 1),
('E6', 'E', 1),
('E7', 'E', 1),
('E8', 'E', 1),
('E9', 'E', 1),
('E10', 'E', 1);

select * from pedido;


INSERT INTO Pedido (
    NumeroMesa, Cliente,
    detallesPedido, 
    fecha, 
    Mesero, 
    Total_a_pagar,
    Activo
) VALUES (
    3, "messi",
    '{
        "platillos": [
            {"nombre": "Tacos", "cantidad": 3, "precio": 5.00},
            {"nombre": "Enchiladas", "cantidad": 2, "precio": 7.50}
        ],
        "bebidas": [
            {"nombre": "Coca Cola", "cantidad": 2, "precio": 1.50}
        ]
    }', 
    '2023-10-01', 
    2, 2000, 1
);


SELECT id,NoMesa FROM mesa WHERE mesero = 4 && area = "A";

select * from mesa;

SELEct
    p.ID AS PedidoID,
    m.NoMesa,
    p.Cliente,
    p.detallesPedido,
    p.fecha,
    f.Nombre AS Mesero,
    p.Total_a_pagar,
    p.Activo
FROM
    Pedido p
INNER JOIN
    Mesa m ON p.NumeroMesa = m.ID
INNER JOIN
    Funcionario f ON p.Mesero = f.ID