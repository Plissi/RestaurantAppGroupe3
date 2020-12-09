/*------------------------------------------------------------
*        Script SQLSERVER 
------------------------------------------------------------*/


/*------------------------------------------------------------
-- Table: Recette
------------------------------------------------------------*/
CREATE TABLE Recette(
	ID     INT IDENTITY (1,1) NOT NULL ,
	Nom    TEXT  NOT NULL ,
	Prix   INT  NOT NULL  ,
	CONSTRAINT Recette_PK PRIMARY KEY (ID)
);


/*------------------------------------------------------------
-- Table: StockIngredients
------------------------------------------------------------*/
CREATE TABLE StockIngredients(
	ID          INT IDENTITY (1,1) NOT NULL ,
	Nom         TEXT  NOT NULL ,
	Stock       INT  NOT NULL ,
	Categorie   TEXT  NOT NULL  ,
	CONSTRAINT StockIngredients_PK PRIMARY KEY (ID)
);


/*------------------------------------------------------------
-- Table: IngredientRecette
------------------------------------------------------------*/
CREATE TABLE IngredientRecette(
	ID             INT  NOT NULL ,
	Quantite       INT  NOT NULL ,
	IDrecette      INT  NOT NULL ,
	IDingredient   INT  NOT NULL  ,
	CONSTRAINT IngredientRecette_PK PRIMARY KEY (ID) ,
	CONSTRAINT IngredientRecette_AK UNIQUE (IDrecette,IDingredient)
);


/*------------------------------------------------------------
-- Table: ReservationTable
------------------------------------------------------------*/
CREATE TABLE ReservationTable(
	ID               INT IDENTITY (1,1) NOT NULL ,
	NomReservation   TEXT  NOT NULL ,
	NbPersonne       INT  NOT NULL ,
	Horaire          INT  NOT NULL  ,
	CONSTRAINT ReservationTable_PK PRIMARY KEY (ID)
);


/*------------------------------------------------------------
-- Table: Materiel
------------------------------------------------------------*/
CREATE TABLE Materiel(
	ID         INT IDENTITY (1,1) NOT NULL ,
	Nom        TEXT  NOT NULL ,
	Quantite   INT  NOT NULL  ,
	CONSTRAINT Materiel_PK PRIMARY KEY (ID)
);


/*------------------------------------------------------------
-- Table: Commande
------------------------------------------------------------*/
CREATE TABLE Commande(
	ID            INT IDENTITY (1,1) NOT NULL ,
	IDRecette     INT  NOT NULL ,
	NomRecette    TEXT  NOT NULL ,
	PrixRecette   INT  NOT NULL  ,
	CONSTRAINT Commande_PK PRIMARY KEY (ID)
);


/*------------------------------------------------------------
-- Table: Contenir
------------------------------------------------------------*/
CREATE TABLE Contenir(
	ID           INT  NOT NULL ,
	ID_Recette   INT  NOT NULL  ,
	CONSTRAINT Contenir_PK PRIMARY KEY (ID,ID_Recette)

	,CONSTRAINT Contenir_IngredientRecette_FK FOREIGN KEY (ID) REFERENCES IngredientRecette(ID)
	,CONSTRAINT Contenir_Recette0_FK FOREIGN KEY (ID_Recette) REFERENCES Recette(ID)
);


/*------------------------------------------------------------
-- Table: Avoir
------------------------------------------------------------*/
CREATE TABLE Avoir(
	ID           INT  NOT NULL ,
	ID_Recette   INT  NOT NULL  ,
	CONSTRAINT Avoir_PK PRIMARY KEY (ID,ID_Recette)

	,CONSTRAINT Avoir_Commande_FK FOREIGN KEY (ID) REFERENCES Commande(ID)
	,CONSTRAINT Avoir_Recette0_FK FOREIGN KEY (ID_Recette) REFERENCES Recette(ID)
);



