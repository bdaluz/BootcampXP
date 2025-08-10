-- 1
SELECT Nome, Ano FROM Filmes

-- 2
SELECT Nome, Ano, Duracao FROM Filmes
ORDER BY Ano

-- 3
SELECT Nome, Ano, Duracao 
FROM Filmes WHERE Nome = 'De Volta para o Futuro'

-- 4
SELECT Nome, Ano, Duracao 
FROM Filmes WHERE Ano = 1997

-- 5
SELECT Nome, Ano, Duracao 
FROM Filmes WHERE Ano > 2000

-- 6
SELECT Nome, Ano, Duracao 
FROM Filmes WHERE Duracao > 100 AND Duracao < 150
ORDER BY Duracao

-- 7
SELECT Ano, COUNT(*) AS Quantidade 
FROM Filmes
GROUP BY Ano
ORDER BY Quantidade DESC

-- 8
SELECT Id, PrimeiroNome, UltimoNome, Genero FROM Atores
WHERE Genero = 'M'

-- 9
SELECT Id, PrimeiroNome, UltimoNome, Genero FROM Atores
WHERE Genero = 'F'
ORDER BY PrimeiroNome

-- 10
SELECT filme.Nome, genero.Genero FROM Filmes filme
INNER JOIN FilmesGenero filmegenero ON filme.Id = filmegenero.IdFilme
INNER JOIN Generos genero ON filmegenero.IdGenero = genero.Id

-- 11
SELECT filme.Nome, genero.Genero FROM Filmes filme
INNER JOIN FilmesGenero filmegenero ON filme.Id = filmegenero.IdFilme
INNER JOIN Generos genero ON filmegenero.IdGenero = genero.Id
WHERE genero = 'Mistério'

-- 12
SELECT filme.Nome, actor.PrimeiroNome, actor.UltimoNome, pr.Papel FROM Filmes filme
INNER JOIN ElencoFilme pr ON filme.Id = pr.IdFilme
INNER JOIN Atores actor ON pr.IdAtor = actor.Id
