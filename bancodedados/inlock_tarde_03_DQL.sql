use inlock_games_tarde;


select * from jogos;
select * from tiposUsuario;
select * from estudios;
select * from usuarios;

select nomeJogo [nome jogo] , descricao, valor preço, dataLancamento [data], nomeEstudio from jogos as J
inner join estudios E
on J.idEstudio = E.idEstudio;

select nomeEstudio Estudios, nomeJogo Jogos from estudios e
inner join jogos j
on j.idEstudio = e.idEstudio;

select email, senha from usuarios; 

select idJogo, nomeJogo from jogos
where idJogo>0;


select idEstudio, nomeEstudio from estudios;