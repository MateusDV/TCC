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

--ALUNO
--|||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||
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
	@TELEFONE VARCHAR(20),
	@ATIVO    BIT
AS
	DECLARE @QNT INT
	
	SET @QNT = (SELECT COUNT(ID_ALUNO) FROM ALUNO WHERE NOME = @NOME)
	
	IF (@QNT > 0)
		BEGIN
			SELECT 0
		END
	ELSE
		BEGIN
			INSERT INTO ALUNO OUTPUT inserted.ID_ALUNO VALUES (@NOME, @EMAIL, @SEXO, @SENHA, @RUA, @NUM, @CEP, @CIDADE, @ESTADO, @TELEFONE, DEFAULT, @ATIVO)
		END
		
--EXEC USP_ALUNO_INSERIR "TESTE", "TESTE@teste.com", "TESTE", "TESTE", "TESTE", "10", "11111111", "TESTE", "TESTE", "111111111", "1"
GO

CREATE PROCEDURE USP_CURSO_ALUNO_INSERIR
	@ID_ALUNO INT,
	@ID_CURSO INT
AS
	DECLARE @QNT INT
	
	SET @QNT = (SELECT COUNT(ID_ALUNO) FROM CURSO_ALUNO WHERE ID_ALUNO = @ID_ALUNO)
	
	IF (@QNT > 0)
		BEGIN
			UPDATE CURSO_ALUNO SET CURSO_ALUNO.ATIVO = 0 WHERE ID_ALUNO = @ID_ALUNO;
			INSERT CURSO_ALUNO VALUES(@ID_ALUNO, @ID_CURSO, DEFAULT, 1);
		END
	ELSE
		BEGIN
			INSERT CURSO_ALUNO VALUES(@ID_ALUNO, @ID_CURSO, DEFAULT, 1);
		END
	SELECT 1
		
--EXEC USP_CURSO_ALUNO_INSERIR "1", "3"
GO

CREATE PROCEDURE USP_CURSO_ALUNO_CONSULTAR
	@ID_ALUNO INT
AS
	SELECT * FROM CURSO_ALUNO WHERE ID_ALUNO = @ID_ALUNO AND ATIVO = 1

--EXEC USP_CURSO_ALUNO_CONSULTAR "1"
GO


--PERIODO_ALUNO INSERIR
CREATE PROCEDURE USP_PERIODO_ALUNO_INSERIR
	@ID_ALUNO   INT,
	@ID_PERIODO INT
AS
	DECLARE @QNT INT
	
	SET @QNT = (SELECT COUNT(ID_ALUNO) FROM PERIODO_ALUNO WHERE ID_ALUNO = @ID_ALUNO)
	
	IF (@QNT > 0)
		BEGIN
			UPDATE PERIODO_ALUNO SET PERIODO_ALUNO.ATIVO = 0 WHERE ID_ALUNO = @ID_ALUNO;
		END
	INSERT PERIODO_ALUNO VALUES(@ID_ALUNO, @ID_PERIODO, DEFAULT, 1);
	SELECT 1
		
--EXEC USP_PERIODO_ALUNO_INSERIR "1", "3"
GO

--PERIODO_ALUNO CONSULTAR
CREATE PROCEDURE USP_PERIODO_ALUNO_CONSULTAR
	@ID_ALUNO INT
AS
	SELECT * FROM PERIODO_ALUNO WHERE ID_ALUNO = @ID_ALUNO AND ATIVO = 1

--EXEC USP_PERIODO_ALUNO_CONSULTAR "1"
GO

CREATE PROCEDURE USP_ALUNO_CONSULTAR_ID
	@ID INT
AS
	SELECT * FROM ALUNO WHERE ID_ALUNO = @ID AND ATIVO = 1
--EXEC USP_ALUNO_CONSULTAR_ID "1"
GO

CREATE PROCEDURE USP_ALUNO_CONSULTAR_TIPO
	@TIPO  INT,
	@ATIVO INT
