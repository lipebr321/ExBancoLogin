create database BCOLOGIN_B; 
use BCOLOGIN_B; 

create table TB_USUARIO(
id_usuario int(8) unsigned NOT NULL auto_increment,
nome_usu varchar(50),
senha_usu varchar(15),
email_usu varchar (100),
primary key (id_usuario)
);

insert into TB_USUARIO (nome_usu, senha_usu, email_usu) values ('Admin', '1234', 'admin@etec');

select * from TB_USUARIO;

DELIMITER $$
CREATE PROCEDURE sp_Inserir (in nome varchar (60), in senha varchar (15), in email varchar (100))
BEGIN

insert into tb_usuario (nome_usu, senha_usu, email_usu)  values (nome, senha, email);

END $$

