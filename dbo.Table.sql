CREATE TABLE [dbo].[tblstd](
    [Firstname]  NVARCHAR (50) NOT NULL,
    [Lastname]   NVARCHAR (50) NOT NULL,
    [Student ID] NCHAR (10)    NOT NULL,
    [Term ]      INT           NOT NULL,
    [Major]      NVARCHAR (50) NOT NULL,
    [Lesson]     NVARCHAR (50) NOT NULL,
    PRIMARY KEY CLUSTERED ([Student ID])
);

