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

insert  into `tageo_departamentos`(`IdDepartamento`,`IdPais`,`NombreDepartamento`) values (1,1,'AREQUIPA'),(2,1,'CUSCO'),(3,1,'PUNO'),(4,1,'AMAZONAS'),(5,1,'ANCASH'),(6,1,'APURÃMAC'),(7,1,'AYACUCHO'),(8,1,'CAJAMARCA'),(9,1,'HUANCAVELICA'),(10,1,'HUÃNUCO'),(11,1,'ICA'),(12,1,'JUNÃN'),(13,1,'LA LIBERTAD'),(14,1,'LAMBAYEQUE'),(15,1,'LIMA/CALLAO'),(16,1,'LORETO'),(17,1,'MADRE DE DIOS'),(18,1,'MOQUEGUA'),(19,1,'PASCO'),(20,1,'PIURA'),(21,1,'SAN MARTÃN'),(22,1,'TACNA'),(23,1,'TUMBES'),(24,1,'UCAYALI');

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

insert  into `tageo_distritos`(`IdDistrito`,`IdProvincia`,`NombreDistrito`) values (1,1,'JOSE LUIS BUSTAMANTE Y RIVERO'),(2,1,'PAUCARPATA'),(3,2,'CUSCO'),(4,2,'WANCHAQ'),(5,2,'SANTIAGO'),(6,2,'SAN JERONIMO'),(7,2,'SAN SEBASTIAN'),(8,2,'CCORCA'),(9,2,'POROY'),(10,2,'SAYLLA'),(11,4,'ANDAHUAYLILLAS'),(12,4,'CAMANTI'),(13,4,'CCARHUAYO'),(14,4,'CCATCA'),(15,4,'CUSIPATA'),(16,4,'HUARO'),(17,4,'LUCRE'),(18,4,'MARCAPATA'),(19,4,'OCONGATE'),(20,4,'OROPESA'),(21,4,'QUIQUIJANA'),(22,4,'URCOS'),(23,5,'SICUANI'),(24,5,'CHECACUPE'),(25,5,'COMBAPATA'),(26,5,'MARANGANI'),(27,5,'PITUMARCA'),(28,5,'SAN PABLO'),(29,5,'SAN PEDRO'),(30,5,'TINTA'),(31,1,'MARIANO MELGAR'),(32,1,'JACOBO HUNTER'),(33,6,'ACOMAYO'),(34,6,'ACOPIA'),(35,6,'ACOS'),(36,6,'MOSOC LLACTA'),(37,6,'POMACANCHI'),(38,6,'RONDOCAN'),(39,6,'SANGARARÃ'),(40,7,'ANTA'),(41,7,'ANCAHUASI'),(42,7,'CACHIMAYO'),(43,7,'CHINCHAYPUJIO'),(44,7,'HUAROCONDO'),(45,7,'LIMATAMBO'),(46,7,'MOLLEPATA'),(47,7,'PUCYURA'),(48,7,'ZURITE'),(49,8,'CALCA'),(50,8,'COYA'),(51,8,'LAMAY'),(52,8,'LARES'),(53,8,'PISAC'),(54,8,'SAN SALVADOR'),(55,8,'TARAY'),(56,8,'YANATILE'),(57,9,'YANAOCA'),(58,9,'CHECCA'),(59,9,'KUNTURKANKI'),(60,9,'LANGUI'),(61,9,'LAYO'),(62,9,'PAMPAMARCA'),(63,9,'QUEHUE'),(64,9,'TUPAC AMARU'),(65,10,'CAPACMARCA'),(66,10,'COLQUEMARCA'),(67,10,'QUIÃ‘OTA'),(68,10,'LLUSCO'),(69,10,'SANTO TOMAS'),(70,10,'CHAMACA'),(71,10,'LIVITACA'),(72,10,'VELILLE'),(73,11,'YAURI'),(74,11,'CONDOROMA'),(75,11,'COPORAQUE'),(76,11,'OCORURO'),(77,11,'PALLPATA'),(78,11,'PICHIGUA'),(79,11,'SUYKUTAMBO'),(80,11,'ALTO PICHIGUA'),(81,12,'SANTA ANA'),(82,12,'ECHARATE'),(83,12,'HUAYOPATA'),(84,12,'MARANURA'),(85,12,'OCOBAMBA'),(86,12,'QUELLOÃšNO'),(87,12,'KIMBIRI'),(88,12,'SANTA TERESA'),(89,12,'VILCABAMBA'),(90,12,'PICHARI'),(91,13,'PARURO'),(92,13,'ACCHA'),(93,13,'CCAPI'),(94,13,'COLCHA'),(95,13,'HUANOQUITE'),(96,13,'OMACHA'),(97,13,'PACCARITAMBO'),(98,13,'PILLPINTO'),(99,13,'YAURISQUE'),(100,14,'PAUCARTAMBO'),(101,14,'CAICAY'),(102,14,'CHALLABAMBA'),(103,14,'COLQUEPATA'),(104,14,'HUANCARANI'),(105,14,'KOSÃ‘IPATA'),(106,15,'URUBAMBA'),(107,15,'CHINCHERO'),(108,15,'HUAYLLABAMBA'),(109,15,'MACHU PICCHU'),(110,15,'MARAS'),(111,15,'OLLANTAYTAMBO'),(112,15,'YUCAY'),(113,1,'ALTO SELVA ALEGRE'),(114,1,'AREQUIPA'),(115,1,'CAYMA'),(116,1,'CERRO COLORADO'),(117,1,'CHARACATO'),(118,1,'CHIGUATA'),(119,1,'LA JOYA'),(120,1,'MIRAFLORES'),(121,1,'MOLLEBAYA'),(122,1,'POCSI'),(123,1,'POLOBAYA'),(124,1,'QUEQUEÃ‘A'),(125,1,'SABANDÃA'),(126,1,'SACHACA'),(127,1,'SAN JUAN DE SIGUAS'),(128,1,'SAN JUAN DE TARUCANI'),(129,1,'SANTA ISABEL DE SIGUAS'),(130,1,'SANTA RITA DE SIGUAS'),(131,1,'SOCABAYA'),(132,1,'TIABAYA'),(133,1,'UCHUMAYO'),(134,1,'VITOR'),(135,1,'YANAHUARA'),(136,1,'YARABAMBA'),(137,1,'YURA'),(138,16,'CAMANÃ'),(139,16,'JOSÃ‰ MARÃA QUIMPER'),(140,16,'MARIANO NICOLÃS VALCARCEL'),(141,16,'MARISCAL CÃCERES'),(142,16,'NICOLÃS DE PIÃ‰ROLA'),(143,16,'OCOÃ‘A'),(144,16,'QUILCA'),(145,16,'SAMUEL PASTOR'),(146,17,'CARAVELÃ'),(147,17,'ACARÃ'),(148,17,'ATICO'),(149,17,'ATIQUIPA'),(150,17,'BELLA UNIÃ“N'),(151,17,'CAHUACHO'),(152,17,'CHALA'),(153,17,'CHAPARRA'),(154,17,'HUANUHUANU'),(155,17,'JAQUI'),(156,17,'LOMAS'),(157,17,'QUICACHA'),(158,17,'YAUCA'),(159,18,'APLAO'),(160,18,'ANDAHUA'),(161,18,'AYO'),(162,18,'CHACHAS'),(163,18,'CHILCAYMARCA'),(164,18,'CHOCO'),(165,18,'HUANCARQUI'),(166,19,'ACHOMA'),(167,19,'CABANACONDE'),(168,19,'CALLALLI'),(169,19,'CAYLLOMA'),(170,19,'COPORAQUE'),(171,19,'HUAMBO'),(172,19,'HUANCA'),(173,19,'ICHUPAMPA'),(174,19,'LARI'),(175,19,'LLUTA'),(176,19,'MACA'),(177,19,'MADRIGAL'),(178,19,'SAN ANTONIO DE CHUCA'),(179,19,'SIBAYO'),(180,19,'TAPAY'),(181,19,'TISCO'),(182,19,'TUTI'),(183,19,'YANQUE'),(184,20,'CHUQUIBAMBA'),(185,20,'ANDARAY'),(186,20,'CAYARANI'),(187,20,'CHICHAS'),(188,20,'IRAY'),(189,20,'RIO GRANDE'),(190,20,'SALAMANCA'),(191,20,'YANAQUIHUA'),(192,21,'MOLLENDO'),(193,21,'COCACHACRA'),(194,21,'DEÃN VALDIVIA'),(195,21,'ISLAY'),(196,21,'MEJÃA'),(197,21,'PUNTA DE BOMBÃ“N'),(198,22,'ALCA'),(199,22,'CHARCANA'),(200,22,'HUAYNACOTAS'),(201,22,'PAMPAMARCA'),(202,22,'PUYCA'),(203,22,'QUECHUALLA'),(204,22,'SAYLA'),(205,22,'TAURÃA'),(206,22,'TOMEPAMPA'),(207,22,'TORO'),(208,23,'AZÃNGARO'),(209,23,'ACHAYA'),(210,23,'ARAPA'),(211,23,'ASILLO'),(212,23,'CAMINACA'),(213,23,'CHUPA'),(214,23,'JOSÃ‰ DOMINGO CHOQUEHUANCA'),(215,23,'MUÃ‘ANI'),(216,23,'POTONI'),(217,23,'SAMÃN'),(218,23,'SAN ANTÃ“N'),(219,23,'SAN JOSÃ‰'),(220,23,'SAN JUAN DE SALINAS'),(221,23,'SANTIAGO DE PUPUJA'),(222,23,'TIRAPATA'),(223,24,'AJOYANI'),(224,24,'AYAPATA'),(225,24,'COASA'),(226,24,'CORANI'),(227,24,'CRUCERO'),(228,24,'ITUATA'),(229,24,'MACUSANI'),(230,24,'OLLACHEA'),(231,24,'SAN GABÃN'),(232,24,'USICAYOS'),(233,25,'DESAGUADERO'),(234,25,'HUACULLANI'),(235,25,'JULI'),(236,25,'KELLUYO'),(237,25,'PISACOMA'),(238,25,'POMATA'),(239,25,'ZEPITA'),(240,26,'CAPAZO'),(241,26,'CONDURIRI'),(242,26,'ILAVE'),(243,26,'PILCUYO'),(244,26,'SANTA ROSA'),(245,27,'COJATA'),(246,27,'HUANCANÃ‰'),(247,27,'HUATASANI'),(248,27,'INCHUPALLA'),(249,27,'PUSI'),(250,27,'ROSASPATA'),(251,27,'TARACO'),(252,27,'VILQUE CHICO'),(253,28,'CABANILLA'),(254,28,'CALAPUJA'),(255,28,'LAMPA'),(256,28,'NICASIO'),(257,28,'OCUVIRI'),(258,28,'PALCA'),(259,28,'PARATIA'),(260,28,'PUCARÃ'),(261,28,'SANTA LUCÃA'),(262,28,'VILAVILA'),(263,29,'ANTAUTA'),(264,29,'AYAVIRI'),(265,29,'CUPI'),(266,29,'LLALLI'),(267,29,'MACARI'),(268,29,'Ã‘UÃ‘OA'),(269,29,'ORURILLO'),(270,29,'SANTA ROSA'),(271,29,'UMACHIRI'),(272,30,'CONINA'),(273,30,'HUAYRAPATA'),(274,30,'MOHO'),(275,30,'TILALI'),(276,31,'ÃCORA'),(277,31,'AMANTANÃ'),(278,31,'ATUNCOLLA'),(279,31,'CAPACHICA'),(280,31,'CHUCUITO'),(281,31,'COATA'),(282,31,'HUATA'),(283,31,'MAÃ‘AZO'),(284,31,'PAUCARCOLLA'),(285,31,'PICHACANI'),(286,31,'PLATERÃA'),(287,31,'SAN ANTONIO'),(288,31,'PUNO'),(289,31,'TIQUILLACA'),(290,31,'VILQUE'),(291,32,'ANANEA'),(292,32,'PEDRO VILCA APAZA'),(293,32,'PUTINA'),(294,32,'QUILCAPUNCU'),(295,32,'SINA'),(296,33,'CABANA'),(297,33,'CABANILLAS'),(298,33,'CARACOTO'),(299,33,'JULIACA'),(300,34,'MASSIAPO'),(301,34,'CUYOCUYO'),(302,34,'LIMBANI'),(303,34,'PATAMBUCO'),(304,34,'QUIACA'),(305,34,'SAN JUAN DEL ORO'),(306,34,'SAN PEDRO DE PUTINA PUNCO'),(307,34,'SANDIA'),(308,34,'YANAHUAYA'),(309,34,'PHARA'),(310,35,'ANAPIA'),(311,35,'COPANI'),(312,35,'CUTURAPI'),(313,35,'OLLARAYA'),(314,35,'TINICACHI'),(315,35,'UNICACHI'),(316,35,'YUNGUYO'),(317,36,'ABANCAY'),(318,36,'CHACOCHE'),(319,36,'CIRCA'),(320,36,'CURAHUASI'),(321,36,'HUANIPACA'),(322,36,'LAMBRAMA'),(323,36,'PICHIRHUA'),(324,36,'SAN PEDRO DE CACHORA'),(325,36,'TAMBURCO'),(326,37,'ANTABAMBA'),(327,37,'EL ORO'),(328,37,'HUAQUIRCA'),(329,37,'JUAN ESPINOZA MEDRANO'),(330,37,'OROPESA'),(331,37,'PACHACONAS'),(332,37,'SABAINO'),(333,38,'CHALHUANCA'),(334,38,'CAPAYA'),(335,38,'CARAYBAMBA'),(336,38,'CHAPIMARCA'),(337,38,'COLCABAMBA'),(338,38,'COTARUSE'),(339,38,'HUAYLLU'),(340,38,'JUSTO APU SAHUARAURA'),(341,38,'LUCRE'),(342,38,'POCOHUANCA'),(343,38,'SAN JUAN DE CHACÃ‘A'),(344,38,'SAÃ‘AYCA'),(345,38,'SORAYA'),(346,38,'TAPAIRIHUA'),(347,38,'TINTAY'),(348,38,'TORAYA'),(349,38,'YANACA'),(350,39,'TAMBOBAMBA'),(351,39,'COTABAMBAS'),(352,39,'COYLLURQUI'),(353,39,'HAQUIRA'),(354,39,'MARA'),(355,39,'CHALHUAHUACHO'),(356,40,'CHUQUIBAMBILLA'),(357,40,'CURPAHUASI'),(358,40,'GAMARRA'),(359,40,'HUAYLLATI'),(360,40,'MAMARA'),(361,40,'MICAELA BASTIDAS'),(362,40,'PATAYPAMPA'),(363,40,'PROGRESO'),(364,40,'SAN ANTONIO'),(365,40,'SANTA ROSA'),(366,40,'TURPAY'),(367,40,'VILCABAMBA'),(368,40,'VIRUNDO'),(369,40,'CURASCO'),(370,41,'CHINCHEROS'),(371,41,'ANCO-HUALLO'),(372,41,'COCHARCAS'),(373,41,'HUACCANA'),(374,41,'OCOBAMBA'),(375,41,'ONGOY'),(376,41,'URANMARCA'),(377,41,'RANRACANCHA'),(378,42,'ANDAHUAYLAS'),(379,42,'ANDARAPA'),(380,42,'CHIARA'),(381,42,'HUANCARAMA'),(382,42,'HUANCARAY'),(383,42,'HUAYANA'),(384,42,'KAQUIABAMBA'),(385,42,'KISHUARA'),(386,42,'PACOBAMBA'),(387,42,'PACUCHA'),(388,42,'PAMPACHIRI'),(389,42,'POMACOCHA'),(390,42,'SAN ANTONIO DE CACHI'),(391,42,'SAN JERÃ“NIMO'),(392,42,'SAN MIGUEL DE CHACCRAPAMPA'),(393,42,'SANTA MARÃA DE CHICMO'),(394,42,'TALAVERA DE LA REYNA'),(395,42,'TUMAY HUARACA'),(396,42,'TURPO');

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

