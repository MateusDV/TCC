USE AALVES3
GO

--LOGIN C# E JAVA
CREATE PROCEDURE USP_PROG_LOGIN
	@EMAIL VARCHAR(80),
	@SENHA VARCHAR(80)
AS
	DECLARE @VAL_EMAIL INT, @VAL_SENHA INT

	SET @VAL_EMAIL = (SELECT COUNT(ID_PROFESSOR) FROM PROFESSOR WHERE EMAIL = @EMAIL)
	SET @VAL_SENHA = (SELECT COUNT(SENHA) FROM PROFESSOR WHERE SENHA = @SENHA)
	IF ((@VAL_EMAIL = 1) AND (@VAL_SENHA = 1))
		BEGIN
			SELECT ID_PROFESSOR AS ID, NOME, ('PROFESSOR') AS CARGO FROM PROFESSOR
		END
	ELSE
		BEGIN 
			SET @VAL_EMAIL = (SELECT COUNT(ID_FUNCIONARIO) FROM FUNCIONARIO WHERE EMAIL = @EMAIL)
			SET @VAL_SENHA = (SELECT COUNT(SENHA) FROM FUNCIONARIO WHERE SENHA = @SENHA)

			IF ((@VAL_EMAIL = 1) AND (@VAL_SENHA = 1))
				BEGIN
					SELECT FUNCIONARIO.ID_FUNCIONARIO AS ID, FUNCIONARIO.NOME, CARGO.NOME AS CARGO FROM FUNCIONARIO
					INNER JOIN CARGO ON FUNCIONARIO.CARGO = CARGO.ID_CARGO
				END
			ELSE
				BEGIN 
					SELECT 0 AS ID, ('') AS NOME, ('') AS CARGO
				END
		END

--EXEC USP_PROG_LOGIN "testet", "teste"

GO


--LOGIN ASP
CREATE PROCEDURE USP_ASP_LOGIN
	@EMAIL VARCHAR(80),
	@SENHA VARCHAR(80)
AS
	DECLARE @VAL_EMAIL INT, @VAL_SENHA INT

	SET @VAL_EMAIL = (SELECT COUNT(ID_ALUNO) FROM ALUNO WHERE EMAIL = @EMAIL)
	SET @VAL_SENHA = (SELECT COUNT(SENHA) FROM ALUNO WHERE SENHA = @SENHA)
	IF ((@VAL_EMAIL = 1) AND (@VAL_SENHA = 1))
		BEGIN
			SELECT ID_ALUNO AS ID, NOME FROM ALUNO
		END
	ELSE
		BEGIN 
			SELECT 0 AS ID, ('') AS NOME
		END
--EXEC USP_ASP_LOGIN "joaoCM@gmail.com", "12345"

--PROCEDURES C#
--#########################################################
GO
CREATE PROCEDURE USP_ALUNO_INSERIR
	@NOME     VARCHAR(50),
	@EMAIL    VARCHAR(50),
	@SEXO     VARCHAR(20),
	@SENHA    VARCHAR(80),
	@RUA      VARCHAR(80),
	@NUM      INT,
	@CEP      VARCHAR(9),
	@CIDADE   VARCHAR(80),
	@ESTADO   VARCHAR(30),
	@TELEFONE VARCHAR(20)
AS
	DECLARE @QNT INT
	
	SET @QNT = (SELECT COUNT(ID_ALUNO) FROM ALUNO WHERE NOME = @NOME)
	
	IF (@QNT > 0)
		BEGIN
			SELECT 0
		END
	ELSE
		BEGIN
			INSERT INTO ALUNO OUTPUT inserted.ID_ALUNO VALUES (@NOME, @EMAIL, @SEXO, @SENHA, @RUA, @NUM, @CEP, @CIDADE, @ESTADO, @TELEFONE, DEFAULT)
		END
		
--EXEC USP_ALUNO_INSERIR "TESTE", "TESTE", "TESTE", "TESTE", "TESTE", "10", "11111111", "TESTE", "TESTE", "111111111"
GO

CREATE PROCEDURE USP_CURSO_ALUNO_INSERIR
	@ID_ALUNO INT,
	@ID_CURSO INT
AS
	DECLARE @QNT INT
	
	SET @QNT = (SELECT COUNT(ID_ALUNO) FROM CURSO_ALUNO WHERE ID_ALUNO = @ID_ALUNO AND ID_CURSO = @ID_CURSO)
	
	IF (@QNT > 0)
		BEGIN
			SELECT 0
		END
	ELSE
		BEGIN
			INSERT CURSO_ALUNO VALUES(@ID_ALUNO, @ID_CURSO, DEFAULT)
			SELECT 1
		END
		
--EXEC USP_CURSO_ALUNO_INSERIR "1", "3"
GO

CREATE PROCEDURE USP_PERIODO_ALUNO_INSERIR
	@ID_ALUNO   INT,
	@ID_PERIODO INT
AS
	DECLARE @QNT INT
	
	SET @QNT = (SELECT COUNT(ID_ALUNO) FROM PERIODO_ALUNO WHERE ID_ALUNO = @ID_ALUNO AND ID_PERIODO = @ID_PERIODO)
	
	IF (@QNT > 0)
		BEGIN
			SELECT 0
		END
	ELSE
		BEGIN
			INSERT PERIODO_ALUNO VALUES(@ID_ALUNO, @ID_PERIODO, DEFAULT)
			SELECT 1
		END
		
--EXEC USP_PERIODO_ALUNO_INSERIR "1", "1"

