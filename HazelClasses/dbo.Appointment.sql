CREATE TABLE [dbo].[Appointment] (
    [Id]                  INT        IDENTITY (1, 1) NOT NULL,
    [AppointmentDateTime] DATETIME   NOT NULL,
    [StaffID]             NCHAR (10) NOT NULL,
    [PatientID]           NCHAR (10) NOT NULL,
    CONSTRAINT [PK_Appointment] PRIMARY KEY CLUSTERED ([Id] ASC)
);

