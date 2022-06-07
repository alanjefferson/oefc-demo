SET SERVEROUTPUT ON

DECLARE
	usuario VARCHAR2(30);
	tabela VARCHAR2(30);
	objeto VARCHAR2(30);
	versao VARCHAR2(10);
	existence NUMBER;
	tipo_pk NUMBER;
BEGIN
  usuario := 'TICKET_DISCAFACIL';
  versao := '1.0';

  DBMS_OUTPUT.PUT_LINE('INICIO SCRIPT VERSAO: ' || versao);

  objeto := 'TIPO_INTEGRACAO_SERVICO';
  SELECT COUNT(*) INTO existence FROM ALL_ALL_TABLES WHERE OWNER = usuario AND TABLE_NAME = objeto;
  IF existence = 0 THEN 
    BEGIN
      DBMS_OUTPUT.PUT_LINE('CRIACAO DA TABELA ' || usuario || '.' || objeto);
            EXECUTE IMMEDIATE
              'CREATE TABLE ' || usuario || '.' || objeto  || CHR(13) || CHR(10) ||
              '("TIIS_CD_ID_PK" NUMBER(38,0) NOT NULL,' || CHR(13) || CHR(10) ||
              ' "TIIS_TX_DESCRICAO" VARCHAR2(255 BYTE) NOT NULL,' || CHR(13) || CHR(10) ||
              ' CONSTRAINT "TIIS_CD_ID_PK" PRIMARY KEY ("TIIS_CD_ID_PK"))';

            EXECUTE IMMEDIATE
                'COMMENT ON COLUMN "' || usuario || '"."' || objeto || '"."TIIS_CD_ID_PK" IS ''Chave primaria controlada pela SEQ_TIPO_INTEGRACAO_SERVICO.''';
            EXECUTE IMMEDIATE
                'COMMENT ON COLUMN "' || usuario || '"."' || objeto || '"."TIIS_TX_DESCRICAO" IS ''Descricao do tipo de integracao a ser logado na tabela LOG_INTEGRACAO_SERVICO.''';
    END;
  END IF;

  IF existence >= 1 THEN 
    BEGIN
      DBMS_OUTPUT.PUT_LINE('TABELA EXISTENTE: ' || objeto);
    END;
  END IF;

  objeto := 'SEQ_TIPO_INTEGRACAO_SERVICO';
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
 
  tipo_pk := 1;
	EXECUTE IMMEDIATE 'SELECT COUNT(*) FROM "' || usuario || '"."TIPO_INTEGRACAO_SERVICO" WHERE TIIS_CD_ID_PK = ' || tipo_pk INTO existence;
	IF existence = 0 THEN 
		BEGIN
			DBMS_OUTPUT.PUT_LINE('INCLUINDO REGISTRO ' || tipo_pk || ' NA TABELA TIPO_INTEGRACAO_SERVICO');
			EXECUTE IMMEDIATE 'INSERT INTO "' || usuario || '"."TIPO_INTEGRACAO_SERVICO" ' || CHR(13) || CHR(10) ||
			'(TIIS_CD_ID_PK,TIIS_TX_DESCRICAO) ' || CHR(13) || CHR(10) ||
			'VALUES ('|| tipo_pk || ', ''API MyTracking'')';
		END;
	END IF;

  objeto := 'LOG_INTEGRACAO_SERVICO';
  SELECT COUNT(*) INTO existence FROM ALL_ALL_TABLES WHERE OWNER = usuario AND TABLE_NAME = objeto;
  IF existence = 0 THEN 
    BEGIN
      DBMS_OUTPUT.PUT_LINE('CRIACAO DA TABELA ' || usuario || '.' || objeto);
            EXECUTE IMMEDIATE
              'CREATE TABLE ' || usuario || '.' || objeto  || CHR(13) || CHR(10) ||
              '("LOIS_CD_ID_PK" NUMBER(38,0) NOT NULL,' || CHR(13) || CHR(10) ||
              ' "LOIS_DT_EXECUCAO" DATE NOT NULL,' || CHR(13) || CHR(10) ||
              ' "LOIS_TX_SOLICITACAO" CLOB NULL,' || CHR(13) || CHR(10) ||
              ' "LOIS_TX_RETORNO" CLOB NULL,' || CHR(13) || CHR(10) ||
              ' "TIIS_CD_ID_FK" NUMBER(38,0) NOT NULL,' || CHR(13) || CHR(10) ||              
              ' "LOOF_CD_ID_FK" NUMBER(38,0) NULL,' || CHR(13) || CHR(10) ||              
              ' CONSTRAINT "LOIS_CD_ID_PK" PRIMARY KEY ("LOIS_CD_ID_PK"))';

            EXECUTE IMMEDIATE
                'COMMENT ON COLUMN "' || usuario || '"."' || objeto || '"."LOIS_CD_ID_PK" IS ''Chave primaria controlada pela SEQ_LOG_INTEGRACAO_SERVICO.''';
            EXECUTE IMMEDIATE
                'COMMENT ON COLUMN "' || usuario || '"."' || objeto || '"."LOIS_DT_EXECUCAO" IS ''Data da execucao do servico.''';
            EXECUTE IMMEDIATE
                'COMMENT ON COLUMN "' || usuario || '"."' || objeto || '"."LOIS_TX_SOLICITACAO" IS ''Campos enviados na solicitacao ao servico.''';
            EXECUTE IMMEDIATE
                'COMMENT ON COLUMN "' || usuario || '"."' || objeto || '"."LOIS_TX_RETORNO" IS ''Retorno do servico apos solicitacao.''';
            EXECUTE IMMEDIATE
                'COMMENT ON COLUMN "' || usuario || '"."' || objeto || '"."TIIS_CD_ID_FK" IS ''Tipo da integracao de acordo com o cadastrado na tabela TIPO_INTEGRACAO_SERVICO.''';
            EXECUTE IMMEDIATE
                'COMMENT ON COLUMN "' || usuario || '"."' || objeto || '"."LOOF_CD_ID_FK" IS ''Chave estrangeira da tabela LOG_OCORRENCIA_FECHADO.''';
    END;
  END IF;
	
  IF existence >= 1 THEN 
    BEGIN
      DBMS_OUTPUT.PUT_LINE('TABELA EXISTENTE: ' || objeto);
    END;
  END IF;

  objeto := 'SEQ_LOG_INTEGRACAO_SERVICO';
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

  tabela := 'LOG_INTEGRACAO_SERVICO';
  objeto := 'LOIS_IDX_TIPO';
  SELECT COUNT(*) INTO existence FROM all_indexes WHERE OWNER = usuario AND TABLE_NAME = tabela AND INDEX_NAME = objeto;
  IF existence = 0 THEN 
    BEGIN
      DBMS_OUTPUT.PUT_LINE('CRIACAO DO INDICE ' || objeto || ' NA TABELA ' || tabela);
      EXECUTE IMMEDIATE
				'CREATE INDEX ' || usuario || '.' || objeto || ' ON '|| usuario || '.' || tabela || ' ("TIIS_CD_ID_FK")';
    END;
  END IF;

  IF existence >= 1 THEN 
    BEGIN
      DBMS_OUTPUT.PUT_LINE('INDEX EXISTENTE: ' || objeto);
    END;
  END IF;

  tabela := 'LOG_INTEGRACAO_SERVICO';
  objeto := 'LOIS_IDX_LOOF';
  SELECT COUNT(*) INTO existence FROM all_indexes WHERE OWNER = usuario AND TABLE_NAME = tabela AND INDEX_NAME = objeto;
  IF existence = 0 THEN 
    BEGIN
      DBMS_OUTPUT.PUT_LINE('CRIACAO DO INDICE ' || objeto || ' NA TABELA ' || tabela);
      EXECUTE IMMEDIATE
				'CREATE INDEX ' || usuario || '.' || objeto || ' ON '|| usuario || '.' || tabela || ' ("LOOF_CD_ID_FK")';
    END;
  END IF;

  IF existence >= 1 THEN 
    BEGIN
      DBMS_OUTPUT.PUT_LINE('INDEX EXISTENTE: ' || objeto);
    END;
  END IF;

  DBMS_OUTPUT.PUT_LINE('FIM SCRIPT VERSAO: ' || versao);
END;
/