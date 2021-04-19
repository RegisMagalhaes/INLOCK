use inlock_games_tarde;


-- INSERE OS TIPOS DE USUARIOS DO SISTEMA
insert into tiposUsuario (titulo)
values					 ('ADMINISTRADOR'),
						 ('CLIENTE');

GO

-- INSERIR OS DADOS USUARIOS
insert into usuarios(email, senha, idTipoUsuario)
values				('admin@admin.com', 'admin', 1),
					('cliente@cliente.com','cliente',2);

GO

--INSERE OS DADOS DOS ESTUDIOS CRIADORES DE JOGOS
insert into estudios(nomeEstudio)
values				('Blizzard'),
					('RockStar Studios'),
					('Square Enix');
GO

--INSERE OS DADOS DOS JOGOS
insert into jogos(nomeJogo, descricao, dataLancamento, valor, idEstudio)
values			 ('Warcraft','RPG batalha entre mundos', '15/05/2012', 'R$99,00',1),
				 ('Red Dead Redemption II', 'Jogo eletronico de ação no faroeste', '26/10/2018', 'R$120,00',2);


							