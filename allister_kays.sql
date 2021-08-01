-- ---
-- Globals
-- ---

-- SET SQL_MODE="NO_AUTO_VALUE_ON_ZERO";
-- SET FOREIGN_KEY_CHECKS=0;

-- ---
-- Table 'stylist'
-- 
-- ---

DROP TABLE IF EXISTS `stylist`;
		
CREATE TABLE `stylist` (
  `id` INTEGER NOT NULL AUTO_INCREMENT,
  `name` VARCHAR(255) NULL DEFAULT NULL,
  `description` MEDIUMTEXT NULL DEFAULT NULL,
  PRIMARY KEY (`id`)
);

-- ---
-- Table 'client'
-- 
-- ---

DROP TABLE IF EXISTS `client`;
		
CREATE TABLE `client` (
  `id` INTEGER NOT NULL AUTO_INCREMENT,
  `id_stylist` INTEGER NOT NULL,
  `name` VARCHAR(255) NULL DEFAULT NULL,
  PRIMARY KEY (`id`)
);

-- ---
-- Foreign Keys 
-- ---

ALTER TABLE `client` ADD FOREIGN KEY (id_stylist) REFERENCES `stylist` (`id`);

-- ---
-- Table Properties
-- ---

-- ALTER TABLE `stylist` ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin;
-- ALTER TABLE `client` ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin;

-- ---
-- Test Data
-- ---

-- INSERT INTO `stylist` (`id`,`name`,`description`) VALUES
-- ('','','');
-- INSERT INTO `client` (`id`,`id_stylist`,`name`) VALUES
-- ('','','');