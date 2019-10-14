-- phpMyAdmin SQL Dump
-- version 4.8.3
-- https://www.phpmyadmin.net/
--
-- Хост: 127.0.0.1:3306
-- Время создания: Окт 14 2019 г., 19:09
-- Версия сервера: 5.6.41
-- Версия PHP: 5.5.38

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- База данных: `somesortoftestbd`
--

-- --------------------------------------------------------

--
-- Структура таблицы `deds`
--

CREATE TABLE `deds` (
  `ID` int(11) NOT NULL,
  `ProjectName` varchar(45) NOT NULL,
  `Note` varchar(45) DEFAULT NULL,
  `EndDate` varchar(45) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `deds`
--

INSERT INTO `deds` (`ID`, `ProjectName`, `Note`, `EndDate`) VALUES
(9, 'SomeShit', 'Do it Niger', '01.01.1996'),
(12, 'NEW TEST', 'WE TRY', '10.10.2006'),
(24, 'IDK', 'I think this ist working', '66.99.6969'),
(25, 'IDK', 'I think this ist working', '66.99.6969');

-- --------------------------------------------------------

--
-- Структура таблицы `users`
--

CREATE TABLE `users` (
  `UserID` int(255) NOT NULL,
  `UserName` varchar(255) NOT NULL,
  `UserPassword` varchar(255) NOT NULL,
  `UserPrivilege` int(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `users`
--

INSERT INTO `users` (`UserID`, `UserName`, `UserPassword`, `UserPrivilege`) VALUES
(1, 'Admin', 'Admin', 2),
(3, 'VIP_User', 'VIP_User', 1),
(4, 'User', 'User', 0),
(5, 'Gun', 'Done', 2),
(6, 'Fuck', 'Face', 0),
(7, 'Suck', 'Some', 0),
(8, 'kakJeYaZaebalsya', 'Bleat', 0);

--
-- Индексы сохранённых таблиц
--

--
-- Индексы таблицы `deds`
--
ALTER TABLE `deds`
  ADD PRIMARY KEY (`ID`),
  ADD UNIQUE KEY `ID_UNIQUE` (`ID`);

--
-- Индексы таблицы `users`
--
ALTER TABLE `users`
  ADD KEY `UserID` (`UserID`);

--
-- AUTO_INCREMENT для сохранённых таблиц
--

--
-- AUTO_INCREMENT для таблицы `deds`
--
ALTER TABLE `deds`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=26;

--
-- AUTO_INCREMENT для таблицы `users`
--
ALTER TABLE `users`
  MODIFY `UserID` int(255) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
