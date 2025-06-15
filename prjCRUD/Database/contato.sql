CREATE DATABASE bdcontato;

USE bdcontato;

CREATE TABLE Contato (
    Contatoid INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
    ContatoNome VARCHAR(45) NOT NULL,
    ContatoEmail VARCHAR(100) UNIQUE,
    ContatoCelular VARCHAR(15) UNIQUE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;