AS
	IF(@TIPO = 1)
		BEGIN
			SELECT ALUNO.ID_ALUNO AS ID, ALUNO.NOME, ALUNO.SEXO, CURSO.NOME AS CURSO, PERIODO.NOME AS PERIODO FROM ALUNO 
			INNER JOIN CURSO_ALUNO ON
			ALUNO.ID_ALUNO = CURSO_ALUNO.ID_ALUNO
			INNER JOIN CURSO ON
			CURSO_ALUNO.ID_CURSO = CURSO.ID_CURSO
			INNER JOIN PERIODO_ALUNO ON
			ALUNO.ID_ALUNO = PERIODO_ALUNO.ID_ALUNO
			INNER JOIN PERIODO ON
			PERIODO_ALUNO.ID_PERIODO = PERIODO.ID_PERIODO
			WHERE ALUNO.ATIVO = @ATIVO AND CURSO_ALUNO.ATIVO = @ATIVO AND PERIODO_ALUNO.ATIVO = @ATIVO
			ORDER BY ALUNO.ID_ALUNO ASC
		END
	ELSE IF(@TIPO = 2)
		BEGIN
			SELECT ID_ALUNO AS ID, NOME, EMAIL, TELEFONE FROM ALUNO WHERE ALUNO.ATIVO = @ATIVO
		END
	ELSE IF(@TIPO = 3)
		BEGIN
			SELECT ID_ALUNO AS ID, NOME, RUA, NUM, CEP, CIDADE, ESTADO FROM ALUNO WHERE ALUNO.ATIVO = @ATIVO
		END
--EXEC USP_ALUNO_CONSULTAR_TIPO "1", "1"
GO

--FRGSDFGDFG
--SDFGSDFSDF
--SDFSDFSDFFS
--FRGSDFGDFG
--SDFGSDFSDF
--SDFSDFSDFFS
--FRGSDFGDFG
--SDFGSDFSDF
--SDFSDFSDFFS
CREATE PROCEDURE USP_ALUNO_CONSULTAR_ESPECIFICO
	@TIPO  INT,
	@ATIVO BIT,
	@CAMPO VARCHAR(30),
	@VALOR VARCHAR(50)
