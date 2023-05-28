-- MySQL Script generated by MySQL Workbench
-- Sat May 27 23:08:40 2023
-- Model: New Model    Version: 1.0
-- MySQL Workbench Forward Engineering

SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION';

-- -----------------------------------------------------
-- Schema Bibliotecadb
-- -----------------------------------------------------

-- -----------------------------------------------------
-- Schema Bibliotecadb
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `Bibliotecadb` DEFAULT CHARACTER SET utf8 ;
USE `Bibliotecadb` ;

-- -----------------------------------------------------
-- Table `Bibliotecadb`.`Categoria`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `Bibliotecadb`.`Categoria` (
  `CodCategoria` INT NOT NULL,
  `Descricao` VARCHAR(45) NULL,
  PRIMARY KEY (`CodCategoria`),
  UNIQUE INDEX `CodCategoria_UNIQUE` (`CodCategoria` ASC) VISIBLE)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `Bibliotecadb`.`Livros`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `Bibliotecadb`.`Livros` (
  `ISBN` INT NOT NULL,
  `Titulo` VARCHAR(45) NULL,
  `AnoDeLancamento` INT NULL,
  `Editora` VARCHAR(45) NULL,
  `QuanCopias` INT NULL,
  `Categoria_CodCategoria` INT NOT NULL,
  PRIMARY KEY (`ISBN`),
  INDEX `fk_Livros_Categoria1_idx` (`Categoria_CodCategoria` ASC) VISIBLE,
  CONSTRAINT `fk_Livros_Categoria1`
    FOREIGN KEY (`Categoria_CodCategoria`)
    REFERENCES `Bibliotecadb`.`Categoria` (`CodCategoria`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `Bibliotecadb`.`Autores`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `Bibliotecadb`.`Autores` (
  `Nome` VARCHAR(45) NULL,
  `E-mail` VARCHAR(45) NOT NULL,
  `Nacionalidade` VARCHAR(45) NULL,
  PRIMARY KEY (`E-mail`),
  UNIQUE INDEX `E-mail_UNIQUE` (`E-mail` ASC) VISIBLE)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `Bibliotecadb`.`Livros_has_Autores`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `Bibliotecadb`.`Livros_has_Autores` (
  `Livros_ISBN` INT NOT NULL,
  `Autores_E-mail` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`Livros_ISBN`, `Autores_E-mail`),
  INDEX `fk_Livros_has_Autores_Autores1_idx` (`Autores_E-mail` ASC) VISIBLE,
  INDEX `fk_Livros_has_Autores_Livros_idx` (`Livros_ISBN` ASC) VISIBLE,
  CONSTRAINT `fk_Livros_has_Autores_Livros`
    FOREIGN KEY (`Livros_ISBN`)
    REFERENCES `Bibliotecadb`.`Livros` (`ISBN`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_Livros_has_Autores_Autores1`
    FOREIGN KEY (`Autores_E-mail`)
    REFERENCES `Bibliotecadb`.`Autores` (`E-mail`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `Bibliotecadb`.`Cursos`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `Bibliotecadb`.`Cursos` (
  `CodCurso` INT NOT NULL,
  `NomeCurso` VARCHAR(45) NULL,
  PRIMARY KEY (`CodCurso`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `Bibliotecadb`.`Usuario`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `Bibliotecadb`.`Usuario` (
  `CodUsuario` INT NOT NULL,
  `QntLivros` INT NOT NULL,
  `TipoUsuario` ENUM('Aluno', 'Professor', 'Funcionario') NOT NULL,
  `Senha` VARCHAR(45) NULL,
  `NivelDeAcesso` ENUM('administrador', 'bibliotecario', 'usuario') NULL,
  PRIMARY KEY (`CodUsuario`),
  UNIQUE INDEX `CodUsuario_UNIQUE` (`CodUsuario` ASC) VISIBLE)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `Bibliotecadb`.`Alunos`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `Bibliotecadb`.`Alunos` (
  `Matricula` INT NOT NULL,
  `Nome` VARCHAR(45) NULL,
  `Endereco` VARCHAR(45) NULL,
  `DataIngresso` DATE NULL,
  `DataConclusaoPrevista` DATE NULL,
  `Cursos_CodCurso` INT NOT NULL,
  `Usuario_CodUsuario` INT NOT NULL,
  PRIMARY KEY (`Matricula`, `Usuario_CodUsuario`),
  INDEX `fk_Alunos_Cursos1_idx` (`Cursos_CodCurso` ASC) VISIBLE,
  INDEX `fk_Alunos_Usuario1_idx` (`Usuario_CodUsuario` ASC) VISIBLE,
  CONSTRAINT `fk_Alunos_Cursos1`
    FOREIGN KEY (`Cursos_CodCurso`)
    REFERENCES `Bibliotecadb`.`Cursos` (`CodCurso`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_Alunos_Usuario1`
    FOREIGN KEY (`Usuario_CodUsuario`)
    REFERENCES `Bibliotecadb`.`Usuario` (`CodUsuario`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `Bibliotecadb`.`Professores`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `Bibliotecadb`.`Professores` (
  `MatSiape` INT NOT NULL,
  `Nome` VARCHAR(45) NULL,
  `Endereco` VARCHAR(45) NULL,
  `TelefoneCelular` VARCHAR(45) NULL,
  `RegimeTrabalho` ENUM('20h', '40h', 'DE') NULL,
  `DataContratacao` DATE NULL,
  `Cursos_CodCurso` INT NOT NULL,
  `Usuario_CodUsuario` INT NOT NULL,
  PRIMARY KEY (`MatSiape`, `Usuario_CodUsuario`),
  INDEX `fk_Professores_Cursos1_idx` (`Cursos_CodCurso` ASC) VISIBLE,
  INDEX `fk_Professores_Usuario1_idx` (`Usuario_CodUsuario` ASC) VISIBLE,
  CONSTRAINT `fk_Professores_Cursos1`
    FOREIGN KEY (`Cursos_CodCurso`)
    REFERENCES `Bibliotecadb`.`Cursos` (`CodCurso`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_Professores_Usuario1`
    FOREIGN KEY (`Usuario_CodUsuario`)
    REFERENCES `Bibliotecadb`.`Usuario` (`CodUsuario`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `Bibliotecadb`.`Funcionarios`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `Bibliotecadb`.`Funcionarios` (
  `Matricula` INT NOT NULL,
  `Nome` VARCHAR(45) NULL,
  `endereco` VARCHAR(45) NULL,
  `Usuario_CodUsuario` INT NOT NULL,
  PRIMARY KEY (`Matricula`, `Usuario_CodUsuario`),
  INDEX `fk_Funcionarios_Usuario1_idx` (`Usuario_CodUsuario` ASC) VISIBLE,
  CONSTRAINT `fk_Funcionarios_Usuario1`
    FOREIGN KEY (`Usuario_CodUsuario`)
    REFERENCES `Bibliotecadb`.`Usuario` (`CodUsuario`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `Bibliotecadb`.`Funcionarios_Telefones`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `Bibliotecadb`.`Funcionarios_Telefones` (
  `Funcionarios_Matricula` INT NOT NULL,
  `NumTelefone` VARCHAR(45) NULL,
  PRIMARY KEY (`Funcionarios_Matricula`),
  CONSTRAINT `fk_Funcionarios_Telefones_Funcionarios1`
    FOREIGN KEY (`Funcionarios_Matricula`)
    REFERENCES `Bibliotecadb`.`Funcionarios` (`Matricula`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `Bibliotecadb`.`Alunos_Telefones`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `Bibliotecadb`.`Alunos_Telefones` (
  `Alunos_Matricula` INT NOT NULL,
  `NumTelefone` VARCHAR(45) NULL,
  PRIMARY KEY (`Alunos_Matricula`),
  CONSTRAINT `fk_Alunos_Telefones_Alunos1`
    FOREIGN KEY (`Alunos_Matricula`)
    REFERENCES `Bibliotecadb`.`Alunos` (`Matricula`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `Bibliotecadb`.`Reservas`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `Bibliotecadb`.`Reservas` (
  `Livros_ISBN` INT NOT NULL,
  `Usuario_CodUsuario` INT NOT NULL,
  `ReservaData` DATE NOT NULL,
  PRIMARY KEY (`Livros_ISBN`, `Usuario_CodUsuario`),
  INDEX `fk_Livros_has_Usuario_Usuario1_idx` (`Usuario_CodUsuario` ASC) VISIBLE,
  INDEX `fk_Livros_has_Usuario_Livros1_idx` (`Livros_ISBN` ASC) VISIBLE,
  CONSTRAINT `fk_Livros_has_Usuario_Livros1`
    FOREIGN KEY (`Livros_ISBN`)
    REFERENCES `Bibliotecadb`.`Livros` (`ISBN`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_Livros_has_Usuario_Usuario1`
    FOREIGN KEY (`Usuario_CodUsuario`)
    REFERENCES `Bibliotecadb`.`Usuario` (`CodUsuario`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;

USE `Bibliotecadb`;

DELIMITER $$
USE `Bibliotecadb`$$
CREATE DEFINER = CURRENT_USER TRIGGER `Bibliotecadb`.`Alunos_BEFORE_INSERT` BEFORE INSERT ON `Alunos` FOR EACH ROW
BEGIN

IF NEW.DataConclusaoPrevista > NOW() THEN
SIGNAL SQLSTATE '45000'
SET MESSAGE_TEXT = 'conta expirada';
END IF;
END$$


DELIMITER ;

SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;
