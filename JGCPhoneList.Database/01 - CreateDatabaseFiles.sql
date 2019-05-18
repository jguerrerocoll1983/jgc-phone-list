USE master;  
GO  
CREATE DATABASE JGCPhoneList  
ON   
( NAME = Sales_dat,  
    FILENAME = 'C:\JGCPhoneList\JGCPhoneList.mdf',  
    SIZE = 10MB,  
    MAXSIZE = 50MB,  
    FILEGROWTH = 5MB )  
LOG ON  
( NAME = Sales_log,  
    FILENAME = 'C:\JGCPhoneList\JGCPhoneList.ldf',  
    SIZE = 5MB,  
    MAXSIZE = 25MB,  
    FILEGROWTH = 5MB ) ;  
GO  