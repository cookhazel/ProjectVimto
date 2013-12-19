CREATE TABLE [dbo].[Patient] (
    [Id]               INT        IDENTITY (1, 1) NOT NULL,
    [PatientFirstName] NCHAR (30) NOT NULL,
    [PatientLastName]  NCHAR (30) NOT NULL,
    [PatientDOB]       DATE       NOT NULL,
    [PatientAddress]   NCHAR (50) NOT NULL, 
    CONSTRAINT [PK_Patient] PRIMARY KEY ([Id]),
);