insert  into `tageo_paises`(`IdPais`,`NombrePais`) values (1,'REPUBLICA DEL PERÃš'),(2,'ARGENTINA'),(3,'BRASIL'),(4,'BOLIVIA'),(5,'COLOMBIA'),(6,'CHILE'),(7,'ECUADOR'),(8,'URUGUAY'),(9,'VENEZUELA'),(11,'PANAMA'),(12,'MEXICO'),(13,'CANADA'),(14,'ESTADOS UNIDOS DE AMERICA'),(15,'FRANCIA'),(16,'ESPAÃ‘A'),(17,'HONDURAS'),(18,'ITALIA'),(19,'NICARAGUA'),(20,'ALEMANIA'),(21,'INGLETERRA'),(22,'HOLANDA');

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

insert  into `tageo_provincias`(`IdProvincia`,`IdDepartamento`,`NombreProvincia`) values (1,1,'AREQUIPA'),(2,2,'CUSCO'),(4,2,'QUISPICANCHI'),(5,2,'CANCHIS'),(6,2,'ACOMAYO'),(7,2,'ANTA'),(8,2,'CALCA'),(9,2,'CANAS'),(10,2,'CHUMBIVILCAS'),(11,2,'ESPINAR'),(12,2,'LA CONVENCIÃ“N'),(13,2,'PARURO'),(14,2,'PAUCARTAMBO'),(15,2,'URUBAMBA'),(16,1,'CAMANÃ'),(17,1,'CARAVELÃ'),(18,1,'CASTILLA'),(19,1,'CAYLLOMA'),(20,1,'CONDESUYOS'),(21,1,'ISLAY'),(22,1,'LA UNIÃ“N'),(23,3,'AZANGARO'),(24,3,'CARABAYA'),(25,3,'CHUCUITO'),(26,3,'EL COLLAO'),(27,3,'HUANCANE'),(28,3,'LAMPA'),(29,3,'MELGAR'),(30,3,'MOHO'),(31,3,'PUNO'),(32,3,'SAN ANTONIO DE PUTINA'),(33,3,'SAN ROMAN'),(34,3,'SANDIA'),(35,3,'YUNGUYO'),(36,6,'ABANCAY'),(37,6,'ANTABAMBA'),(38,6,'AYMARAES'),(39,6,'COTABAMBAS'),(40,6,'GRAU'),(41,6,'CHINCHEROS'),(42,6,'ANDAHUAYLAS');

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

insert  into `taofi_areas`(`IdArea`,`NombreArea`,`Descripcion`) values (1,'GERENCIA REGIONAL DE INFRAESTRUCTURA',''),(2,'G.R. DE PLANEAMIENTO, PRESUPUESTO Y ACONDICIONAMIENTO TERRITORIAL',''),(3,'G.R.DESARROLLO ECONÃ“MICO',''),(4,'G.R. DE RECURSOS NATURALES Y GESTIÃ“N DEL MEDIO AMBIENTE',''),(5,'G.R. DE DESARROLLO SOCIAL',''),(6,'DIRECCIÃ“N REGIONAL DE PRODUCCIÃ“N',''),(7,'DIRECCIÃ“N REGIONAL DE VIVIENDA, CONSTRUCCIÃ“N Y SANEAMIENTO',''),(8,'PROCURADURÃA PÃšBLICA REGIONAL',''),(9,'OFICINA DE SUPERVISIÃ“N, LIQUIDACIÃ“N Y TRANSFERENCIA DE PROYECTOS DE INVERSIÃ“N','OSLTPI'),(10,'OFICINA DE DEFENSA NACIONAL',''),(11,'OFICINA REGIONAL DE ADMINISTRACION',''),(14,'D.R. DE ENERGIA Y MINAS','DREM'),(13,'DIRECCIÃ“N REGIONAL DE COMERCIO EXTERIOR Y TURISMO',''),(15,'CONSEJERIA  REGIONAL DEL CUSCO','CRC'),(16,'OFICINA REGIONAL DE ASESORIA LEGAL','ORAL'),(17,'SECRETARIA GENERAL','SG'),(18,'G. DE ACONDICIONAMIENTO TERRITORIAL','SGRAT'),(19,'D.R. DE TRABAJO Y PROMOCION DEL EMPLEO',''),(20,'G.R. DE CULTURA',''),(21,'ALTA DIRECCION','');

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

