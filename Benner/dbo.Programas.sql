CREATE TABLE [dbo].[Programas]
(
    [Id] INT NOT NULL PRIMARY KEY, 
    [Nome] VARCHAR(150) NOT NULL, 
    [Instrucoes] VARCHAR(MAX) NOT NULL, 
    [Caractere] CHAR(1) NOT NULL, 
    [Tempo] TIME NOT NULL, 
    [Potencia] INT NOT NULL
)
