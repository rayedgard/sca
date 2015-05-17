/*
SQLyog Community Edition- MySQL GUI v8.05 
MySQL - 5.5.14 : Database - salud
*********************************************************************
*/

/*!40101 SET NAMES utf8 */;

/*!40101 SET SQL_MODE=''*/;

/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;

CREATE DATABASE /*!32312 IF NOT EXISTS*/`salud` /*!40100 DEFAULT CHARACTER SET utf8 */;

USE `salud`;

/*Table structure for table `taadm_administrador` */

DROP TABLE IF EXISTS `taadm_administrador`;

CREATE TABLE `taadm_administrador` (
  `Administrador` char(20) NOT NULL,
  `Contrasenia` text NOT NULL,
  `Correo` char(255) NOT NULL,
  `NuevaClave` text,
  `privilegio` int(1) DEFAULT NULL,
  `idArea` int(8) DEFAULT NULL,
  PRIMARY KEY (`Administrador`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

/*Data for the table `taadm_administrador` */

LOCK TABLES `taadm_administrador` WRITE;

insert  into `taadm_administrador`(`Administrador`,`Contrasenia`,`Correo`,`NuevaClave`,`privilegio`,`idArea`) values ('test','test','email@hotmail.com','test',1,6),('gabino','gabino','rayedgard@gmail.com','edgard',0,13);

UNLOCK TABLES;

/*Table structure for table `tageo_departamentos` */

DROP TABLE IF EXISTS `tageo_departamentos`;

CREATE TABLE `tageo_departamentos` (
  `IdDepartamento` int(10) NOT NULL,
  `IdPais` int(10) NOT NULL,
  `NombreDepartamento` char(255) NOT NULL,
  PRIMARY KEY (`IdDepartamento`),
  KEY `FK_tageo_departamentos` (`IdPais`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

/*Data for the table `tageo_departamentos` */

LOCK TABLES `tageo_departamentos` WRITE;

insert  into `tageo_departamentos`(`IdDepartamento`,`IdPais`,`NombreDepartamento`) values (1,1,'AREQUIPA'),(2,1,'CUSCO'),(3,1,'PUNO'),(4,1,'AMAZONAS'),(5,1,'ANCASH'),(6,1,'APURÍMAC'),(7,1,'AYACUCHO'),(8,1,'CAJAMARCA'),(9,1,'HUANCAVELICA'),(10,1,'HUÁNUCO'),(11,1,'ICA'),(12,1,'JUNÍN'),(13,1,'LA LIBERTAD'),(14,1,'LAMBAYEQUE'),(15,1,'LIMA/CALLAO'),(16,1,'LORETO'),(17,1,'MADRE DE DIOS'),(18,1,'MOQUEGUA'),(19,1,'PASCO'),(20,1,'PIURA'),(21,1,'SAN MARTÍN'),(22,1,'TACNA'),(23,1,'TUMBES'),(24,1,'UCAYALI');

UNLOCK TABLES;

/*Table structure for table `tageo_distritos` */

DROP TABLE IF EXISTS `tageo_distritos`;

CREATE TABLE `tageo_distritos` (
  `IdDistrito` int(10) NOT NULL,
  `IdProvincia` int(10) NOT NULL,
  `NombreDistrito` char(255) NOT NULL,
  PRIMARY KEY (`IdDistrito`),
  KEY `FK_tageo_distritos` (`IdProvincia`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

/*Data for the table `tageo_distritos` */

LOCK TABLES `tageo_distritos` WRITE;

insert  into `tageo_distritos`(`IdDistrito`,`IdProvincia`,`NombreDistrito`) values (1,1,'JOSE LUIS BUSTAMANTE Y RIVERO'),(2,1,'PAUCARPATA'),(3,2,'CUSCO'),(4,2,'WANCHAQ'),(5,2,'SANTIAGO'),(6,2,'SAN JERONIMO'),(7,2,'SAN SEBASTIAN'),(8,2,'CCORCA'),(9,2,'POROY'),(10,2,'SAYLLA'),(11,4,'ANDAHUAYLILLAS'),(12,4,'CAMANTI'),(13,4,'CCARHUAYO'),(14,4,'CCATCA'),(15,4,'CUSIPATA'),(16,4,'HUARO'),(17,4,'LUCRE'),(18,4,'MARCAPATA'),(19,4,'OCONGATE'),(20,4,'OROPESA'),(21,4,'QUIQUIJANA'),(22,4,'URCOS'),(23,5,'SICUANI'),(24,5,'CHECACUPE'),(25,5,'COMBAPATA'),(26,5,'MARANGANI'),(27,5,'PITUMARCA'),(28,5,'SAN PABLO'),(29,5,'SAN PEDRO'),(30,5,'TINTA'),(31,1,'MARIANO MELGAR'),(32,1,'JACOBO HUNTER'),(33,6,'ACOMAYO'),(34,6,'ACOPIA'),(35,6,'ACOS'),(36,6,'MOSOC LLACTA'),(37,6,'POMACANCHI'),(38,6,'RONDOCAN'),(39,6,'SANGARARÁ'),(40,7,'ANTA'),(41,7,'ANCAHUASI'),(42,7,'CACHIMAYO'),(43,7,'CHINCHAYPUJIO'),(44,7,'HUAROCONDO'),(45,7,'LIMATAMBO'),(46,7,'MOLLEPATA'),(47,7,'PUCYURA'),(48,7,'ZURITE'),(49,8,'CALCA'),(50,8,'COYA'),(51,8,'LAMAY'),(52,8,'LARES'),(53,8,'PISAC'),(54,8,'SAN SALVADOR'),(55,8,'TARAY'),(56,8,'YANATILE'),(57,9,'YANAOCA'),(58,9,'CHECCA'),(59,9,'KUNTURKANKI'),(60,9,'LANGUI'),(61,9,'LAYO'),(62,9,'PAMPAMARCA'),(63,9,'QUEHUE'),(64,9,'TUPAC AMARU'),(65,10,'CAPACMARCA'),(66,10,'COLQUEMARCA'),(67,10,'QUIÑOTA'),(68,10,'LLUSCO'),(69,10,'SANTO TOMAS'),(70,10,'CHAMACA'),(71,10,'LIVITACA'),(72,10,'VELILLE'),(73,11,'YAURI'),(74,11,'CONDOROMA'),(75,11,'COPORAQUE'),(76,11,'OCORURO'),(77,11,'PALLPATA'),(78,11,'PICHIGUA'),(79,11,'SUYKUTAMBO'),(80,11,'ALTO PICHIGUA'),(81,12,'SANTA ANA'),(82,12,'ECHARATE'),(83,12,'HUAYOPATA'),(84,12,'MARANURA'),(85,12,'OCOBAMBA'),(86,12,'QUELLOÚNO'),(87,12,'KIMBIRI'),(88,12,'SANTA TERESA'),(89,12,'VILCABAMBA'),(90,12,'PICHARI'),(91,13,'PARURO'),(92,13,'ACCHA'),(93,13,'CCAPI'),(94,13,'COLCHA'),(95,13,'HUANOQUITE'),(96,13,'OMACHA'),(97,13,'PACCARITAMBO'),(98,13,'PILLPINTO'),(99,13,'YAURISQUE'),(100,14,'PAUCARTAMBO'),(101,14,'CAICAY'),(102,14,'CHALLABAMBA'),(103,14,'COLQUEPATA'),(104,14,'HUANCARANI'),(105,14,'KOSÑIPATA'),(106,15,'URUBAMBA'),(107,15,'CHINCHERO'),(108,15,'HUAYLLABAMBA'),(109,15,'MACHU PICCHU'),(110,15,'MARAS'),(111,15,'OLLANTAYTAMBO'),(112,15,'YUCAY'),(113,1,'ALTO SELVA ALEGRE'),(114,1,'AREQUIPA'),(115,1,'CAYMA'),(116,1,'CERRO COLORADO'),(117,1,'CHARACATO'),(118,1,'CHIGUATA'),(119,1,'LA JOYA'),(120,1,'MIRAFLORES'),(121,1,'MOLLEBAYA'),(122,1,'POCSI'),(123,1,'POLOBAYA'),(124,1,'QUEQUEÑA'),(125,1,'SABANDÍA'),(126,1,'SACHACA'),(127,1,'SAN JUAN DE SIGUAS'),(128,1,'SAN JUAN DE TARUCANI'),(129,1,'SANTA ISABEL DE SIGUAS'),(130,1,'SANTA RITA DE SIGUAS'),(131,1,'SOCABAYA'),(132,1,'TIABAYA'),(133,1,'UCHUMAYO'),(134,1,'VITOR'),(135,1,'YANAHUARA'),(136,1,'YARABAMBA'),(137,1,'YURA'),(138,16,'CAMANÁ'),(139,16,'JOSÉ MARÍA QUIMPER'),(140,16,'MARIANO NICOLÁS VALCARCEL'),(141,16,'MARISCAL CÁCERES'),(142,16,'NICOLÁS DE PIÉROLA'),(143,16,'OCOÑA'),(144,16,'QUILCA'),(145,16,'SAMUEL PASTOR'),(146,17,'CARAVELÍ'),(147,17,'ACARÍ'),(148,17,'ATICO'),(149,17,'ATIQUIPA'),(150,17,'BELLA UNIÓN'),(151,17,'CAHUACHO'),(152,17,'CHALA'),(153,17,'CHAPARRA'),(154,17,'HUANUHUANU'),(155,17,'JAQUI'),(156,17,'LOMAS'),(157,17,'QUICACHA'),(158,17,'YAUCA'),(159,18,'APLAO'),(160,18,'ANDAHUA'),(161,18,'AYO'),(162,18,'CHACHAS'),(163,18,'CHILCAYMARCA'),(164,18,'CHOCO'),(165,18,'HUANCARQUI'),(166,19,'ACHOMA'),(167,19,'CABANACONDE'),(168,19,'CALLALLI'),(169,19,'CAYLLOMA'),(170,19,'COPORAQUE'),(171,19,'HUAMBO'),(172,19,'HUANCA'),(173,19,'ICHUPAMPA'),(174,19,'LARI'),(175,19,'LLUTA'),(176,19,'MACA'),(177,19,'MADRIGAL'),(178,19,'SAN ANTONIO DE CHUCA'),(179,19,'SIBAYO'),(180,19,'TAPAY'),(181,19,'TISCO'),(182,19,'TUTI'),(183,19,'YANQUE'),(184,20,'CHUQUIBAMBA'),(185,20,'ANDARAY'),(186,20,'CAYARANI'),(187,20,'CHICHAS'),(188,20,'IRAY'),(189,20,'RIO GRANDE'),(190,20,'SALAMANCA'),(191,20,'YANAQUIHUA'),(192,21,'MOLLENDO'),(193,21,'COCACHACRA'),(194,21,'DEÁN VALDIVIA'),(195,21,'ISLAY'),(196,21,'MEJÍA'),(197,21,'PUNTA DE BOMBÓN'),(198,22,'ALCA'),(199,22,'CHARCANA'),(200,22,'HUAYNACOTAS'),(201,22,'PAMPAMARCA'),(202,22,'PUYCA'),(203,22,'QUECHUALLA'),(204,22,'SAYLA'),(205,22,'TAURÍA'),(206,22,'TOMEPAMPA'),(207,22,'TORO'),(208,23,'AZÁNGARO'),(209,23,'ACHAYA'),(210,23,'ARAPA'),(211,23,'ASILLO'),(212,23,'CAMINACA'),(213,23,'CHUPA'),(214,23,'JOSÉ DOMINGO CHOQUEHUANCA'),(215,23,'MUÑANI'),(216,23,'POTONI'),(217,23,'SAMÁN'),(218,23,'SAN ANTÓN'),(219,23,'SAN JOSÉ'),(220,23,'SAN JUAN DE SALINAS'),(221,23,'SANTIAGO DE PUPUJA'),(222,23,'TIRAPATA'),(223,24,'AJOYANI'),(224,24,'AYAPATA'),(225,24,'COASA'),(226,24,'CORANI'),(227,24,'CRUCERO'),(228,24,'ITUATA'),(229,24,'MACUSANI'),(230,24,'OLLACHEA'),(231,24,'SAN GABÁN'),(232,24,'USICAYOS'),(233,25,'DESAGUADERO'),(234,25,'HUACULLANI'),(235,25,'JULI'),(236,25,'KELLUYO'),(237,25,'PISACOMA'),(238,25,'POMATA'),(239,25,'ZEPITA'),(240,26,'CAPAZO'),(241,26,'CONDURIRI'),(242,26,'ILAVE'),(243,26,'PILCUYO'),(244,26,'SANTA ROSA'),(245,27,'COJATA'),(246,27,'HUANCANÉ'),(247,27,'HUATASANI'),(248,27,'INCHUPALLA'),(249,27,'PUSI'),(250,27,'ROSASPATA'),(251,27,'TARACO'),(252,27,'VILQUE CHICO'),(253,28,'CABANILLA'),(254,28,'CALAPUJA'),(255,28,'LAMPA'),(256,28,'NICASIO'),(257,28,'OCUVIRI'),(258,28,'PALCA'),(259,28,'PARATIA'),(260,28,'PUCARÁ'),(261,28,'SANTA LUCÍA'),(262,28,'VILAVILA'),(263,29,'ANTAUTA'),(264,29,'AYAVIRI'),(265,29,'CUPI'),(266,29,'LLALLI'),(267,29,'MACARI'),(268,29,'ÑUÑOA'),(269,29,'ORURILLO'),(270,29,'SANTA ROSA'),(271,29,'UMACHIRI'),(272,30,'CONINA'),(273,30,'HUAYRAPATA'),(274,30,'MOHO'),(275,30,'TILALI'),(276,31,'ÁCORA'),(277,31,'AMANTANÍ'),(278,31,'ATUNCOLLA'),(279,31,'CAPACHICA'),(280,31,'CHUCUITO'),(281,31,'COATA'),(282,31,'HUATA'),(283,31,'MAÑAZO'),(284,31,'PAUCARCOLLA'),(285,31,'PICHACANI'),(286,31,'PLATERÍA'),(287,31,'SAN ANTONIO'),(288,31,'PUNO'),(289,31,'TIQUILLACA'),(290,31,'VILQUE'),(291,32,'ANANEA'),(292,32,'PEDRO VILCA APAZA'),(293,32,'PUTINA'),(294,32,'QUILCAPUNCU'),(295,32,'SINA'),(296,33,'CABANA'),(297,33,'CABANILLAS'),(298,33,'CARACOTO'),(299,33,'JULIACA'),(300,34,'MASSIAPO'),(301,34,'CUYOCUYO'),(302,34,'LIMBANI'),(303,34,'PATAMBUCO'),(304,34,'QUIACA'),(305,34,'SAN JUAN DEL ORO'),(306,34,'SAN PEDRO DE PUTINA PUNCO'),(307,34,'SANDIA'),(308,34,'YANAHUAYA'),(309,34,'PHARA'),(310,35,'ANAPIA'),(311,35,'COPANI'),(312,35,'CUTURAPI'),(313,35,'OLLARAYA'),(314,35,'TINICACHI'),(315,35,'UNICACHI'),(316,35,'YUNGUYO'),(317,36,'ABANCAY'),(318,36,'CHACOCHE'),(319,36,'CIRCA'),(320,36,'CURAHUASI'),(321,36,'HUANIPACA'),(322,36,'LAMBRAMA'),(323,36,'PICHIRHUA'),(324,36,'SAN PEDRO DE CACHORA'),(325,36,'TAMBURCO'),(326,37,'ANTABAMBA'),(327,37,'EL ORO'),(328,37,'HUAQUIRCA'),(329,37,'JUAN ESPINOZA MEDRANO'),(330,37,'OROPESA'),(331,37,'PACHACONAS'),(332,37,'SABAINO'),(333,38,'CHALHUANCA'),(334,38,'CAPAYA'),(335,38,'CARAYBAMBA'),(336,38,'CHAPIMARCA'),(337,38,'COLCABAMBA'),(338,38,'COTARUSE'),(339,38,'HUAYLLU'),(340,38,'JUSTO APU SAHUARAURA'),(341,38,'LUCRE'),(342,38,'POCOHUANCA'),(343,38,'SAN JUAN DE CHACÑA'),(344,38,'SAÑAYCA'),(345,38,'SORAYA'),(346,38,'TAPAIRIHUA'),(347,38,'TINTAY'),(348,38,'TORAYA'),(349,38,'YANACA'),(350,39,'TAMBOBAMBA'),(351,39,'COTABAMBAS'),(352,39,'COYLLURQUI'),(353,39,'HAQUIRA'),(354,39,'MARA'),(355,39,'CHALHUAHUACHO'),(356,40,'CHUQUIBAMBILLA'),(357,40,'CURPAHUASI'),(358,40,'GAMARRA'),(359,40,'HUAYLLATI'),(360,40,'MAMARA'),(361,40,'MICAELA BASTIDAS'),(362,40,'PATAYPAMPA'),(363,40,'PROGRESO'),(364,40,'SAN ANTONIO'),(365,40,'SANTA ROSA'),(366,40,'TURPAY'),(367,40,'VILCABAMBA'),(368,40,'VIRUNDO'),(369,40,'CURASCO'),(370,41,'CHINCHEROS'),(371,41,'ANCO-HUALLO'),(372,41,'COCHARCAS'),(373,41,'HUACCANA'),(374,41,'OCOBAMBA'),(375,41,'ONGOY'),(376,41,'URANMARCA'),(377,41,'RANRACANCHA'),(378,42,'ANDAHUAYLAS'),(379,42,'ANDARAPA'),(380,42,'CHIARA'),(381,42,'HUANCARAMA'),(382,42,'HUANCARAY'),(383,42,'HUAYANA'),(384,42,'KAQUIABAMBA'),(385,42,'KISHUARA'),(386,42,'PACOBAMBA'),(387,42,'PACUCHA'),(388,42,'PAMPACHIRI'),(389,42,'POMACOCHA'),(390,42,'SAN ANTONIO DE CACHI'),(391,42,'SAN JERÓNIMO'),(392,42,'SAN MIGUEL DE CHACCRAPAMPA'),(393,42,'SANTA MARÍA DE CHICMO'),(394,42,'TALAVERA DE LA REYNA'),(395,42,'TUMAY HUARACA'),(396,42,'TURPO');

UNLOCK TABLES;

/*Table structure for table `tageo_paises` */

DROP TABLE IF EXISTS `tageo_paises`;

CREATE TABLE `tageo_paises` (
  `IdPais` int(10) NOT NULL,
  `NombrePais` char(255) NOT NULL,
  PRIMARY KEY (`IdPais`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

/*Data for the table `tageo_paises` */

LOCK TABLES `tageo_paises` WRITE;

insert  into `tageo_paises`(`IdPais`,`NombrePais`) values (1,'REPUBLICA DEL PERÚ'),(2,'ARGENTINA'),(3,'BRASIL'),(4,'BOLIVIA'),(5,'COLOMBIA'),(6,'CHILE'),(7,'ECUADOR'),(8,'URUGUAY'),(9,'VENEZUELA'),(11,'PANAMA'),(12,'MEXICO'),(13,'CANADA'),(14,'ESTADOS UNIDOS DE AMERICA'),(15,'FRANCIA'),(16,'ESPAÑA'),(17,'HONDURAS'),(18,'ITALIA'),(19,'NICARAGUA'),(20,'ALEMANIA'),(21,'INGLETERRA'),(22,'HOLANDA');

UNLOCK TABLES;

/*Table structure for table `tageo_provincias` */

DROP TABLE IF EXISTS `tageo_provincias`;

CREATE TABLE `tageo_provincias` (
  `IdProvincia` int(10) NOT NULL,
  `IdDepartamento` int(10) NOT NULL,
  `NombreProvincia` char(255) NOT NULL,
  PRIMARY KEY (`IdProvincia`),
  KEY `FK_tageo_provincias` (`IdDepartamento`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

/*Data for the table `tageo_provincias` */

LOCK TABLES `tageo_provincias` WRITE;

insert  into `tageo_provincias`(`IdProvincia`,`IdDepartamento`,`NombreProvincia`) values (1,1,'AREQUIPA'),(2,2,'CUSCO'),(4,2,'QUISPICANCHI'),(5,2,'CANCHIS'),(6,2,'ACOMAYO'),(7,2,'ANTA'),(8,2,'CALCA'),(9,2,'CANAS'),(10,2,'CHUMBIVILCAS'),(11,2,'ESPINAR'),(12,2,'LA CONVENCIÓN'),(13,2,'PARURO'),(14,2,'PAUCARTAMBO'),(15,2,'URUBAMBA'),(16,1,'CAMANÁ'),(17,1,'CARAVELÍ'),(18,1,'CASTILLA'),(19,1,'CAYLLOMA'),(20,1,'CONDESUYOS'),(21,1,'ISLAY'),(22,1,'LA UNIÓN'),(23,3,'AZANGARO'),(24,3,'CARABAYA'),(25,3,'CHUCUITO'),(26,3,'EL COLLAO'),(27,3,'HUANCANE'),(28,3,'LAMPA'),(29,3,'MELGAR'),(30,3,'MOHO'),(31,3,'PUNO'),(32,3,'SAN ANTONIO DE PUTINA'),(33,3,'SAN ROMAN'),(34,3,'SANDIA'),(35,3,'YUNGUYO'),(36,6,'ABANCAY'),(37,6,'ANTABAMBA'),(38,6,'AYMARAES'),(39,6,'COTABAMBAS'),(40,6,'GRAU'),(41,6,'CHINCHEROS'),(42,6,'ANDAHUAYLAS');

UNLOCK TABLES;

/*Table structure for table `taofi_agencias` */

DROP TABLE IF EXISTS `taofi_agencias`;

CREATE TABLE `taofi_agencias` (
  `IdAgencia` int(10) NOT NULL,
  `NombreAgencia` char(255) NOT NULL,
  `Direccion` char(255) DEFAULT NULL,
  `Telefono` char(25) DEFAULT NULL,
  `IdDistrito` int(10) NOT NULL,
  PRIMARY KEY (`IdAgencia`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

/*Data for the table `taofi_agencias` */

LOCK TABLES `taofi_agencias` WRITE;

insert  into `taofi_agencias`(`IdAgencia`,`NombreAgencia`,`Direccion`,`Telefono`,`IdDistrito`) values (1,'HOSPITAL ANTONIO LORENA','DIRECCION','',4);

UNLOCK TABLES;

/*Table structure for table `taofi_areas` */

DROP TABLE IF EXISTS `taofi_areas`;

CREATE TABLE `taofi_areas` (
  `IdArea` int(10) NOT NULL,
  `NombreArea` char(255) NOT NULL,
  `Descripcion` char(255) DEFAULT NULL,
  PRIMARY KEY (`IdArea`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

/*Data for the table `taofi_areas` */

LOCK TABLES `taofi_areas` WRITE;

insert  into `taofi_areas`(`IdArea`,`NombreArea`,`Descripcion`) values (1,'GERENCIA REGIONAL DE INFRAESTRUCTURA',''),(2,'G.R. DE PLANEAMIENTO, PRESUPUESTO Y ACONDICIONAMIENTO TERRITORIAL',''),(3,'G.R.DESARROLLO ECONÓMICO',''),(4,'G.R. DE RECURSOS NATURALES Y GESTIÓN DEL MEDIO AMBIENTE',''),(5,'G.R. DE DESARROLLO SOCIAL',''),(6,'DIRECCIÓN REGIONAL DE PRODUCCIÓN',''),(7,'DIRECCIÓN REGIONAL DE VIVIENDA, CONSTRUCCIÓN Y SANEAMIENTO',''),(8,'PROCURADURÍA PÚBLICA REGIONAL',''),(9,'OFICINA DE SUPERVISIÓN, LIQUIDACIÓN Y TRANSFERENCIA DE PROYECTOS DE INVERSIÓN','OSLTPI'),(10,'OFICINA DE DEFENSA NACIONAL',''),(11,'OFICINA REGIONAL DE ADMINISTRACION',''),(14,'D.R. DE ENERGIA Y MINAS','DREM'),(13,'DIRECCIÓN REGIONAL DE COMERCIO EXTERIOR Y TURISMO',''),(15,'CONSEJERIA  REGIONAL DEL CUSCO','CRC'),(16,'OFICINA REGIONAL DE ASESORIA LEGAL','ORAL'),(17,'SECRETARIA GENERAL','SG'),(18,'G. DE ACONDICIONAMIENTO TERRITORIAL','SGRAT'),(19,'D.R. DE TRABAJO Y PROMOCION DEL EMPLEO',''),(20,'G.R. DE CULTURA',''),(21,'ALTA DIRECCION','');

UNLOCK TABLES;

/*Table structure for table `taper_modalidadcontrato` */

DROP TABLE IF EXISTS `taper_modalidadcontrato`;

CREATE TABLE `taper_modalidadcontrato` (
  `IdModalidad` int(10) NOT NULL,
  `Modalidad` char(100) DEFAULT NULL,
  `Observaciones` char(255) DEFAULT NULL,
  PRIMARY KEY (`IdModalidad`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

/*Data for the table `taper_modalidadcontrato` */

LOCK TABLES `taper_modalidadcontrato` WRITE;

insert  into `taper_modalidadcontrato`(`IdModalidad`,`Modalidad`,`Observaciones`) values (4,'NOMBRADOS','MODALIDAD PARA PERSONAL PERMANENTE'),(2,'CAS',''),(3,'INVERSION',''),(5,'REPUESTO JUDICIAS POR INVERSION',''),(6,'REPUESTO JUDICIAS POR CAS','');

UNLOCK TABLES;

/*Table structure for table `tapri_persona` */

DROP TABLE IF EXISTS `tapri_persona`;

CREATE TABLE `tapri_persona` (
  `DocumentoDNI` int(8) NOT NULL,
  `Nombres` char(80) NOT NULL,
  `Paterno` char(80) NOT NULL,
  `Materno` char(80) NOT NULL,
  `Sexo` char(1) DEFAULT 'M',
  `Foto` blob,
  `FechaNacimiento` date DEFAULT '1980-01-01',
  `Email` char(250) DEFAULT NULL,
  `Direccion` char(250) DEFAULT NULL,
  `IdDistrito` int(10) NOT NULL,
  `Telefono` char(20) DEFAULT NULL,
  `Celular` char(20) DEFAULT NULL,
  `Ocupacion` char(150) DEFAULT NULL,
  `Usuario` char(20) NOT NULL,
  `Contrasenia` char(20) NOT NULL,
  `IdCodPersonaEmpresa` char(10) DEFAULT NULL,
  `IdAgencia` int(10) DEFAULT NULL,
  `IdArea` int(10) DEFAULT NULL,
  `IdModalidad` int(10) DEFAULT NULL,
  `FechaInicio` date DEFAULT NULL,
  `FechaFin` date DEFAULT NULL,
  `EnableSINO` int(1) DEFAULT '0',
  PRIMARY KEY (`DocumentoDNI`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1 CHECKSUM=1 DELAY_KEY_WRITE=1 ROW_FORMAT=DYNAMIC;

/*Data for the table `tapri_persona` */

LOCK TABLES `tapri_persona` WRITE;

insert  into `tapri_persona`(`DocumentoDNI`,`Nombres`,`Paterno`,`Materno`,`Sexo`,`Foto`,`FechaNacimiento`,`Email`,`Direccion`,`IdDistrito`,`Telefono`,`Celular`,`Ocupacion`,`Usuario`,`Contrasenia`,`IdCodPersonaEmpresa`,`IdAgencia`,`IdArea`,`IdModalidad`,`FechaInicio`,`FechaFin`,`EnableSINO`) values (40494250,'EDGARD','RAYME','UISPE','M','�PNG\r\n\Z\n\0\0\0\rIHDR\0\0\0d\0\0\0K\0\0\0�\"�\0\0\0sRGB\0���\0\0\0gAMA\0\0���a\0\0\0	pHYs\0\0�\0\0��o�d\0\0TIDATx^M�u|����7�A�QQALBTD�PP���nXwo�mc���������{�{����q^���ϳ;��ω��_xH�ԈŇ��\Z��ܗ��۲S\Z��F/=�?q_~R+��{�Y��>����梂�^R�:��\n\\{Q�k��[w9/�u���g���x���>/��[A��݆K\nB�mܘ�m�����wE��*$�3e\\S��k\n�pM��+	�sІ����/ˇk��zܹV7�y��������]����|������=���$�U�q_yNn+�\"g��<��@���x,��eg��F/9�Oh��\Z���?�s�ߜC�w�A���_]g�S�{�~����K���R���r1@�,:�!��d����d1r�q�Zz����bNˇ��]u.n�����\\�F\0`\rJF�(ݗ�����>O@���f�}��\r�Q\n@������\rWP�q@��5�\r��qC7���&��\0�k�\npY\\�;�9��\r\0cV]�K�ZsY�k���+\\�U����]è��u\0������_��w�%����+/\0�y�`\\���\0ʶ�����\09�Q�Ok��\Z��$���\03`�ه�g�A��u@=f�W���p�L�+��h�\0YtT�p��rs���;�����3���|�o\0��rl���5�㦽�F�m��x��~(�@2 ��gyA����l ����N `�gd����7\0	�@�;�q�b��_Ыx\"�8��̶��ኣp�l��:׀w��o�_W0c0�B�0>���<�Uo�Eta`\0�r<i���ҳ\Z�\r���g��0��,�E�4l�1\r��s�h ��!G���e`5�XtD#�w��\0��<Ũ�4\'<�\0\nb�x\Z@��4��\0d�f��/� ��\n�[w١7����\0`�Ck\0g^cb���ЎѕQT(��	o@�a�`���p\0�F\"2��<&��(�?�\ZVψ�����o*��=c(�������D���X�n,��f�	_˱̫V\n@x-C�_�K�<�\Z\\\nK��<�\0��߸Z���k���\Z6f���G5`����\0r�r/�eb�g�x�\0�q��O��20�P/p�O�s�_����u���g�S��d�ĳ���7b��ۼ���1������������g`�7E�D�e@�يB�A(6	5q~��C�H2���6�T�G#���F����o�hf-�J�Q�\n��������@]^K��� <�o)���q	zYB��k<e4�e����Nh�\Z:��\\�-<?� G�X6(��r�C��{9\n���5O� F_Y�_X��&���cx؇�O�\0�\'y��x��~\0���_�k�D�1\0��V�d���,��!��@,߼!e\0Vd�θ��\'f�m�N��6`��q\00.0���X�$�h�X㿚���W��}��9W��`xQ�r�j�e\0J�c_@q_���3�P�����$R��2�䰆-:��%u�7���@<�,����;;�X`�\'��;\0�D\'�sb�_`�2 �|�M0�����,kL7���x�%�E�\0̈́Bf���7�T,� �P�X�;�a�o0*��\n�\0h �q�����s��ͷ5ޑ;\0|W�7�xG��4nC��dm(Qx[�:�\r/	��B�\0��\\�w�|_�� ����	^�\0&��9�P�7����ٸ�Y��/<-��0P�eǑQK�<� ��Ὄ�\0 �(�o%)-�\rv�]�E�8\0 (�� �?��!>�7`����n+p]\'�EWa)�M\Z>S�����N�b�:�$�C�[�,�2�A���?Ɏ��<�@��+L��\0��7a�]ƻ�e^�5��~�g�>����\r���#��jK�ed 9��}������T�ׄ,��%�8 \0\0��C_Fc��1j<�P�����р�^��~��\0��P�\Z������\\QJ�p��$	e�*�FP0��T �喇��FZJJj�fP���Q������Q����k(�&�J��qH�,f�9�D�]29�����FO(<ր0�o����-w���._��KVi��E�2m�&N�%����w��^�?�F�|VM��\nH3]�f��f��GQPQ,t�~j���3:q���V�Z�k���[/!]��B�1��bM��K`�,�>��Ǣcp�	����S�� R��8��.E���p@�@��(<�\Z�\0���g�N�WK\r}�S�R}��p5�����+n��E,V�!Qjڲ�Z�����s��:�O ���8�4���b�HR7)~��q�X�ǂqJ7�B��l�!\Z\0�Q|�{\0�%6���-4y�%f>P���^-\'-Q��0eN�W73�IW�*5��>���JV���>�R�F՛T�ϩ&���������K�Ǳ8��!�\02�]��)�PW�J���2�B\"\0*b���� �dŋ^��?�\"��ٟ H� ȯ��\"\"Pn$J�r�\n��g���Ia+/\ZV��4_���ɻ�I���U��\\���KN��ȭ�?)%�^�h�e폨������U vc��e�`��;T��@��\'X�\\k��wq({<�����D�\'f+\0$8�P�[9���XI[m|��쟴��&n���M9o����\n�?Q��\0��X�c�\n���Sk������B�:+`�1M�xP�d\"�L���(��3�8b��K|��8�	ę�dl�PZ,����H4��`�\"	3�Xv����\"Qn�w�0@x@J�\r��/�߆0в\r�\n�_A9����3�\\rP޼���+M�����(�6]:r�x�V��x|<��X67���·��{�MS�/j�׮~�NۭI|���3Q�և�����·>UҶ\'����X���3�)��?��J��\0:�L�|�s@�$}T�C��S�v�։37�e�%M[�_mF\')�O��d�$%oz�-x��q_ɀ���&�@iS\0g2�L��&�$�D�N�	�h2�d���7��(�P<��%%���e��p�����71�`��0���C\0���_�1NJϡ�\n+G.�p��x��K���*�~>!�UO\0���	(#!�Z\'��ɶ��̒�����\'�����5�U�K��U�ӷM:��@��F�z�S��^��[S�?W��gY�\r��\\Sٗ��\r�̧�\n0�xL*2w�%���UGVҥ�t��#�;|C��ׄ�-��o�\\��U��)m�SM��ؑ�3\rI�x�@q��JER��<(K�8c\Z���v�}�)\05P&�K��s<��o�8� ���=��\n�{���}+�#Fa�X��[}M��\\ӳ�wtiR�� �.�⪼\n�;i��fǢQ�n&�}I\0c���n*��X{\nJLF�iĂ��)g�<�Y��*�o���vջ5~V�Z����[I�I隻�f!�wdɌ�/4s�KM����i\0Mg\\����\\�To��Ӯ%�j�>m�wU����ٛ5*8M?��k�V*U��f��-O4m�#��-�xH\n�1�Ĕ�ҧ�4�����;rW3����Lۆ�gR#M�S�@c��/��_A(aHK8�����C[c�r�����S\0��b-`� ���\'R8-�vY6҉�j��TQ��(�����2%sC]x�kN\r���$�*�s:2\r\nIC驌�l�L\0p\0fm{��i�����l�\\����%ʩF�6�޴�J~U��\"ׂ�B��T�p͝3Iw���l�������\05g�s�:pW�$H��K�\n�bfa�;�O�V�QڼL�\nKU�_;(����Z����	�}�w<r<#��4�����\0��H�3���M���0��i�0�:g\Z@��Pߤ��)ē�|�P*�PJ�H���S��q�C|��&�(>�l(R�%�o\'p�I�Y@L4��wu��#���P�.�ӱ�w�u�-��]3;��/���#�F�C��Y��,���\r��`62�q��Ê�\0�,>g�s�?���O��6z��o*^�[�,\\J9�����,���Qe�_��{_kўWY��%�K-@�y�;�H/�K��I����6j��/���Uw�I��r�rU�/�w�b����9�s�0f��xD�Qb���?j��4�)�MAWS�^S\0$Q�\'�q%�i�S8�RͻDFԢ3��(��3b	��O�4���&R�N��J#�A�9��;�q*\'I�)�R�|��}ݸ�Tw<�M�c����,w=�ˡ��]� 5^sQ�S82/[�s�A�\r=���x�<b1�jY��w@��\0Z�u/G�s���YM@���b����Su�z_��<֪}��j����Z��b��v�y*��#�<.=ϐ���ͣ����~��_������(g�r-�\\�|����0�x�Lhw^?�f�Aj���Ђ��~�!	:��������x(�X �R�G.�0���b��\01��-�Z#��9��s*���Y�h3�ͼ�U�2�k���Ƕ����˼�������,0�3������0�Ugƺ�H��Z�����8}1�^��\0�<��PѢϴ��W�z��(~)����8Km@���JkQ�zd��+���/���!+ypFW�X�2r�����o�������7Z�\\��@�J��W��b��<]�=~Q��@�.��}k�~��QY.�*�X���F˼/�����َ<B�EM�\00S�3`�D<c2�$`�����g��\r�qT�.Sp�Tz?i�!f��y(~�V���Mm��e;j��GZ���V�y����j9��w>t�[ʸb�#��y����Wk[�|�|��\'zs�=���+�]�gi՞�s�d\\��n�O�/w�Gጫ���\0a@�ǲ7|�\r���H:�MZ�G\n�G�]�ciW�*�\rL����^U�h�][O<���R�7�|�2O���W�F\0b^��&�rRo�mӊ%nʑ��r~�P9����ȵ��ħ\n*R�:��D1�9x�B�ݮ1��2.a\\��R�ΡFJ�h�\n�$Y� �I�S��d�&ß�V2��`���.���;���Xf��Q�*\0X�������ϴ��S���<c�s�z�M�_�`�v�9�U�7������p�o���k�����ul��6y����P���Z��9 �(\r��D�^���ڈ5g`���h#��#�&y��7�v�Fi��o4yn�z�XH�?p�7%\0�h쭊r)_]���C�7����o9�/\0�\0y(�����\0��]>��y������Q��r|\\��(\'�\"+j�f�Ɖa!+����\Z��n�CF8��v�2Pf�-���9��P�B�[�����>.+�|G������p��\'��E�¦Cϴ��Km>�\"K�@I|F���O����3~�֭٭\r�pc����J=����\"ud�h�6@Gwj���u򵶣TS�Y��m��v��p6�>�%�ξA���q��3�J;���Y��q�l/�����/!��˥D��_Cſ����T��F{/J�/�ѭ�\0�Ae1�~yY/��ӻ+��+A�P��r}�D9��K��kɥ`y�}u���� �:_2��d#�6¨��\Zl�N�f�C-D���\0���w	Կ��o�]�~%�K��e%ް0�� \0�z�G���#ϵ��z��2���2_j��W�y���}��^������$w�0]����O6�ޕy:s8I�w�k��:�3Zw\'hϡ�(����@G�lJ�wA:x�]y�#W���e��߾ۃ�F�:�o�}�w;8Ɓsu��M���M��6�K��Ȉ>��{�������]�@�8�F��?^��{z��?>�{�����ڕ��JCS�)�W��Z��\\?��ϟ�%OI�Ҭ�2��Mxr�y�A���v�5F�R�x���j��0qw���Z����������폴���\0�J�[B\\�Ł�����ϫ�[\0f�l<���x����v\"��}�^;`��ZG�ψu��\r�߭gwV�ʥ5:p`��혧�;gi��T��;S���՞�/����C�C!P��Y@��F\'o�։��Z(��A1`�;����ct��Y-Y�Yc�bU�J=���\Z/�C��Jſ���>#�Cؙ�U�^ ���]={vM������uxw�vo\Z��eK\0�G�Y��C��v�ªȻ��umǻ�B�F�����6dF�c5�]����:�~�G\0@�E������s�=-�%L1�����Ȣ��Ē�Z(k\0cþg�@6\0<dAp�8\'=m� �_�0}��_w����ڢ[W3t���8�O�v�T��ڲs����Ԏ��Q����!��������\r�\0���ۍ��(��K?�2�^ժ5�\n�����CԬ�hUj�A.���kI�޷*Z�������W���~#���z��x~שE.\\9����k�v<z��J�+����u�(W�rm4L���᤾����N��1��8^�h�����l>������\0��Z���#֢�5��/�C��ر�y����5 g�d)�BR��[oK�����@@�H��r��s��ЕY���;[����PW�>�Լ��z� ]�/mҁ�ǵy�	��qJ�v�xNw�Ӧ�����x�u,˲�7�N���b�����C�|��=\0��L��d��,��o��[�\\���G�4e��{������ϭ���_�8���r����|�H��شy��ݹ{S�^>��wt��%=}X;v�֖-Iڞ�J_}\"�ҕ����r��\r�)����m�{�w���h&4����;��[���i�I�tA~#�x�n�!Cu�A���	拙ǙO�;�i\0!��k�!��b�.��P� �n��XĒM�)�Xb��I3��X�їœ\r�n�Y���7�=�9[�/n�ޣG�e�	��zV��]��헴q�Em�sU;��Qo���[ڀ�o6ׇ� ۰8��(>�˰��0�̹�˼6��;����;�n�~\r�v�U��?��qm���X|��r|��r|�@j6�g-���h/���v��U��u��=ݺ�@\'��Ҏ\'�ns�֦\'k�\n?U��k�QE�~�G._�-���#�v��u���Sҵ���W�s\n�\0\'�1�\'~d|����	���3I���x�*b���r���,���P��ͷ��%6����\nj�5d^�	��Tgi�^��qþڸ�l��o��S����\Z��OOn-��+���\09��[/jՖZ����Ь۰�20G�Lݗͻ(ff�6��l�\Z7Z�b�/Y�#d0�\Z[c�3����nj��]Z�h�&MY�V�Ǩ�/���\'?*g��NUm�õJ���rWm�����Vݵ��ݶ�f,����Ӊ�������ݸO��.֢�	�ը�r���5�˚��3��@��1��{\Z82J{��P�>��P�y��\'��az���o�N�=|��I7�Rb���}��S��v�e�����˹&�}�Gq�\0�l��l��dd�)X^��F�n��gP�S�7���O4\" UoU�R>>]u��:��x��qF���k���Z�qA+7���-����z������U�(g�oU���LN�:��\n���?Y��Rn�\0܊��=�@�O��?��̳�����Q�j���4�����\\\n} �=�WS�k��\"���ّ�Rm�z@I�3�d�)m�vE��b��/kA�i�Z����APT��T�x�Gdm��?����I}+�џ=u��樉�+��P�`XFS��}g�^\0; �a�L�ƾ��eBmیu��$P�.�X/5�i�,P�I�>ۑ���\\�Z\0��8�1ѳl;`P���I�NU��>�;����R�2_j��?���\'N+ů�r^KןҒ\rg�:�6n=�MD�m�/i�ɻz����]�U���|��_����o$��������\rx˶��Qb`�|-Z�O����,ݭ΃|��o픿��;���-�(R�6���*G�o���*и�J����1\\�NŦ�׼U\'�|޻�\Z���ho��#�Nq��/�ꜿw)�����(\0�����k�t��ks\0!���NC��K�v@��c;I�f�����\r@vËN\"����rIe\"\'�9�4�WV��Qʧ�g0�=�Jr�,b*�@0�X;c%�����a��ar���r}ZO�<�i��m[bF&�~JK7����3��y��zY�����EN�U�#T��Z��cW���O\r�R�������=t\'����	)4\"(UU[�W��^��rR�H�������z-��C@5�!��sr-��SU�V������P��*��W�;{k��m\n�[�1҂5g0�KZ���y,���j�����X���ȡ=�5\0��??S�E�W���+�ū��	�J\0��(8ò+������\r�����w���ߎwl#aڞ-.���%J\nS���YR�LN��;�����V]�g���ܡ\reծ,˵\nu1�C������W�*\r��ȑ��ܭu���Z�qY�XT�`�9>_b�m�IP?tM�O���u;��4I���hbb�f̘��+Vi���\n���������#�a�n��a+��5Z;����u�><Lա�w��]y?�͜��xmrRS�׷>���r��\\\r�U�F���^o�R_�	J��W���\"<c�Z��r���XqX�Z��\ndV�\00���N�p-���O��Х����dg#��R\\+��@�6�f\\Ae�\nYO�e�e������#�)5�I�]@.+�f�4�]3\0�(k.��yD�Ŭ\"f��td-H�g��l�m0�k��Т���7��a-�w�#V���uǠ����Y�^}F�֞a���Vg^VƮ��}�������\'���Z�x���X�CCT�U_Uo�O_��K_��B?��\'���m*�_���B���[����|����W�U��z�]P�!��\"7����F��SG��M9ku�k������?��f��7j�ң�ς�E,�����9,g��\Z�4�A��ީR��ؠ)�\"�X�Q��L��|OT��@\r���xk�JZ%˘�ZLk>�\0�YJW܊�3n�8+�ߦ0�h��[*���N�5;��č�x��x)]�	����=��c\\M`_\r(��o붧re1CYh�ԗ\Z2V�\0����5��3���+��1��8E�x^�]ҁ״`z�r�_x�\Zt��ͺ�Bö��k[�o��mT�z��������2>�w�~�:B_6��7R�J?�0��\"q�^�щ���WxHsbH�~�����Q�_�P��۩a�PM��W�W�r�j�̥��Z�I<Jд�(bSU<�@.�q��4��F[x����t<`�.�ȀY\n(K`�%пU�Fa�-�l?�t�)q�9e�3m%9r�� w����U�1\0��l%.f��*��2�Կ��f)�os�E�.\\Q�>���%[��Jx9�<� +Nh��#�������b?������˚�r�����G�۩5�[����[�J��߮�����!�����O��|U�%������y~�JEHisWd��ӟ�!PE�k.��\0� 9>�[\09J��\"໖\"s�����Vu�(��jf�^y6��@�ӑf��P���?����sӴ4/1@��\n�@��L\Z�VdA�kHx�SV!k�[:������/t�B���W:{��]��$�.ԗۏ�{�(y-Y��D\rU�ׂǬ����2�S�3���(��\Z��r�����K�/h.+ڧ/? ��Cڼ���=���U��oğ���A�W�o��Ho�T�X�Y�U/��n*�ER��U��j�<`�z����z�b�*���xF-�(eZ1X�@N��\n7�|(�\0��RS���9�b�\"X����1?^P>�k��K�6����g�`]Z\Zޑ̲ϸY��y]\n�\"Č\\ď��P�����SJ��c�4`��;U9���tȢ�U�k)�7�~\0p�t����R���ԥۯt�r��/岊ɨuX�\Z���M���8�\n޳�.��ڪx��߬�����F�:QӞCT�Rm\r\n�Ӥ�[z���4�v\Z�8�TJ]�OӘDZ�j�6lأ)���g?˅<� <�^����Q�;����\nU����Vݿ��`��Ujݯ��y��n�!��Y��\n�rQfeW��X�uckƒ-Uu}��rT�S9�u���1�tM��\0X�����\n�w�k+�x�)甊La�At�.���\Z���?@���9���-}S�1t���YE�\n������\r�p�F>g���:�D�>\'U~��\0��+]�<z�k*�\0a�~\'��{�J1�{��e��n����H/������~�㩰I�U��Vr���36+�G�f�<����k��}Jbe��;4s���z�r��X�eD��*G�\Z��M�*����\Z��ę�4}�r<~�9�@\n�S�!��J�/נ��|�K6M���f�6p-���-���X���z�\Z�#��c[ vu*x��%�E��-�y���⯁�}�L���;N+q�)�2U�����CL���V����\n�U����	lj�G�?:Ȭ)1a��\'�\r�/�����ϽЉ/X�Bo��U���\0 ��ޢ�\nr�S�=�۞���g:y񹎰}��S�9��<��~@��H{�?UP�,��6Fiϑ{�0�M���55�9@qu�:�g���Қ<��v�6M���i]��x+�2(�\\,�����u�?�j����z��_�޳�z����?}��7�b��uT��-U�:�]�\Z�� p�b��+-rk�;�����]�>v�0���b�^���rW�?�\\���ncR4v�yŭVn��b��r����Tؕ�5w1�#7A���E��Mb�՗J\'>�G�+N]y�#�\0`�\0���/t�2P.CW�ﾒ�ɫ�t��s��|�\\���:�^�\nr�6�~;�a;��%����RO�(�.Z�}�ht�8���TĔ5���/9�pO�)�Is�+vF��gd�i�A(�,Ūi���hn��7?�:�9툗:s㕮>x��O^��ӗ���^��C��M_���6�7�*_E\Z�eP6�Z���xTb@��%��g�H���+��w5T�\"�X�P\\��E��X�� �����w�z���wPa~c`�wP ���+�K,�KL���ϣg�z��K�����P�Ŋs(�(�f^r��Ka����<w`\0����~��n=~�;O^`�/���<~�����\0�o.��;��]U\'#������t��c����������(&-S	��)0�xlk�=\Z��E�㗨\0�.V��k���5l�����W�\\�e��M����׺��\0��x����3���\n|�Py�99�wU���,��K\\\nY��%�ɐ\\��qbH���uH�����*+���9��h���t���z�r#����o\0�81\n0,�u�\'���n�)�.=����7z�����|�\'\0��&6(������&�K�\\�37�tz���4ʺ���b\0q�����x�G/^�)��9E<(��\r�\0h+\rj4j�9+�:���KO5:,B��QH�\"�\'����]�\01�ǀ\'��\'oԟ=��!������zsV�z��i�n�\"��֣W�����s��O����.�w�����/��B�$�H\n|R@�����x�\n\'%����z!�8A�\\��ُ�8l���]A�3ߩ6k�1�������[��ʒf��7��e.����@k�%�#�;�/�n��z��޼1P^��+t���s�7͠\r��	o1�� ~O��3x��ˍ��A��\n�ͿУ�/�>�R�\0��?b|�w�M������\0]�s��.=Q��Ù\r<��������&<e��x(>f�6E%oP�_��ˍ���\\�U�fMm�ت͙�\0�pQ������0�3��y�{D�>�Z/S�m�Z���wN{<�Y8AֱX�K!���7 W���uU�>Xo�P�_����l%}���\Z��b�S��B��m���(����x ������KПka+@9�e[�S�7lq\0y\r ���)٠ۘ�C�fpwa��}�W~c:~�\Z@�@CW,n��*��0�@�\0y��zmb뗲\\�!���z��+�ۯ�y�]�ձ34)m�B\'-$;Y��Wd�zE�n����nלT�DI͘=[�7��z�ࣧ/s�x\'��|�h���{�t��ku��\0R�vs � =����)�@,�:�.ME��dA�ɲj(G���Ꝧ��q:x��\Z�̈́S��*\\����Ő�y)�;�!�=�x�(�L̼ĵ0�\0����t�߲/�<.\nM�A#�@�\n:3E?�e�|���v�ݘȌy����\\�Z\0�ˎ�\\\\���z\r�����ʼ�s��}�4u�|,�q�뷞��Gk����x��\'�WЄE\n���+\0f�����^`�-TDn��Z�ce7����;v�i1���,�\\��<�K1�v�!����N*���K\rS�2�Żx⤺&F[�E�9Y�ܵ��*S���G�Ј�$ݸ}WGϞW����܅4��[|��V�!NX3�ŕaƑ^�y�K�lp�aY�X�倏�T��@��yȫ���9zC\0��쥍Y@9��;��~�q�J�v\0a4��a�zu\0z��#��᧖�h\nn�c^���w�o�ۨ ����ʵ�5n�B�ϖw�l@Y��,SD�RyF���v]4�?P�Ӵ`i��1�t�6��|����v�v��[��\\�����l\0Ҩ�p}������\n~^O��g�5�8�m�+\'�2P���Jp\nc����t�տK<�lE<z�Z�/�$��IL��Ҙ�H\r�	��)o1�o��$WQ\nB�AI���m��a�����]P*�+�nB�o����3>#m7图l�3����=Fm�c�!�\0r�8b@�b���q�y�޼�����aK]�v��\"m���th}�4k6��{��X��	\02n�����y\0�H�S�*&y������y�1��.^�y,ݹB�g�\\�^����C[�i�v�����Iy�\0��c���9\n�IK\r[]hA�4�:�9K}��40|�f����H����_��H�154h��E�IWV�P�[&�Lt�S���x������s�9�e��k�mq\0y����k�ʶx����,N8`8Øq�!�_�*U�Q�UKk���x�Vj���w�&X�qH��K�e�&���p�x�O��-�O*����Is�Ǔ�\0��6i�b�.Ql�BML����4k�z�]��7d��Hv�k^r��^�qOUi����^@\\�����NAhm������{�+׻�.Ր���ʴ�m�$�	D��\Z��������k�N)H\\2z2��Z��!V��ZRb�В�A|r���ĩ3�<�[L�\0��0�<Ĩf�s?q;�dv��r���=����m���E���6�e�5���_+b�By��P��х����gܤ����P��f����J���K^�@d�y�tb�|E죓kB*YؤY\Z7y�&O[�����M��a}�so�a�Q�����)}Ӽ�J���r}HZZ�f�qĔ�e����PCU~�.�C<�����]<�4�q�Y�e�FG��o�z�	Q�~cT�`;�c5�y�������حP�\"Ӽ���O`�\0ɦ��`��)O\r��<N�B�j�\nɔe�.�)T��&9}���S��\'G���M,W� ��<��S��´�:\0y��_S���xf�ֳR��?~�<�y��,S��Y�����3:�)ә\nM�����\n�M��dM&+۶����i&�y7��l@�>Y�i������ϭ��iB�%Mu8�ROe�+k�Y�kte��\n�\Z�5Z��w�\"M����5VQ�;�L�}���zC^�����R�`��ߺ�! �>�#���-C�~�3��1.�Ü,/��w���d�\rK,�b�1�-Qy�����W\\�҃?Ik�<+���,�ߴ��P� g�<��jHc����2�%@�7i6�?v�\n�\\���}w9e���ةr�~�\Z�;:M~����P#�36A�qS�ʽ�GV�ܵ�M�w� ��I3�no���U��?l5��L�	�j�E�Z�b]_���O��Al�X�����OQ�Qʓl`���)�՗�C���~�:2H_�c�O������\\EH�����0���x`���\r~oKl5|�M�Y�v΁GX����S[Y:oe���0q9{�9֎���B��y�\n�lĬ��Y&v�X�e�&Xr�����=�.(*n�n޼��=XV���+v���y�Qa���	\Z��ѡ�440F�����W�B�56)���A7�.0�\"m�Ϗ�z�}�),dh�|����1=,�k*���I=�`k�@�	�֗�.o�jj�>K�cְ ��Z��&��|�d��1Ц��5�;@�x�7T���-#U�()@�ܢ��-F�U�\'}�ʛk �9i�5�Q*�,�ge��\rfP&����є�V���Nh���ٛY-`+/�W@Q��2O�昕�����\r�j���~��%CJĲ�\0Ɖ��,nṹ�4�W�\rIԈ��\Z8^��c��;B�����3D�G{�������\n���Z\rF]wL����~��D���O�r(��������B�c�?���Z�m�L�n�[�;Z+5�l�����p�b���MΪ{,���[dr~��c��z\0Fw<��`_u��%�</b�E���de5q_��6e`iwvO+��s�9�gy�erY-��v�-��m1�h�����Rн˙��uPl���m_\0�Kx��d�eb��騎��g���\\&���[���7`�L̰B1q�nO�@�kH`��D�2NԿ^Q�ʍv<Z����u?Hqi)T�Y�\0y�=Z��n�7v�z���*�3�X�P�,+�G?d͟�2l��Z\'yɲ,�1a�õDUE��v�+X�ɣ�ҍj-i ��V�)�\0�����g�c�����\Z�1��=F���P�k~b��J(�&���b�s6�b�П�z��Y�d�����o�5�L��lc7ڷX}	_���yZ�?.X��@��/�\n3�L��پ��=u[�~�:�s.ܼe��}O&���Ki\\JY�R�E΢��!����\r\'{�y���0�2����\rL���,�5�0K5^��n)�U29��~�x�*ƤT�/(7�Cs��.�Ud�%9U:=%ƺ���пh�aX%yűL؊ϛ(żҼӘ���\0��z`��u�V�դ�����z�E*_ah�b��d���\'Ax.�0H}-��%Bd`���p��5\Z-e\'*t#�u+��3�3�kܫ��3u��#���L�	��gL!7�\'�������O�}��MJ[������I���KW�Wڬ%� ��徛�v����\0�x��S��~�*�_����}�j�P��[S���!��y�Sx�9�<�h��̨�����x��m��$3�E��<PVn�z�U�f���X��x�\0�\n�<k|�lj�H���0kw�Z��Q��h�gƇ�a�v�6�s�6�0�<c!�aCԠ�\0d�Z��W�X/.+���/��:��w��L;����X���Q�{�S����%G׉�W0ދf���c����}�\n�ns\"|vY�~@ki�oޯ��G�y���˪@�ع�%�;O��)��8��;Oj�\Z1,�B�ckk�+1u�Rg�д�����1Q�8u&���_�N=U�c7��\Zt�?�T_�`M���7%�Վ}由����7Ѯ���(�x\Zg3KN3v�&;:�/m��,;-����ite5��[kct�]�`��S�.LH���^���K�j��y�\r]�a��\\���՞�WX�tB+��e<����:t����5�PL����Uu:����G�3��Q{�)���R����;&k���!N\'�k ȏ����1n����0�]^�qK{X����-��\Z���B����c�x\" ��j�w�8B�8G�SHt��c�+\"�W$�Oи������	S�0)I�h|B���(>a�&\'MW�6Q�����{��yx�x(�O�z\r��z�V�^��s/n��~�=H��Q|�hR��L�����4m��5s��a��q���\\��Ȇ�,4@�Ԩ�r����$]��>�ܕ�S�k2�|�k�3���k���ՠ�5/�6}�X������Ϯ�d����͚�6���T~�z��ܥ\'t;F��tWy -����9@�w�d�0s�P؊3�u灚���s�T��������k.F<��s����4d�����0e�\\�\"�)(2F�Q�\n���LTDl�\"�&��N�8�o�����\'*nb�&\0H��́��\'h��u�$��들�CiQ�֝�}��Hw�ر�~�����\Z];A>9\re��Q���L����1(�3s>��O�>��\Z���(+���,����#7�a#@Y�q@�V��[&��kn\Z\0��D����h���RP��Ԕ9�:u��y��d$��)��E�A,��=�髖���8Ze���Z3�Hr�L�崴�j������q�(\n�B�1���#��� t<6^���8y����X���6./�$`\"c9���OV���3N4/I��IS���Y��/v%�1I���T������m�^xI/�hۃ�xH���:&R��3��َ$��V��L5���TF��x�Y�,�Q%��e��@�ь�%�A�eaet~[��{�Xt`ϓ�$%n6f��$�JZ͚ac>��a�NI���\r�����0&M��	�D���ix�2:�a�١�:��\ZX��~�J4��-G+gy�L��o0:�~l��\')�0B��#�,��S \0��F*f�	��och\0��2��(�@1���C` �+�\0�K&$2NQ�L����n�Nkh�l5�\'VV��h�Y�kc+V!v�?�y��G�7����P@r��,�\05Ŭ��\r�yOҴ�*�u=�������m<���OI�G�¦S����Ѕ����}��C&��\'1m�R��d�7j0�s\'���\Z���%%�[KJs�xb��\'�@թν�fz�a������죪����mT�~����b�4[Ac��P\n����\n3��q�\ntdϳD�;40\"�\na�^0L��r��M£��q�Q��\\*�	�\0!�W�(\Z���0��S\"�SAq�Q�d��2T?u�:����j�N�ٮ��v�#�j`n�����DS�#�y\Z�9EA�|g�a�j����w�o����z�6o��ģ�Kl9�e����iU�3�z�2,E#Ʈ�<��s%r����H��FKS�Z��I\0� ���g<�<�a\Z������j��Y�ʚ��_��D����Τ�B�7k������@\0F�H�����\"BD@��\0�-0P.^��� \n�u�Yo���p�5\0�{�k\"�Mp�&��e1���l6�j<���E�0@ߴ�O���Q��R/��i�\Z�tS���I0��p� #\0&�B���8Xj�t������3?]E	�U�G���V���V<?hoW�*�Bu�Mі�00�:���\rIP؄x������Wf�͹؎���c�G�5C]�\Z��(2��f\\�$^��@�_�z]�������U��W~[cV�t��6�H�bS���?6l�7D;`�π���%t�\Z.O������j��\'��?nd.�E��	������8T6\Z�3�\0�w��ڱ������<��Gy�|��_�r��{�Y4ݲ�j���^4�b\nH��n�Yb\"��g��R�`&�0��Od\"7^Om)���b����\r�s�˝Ǩ�g6\\��N)]]����_��%&\Z%\0����x�l�8�@1q��z�b��{i�������믶���W4T��Jc4^e������gvP�_:�Ђ�V��I�Y�7����m����<a�����9J�й��gp�`\0\n�`E?��	���2~��W���!�Q��i�(�G�,xV���z\r)��x����}@�ޮƴ��eU�R�q�J?�΋�Z����)���@qĠ8n2nr*��Pd|�c��x�T6qR�F�f�}��c�^%[�\'V����Xl�m�q�:mň-�����<��͗�%Y���P�$�ٴ��|��P�\"j��uL�8�89�k�LR3����\'��TE@Չ\\c�j��𶼏������ܼ��2�B��,]�t�R_��ڍZ��ya�c�\r0n�o���	�F��#(D��5��_.��Y��q#8&���7tq9���[�<�t\r��B7SRV��G\n�u�P�w+Hi81T���5���PE~#b\0$�M��Փ9V$�\r����dM k���X7)q*1�=�+T_7k�Qd:�G�S��-��Zߖn:��H	��r�1���{\rz�;j�b��-��X�\rFK㩫&q��1��axA�����v��D�GFk���4��\Z����6b�zM�*���}����+��-@ު�����<E�i���UW�A��0�(X�=�5��O���a~�\Z��Iwً���ըs{�ؼ�j�⸏�pP̒�m�J\0�-��r\0�q�!КyRz>����0����A�J��[���-RB�J������T��F#�w&N�/O\"�E¥�\n��\Z��r�SFYf�l;�Py�X��	��~W�a.\"�Hr-l/�)��tR��׊G\"r|@��j�\Z�C�Ǐ돛�L̋W�ر�;�k����/�^��}{�����>t��i����y�.�6��\Zu�G-zvU��վ�1�����啅�V��uN<����i�0uc����V~��آW_�З��դK�Т9�R�Q��u@���7}�k=�Ь�j�ɣ��\n1�\n��\\6(��\n0��������Fz�lUK=mٿ�,�F͚��V���νU�Yo\'-_��S$��	qXmq²��(|�:!i*q��:a2c��=)ɩJJL�2CX�PW����&\ryx��Q�T���Ԕ�!�t�O+W�	�,[����j������B!�}�`��Ӎ�K���!��%F+�,	���0�0��[#���`8�1��~�Z�\'v�9Z�5��ʩb�XAo��͑WM۴�m�dK=��W�^$=�Q|\'\r��S��C�g�.�<x�~���>����i\\_U~�Y|�#\0�q0��p2-rch�F?n��-�l���li1��,�&\n�J?�S�b�ʣ�r����\\xL��p�?��r<���p��PAi35�A숌���QH\"�D�?qT��t�RR�X�&A�ݘ�SH��v�Xh��󶖷�7VQN��Q\Z���9ާ�Ǣ���dUk�\nz�\Zʓ�����6� �\'\n��5����8߄	��㝘;�I¨�@�=����H\0F�y�Ӏ����O*Z���~�:���3W5�j��:����\r\Z�f��T�oڵ���ޅ\'�Ϳ���\Z�˟���:���������T�YS�Д�-!ҏ�:�\"���8��(�F�߰0\'M��3�\\��߭��k٩���jIjgy�X��l֖��p���8��E�)��Q�28��	�X��ǏC)	j�w��Sm���:9��}��Hq��(�ޕs�o���v�Ǡ1C�������+�\\�^��Pq�#R�||��X�h����pi1+*������hnH�z療n�ո]5��Atm��C�����5l�\Z�m�]�k����l�Q��}�Z?���U��;\n�[^�ׯ��~�Mͺ��::��w�.jM׶ow����Z8����/k�������O��s72<�Xd���[@\0���99q�G�:�7�\n&%B|��9��x���U�(��R�ʟ�]yR�����JE,��v-PB�UV�v�	t#�π!jٽq%>7\n�(�1������(�\n���x�Hm*YV�y~=G�R��#t�����L<��y{�9\"�-�\0�jF�3�ܸ/o�=��G�}<���\Z0f8�w�A��8���j�R_�\\[�U��H;���M(@�~��T��f��GSu��_����<O_�{��/Tzq�����!�V���~`�KU������F��!=���\n��Eym��O�T�Ak}�wj����l�OÛ�h�ϛ�S�VT�C���&��q���F�;+\r�Qd����Y����0\0�Wp���={�Y�v����啓��EJ�c���\0��aM�j�D�ͽ��jt[Kw�PIx�IA^��F_��D\r;vT���y��:�&��곚ą������_�C���7�ڥ�\Zv��M��a�\\\Z��.�,����/)�o��>�\n_7j��_W�;UP~^���R5�i�a����W{U�u��r��0��?W����{d����{��9\n����)�b����Gʍ����K���{�����|�|_�Q��?�_*b;��ߪH�Z�_����\n?�?(�7\rU�����qj4�ic��a�n��G�;Ap43�2�s��<�4/@� ??g�H8�+��c�:��?:w�u�X����*]VE��X�ʲB�T�˚�y��JW�Ie�t���D~�G��^�Ȓ>����`9_�ƞ��n�A�T�IEPZ���\r�%%����EJ2W�	+૫̏My,����+C\0��ȏ�P�ka<�Dy�v�����b�5�ۼ��K���$��k�J�N��e޻�s.%�m��5\Z�pU�K���������U�)��5�H��y$����~���,�{�ۆ*ǵ|��*�F���sm�a��A���n��*T�!��]�񚲵����U�7ZLvT�f��}�0�o������C�42��\'+\r���E�0��F��#}l�J(�b���|�=���F{����\'U����������Ŕ�����5z���Z�>�\"�1���atQG��!j� �W����-��2�վ� ��!�2p��������F�~���Og�l�A��l��MZ�F�V��Y�o�N���E�2ӰSo�b�@��#Լ�0��o\0���Nxa��#y#�(����/Y�\0wy���ϰ��@�iݍ�w�p\r������Vhr���{����-4����m� \no*�\0^n0����n8:�KKf\0NП�H�ч������t�,�e��\'��\'��X��϶7 @e@�����m�S�\0�y�y9�HO˗�2D�!�d2��3��(A�KzB�,�����?�?�\r$�a4� �)8���l�4��p\\� �u\'~�9g��}�wA0?�;����0�F�9�{���8�/���:��\r��j��M�����0\0��u�||7*�\rF��d��1��\"Ѳ8���p E߿�Fi0�I���ݍ �����<5��]�<����QNJ�{�qlˍF���\0{�h7��Al\0(��$\\�p�āp����q�Dnj�͛-�3�r�k��}5\Z�����1l��o>{2Z@��s�Δ9��H�K$����P�����\n2�P\"���@�0%��u�\n��r`\\u�!������k�T�c�\n����rh�y~ 	J���X�ʓss>,��y�r.�s����\Z��?���R�P�1���x�@\0�a�5�6@\0޿X�Hw�ȃ����v�����t2��k(�	2f���U �h��\0\0\0\0IEND�B`�','2014-10-15','RAY@HOT','AV NAVAL',7,'415263','992456321','PROFESOR','40494250','1234','NO HAY',1,17,3,'2014-10-15','2014-10-15',0);

UNLOCK TABLES;

/*Table structure for table `tb_vacaciones` */

DROP TABLE IF EXISTS `tb_vacaciones`;

CREATE TABLE `tb_vacaciones` (
  `DocumentoDNI` int(8) NOT NULL,
  `numeroVacaciones` int(3) DEFAULT '0',
  `vacaAsignado` int(2) DEFAULT '0',
  `periodo` text,
  PRIMARY KEY (`DocumentoDNI`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

/*Data for the table `tb_vacaciones` */

LOCK TABLES `tb_vacaciones` WRITE;

insert  into `tb_vacaciones`(`DocumentoDNI`,`numeroVacaciones`,`vacaAsignado`,`periodo`) values (4419984,0,0,'  \r'),(4828545,0,0,'  \r'),(6116962,0,0,'  \r'),(6278227,0,0,''),(41655881,0,0,''),(6297816,0,0,'  \r'),(6532908,30,4,'PERIODO 2014'),(6653459,0,0,''),(6657651,0,0,'  \r'),(7240310,0,0,'  \r'),(8053807,0,0,'  \r'),(9051193,0,0,''),(9462708,0,0,''),(9881369,0,0,'  \r'),(9914445,30,3,'PERIODO MARZO 2013 - MARZO 2014'),(10181885,0,0,''),(10298901,0,0,''),(10337864,30,1,'PERIODO MARZO 2013- MARZO 2014'),(10429052,0,0,'  \r'),(10446459,0,0,'  \r'),(10581459,0,0,'  \r'),(10660033,0,0,''),(10862003,0,0,''),(16421035,0,0,'  \r'),(18130284,30,6,'PERIODO FEBRERO 2013 - FEBRERO 2014'),(18160869,0,0,''),(20018138,0,0,'  \r'),(25076857,0,0,''),(21482518,0,0,'  \r'),(21493631,30,7,'PERIODO FEBRERO 2013 - FEBRERO 2014'),(21525483,30,17,'PERIODOP MARZO 2013 - MARZO 2014'),(23878057,134,3,'HASTA 2014'),(23800131,0,0,''),(23800488,30,21,'PERIODO MARZO 2013 - MARZO 2014'),(23801395,0,0,''),(23801500,0,0,''),(23802283,0,0,'  \r'),(23805471,0,0,''),(23807045,0,0,'  \r'),(23807048,0,0,'  \r'),(23809146,0,0,''),(23809189,0,0,'  \r'),(23809284,0,0,''),(23809916,0,0,'  \r'),(23812080,0,0,'  \r'),(23812763,0,0,''),(23814024,0,0,''),(23817170,0,0,'  \r'),(23820283,0,0,'  \r'),(23826617,0,0,''),(23821785,0,0,''),(23821811,0,0,'  \r'),(23822775,0,0,''),(23822992,0,0,'  \r'),(23823999,0,0,''),(23825114,0,0,''),(23829815,0,0,'  \r'),(23832060,0,0,''),(23833711,0,0,'  \r'),(23833930,30,2,'PERIODO FEBRERO 2013 - FEBRERO 2014'),(23834348,0,0,''),(23835080,0,0,''),(23837122,0,0,''),(23837511,30,15,'PERIODO MARZO 2013 A MARZO 2014'),(23838012,0,0,'  \r'),(23838833,0,0,'  \r'),(23839195,0,0,''),(23839304,0,0,'  \r'),(23839452,0,0,''),(23839766,0,0,''),(23933568,0,0,''),(23840170,0,0,'  \r'),(23842353,0,0,''),(23842708,30,4,'PERIODO MARZO 2013 - MARZO 2014'),(23844963,0,0,''),(23845507,0,0,'  \r'),(23846644,0,0,''),(23848291,0,0,''),(23848348,0,0,''),(23848994,0,0,''),(23849044,30,2,'PERIODO FEBRERO 2013 - FEBRERO 2014'),(23849808,0,0,''),(23849990,0,0,'  \r'),(23850050,0,0,''),(23850375,0,0,''),(23850614,0,0,''),(23851528,0,0,''),(23851575,0,0,'  \r'),(23851623,0,0,'  \r'),(23853491,30,7,'PERIODO FEBRERO 2013 - FEBRERO 2014'),(23854087,0,0,'  \r'),(23854175,0,0,'  \r'),(23855054,0,0,''),(23855085,0,0,''),(23856244,0,0,''),(23856628,0,0,'  \r'),(23856666,0,0,''),(23856695,30,10,'PERIODO MARZO 2013 - MARZO 2014'),(23856990,0,0,'  \r'),(23857379,0,0,''),(23857467,30,28,'PERIODO FEBRERO 2013 - FEBRERO 2014'),(23857536,0,0,'  \r'),(44261967,0,0,''),(23859066,0,0,'  \r'),(23859472,0,0,''),(23859550,0,0,''),(23859835,0,0,'  \r'),(23860121,0,0,''),(23860482,0,0,'  \r'),(23861067,0,0,'  \r'),(23862645,0,0,'  \r'),(23862806,30,6,'PERIODO FEBRERO DEL 2013 -FEBRERO DEL 2014'),(23863241,0,0,'  \r'),(23863372,0,0,''),(23863524,0,0,'  \r'),(23863597,0,0,''),(23863714,0,0,'  \r'),(23863905,0,0,'  \r'),(43479934,0,0,''),(23865597,0,0,''),(23867063,0,0,'  \r'),(23879698,0,0,''),(23868860,0,0,'  \r'),(23869476,0,0,'  \r'),(23870134,0,0,'  \r'),(23870182,30,2,'PERIODO MARZO 2013 - MARZO 2014'),(23870494,0,0,''),(23870870,30,30,'PERIODO ENERO 2013-ENERO 2014'),(23872152,0,0,''),(23872524,0,0,'  \r'),(23872843,0,0,'  \r'),(23873200,12,3,'PERIODO 2013'),(23873437,0,0,'  \r'),(23873492,0,0,'  \r'),(23874632,0,0,'  \r'),(23875476,0,0,''),(23875569,0,0,''),(23879794,0,0,''),(23879796,0,0,''),(23879968,0,0,'  \r'),(23880755,0,0,'  \r'),(40449752,0,0,''),(23884920,0,0,''),(23885012,30,30,'PERIODO ABRIL 2012 A ABRIL 2013'),(23885445,0,0,''),(23885575,0,0,''),(23886258,0,0,'  \r'),(23886891,0,0,''),(23889940,0,0,''),(23893382,0,0,'  \r'),(23893845,0,0,'  \r'),(23893991,0,0,''),(23894080,0,0,''),(23894100,0,0,'  \r'),(23894215,0,0,''),(23894463,0,0,''),(23897158,0,0,''),(23899167,0,0,'  \r'),(23899332,0,0,'  \r'),(23899816,30,30,'PERIODO ENERO 2013 - ENERO 2014'),(23900147,0,0,'  \r'),(23900318,0,0,''),(23900426,0,0,'  \r'),(23901191,0,0,'  \r'),(23904081,0,0,''),(23904621,0,0,'  \r'),(23906171,0,0,''),(23906917,0,0,''),(23912111,0,0,'  \r'),(23912233,0,0,''),(23912843,0,0,'  \r'),(23914072,0,0,''),(23914779,0,0,''),(23914888,0,0,''),(23916032,0,0,''),(23917811,30,20,'PERIODO MARZO 2013 - MARZO 2014'),(23917937,0,0,'  \r'),(23919961,0,0,'  \r'),(23920575,0,0,''),(23921213,0,0,''),(23921848,0,0,''),(23922625,0,0,'  \r'),(23924387,0,0,''),(23924634,0,0,''),(23925281,0,0,'  \r'),(23925366,0,0,'  \r'),(23925786,0,0,''),(23926482,0,0,'  \r'),(23926753,0,0,''),(23927126,30,7,'PERIODO FEBRERO 2013 - FEBRERO 2014'),(23928174,0,0,'  \r'),(23928834,0,0,'  \r'),(23929048,0,0,'  \r'),(23924599,0,0,''),(23929081,0,0,''),(23930057,0,0,'  \r'),(23930697,0,0,''),(23932495,0,0,''),(23932635,0,0,'  \r'),(23932642,0,0,'  \r'),(23933049,0,0,'  \r'),(23933128,0,0,'  \r'),(23934096,0,0,''),(23934148,0,0,''),(23935727,0,0,''),(23936260,0,0,''),(23936639,0,0,''),(23937531,0,0,''),(23939757,0,0,'  \r'),(23940361,0,0,''),(23940613,0,0,'  \r'),(23941435,0,0,'  \r'),(23942506,0,0,'  \r'),(23942546,0,0,''),(23942957,0,0,'  \r'),(23943349,0,0,'  \r'),(23944718,0,0,'  \r'),(23945248,0,0,'  \r'),(23948312,0,0,'  \r'),(23948502,0,0,'  \r'),(23948783,0,0,'  \r'),(23949473,0,0,'  \r'),(23950564,0,0,'  \r'),(23950646,0,0,''),(42109575,0,0,''),(23951315,0,0,''),(23951873,30,3,'  \rPERIODO 2013'),(23953114,30,2,'PERIODO MAYO 2013 - MAYO 2014'),(23953201,0,0,''),(23953354,30,1,'PERIODO FEBRERO DEL 2013 - FEBRERO DEL 2014'),(23953425,0,0,''),(23955481,0,0,''),(23956011,0,0,'  \r'),(23956100,0,0,''),(23957289,0,0,''),(23957375,0,0,'  \r'),(23957592,0,0,''),(23958541,30,1,'PERIODO MARZO 2013 - MARZO 2014'),(23959834,30,15,'PERIODO FEBRERO 2013 - FEBRERO 2014'),(23959906,0,0,'  \r'),(23960333,0,0,''),(23960905,0,0,''),(23961402,0,0,'  \r'),(23962443,30,3,'PERIODO MARZO 2013 - MARZO 2014'),(23962652,0,0,'  \r'),(23963052,30,5,'PERIODO FEBRERO 2013 - FEBRERO 2014'),(23963478,0,0,''),(23963716,0,0,''),(23964620,0,0,''),(23964865,0,7,''),(23965038,0,0,'  \r'),(23966429,0,0,''),(23966554,0,0,''),(23967129,0,0,'  \r'),(23975470,0,0,'  \r'),(23975891,0,0,''),(23975959,0,0,''),(23976776,0,0,'  \r'),(23976986,0,0,''),(23979031,0,0,''),(23979173,0,0,''),(23979710,0,0,'  \r'),(23979862,30,6,'PERIODO FEBRERO 2013-FEBRERO 2014'),(23981116,30,5,'PERIODO MAYO 2013 -  MAYO 2014'),(23981403,0,0,'  \r'),(23981481,0,0,'  \r'),(23983419,0,0,''),(23984191,0,0,''),(23984424,0,0,'  \r'),(42339070,0,0,''),(23985278,0,0,'  \r'),(23986877,0,0,'  \r'),(23987508,0,0,'  \r'),(23988433,0,0,''),(23988677,0,0,'  \r'),(23989605,0,0,'  \r'),(23989937,0,0,''),(23990485,0,0,'  \r'),(23990623,0,0,'  \r'),(23990959,0,0,''),(23991108,30,8,'PERIODO FEBRERO 2013 - FEBRERO 2014'),(23992095,0,0,''),(23878336,0,0,''),(23992949,0,0,'  \r'),(23993157,0,0,'  \r'),(23993526,0,0,''),(23993646,0,0,'  \r'),(23993841,30,8,'PERIODO MARZO 2013 - FEBRERO DEL 2014'),(23994341,0,0,'  \r'),(23994525,0,0,'  \r'),(23995068,0,0,''),(23995919,0,0,'  \r'),(23996964,0,0,''),(23998314,0,0,'  \r'),(23998517,0,0,'  \r'),(23999800,0,0,''),(23999918,0,0,'  \r'),(42418451,0,0,''),(24002518,0,0,'  \r'),(24003935,0,0,''),(24003998,0,0,'  \r'),(24004287,0,0,''),(24004667,0,0,''),(24005106,0,0,'  \r'),(24005284,0,0,''),(24005306,0,0,'  \r'),(24005328,0,0,'  \r'),(24005487,0,0,''),(24005828,0,0,'  \r'),(24006362,0,0,''),(24007216,0,0,'  \r'),(24293282,0,0,''),(24360716,0,0,''),(24362011,0,0,'  \r'),(24367534,0,0,'  \r'),(24381344,0,0,'  \r'),(24382681,0,0,''),(24389018,0,0,''),(24389023,0,0,''),(24461902,0,0,'  \r'),(24474000,0,0,'  \r'),(24485615,0,0,''),(24486579,0,0,'  \r'),(24487462,0,0,'  \r'),(24487931,0,0,''),(24489735,30,3,'PELRIODO FEBRERO 2013 - FEBRERO 2014'),(24569848,0,0,'  \r'),(24571432,0,0,''),(24668255,0,0,''),(80187057,0,0,''),(24680599,0,0,''),(24683247,0,0,''),(24706467,0,0,''),(24705625,0,0,'  \r'),(24706529,0,0,'  \r'),(24711300,0,0,'  \r'),(24712848,0,0,'  \r'),(43098387,0,0,''),(24718085,0,0,'  \r'),(24718171,0,0,'  \r'),(24719125,0,0,'  \r'),(24802976,0,0,'  \r'),(24867677,0,0,''),(24893608,0,0,'  \r'),(24944600,0,0,'  \r'),(24947699,0,0,'  \r'),(24969877,0,0,'  \r'),(24987520,0,0,'  \r'),(24991387,0,0,''),(24991496,0,0,''),(24994792,0,0,''),(41614797,0,0,''),(25000476,0,0,'  \r'),(25000575,0,0,''),(25000578,0,0,''),(25001877,30,4,'PERIODO FEBRERO DEL 2013 A FEBRERO DEL 2014'),(25002108,0,0,'  \r'),(25002271,30,15,'PERIODO MARZO 2013 - MARZO 2014'),(25003313,0,0,''),(25003592,0,0,''),(25123498,0,0,''),(25182353,0,0,'  \r'),(25182368,0,0,''),(25198801,0,0,'  \r'),(25200382,0,0,'  \r'),(25210650,0,0,''),(25304708,0,0,''),(25310609,0,0,''),(25311890,0,0,''),(25327097,0,0,''),(28225756,0,0,'  \r'),(28266101,0,0,'  \r'),(29273550,0,0,'  \r'),(29419271,0,0,''),(29426388,0,0,'  \r'),(29802324,0,0,''),(31024707,0,0,''),(42152799,0,0,''),(31045391,0,0,'  \r'),(40062893,0,0,''),(40067774,0,0,'  \r'),(40069045,0,0,'  \r'),(40085278,0,0,''),(40105057,0,0,''),(40117609,0,0,'  \r'),(40130403,0,0,'  \r'),(40135998,0,0,''),(40139585,0,0,''),(40271128,0,0,'  \r'),(40281249,0,0,'  \r'),(40326499,0,0,''),(40335500,0,0,'  \r'),(40376984,0,0,'  \r'),(23951659,0,0,''),(40394328,0,0,'  \r'),(40398149,0,0,'  \r'),(40416158,0,0,'  \r'),(40429086,0,0,''),(40431624,0,0,'  \r'),(40431873,0,0,'  \r'),(40444653,0,0,'  \r'),(40447243,0,0,''),(40448617,0,0,'  \r'),(40448629,30,2,'PERIODO FEBRERO 2013 - FEBRERO 2014'),(40467677,0,0,'  \r'),(40500877,0,0,''),(40519915,0,0,'  \r'),(40536077,0,0,'  \r'),(40562204,0,0,''),(40591696,52,7,'PERIODO ABRIL 2012 A ABRIL 2013, ABRIL 2014'),(40624224,0,0,'  \r'),(40662607,0,0,'  \r'),(40695540,0,0,'  \r'),(40715748,0,0,''),(40728170,0,0,'  \r'),(40736088,0,0,''),(40744756,0,0,'  \r'),(40773038,0,0,''),(40773637,0,0,'  \r'),(40813246,0,0,'  \r'),(40822252,0,0,''),(40824974,0,0,'  \r'),(40875887,0,0,''),(40876488,0,0,''),(40880978,0,0,''),(23856153,0,0,''),(40899251,0,0,'  \r'),(41715079,0,0,''),(40910084,0,0,''),(40931699,0,0,'  \r'),(40939798,30,4,'PERIODO FEBRERO 2013 - FEBRERO 2014'),(40952413,0,0,'  \r'),(40969380,0,0,''),(40975093,0,0,'  \r'),(41053977,0,0,''),(41107088,0,0,''),(41107103,0,0,'  \r'),(41108525,0,0,''),(41112489,0,0,''),(41119178,0,0,'  \r'),(41125241,0,0,''),(41129986,0,0,''),(41134571,0,0,''),(41139026,0,0,'  \r'),(41153489,0,0,''),(41154631,0,0,'  \r'),(41157398,0,0,'  \r'),(45430985,0,0,''),(41158850,0,0,'  \r'),(41160584,0,0,''),(41178911,0,0,'  \r'),(41230182,0,0,''),(41253433,0,0,''),(41266089,0,0,''),(41346216,0,0,''),(41374815,0,0,'  \r'),(41400140,0,0,'  \r'),(41407885,0,0,''),(41441595,0,0,''),(41447660,0,0,'  \r'),(41555209,0,0,'  \r'),(41556313,0,0,''),(45073834,0,0,''),(44775000,0,0,''),(41596776,0,0,''),(41626705,30,2,'PERIODO ENERO 2013 - FEBRERO 2014'),(41655522,30,22,'PERIODO MARZO 2013 - MARZO 2014'),(41659380,0,0,'  \r'),(41703486,0,0,'  \r'),(41737113,0,0,'  \r'),(41746442,0,0,'  \r'),(41755802,0,0,''),(41774812,0,0,''),(41805881,0,0,'  \r'),(41818966,0,0,'  \r'),(41833740,0,0,'  \r'),(41839955,0,0,''),(41848253,0,0,'  \r'),(41848464,0,0,'  \r'),(41892681,0,0,''),(41900763,0,0,'  \r'),(41929708,0,0,'  \r'),(41962222,0,0,'  \r'),(41972471,0,0,''),(41978152,0,0,'  \r'),(41997069,0,0,''),(42044551,0,0,''),(42055572,0,0,''),(42155935,0,0,''),(42162355,0,0,'  \r'),(42169218,0,0,'  \r'),(42172701,30,4,'PERIODO FEBRERO 2013- FEBRERO 2014'),(42246849,0,0,''),(42257499,30,1,'  \rPERIODO 2013'),(42266292,0,0,'  \r'),(42268578,0,0,'  \r'),(42279175,0,0,'  \r'),(42316871,0,0,'  \r'),(42319761,0,0,''),(42326176,0,0,'  \r'),(42329767,0,0,''),(42340684,0,0,'  \r'),(42352136,0,0,'  \r'),(42386687,0,0,'  \r'),(42404455,0,0,''),(42561556,0,0,'  \r'),(42563846,0,0,'  \r'),(42586246,0,0,''),(42617932,0,0,'  \r'),(42699722,0,0,'  \r'),(42700054,0,0,'  \r'),(42708755,0,0,'  \r'),(42839707,0,0,'  \r'),(42962461,0,0,''),(42990357,0,0,'  \r'),(43001254,30,7,'PERIODO FEBRERO 2013 - FEBRERO 2014'),(43066411,30,7,'PERIODO FEBRERO 2013 - FEBRERO 2014'),(43068560,0,0,''),(43076569,0,0,'  \r'),(43081298,0,0,'  \r'),(43165165,0,0,'  \r'),(43199483,0,0,'  \r'),(43206589,0,0,'  \r'),(43371391,0,0,''),(43376395,0,0,'  \r'),(43420602,0,0,''),(43460993,0,0,'  \r'),(43464494,0,0,''),(43556526,0,0,'  \r'),(43556537,0,0,'  \r'),(43575685,0,0,'  \r'),(43700848,0,0,''),(23920861,0,0,''),(43899141,0,0,'  \r'),(43990456,0,0,'  \r'),(44137987,0,0,'  \r'),(44151319,0,0,'  \r'),(44159824,0,0,'  \r'),(23867830,0,0,''),(44254412,0,0,''),(44261190,0,0,'  \r'),(44283464,0,0,'  \r'),(44377601,0,0,''),(44394207,0,0,'  \r'),(44414416,0,0,''),(44434172,0,0,''),(44463683,0,2,''),(23943964,0,0,''),(44607400,0,0,''),(44706978,0,0,''),(44773977,0,0,'  \r'),(44783968,0,0,''),(40065151,0,0,''),(44853226,0,0,''),(44858334,0,0,'  \r'),(44915833,0,0,'  \r'),(24004863,0,0,''),(45026845,0,0,'  \r'),(45112960,0,0,''),(45260928,0,0,''),(45381628,0,0,''),(45472600,0,0,''),(45547865,0,0,'  \r'),(45597650,0,0,''),(45647210,0,0,''),(45647228,30,15,'PERIODO ENERO 2013 - ENERO 2014'),(45856758,0,0,''),(45873938,0,0,'  \r'),(45880577,0,0,'  \r'),(45963802,0,0,''),(46027895,0,0,''),(46064527,0,0,'  \r'),(46116086,0,0,'  \r'),(46119429,0,0,'  \r'),(46172398,0,0,'  \r'),(46306701,0,0,''),(46319836,0,0,''),(46356145,0,0,'  \r'),(46393989,0,0,''),(46600148,0,0,''),(46616552,0,0,''),(47032505,0,0,''),(47151664,0,0,'  \r'),(47189981,0,0,'  \r'),(47404645,30,2,'PERIODO MARZO 2013 - MARZO 2014'),(47817197,0,0,'  \r'),(48543507,0,0,'  \r'),(71330030,0,0,''),(72238881,0,0,'  \r'),(72541160,0,0,''),(80101484,0,0,'  \r'),(80168162,0,0,''),(80175543,0,0,'  \r'),(80630511,0,0,'  \r'),(23880331,0,0,''),(20076341,0,0,''),(40089682,0,0,''),(23985401,0,0,''),(23943018,0,0,''),(24003726,0,0,''),(23829448,0,0,''),(40803578,0,0,''),(23845958,0,0,''),(24487942,0,0,''),(40672071,0,0,''),(40026870,0,0,''),(42713949,0,0,''),(40720799,0,0,''),(23936679,0,0,''),(23989969,0,0,''),(31043438,0,0,''),(23978429,0,0,''),(24677678,0,0,''),(23931157,0,0,''),(43932196,0,0,''),(23870954,0,0,''),(47541224,0,0,''),(23974915,0,0,''),(40119336,0,0,''),(23880228,0,0,''),(23884420,0,0,''),(23949981,0,0,''),(44455120,0,0,''),(23952293,0,0,''),(41158845,0,0,''),(25001815,0,0,''),(45525206,0,0,''),(41834758,0,0,''),(44441297,0,0,''),(23979788,0,0,''),(42369620,0,0,''),(45326006,0,0,''),(41397791,0,0,''),(23930755,0,0,''),(24461379,0,0,''),(23954659,0,0,''),(24000154,0,0,''),(42025212,0,0,''),(41608491,0,0,''),(43224761,0,0,''),(44023841,0,0,''),(23908489,0,0,''),(41158882,0,0,''),(23845416,0,0,''),(45067407,0,0,''),(40805856,0,0,''),(23886854,0,0,''),(45041082,0,0,''),(23856066,0,0,''),(43925255,0,0,''),(23846028,0,0,''),(23979115,0,0,''),(23890047,0,0,''),(23947640,0,0,''),(24970709,0,0,''),(23846851,0,0,''),(40213980,0,0,''),(23945012,0,0,''),(23806217,151,0,'PERIODO ACUMULADO DE AÑOS PASADOS'),(23869318,0,0,''),(44174700,0,0,''),(46137182,0,0,''),(23837340,30,11,'PERIODO MARZO 2013 A MARZO DEL 2014'),(23977649,0,0,''),(45078022,0,0,''),(23979343,0,0,''),(23830014,0,0,''),(23863654,0,0,''),(40480847,0,0,''),(23810953,0,0,''),(23845765,0,0,''),(25000633,0,0,''),(23958834,0,0,''),(6804598,0,0,''),(42622739,0,0,''),(23920269,0,0,''),(40706313,30,15,'PERIODO FEBRERO 2013 - FEBRERO 2014'),(23849143,0,0,''),(23872834,0,0,''),(25000447,0,0,''),(23860250,0,0,''),(44858339,0,0,''),(23975777,0,0,''),(23862321,0,0,''),(23979923,0,0,''),(42821783,0,0,''),(41605507,0,0,''),(42721866,0,0,''),(23922390,0,0,''),(23833799,0,0,''),(41053936,0,0,''),(23827704,0,0,''),(44373864,0,0,''),(23850926,0,0,''),(45918490,0,0,''),(23918058,0,0,''),(23919212,0,0,''),(24981017,0,0,''),(44730967,0,0,''),(23811154,0,0,''),(44082269,0,0,''),(42451718,0,0,''),(40148385,0,0,''),(23938389,0,0,''),(23929959,0,0,''),(23937989,0,0,''),(23873104,0,0,''),(24000700,0,0,''),(23886743,0,0,''),(23929647,0,0,''),(41655489,0,0,''),(41841956,0,0,''),(42842615,0,0,''),(23917795,0,0,''),(44010840,0,0,''),(41524292,0,0,''),(23863792,0,0,''),(23922386,0,0,''),(44362909,0,0,''),(23957934,0,0,''),(23946116,0,0,''),(23882221,0,0,''),(23858394,0,0,''),(23828756,0,0,''),(40359718,0,0,''),(23891830,0,0,''),(23947125,0,0,''),(31039247,0,0,''),(23843416,0,0,''),(23857134,0,0,''),(23929061,0,0,''),(23954143,0,0,''),(23833790,0,0,''),(25183555,0,0,''),(24712971,0,0,''),(515557,0,0,''),(23864618,0,0,''),(23884955,0,0,''),(2365417,0,0,''),(41718916,0,0,''),(43157424,0,0,''),(40429084,0,0,''),(25000324,0,0,''),(23842944,259,2,'2014'),(23863585,0,0,''),(40155948,0,0,''),(41655856,0,0,''),(41285850,0,0,''),(41785041,0,0,''),(23834075,0,0,''),(43657317,0,0,''),(40757754,0,0,''),(23835066,0,0,''),(46081755,0,0,''),(24005691,0,0,''),(45156437,0,0,''),(23811862,0,0,''),(40739751,0,0,''),(23894332,0,0,''),(43648338,0,0,''),(25138944,0,0,''),(45636005,0,0,''),(43872818,0,0,''),(24005516,0,0,''),(23894820,0,0,''),(40341799,0,0,''),(40705272,0,0,''),(47018112,0,0,''),(23884652,0,0,''),(40238131,0,0,''),(41659364,0,0,''),(23876504,0,0,''),(24719072,0,0,''),(40902287,0,0,''),(40291457,0,0,''),(80668196,0,0,''),(45531623,0,0,''),(46024827,0,0,''),(40411794,0,0,''),(42140802,0,0,''),(41994825,0,0,''),(45504652,0,0,''),(43099809,0,0,''),(41655896,0,0,''),(40250111,0,0,''),(46397715,0,0,''),(41732162,0,0,''),(41053932,30,17,'PERIODO ENERO 2013- ENERO 2014'),(40775890,0,0,''),(105912,30,1,'PERIODO ENEO 2012 - ENERO 2013'),(9611010,0,0,''),(25074107,0,0,''),(23933974,0,0,''),(23856415,0,0,''),(44812108,0,0,''),(42527810,0,0,''),(44174692,0,0,''),(23996128,145,1,'HASTA MAYO 2014'),(42234635,0,0,''),(24000662,0,0,''),(46461601,0,0,''),(80029948,0,0,''),(42497818,0,0,''),(23934193,0,0,''),(23950633,0,0,''),(46589702,0,0,''),(23828341,0,0,''),(40697267,0,0,''),(40033248,0,0,''),(23846172,0,0,''),(41490073,0,0,''),(44602152,0,0,''),(40335528,0,0,''),(23856883,0,0,''),(41154634,0,0,''),(23880635,0,0,''),(40260816,0,0,''),(42318041,0,0,''),(42334618,0,0,''),(41152096,0,0,''),(43612754,0,0,''),(44975687,0,0,''),(42386649,0,0,''),(23998684,0,0,''),(45079834,0,0,''),(43070495,0,0,''),(42851352,0,0,''),(42924288,0,0,''),(43924452,0,0,''),(45386696,0,0,''),(40234953,0,0,''),(43099822,0,0,''),(46283541,0,0,''),(44417100,0,0,''),(40708011,0,0,''),(23954544,0,0,''),(40822248,0,0,''),(23999852,0,0,''),(46697749,0,0,''),(44887101,0,0,''),(24865193,0,0,''),(45239734,0,0,''),(42109372,0,0,''),(42130283,0,0,''),(43065558,0,0,''),(46309995,0,0,''),(42480322,0,0,''),(29689235,0,0,''),(42988511,0,0,''),(46357121,0,0,''),(40377844,0,0,''),(42723935,0,0,''),(44826929,0,0,''),(40744737,0,0,''),(40389201,0,0,''),(43774943,0,0,''),(23880695,0,0,''),(23868169,0,0,''),(23916638,0,0,''),(40494250,0,0,''),(45426041,0,0,''),(23942802,0,0,''),(23929291,0,0,''),(25003203,0,0,''),(46957119,0,0,''),(47090000,0,0,''),(70577292,0,0,''),(43744646,0,0,''),(23975383,0,0,''),(45913756,0,0,''),(40164682,0,0,''),(24495417,0,0,''),(23860560,0,0,''),(23843044,0,0,''),(23826766,0,0,''),(24484140,0,0,''),(23811389,0,0,''),(42927158,0,0,''),(40270876,0,0,''),(23929546,0,0,''),(23817252,0,0,''),(23879352,0,0,''),(24660325,0,0,''),(42766935,0,0,''),(23995548,0,0,''),(23901417,0,0,''),(23872250,0,0,''),(24001413,0,0,''),(4749301,0,0,''),(41597031,0,0,''),(80034579,0,0,''),(23823493,0,0,''),(24462788,0,0,''),(41955626,0,0,''),(23901038,0,0,''),(23892102,0,0,''),(23854460,0,0,''),(23952971,0,0,''),(23991864,0,0,''),(23975226,0,0,''),(24462651,0,0,''),(42140822,0,0,''),(23872169,0,0,''),(40882256,0,0,''),(23832718,0,0,''),(40470816,0,0,''),(40421253,0,0,''),(46606327,0,0,''),(1287433,0,0,''),(23990323,0,0,''),(23963725,0,0,''),(6441384,0,0,''),(41657289,0,0,''),(40255548,0,0,''),(23975341,22,8,'PERIODO MARZO 2013 - MARZO 2014'),(23839815,0,0,''),(42200992,0,0,''),(43812777,0,0,''),(23999566,30,7,'PERIODO FEBRERO 2013 - FEBRERO 2014'),(43099826,0,0,''),(23844969,46,3,'HASTA 2014'),(42924474,0,0,''),(24586020,0,0,''),(45830355,0,0,''),(24967520,0,0,''),(45859589,0,0,''),(46989136,0,0,''),(41125231,0,0,''),(24389598,0,0,''),(42310075,0,0,''),(43774936,0,0,''),(40084069,0,0,''),(42920752,0,0,''),(47171618,0,0,''),(23836452,0,0,''),(40211461,0,0,''),(25131378,0,0,''),(23900305,0,0,''),(40890070,0,0,''),(42306693,0,0,''),(44944167,0,0,''),(45559232,0,0,''),(24002170,0,0,''),(23902319,0,0,''),(23830036,0,0,''),(23862748,0,0,''),(1326953,0,0,''),(23929320,0,0,''),(4820910,0,0,''),(23871142,0,0,''),(43058746,0,0,''),(23947981,0,0,''),(23836501,54,1,'HASTA 2014'),(23884057,90,7,'HASTA EL 2014'),(23881867,45,1,'HASTA EL 2014'),(23885473,56,2,'HASTA EL 2014'),(23879890,61,4,'HASTA EL 2014'),(23874607,82,12,'HASTA -2014'),(23871757,40,31,'HASTA MAYO 2014'),(24711036,214,1,'HASTA 2014'),(54789655,0,0,''),(31041193,16,2,'HASTA -2014'),(23957602,0,0,''),(46616454,0,0,''),(23801186,0,0,''),(41008983,0,0,''),(23818014,57,1,'HASTA EL 2014'),(23825387,158,15,'HASTA EL 2014'),(23924986,0,0,''),(23915377,0,0,''),(23811855,0,0,''),(23817816,10,1,'HASTA MAYO 2014*'),(23868102,0,0,''),(23813613,273,1,'HASTA MAYO 2014'),(23914527,54,3,'HASTA MAYO 2014'),(29391879,0,0,''),(23826802,0,0,''),(23891560,0,0,''),(23843901,0,0,''),(23845335,48,5,'HASTA MAYO 2014'),(25008775,0,0,''),(23888456,0,0,''),(23845532,0,0,''),(23840427,0,0,''),(24862629,92,1,'HASTA MAYO 2014'),(23836392,0,0,''),(23882129,0,0,''),(23873435,0,0,''),(23814095,0,0,''),(23875228,0,0,''),(23910822,0,0,''),(23831976,0,0,''),(23880550,0,0,''),(23827930,109,30,'HASTA MAYO 2014'),(9308755,0,0,''),(23873850,199,2,'HASTA MAYO 2014'),(23879697,0,0,''),(23875360,0,0,''),(23851334,0,0,''),(23923564,45,10,'HASTA MAYO 2014'),(23860612,7,1,'HASTA MAYO 2014'),(23871175,11,5,'HASTA MAYO 2014'),(24377202,175,1,'HASTA MAYO DEL 2014'),(23817995,0,0,''),(23883367,0,0,''),(23841547,0,0,''),(23902017,0,0,''),(23805947,0,0,''),(23846278,212,0,'HASTA MAYO 2014'),(23839590,9,1,'HASTA MAYO DEL 2014'),(23872251,0,0,''),(23905603,0,0,''),(23924055,0,0,''),(23812530,0,0,''),(23878021,324,7,'HASTA MAYO 2014'),(23885471,315,1,'HASTA MAYO 2014'),(23800632,0,0,''),(23817223,0,0,''),(23825067,21,1,'HASTA MAYO 2014'),(23839577,0,0,''),(23983710,0,0,''),(23829140,0,0,''),(23876814,0,0,''),(23824344,0,0,''),(23823545,0,0,''),(23843063,0,0,''),(23882387,0,0,''),(23815234,0,0,''),(23886001,0,0,''),(23858276,0,0,''),(23881617,0,0,''),(25121027,227,7,'HASTA MAYO 2014'),(23819740,95,2,'HASTA MAYO 2014'),(25180003,192,5,'HASTA MAYO 2014'),(24468229,0,0,''),(23904660,262,30,'HASTA MAYO 2014'),(23804863,130,1,'HASTA MAYO 2014'),(23913122,0,0,''),(23873586,0,0,''),(23900485,154,1,'HASTA MAYO 2014*'),(23868214,0,0,''),(23892351,0,0,''),(23890238,0,0,''),(23818497,0,0,''),(23843720,411,5,'HASTA MAYO 2014'),(23956820,0,0,''),(23874680,31,1,'HASTA JUNIO 2014'),(23837373,0,0,''),(23827396,0,0,''),(23907641,186,1,'HASTA JUNIO 2014'),(23875527,0,0,''),(23875050,53,1,'HASTA MAYO 2014'),(23833677,0,0,''),(23836515,0,0,''),(23800695,0,0,''),(23885660,36,1,'HASTA MES DE MAYO 2014'),(24670414,61,1,'HASTA MAYO 2014*'),(23800164,0,0,''),(23923465,0,0,''),(24280800,0,0,''),(23883002,0,0,''),(23814088,0,0,''),(23923235,0,0,''),(23878754,0,0,''),(23802153,0,0,''),(23951720,0,0,''),(23915799,0,0,''),(23809168,115,1,'HASTA MAYO 2014*'),(23914027,0,0,''),(23883213,0,0,''),(7188982,0,0,''),(23881471,0,0,''),(23873338,0,0,''),(23995106,0,0,''),(23879544,0,0,''),(23912098,132,30,'HASTA MAYO 2014'),(23839829,0,0,''),(23828694,0,0,''),(24003255,62,1,'HASTA MAYO 2014'),(23876796,0,0,''),(23910391,0,0,''),(23867749,140,1,'HASTA MAYO 2014*'),(23823667,0,0,''),(23848121,0,0,''),(23883592,0,0,''),(23875839,22,2,'HASTA MAYO 2014'),(23853612,0,0,''),(23848486,0,0,''),(23805316,0,0,''),(23887108,0,0,''),(23868117,0,0,''),(23982280,20,1,'HASTA MAYO 2014'),(23985756,0,0,''),(23867678,26,1,'HASTA MAYO 2014'),(23910299,125,1,'HASTA MAYO 2014*'),(23840794,0,0,''),(23884227,0,0,''),(23829549,0,0,''),(24361016,140,10,'HASTA MAYO 2014'),(23847068,0,0,''),(23822390,59,2,'HASTA MAYO 2014*'),(23878656,0,0,''),(24282055,0,0,''),(25184490,0,0,''),(23905918,36,15,'HASTA MAYO 2014'),(23878938,0,0,''),(31018184,26,7,'HASTA MAYO 2014'),(23849603,0,0,''),(23814801,5,1,'HASTA MAYO 2014*'),(23919268,61,10,'HASTA MAYO 2014'),(23870318,0,0,''),(23965476,247,1,'HASTA MAYO 2014'),(23853520,0,0,''),(23872037,0,0,''),(23872775,0,0,''),(23804922,0,0,''),(23821092,0,0,''),(23810902,0,0,''),(29281954,67,4,'HASTA MAYO 2014'),(43938937,0,0,''),(23853853,0,0,''),(23651064,0,0,''),(23951452,0,0,''),(41676043,0,0,''),(24813923,0,0,''),(23820557,0,0,''),(23940358,10,10,'HASTA MAYO 2014'),(46640101,0,0,''),(23993114,123,1,'HASTA EL 2014'),(23840199,58,30,'HASTA MAYO 2014'),(23985737,30,8,'PERIODO ABRIL 2013 - ABRIL 2014'),(23824650,114,8,'HASTA MAYO 2014'),(23806220,49,3,'HASTA MAYO 2014'),(23885345,30,4,'HASTA MAYO 2014'),(42405663,0,0,''),(24895309,0,0,''),(44595031,0,0,''),(46757719,0,0,''),(45807139,0,0,''),(41421422,0,0,''),(24382594,0,0,''),(41884366,0,0,''),(1320661,0,0,''),(23865805,0,0,''),(23959409,0,0,''),(45156445,0,0,''),(23879753,0,0,''),(40022237,0,0,''),(43488768,0,0,''),(43081540,0,0,''),(23840333,0,0,''),(42140815,0,0,''),(48021315,0,0,''),(23930518,0,0,''),(31020205,0,0,''),(24462468,0,0,''),(23936753,0,0,''),(24287251,0,0,''),(42130163,0,0,''),(1842029,0,0,''),(23921918,0,0,''),(23855104,0,0,''),(23985013,0,0,''),(23859199,0,0,''),(31302146,0,0,''),(4742135,0,0,''),(23965893,0,0,''),(23849494,0,0,''),(23810498,0,0,''),(44936314,0,0,''),(23981341,0,0,''),(48186151,0,0,''),(45848252,0,0,''),(23950629,0,0,''),(9685531,0,0,''),(40811367,0,0,''),(23982454,0,0,''),(40567499,0,0,''),(41818181,0,0,''),(44780128,0,0,''),(41756734,0,0,''),(23999177,0,0,''),(23815576,0,0,''),(23976612,0,0,''),(23860168,0,0,''),(41662799,0,0,''),(23850554,0,0,''),(23925540,0,0,''),(23996332,0,0,''),(43525768,0,0,''),(44739540,0,0,''),(23945079,0,0,''),(40766317,0,0,''),(23810595,0,0,''),(25311772,0,0,''),(40613713,0,0,''),(2365269,0,0,''),(44227979,0,0,''),(46497497,0,0,''),(43395868,0,0,''),(80089281,0,0,''),(23837437,0,0,''),(23854960,0,0,''),(40722690,0,0,''),(40994220,0,0,''),(23989928,0,0,''),(23933084,0,0,''),(40247746,0,0,''),(23894635,0,0,''),(40509395,0,0,''),(41492881,0,0,''),(8266480,0,0,''),(23990659,0,0,''),(42305575,0,0,''),(40461491,0,0,''),(43822355,0,0,''),(41785199,0,0,''),(41424486,0,0,''),(40968406,0,0,''),(41156052,0,0,''),(24462650,113,1,'HASTA MAYO 2014'),(23833027,0,0,''),(31037418,0,0,''),(44164208,0,0,''),(23801454,0,0,''),(23818880,0,0,''),(23851971,0,0,''),(70032190,0,0,''),(23868484,0,0,''),(45564477,0,0,''),(42936752,0,0,''),(43248148,0,0,''),(23865467,0,0,''),(23851795,0,0,''),(23999621,0,0,''),(23925060,30,0,'SOLO PERIODO 2014 PUAES VINO DE INDECI'),(23974790,0,0,'');

UNLOCK TABLES;

/* Procedure structure for procedure `nuevo_VerificarUsuario` */

/*!50003 DROP PROCEDURE IF EXISTS  `nuevo_VerificarUsuario` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `nuevo_VerificarUsuario`(pIdUsuario CHAR(20),pPassword CHAR(20))
BEGIN
    
    
    SELECT idArea,privilegio,Administrador
    FROM taadm_administrador
    WHERE Administrador = pIdUsuario AND (pPassword=Contrasenia OR pPassword=NuevaClave);        
    END */$$
DELIMITER ;

/* Procedure structure for procedure `spuadm_CorreoAdministrador` */

/*!50003 DROP PROCEDURE IF EXISTS  `spuadm_CorreoAdministrador` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `spuadm_CorreoAdministrador`()
BEGIN
    
    declare pAdmin char(20);
    declare pClave char(20);
    declare pMail char(255);
    declare pNueva char(10);
    
    select Administrador,Contrasenia,Correo,Contrasenia 
    into pAdmin,pClave,pMail,pNueva
    from taadm_administrador limit 1;
    
    update taadm_administrador	 set NuevaClave = pNueva
    where Administrador = pAdmin;
    
    select pAdmin as 'ADMIN',pNueva as 'CLAVE',pMail as 'CORREO';
    
    
    END */$$
DELIMITER ;

/* Procedure structure for procedure `spuadm_VerificarAdministrador` */

/*!50003 DROP PROCEDURE IF EXISTS  `spuadm_VerificarAdministrador` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `spuadm_VerificarAdministrador`(pIdUsuario char(20),pPassword char(20))
BEGIN
    
    declare pContador int(4);
    Declare Mensaje char(10);
    
    select count(*) into pContador
    from taadm_administrador
    where Administrador = pIdUsuario and (pPassword=Contrasenia or pPassword=NuevaClave);
    
    Set Mensaje = 'false';
    if(pContador>0)
    then
	set Mensaje = 'true';	
    end if;
    
    select Mensaje;
    END */$$
DELIMITER ;

/* Procedure structure for procedure `spuGeo_ListarAgencias` */

/*!50003 DROP PROCEDURE IF EXISTS  `spuGeo_ListarAgencias` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `spuGeo_ListarAgencias`()
BEGIN
    
    SELECT IdAgencia AS 'VALUE MEMBER',NombreAgencia AS 'DISPLAY MEMBER'
    from taofi_agencias
    ORDER BY NombreAgencia;
    END */$$
DELIMITER ;

/* Procedure structure for procedure `spuGeo_ListarAreas` */

/*!50003 DROP PROCEDURE IF EXISTS  `spuGeo_ListarAreas` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `spuGeo_ListarAreas`()
BEGIN
    
    SELECT IdArea AS 'VALUE MEMBER',NombreArea AS 'DISPLAY MEMBER'
    from taofi_areas
    ORDER BY NombreArea;
    END */$$
DELIMITER ;

/* Procedure structure for procedure `spuGeo_ListarDistritos` */

/*!50003 DROP PROCEDURE IF EXISTS  `spuGeo_ListarDistritos` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `spuGeo_ListarDistritos`(pIdProvincia char(10))
BEGIN
    
    SELECT IdDistrito AS 'VALUE MEMBER',NombreDistrito AS 'DISPLAY MEMBER'
    from tageo_distritos
    where IdProvincia = pIdProvincia
    ORDER BY NombreDistrito;
    END */$$
DELIMITER ;

/* Procedure structure for procedure `spuGeo_ListarModalidades` */

/*!50003 DROP PROCEDURE IF EXISTS  `spuGeo_ListarModalidades` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `spuGeo_ListarModalidades`()
BEGIN
    
    SELECT IdModalidad AS 'VALUE MEMBER',Modalidad AS 'DISPLAY MEMBER'
    from taper_modalidadcontrato
    ORDER BY IdModalidad ASC;
    END */$$
DELIMITER ;

/* Procedure structure for procedure `spuGeo_ListarProvincias` */

/*!50003 DROP PROCEDURE IF EXISTS  `spuGeo_ListarProvincias` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `spuGeo_ListarProvincias`()
BEGIN
    
    SELECT P.IdProvincia as 'VALUE MEMBER',CONCAT(D.NombreDepartamento,' - ',P.NombreProvincia) as 'DISPLAY MEMBER'
    FROM tageo_departamentos D INNER JOIN tageo_provincias P
    ON (P.IdDepartamento = D.IdDepartamento)
    ORDER BY D.NombreDepartamento,P.NombreProvincia;
    END */$$
DELIMITER ;

/* Procedure structure for procedure `spuhor_ListarTurnosExistentes` */

/*!50003 DROP PROCEDURE IF EXISTS  `spuhor_ListarTurnosExistentes` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `spuhor_ListarTurnosExistentes`()
BEGIN
    
    SELECT IdTurno as 'VALUE MEMBER',NombreTurno as 'DISPLAY MEMBER',Nomenclatura,Detalles
    from tahor_turnos
    GROUP BY IdTurno
    ORDER BY IdTurno;
    END */$$
DELIMITER ;

/* Procedure structure for procedure `spupri_BuscarPersona` */

/*!50003 DROP PROCEDURE IF EXISTS  `spupri_BuscarPersona` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `spupri_BuscarPersona`(pDocumentoDNI int(8))
BEGIN
    
    SELECT 
    P.DocumentoDNI,
    P.Nombres,
    P.Paterno,
    P.Materno,
    P.Sexo,
    P.Foto,
    day(p.FechaNacimiento) as 'DIANAC',
    MONTH(p.FechaNacimiento) AS 'MESNAC',
    YEAR(p.FechaNacimiento) AS 'ANIOANAC',
    P.Email,
    P.Direccion,
    D.IdProvincia,
    P.IdDistrito,
    P.Telefono,
    P.Celular,
    P.Ocupacion,
    P.Usuario,
    P.Contrasenia,
    p.IdCodPersonaEmpresa,
    p.IdAgencia,
    p.IdArea,
    p.IdModalidad,
    DAY(p.FechaInicio) AS 'DIAINIC',
    MONTH(p.FechaInicio) AS 'MESINIC',
    YEAR(p.FechaInicio) AS 'ANIOINIC',
    DAY(p.FechaFin) AS 'DIAFIN',
    MONTH(p.FechaFin) AS 'MESFIN',
    YEAR(p.FechaFin) AS 'ANIOFIN',
    p.EnableSINO
    from tapri_persona P inner join tageo_distritos D     
    on P.IdDistrito = D.IdDistrito
    where DocumentoDNI = pDocumentoDNI;
    END */$$
DELIMITER ;

/* Procedure structure for procedure `spupri_BuscarPersonal_Filtro` */

/*!50003 DROP PROCEDURE IF EXISTS  `spupri_BuscarPersonal_Filtro` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `spupri_BuscarPersonal_Filtro`(pFiltro varchar(300))
BEGIN
    
    SELECT DocumentoDNI, CAST(CONCAT(Paterno,' ',Materno,' ',Nombres) AS CHAR(300))    
    FROM tapri_persona
    WHERE DocumentoDNI LIKE CONCAT('%',pFiltro,'%') OR Nombres LIKE CONCAT('%',pFiltro,'%') 
    OR Paterno LIKE CONCAT('%',pFiltro,'%') OR Materno LIKE CONCAT('%',pFiltro,'%')
    
    ORDER BY Paterno;
    
    
    END */$$
DELIMITER ;

/* Procedure structure for procedure `spuPri_GuardarDatosPersonal` */

/*!50003 DROP PROCEDURE IF EXISTS  `spuPri_GuardarDatosPersonal` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `spuPri_GuardarDatosPersonal`(pDocumentoDNI int(8), pNombres char(100),
						     pPaterno char(100),pMaterno char(100),pSexo char(1),
						     pFoto blob,pFechaNacimiento date,pEmail char(200),pDireccion char(200),
						     pIdDistrito int(10),pTelefono char(35),
						     pCelular char(35),pOcupacion char(180),pUsuario char(30),pContrasenia char(30),
						     pIdCodPersonaEmpresa char(10), pIdAgencia int(10), pIdArea int(10), pIdModalidad int(10),
						     pFechaInicio date, pFechaFin date, pEnableSINO int(1))
BEGIN
    
	replace into tapri_persona values(pDocumentoDNI,pNombres,pPaterno,pMaterno,pSexo,pFoto,pFechaNacimiento,pEmail,
	pDireccion,pIdDistrito,pTelefono,pCelular,pOcupacion,pUsuario,pContrasenia,pIdCodPersonaEmpresa,pIdAgencia,pIdArea,
	pIdModalidad,pFechaInicio,pFechaFin,pEnableSINO	);
    
    END */$$
DELIMITER ;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
