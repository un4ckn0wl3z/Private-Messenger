-- phpMyAdmin SQL Dump
-- version 4.5.1
-- http://www.phpmyadmin.net
--
-- Host: 127.0.0.1
-- Generation Time: May 30, 2017 at 03:46 AM
-- Server version: 10.1.16-MariaDB
-- PHP Version: 5.6.24

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `db_priv8msg`
--

-- --------------------------------------------------------

--
-- Table structure for table `tb_chat`
--

CREATE TABLE `tb_chat` (
  `id` int(11) NOT NULL,
  `chat` longtext NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `tb_chat`
--

INSERT INTO `tb_chat` (`id`, `chat`) VALUES
(1, '################################################\nWELCOME TO CHAT ROOM | | -:)| | [Powered By un4ckn0wl3z]\nVisite My Website: http://haxtivitiez.wordpress.com/\n################################################\n\n\n[18/5/2560-22:19:49] - Handy: Hi\n\n[18/5/2560-22:19:52] - Handy: สวัสดี\n\n[18/5/2560-22:19:55] - Handy: อิอิ\n\n[18/5/2560-22:20:29] - palm: หวัดดี\n\n[18/5/2560-22:20:36] - palm: 55555555\n\n[18/5/2560-22:20:41] - Handy: LoL\n\n[18/5/2560-22:20:44] - Handy: 5555\n\n[18/5/2560-22:20:45] - Handy: 5\n\n[18/5/2560-22:20:45] - Handy: 55\n\n[18/5/2560-22:20:45] - Handy: 55\n\n[18/5/2560-22:20:45] - Handy: 55\n\n[18/5/2560-22:20:51] - palm: อิอิ\n\n[18/5/2560-22:20:53] - palm: อิอิ\n\n[21/5/2560-11:01:05] - palm: abc\n\n[21/5/2560-11:01:07] - palm: abc\n\n[21/5/2560-11:01:15] - palm: อิอิ\n\n[21/5/2560-11:01:16] - palm: อิอิ\n\n[21/5/2560-11:01:16] - palm: อิ\n\n[21/5/2560-11:01:18] - palm: sad\n\n[21/5/2560-11:01:18] - palm: sad\n\n[21/5/2560-11:01:18] - palm: sa\n\n[21/5/2560-11:01:18] - palm: d\n\n[21/5/2560-11:01:19] - palm: sad\n\n[21/5/2560-11:25:31] - palm: hi\n\n[21/5/2560-11:25:35] - palm: อิอิอิ\n\n[21/5/2560-11:25:38] - palm: ทำไรกันยุ\n\n[21/5/2560-12:43:17] - Kamonporn: 5555\n\n[21/5/2560-12:53:49] - palm: 55\n\n[21/5/2560-13:05:13] - slax: หวัดดีทุกคน\n\n[29/5/2560-19:26:36] - palm: 5555\n\n[29/5/2560-19:26:39] - palm: 5555\n\n[29/5/2560-19:26:49] - palm: อิอิ');

-- --------------------------------------------------------

--
-- Table structure for table `tb_users`
--

CREATE TABLE `tb_users` (
  `id` int(11) NOT NULL,
  `username` varchar(200) NOT NULL,
  `password` varchar(200) NOT NULL,
  `fname` varchar(200) NOT NULL,
  `sname` varchar(200) NOT NULL,
  `email` varchar(200) NOT NULL,
  `gender` varchar(10) NOT NULL,
  `user_pic` longtext NOT NULL,
  `online_status` varchar(1) NOT NULL DEFAULT 'f'
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `tb_users`
--

INSERT INTO `tb_users` (`id`, `username`, `password`, `fname`, `sname`, `email`, `gender`, `user_pic`, `online_status`) VALUES
(1, 'Kamonporn', '123', 'Nam', 'Sumrit', 'Kamonporn@fuck.com', 'Male', '', 'f'),
(2, 'palm', '123', 'Lord', 'Haxxor', 'hackerth@gmail.com', 'Male', '', 'f'),
(3, 'bot1', 'bot1', 'bot1', 'bot1', 'bot1', 'Female', '', 'f'),
(4, 'anuwat69', 'anuwat69', 'Anuwat', 'Khongchuai', 'slickerth@gmail.com', 'Male', '', 'f'),
(5, 'TestUser1', 'TestUser1', 'TestUser1', 'TestUser1', 'TestUser1@Lookme.keyrock', 'Female', '', 'f'),
(6, 'Luke', '123456', 'Luke', 'Skywalker', 'Skywalker@starwar.galaxx', 'Female', '', 'f'),
(7, 'Handy', '12345', 'Handy', 'Letgo', 'Handy@rock.loc', 'Female', '', 'f'),
(8, 'test001', 'test001', 'test001', 'test001', 'test001', 'Male', '', 'f'),
(9, 'slax', '123', 'slaxy', 'morin', 'slaxgg@gm.com', 'Female', '', 'f'),
(10, 'Anuwat', 'Anuwat', 'Anuwat', 'Palm', 'Anuwat', 'Male', '', 'f'),
(11, 'joker', 'joker', 'joker', 'leet37', 'joker@haxtivitiez', 'Female', '', 'f');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `tb_chat`
--
ALTER TABLE `tb_chat`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `tb_users`
--
ALTER TABLE `tb_users`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `username` (`username`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `tb_chat`
--
ALTER TABLE `tb_chat`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;
--
-- AUTO_INCREMENT for table `tb_users`
--
ALTER TABLE `tb_users`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=12;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
