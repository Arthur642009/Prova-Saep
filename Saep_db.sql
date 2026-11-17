SELECT 'Usuarios' AS Tabela, COUNT(*) AS Quantidade FROM Usuarios
UNION ALL SELECT 'Tutores', COUNT(*) FROM Tutores
UNION ALL SELECT 'Pets', COUNT(*) FROM Pets
UNION ALL SELECT 'Agendamentos', COUNT(*) FROM Agendamentos;

SELECT Id, Nome, CpfCriptografado FROM Tutores;
SELECT Id, Email, SenhaHash FROM Usuarios;