insert  into `tapri_persona`(`DocumentoDNI`,`Nombres`,`Paterno`,`Materno`,`Sexo`,`Foto`,`FechaNacimiento`,`Email`,`Direccion`,`IdDistrito`,`Telefono`,`Celular`,`Ocupacion`,`Usuario`,`Contrasenia`,`IdCodPersonaEmpresa`,`IdAgencia`,`IdArea`,`IdModalidad`,`FechaInicio`,`FechaFin`,`EnableSINO`) values (40494250,'EDGARD','RAYME','UISPE','M','‰PNG\r\n\Z\n\0\0\0\rIHDR\0\0\0d\0\0\0K\0\0\0†\"·\0\0\0sRGB\0®Îé\0\0\0gAMA\0\0±üa\0\0\0	pHYs\0\0Ã\0\0ÃÇo¨d\0\0TIDATx^Mu|–å÷Ç7ºAQQALBTDPP•”î’nXwoŒmcİİŒîîîîæó{Ÿ{óûúıq^×ıÜÏ³;ÎçœÏ‰ëºï¹_xHÃÔˆÅ‡Ã\Zµä¨Ü—”Û²S\Z³ì¤F/=ñ?q_~R+ÏÈ{ÕYù®>¯€Õ¸æ¢‚×^Rà:“‹\n\\{Qşkùñ[w9/ßuçäÍgïµçä‰x±íÅ>/¾ó[Aéüİ†K\nB‚mÜ˜µmûœı—ÙwEÁ¯*$ãª3e\\SÈÆk\nİpMá¯+	åsĞ†«ëªüÓ/Ë‡kòàzÜ¹V7®yôÿ÷Õçä¾êß]â¹ú¢|¸¿µ—åË=ù¬¹$ÏUçq_yNn+Ï\"gä¾â¬<Ùö@¼Øï‰x,Ï·egä¶ä´F/9…Ohø¢\Z¶ğ˜Í?¢s«ßœCúwÖAõ˜µ_]gîS§{Õ~Úµ¶Kÿ¤îR›”r1@†,:¨!ŒÃd´²ì„Æd1réqZzŠ“äbNË‡‹ò]u.nÂŸ‹÷ã¦ıÖ\\àF\0`\rJFé¾(İ—ñÿƒâÃ>O@ğÛöfÛ}–Ò\rÒQ\n@ø”ßÙşà\rWP¶q@®Î5¶\rë€qC7É¹ñ&ÀÜ\0”k÷\npY\\Ÿ;×9†ë\r\0cV]€KòZsYŞk®¢ø+\\ËU®ùªÖ]Ã¨øÛu\0ºöŠ¿ó_şÆwÕ%ùğ÷Ş+/\0Æy¯`\\Áçå\0Ê¶û²óèÍ\09­Q‹Okäâ“\Z¹è$ ×Ğ\03`”Ù‡ÕgöAõšu@=fîWûÔpºLÛ+—¡hĞ\0YtTpÀãrsÀøÏ;—–Ûò3œüŒ|°o\0ñÆrlôÉï5ìã¦½±F‡m†Ïx‹~(Ù@2 ü×gyA Îçl ø€øN `™gdƒ¶áÛ7\0	@Ì;ŒqÙbß¦_Ğ«x\" 8Š¿Ì¶É®áŠ£p¿lÉá:×€w­ão×_W0c0ûB‘0>‡ñÛ<¿UoåEta`\0Är<i †ÛÒ³\Z“\rÆèÅgåŒÆ0º™,¤E§4lş1\r˜Ásh Òö!Gş Çe`5ïXtD#—wèÉ\0ÉÅ<Å¨ë4\'<ƒ\0\nbÀx\Z@¸­4à€\0d­f¿³/ó èÌ\nñ[wÙ¡7ÿõ—³\0`¿Ck\0g^cbàù€ĞÑ•QT(¶	o@ñaÙ`„¡øp\0ˆF\"2²Ä<&˜Ï(Ò?ı\ZVÏˆ‚í³” ëo*Ôù=c(ûÅÛçõ·‰D¤ßÔXşn,¿fÇ	_Ë±Ì«V\n@x-C–_KĞ<²\Z\\\nKÎÊ<—\0âõß¸Z”‘kÄüã\Z6ï˜†fËàÙG5`ğ£«ƒ\0r˜r/Éebîgâx™\0‚q¨ÅO€ğ20àP/pŒOÍsó_€°ø‚u„âËgÇSØödôÄ³¼ø­7b±ÅÛ¼‰¿ó1ÀÒñóŒƒš¢¢Øg`˜7E™D°e@ÁÙŠB™A(6	5q~‹¿CáH2–Ïã6ÜTßG#ãÖßFØÏ•Îohf-ÀJ€QÜ\n€€ªïÙà˜§@]^K¹€ñ <Ço)÷»”q	zYB¬Ák<e4ñeÀŒ˜‘Nhä¼\Z:÷¨\\†-<? GåX6(ÇúrÇCÜÂ{9\n·€æ5Où F_Yâ_X ‡&‚¡ãcxØ‡ï¼O¤\0á\'y¬áx€ğ~\0æİ¥_ŒkŠDù1\0·éV–dÇóó”,¹æŒ!ÿŒ@,ß¼!e\0VdŠÎ¸­±\'fãmäN¶Ø6`ğÛq\00.0ÖßÑXÛ$ÔhXã¿šû¿•W°’}« 9W‡Ø`xQĞrŒjÙe\0JÀc_@q_‚şˆ3P™Ç’…$R€ã2Òä°†-:Šà%uó7²¼Ä@< ,¯ììÂ;;–X`÷\'°ù;\0 D\'Àsb‚_`ß2 ¾|çM0ô´¬ĞÜ,kL7áéx†%æE€\0Í„Bfı¬£7İT,ò ãPæXö;año0*Êò\n¥\0h Çqèéÿ½é¶sœøÍ·5Ş‘;\0|Wã7ÙxG±€4nC–Ädm(Qx[ä:¼\r/	†ºBÖ\0±¯\\ËwŒ|_ ¡«¸À	^\0&Èá9¾Pš7”æ…ùÙ¸ïYˆ‘/<-—€0P†eÇ‘QKğ<Ã ¼Â›Øá½Œ˜\0 ş(Òo%)-Ê\rvÒ]E‡8\0 (Ôö †?àø!>ˆ7`¥¹ñ÷n+p]\'ÖEWa)ç”M\Z>S¾³¶¤±N³b¬:Î$ÛCÌ[¢,›2úAé„ò?É¶ß<Æ@Å+Léñ\0ğŸØ7aó]Æ»Še^ã5û€~øg°>¬ı§º\r®…‹#”¸jK•ed 9²}ˆ¬œÕT‹×„,ÇÛ%ˆ8 \0\0¥ùC_Fcş‹1j<ÇP—‡ĞñÑ€á^€á~äÖ\0ˆñ†P”\Z‚µ‡­¾Œ\\QJ€p¼Á$	eà*ËFP0‰ÑT Ğï¤‹Œ–FZJJjØfP„šğQÿğéê˜ªQ‰«¹Ùk(±&ÙJ˜qHû,f„9”D–]29ÁËå÷áFO(<Ö€0…o¾—¥ü-w•°ì ._§…KViæìEš2m&N%¯µì¯w¿ú^Å?ùFï|VMûâ\nH3]ôf¦«fŒûGQPQ,t›~jƒòÖ3:qç€ÜVôZÎk ¬Â[/!]‡ŞBˆ1ÁÄbMÛÁK`è,Ğ>‹Ç¢cpÙ	²“Sòˆ R¸¬8”ô.E†¡Ôp@ˆ@‰á(<É\ZÃ\0ÉşÄgãNãWK\r}¤SøR}÷Ïp5èæ©¼’Õ+nºE,V«!QjÚ²‹Zµ¬­ñ¡ƒÔs¸·:úO ›¹ 8¬4‹Åb£HR7)~á³qÿX¨Ç‚qJ7‰B¢ùlñ!\Z\0¢Q|ì¦{\0‘%6ß×Ä-4yë%f>PÜúóŠ^-\'-QĞØ0eNûW73ºIW†*5¡ƒ>ù®®JV®ª·>úR‹FÕ›TÏ©&µŞÑ÷ĞÄ¹ªK¿Ç±8 Ä!±\02‰]“å)ÑPWÔJÒòŞ2‰B\"\0*b‚÷„­ ƒdÅ‹Â–^‘‹?±\"€ÜÙŸ H¼ È¯ÃÉ\"\"Pn$Jrä\n»Âg“« Ia+/\ZVÎ„4_²¡É»õI¶ÊU´¬\\ó•‹KN¹æÈ­?)%Ÿ^Ÿhµeí¨®ˆîµäŸâU vcÆíe£`ïÙ;T§ı@ıŞ\'X¡\\kÖÇwq({<ÛñíÜÓD¶\'f+\0$8òP‰[9’”ùXI[m|¤ÉìŸ´ù&nº¯„M9o§úöí¬\n•?Q¾òŸ\0ÆªXåc­\n® ÕSkòôùê¬Bõ:+`ö1MØxP²d\"àLØÀ¹(¯‰3˜8b‹K|‰ 8Æ	Ä™ñdlñPZ,½´±H4À¹`‚\"	3ÏXv¯À­\"QnŠwë0@x@JÅ\rƒƒ/˜ß†0Ğ²\rñ\nè_A9¾í€à’3¿\\rPŞ¼´Òı+Míü±š×(£6]:ráx„V¬Îx|<ŠïX67‹‚ÌÂ·°{‡MS™/jé×®~òNÛ­I|—ˆ‚3QúÖ‡š‚‚§šÂ·>UÒ¶\'š²ÙöXÉÎö3ä)ò˜ß?ÇJØü\0:€Lâ|“s@Ä$}TíCŒşS§vÍÖ‰37µeÇ%M[°_mF\')ïOİÕdè$%oz˜-x›˜q_É€”¸ñ&›@iS\0g2àL†Ò&Ğ$ÆDâN’	±h2ãd…€‹7 ğ(—P<ÃÀ%%¸„Áe¦ìp¸Î‰‚71ï`çû0¾€¶C\0Ãñ¾_·1NJÏ¡\n+G.€pÍåx‡‹KÄÕó*¨~>!UO\0ˆ‰Œ	(#!ÛZ\'¢ É¶²Ì’ÿ³îÄÌ\'š°ú´ê5øUùK¢²U¾Ó·M:©å€@õ¢Fízè£SÓî^ŠÇ[S·?WÚögY²\rÙú\\SÙ—²í©’\r´Ì§š\n0ÉxL*2wÛ%ÚÚUGVÒ¥ëtîÊ#í;|CË××„´-ªûo”\\«·U•ß)mËSMÛüØ‘®3\rIÍx @q„ûJERğø<(Kî8c\Z”œÊvš}˜)\05P&ŠKÈâs<„¨o 8€ ¦ôó=Öä\n¼{•ñªÃ}+ˆ#FaÈXö[}Mã×\\Ó³ŒwtiRåÏ æ.Ùâª¼\nÊ;i…±fÇ¢Qøn&±}I\0cûÿûn*ÉX{\nJLF™iÄ‚îÚ)gÎ<ÊY´Œ*×oªŸÛvÕ»5~Vî²•åZ¨¬Š¼[IÁIéš»ë…f!³wdÉŒ/4sçKMßùÀi\0Mg\\¹÷\\üToÎçÓ®%µjı>mßwU¶œÕÔÙ›5*8M?õğ•kÕV*U«³fîô-O4mÓ#¥à-©xH\n1ÕÄ”Ò§È4öÏÀ¸¦;rW3ğú™àLÛ†šgR#MÇS¦@c“¡/—š_A(aHK8À„‘–…C[cñ‚rè”‡ÒÇS\0çb-`Å ±ää\'R8-ÚvY6Ò‰”jòìTQ½ÿ(§Ÿ«¾¥2%sC]x‡kN\rŒò±$³*¬s:2\r\nICé©ŒÓlãL\0p\0fm{âiÚö§šîl£\\¶õêªü%Ê©FÓ6ªŞ´µJ~Uş¯\"×‚ïB‘…T´pÍ3Iw¿Òül™»û¥ş“Ù\05gÇs­:pWÏ$H÷ÚK—\nëbfaı;ÊO‹VìQÚ¼L\nKUù_;(ÇûµäZöåù¬	Ê}€w<r<#í4”œ†òÓ\0ÄÀHÅ3¦™ÒMù™0‹ıi€0:g\Z@¤™Pß¤ Ã)Ä“‰|—P*ÄPJùHÀˆÄS¢ğ’q€C|ˆÃ&ğ£‰(>™l(R´%’o\'p I¸Y@L4áó³wuáÆ#½òP§.ÜÓ±“w´uû-óû]3;åĞ/­ÚÀ#çF¦C¦ğYĞÆ,À˜‘\rÀ¼`62ŠqåÏÃŠç\0Ä,>gÉsö?×ÂíOÔè¯6z¿Îo*^ù[å,\\J9ó¿øùğÈ,ª¬ıQe®_©Å{_kÑWY²÷%ãK-@íy®;¯H/¶KÆI·ëåõ6jĞü/…ÅÏUw¯IªÔrrUª/×wğ¾bŸÊõí¯9ë°s©0fıŒxDšQb””ú?jº­4¨)İMAWSÖ^S\0$Qõ\'’q%iÅS8ÆRÍ»DFÔ¢3Š¦(‰Æ3b	æñ€OÖ4¯˜Ä&RN¥ĞJ#ïŸAŠ9ƒà;q*\'Iˆ)ô€Rø|æÒ}İ¸ûTw<ÑMÆc§îëğ,w=òË¡ãÃ]µ 5^sQüS82/[és²A™\r=Íœ¹xÅ<b1²jY„Ïw@ÉÉ\0Z„u/G¡sè¿÷YM@Èóÿb•Ñä’Su¾z_Ëö<Öª}¯µjÿ­ÙÿZ«¼bû•vy*½¹#½<.=Ï¤éÍ£Õøµ~êĞ_Ÿ·£‚õ»(gå†r-ñ¥\\ˆ|¤‰”³0ªxÈLhw^?™fAj‚¤Ğ‚™Š~’!	:Ÿ´úªˆ³±ıx(ÖX ÆRµG. 0Œ¢bñŠñ\01‚-‘Z#™Ê9…–s*­íéY³h3ÌÍ¼£U‹2ïkş¶šÇ¶íŸíÈÍË¼«“çîêòÍ,0®3Ü­×é¹ô0ÙUgÆºêHÌÛZµã¦£ä¥È8}1Ê^„â\0Â<²¡PÑ¢Ï´ŒïWìz©å(~)¼¿„ß8Km@¬ŞûJkQğzdÑæ+úàÓ/²±Ä!+ypFWâX‘2r‹™¯ô£o´ş˜´şãá7Z‡\\½÷@îJ¯ñ’W€òb§Ş<]£=~QòŸ«@ƒ.Êó}k¹~øŞQY.…*¨X™¯¸FË¼/™…×Ï”Ù<B€EM·\00SÍ3`—D<c2€$`ìñÄèñ€g‚ş\r”qTë.Sp›Tz?i´!f¢üy(~áV”‚Mm»¯e;jùÎGZµû±Vïy¢•»Ÿj9ÛËw>t¾[Ê¸b÷#íÚyšº­óWk[Æ|é|éä\'zsâ=Øğ¶î®+ª]ÛgiÕÈs­d\\¾Ûn Oå/w¾GáŒ«÷²½\0a@¬Ç²7|£\r‡¥H:ŠMZ¼G\nÓGÅ]õciW•*˜\rL·åò^UÕhÙ][O<ÓöÓRæ©7Ú|â2O¼ÒËWôF\0b^òæ&rRomÓŠ%nÊ‘¯˜r~ÑP9¾êÈµèÇÄ§\n*R¶:÷ıD1¢9xüB¼İ®1û–2.a\\²í‘R„Î¡FJ£h\n‹$Y¬ ùIÆS’d¼&ÃŸ¥V2Œä²`Ë¬ş.¸§•; ØÇXf¶²Qô*\0X·÷©ÖíªôÏ´şÀSò·<cÿs¥z®Mì_´`³vï9§UË7ééı¥ÒıpŒo¬Ÿé­k»ÿÔå­õul·Ÿ6y…¼æïPğş—Z¹ï9 à(\rŸ×Dá‡^£ğ×Úˆ5g`ÙÇŞh#ãÆ#Ò&yëÉ7ÚvÂFiã–ão4yn†zÿXHí?pÕ7%\0Ähì­Šr)_]ïÖıC‹7ìÓîóo9ã©/\0Ã\0y(™¼¹‡\0ÈÓ]>«œyóÉõİÊÊQµ™r|\\‚(\'×\"+jÊfôÆ‰a!+ÕÜÃ\ZîÇn…CF8âv2Pfà-³ ş9ô¹PÛB¾[²åƒÃÚ>.+°|G°ğÕğìê½píŞ\'¬EÖÂ¦CÏ´åğKm>ô\"K¿@I|F¶‡‡O¿Òî“Ï3~Ö­Ù­\rëpc‡õæñJ=¼’¤³\"udûhÛ6@Gwj×ÑÚuòµ¶£TS¤YëÄmÊİvúp6í>›%»Î¾A¤ìÛq…3…J;‘¬ıY¿·qıl/Õÿ¦¤ò/!—âË¥D¹¼_CÅ¿«¯øÔTí¾øF{/Jû/¼Ñ­Ï\0áAe1¾~yY/ÒÓ»+¸æ+A‚P¤¬r}İD9¾şK®åkÉ¥`yä}u¾Â :_2¾Ôd#û6Â¨¼Ô\ZlÅN¼fÛC-Déóñ–\0°˜Ôw	Ô¿°–o‡]ø~%ÛKøŞe%Ş°0–ï‚’ö \0²zßGÖà#Ïµ«Şzô•2½Ä2_jÇÉWÚyêµö}¥ƒ^ëÈå×òš$w¯0]½’©×O6ëŞ•y:s8IûwÆkïñ:¸3Zw\'hÏ¡í(úö @G²lJŞwA:xé]y£#W¨ıĞeö±ß¾ÛƒìFö:Ûoœ}öw;8ÆsuáâMıÙÏM¹ª6”K©¯Èˆ>—ë{ÕõÖ÷õåê¯]Ù@î8÷F?^Èë{zõê?>£{··èÒÉÚ•á®åJCSï)×WåZ£•\\?ù…ÏŸÈ%OIıÒ¬—2ğàMxrºyóA¼£İvô5FúR™xº±Èjœ0qwéÖûZ¼õ–±½’ÎÂÊí´–ïÖ\0ÊJ¾[B\\âƒÅíàÅû²Ï«Ì[\0f l<ğÜñŠ­xÃö¯âµv\"»ñŠ}ç^;`ºøZG¤ÏˆuèÖ\r—ß­gwVéÊ¥5:p`‰¶í˜§í;gi÷®TíÛ;S»ö­Õ³/´¥˜ìCöC!Pğ¡ËY@»şF\'o¾Ö‰ëûZ(ò³A1`ö;–ÒöctôÄY-YºYcübU J=¹”ü\Z/ÁCŞıJÅ¿­¯‘>#µCØ™íU¯^ õæå]={vM×ïÓù³«uxw¬vo\Z¥’eK\0èGÊYï¨ÓC®ßv„ÂªÈ»ªüumÇ»·B©F¿›½Ò6dFºc5ã]îÖÈ:Œ~íG\0@ÌEñ¦üæŒ«ìsæ=-Œ%L1¸¬ÈÃâÈ¢ÌÛÄ’»Z(k\0cÃ¾gÊ@6\0<dAp 8\'=mŞ ç_ë0}ùç_wµìĞªÚ¢[W3tòìí8¸O›vïTæ®õÚ²sƒ¶îÊÔ½ÛQà‘å!È ˜âàÇäÄ\rÀ\0œƒìÛò·ó»(ÓºK?2ö^Õª5™\nªş£CÔ¬çhUjÔA.¥¿•kIøŞ·*Z³úì«ô½W´•À~#ÒëÇzƒ¼x~×©E.\\9¦ƒ‡×kÏv<z‹‡J•+Éßª¼uÛ(Wãrm4L®Ÿÿá¤¾ù‹¼NĞË1¨÷8^Áhô½ïØ‹l>ûˆ·Äàõ\0²êZ·ÖÁ#Ö¢ó5Û/¥C½ˆØ±€yœ…Ä—5 g®d)íBRØå[oKÀ‹ÄÀØ@@ßHÀŞrø¹s¢íĞ•Y€²;[™°îıPWû>£Ô¼ıŸzù ]—/mÒãÇµyß	­ßqJëvØxNwÓ¦½—¸¨‹xåu,Ë²7ÚNæ³€öbÁ§ °C€|í=\0±ØLÌÙdñÆ,“ßoç÷[ö\\ÒöíG•4e±†{†ëïÃôÁÏ­•ÿ‹_³8ÿ£ºr­ü³Š|ßHôê©Ø´yÔæİ¹{S¯^>Öã§wtùÖ%=}X;v¯Ö–-IÚî¥J_}\"×Ò••ûçör­İ\ré)×ï»Èåm‚{¾wµÆh&4µ½ìÀ;¶ã[ğ™›i‰ItA~#ñxÃnÀ!Cu€AïæË	æ‹™Ç™O¶;‡i\0!¨Àkæ!¶Übû.¼öPé ›nÙ÷XÄ’MŸ)“XbÉI3ñ˜íX„Ñ—Å“\r»n¨YÛŞê7ø=¾9[—/nÓŞ£Gµe÷	­ŞzV«¶]ÔÚí—´qûEmÜsU;ÜQoŸ²[Ú€Ëo6×‡· Û°8óÄ(>ËË°Œì0œÌ¹ÿË¼6Âß;ŞĞÊÕ;´nı~\rªv½U±á?Ê÷qm¹–£X|·ºr|ø£r|Ş@j6Òg-º©ëh/íÁ€v»©UéûuóÎ=İºÿ@\'¯ÜÒ\'µns¦Ö¦\'kí\n?UùşkQE¹~øG._ı-—¯‰#ßvëu¤¬âSÒµ×âè™WÚs\nö\0\'ù1š\'~d|Á¾—Ú	³ì„ò3I˜õxÉ*bˆÑÔrò¤ÅÈ,ê—ÕPÔÒÍ·´˜%6ó‘ÅĞÖ\nj5d^ë	ôëTgiï^ø±qÃ¾Ú¸Ÿl‹“oâÄSÓÖêÃ\ZõÕOOn-Óå+´ÿø\09¯µ[/jÕ–Z½ù‚ÖĞ¬Û°ó’20GÀLİ—Í»(ff¦6’™l„\Z7Z¦b©/YŠ#d0–\Z[cÁ3À¸ûnjÉò]Z°h«&MY®V½Ç¨â/ÿ¨à\'?*g¹êNUmñÃµJı¨–rWm¤òÍúè‹Vİµ‘¿İ¶ï¬f,ÚÅõœÓ‰‹÷´ÿô®¯İ¸OËÖ.Ö¢•	ªÕ¨r”æï«5ÇËšÈå3èÊ@ù¸1éï{\Z82J{ñÜP÷>ËôP¼y†é\'ØazÙ£ØoĞNâ=|¿ÖI7Rb¬³Ò}¯ÀS–³vÀeÉæëšÇÒË¹&¬}šGq¸\0ê²lÀ¨l¹¥dd–)X^½ÂFÜnõîgPÛSŠ7Š­ƒO4\" UoUøR>>]u÷ú:¹xŒøqFéÛÎkõ–‹ZqA+7œÔÚ-§µêÚzàŠ¶ ”‚Uë(g¥oUëïŠLN×:·\n±œş?Yø–Rn¢\0ÜŠ÷ì=ú@›OÓê?©ÌÌ³ò›¢ÛôQÑj•«4™©®õœ\\\n} ë=½WS¹kü¥\"ú¨Ù‘ÒRmØz@I³3µdí)mØvE›÷bˆ›/kAúiÍZ•©ËæAPT™ªTéxÄGdmå¨Ö?ıÏõI}+¨ÑŸ=u˜¤æ¨‰Ñ+·P¶`XFSÛñŠ}g ^\0; »a”L˜Æ¾ÛeBmÛŒuğœÌ$P”.³X/5iØ,P˜Iµ>Û‘šÍŞ\\ÎZ\0‹©8—1Ñ³l;`P‰®ØI¥NU½Ü>ï ;Ëò¡â¿ôR2_jâ?—¡ƒ\'N+Å¯İr^K×ŸÒ’\rg´:ã¤6n=¥MDåmû/ißÉ»zÿ‡ÆÊ]…U®©œ|¥Ò_ı¤¶Ìo$³úÅ‚Ëòù\rxË¶´¹Qb`ô|-Z¶O‡„,İ­Îƒ|õÙoí”¿Õô;ŸÉõ-À(R‘6ü‡Œ*G¹o•û‡*Ğ¸¿J´¥–î1\\ÇNÅ¦¬×¼U\'´|Ş»é\Zöšæ±hoÖÊ#šNqÛÇ/ˆÂ’êœ¿w)ıÁœ”·(\0—¬Øªç™k¯tâÊks\0!® NCÙñK†v@í»ñc;IÀfîÃ„ ¿\r@vÃ‹N\"ÇùíÑrIe\"\'9ó4úWV¾§QÊ§ñg0‡=‡Jr€,b*Ô@0ÅX;c%­•ô›aƒarı¢‰r}ZOÃ<‡iÏşm[bF&~JK7œ×âô3ĞÃy­ßzYéÌÀíØENİU‹#TæÛZú½cWµêÛO\rèR»¾Š³Ààç–=t\'µ„µÀ	)4\"(UU[öWÓŞ^ÊÜrR»HÂÇÍÒïëız-•÷C@5Š!èºÒsr-øSU»V¨«Üõû¨PÓá*ÑÆW•;{kûîm\nˆ[‚1Ò‚5g0˜KZÄÒÕy,ƒÉj˜´åºX¹ßùÈ¡=—5\0ª??SÒEØWŒãæ+­Å«÷ë	ÈJ\0£¥(8Ã²+‡’Ìê‰ÃÄ\r‡òÙŞÈw”²ºßwl#aÚ-.ÉÌú%J\nS³ÉôYRèLN§‹;‹öñÚÇV]šg¬ŞûÜ¡\reÕ®,Ëµ\nu1«CòàÒù«ÔW®*\rõïÈ‘ÊÈÜ­u™çµšZqY‹XT°`ı9>_bÿmÜIP?tM‡OßÒÊu;”˜4I“§¦hbb¢fÌ˜¦Õ+ViÆÌå\n£ò÷›®¿ûé»ö#ôaÓnú a+µî5Z;¶Òä”uê><LÕ¡»w¾ı]y?©ÍœÅ÷xmrRS£×·>£õ§rÕï«\\\rÿUÎFƒ”³^oR_Ï	Jœ³W³–×\"<cËZ°¢rÊÍXqXõZ÷€\ndVß\00•îâNüp-·äO½…Ğ¥°„´—dg#ÁÜR\\+öÖ@÷6®f\\Ae¾\nYO†eñeƒÅ‹ÏÄ‹#ë)5ÒI]@.+…f×4š]3\0Ä(k.­ãyDëÅ¬\"f¬td-HÛgëÙl m0ÈkºòĞ¢Èùş7Êùa-õwó#VìÖâuÇ ª³ÜàYÍ^}FóÖa®ı¬Vg^VÆ®ËÚ}øªŸº¡ô­\'¥±Z´x©¦ÌX¢CCT£U_UoÕO_şİK_· B?¶Ô\'Úêm*ğ_ÛôÒB¨ª¿[Œê²ø¡|¿õÖWõUø‹zÊ]PŞ!†Ğ\"7…¹–üF¹«SGüØM9ku’k•¦ç¦Êıİ?ªÑf€Â7júÒ£šÏ‚½E,úÏú°9,gšÁ\Z‚4–AÅÏŞ©R•ÈØ )×\"•X°Q†«L–ç|OTú‘@\r¦¼šxkÔJZ%Ë˜ ZLk>¾\0ÆYJWÜŠÄ3nè8+˜ß¦0¼h÷ø[*õÀ˜NÊ5;ˆùÄÅxÅşx)]Å	œŒ‹ê= c\\M`_\r(àÂoë¶§re1CYh¢Ô—\Z2VÖ\0ãäé§5—å¢3°À™+Ê1­Ì8E‘x^»]Ò×´`zr“_x’\Zt©ÊÍº«BÃ¶ªğk[•oğÛmT¸züú­ò“ò¼÷•ú2>Üw’~ï:B_6í¬·«7R¡J?©0’»\"q„^“Ñ‰«òöWxHsbH¹~ÖÅôßÿQ®_µPÎïÛ©a¯PMœµW³Wœrèj€Ì¥˜ÎÂZäI<JĞ´Û(bSU<Î@.Ïqñ˜ü4ñÂF[x•Ñ°üt<`ı.˜È€Y\n(K`š%Ğ¿UäFaØ-l?òŒtø)qä9eÀ3m%9r™ï w¤èö’U­1\0²İl%.fî¶ŠŞË*´ê2«Ô¿ëüf)ëos¿Eñ”·.\\Q¥>­¦´%[ñŠãJx9ı<– +NhÚÒ#š¹ü€–§£b?­İÎéÀÑËš·r»š÷õÔGÛ©5Ä[ÕÓûõ[ªJ“ªß®¿¾şƒÉ!”œó¨èO•¿|U¹%êïŞîú¶y~ÛJEHisWdúöÓŸˆ!PE›k.Œ¤\0” 9>£[\09JÒ×\"à»–\"s²¾”í«ÑVu»(‰‡jf³^y6‹ç@ßÓ‘fñæŸPí¿ûÜ?‡®¨ÜsÓ´4/1@Šç\n·@Ûğ’L\Z‹VdAëkHxÌSV!kĞ[:İôÌ‰/t˜BúøåW:{í¥Î]¥Ó$Ç.Ô—Û®{à(y-Yë¸D\rU§×‚Ç¬ ùÿ2ÎSæ3•úæ(û•\Z·ï¡rû¤’ËäKÒ/h.+Ú§/? ğóœCÚ¼í˜öì=¦é‹ÒU¬êoÄŸºú°A½W÷o¯ÑHo×T¥XÆY«U/Òán*ğERÙÏUøƒjê<`¤zŒˆ€Òz«bã*şÃßxF-å(eZ1X˜@NóÏ\n7×|(\0Ÿ³RSåø’9bã\"X¸õ¸Ê1?^P>Æk¾üKŸ6¨œ™gÌ`]Z\ZŞ‘Ì²Ï¸Y‡ôy]\nÃ\"ÄŒ\\Äœ…PìøÖùÍSJ»¹cõ4`’š;U9”äÄtÈ¢¾U”k)¸7î~\0ptğÌ½øR§®¿Ô¥Û¯tírŸí»/å²ŠÉ¨uXş\ZÇ´M¬ûˆ8Å\nŞ³œ.£ñµÚªx¾·ß¬ÿ¾¯ßFõ:QÓCTºRm\r\nŠÓ¤¹[zš¿ö4–v\Z¯8©TJ]¼OÓ˜DZ°j6lØ£)Ó«àg?Ë…<¿ <ü^í¿”·âÊQá;åû¬®\nU®­¯µVİ¿»ª`ÅïUî»†jİ¯¿†y‡©nÇ!ú¢Y«ñ»\nó›rQfeW¤¼X®uckÆ’-Uu}¿®rTùS9ˆu®Ù÷1¦tMš\0XŠ”–ºÂ\n¿w¾k+¿x‹)ç”ŠLaAtÚ.•ş’\Z„øñ?@ìøù9Şá’ë-}S£1tõ˜–YEß\n¾õ»ÌÀ‰\rèpãF>g’¶ï:öDÏ>\'U~¡ó·\0áş+]€<z¡k*óµ\0a´~\'Õê{´Jî“1î{€ëeàÖn¿ƒÛñH/‡¾©÷—~ëã©°IóUó×Vr›¤ñ36+…Gãf¯<…µÂkÊü}JbeàÔ;4sé²£z«rÚãXªeD¥«*Gù\ZŒĞMÉ*ú´Öï\Zä¥Ä™‹4}Ár<~‚9@\nS§!¾ªJ°/× ­Š|óK6Mñ÷Öf§6p-€Õæ-µ¼ÃXšŒÚz—\Zâ#¼c[ vu*xš%‰E˜–-Áyßû‘â¯ò}ÙLıüç;N+qş)…2U¤àƒ²ÌCLÌóò—VÂ€Ÿ³ˆ\n¿Uğ„ö	ljŠG™?:È¬)1aÛá\'Ú\r˜/Úú¹ã‡Ï½Ğ‰/XòBo¿ÔU¼ãæƒ\0 ›öŞ¢ó\nrÇS¨=Ûéø¥g:yñ¹°}àÔSí9ÊÁ< º~@¾üH{?UPØ,µè¥6FiÏ‘{ê0ÀMŞÑÓ559@quŠ:gœÔÒš<‡ôvö6M•®i]»§x+2(à\\,•úœìèuê?†j÷ÎŞz¥›_éŞ³×zøüµî?}­‹7êbÇ¿uTÉÚ-Uè³:Ê]¾\Z±¿ póbµˆ+-rk“;Ş—¸¾]à>v²0øâbÅ^®…ùrWŠ?ó–\\ŸşªncR4vúyÅ­Vn£¸bœªr…¢œTØ•Ø5w1Ç#7AÃî¼ÒEäÜMbÃÕ—J\'>œGÎ+N]y¥#ç\0`\0Ìñó/tÚ2P.CW—ï¾’ËÉ«ÏtîÆsÜç|ö\\×îâ:÷^è\nré6Â~;ğa;Ğë%è…ÚöôRO÷(¥.Z©}Çhtğ8ùÇÎTÄ”5ŠŸ¹/9¡pOá)ÔIs÷+vF¦âgd¨i»A(,Åªi°…°hn®Â7?Ö:ã9íˆ—:sã•®>x­ÛO^éÎÓ—ºû„^ÖöCú¡M_•ú‘6È7¿*_E\Z‡eP6ÀZ¡æâxTb@Çã%–¹gµH™¨²+ªâw5T¨\"ŞXœP\\¬çE­â´XŠó¹ à ØÃw®zù§ñwPa~c`˜wP ºÅ¡+«K,£KL™§ÇÏ£g×zçáKİÀâ¯ßÃP´ÅŠs(ÿ(÷f^rğÜKaûıú<w`\0Óåòçº~ÿ…n=~¡;O^`‘/¹‹î<~©ÛÈõ‡\0Äo.‚â¥;èÌ]U\'#êÇìà¹ë÷tòÂcù¨¨‰³Èë×(&-S	³÷)0’xlkâ¬=\Z—ºEşã—¨\0ó.V´„k”—÷5lú·ö»ŠWà\\Ôe‚ÜM¸õÆÃ×ºõÿ\0™±xƒ¾ø£3¿±\n|ÕPyˆ99­wU…Ùñ,ÍÅK\\\nYí%¹É\\Ë×qbHãîÕuH•«ò£Şş*+†‡à9–Ûhàòtöî÷z§r#ÕëêÉo\0£81\n0,íuÚ\'–ä±ànç)¡.=‡êÕë7zùú•¿|©\'\0óŞ&6(ñø“×ğŒ&õK´\\ğš37²tzßÜ4Êºş€…b\0qÿòü¥¼x¥G/^è)òä9E<(¾»\rò·\0h+\rj4j£9+×:ÙÁ™KO5:,BÓç­QHÂ\"…\'­¥“»]±\01Ç€\'ç‡\'oÔŸ=¼¸!¨¤ ­ˆÇzsVízõµiËnæ\"®ëÖ£Wºûø•îsûOÍÒ¨ê.–w››ŒŸ¦/ÿìªBÔ$ùH\n|R@¾„‚ğËxğ\n\'%…‚Œºz!8A¼\\½ûÙê8l¤Æğ]AÚ3ß©6kƒ1Åëô¿ŒöÌ[ŒÊÊ’fôˆ7¥áe.ùŞÇ¡@kË%›#°;é/òn…ªzÎŞ¼1P^ëÙ+tˆÎîsİ7Í \rŞè	o1£³ ~Oº‹3xù½Ë‡ÏAÑä\nÁÍ¿Ğ£—/œ>ñRÏ\0èˆ?b|êwùMäøùú£ç\0]½sï‚Â.=Q›ÁÃ™\r<¢¨Ä€²”Îí&<e›âx(>fÚ6E%oPµ_˜ÅË›çŒ\\…UµfMmÌØªÍ™û\0ä’pQ³®§€ğ0î3Şã³yª{D’> Z/S«m’ZÊõÁwN{<‡Y8AÖ±XºK!«øœ7 W³îòuU›>XoÏPÍ_±‚îñ l%}÷ÓÏ\ZìªbïS›°BÅõmÀµã½(¥¡¯âx ‰ÔÅò‹KĞŸka+@9Ÿe[´SÒ7lq\0y\r ¯ğ”æ)Ù Û˜ÜCùfpwa¡È}»W~c:~ñ\Z@®@CW,n°ã*àÜ0´@Ú\0y‰¼zmbë—²\\ñ!€ôÉz×‡+Û¯Şy¦]şÕ±34)m±B\'-$;YçĞWdòzE§nõúºn×œT´DIÍ˜=[›7ïÒzÒà£§/s±x\'ñ˜‹|Âh Øç{€tÿÉku¦Š\0R²vs   =ÎÉô¬)Ç@,¸:©.ME§ßdAŞÉ²j(G©êêê¦şşq:xô¸\ZüÍ„SÁ’*\\¼´‚ÆÅ½y)ß;Ä!Š=çx¶(LÌ¼Äµ0Û\0â‹€ît‘ß²/á<.\nMÇA#¼@ş\n:3E?…e£|ÇĞØvÄİ˜ÈŒyî\\®Z\0Ë \\\\ëî“çzÂ\r—¯ŸòÊ¼å…sàÖ}¼4uŞ|,Åq’ë·èïGk×Áš³x“Â\'ÏWĞ„E\nˆœÉ+\0f¥Æìø^`ä-TDnşŞZÊce7íÕß;vîi1ƒÌÊ,É\\ø€<ÆK1Úv‡!şúô÷N*ùãŸÊK\rS°2õÅ»xâ¤º&F[Eë9Y›ÜµÌ÷*S­™úG­Ğˆ°$İ¸}WGÏW™ğ†Ü…4ÒÃ[|ÕÎV«!NX3ÑÅ•aÆ‘^˜y‰KŞlp­aYê²ï¾X§å€—T©Ö@¯ä•yÈ«×è9zC\0Áÿì¥Y@9ûÌ;øŞ~ûq¹J°v\0a4ú¹aúzu\0z¯#ö”á§–ıh\nnÆc^À›¤w—o«Û¨ ­ÊÈĞÊµ»5nÊBÅÏ–wìl@Y€Ç,SDâRyF¦êïv]4Ú?P’Ó´`i†–1´tõ6º|ÄÁ–v¾vòñ[²\\üç»ÿœål\0Ò¨Çp}Œ‡”¨ù»\n~^O¹Şg5€8ëm¡+\'«2P ”¬Jp\ncõô¡êtôÕ¿K<lE<zñZÇ/ğ$ØøILÛîÒ˜H\rô	×İ)o1”o Ø$WQ\nB‹AIÍó™â‰m±ŞaÔö¿Úç]P*¯+×nBõo×èì¥3>#m7å›¾lß3¨é‘å=Fmìc¿!†\0rƒ8b@ÜbÛÄ½qœyÄŞ¼áìå‡ú¢aK]¼vÑñ\"mÇÁ“th}•4k6óÔ{™»X¬	\02nš¼ÆÍ”y\0²HÑS—*&y‘â¦Ì×ÄÔyš1¥æ.^§y,İ¹B¶g€\\«^ïäïˆC[Ğivÿêı†­Iy©\0Äc§°´9\nÄIK\r[]hA4Ø:´9K}£ş40|‘fàÁ·—H¬¶±ã_»óH154h¬øE©IWV˜PÑ[&èLtˆS«äãxÖéÍøÖí…s­9eöã©k×mq\0yöÒâÈkâÊ¶x‚¼‚Â,N8`8Ã˜q¥!¦_ã*U¢Q×UKk¡¬ËxÊVj™•Õw­&X‘qH÷ìKeÅ&×îĞpÿxÅO™®-ÛO*™¹ŒÈIsäÇ“­\0âÇ6i¡b¦.QlòBML™¯ä‹4kázÍ]–7dµşHvÚk^rŸó^¸qOUi£” Õ^@\\­²·ÕèNAhmêÄóóóã{è¦+×»‡.Õ°ÙÚÊ´±mç$Ù	DÒÌ\Z«şÑêé¢kÒN)H\\2z2…“Z»à!Vı»ZRb€Ğ’ÏA|rÅğñÄ©3³<å[L°\0Ÿä¡0Ç<Ä¨f±s?q;™dv­år†Âï=•³ŒçmûéÙE¬ô²6¤eÚ5ÆË÷_+bâByÅÄP•¾Ñ…»ü†¢gÜ¤¹Š¼P«×fêÄÙÛJ¦À‹K^¬@d¬yÉtbÊ|Eì£“kB*YØ¤Y\Z7yš&O[¬éÛ‹½Mü¸a}Îso¹aŸQ²ıÀ)}Ó¼‡J“¬ò³r}HZZÒfáqÄ”ôeø®¬PCU~í£.´C<ÆÍ×âİ]<ä4òq¨Y¿e‡FG«¿o”z	Q‹~cT¼`;‡c5‡yˆúÅÕæØ­PŒ\"Ó¼”¶ŒO`±\0É¦¦Ù`üç)O\rêÆ<N­Bæjõ\nÉ”eº.‡)TÒ&9}ù©ÎS¤œ\'G¾ˆ’M,W¶ ‰ñ<ŸÏS´õÂ´ê:\0y­·_SÔØÒxføÖ³Rñœî?~Ê<Èy–È,SğøYò›‚¤É3:•)Ó™\nM˜§ğ„¹\nŠMæûdM&+Û¶÷¨îâi&æy7Ì”l@¬>Y¹i¾¦óûŞÏ­¨ĞiB–%Mu8ÜROe½+kúYÚkte\nÛ\Zˆ5Z»«wÈ\"Mš“áÔ5VQ¯;–L€}½œ¿zC^‘ñêãÆR¡`µì¥ßºà! £>£#â‡Íû-Cò~ü3€Ğ1.‘Ãœ,/íŞw”´Ÿdî”\rK,ãbû1û-Qy˜í„…«W\\Òƒ?Ikä<+Á²,¨ß´àîP  gÉ<ÇÀjHcïè¹„Ö2¦%@É7i6«?v±\nĞ\\‘ù€}w9e£€×Ø©r£~°\ZÂ;:M~Ä°¦P#å36AÁqS˜Ê½èGVãÜµî€’M‡w± »ğI3Óno«âÕUî©?l5ˆµL 	ÇjëE¬Z·b]_«ĞéOÕíAlˆX®íûÏüOQQÊ“l`³Úñ)³Õ—îC—á~ê:2H_×céOş·Éäğ€\\EHÛ…‰ÏÃ0è·ñx`¹à™\r~oKl5|“M‰YÇvÎGX¼¸ÿìS[Y:oeÃóÀ0q9{ı9ÖòïÓBÉŞyË\nÅlÄ¬¿…Y&vƒXóe&XrÖ÷· ´=‡.(*nšnŞ¼Šå=XV¥°Î+væàyÂQa“àæ	\Zš Ñ¡“440FÃ¢ÕÇİW£B¢56)•¾A7À.0û\"m´Ïzä}²),dh®|¬»Êû1=,ók*²ªÄI=`kÖ@…	ÄÖ—².o‰jjî>K£cÖ° îàZÆö&»à|ídæ1Ğ¦İû5Ğ;@üxª7T½Æà-#Uò()@ğÜ¢µÛ-F½Uñ\'}ÜÊ›k 9i·5ßQ*û,Åge†æ\rfP&æ÷Ÿ†Ñ”ŠVŒÃæNh°ÖÉÙ›Y-`+/›W@QÖÛ2O±æ˜•÷ğ¯Æš\rşjáà†~öÏ%CJÄ²\0Æ‰óÌ,ná¹¹§4WÙ\rIÔˆà‰\Z8^ƒıcÔß;B½ÜüÕß3D½G{«·»óû³\nÖøÔZ\rF]wL¬…‚Ø~ŸèD•ùéO¦r(ÿ§µ•«Â÷€B†c«?¨˜³Z–mÙLün–[æ;Z+5ÔlôÅÍÙã€pÇb•ã…ÖMÎª{,ëºËş[dr~ãÔc”¿z\0Fw<¤Ã`_uê¯Â%ğ¼œ</b”E˜·de5q_ªÜ6e`iwvO+Ós¯9ÀgyerY-§vî-«“m1Òhùª±µRĞ½Ë™«ÏuPl²ä£m_\0 Kxd´ebèæé¨½ºg‡×\\&¦¤Ì[¯õë7`åLÌ°B1qönOÎ@ÖkH`¬ÆD¤2NÔ¿^QêÊv<Z‡¡u?Hqi)TşYú\0y”=Z·½n“7v±z÷ˆ‰*Ë3è…XÌPˆ,+ïG?dÍŸ˜2lÃZ\'yÉ²,Û1a®ÃµDUEü¥v+X®É£Òj-i ½ÎVŠ)Ç\0²şÙş“gÕc¤Úòà\Z½1 ®=F´ïçP–k~b–ÍJ(­&£—¨bús6¿b€ĞŸ³z¦ÍYâd·›×o£5LÒ—lc7Ú·X}	_±öûyZÂ?.Xûİ@°î/–\n3ÄLù×Ù¾…‡=u[î~¾:—s.Ü¼e›µ}O&¾®™Ki\\JYØR¹EÎ¢ú«!Á‰êã\r\'{«yÿÜä0µ2ŠÅáĞ\rL”ğÀ,—5¯0K5^µÀn)ğU29»‘~îxÈ*Æ¤T¡/(7ËCs–„.ŠUd¢%9U:=%Æº¿–ıĞ¿hé©aX%yÅ±LØŠÏ›(Å¼Ò¼Ó˜À”ö\0‹¶z`ÑÚuæ©VÜÕ¤÷ıõ¯›z¸E*_ahÉb”Ñd¾ªÛ\'Ax.Ã0H}-³³%Bd`ÍÏñp5\Z-e\'*t#Œu+ÄÍ3ş3úkÜ«ËÑ3uüì#¼ôˆLë	íôgL!7˜\'¹öŒ¹§ŒOœ}ÖÕMJ[¨½‡ïëàIşäKWíWÚ¬%Ì ¡å¾›ôv†òı\0¿xõğS»¡~Ì*Õ_ı†ê×}ÕjàP¨À[Sç§ë®Å!À¶y—Sxê9Ã<Ïhó¢¥àÌ¨¹Œ¡Üx¨†m»«$3‰E ¬<PVn¦zUŠf­–áX÷ØxÜ\0±\n»<k|™ljî¹Hƒ×0kw›Z†óQ¼h÷gÆ‡Áa„vÏ6ïsš6Ã0™<c!“aCÔ û\0d°ZğÔW¿X/.+¨»æ/¥ï:…éw÷…L;³ŠÅâX®¢Qä{ûS€½ã³%G×‰¿W0Ş‹fôˆİÛc¢ëÜ÷}ú\n÷ns\"|vY›~@kiî¥oŞ¯Œ­GµyûíÜËª@¾Ø¹—%Ÿ;Oñ°Í)é8­­;Ojù\Z1,ÛBËckk÷+1u¥Rg­Ğ´…û‘”¡1Qñˆ8u&şÁì_íN=U»c7¤«\Ztí¡?ûT_`M™·‘7%œÕ}ç”±òœë7Ñ®ıçµÿ(éx\Zg3KN3vœ&;:©/m®’,;-øÅÏÊite5ÈÛ[kct]ó`¡ÙS´.LH•¨Ù^£«KÈj­áy¹\r]Æa­å\\ÛöœÕÃWX’tB+×ïe<Íò×ë:tê¦ö»Î5ÜPLâÕíĞUu:õÒßıG©3¤åªQ{ä)†âßR¥ÖªÖ;&k©©Õ!N\'›k ÈŸ¼ˆÇ1nëØÙû0Ë]^ÑqK{X­¿ûĞ-îñ\Zú¼ÊBôËÚÄc›x\" “µj›wñ8Bè¸8GSHt¬ÂcÆ+\"†W$OĞ¸‰“›¤‰	S”0)Iñ“¦h|B²¢ã§(>aª&\'MWâ6Qó¬ÓäÙ{áùyxÅx(ÉOz\rÕ÷z«VÇ^ú©s/nª§~ï=Hí»Q|ÅhRê¥L›«´éó4mâŒó5sÖŞaµq¡¦Í\\¨éÈ†­,4@ïÔ¨¯rµ›©«$]>¸Ü•ùS„k2 |Äk3§ÑÖk±ÆíÕ ±5/6}çX¨´™¤°Ï®ÁdçÁù§ÍšÏ6óùÈT~ßzàıÜ¥\'t;FÕÚtWy -ñıïªÒ9@Ÿw‹dí0sî–PØŠ3è³uçšÊ„¦s¼TîÏŸ¤´¹¼›k.F<‡÷sÍÔøÄ4dšâø¤š0e–\\‚\"Æ)(2F¡Q±\n‹€LTDl‚\"ã&‘ÎNÖ8šoñ’‡ÄÄ\'*nb’&\0Hâ”šÌü‚\'hæÜuŠ$ÿë“¤öCiQµÖô}ûHwıØ±‡~îú¯šô\Z];A>9\re¤ÍQªòŸLŸ›õ™1(”3s>»OÅ>ÿ\Z¤‹ç(+‘ÿ³,ÈñøÜ#7”a#@YÓq@ôVµó[&Ïñkn\Z\0¤òDê´ùšÊh’‚‚RP–ÉÔ”9š:u¶’y¡Ùd$™í)ÓªEŸA,¥Æ=‡é«–¬¦ì8Zeÿ¬÷Z3£HráLŠå´´Øj•¢ªËâïq¦(\nB—1è½†#¡Ñ§ t<6^şÑÈ8y‡ÈX¾Ïã6./É$`\"c9ÛãÆOV€Äˆ3N4/IÖÄISå” Yó·È/v%Ş1IÍşõT­ö½õŞñm‡^xI/ÕhÛƒÏxHŸÑê:&R¡ñ3¸ñÙ$§ÎVªƒL5… œTFó˜éxŒYñ¢•,ıQ%«Õeï@©ÑŒÉ%æA¬eaet~[ÄÆ{¹Xt`Ï“ç$%n6f¦ş$åJZÍšac>ÇÎaŠNIËù\r®‹’Œ0&M™©	ÛD³ÜÉixì2:Áa¼Ù¡‡:õâ\ZXâÚ~˜J4í«ò-G+gyæL¬é´o0:Õ~l‚ò\')Ô0B£Ç#ñ,™S \0ø…F*fò	‹’och\0Ãå2Áü(Ä@1û£ğC` è+Ş\0ÁK&$2NQ€L˜˜¬¡n¡NkhĞl5ˆ\'VV£×híYŸkc+V!v¦?úy«§G–7Ÿ›ÇòP@rŠÉ,À\05Å¬Ó”\r’yOÒ´¥*úu=•ƒ²šõõåm<­•³OI½GëÂ¦SóÂÛæĞ…ÁÖêï}§ÆC&«µ\'1m™R°üdÎ7j0ï¶s\'™òí\Z’ñö%%Ñ[KJsèxb‹¿\'§@Õ©Î½Îfzºa×şª¡µì£ªí¨ØÏmT¬~§¬¹‘bÄ4[Acóí´P\n—ıÒñ\n3èĞqã\ntdÏ³DÈ;40\"å\na¼^0LîÁrñÃMÂ£ùƒqŒQ€§\\*	á\0!ŒW¢(\Z×‡Ç0ÃS\"®SAqóQôdÕî2T?u¦:ö×¼¦jËNªÙ®›êvÄ#îj`nô¯Œ°ÂDSŠ#öy\Z–9EA…|g´aÖjŠ™ªw¾oì¼ëŞŞz»6oª«Ä£ÊKl9”e€Ø€œiU£3Özı2,E#Æ®ä<³s%rüÉÙçHæØFKSìZğ„I\0‘ “Ââg<ã<Äa\Z”ç‘ Ïÿj§úYÂÊš´¼_şÌD†Áã×Î¤ëB÷7k™éÇêŞ¤@\0F‘HøØ·à¼\"BD@°¼\0Å-0P.^Á¡ü \nÃuÂYoÇÄpã5\0Â{Ìk\"ÆMp¼&š€e1¼èl6Áj<£æóEè0@ß´í£Oš¶àQµôR/©Ùi°\ZötS«ÁŠI0…Ïpè #\0&ÓB™˜8Xjòt”•¥°¤©3?]E	¢UıGí‡ê›Vƒ•ç›V<?hoW€*˜BuÍMÑ–º00œ:¤Šê\rIPØ„xôÀÿœˆWfÍ¹Ø‹‡’c¹Gî5C]÷\Zãæ(2¤f\\ü$^Š@_ªz]úòÌû¯ú¶UÖ×W~[cVútÚï6›HbS»¤Æ?6l7D;`£Ï€¨±€%tí\Z.O¼Ã¯ˆ—„j£‹\'Şğ™?nd.ÉEÅÈ	öá«™÷8T6\Z‹3á\0ÔwèıÚ±¯ú¥¨ñ¿ş<¿×GyË|¬â_“rò ş{Y4İ²›j²ôó—^4îb\nH ín£Yb\"ÊÏg†ÌR±`&Ú0àì³Od\"7^Om)Ğ¢ç¨bÓş¼ \r¦sæËÇ¨Šg6\\ËĞN)]]…«ü¢_‡‘%&\Z%\0³ ­¬x•lÔ8@1q¤èzñŒb¦¦{i¨§·Üıäæë¯¶Ê‰W4TŸ˜Jc4^eëş®âŸ×ÔgvPÉ_:³Ğ‚…VûØIî‚Y©7úı¯mäûøÃ<a„ƒÀğ±è9J£Ğ¹éİgp`\0\nŠ`E?€Œ	¿à2~è‡šWğÇæ!ÁQ€Âi(†Gò,xVàƒÖz\r)ïàxŠÀéú}@„Ş®Æ´êÛeU®Rùq‚J?ÿÎ‹¿ZÜ«Ü—)ÜÜÅ@qÄ 8n2nr*ÀÏPd|‚c•ÉxÏT6qRŠF³f¸}¬şc¸^%[ì\'VÄÛÊõXl¼mËqÌ:mÅˆ-¸æùô’<ÿÑÍ—ó%Y¬˜ãPÖ$‹Ù´•à|øPñ\"jšÈuL˜8•89™kœLR3º‚ã\'ğİTE@Õ‰\\cùjÌÅğ¶¼ªÿ¨şè¡Ü¼ Æ2»B¬¢,]‰tÜR_ªùÚZÉıyaè¾cå\r0n¦oèÉ×	€FúÉ#(D£ü5Êß_.îÁY´üq#8&¾ìó7tq9óËö[Š<–t\r°¦B7SRV¨»G\nÏuôP®w+Hi81T‰““5¤ßå¯PE~ï –#b\0$‘MÌñ¤Õ“9V$ç\rÁûÆÎdM k›€çX7)q*1±=Ğ+T_7k¯Qd:íGŒSª-”ËZß–n:ÕßH	²®r´1ÊÔÔ{\rzÊ;jªbí˜œ-ßçXã‰\rFKã©«&qæ1¤òaxAì„Ÿ˜Èv™åDùGFkŒ¿±4’ø\Z®‘¾ê6bˆzMÌ*¨ü¼}èãßÚ+ï÷-@Şªøº¡<E‰iŞÕŸUWûA¹Ç0è(Xı=Ü5ÔËOƒğÂa~ş\ZèéIwÙ‹‡ÜÕ¨s{ıØ¼”jîâ¸£pPÌ’ìmâJ\0û-à€r\0Àq¡!ĞšyRz>•á•¼û0ÇÛåõAåJ™©[’İå-RB¹J¾§Æü±´TåF#©w&N˜/O\"°EÂ¥á\n…í\Z¢ár‹SFYf±l;õPyúXş‘	ú ~Wåa.\"¯Hr-l/‚)«štRí¼×ŠG\"r|@æÅj‘\ZCœÇë›”LÌ‹WèØ±€;šk·ÌÒê/î^áë«}{©ãàşê>tê´i®½»©y¯.ê6¨¿\ZuúG-zvUŸ¡Õ¾Ş1Œ•¬÷å•…ïV¯ŸuN<õÃêµÕiĞ0ucÚ•¿V~ŞûØ¢W_µĞ—ııÕ¤KıĞ¢9ÏRöQ«ÿu@¨Öô7}ık=ıĞ¬™jüÉ£×î\n1È\näğ\\6(ÿ×\n0ş³ı¸Ÿ³ŸÏFzªlUK=mÙ¿­, FÍšàÚVËÄë¯Î½U¤Yo\'-_£–S$Åâ	qXmqÂ²—‰(|–:!i*q…”:a2c’ã=)É©JJLÆ2CXØPW½‡Œá&\ryx‡ŞQñTâÓïÔ”¤!tÜO+W«	,[Öóµ¾ïçj¸·»ú»B!Õ}Ø`µìÓçK«÷È!òğ%F+™,	Á³ƒ0Î0şÆ[#¡ `8Š1öà~ÇZà\'vö9Zß5ùÚÊ©b•XAo¯ÁÍ‘WMÛ´…mÚdK=¼ôWÏ^$=íQ|\'\róõSáCôgÏ.ê<x ~ø»©>ªù­¾i\\_U~şY|ÿ#\0Òq0Êğp2-rchÊF?nâë-‘lÍúli1€£,ó&\n™J?ÖSşb¶Ê£°rçÍãÜ\\xL¬¢pû?»ôr<Äø¶péòPAi35AìˆŒ›À¶QH\"ôDŞ?qT‘àtŒRR¦XÛ&Aƒİ˜ÊSHÍÛvæ©Xh‰•ó¶–·ß7VQNÔQ\ZáãÉ9Ş§ÑÇ¢¸ëğdUk‡\nz\ZÊ“Á¼åó6  ¨\'\n²ø5Ãñ‹…¦8ß„	¤×ã˜;£IÂ¨â@Æ=¢™ï¢H\0Fûy«Ó€ú¬ÖO*Z¼¤Ê~Î:à¹”3W5Åj¢è:ÿ´Òç\r\Zªf³ßT«oÚµ³şêŞ…\'ÂšãÍ¿ëÛß\ZèËŸêèó:µõÁ·ßê×ö­T«YSıĞ”ç-Â!ÒÁ:Ì\"¼œü8ÜÉ(ÄF³ß°0\'MŸ‹3Ä\\¾şß­Õ÷kÙ©‡š´jIjgy÷X§¨lÖ–÷‚p±®¹8€ùE„)’ıQÔ28”ñ	‰XŞÅÇC)	jÓwîİSmû÷â:9ãŞ}•»Hqµ (³Ş•sÜo•«¤vĞÇ 1C „ú³´™+·\\¡^›§Pq®#RÃ||¸–X‚h¨ÂÆòpi1+*ÜñÔ ¥¨hnHzï§nÃÕ¸]5ïŞAtm£îCªßèáê5l˜\Z·m£]ºk¤—¯şl×Q¥Ë} Z?××ûU˜Ã;\n½[^Ÿ×¯«¯~ÿMÍºã::”÷w.jM×¶owµù·Z8‹½‡¨/kŒûŒ©€ÛOú»s72<¹Xdåàğ¨[@\0î‚›99q€GÆ:7«\n&%B|ñ»9ç³ïxóí’ÊU°(ÌŞRéÊŸâ–]yR¶­şîÀJE,Ç—v-PBÊUV½v	t#ôÏ€!jÙ½q%>7\nĞ(ß1úîÆúâç(¤\né§ÁîƒxçHm*YVÕy~=GÁRªÄ#t¿üÓÆÉL<ƒüy{ô9\"ë-Ú\0âjF3¯Ü¸/o”=ÊßGÃ}< ­¾\Z0f8€wåAÓê8°şjßR_ı\\[ïU‡H;«êïM(@ëª~‹¿T÷ÏfªõGSuîß_•ª§Š<O_ñ{¼ï³/Tzq­´·Ö!ïVøˆ~`…KUû“×ÖşİFïÕ!=®õ›\nÖøEymµıOÍT²Ak}úwjµ¶¬Âl©OÃ›şh­Ï›µSÍVTıC¼™Û&“°q¤ŸFø;+\róQdÁÁ¤·Yå½ÉÀÈ0\0Wpú®={«Y‡v€Ãşòå•“¥¢EJ•cÅÆÛ\0ôéaMÕjÜDåÍ½‹Újt[Kw¶PIx¿IA^ÑF_şÖD\r;vT½öíy´¯:£&íÛê³šÄ…‚ô¨òà¼Ê_öC•ûş7ıÚ¥«\Zvè¨ûMßÔaá\\\Zà.Ä,×Üù•/)oü¹>ª\n_7j¬²_W×;UP~^´Ÿ¿R5¡iùa½¦ªşW{Uàu³ïr•0ˆâ•?WŞÒªÀ{dÅËğ{ŠÏ9\n¾¥œŠ)×b÷—§ìGÊ·æùàKåşô{²¿ªÌÕ|®|_ÔQ®Ê?ò_*b;ÏÇßªH•ZÊ_™÷®°\n?ï§?(ï7\rUÈ­¨ÊËqj4äicŠÌanÒG†;Ap43ñ2ás ¿<¡4/@ñ ??gÿH8Û+ˆÎc„:õë¥?:wÖuªX…ŠÊ·*]VEßÿXÅÊ²Bã«TöËš¼yºJWıIe©tËüÔD~ûGşŞ^•È’>ı«‹ª`9_òÆÏ¿nŞAïTÿIEPZŞ¿ä\rÖ%%¸æãÙEJ2Wş	+à««ÌMy,¡šò½ÿ+C\0…åÈÂPška<·DyŞvı±òò–bß5ÖÛ¼ñ¡«K²‚¥$á•kôJÒN‹ÆeŞ»òs.%¾m ¢5\Z¨pUşKÂôî¿èãúUŒ)€â5ªHµŸy$¢¶Şâ~Šò›â,ª{ûÛ†*Çµ|Êñ*ó¨F…Ÿ›smÔa€üAƒ¿ôn­Æ*T½!¿ı]¥ñš²µ¹ÿúÍUå7ZLvTõfÿ}ñ0ÓoÜÙÛ®õÂCü42ÀÏ\'+\r†¾ØE†0šïFãú#}lÛJ(èb„·›|ƒ=ø‡F{‘‡Ÿ\'U®§üƒıäîãçÔRÍîÃàã¡ê5z¤º‘Zö>ê\"§1œéÒatQGğ÷!jİ ÖW¿·ï¬Æ-Úğ2²Õ¾ß ÒÏ!ê2p€ò÷ıù›îÃFñ~®ªıOgÕlÑAÕÿl«ªMZ¨F“Vú®YÕoİN¿şÓE¿2Ó°SoıbÂ@§Á#Ô¼ß0ıÓo\0¯õè§Nxa×Á#y#Ä(ƒ¸«/YÔ\0wyøú¨Ï°¡ê@¬iİ´wØp\r†òÚãºVhr¸‡›{º“ÄÈ-4˜ÅÃÕmÈ \no*ï\0^n0‚ûêün8:îKKf\0NĞŸûHÒÑ‡º¥¿››t™,Ìe¸—\'…Š\'€øXºçÏ¶7 @e@Œ¡•àìmùS‡\0 yùy9âHOË—¢2Dş!şd2ì3İå(Aá€KzBŸ,ˆãØßğ?Õ?¿\r$òa4¾ è)8Œı¡l“4ùp\\¯ €u\'~ 9g«}ÆwA0?ã;šëğáš0»F¶9®{€‚8–/ë„‡:Çô\r¢Ãj¬àM¢¡¤Ç0\0çÁuå||7*›\rFù¢d’„1¶\"Ñ²8ûép Eß¿£Fi0ŠIÚÜßİ í¸£Èò<5ÀÍ]£<†ª÷ˆQNJÜ{¤qlËF°ÊĞ\0{àh7¹Al\0(óâ$\\ÔpÒÄp¤·§úq DnjÉÍ›-ı3ÚrÇkÜı}5\Z¯ğææ¹ñ1lû¢o>{2Z@õÀsøÎ”9‚öHßK$Œú¼°P·ıêô\n2€P\" ùó»@€0%ñu“\nóôr`\\uŠ!®ù³Ÿ¿‰k™T°cŞ\näÚıîrh¤y~ 	Jˆ“†XïÊ“ss>,”óyùr.„sõÄëí\Z¹Ÿ?®İÎRüP¯1¤ÜîxË@\0äaŞ5†6@\0Ş¿XşHw¼Èƒ¿­¿ºv¼ƒ¿·ßt2”¬k(‰	2f´şöU Áhˆ‘\0\0\0\0IEND®B`‚','2014-10-15','RAY@HOT','AV NAVAL',7,'415263','992456321','PROFESOR','40494250','1234','NO HAY',1,17,3,'2014-10-15','2014-10-15',0);

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

