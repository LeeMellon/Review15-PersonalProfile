-- phpMyAdmin SQL Dump
-- version 4.7.0
-- https://www.phpmyadmin.net/
--
-- Host: localhost:8889
-- Generation Time: May 17, 2018 at 06:35 AM
-- Server version: 5.6.34-log
-- PHP Version: 7.1.5

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `portfolio`
--

-- --------------------------------------------------------

--
-- Table structure for table `aspnetroleclaims`
--

CREATE TABLE `aspnetroleclaims` (
  `Id` int(11) NOT NULL,
  `ClaimType` longtext,
  `ClaimValue` longtext,
  `RoleId` varchar(127) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `aspnetroles`
--

CREATE TABLE `aspnetroles` (
  `Id` varchar(127) NOT NULL,
  `ConcurrencyStamp` longtext,
  `Name` varchar(127) DEFAULT NULL,
  `NormalizedName` varchar(127) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `aspnetuserclaims`
--

CREATE TABLE `aspnetuserclaims` (
  `Id` int(11) NOT NULL,
  `ClaimType` longtext,
  `ClaimValue` longtext,
  `UserId` varchar(127) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `aspnetuserlogins`
--

CREATE TABLE `aspnetuserlogins` (
  `LoginProvider` varchar(127) NOT NULL,
  `ProviderKey` varchar(127) NOT NULL,
  `ProviderDisplayName` longtext,
  `UserId` varchar(127) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `aspnetuserroles`
--

CREATE TABLE `aspnetuserroles` (
  `UserId` varchar(127) NOT NULL,
  `RoleId` varchar(127) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `aspnetusers`
--

CREATE TABLE `aspnetusers` (
  `Id` varchar(127) NOT NULL,
  `AccessFailedCount` int(11) NOT NULL,
  `ConcurrencyStamp` longtext,
  `Email` varchar(127) DEFAULT NULL,
  `EmailConfirmed` bit(1) NOT NULL,
  `LockoutEnabled` bit(1) NOT NULL,
  `LockoutEnd` datetime(6) DEFAULT NULL,
  `NormalizedEmail` varchar(127) DEFAULT NULL,
  `NormalizedUserName` varchar(127) DEFAULT NULL,
  `PasswordHash` longtext,
  `PhoneNumber` longtext,
  `PhoneNumberConfirmed` bit(1) NOT NULL,
  `Role` longtext,
  `SecurityStamp` longtext,
  `TwoFactorEnabled` bit(1) NOT NULL,
  `UserId` longtext,
  `UserName` varchar(127) DEFAULT NULL,
  `Name` longtext,
  `ProfileName` longtext
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `aspnetusers`
--

INSERT INTO `aspnetusers` (`Id`, `AccessFailedCount`, `ConcurrencyStamp`, `Email`, `EmailConfirmed`, `LockoutEnabled`, `LockoutEnd`, `NormalizedEmail`, `NormalizedUserName`, `PasswordHash`, `PhoneNumber`, `PhoneNumberConfirmed`, `Role`, `SecurityStamp`, `TwoFactorEnabled`, `UserId`, `UserName`, `Name`, `ProfileName`) VALUES
('9391d0f5-fd1e-47a4-acd3-24789407b358', 0, 'b58b15f2-603a-4145-8c03-76c0babf62b6', NULL, b'0', b'1', NULL, NULL, 'FAKE@PHONY.COM', 'AQAAAAEAACcQAAAAEP3brgvvMPSPPHDl6iV7Cjvxz0V7wFbwkQhVHqOIbUFE/oveUWSchP72/dnaPda1Dw==', NULL, b'0', NULL, '7aa7b222-1bc1-4b8f-b160-594841a5dc5e', b'0', NULL, 'fake@phony.com', NULL, 'Testier');

-- --------------------------------------------------------

--
-- Table structure for table `aspnetusertokens`
--

CREATE TABLE `aspnetusertokens` (
  `UserId` varchar(127) NOT NULL,
  `LoginProvider` varchar(127) NOT NULL,
  `Name` varchar(127) NOT NULL,
  `Value` longtext
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `pictures`
--

CREATE TABLE `pictures` (
  `PictureId` int(11) NOT NULL,
  `Alt` longtext,
  `Caption` longtext,
  `Location` longtext,
  `Title` longtext,
  `Url` longtext
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `pictures`
--

INSERT INTO `pictures` (`PictureId`, `Alt`, `Caption`, `Location`, `Title`, `Url`) VALUES
(1, 'unhappy cat and child', 'Young girl and cat waiting for the Best Dressed Pet contest winners to be announced.', 'Norwood, Co', 'Neither of us wants to be here', '../images/IMGP9950CropMod.png'),
(2, 'Norwood Rodeo', NULL, 'Norwood, Co', NULL, '../images/IMGP0276Mod.png');

-- --------------------------------------------------------

--
-- Table structure for table `posts`
--

CREATE TABLE `posts` (
  `PostId` int(11) NOT NULL,
  `Alt` longtext,
  `Img` longtext,
  `Text` longtext,
  `Title` longtext,
  `Blurb` longtext
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `posts`
--

INSERT INTO `posts` (`PostId`, `Alt`, `Img`, `Text`, `Title`, `Blurb`) VALUES
(6, NULL, NULL, 'dwedddwddswe', 'Test The User Name', NULL),
(7, 'A picture that could be Doofus Rick or this pages creator.', 'data:image/jpeg;base64,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', 'Hey there. Sorry, I cleaned out the JS snippet in my admin page so none of these things worked. Still a work in progress. Sorry for the delay and the cost to your time.  ', 'Ian\'s A Doofus!', NULL);

-- --------------------------------------------------------

--
-- Table structure for table `responces`
--

CREATE TABLE `responces` (
  `ResponceId` int(11) NOT NULL,
  `PostId` int(11) NOT NULL,
  `ResponceText` longtext,
  `UserId` varchar(127),
  `ResponceTitle` longtext,
  `ProfileName` longtext
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `responces`
--

INSERT INTO `responces` (`ResponceId`, `PostId`, `ResponceText`, `UserId`, `ResponceTitle`, `ProfileName`) VALUES
(5, 6, 'fsawqdsadsaw', '9391d0f5-fd1e-47a4-acd3-24789407b358', 'dsdasda', NULL),
(6, 6, 'FEWFEWaw', '9391d0f5-fd1e-47a4-acd3-24789407b358', 'daswsawEDWAE', 'Testier'),
(7, 6, 'Yeah, so I\'m not much for words but your post really spoke to me in a language I could understand.', '9391d0f5-fd1e-47a4-acd3-24789407b358', 'I need to clean out the history on this text field', 'Testier');

-- --------------------------------------------------------

--
-- Table structure for table `__efmigrationshistory`
--

CREATE TABLE `__efmigrationshistory` (
  `MigrationId` varchar(95) NOT NULL,
  `ProductVersion` varchar(32) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `__efmigrationshistory`
--

INSERT INTO `__efmigrationshistory` (`MigrationId`, `ProductVersion`) VALUES
('20180504195210_Initial', '1.1.2'),
('20180504195652_UpdateUserModel', '1.1.2'),
('20180504203841_PostResponceCollectionVirtual', '1.1.2'),
('20180504205316_ForeignKeyToResponces', '1.1.2'),
('20180504212140_ChangeToBlogResponces', '1.1.2'),
('20180504222344_DataTypeTextToRegisterView', '1.1.2'),
('20180504224754_ChangeUserModelAgain', '1.1.2'),
('20180504233511_User', '1.1.2'),
('20180505001542_ResponceTite', '1.1.2'),
('20180507175319_ChangeToUserIdKeyInResponceModel', '1.1.2'),
('20180507235031_PicturesClass', '1.1.2'),
('20180508205458_RegistrationAddProfileName', '1.1.2'),
('20180508210710_ProfileNameToAppUserModelAndRegistry', '1.1.2'),
('20180508213231_ProfileNameVirtualToResponce', '1.1.2'),
('20180508214729_FrKeyToProfileName', '1.1.2'),
('20180511161541_ProfileNameToResponce', '1.1.2'),
('20180511212557_AddBlurbToPost', '1.1.2'),
('20180517060603_Blurb', '1.1.2');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `aspnetroleclaims`
--
ALTER TABLE `aspnetroleclaims`
  ADD PRIMARY KEY (`Id`),
  ADD KEY `IX_AspNetRoleClaims_RoleId` (`RoleId`);

--
-- Indexes for table `aspnetroles`
--
ALTER TABLE `aspnetroles`
  ADD PRIMARY KEY (`Id`),
  ADD UNIQUE KEY `RoleNameIndex` (`NormalizedName`);

--
-- Indexes for table `aspnetuserclaims`
--
ALTER TABLE `aspnetuserclaims`
  ADD PRIMARY KEY (`Id`),
  ADD KEY `IX_AspNetUserClaims_UserId` (`UserId`);

--
-- Indexes for table `aspnetuserlogins`
--
ALTER TABLE `aspnetuserlogins`
  ADD PRIMARY KEY (`LoginProvider`,`ProviderKey`),
  ADD KEY `IX_AspNetUserLogins_UserId` (`UserId`);

--
-- Indexes for table `aspnetuserroles`
--
ALTER TABLE `aspnetuserroles`
  ADD PRIMARY KEY (`UserId`,`RoleId`),
  ADD KEY `IX_AspNetUserRoles_RoleId` (`RoleId`);

--
-- Indexes for table `aspnetusers`
--
ALTER TABLE `aspnetusers`
  ADD PRIMARY KEY (`Id`),
  ADD UNIQUE KEY `UserNameIndex` (`NormalizedUserName`),
  ADD KEY `EmailIndex` (`NormalizedEmail`);

--
-- Indexes for table `aspnetusertokens`
--
ALTER TABLE `aspnetusertokens`
  ADD PRIMARY KEY (`UserId`,`LoginProvider`,`Name`);

--
-- Indexes for table `pictures`
--
ALTER TABLE `pictures`
  ADD PRIMARY KEY (`PictureId`);

--
-- Indexes for table `posts`
--
ALTER TABLE `posts`
  ADD PRIMARY KEY (`PostId`);

--
-- Indexes for table `responces`
--
ALTER TABLE `responces`
  ADD PRIMARY KEY (`ResponceId`),
  ADD KEY `IX_Responces_PostId` (`PostId`),
  ADD KEY `IX_Responces_UserId` (`UserId`);

--
-- Indexes for table `__efmigrationshistory`
--
ALTER TABLE `__efmigrationshistory`
  ADD PRIMARY KEY (`MigrationId`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `aspnetroleclaims`
--
ALTER TABLE `aspnetroleclaims`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT for table `aspnetuserclaims`
--
ALTER TABLE `aspnetuserclaims`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT for table `pictures`
--
ALTER TABLE `pictures`
  MODIFY `PictureId` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;
--
-- AUTO_INCREMENT for table `posts`
--
ALTER TABLE `posts`
  MODIFY `PostId` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;
--
-- AUTO_INCREMENT for table `responces`
--
ALTER TABLE `responces`
  MODIFY `ResponceId` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;
--
-- Constraints for dumped tables
--

--
-- Constraints for table `aspnetroleclaims`
--
ALTER TABLE `aspnetroleclaims`
  ADD CONSTRAINT `FK_AspNetRoleClaims_AspNetRoles_RoleId` FOREIGN KEY (`RoleId`) REFERENCES `aspnetroles` (`Id`) ON DELETE CASCADE;

--
-- Constraints for table `aspnetuserclaims`
--
ALTER TABLE `aspnetuserclaims`
  ADD CONSTRAINT `FK_AspNetUserClaims_AspNetUsers_UserId` FOREIGN KEY (`UserId`) REFERENCES `aspnetusers` (`Id`) ON DELETE CASCADE;

--
-- Constraints for table `aspnetuserlogins`
--
ALTER TABLE `aspnetuserlogins`
  ADD CONSTRAINT `FK_AspNetUserLogins_AspNetUsers_UserId` FOREIGN KEY (`UserId`) REFERENCES `aspnetusers` (`Id`) ON DELETE CASCADE;

--
-- Constraints for table `aspnetuserroles`
--
ALTER TABLE `aspnetuserroles`
  ADD CONSTRAINT `FK_AspNetUserRoles_AspNetRoles_RoleId` FOREIGN KEY (`RoleId`) REFERENCES `aspnetroles` (`Id`) ON DELETE CASCADE,
  ADD CONSTRAINT `FK_AspNetUserRoles_AspNetUsers_UserId` FOREIGN KEY (`UserId`) REFERENCES `aspnetusers` (`Id`) ON DELETE CASCADE;

--
-- Constraints for table `responces`
--
ALTER TABLE `responces`
  ADD CONSTRAINT `FK_Responces_AspNetUsers_UserId` FOREIGN KEY (`UserId`) REFERENCES `aspnetusers` (`Id`) ON DELETE NO ACTION,
  ADD CONSTRAINT `FK_Responces_Posts_PostId` FOREIGN KEY (`PostId`) REFERENCES `posts` (`PostId`) ON DELETE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
