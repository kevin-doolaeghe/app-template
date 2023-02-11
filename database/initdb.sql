CREATE DATABASE IF NOT EXISTS db;
USE db;

CREATE TABLE IF NOT EXISTS Users
(
    Id int PRIMARY KEY NOT NULL AUTO_INCREMENT,
    Name varchar(100),
    Email varchar(100),
    Password varchar(100)
);
