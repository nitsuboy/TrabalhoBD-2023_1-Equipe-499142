-- MySQL Script generated by MySQL Workbench
-- Wed Jul  5 12:43:06 2023
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
-- Table `Bibliotecadb`.`Categorias`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `Bibliotecadb`.`Categorias` (
  `CodCategoria` INT NOT NULL AUTO_INCREMENT,
  `Descricao` VARCHAR(45) NULL,
  PRIMARY KEY (`CodCategoria`),
  UNIQUE INDEX `CodCategoria_UNIQUE` (`CodCategoria` ASC) VISIBLE)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `Bibliotecadb`.`Livros`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `Bibliotecadb`.`Livros` (
  `ISBN` VARCHAR(20) NOT NULL,
  `Titulo` VARCHAR(145) NULL,
  `AnoDeLancamento` INT NULL,
  `Editora` VARCHAR(100) NULL,
  `QuanCopias` INT NULL,
  `Categoria_CodCategoria` INT NOT NULL,
  PRIMARY KEY (`ISBN`),
  INDEX `fk_Livros_Categoria1_idx` (`Categoria_CodCategoria` ASC) VISIBLE,
  CONSTRAINT `fk_Livros_Categoria1`
    FOREIGN KEY (`Categoria_CodCategoria`)
    REFERENCES `Bibliotecadb`.`Categorias` (`CodCategoria`)
    ON DELETE RESTRICT
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `Bibliotecadb`.`Autores`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `Bibliotecadb`.`Autores` (
  `Nome` VARCHAR(125) NULL,
  `Email` VARCHAR(45) NOT NULL,
  `Nacionalidade` VARCHAR(45) NULL,
  PRIMARY KEY (`Email`),
  UNIQUE INDEX `E-mail_UNIQUE` (`Email` ASC) VISIBLE)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `Bibliotecadb`.`Cursos`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `Bibliotecadb`.`Cursos` (
  `CodCurso` INT NOT NULL AUTO_INCREMENT,
  `NomeCurso` VARCHAR(45) NULL,
  PRIMARY KEY (`CodCurso`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `Bibliotecadb`.`Usuarios`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `Bibliotecadb`.`Usuarios` (
  `CodUsuario` INT NOT NULL AUTO_INCREMENT,
  `NomeUsuario` VARCHAR(45) NOT NULL,
  `Senha` VARCHAR(45) NOT NULL,
  `QntLivros` INT NULL,
  `TipoUsuario` ENUM('Aluno', 'Professor', 'Funcionario') NOT NULL,
  `NivelDeAcesso` ENUM('administrador', 'bibliotecario', 'usuario') NULL,
  PRIMARY KEY (`CodUsuario`),
  UNIQUE INDEX `CodUsuario_UNIQUE` (`CodUsuario` ASC) VISIBLE,
  UNIQUE INDEX `NomeUsuario_UNIQUE` (`NomeUsuario` ASC) VISIBLE)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `Bibliotecadb`.`Alunos`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `Bibliotecadb`.`Alunos` (
  `Matricula` INT NOT NULL,
  `Nome` VARCHAR(45) NULL,
  `Endereco` VARCHAR(125) NULL,
  `DataIngresso` DATE NULL,
  `DataConclusaoPrevista` DATE NULL,
  `Cursos_CodCurso` INT NOT NULL,
  `Usuario_CodUsuario` INT NOT NULL,
  PRIMARY KEY (`Matricula`, `Usuario_CodUsuario`),
  INDEX `fk_Alunos_Cursos1_idx` (`Cursos_CodCurso` ASC) VISIBLE,
  INDEX `fk_Alunos_Usuario1_idx` (`Usuario_CodUsuario` ASC) VISIBLE,
  UNIQUE INDEX `Matricula_UNIQUE` (`Matricula` ASC) VISIBLE,
  CONSTRAINT `fk_Alunos_Cursos1`
    FOREIGN KEY (`Cursos_CodCurso`)
    REFERENCES `Bibliotecadb`.`Cursos` (`CodCurso`)
    ON DELETE RESTRICT
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_Alunos_Usuario1`
    FOREIGN KEY (`Usuario_CodUsuario`)
    REFERENCES `Bibliotecadb`.`Usuarios` (`CodUsuario`)
    ON DELETE CASCADE
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `Bibliotecadb`.`Professores`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `Bibliotecadb`.`Professores` (
  `MatSiape` INT NOT NULL,
  `Nome` VARCHAR(45) NULL,
  `Endereco` VARCHAR(125) NULL,
  `TelefoneCelular` VARCHAR(20) NULL,
  `RegimeTrabalho` ENUM('20h', '40h', 'DE') NULL,
  `DataContratacao` DATE NULL,
  `Cursos_CodCurso` INT NOT NULL,
  `Usuario_CodUsuario` INT NOT NULL,
  PRIMARY KEY (`MatSiape`, `Usuario_CodUsuario`),
  INDEX `fk_Professores_Cursos1_idx` (`Cursos_CodCurso` ASC) VISIBLE,
  INDEX `fk_Professores_Usuario1_idx` (`Usuario_CodUsuario` ASC) VISIBLE,
  UNIQUE INDEX `MatSiape_UNIQUE` (`MatSiape` ASC) VISIBLE,
  CONSTRAINT `fk_Professores_Cursos1`
    FOREIGN KEY (`Cursos_CodCurso`)
    REFERENCES `Bibliotecadb`.`Cursos` (`CodCurso`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_Professores_Usuario1`
    FOREIGN KEY (`Usuario_CodUsuario`)
    REFERENCES `Bibliotecadb`.`Usuarios` (`CodUsuario`)
    ON DELETE CASCADE
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `Bibliotecadb`.`Funcionarios`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `Bibliotecadb`.`Funcionarios` (
  `Matricula` INT NOT NULL,
  `Nome` VARCHAR(45) NULL,
  `endereco` VARCHAR(125) NULL,
  `Usuario_CodUsuario` INT NOT NULL,
  PRIMARY KEY (`Matricula`, `Usuario_CodUsuario`),
  INDEX `fk_Funcionarios_Usuario1_idx` (`Usuario_CodUsuario` ASC) VISIBLE,
  UNIQUE INDEX `Matricula_UNIQUE` (`Matricula` ASC) VISIBLE,
  CONSTRAINT `fk_Funcionarios_Usuario1`
    FOREIGN KEY (`Usuario_CodUsuario`)
    REFERENCES `Bibliotecadb`.`Usuarios` (`CodUsuario`)
    ON DELETE CASCADE
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `Bibliotecadb`.`Funcionarios_Telefones`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `Bibliotecadb`.`Funcionarios_Telefones` (
  `Funcionarios_Matricula` INT NOT NULL,
  `NumTelefone` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`Funcionarios_Matricula`, `NumTelefone`),
  CONSTRAINT `fk_Funcionarios_Telefones_Funcionarios1`
    FOREIGN KEY (`Funcionarios_Matricula`)
    REFERENCES `Bibliotecadb`.`Funcionarios` (`Matricula`)
    ON DELETE CASCADE
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `Bibliotecadb`.`Alunos_Telefones`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `Bibliotecadb`.`Alunos_Telefones` (
  `Alunos_Matricula` INT NOT NULL,
  `NumTelefone` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`Alunos_Matricula`, `NumTelefone`),
  CONSTRAINT `fk_Alunos_Telefones_Alunos1`
    FOREIGN KEY (`Alunos_Matricula`)
    REFERENCES `Bibliotecadb`.`Alunos` (`Matricula`)
    ON DELETE CASCADE
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `Bibliotecadb`.`Reservas`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `Bibliotecadb`.`Reservas` (
  `Usuario_CodUsuario` INT NOT NULL,
  `ReservaData` DATE NOT NULL,
  `Livros_ISBN` VARCHAR(20) NOT NULL,
  PRIMARY KEY (`Usuario_CodUsuario`, `Livros_ISBN`),
  INDEX `fk_Livros_has_Usuario_Usuario1_idx` (`Usuario_CodUsuario` ASC) VISIBLE,
  INDEX `fk_Reservas_Livros1_idx` (`Livros_ISBN` ASC) VISIBLE,
  CONSTRAINT `fk_Livros_has_Usuario_Usuario1`
    FOREIGN KEY (`Usuario_CodUsuario`)
    REFERENCES `Bibliotecadb`.`Usuarios` (`CodUsuario`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_Reservas_Livros1`
    FOREIGN KEY (`Livros_ISBN`)
    REFERENCES `Bibliotecadb`.`Livros` (`ISBN`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `Bibliotecadb`.`Livros_has_Autores`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `Bibliotecadb`.`Livros_has_Autores` (
  `Livros_ISBN` VARCHAR(20) NOT NULL,
  `Autores_Email` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`Livros_ISBN`, `Autores_Email`),
  INDEX `fk_Livros_has_Autores_Autores1_idx` (`Autores_Email` ASC) VISIBLE,
  INDEX `fk_Livros_has_Autores_Livros1_idx` (`Livros_ISBN` ASC) VISIBLE,
  CONSTRAINT `fk_Livros_has_Autores_Livros1`
    FOREIGN KEY (`Livros_ISBN`)
    REFERENCES `Bibliotecadb`.`Livros` (`ISBN`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_Livros_has_Autores_Autores1`
    FOREIGN KEY (`Autores_Email`)
    REFERENCES `Bibliotecadb`.`Autores` (`Email`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;

USE `Bibliotecadb` ;

-- -----------------------------------------------------
-- Placeholder table for view `Bibliotecadb`.`LivrosPorEditora`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `Bibliotecadb`.`LivrosPorEditora` (`ISBN` INT, `Editora` INT, `Titulo` INT, `Ano` INT, `Categoria` INT, `Quancopias` INT);

-- -----------------------------------------------------
-- Placeholder table for view `Bibliotecadb`.`LivrosPorCategoria`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `Bibliotecadb`.`LivrosPorCategoria` (`ISBN` INT, `Categoria` INT, `Titulo` INT, `Ano` INT, `Editora` INT, `Quancopias` INT);

-- -----------------------------------------------------
-- Placeholder table for view `Bibliotecadb`.`LivrosPorAno`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `Bibliotecadb`.`LivrosPorAno` (`ISBN` INT, `Ano` INT, `Titulo` INT, `Editora` INT, `Categoria` INT, `Quancopias` INT);

-- -----------------------------------------------------
-- Placeholder table for view `Bibliotecadb`.`LivrosPorAutor`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `Bibliotecadb`.`LivrosPorAutor` (`ISBN` INT, `Autor` INT, `Categoria` INT, `Titulo` INT, `Ano` INT, `Editora` INT, `Quancopias` INT);

-- -----------------------------------------------------
-- Placeholder table for view `Bibliotecadb`.`ProfessoresPorCurso`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `Bibliotecadb`.`ProfessoresPorCurso` (`Curso` INT, `Professor` INT);

-- -----------------------------------------------------
-- Placeholder table for view `Bibliotecadb`.`ReservasDeLivro`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `Bibliotecadb`.`ReservasDeLivro` (`Data` INT, `Usuario` INT);

-- -----------------------------------------------------
-- Placeholder table for view `Bibliotecadb`.`usuariosematriculas`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `Bibliotecadb`.`usuariosematriculas` (`CodUsuario` INT, `NomeUsuario` INT, `QntLivros` INT, `TipoUsuario` INT, `matricula` INT, `nome` INT);

-- -----------------------------------------------------
-- View `Bibliotecadb`.`LivrosPorEditora`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `Bibliotecadb`.`LivrosPorEditora`;
USE `Bibliotecadb`;
CREATE  OR REPLACE VIEW LivrosPorEditora AS
SELECT ISBN ,l.Editora AS Editora, l.Titulo AS Titulo, l.AnoDeLancamento AS Ano, c.Descricao AS Categoria, Quancopias
FROM Livros l
INNER JOIN Categorias c ON l.Categoria_CodCategoria = c.CodCategoria
ORDER BY l.Editora, l.Titulo;

-- -----------------------------------------------------
-- View `Bibliotecadb`.`LivrosPorCategoria`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `Bibliotecadb`.`LivrosPorCategoria`;
USE `Bibliotecadb`;
CREATE  OR REPLACE VIEW LivrosPorCategoria AS
SELECT ISBN, c.Descricao AS Categoria, l.Titulo AS Titulo, l.AnoDeLancamento AS Ano, l.Editora AS Editora, Quancopias
FROM Livros l
INNER JOIN Categorias c ON l.Categoria_CodCategoria = c.CodCategoria
ORDER BY c.Descricao, l.Titulo;

-- -----------------------------------------------------
-- View `Bibliotecadb`.`LivrosPorAno`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `Bibliotecadb`.`LivrosPorAno`;
USE `Bibliotecadb`;
CREATE  OR REPLACE VIEW LivrosPorAno AS
SELECT ISBN ,l.AnoDeLancamento AS Ano, l.Titulo AS Titulo, l.Editora AS Editora, c.Descricao AS Categoria, Quancopias
FROM Livros l
INNER JOIN Categorias c ON l.Categoria_CodCategoria = c.CodCategoria
ORDER BY l.AnoDeLancamento, l.Titulo;

-- -----------------------------------------------------
-- View `Bibliotecadb`.`LivrosPorAutor`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `Bibliotecadb`.`LivrosPorAutor`;
USE `Bibliotecadb`;
CREATE  OR REPLACE VIEW LivrosPorAutor AS
SELECT ISBN ,a.Nome AS Autor, c.Descricao AS Categoria, l.Titulo AS Titulo, l.AnoDeLancamento AS Ano, l.Editora AS Editora, Quancopias
FROM Livros l
INNER JOIN Categorias c ON l.Categoria_CodCategoria = c.CodCategoria
INNER JOIN Livros_has_Autores la ON l.ISBN = la.Livros_ISBN
INNER JOIN Autores a ON la.Autores_Email = a.Email
ORDER BY a.Nome, l.Titulo;

-- -----------------------------------------------------
-- View `Bibliotecadb`.`ProfessoresPorCurso`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `Bibliotecadb`.`ProfessoresPorCurso`;
USE `Bibliotecadb`;
CREATE  OR REPLACE VIEW ProfessoresPorCurso AS
SELECT c.NomeCurso AS Curso , p.Nome AS Professor
FROM Professores p
INNER JOIN Cursos c ON p.Cursos_CodCurso = c.CodCurso
ORDER BY c.NomeCurso, p.Nome;

-- -----------------------------------------------------
-- View `Bibliotecadb`.`ReservasDeLivro`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `Bibliotecadb`.`ReservasDeLivro`;
USE `Bibliotecadb`;
CREATE  OR REPLACE VIEW ReservasDeLivro AS
SELECT r.ReservaData AS Data, u.NomeUsuario AS Usuario
FROM Reservas r
INNER JOIN Usuarios u ON r.Usuario_CodUsuario = u.CodUsuario
INNER JOIN Livros l ON r.Livros_ISBN = l.ISBN
WHERE l.Titulo = 'Nome do Livro' OR l.ISBN = 'ISBN do Livro';

-- -----------------------------------------------------
-- View `Bibliotecadb`.`usuariosematriculas`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `Bibliotecadb`.`usuariosematriculas`;
USE `Bibliotecadb`;
CREATE  OR REPLACE VIEW `usuariosematriculas` AS 
SELECT u.CodUsuario, u.NomeUsuario, u.QntLivros, u.TipoUsuario, coalesce(a.Matricula,p.MatSiape,f.matricula) as matricula , coalesce(a.Nome,p.Nome,f.Nome) as nome
FROM usuarios u
left join alunos a 
on u.CodUsuario = a.Usuario_CodUsuario
left join professores p 
on u.CodUsuario = p.Usuario_CodUsuario
left join funcionarios f 
on u.CodUsuario = f.Usuario_CodUsuario;
USE `Bibliotecadb`;

DELIMITER $$
USE `Bibliotecadb`$$
CREATE DEFINER = CURRENT_USER TRIGGER `Bibliotecadb`.`Livros_BEFORE_UPDATE` BEFORE UPDATE ON `Livros` FOR EACH ROW
BEGIN

if new.quancopias < 0 then
signal sqlstate '45000' SET MESSAGE_TEXT = 'sem livros';
end if;

END$$

USE `Bibliotecadb`$$
CREATE DEFINER = CURRENT_USER TRIGGER `Bibliotecadb`.`livros_check` BEFORE UPDATE ON `Usuarios` FOR EACH ROW
BEGIN

IF (new.qntlivros > 3 and old.tipousuario = 'Aluno') then
signal sqlstate '45000' SET MESSAGE_TEXT = 'Limite excedido';
elseif (new.qntlivros > 5 and old.tipousuario = 'Professor') then
signal sqlstate '45000' SET MESSAGE_TEXT = 'Limite excedido';
elseif (new.qntlivros > 4 and old.tipousuario = 'Funcionario') then
signal sqlstate '45000' SET MESSAGE_TEXT = 'Limite excedido';
end if;

END$$

USE `Bibliotecadb`$$
CREATE 
DEFINER = CURRENT_USER 
TRIGGER `Bibliotecadb`.`Remove_User` 
BEFORE INSERT ON `Alunos` 
FOR EACH ROW
BEGIN 

IF NEW.DataConclusaoPrevista < NOW() THEN
DELETE FROM Usuarios WHERE CodUsuario = NEW.Usuario_CodUsuario;
END IF;

END$$

USE `Bibliotecadb`$$
CREATE
DEFINER = CURRENT_USER
TRIGGER `Bibliotecadb`.`Send_Signal`
BEFORE INSERT ON `Alunos` 
FOR EACH ROW 
BEGIN

IF NEW.DataConclusaoPrevista < NOW() THEN
signal sqlstate '45000' SET MESSAGE_TEXT = 'conta expirada';
END IF;

END$$

USE `Bibliotecadb`$$
CREATE DEFINER = CURRENT_USER TRIGGER `Bibliotecadb`.`Reservas_AFTER_DELETE` AFTER DELETE ON `Reservas` FOR EACH ROW
BEGIN

UPDATE usuarios
SET qntlivros = qntlivros - 1
WHERE codusuario = old.usuario_codusuario;

UPDATE livros
SET quancopias = quancopias + 1
WHERE isbn = old.livros_isbn;

END$$

USE `Bibliotecadb`$$
CREATE DEFINER = CURRENT_USER TRIGGER `Bibliotecadb`.`Reservas_AFTER_INSERT` AFTER INSERT ON `Reservas` FOR EACH ROW
BEGIN

UPDATE usuarios
SET qntlivros = qntlivros + 1
WHERE codusuario = new.usuario_codusuario;

UPDATE livros
SET quancopias = quancopias - 1
WHERE isbn = new.livros_isbn;

END$$


DELIMITER ;

SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;
