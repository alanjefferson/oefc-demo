SET SERVEROUTPUT ON

DECLARE
	usuario VARCHAR2(30);
	tabela VARCHAR2(30);
	objeto VARCHAR2(30);
	versao VARCHAR2(10);
	existence NUMBER;
	index_pk NUMBER;
BEGIN
  usuario := 'TICKET_DISCAFACIL';
  versao := '1.0';

  DBMS_OUTPUT.PUT_LINE('INICIO SCRIPT VERSAO: ' || versao);

  objeto := 'VALIDA_CEP';
  SELECT COUNT(*) INTO existence FROM ALL_ALL_TABLES WHERE OWNER = usuario AND TABLE_NAME = objeto;
  IF existence = 0 THEN 
    BEGIN
      DBMS_OUTPUT.PUT_LINE('CRIACAO DA TABELA ' || usuario || '.' || objeto);
            EXECUTE IMMEDIATE
              'CREATE TABLE ' || usuario || '.' || objeto  || CHR(13) || CHR(10) ||
              '("VACE_CD_ID_PK" NUMBER(38,0) NOT NULL,' || CHR(13) || CHR(10) ||
              ' "VACE_TX_NUMERO_CEP" VARCHAR2(5 BYTE) NOT NULL,' || CHR(13) || CHR(10) ||
              ' "VACE_TX_COMPLEMENTO_CEP" VARCHAR2(5 BYTE) NOT NULL,' || CHR(13) || CHR(10) ||
              ' CONSTRAINT "VACE_CD_ID_PK" PRIMARY KEY ("VACE_CD_ID_PK"))';

            EXECUTE IMMEDIATE
                'COMMENT ON COLUMN "' || usuario || '"."' || objeto || '"."VACE_CD_ID_PK" IS ''Chave primaria controlada pela SEQ_TIPO_INTEGRACAO_SERVICO.''';
            EXECUTE IMMEDIATE
                'COMMENT ON COLUMN "' || usuario || '"."' || objeto || '"."VACE_TX_NUMERO_CEP" IS ''Numero CEP.''';
            EXECUTE IMMEDIATE
                'COMMENT ON COLUMN "' || usuario || '"."' || objeto || '"."VACE_TX_COMPLEMENTO_CEP" IS ''Complemento CEP.''';
    END;
  END IF;

  IF existence >= 1 THEN 
    BEGIN
      DBMS_OUTPUT.PUT_LINE('TABELA EXISTENTE: ' || objeto);
    END;
  END IF;

  objeto := 'SEQ_VALIDA_CEP';
  SELECT COUNT(*) INTO existence FROM ALL_SEQUENCES WHERE SEQUENCE_OWNER = usuario AND SEQUENCE_NAME = objeto;
  IF existence = 0 THEN 
    BEGIN
      DBMS_OUTPUT.PUT_LINE('CRIACAO DA SEQUENCE ' || objeto);      
      EXECUTE IMMEDIATE
        'CREATE SEQUENCE "' || usuario || '"."' || objeto || '"';
    END;
  END IF;

  IF existence >= 1 THEN 
    BEGIN
      DBMS_OUTPUT.PUT_LINE('SEQUENCE EXISTENTE: ' || objeto);
    END;
  END IF;
 
  index_pk := 1;
	EXECUTE IMMEDIATE 'SELECT COUNT(*) FROM "' || usuario || '"."VALIDA_CEP" WHERE VACE_CD_ID_PK = ' || index_pk INTO existence;
	IF existence = 0 THEN 
		BEGIN
			DBMS_OUTPUT.PUT_LINE('INCLUINDO REGISTRO ' || index_pk || ' NA TABELA VALIDA_CEP');
			EXECUTE IMMEDIATE 'INSERT INTO "' || usuario || '"."VALIDA_CEP" ' || CHR(13) || CHR(10) ||
			'(VACE_CD_ID_PK,VACE_TX_NUMERO_CEP,VACE_TX_COMPLEMENTO_CEP) ' || CHR(13) || CHR(10) ||
			'VALUES ('|| index_pk || ', ''05787'', ''000'')';
		END;
	END IF;

  DBMS_OUTPUT.PUT_LINE('FIM SCRIPT VERSAO: ' || versao);
END;
/