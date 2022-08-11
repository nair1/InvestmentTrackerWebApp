CREATE TABLE USER_LOGINS (
	USR_NM varchar(32) NOT NULL PRIMARY KEY,
	PSS_WRD varchar(max) NOT NULL,
	FRST_NM varchar(max) NOT NULL,
	LST_NM varchar(max) NOT NULL,
	EMAIL varchar(max) NOT NULL
);