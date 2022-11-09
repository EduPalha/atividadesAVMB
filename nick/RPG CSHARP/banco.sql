
create database provaNicolasLInguages2;

use provaNicolasLInguages2;

CREATE TABLE classe (
  codigo int(11) NOT NULL AUTO_INCREMENT,
  descricao varchar(50) NOT NULL,
  forca int(11) NOT NULL,
  hp int(11) NOT NULL,
  destresa int(11) NOT NULL,
  defesa int(11) NOT NULL,
  PRIMARY KEY (codigo)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8;

CREATE TABLE personagens (
  ID int(11) NOT NULL AUTO_INCREMENT,
  Codigo_classe int(11) NOT NULL,
  nome varchar(50) NOT NULL,
  XP int(11) NOT NULL,
  pontos_livres int(11) DEFAULT NULL,
  nivel int(11) NOT NULL,
  forca int(11) NOT NULL,
  hp int(11) NOT NULL,
  destresa int(11) NOT NULL,
  defesa int(11) NOT NULL,
  PRIMARY KEY (ID),
  KEY Codigo_classe (Codigo_classe),
  CONSTRAINT personagens_ibfk_1 FOREIGN KEY (Codigo_classe) REFERENCES classe (codigo) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;


CREATE VIEW vw_personagens AS
    SELECT 
        personagens.ID AS Codigo,
        personagens.nome AS nome,
        classe.codigo AS codClasse,
        classe.descricao AS classe,
        classe.forca AS classe_forca,
        classe.hp AS classe_HP,
        classe.destresa AS classe_destresa,
        classe.defesa AS classe_defesa,
        personagens.XP AS XP,
        personagens.pontos_livres AS Pontos_Livres,
        personagens.nivel AS Nivel,
        personagens.forca AS forca,
        personagens.hp AS HP,
        personagens.destresa AS destresa,
        personagens.defesa AS defesa
    FROM
        (personagens
        LEFT JOIN classe ON ((personagens.Codigo_classe = classe.codigo)));
