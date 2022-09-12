ALTER DATABASE CHARACTER SET utf8mb4;
CREATE TABLE IF NOT EXISTS `__EFMigrationsHistory` (
    `MigrationId` varchar(150) CHARACTER SET utf8mb4 NOT NULL,
    `ProductVersion` varchar(32) CHARACTER SET utf8mb4 NOT NULL,
    CONSTRAINT `PK___EFMigrationsHistory` PRIMARY KEY (`MigrationId`)
) CHARACTER SET utf8mb4;

START TRANSACTION;

ALTER DATABASE CHARACTER SET utf8mb4;

CREATE TABLE `Clientes` (
    `Id` int NOT NULL AUTO_INCREMENT,
    `Nome` varchar(200) CHARACTER SET utf8mb4 NOT NULL,
    `CPF` varchar(11) CHARACTER SET utf8mb4 NOT NULL,
    `DataNascimento` datetime(6) NOT NULL,
    CONSTRAINT `PK_Clientes` PRIMARY KEY (`Id`)
) CHARACTER SET utf8mb4;

CREATE TABLE `Filmes` (
    `Id` int NOT NULL AUTO_INCREMENT,
    `Titulo` longtext CHARACTER SET utf8mb4 NULL,
    `ClassificacaoIndicativa` int NOT NULL,
    `Lancamento` tinyint unsigned NOT NULL,
    CONSTRAINT `PK_Filmes` PRIMARY KEY (`Id`)
) CHARACTER SET utf8mb4;

CREATE TABLE `Locacoes` (
    `Id` int NOT NULL AUTO_INCREMENT,
    `Id_Cliente` int NOT NULL,
    `Id_Filme` int NOT NULL,
    `DataLocacao` datetime(6) NOT NULL,
    `DataDevolucao` datetime(6) NOT NULL,
    CONSTRAINT `PK_Locacoes` PRIMARY KEY (`Id`),
    CONSTRAINT `FK_Locacoes_Clientes_Id_Cliente` FOREIGN KEY (`Id_Cliente`) REFERENCES `Clientes` (`Id`) ON DELETE CASCADE,
    CONSTRAINT `FK_Locacoes_Filmes_Id_Filme` FOREIGN KEY (`Id_Filme`) REFERENCES `Filmes` (`Id`) ON DELETE CASCADE
) CHARACTER SET utf8mb4;

CREATE INDEX `IX_Locacoes_Id_Cliente` ON `Locacoes` (`Id_Cliente`);

CREATE INDEX `IX_Locacoes_Id_Filme` ON `Locacoes` (`Id_Filme`);

INSERT INTO `__EFMigrationsHistory` (`MigrationId`, `ProductVersion`)
VALUES ('20220909143051_Inicial', '5.0.5');

COMMIT;