insert  into `tb_vacaciones`(`DocumentoDNI`,`numeroVacaciones`,`vacaAsignado`,`periodo`) values (4419984,0,0,'  \r'),(4828545,0,0,'  \r'),(6116962,0,0,'  \r'),(6278227,0,0,''),(41655881,0,0,''),(6297816,0,0,'  \r'),(6532908,30,4,'PERIODO 2014'),(6653459,0,0,''),(6657651,0,0,'  \r'),(7240310,0,0,'  \r'),(8053807,0,0,'  \r'),(9051193,0,0,''),(9462708,0,0,''),(9881369,0,0,'  \r'),(9914445,30,3,'PERIODO MARZO 2013 - MARZO 2014'),(10181885,0,0,''),(10298901,0,0,''),(10337864,30,1,'PERIODO MARZO 2013- MARZO 2014'),(10429052,0,0,'  \r'),(10446459,0,0,'  \r'),(10581459,0,0,'  \r'),(10660033,0,0,''),(10862003,0,0,''),(16421035,0,0,'  \r'),(18130284,30,6,'PERIODO FEBRERO 2013 - FEBRERO 2014'),(18160869,0,0,''),(20018138,0,0,'  \r'),(25076857,0,0,''),(21482518,0,0,'  \r'),(21493631,30,7,'PERIODO FEBRERO 2013 - FEBRERO 2014'),(21525483,30,17,'PERIODOP MARZO 2013 - MARZO 2014'),(23878057,134,3,'HASTA 2014'),(23800131,0,0,''),(23800488,30,21,'PERIODO MARZO 2013 - MARZO 2014'),(23801395,0,0,''),(23801500,0,0,''),(23802283,0,0,'  \r'),(23805471,0,0,''),(23807045,0,0,'  \r'),(23807048,0,0,'  \r'),(23809146,0,0,''),(23809189,0,0,'  \r'),(23809284,0,0,''),(23809916,0,0,'  \r'),(23812080,0,0,'  \r'),(23812763,0,0,''),(23814024,0,0,''),(23817170,0,0,'  \r'),(23820283,0,0,'  \r'),(23826617,0,0,''),(23821785,0,0,''),(23821811,0,0,'  \r'),(23822775,0,0,''),(23822992,0,0,'  \r'),(23823999,0,0,''),(23825114,0,0,''),(23829815,0,0,'  \r'),(23832060,0,0,''),(23833711,0,0,'  \r'),(23833930,30,2,'PERIODO FEBRERO 2013 - FEBRERO 2014'),(23834348,0,0,''),(23835080,0,0,''),(23837122,0,0,''),(23837511,30,15,'PERIODO MARZO 2013 A MARZO 2014'),(23838012,0,0,'  \r'),(23838833,0,0,'  \r'),(23839195,0,0,''),(23839304,0,0,'  \r'),(23839452,0,0,''),(23839766,0,0,''),(23933568,0,0,''),(23840170,0,0,'  \r'),(23842353,0,0,''),(23842708,30,4,'PERIODO MARZO 2013 - MARZO 2014'),(23844963,0,0,''),(23845507,0,0,'  \r'),(23846644,0,0,''),(23848291,0,0,''),(23848348,0,0,''),(23848994,0,0,''),(23849044,30,2,'PERIODO FEBRERO 2013 - FEBRERO 2014'),(23849808,0,0,''),(23849990,0,0,'  \r'),(23850050,0,0,''),(23850375,0,0,''),(23850614,0,0,''),(23851528,0,0,''),(23851575,0,0,'  \r'),(23851623,0,0,'  \r'),(23853491,30,7,'PERIODO FEBRERO 2013 - FEBRERO 2014'),(23854087,0,0,'  \r'),(23854175,0,0,'  \r'),(23855054,0,0,''),(23855085,0,0,''),(23856244,0,0,''),(23856628,0,0,'  \r'),(23856666,0,0,''),(23856695,30,10,'PERIODO MARZO 2013 - MARZO 2014'),(23856990,0,0,'  \r'),(23857379,0,0,''),(23857467,30,28,'PERIODO FEBRERO 2013 - FEBRERO 2014'),(23857536,0,0,'  \r'),(44261967,0,0,''),(23859066,0,0,'  \r'),(23859472,0,0,''),(23859550,0,0,''),(23859835,0,0,'  \r'),(23860121,0,0,''),(23860482,0,0,'  \r'),(23861067,0,0,'  \r'),(23862645,0,0,'  \r'),(23862806,30,6,'PERIODO FEBRERO DEL 2013 -FEBRERO DEL 2014'),(23863241,0,0,'  \r'),(23863372,0,0,''),(23863524,0,0,'  \r'),(23863597,0,0,''),(23863714,0,0,'  \r'),(23863905,0,0,'  \r'),(43479934,0,0,''),(23865597,0,0,''),(23867063,0,0,'  \r'),(23879698,0,0,''),(23868860,0,0,'  \r'),(23869476,0,0,'  \r'),(23870134,0,0,'  \r'),(23870182,30,2,'PERIODO MARZO 2013 - MARZO 2014'),(23870494,0,0,''),(23870870,30,30,'PERIODO ENERO 2013-ENERO 2014'),(23872152,0,0,''),(23872524,0,0,'  \r'),(23872843,0,0,'  \r'),(23873200,12,3,'PERIODO 2013'),(23873437,0,0,'  \r'),(23873492,0,0,'  \r'),(23874632,0,0,'  \r'),(23875476,0,0,''),(23875569,0,0,''),(23879794,0,0,''),(23879796,0,0,''),(23879968,0,0,'  \r'),(23880755,0,0,'  \r'),(40449752,0,0,''),(23884920,0,0,''),(23885012,30,30,'PERIODO ABRIL 2012 A ABRIL 2013'),(23885445,0,0,''),(23885575,0,0,''),(23886258,0,0,'  \r'),(23886891,0,0,''),(23889940,0,0,''),(23893382,0,0,'  \r'),(23893845,0,0,'  \r'),(23893991,0,0,''),(23894080,0,0,''),(23894100,0,0,'  \r'),(23894215,0,0,''),(23894463,0,0,''),(23897158,0,0,''),(23899167,0,0,'  \r'),(23899332,0,0,'  \r'),(23899816,30,30,'PERIODO ENERO 2013 - ENERO 2014'),(23900147,0,0,'  \r'),(23900318,0,0,''),(23900426,0,0,'  \r'),(23901191,0,0,'  \r'),(23904081,0,0,''),(23904621,0,0,'  \r'),(23906171,0,0,''),(23906917,0,0,''),(23912111,0,0,'  \r'),(23912233,0,0,''),(23912843,0,0,'  \r'),(23914072,0,0,''),(23914779,0,0,''),(23914888,0,0,''),(23916032,0,0,''),(23917811,30,20,'PERIODO MARZO 2013 - MARZO 2014'),(23917937,0,0,'  \r'),(23919961,0,0,'  \r'),(23920575,0,0,''),(23921213,0,0,''),(23921848,0,0,''),(23922625,0,0,'  \r'),(23924387,0,0,''),(23924634,0,0,''),(23925281,0,0,'  \r'),(23925366,0,0,'  \r'),(23925786,0,0,''),(23926482,0,0,'  \r'),(23926753,0,0,''),(23927126,30,7,'PERIODO FEBRERO 2013 - FEBRERO 2014'),(23928174,0,0,'  \r'),(23928834,0,0,'  \r'),(23929048,0,0,'  \r'),(23924599,0,0,''),(23929081,0,0,''),(23930057,0,0,'  \r'),(23930697,0,0,''),(23932495,0,0,''),(23932635,0,0,'  \r'),(23932642,0,0,'  \r'),(23933049,0,0,'  \r'),(23933128,0,0,'  \r'),(23934096,0,0,''),(23934148,0,0,''),(23935727,0,0,''),(23936260,0,0,''),(23936639,0,0,''),(23937531,0,0,''),(23939757,0,0,'  \r'),(23940361,0,0,''),(23940613,0,0,'  \r'),(23941435,0,0,'  \r'),(23942506,0,0,'  \r'),(23942546,0,0,''),(23942957,0,0,'  \r'),(23943349,0,0,'  \r'),(23944718,0,0,'  \r'),(23945248,0,0,'  \r'),(23948312,0,0,'  \r'),(23948502,0,0,'  \r'),(23948783,0,0,'  \r'),(23949473,0,0,'  \r'),(23950564,0,0,'  \r'),(23950646,0,0,''),(42109575,0,0,''),(23951315,0,0,''),(23951873,30,3,'  \rPERIODO 2013'),(23953114,30,2,'PERIODO MAYO 2013 - MAYO 2014'),(23953201,0,0,''),(23953354,30,1,'PERIODO FEBRERO DEL 2013 - FEBRERO DEL 2014'),(23953425,0,0,''),(23955481,0,0,''),(23956011,0,0,'  \r'),(23956100,0,0,''),(23957289,0,0,''),(23957375,0,0,'  \r'),(23957592,0,0,''),(23958541,30,1,'PERIODO MARZO 2013 - MARZO 2014'),(23959834,30,15,'PERIODO FEBRERO 2013 - FEBRERO 2014'),(23959906,0,0,'  \r'),(23960333,0,0,''),(23960905,0,0,''),(23961402,0,0,'  \r'),(23962443,30,3,'PERIODO MARZO 2013 - MARZO 2014'),(23962652,0,0,'  \r'),(23963052,30,5,'PERIODO FEBRERO 2013 - FEBRERO 2014'),(23963478,0,0,''),(23963716,0,0,''),(23964620,0,0,''),(23964865,0,7,''),(23965038,0,0,'  \r'),(23966429,0,0,''),(23966554,0,0,''),(23967129,0,0,'  \r'),(23975470,0,0,'  \r'),(23975891,0,0,''),(23975959,0,0,''),(23976776,0,0,'  \r'),(23976986,0,0,''),(23979031,0,0,''),(23979173,0,0,''),(23979710,0,0,'  \r'),(23979862,30,6,'PERIODO FEBRERO 2013-FEBRERO 2014'),(23981116,30,5,'PERIODO MAYO 2013 -  MAYO 2014'),(23981403,0,0,'  \r'),(23981481,0,0,'  \r'),(23983419,0,0,''),(23984191,0,0,''),(23984424,0,0,'  \r'),(42339070,0,0,''),(23985278,0,0,'  \r'),(23986877,0,0,'  \r'),(23987508,0,0,'  \r'),(23988433,0,0,''),(23988677,0,0,'  \r'),(23989605,0,0,'  \r'),(23989937,0,0,''),(23990485,0,0,'  \r'),(23990623,0,0,'  \r'),(23990959,0,0,''),(23991108,30,8,'PERIODO FEBRERO 2013 - FEBRERO 2014'),(23992095,0,0,''),(23878336,0,0,''),(23992949,0,0,'  \r'),(23993157,0,0,'  \r'),(23993526,0,0,''),(23993646,0,0,'  \r'),(23993841,30,8,'PERIODO MARZO 2013 - FEBRERO DEL 2014'),(23994341,0,0,'  \r'),(23994525,0,0,'  \r'),(23995068,0,0,''),(23995919,0,0,'  \r'),(23996964,0,0,''),(23998314,0,0,'  \r'),(23998517,0,0,'  \r'),(23999800,0,0,''),(23999918,0,0,'  \r'),(42418451,0,0,''),(24002518,0,0,'  \r'),(24003935,0,0,''),(24003998,0,0,'  \r'),(24004287,0,0,''),(24004667,0,0,''),(24005106,0,0,'  \r'),(24005284,0,0,''),(24005306,0,0,'  \r'),(24005328,0,0,'  \r'),(24005487,0,0,''),(24005828,0,0,'  \r'),(24006362,0,0,''),(24007216,0,0,'  \r'),(24293282,0,0,''),(24360716,0,0,''),(24362011,0,0,'  \r'),(24367534,0,0,'  \r'),(24381344,0,0,'  \r'),(24382681,0,0,''),(24389018,0,0,''),(24389023,0,0,''),(24461902,0,0,'  \r'),(24474000,0,0,'  \r'),(24485615,0,0,''),(24486579,0,0,'  \r'),(24487462,0,0,'  \r'),(24487931,0,0,''),(24489735,30,3,'PELRIODO FEBRERO 2013 - FEBRERO 2014'),(24569848,0,0,'  \r'),(24571432,0,0,''),(24668255,0,0,''),(80187057,0,0,''),(24680599,0,0,''),(24683247,0,0,''),(24706467,0,0,''),(24705625,0,0,'  \r'),(24706529,0,0,'  \r'),(24711300,0,0,'  \r'),(24712848,0,0,'  \r'),(43098387,0,0,''),(24718085,0,0,'  \r'),(24718171,0,0,'  \r'),(24719125,0,0,'  \r'),(24802976,0,0,'  \r'),(24867677,0,0,''),(24893608,0,0,'  \r'),(24944600,0,0,'  \r'),(24947699,0,0,'  \r'),(24969877,0,0,'  \r'),(24987520,0,0,'  \r'),(24991387,0,0,''),(24991496,0,0,''),(24994792,0,0,''),(41614797,0,0,''),(25000476,0,0,'  \r'),(25000575,0,0,''),(25000578,0,0,''),(25001877,30,4,'PERIODO FEBRERO DEL 2013 A FEBRERO DEL 2014'),(25002108,0,0,'  \r'),(25002271,30,15,'PERIODO MARZO 2013 - MARZO 2014'),(25003313,0,0,''),(25003592,0,0,''),(25123498,0,0,''),(25182353,0,0,'  \r'),(25182368,0,0,''),(25198801,0,0,'  \r'),(25200382,0,0,'  \r'),(25210650,0,0,''),(25304708,0,0,''),(25310609,0,0,''),(25311890,0,0,''),(25327097,0,0,''),(28225756,0,0,'  \r'),(28266101,0,0,'  \r'),(29273550,0,0,'  \r'),(29419271,0,0,''),(29426388,0,0,'  \r'),(29802324,0,0,''),(31024707,0,0,''),(42152799,0,0,''),(31045391,0,0,'  \r'),(40062893,0,0,''),(40067774,0,0,'  \r'),(40069045,0,0,'  \r'),(40085278,0,0,''),(40105057,0,0,''),(40117609,0,0,'  \r'),(40130403,0,0,'  \r'),(40135998,0,0,''),(40139585,0,0,''),(40271128,0,0,'  \r'),(40281249,0,0,'  \r'),(40326499,0,0,''),(40335500,0,0,'  \r'),(40376984,0,0,'  \r'),(23951659,0,0,''),(40394328,0,0,'  \r'),(40398149,0,0,'  \r'),(40416158,0,0,'  \r'),(40429086,0,0,''),(40431624,0,0,'  \r'),(40431873,0,0,'  \r'),(40444653,0,0,'  \r'),(40447243,0,0,''),(40448617,0,0,'  \r'),(40448629,30,2,'PERIODO FEBRERO 2013 - FEBRERO 2014'),(40467677,0,0,'  \r'),(40500877,0,0,''),(40519915,0,0,'  \r'),(40536077,0,0,'  \r'),(40562204,0,0,''),(40591696,52,7,'PERIODO ABRIL 2012 A ABRIL 2013, ABRIL 2014'),(40624224,0,0,'  \r'),(40662607,0,0,'  \r'),(40695540,0,0,'  \r'),(40715748,0,0,''),(40728170,0,0,'  \r'),(40736088,0,0,''),(40744756,0,0,'  \r'),(40773038,0,0,''),(40773637,0,0,'  \r'),(40813246,0,0,'  \r'),(40822252,0,0,''),(40824974,0,0,'  \r'),(40875887,0,0,''),(40876488,0,0,''),(40880978,0,0,''),(23856153,0,0,''),(40899251,0,0,'  \r'),(41715079,0,0,''),(40910084,0,0,''),(40931699,0,0,'  \r'),(40939798,30,4,'PERIODO FEBRERO 2013 - FEBRERO 2014'),(40952413,0,0,'  \r'),(40969380,0,0,''),(40975093,0,0,'  \r'),(41053977,0,0,''),(41107088,0,0,''),(41107103,0,0,'  \r'),(41108525,0,0,''),(41112489,0,0,''),(41119178,0,0,'  \r'),(41125241,0,0,''),(41129986,0,0,''),(41134571,0,0,''),(41139026,0,0,'  \r'),(41153489,0,0,''),(41154631,0,0,'  \r'),(41157398,0,0,'  \r'),(45430985,0,0,''),(41158850,0,0,'  \r'),(41160584,0,0,''),(41178911,0,0,'  \r'),(41230182,0,0,''),(41253433,0,0,''),(41266089,0,0,''),(41346216,0,0,''),(41374815,0,0,'  \r'),(41400140,0,0,'  \r'),(41407885,0,0,''),(41441595,0,0,''),(41447660,0,0,'  \r'),(41555209,0,0,'  \r'),(41556313,0,0,''),(45073834,0,0,''),(44775000,0,0,''),(41596776,0,0,''),(41626705,30,2,'PERIODO ENERO 2013 - FEBRERO 2014'),(41655522,30,22,'PERIODO MARZO 2013 - MARZO 2014'),(41659380,0,0,'  \r'),(41703486,0,0,'  \r'),(41737113,0,0,'  \r'),(41746442,0,0,'  \r'),(41755802,0,0,''),(41774812,0,0,''),(41805881,0,0,'  \r'),(41818966,0,0,'  \r'),(41833740,0,0,'  \r'),(41839955,0,0,''),(41848253,0,0,'  \r'),(41848464,0,0,'  \r'),(41892681,0,0,''),(41900763,0,0,'  \r'),(41929708,0,0,'  \r'),(41962222,0,0,'  \r'),(41972471,0,0,''),(41978152,0,0,'  \r'),(41997069,0,0,''),(42044551,0,0,''),(42055572,0,0,''),(42155935,0,0,''),(42162355,0,0,'  \r'),(42169218,0,0,'  \r'),(42172701,30,4,'PERIODO FEBRERO 2013- FEBRERO 2014'),(42246849,0,0,''),(42257499,30,1,'  \rPERIODO 2013'),(42266292,0,0,'  \r'),(42268578,0,0,'  \r'),(42279175,0,0,'  \r'),(42316871,0,0,'  \r'),(42319761,0,0,''),(42326176,0,0,'  \r'),(42329767,0,0,''),(42340684,0,0,'  \r'),(42352136,0,0,'  \r'),(42386687,0,0,'  \r'),(42404455,0,0,''),(42561556,0,0,'  \r'),(42563846,0,0,'  \r'),(42586246,0,0,''),(42617932,0,0,'  \r'),(42699722,0,0,'  \r'),(42700054,0,0,'  \r'),(42708755,0,0,'  \r'),(42839707,0,0,'  \r'),(42962461,0,0,''),(42990357,0,0,'  \r'),(43001254,30,7,'PERIODO FEBRERO 2013 - FEBRERO 2014'),(43066411,30,7,'PERIODO FEBRERO 2013 - FEBRERO 2014'),(43068560,0,0,''),(43076569,0,0,'  \r'),(43081298,0,0,'  \r'),(43165165,0,0,'  \r'),(43199483,0,0,'  \r'),(43206589,0,0,'  \r'),(43371391,0,0,''),(43376395,0,0,'  \r'),(43420602,0,0,''),(43460993,0,0,'  \r'),(43464494,0,0,''),(43556526,0,0,'  \r'),(43556537,0,0,'  \r'),(43575685,0,0,'  \r'),(43700848,0,0,''),(23920861,0,0,''),(43899141,0,0,'  \r'),(43990456,0,0,'  \r'),(44137987,0,0,'  \r'),(44151319,0,0,'  \r'),(44159824,0,0,'  \r'),(23867830,0,0,''),(44254412,0,0,''),(44261190,0,0,'  \r'),(44283464,0,0,'  \r'),(44377601,0,0,''),(44394207,0,0,'  \r'),(44414416,0,0,''),(44434172,0,0,''),(44463683,0,2,''),(23943964,0,0,''),(44607400,0,0,''),(44706978,0,0,''),(44773977,0,0,'  \r'),(44783968,0,0,''),(40065151,0,0,''),(44853226,0,0,''),(44858334,0,0,'  \r'),(44915833,0,0,'  \r'),(24004863,0,0,''),(45026845,0,0,'  \r'),(45112960,0,0,''),(45260928,0,0,''),(45381628,0,0,''),(45472600,0,0,''),(45547865,0,0,'  \r'),(45597650,0,0,''),(45647210,0,0,''),(45647228,30,15,'PERIODO ENERO 2013 - ENERO 2014'),(45856758,0,0,''),(45873938,0,0,'  \r'),(45880577,0,0,'  \r'),(45963802,0,0,''),(46027895,0,0,''),(46064527,0,0,'  \r'),(46116086,0,0,'  \r'),(46119429,0,0,'  \r'),(46172398,0,0,'  \r'),(46306701,0,0,''),(46319836,0,0,''),(46356145,0,0,'  \r'),(46393989,0,0,''),(46600148,0,0,''),(46616552,0,0,''),(47032505,0,0,''),(47151664,0,0,'  \r'),(47189981,0,0,'  \r'),(47404645,30,2,'PERIODO MARZO 2013 - MARZO 2014'),(47817197,0,0,'  \r'),(48543507,0,0,'  \r'),(71330030,0,0,''),(72238881,0,0,'  \r'),(72541160,0,0,''),(80101484,0,0,'  \r'),(80168162,0,0,''),(80175543,0,0,'  \r'),(80630511,0,0,'  \r'),(23880331,0,0,''),(20076341,0,0,''),(40089682,0,0,''),(23985401,0,0,''),(23943018,0,0,''),(24003726,0,0,''),(23829448,0,0,''),(40803578,0,0,''),(23845958,0,0,''),(24487942,0,0,''),(40672071,0,0,''),(40026870,0,0,''),(42713949,0,0,''),(40720799,0,0,''),(23936679,0,0,''),(23989969,0,0,''),(31043438,0,0,''),(23978429,0,0,''),(24677678,0,0,''),(23931157,0,0,''),(43932196,0,0,''),(23870954,0,0,''),(47541224,0,0,''),(23974915,0,0,''),(40119336,0,0,''),(23880228,0,0,''),(23884420,0,0,''),(23949981,0,0,''),(44455120,0,0,''),(23952293,0,0,''),(41158845,0,0,''),(25001815,0,0,''),(45525206,0,0,''),(41834758,0,0,''),(44441297,0,0,''),(23979788,0,0,''),(42369620,0,0,''),(45326006,0,0,''),(41397791,0,0,''),(23930755,0,0,''),(24461379,0,0,''),(23954659,0,0,''),(24000154,0,0,''),(42025212,0,0,''),(41608491,0,0,''),(43224761,0,0,''),(44023841,0,0,''),(23908489,0,0,''),(41158882,0,0,''),(23845416,0,0,''),(45067407,0,0,''),(40805856,0,0,''),(23886854,0,0,''),(45041082,0,0,''),(23856066,0,0,''),(43925255,0,0,''),(23846028,0,0,''),(23979115,0,0,''),(23890047,0,0,''),(23947640,0,0,''),(24970709,0,0,''),(23846851,0,0,''),(40213980,0,0,''),(23945012,0,0,''),(23806217,151,0,'PERIODO ACUMULADO DE AÃ‘OS PASADOS'),(23869318,0,0,''),(44174700,0,0,''),(46137182,0,0,''),(23837340,30,11,'PERIODO MARZO 2013 A MARZO DEL 2014'),(23977649,0,0,''),(45078022,0,0,''),(23979343,0,0,''),(23830014,0,0,''),(23863654,0,0,''),(40480847,0,0,''),(23810953,0,0,''),(23845765,0,0,''),(25000633,0,0,''),(23958834,0,0,''),(6804598,0,0,''),(42622739,0,0,''),(23920269,0,0,''),(40706313,30,15,'PERIODO FEBRERO 2013 - FEBRERO 2014'),(23849143,0,0,''),(23872834,0,0,''),(25000447,0,0,''),(23860250,0,0,''),(44858339,0,0,''),(23975777,0,0,''),(23862321,0,0,''),(23979923,0,0,''),(42821783,0,0,''),(41605507,0,0,''),(42721866,0,0,''),(23922390,0,0,''),(23833799,0,0,''),(41053936,0,0,''),(23827704,0,0,''),(44373864,0,0,''),(23850926,0,0,''),(45918490,0,0,''),(23918058,0,0,''),(23919212,0,0,''),(24981017,0,0,''),(44730967,0,0,''),(23811154,0,0,''),(44082269,0,0,''),(42451718,0,0,''),(40148385,0,0,''),(23938389,0,0,''),(23929959,0,0,''),(23937989,0,0,''),(23873104,0,0,''),(24000700,0,0,''),(23886743,0,0,''),(23929647,0,0,''),(41655489,0,0,''),(41841956,0,0,''),(42842615,0,0,''),(23917795,0,0,''),(44010840,0,0,''),(41524292,0,0,''),(23863792,0,0,''),(23922386,0,0,''),(44362909,0,0,''),(23957934,0,0,''),(23946116,0,0,''),(23882221,0,0,''),(23858394,0,0,''),(23828756,0,0,''),(40359718,0,0,''),(23891830,0,0,''),(23947125,0,0,''),(31039247,0,0,''),(23843416,0,0,''),(23857134,0,0,''),(23929061,0,0,''),(23954143,0,0,''),(23833790,0,0,''),(25183555,0,0,''),(24712971,0,0,''),(515557,0,0,''),(23864618,0,0,''),(23884955,0,0,''),(2365417,0,0,''),(41718916,0,0,''),(43157424,0,0,''),(40429084,0,0,''),(25000324,0,0,''),(23842944,259,2,'2014'),(23863585,0,0,''),(40155948,0,0,''),(41655856,0,0,''),(41285850,0,0,''),(41785041,0,0,''),(23834075,0,0,''),(43657317,0,0,''),(40757754,0,0,''),(23835066,0,0,''),(46081755,0,0,''),(24005691,0,0,''),(45156437,0,0,''),(23811862,0,0,''),(40739751,0,0,''),(23894332,0,0,''),(43648338,0,0,''),(25138944,0,0,''),(45636005,0,0,''),(43872818,0,0,''),(24005516,0,0,''),(23894820,0,0,''),(40341799,0,0,''),(40705272,0,0,''),(47018112,0,0,''),(23884652,0,0,''),(40238131,0,0,''),(41659364,0,0,''),(23876504,0,0,''),(24719072,0,0,''),(40902287,0,0,''),(40291457,0,0,''),(80668196,0,0,''),(45531623,0,0,''),(46024827,0,0,''),(40411794,0,0,''),(42140802,0,0,''),(41994825,0,0,''),(45504652,0,0,''),(43099809,0,0,''),(41655896,0,0,''),(40250111,0,0,''),(46397715,0,0,''),(41732162,0,0,''),(41053932,30,17,'PERIODO ENERO 2013- ENERO 2014'),(40775890,0,0,''),(105912,30,1,'PERIODO ENEO 2012 - ENERO 2013'),(9611010,0,0,''),(25074107,0,0,''),(23933974,0,0,''),(23856415,0,0,''),(44812108,0,0,''),(42527810,0,0,''),(44174692,0,0,''),(23996128,145,1,'HASTA MAYO 2014'),(42234635,0,0,''),(24000662,0,0,''),(46461601,0,0,''),(80029948,0,0,''),(42497818,0,0,''),(23934193,0,0,''),(23950633,0,0,''),(46589702,0,0,''),(23828341,0,0,''),(40697267,0,0,''),(40033248,0,0,''),(23846172,0,0,''),(41490073,0,0,''),(44602152,0,0,''),(40335528,0,0,''),(23856883,0,0,''),(41154634,0,0,''),(23880635,0,0,''),(40260816,0,0,''),(42318041,0,0,''),(42334618,0,0,''),(41152096,0,0,''),(43612754,0,0,''),(44975687,0,0,''),(42386649,0,0,''),(23998684,0,0,''),(45079834,0,0,''),(43070495,0,0,''),(42851352,0,0,''),(42924288,0,0,''),(43924452,0,0,''),(45386696,0,0,''),(40234953,0,0,''),(43099822,0,0,''),(46283541,0,0,''),(44417100,0,0,''),(40708011,0,0,''),(23954544,0,0,''),(40822248,0,0,''),(23999852,0,0,''),(46697749,0,0,''),(44887101,0,0,''),(24865193,0,0,''),(45239734,0,0,''),(42109372,0,0,''),(42130283,0,0,''),(43065558,0,0,''),(46309995,0,0,''),(42480322,0,0,''),(29689235,0,0,''),(42988511,0,0,''),(46357121,0,0,''),(40377844,0,0,''),(42723935,0,0,''),(44826929,0,0,''),(40744737,0,0,''),(40389201,0,0,''),(43774943,0,0,''),(23880695,0,0,''),(23868169,0,0,''),(23916638,0,0,''),(40494250,0,0,''),(45426041,0,0,''),(23942802,0,0,''),(23929291,0,0,''),(25003203,0,0,''),(46957119,0,0,''),(47090000,0,0,''),(70577292,0,0,''),(43744646,0,0,''),(23975383,0,0,''),(45913756,0,0,''),(40164682,0,0,''),(24495417,0,0,''),(23860560,0,0,''),(23843044,0,0,''),(23826766,0,0,''),(24484140,0,0,''),(23811389,0,0,''),(42927158,0,0,''),(40270876,0,0,''),(23929546,0,0,''),(23817252,0,0,''),(23879352,0,0,''),(24660325,0,0,''),(42766935,0,0,''),(23995548,0,0,''),(23901417,0,0,''),(23872250,0,0,''),(24001413,0,0,''),(4749301,0,0,''),(41597031,0,0,''),(80034579,0,0,''),(23823493,0,0,''),(24462788,0,0,''),(41955626,0,0,''),(23901038,0,0,''),(23892102,0,0,''),(23854460,0,0,''),(23952971,0,0,''),(23991864,0,0,''),(23975226,0,0,''),(24462651,0,0,''),(42140822,0,0,''),(23872169,0,0,''),(40882256,0,0,''),(23832718,0,0,''),(40470816,0,0,''),(40421253,0,0,''),(46606327,0,0,''),(1287433,0,0,''),(23990323,0,0,''),(23963725,0,0,''),(6441384,0,0,''),(41657289,0,0,''),(40255548,0,0,''),(23975341,22,8,'PERIODO MARZO 2013 - MARZO 2014'),(23839815,0,0,''),(42200992,0,0,''),(43812777,0,0,''),(23999566,30,7,'PERIODO FEBRERO 2013 - FEBRERO 2014'),(43099826,0,0,''),(23844969,46,3,'HASTA 2014'),(42924474,0,0,''),(24586020,0,0,''),(45830355,0,0,''),(24967520,0,0,''),(45859589,0,0,''),(46989136,0,0,''),(41125231,0,0,''),(24389598,0,0,''),(42310075,0,0,''),(43774936,0,0,''),(40084069,0,0,''),(42920752,0,0,''),(47171618,0,0,''),(23836452,0,0,''),(40211461,0,0,''),(25131378,0,0,''),(23900305,0,0,''),(40890070,0,0,''),(42306693,0,0,''),(44944167,0,0,''),(45559232,0,0,''),(24002170,0,0,''),(23902319,0,0,''),(23830036,0,0,''),(23862748,0,0,''),(1326953,0,0,''),(23929320,0,0,''),(4820910,0,0,''),(23871142,0,0,''),(43058746,0,0,''),(23947981,0,0,''),(23836501,54,1,'HASTA 2014'),(23884057,90,7,'HASTA EL 2014'),(23881867,45,1,'HASTA EL 2014'),(23885473,56,2,'HASTA EL 2014'),(23879890,61,4,'HASTA EL 2014'),(23874607,82,12,'HASTA -2014'),(23871757,40,31,'HASTA MAYO 2014'),(24711036,214,1,'HASTA 2014'),(54789655,0,0,''),(31041193,16,2,'HASTA -2014'),(23957602,0,0,''),(46616454,0,0,''),(23801186,0,0,''),(41008983,0,0,''),(23818014,57,1,'HASTA EL 2014'),(23825387,158,15,'HASTA EL 2014'),(23924986,0,0,''),(23915377,0,0,''),(23811855,0,0,''),(23817816,10,1,'HASTA MAYO 2014*'),(23868102,0,0,''),(23813613,273,1,'HASTA MAYO 2014'),(23914527,54,3,'HASTA MAYO 2014'),(29391879,0,0,''),(23826802,0,0,''),(23891560,0,0,''),(23843901,0,0,''),(23845335,48,5,'HASTA MAYO 2014'),(25008775,0,0,''),(23888456,0,0,''),(23845532,0,0,''),(23840427,0,0,''),(24862629,92,1,'HASTA MAYO 2014'),(23836392,0,0,''),(23882129,0,0,''),(23873435,0,0,''),(23814095,0,0,''),(23875228,0,0,''),(23910822,0,0,''),(23831976,0,0,''),(23880550,0,0,''),(23827930,109,30,'HASTA MAYO 2014'),(9308755,0,0,''),(23873850,199,2,'HASTA MAYO 2014'),(23879697,0,0,''),(23875360,0,0,''),(23851334,0,0,''),(23923564,45,10,'HASTA MAYO 2014'),(23860612,7,1,'HASTA MAYO 2014'),(23871175,11,5,'HASTA MAYO 2014'),(24377202,175,1,'HASTA MAYO DEL 2014'),(23817995,0,0,''),(23883367,0,0,''),(23841547,0,0,''),(23902017,0,0,''),(23805947,0,0,''),(23846278,212,0,'HASTA MAYO 2014'),(23839590,9,1,'HASTA MAYO DEL 2014'),(23872251,0,0,''),(23905603,0,0,''),(23924055,0,0,''),(23812530,0,0,''),(23878021,324,7,'HASTA MAYO 2014'),(23885471,315,1,'HASTA MAYO 2014'),(23800632,0,0,''),(23817223,0,0,''),(23825067,21,1,'HASTA MAYO 2014'),(23839577,0,0,''),(23983710,0,0,''),(23829140,0,0,''),(23876814,0,0,''),(23824344,0,0,''),(23823545,0,0,''),(23843063,0,0,''),(23882387,0,0,''),(23815234,0,0,''),(23886001,0,0,''),(23858276,0,0,''),(23881617,0,0,''),(25121027,227,7,'HASTA MAYO 2014'),(23819740,95,2,'HASTA MAYO 2014'),(25180003,192,5,'HASTA MAYO 2014'),(24468229,0,0,''),(23904660,262,30,'HASTA MAYO 2014'),(23804863,130,1,'HASTA MAYO 2014'),(23913122,0,0,''),(23873586,0,0,''),(23900485,154,1,'HASTA MAYO 2014*'),(23868214,0,0,''),(23892351,0,0,''),(23890238,0,0,''),(23818497,0,0,''),(23843720,411,5,'HASTA MAYO 2014'),(23956820,0,0,''),(23874680,31,1,'HASTA JUNIO 2014'),(23837373,0,0,''),(23827396,0,0,''),(23907641,186,1,'HASTA JUNIO 2014'),(23875527,0,0,''),(23875050,53,1,'HASTA MAYO 2014'),(23833677,0,0,''),(23836515,0,0,''),(23800695,0,0,''),(23885660,36,1,'HASTA MES DE MAYO 2014'),(24670414,61,1,'HASTA MAYO 2014*'),(23800164,0,0,''),(23923465,0,0,''),(24280800,0,0,''),(23883002,0,0,''),(23814088,0,0,''),(23923235,0,0,''),(23878754,0,0,''),(23802153,0,0,''),(23951720,0,0,''),(23915799,0,0,''),(23809168,115,1,'HASTA MAYO 2014*'),(23914027,0,0,''),(23883213,0,0,''),(7188982,0,0,''),(23881471,0,0,''),(23873338,0,0,''),(23995106,0,0,''),(23879544,0,0,''),(23912098,132,30,'HASTA MAYO 2014'),(23839829,0,0,''),(23828694,0,0,''),(24003255,62,1,'HASTA MAYO 2014'),(23876796,0,0,''),(23910391,0,0,''),(23867749,140,1,'HASTA MAYO 2014*'),(23823667,0,0,''),(23848121,0,0,''),(23883592,0,0,''),(23875839,22,2,'HASTA MAYO 2014'),(23853612,0,0,''),(23848486,0,0,''),(23805316,0,0,''),(23887108,0,0,''),(23868117,0,0,''),(23982280,20,1,'HASTA MAYO 2014'),(23985756,0,0,''),(23867678,26,1,'HASTA MAYO 2014'),(23910299,125,1,'HASTA MAYO 2014*'),(23840794,0,0,''),(23884227,0,0,''),(23829549,0,0,''),(24361016,140,10,'HASTA MAYO 2014'),(23847068,0,0,''),(23822390,59,2,'HASTA MAYO 2014*'),(23878656,0,0,''),(24282055,0,0,''),(25184490,0,0,''),(23905918,36,15,'HASTA MAYO 2014'),(23878938,0,0,''),(31018184,26,7,'HASTA MAYO 2014'),(23849603,0,0,''),(23814801,5,1,'HASTA MAYO 2014*'),(23919268,61,10,'HASTA MAYO 2014'),(23870318,0,0,''),(23965476,247,1,'HASTA MAYO 2014'),(23853520,0,0,''),(23872037,0,0,''),(23872775,0,0,''),(23804922,0,0,''),(23821092,0,0,''),(23810902,0,0,''),(29281954,67,4,'HASTA MAYO 2014'),(43938937,0,0,''),(23853853,0,0,''),(23651064,0,0,''),(23951452,0,0,''),(41676043,0,0,''),(24813923,0,0,''),(23820557,0,0,''),(23940358,10,10,'HASTA MAYO 2014'),(46640101,0,0,''),(23993114,123,1,'HASTA EL 2014'),(23840199,58,30,'HASTA MAYO 2014'),(23985737,30,8,'PERIODO ABRIL 2013 - ABRIL 2014'),(23824650,114,8,'HASTA MAYO 2014'),(23806220,49,3,'HASTA MAYO 2014'),(23885345,30,4,'HASTA MAYO 2014'),(42405663,0,0,''),(24895309,0,0,''),(44595031,0,0,''),(46757719,0,0,''),(45807139,0,0,''),(41421422,0,0,''),(24382594,0,0,''),(41884366,0,0,''),(1320661,0,0,''),(23865805,0,0,''),(23959409,0,0,''),(45156445,0,0,''),(23879753,0,0,''),(40022237,0,0,''),(43488768,0,0,''),(43081540,0,0,''),(23840333,0,0,''),(42140815,0,0,''),(48021315,0,0,''),(23930518,0,0,''),(31020205,0,0,''),(24462468,0,0,''),(23936753,0,0,''),(24287251,0,0,''),(42130163,0,0,''),(1842029,0,0,''),(23921918,0,0,''),(23855104,0,0,''),(23985013,0,0,''),(23859199,0,0,''),(31302146,0,0,''),(4742135,0,0,''),(23965893,0,0,''),(23849494,0,0,''),(23810498,0,0,''),(44936314,0,0,''),(23981341,0,0,''),(48186151,0,0,''),(45848252,0,0,''),(23950629,0,0,''),(9685531,0,0,''),(40811367,0,0,''),(23982454,0,0,''),(40567499,0,0,''),(41818181,0,0,''),(44780128,0,0,''),(41756734,0,0,''),(23999177,0,0,''),(23815576,0,0,''),(23976612,0,0,''),(23860168,0,0,''),(41662799,0,0,''),(23850554,0,0,''),(23925540,0,0,''),(23996332,0,0,''),(43525768,0,0,''),(44739540,0,0,''),(23945079,0,0,''),(40766317,0,0,''),(23810595,0,0,''),(25311772,0,0,''),(40613713,0,0,''),(2365269,0,0,''),(44227979,0,0,''),(46497497,0,0,''),(43395868,0,0,''),(80089281,0,0,''),(23837437,0,0,''),(23854960,0,0,''),(40722690,0,0,''),(40994220,0,0,''),(23989928,0,0,''),(23933084,0,0,''),(40247746,0,0,''),(23894635,0,0,''),(40509395,0,0,''),(41492881,0,0,''),(8266480,0,0,''),(23990659,0,0,''),(42305575,0,0,''),(40461491,0,0,''),(43822355,0,0,''),(41785199,0,0,''),(41424486,0,0,''),(40968406,0,0,''),(41156052,0,0,''),(24462650,113,1,'HASTA MAYO 2014'),(23833027,0,0,''),(31037418,0,0,''),(44164208,0,0,''),(23801454,0,0,''),(23818880,0,0,''),(23851971,0,0,''),(70032190,0,0,''),(23868484,0,0,''),(45564477,0,0,''),(42936752,0,0,''),(43248148,0,0,''),(23865467,0,0,''),(23851795,0,0,''),(23999621,0,0,''),(23925060,30,0,'SOLO PERIODO 2014 PUAES VINO DE INDECI'),(23974790,0,0,'');

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
