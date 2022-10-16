-- MySQL Workbench Forward Engineering

SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION';

-- -----------------------------------------------------
-- Schema rh
-- -----------------------------------------------------

-- -----------------------------------------------------
-- Schema rh
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `rh` DEFAULT CHARACTER SET utf8 ;
USE `rh` ;

-- -----------------------------------------------------
-- Table `rh`.`Tipo_Inscricao`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `rh`.`Tipo_Inscricao` (
  `ID_Tipo_Insc` INT NOT NULL AUTO_INCREMENT,
  `Desc_Tp_Insc` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`ID_Tipo_Insc`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `rh`.`Cadastro_PF_PJ`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `rh`.`Cadastro_PF_PJ` (
  `ID_Cad_PF_PJ` INT NOT NULL AUTO_INCREMENT,
  `Nome_Razao_Social` VARCHAR(45) NOT NULL,
  `ID_Tipo_Insc` INT NOT NULL,
  PRIMARY KEY (`ID_Cad_PF_PJ`),
  INDEX `fk_Cadastro PF_PJ_Tipo Inscricao_idx` (`ID_Tipo_Insc` ASC) VISIBLE,
  CONSTRAINT `fk_Cadastro PF_PJ_Tipo Inscricao`
    FOREIGN KEY (`ID_Tipo_Insc`)
    REFERENCES `rh`.`Tipo_Inscricao` (`ID_Tipo_Insc`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `rh`.`UF`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `rh`.`UF` (
  `UF` CHAR(2) NOT NULL,
  `Descricao` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`UF`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `rh`.`Endereco`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `rh`.`Endereco` (
  `ID_Endereco` INT NOT NULL AUTO_INCREMENT,
  `ID_Cad_PF_PJ` INT NOT NULL,
  `End_Logradouro` VARCHAR(45) NOT NULL,
  `End_Numero` VARCHAR(45) NOT NULL,
  `End_CEP` INT(8) NOT NULL,
  `End_Complemento` VARCHAR(45) NOT NULL,
  `UF` CHAR(2) NOT NULL,
  `End_Dt_Ini` DATE NOT NULL,
  `End_Dt_Fim` DATE NOT NULL,
  PRIMARY KEY (`ID_Endereco`, `ID_Cad_PF_PJ`, `UF`, `End_Dt_Ini`),
  INDEX `fk_Endereco_Cadastro PF_PJ1_idx` (`ID_Cad_PF_PJ` ASC) VISIBLE,
  INDEX `fk_Endereco_UF1_idx` (`UF` ASC) VISIBLE,
  CONSTRAINT `fk_Endereco_Cadastro PF_PJ1`
    FOREIGN KEY (`ID_Cad_PF_PJ`)
    REFERENCES `rh`.`Cadastro_PF_PJ` (`ID_Cad_PF_PJ`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_Endereco_UF1`
    FOREIGN KEY (`UF`)
    REFERENCES `rh`.`UF` (`UF`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `rh`.`Tipo_contato`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `rh`.`Tipo_contato` (
  `ID_Tp_Cont` INT NOT NULL,
  `descricao` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`ID_Tp_Cont`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `rh`.`Contato`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `rh`.`Contato` (
  `ID_Contato` INT NOT NULL AUTO_INCREMENT,
  `ID_Tp_Cont` INT NOT NULL,
  `ID_Endereco` INT NOT NULL,
  `Cont_Desc` VARCHAR(45) NOT NULL,
  `Cont_Dt_Ini` DATE NOT NULL,
  `Cont_Dt_Fim` DATE NOT NULL,
  PRIMARY KEY (`ID_Contato`, `ID_Tp_Cont`, `ID_Endereco`, `Cont_Dt_Ini`, `Cont_Dt_Fim`),
  INDEX `fk_Contato_Tipo contato1_idx` (`ID_Tp_Cont` ASC) VISIBLE,
  INDEX `fk_Contato_Endereco1_idx` (`ID_Endereco` ASC) VISIBLE,
  CONSTRAINT `fk_Contato_Tipo contato1`
    FOREIGN KEY (`ID_Tp_Cont`)
    REFERENCES `rh`.`Tipo_contato` (`ID_Tp_Cont`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_Contato_Endereco1`
    FOREIGN KEY (`ID_Endereco`)
    REFERENCES `rh`.`Endereco` (`ID_Endereco`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `rh`.`Salario`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `rh`.`Salario` (
  `ID_Salario` INT NOT NULL AUTO_INCREMENT,
  `ID_Cad_PF_PJ` INT NOT NULL,
  `Salario_Valor` DECIMAL(14,2) NOT NULL,
  `Sal_Dt_Ini` DATE NOT NULL,
  `Sal_Dt_Fim` DATE NOT NULL,
  PRIMARY KEY (`ID_Salario`, `ID_Cad_PF_PJ`, `Sal_Dt_Ini`),
  INDEX `fk_Salario_Cadastro PF_PJ1_idx` (`ID_Cad_PF_PJ` ASC) VISIBLE,
  CONSTRAINT `fk_Salario_Cadastro PF_PJ1`
    FOREIGN KEY (`ID_Cad_PF_PJ`)
    REFERENCES `rh`.`Cadastro_PF_PJ` (`ID_Cad_PF_PJ`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `rh`.`Registro_Marcacao`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `rh`.`Registro_Marcacao` (
  `id_Reg_Jor` INT NOT NULL AUTO_INCREMENT,
  `ID_Cad_PF_PJ` INT NOT NULL,
  `Reg_Marc_Data` DATE NOT NULL,
  `Reg_Marc_Entr_1` TIME NOT NULL,
  `Reg_Marc_Sai_1` TIME NOT NULL,
  `Reg_Marc_Entr_2` TIME NOT NULL,
  `Reg_Marc_Sai_2` TIME NOT NULL,
  `Reg_Marc_Entr_3` TIME NOT NULL,
  `Reg_Marc_Sai_3` TIME NOT NULL,
  `Reg_Marc_Entr_4` TIME NOT NULL,
  `Reg_Marc_Sai_4` TIME NOT NULL,
  PRIMARY KEY (`id_Reg_Jor`, `ID_Cad_PF_PJ`, `Reg_Marc_Data`),
  INDEX `fk_Registro Jornada_Cadastro PF_PJ1_idx` (`ID_Cad_PF_PJ` ASC) VISIBLE,
  CONSTRAINT `fk_Registro Jornada_Cadastro PF_PJ1`
    FOREIGN KEY (`ID_Cad_PF_PJ`)
    REFERENCES `rh`.`Cadastro_PF_PJ` (`ID_Cad_PF_PJ`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;