AS
	DECLARE @QUERY VARCHAR(500)
	IF(@TIPO = 1)
		BEGIN
			IF(@CAMPO = 'CURSO')
				BEGIN
					SELECT ALUNO.ID_ALUNO AS ID, ALUNO.NOME, ALUNO.SEXO, CURSO.NOME AS CURSO, PERIODO.NOME AS PERIODO FROM ALUNO
					INNER JOIN CURSO_ALUNO ON
					ALUNO.ID_ALUNO = CURSO_ALUNO.ID_ALUNO
					INNER JOIN CURSO ON
					CURSO_ALUNO.ID_CURSO = CURSO.ID_CURSO
					INNER JOIN PERIODO_ALUNO ON
					ALUNO.ID_ALUNO = PERIODO_ALUNO.ID_ALUNO
					INNER JOIN PERIODO ON
					PERIODO_ALUNO.ID_PERIODO = PERIODO.ID_PERIODO WHERE CURSO.NOME LIKE @VALOR AND ALUNO.ATIVO = @ATIVO AND CURSO_ALUNO.ATIVO = @ATIVO AND PERIODO_ALUNO.ATIVO = @ATIVO
				END
			ELSE IF(@CAMPO = 'PERIODO')
				BEGIN
					SELECT ALUNO.ID_ALUNO AS ID, ALUNO.NOME, ALUNO.SEXO, CURSO.NOME AS CURSO, PERIODO.NOME AS PERIODO FROM ALUNO
					INNER JOIN CURSO_ALUNO ON
					ALUNO.ID_ALUNO = CURSO_ALUNO.ID_ALUNO
					INNER JOIN CURSO ON
					CURSO_ALUNO.ID_CURSO = CURSO.ID_CURSO
					INNER JOIN PERIODO_ALUNO ON
					ALUNO.ID_ALUNO = PERIODO_ALUNO.ID_ALUNO
					INNER JOIN PERIODO ON
					PERIODO_ALUNO.ID_PERIODO = PERIODO.ID_PERIODO WHERE PERIODO.NOME LIKE @VALOR AND ALUNO.ATIVO = @ATIVO AND CURSO_ALUNO.ATIVO = @ATIVO AND PERIODO_ALUNO.ATIVO = @ATIVO
				END
			ELSE 
				BEGIN
					SET @QUERY = 'SELECT ALUNO.ID_ALUNO AS ID, ALUNO.NOME, ALUNO.SEXO, CURSO.NOME AS CURSO, PERIODO.NOME AS PERIODO FROM ALUNO
					INNER JOIN CURSO_ALUNO ON
					ALUNO.ID_ALUNO = CURSO_ALUNO.ID_ALUNO
					INNER JOIN CURSO ON
					CURSO_ALUNO.ID_CURSO = CURSO.ID_CURSO
					INNER JOIN PERIODO_ALUNO ON
					ALUNO.ID_ALUNO = PERIODO_ALUNO.ID_ALUNO
					INNER JOIN PERIODO ON
					PERIODO_ALUNO.ID_PERIODO = PERIODO.ID_PERIODO WHERE ALUNO.' + @CAMPO + ' LIKE ''' + @VALOR + '''AND ALUNO.ATIVO = @ATIVO AND CURSO_ALUNO.ATIVO = @ATIVO AND PERIODO_ALUNO.ATIVO = @ATIVO';
					EXEC (@QUERY)
				END
		END
	ELSE IF(@TIPO = 2)
		BEGIN
		--ESSA COISA NAO FUNCIONA COM CAMPOS NAO DEFINIDOS
			--DECLARE @QUERY NVARCHAR(500);
			SET @QUERY = 'SELECT ID_ALUNO AS ID, NOME, EMAIL, TELEFONE FROM ALUNO WHERE ' + @CAMPO + ' LIKE ''' + @VALOR + ''' AND ALUNO.ATIVO = @ATIVO';
			SELECT @QUERY
			EXEC (@QUERY)
		END
	ELSE IF(@TIPO = 3)
		BEGIN
			SET @QUERY = 'SELECT ID_ALUNO AS ID, NOME, RUA, NUM, CEP, CIDADE, ESTADO FROM ALUNO WHERE ' + @CAMPO + ' LIKE ''' + @VALOR + ''' AND ALUNO.ATIVO = @ATIVO';
			EXEC (@QUERY)
		END
--EXEC USP_ALUNO_CONSULTAR_ESPECIFICO "1", "NOME", "J"
GO

CREATE PROCEDURE USP_ALUNO_ALTERAR
	@ID_ALUNO INT,
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
	DECLARE @COUNT INT
	
	SET @COUNT = (SELECT COUNT(ID_ALUNO) FROM ALUNO WHERE ID_ALUNO = @ID_ALUNO)
	
	IF(@COUNT = 1)
		BEGIN
			UPDATE ALUNO SET
				NOME = @NOME,
				EMAIL = @EMAIL,
				SEXO = @SEXO,
				SENHA = @SENHA,
				RUA = @RUA,
				NUM = @NUM,
				CEP = @CEP,
				CIDADE = @CIDADE,
				ESTADO = @ESTADO,
				TELEFONE = @TELEFONE
				WHERE ID_ALUNO = @ID_ALUNO AND ATIVO = 1;
			SELECT 1
		END
	ELSE
		BEGIN
			SELECT 0
		END

GO

CREATE PROCEDURE USP_ALUNO_DESATIVAR
	@ID_ALUNO INT
AS
	DECLARE @COUNT INT
	
	SET @COUNT = (SELECT COUNT(ID_ALUNO) FROM ALUNO WHERE ID_ALUNO = @ID_ALUNO)
	
	IF(@COUNT = 1)
		BEGIN
			UPDATE CURSO_ALUNO SET ATIVO = 0 WHERE ID_ALUNO = @ID_ALUNO;
			UPDATE PERIODO_ALUNO SET ATIVO = 0 WHERE ID_ALUNO = @ID_ALUNO;
			UPDATE ALUNO SET ATIVO = 0 WHERE ID_ALUNO = @ID_ALUNO;
			SELECT 1;
		END
	ELSE
		BEGIN
			SELECT 0;
		END

GO
--FUNCIONARIO
--||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||

--CADASTRAR FUNCIONARIO
CREATE PROCEDURE USP_FUNC_INSERIR
	@NOME     VARCHAR(80),
	@SEXO     VARCHAR(20),
	@RG       VARCHAR(50),
	@CPF      VARCHAR(50),
	@RUA      VARCHAR(80),
	@NUM      INT,
	@BAIRRO   VARCHAR(20),
	@CEP      VARCHAR(9),
	@CIDADE   VARCHAR(80),
	@ESTADO   VARCHAR(30),
	@TELEFONE VARCHAR(20),
	@CELULAR  VARCHAR(20),
	@EMAIL    VARCHAR(80),
	@SENHA    VARCHAR(80),
	@CARGO    INT,
	@ATIVO    BIT
AS
	DECLARE @QNT INT
	
	SET @QNT = (SELECT COUNT(ID_FUNCIONARIO) FROM FUNCIONARIO WHERE CPF = @CPF)
	
	IF (@QNT > 0)
		BEGIN
			SELECT 0
		END
	ELSE
		BEGIN
			INSERT INTO FUNCIONARIO VALUES (@NOME, @SEXO, @RG, @CPF, @RUA, @NUM, @BAIRRO, @CEP, @CIDADE, @ESTADO, @TELEFONE, @CELULAR, @EMAIL, @SENHA, @CARGO, DEFAULT, @ATIVO);
			SELECT 1
		END
--EXEC USP_FUNC_INSERIR "TESTE", "TESTE", "TESTE", "TESTE", "TESTE", "111", "EEEE", "TESTE", "TESTE", "111111111", "EEEEE1", "TESTE", "TESTE", "TESTE", "1", "1"
GO

--CONSULTAR ID
CREATE PROCEDURE USP_FUNC_CONSULTAR_ID
	@ID INT
AS
	SELECT * FROM FUNCIONARIO WHERE ID_FUNCIONARIO = @ID AND ATIVO = 1
	
GO

--CONSULTAR TIPO
CREATE PROCEDURE USP_FUNC_CONSULTAR_TIPO
	@TIPO  INT,
	@ATIVO INT
AS
	IF(@TIPO = 1)
		BEGIN
			SELECT ID_FUNCIONARIO AS ID, NOME, SEXO, RG, CPF, CARGO, CADASTRO FROM FUNCIONARIO WHERE FUNCIONARIO.ATIVO = @ATIVO
		END
	ELSE IF(@TIPO = 2)
		BEGIN
			SELECT ID_FUNCIONARIO AS ID, NOME, EMAIL, TELEFONE, CELULAR FROM FUNCIONARIO WHERE FUNCIONARIO.ATIVO = @ATIVO
		END
	ELSE IF(@TIPO = 3)
		BEGIN
			SELECT ID_FUNCIONARIO AS ID, NOME, RUA, NUM, CEP, BAIRRO, CIDADE, ESTADO FROM FUNCIONARIO WHERE FUNCIONARIO.ATIVO = @ATIVO
		END
--EXEC USP_FUNC_CONSULTAR_TIPO "1", "1"

GO

--CONSULTAR TIPO ESPECIFICO
CREATE PROCEDURE USP_FUNC_CONSULTAR_ESPECIFICO
	@TIPO  INT,
	@ATIVO BIT,
	@CAMPO VARCHAR(30),
	@VALOR VARCHAR(50)
AS
	DECLARE @QUERY VARCHAR(500)
	IF(@TIPO = 1)
		BEGIN
			SET @QUERY = 'SELECT ID_FUNCIONARIO AS ID, NOME, SEXO, RG, CPF, CARGO, CADASTRO FROM FUNCIONARIO WHERE ' + @CAMPO + ' LIKE ''' +  @VALOR + ''' AND FUNCIONARIO.ATIVO = @ATIVO';
			EXEC (@QUERY)
		END
	ELSE IF(@TIPO = 2)
		BEGIN
			SET @QUERY = 'SELECT ID_FUNCIONARIO AS ID, NOME, EMAIL, TELEFONE, CELULAR FROM FUNCIONARIO WHERE ' + @CAMPO + ' LIKE ''' +  @VALOR + ''' AND FUNCIONARIO.ATIVO = @ATIVO';
			EXEC (@QUERY)
		END
	ELSE IF(@TIPO = 3)
		BEGIN
			SET @QUERY = 'SELECT ID_FUNCIONARIO AS ID, NOME, RUA, NUM, CEP, BAIRRO, CIDADE, ESTADO FROM FUNCIONARIO WHERE ' + @CAMPO + ' LIKE ''' +  @VALOR + ''' AND FUNCIONARIO.ATIVO = @ATIVO';
			EXEC (@QUERY)
		END
		
GO

CREATE PROCEDURE USP_FUNC_ALTERAR
	@ID_FUNCIONARIO INT,
	@NOME           VARCHAR(80),
	@SEXO           VARCHAR(20),
	@RG             VARCHAR(50),
	@CPF            VARCHAR(50),
	@RUA            VARCHAR(80),
	@NUM            INT,
	@BAIRRO         VARCHAR(20),
	@CEP            VARCHAR(9),
	@CIDADE         VARCHAR(80),
	@ESTADO         VARCHAR(30),
	@TELEFONE       VARCHAR(20),
	@CELULAR        VARCHAR(20),
	@EMAIL          VARCHAR(80),
	@SENHA          VARCHAR(80),
	@CARGO          INT,
	@ATIVO          BIT
AS
	DECLARE @COUNT INT
	
	SET @COUNT = (SELECT COUNT(ID_FUNCIONARIO) FROM FUNCIONARIO WHERE ID_FUNCIONARIO = @ID_FUNCIONARIO)
	
	IF(@COUNT = 1)
		BEGIN
			UPDATE FUNCIONARIO SET
				NOME = @NOME,
				SEXO = @SEXO,
				RG = @RG,
				CPF = @CPF,
				RUA = @RUA,
				NUM = @NUM,
				BAIRRO = @BAIRRO,
				CEP = @CEP,
				CIDADE = @CIDADE,
				ESTADO = @ESTADO,
				TELEFONE = @TELEFONE,
				CELULAR = @CELULAR,
				EMAIL = @EMAIL,
				SENHA = @SENHA,
				CARGO = @CARGO,
				ATIVO = @ATIVO
				WHERE ID_FUNCIONARIO = @ID_FUNCIONARIO AND ATIVO = 1;
			SELECT 1
		END
	ELSE
		BEGIN
			SELECT 0
		END

GO

CREATE PROCEDURE USP_FUNC_DESATIVAR
	@ID_FUNCIONARIO INT
AS
	DECLARE @COUNT INT
	
	SET @COUNT = (SELECT COUNT(ID_FUNCIONARIO) FROM FUNCIONARIO WHERE ID_FUNCIONARIO = @ID_FUNCIONARIO)
	
	IF(@COUNT = 1)
		BEGIN
			UPDATE FUNCIONARIO SET ATIVO = 0 WHERE ID_FUNCIONARIO = @ID_FUNCIONARIO;
			SELECT 1;
		END
	ELSE
		BEGIN
			SELECT 0;
		END
GO
--PROFESSOR
--|||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||
CREATE PROCEDURE USP_PROF_INSERIR
	@NOME     VARCHAR(80),
	@SEXO     VARCHAR(20),
	@RG       VARCHAR(50),
	@CPF      VARCHAR(50),
	@RUA      VARCHAR(80),
	@NUM      INT,
	@BAIRRO   VARCHAR(20),
	@CEP      VARCHAR(9),
	@CIDADE   VARCHAR(80),
	@ESTADO   VARCHAR(30),
	@TELEFONE VARCHAR(20),
	@CELULAR  VARCHAR(20),
	@EMAIL    VARCHAR(80),
	@SENHA    VARCHAR(80),
	@ATIVO    BIT
AS
	DECLARE @QNT INT
	
	SET @QNT = (SELECT COUNT(ID_PROFESSOR) FROM PROFESSOR WHERE CPF = @CPF)
	
	IF (@QNT > 0)
		BEGIN
			SELECT 0
		END
	ELSE
		BEGIN
			INSERT INTO PROFESSOR VALUES (@NOME, @SEXO, @RG, @CPF, @RUA, @NUM, @BAIRRO, @CEP, @CIDADE, @ESTADO, @TELEFONE, @CELULAR, @EMAIL, @SENHA, DEFAULT, @ATIVO);
			SELECT 1
		END
--EXEC USP_PROF_INSERIR "TESTE", "TESTE", "TESTE", "TESTE", "TESTE", "111", "EEEE", "TESTE", "TESTE", "111111111", "EEEEE1", "TESTE", "TESTE", "TESTE", "1"
GO
--CONSULTAR ID
CREATE PROCEDURE USP_PROF_CONSULTAR_ID
	@ID INT
AS
	SELECT * FROM PROFESSOR WHERE ID_PROFESSOR = @ID AND ATIVO = 1
	
GO

--CONSULTAR TIPO
CREATE PROCEDURE USP_PROF_CONSULTAR_TIPO
	@TIPO  INT,
	@ATIVO INT
AS
	IF(@TIPO = 1)
		BEGIN
			SELECT ID_PROFESSOR AS ID, NOME, SEXO, RG, CPF, CADASTRO FROM PROFESSOR WHERE PROFESSOR.ATIVO = @ATIVO
		END
	ELSE IF(@TIPO = 2)
		BEGIN
			SELECT ID_PROFESSOR AS ID, NOME, EMAIL, TELEFONE, CELULAR FROM PROFESSOR WHERE PROFESSOR.ATIVO = @ATIVO
		END
	ELSE IF(@TIPO = 3)
		BEGIN
			SELECT ID_PROFESSOR AS ID, NOME, RUA, NUM, CEP, BAIRRO, CIDADE, ESTADO FROM PROFESSOR WHERE PROFESSOR.ATIVO = @ATIVO
		END
--EXEC USP_FUNC_CONSULTAR_TIPO "1", "1"

GO

--CONSULTAR TIPO ESPECIFICO
CREATE PROCEDURE USP_PROF_CONSULTAR_ESPECIFICO
	@TIPO  INT,
	@ATIVO BIT,
	@CAMPO VARCHAR(30),
	@VALOR VARCHAR(50)
AS
	DECLARE @QUERY VARCHAR(500)
	IF(@TIPO = 1)
		BEGIN
			SET @QUERY = 'SELECT ID_PROFESSOR AS ID, NOME, SEXO, RG, CPF, CADASTRO FROM PROFESSOR WHERE ' + @CAMPO + ' LIKE ''' +  @VALOR + ''' AND PROFESSOR.ATIVO = @ATIVO';
			EXEC (@QUERY)
		END
	ELSE IF(@TIPO = 2)
		BEGIN
			SET @QUERY = 'SELECT ID_PROFESSOR AS ID, NOME, EMAIL, TELEFONE, CELULAR FROM PROFESSOR WHERE ' + @CAMPO + ' LIKE ''' +  @VALOR + ''' AND PROFESSOR.ATIVO = @ATIVO';
			EXEC (@QUERY)
		END
	ELSE IF(@TIPO = 3)
		BEGIN
			SET @QUERY = 'SELECT ID_PROFESSOR AS ID, NOME, RUA, NUM, CEP, BAIRRO, CIDADE, ESTADO FROM PROFESSOR WHERE ' + @CAMPO + ' LIKE ''' +  @VALOR + ''' AND PROFESSOR.ATIVO = @ATIVO';
			EXEC (@QUERY)
		END
		
GO

CREATE PROCEDURE USP_PROF_ALTERAR
	@ID_PROFESSOR INT,
	@NOME           VARCHAR(80),
	@SEXO           VARCHAR(20),
	@RG             VARCHAR(50),
	@CPF            VARCHAR(50),
	@RUA            VARCHAR(80),
	@NUM            INT,
	@BAIRRO         VARCHAR(20),
	@CEP            VARCHAR(9),
	@CIDADE         VARCHAR(80),
	@ESTADO         VARCHAR(30),
	@TELEFONE       VARCHAR(20),
	@CELULAR        VARCHAR(20),
	@EMAIL          VARCHAR(80),
	@SENHA          VARCHAR(80),
	@ATIVO          BIT
AS
	DECLARE @COUNT INT
	
	SET @COUNT = (SELECT COUNT(ID_PROFESSOR) FROM PROFESSOR WHERE ID_PROFESSOR = @ID_PROFESSOR)
	
	IF(@COUNT = 1)
		BEGIN
			UPDATE PROFESSOR SET
				NOME = @NOME,
				SEXO = @SEXO,
				RG = @RG,
				CPF = @CPF,
				RUA = @RUA,
				NUM = @NUM,
				BAIRRO = @BAIRRO,
				CEP = @CEP,
				CIDADE = @CIDADE,
				ESTADO = @ESTADO,
				TELEFONE = @TELEFONE,
				CELULAR = @CELULAR,
				EMAIL = @EMAIL,
				SENHA = @SENHA
				WHERE ID_PROFESSOR = @ID_PROFESSOR AND ATIVO = 1;
			SELECT 1
		END
	ELSE
		BEGIN
			SELECT 0
		END

GO

CREATE PROCEDURE USP_PROF_DESATIVAR
	@ID_PROFESSOR INT
AS
	DECLARE @COUNT INT
	
	SET @COUNT = (SELECT COUNT(ID_PROFESSOR) FROM PROFESSOR WHERE ID_PROFESSOR = @ID_PROFESSOR)
	
	IF(@COUNT = 1)
		BEGIN
			UPDATE PROFESSOR SET ATIVO = 0 WHERE ID_PROFESSOR = @ID_PROFESSOR;
			SELECT 1;
		END
	ELSE
		BEGIN
			SELECT 0;
		END
		
GO

--PROVA
--#################################################################################################

CREATE PROCEDURE USP_PROVA_CONSULTAR_TODOS
	@ID_PROFESSOR INT
AS
    IF(@ID_PROFESSOR != 0)
		BEGIN
			SELECT ID_PROVA, NOME, DESCRICAO, CADASTRO FROM PROVA WHERE ID_PROFESSOR = @ID_PROFESSOR
		END
	ELSE
		BEGIN
			SELECT ID_PROVA, NOME, DESCRICAO, CADASTRO FROM PROVA
		END
GO

CREATE PROCEDURE USP_PROVA_CONSULTAR_ESPECIFICO
	@CAMPO VARCHAR(50),
	@VALOR VARCHAR(50)
AS
	SELECT * FROM PROVA WHERE @CAMPO LIKE @VALOR

GO

CREATE PROCEDURE USP_PROVA_INSERIR
	@NOME         VARCHAR(40),
	@DESCRICAO    VARCHAR(100),
	@ID_PROFESSOR INT
AS
	DECLARE @QNT INT

	SET @QNT = (SELECT COUNT(*) FROM PROVA WHERE NOME = @NOME)

	IF(@QNT > 0)
		BEGIN
			SELECT 0
		END
	ELSE
		BEGIN
			INSERT PROVA VALUES (@NOME, @DESCRICAO, @ID_PROFESSOR, DEFAULT);
			SELECT 1
		END
GO

CREATE PROCEDURE USP_PROVA_ALTERAR
	@ID_PROVA  INT,
	@NOME      VARCHAR(40),
	@DESCRICAO VARCHAR(100)
AS
	DECLARE @QNT INT

	SET @QNT = (SELECT COUNT(*) FROM PROVA WHERE ID_PROVA = @ID_PROVA)

	IF(@QNT = 0)
		BEGIN
			UPDATE PROVA SET
				NOME = @NOME,
				DESCRICAO = @DESCRICAO
				WHERE ID_PROVA = @ID_PROVA;
			SELECT 1
		END
	ELSE
		BEGIN
			SELECT 0
		END

GO
--PRODUTOS_VENDAS
CREATE PROCEDURE USP_PRODUTOS_VENDAS_REPORT
AS
	SELECT DISTINCT PRODUTO.ID_PROD, PRODUTO.NOME_PROD, SUM(DETALHE_PEDIDO.VALOR) AS VALOR, SUM(DETALHE_PEDIDO.QNT) AS QUANTIDADE FROM DETALHE_PEDIDO
	INNER JOIN PRODUTO ON 
	DETALHE_PEDIDO.ID_PROD = PRODUTO.ID_PROD
	GROUP BY PRODUTO.ID_PROD, PRODUTO.NOME_PROD
GO
--EXEC USP_PRODUTOS_VENDAS_REPORT


--PROCEDURES ASP
--#################################################################################################

--ALTERAR SENHA
CREATE PROCEDURE USP_ALUNO_ALT_SENHA
	@ID_ALUNO    INT,
	@SENHA_ATUAL VARCHAR(80),
	@SENHA_NOVA  VARCHAR(80)
AS
	DECLARE @QNT INT
	
	SET @QNT = (SELECT COUNT(ID_ALUNO) FROM ALUNO WHERE ID_ALUNO = @ID_ALUNO AND SENHA = @SENHA_ATUAL)
	
	IF(@QNT = 1)
		BEGIN
			UPDATE ALUNO SET SENHA = @SENHA_NOVA WHERE ID_ALUNO = @ID_ALUNO;
			SELECT ('Senha alterada com sucesso')
		END
	ELSE
		BEGIN
			SELECT ('A senha atual não confere!')
		END
--EXEC USP_ALUNO_ALT_SENHA "1", "TESTE", "abc"
GO

--PROCEDURES JAVA
--##############################################################################################

--CONSULTAR PRODUTOS
CREATE PROCEDURE USP_PROD_CONSULTAR_TODOS
AS
	SELECT ID_PROD, NOME_PROD, PRECO, QNT FROM PRODUTO
	
GO

--CONSULTAR PRODUTO POR ID
CREATE PROCEDURE USP_PROD_CONSULTAR_EPECIFICO
	@ID_PROD INT
AS
	SELECT ID_PROD, NOME_PROD, PRECO, QNT FROM PRODUTO WHERE ID_PROD = @ID_PROD

GO

--ALTERAR PRODUTO
CREATE PROCEDURE USP_PROD_ALTERAR
	@ID_PROD INT,
	@NOME    VARCHAR(50),
	@PRECO   DECIMAL(10,2),
	@QNT     INT
AS
	DECLARE @COUNT INT

	SET @COUNT = (SELECT COUNT(ID_PROD) FROM PRODUTO WHERE ID_PROD = @ID_PROD)

	IF(@COUNT = 1)
		BEGIN
			UPDATE PRODUTO SET NOME_PROD = @NOME, PRECO = @PRECO, QNT = @QNT WHERE ID_PROD = @ID_PROD;
			SELECT ('Produto alterado com sucesso')
		END
	ELSE
		BEGIN
			SELECT ('Esse produto nao existe')
		END

GO

--INSERIR FREQUENCIA
CREATE PROCEDURE USP_FREQ_INSERIR
	@ID_AULA  INT,
	@ID_ALUNO INT,
	@PRESENTE BIT
AS
	DECLARE @ALUNO_QNT INT, @AULA_QNT INT

	SET @ALUNO_QNT = (SELECT COUNT(ID_ALUNO) FROM ALUNO WHERE ID_ALUNO = @ID_ALUNO)
	SET @AULA_QNT = (SELECT COUNT(ID_AULA) FROM AULA WHERE ID_AULA = @ID_AULA)

	IF(@ALUNO_QNT = 1 AND @AULA_QNT = 1)
		BEGIN
			INSERT PRESENCA VALUES(@ID_AULA, @ID_ALUNO, @PRESENTE);
			SELECT 1
		END
	ELSE
		BEGIN
			SELECT 0
		END

GO

--CRIAR TURMA
CREATE PROCEDURE USP_TURMA_INSERIR
	@NOME_TURMA VARCHAR(50),
	@ID_CURSO   INT,
	@ID_PERIODO INT
AS
	DECLARE @QNT INT

	SET @QNT = (SELECT COUNT(ID_TURMA) FROM TURMA WHERE NOME_TURMA = @NOME_TURMA)

	IF(@QNT > 0)
		BEGIN
			SELECT ('Por favor escolha outro nome para a turma')
		END
	ELSE
		BEGIN
			INSERT TURMA VALUES(@NOME_TURMA, @ID_CURSO, @ID_PERIODO);
			SELECT ('Turma inserida com sucesso')
		END
GO
