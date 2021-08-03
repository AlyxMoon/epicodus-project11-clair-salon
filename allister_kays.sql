-- ---
-- Globals
-- ---

-- SET SQL_MODE="NO_AUTO_VALUE_ON_ZERO";
-- SET FOREIGN_KEY_CHECKS=0;

-- ---
-- Table 'stylists'
-- 
-- ---

DROP TABLE IF EXISTS `stylists`;
		
CREATE TABLE `stylists` (
  `Id` INTEGER NOT NULL AUTO_INCREMENT,
  `Name` VARCHAR(255) NULL DEFAULT NULL,
  `Description` MEDIUMTEXT NULL DEFAULT NULL,
  PRIMARY KEY (`Id`)
);

-- ---
-- Table 'clients'
-- 
-- ---

DROP TABLE IF EXISTS `clients`;
		
CREATE TABLE `clients` (
  `Id` INTEGER NOT NULL AUTO_INCREMENT,
  `IdStylist` INTEGER NOT NULL,
  `Name` VARCHAR(255) NULL DEFAULT NULL,
  PRIMARY KEY (`Id`)
);

-- ---
-- Foreign Keys 
-- ---

ALTER TABLE `clients` ADD FOREIGN KEY (IdStylist) REFERENCES `stylists` (`Id`);

-- ---
-- Table Properties
-- ---

-- ALTER TABLE `stylists` ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin;
-- ALTER TABLE `clients` ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin;

-- ---
-- Test Data
-- ---

-- INSERT INTO `stylists` (`Id`,`Name`,`Description`) VALUES
-- ('','','');
-- INSERT INTO `clients` (`Id`,`IdStylist`,`Name`) VALUES
-- ('','','');