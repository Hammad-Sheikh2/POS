CREATE TABLE [dbo].[Categories] (
    [Value] NVARCHAR (50) NOT NULL,
    PRIMARY KEY CLUSTERED ([Value] ASC)
);

CREATE TABLE [dbo].[Cities] (
    [Value] NVARCHAR (50) NOT NULL,
    PRIMARY KEY CLUSTERED ([Value] ASC)
);

CREATE TABLE [dbo].[Customers] (
    [Id]          INT           NOT NULL,
    [Name]        NVARCHAR (50) NULL,
    [Category]    NVARCHAR (50) NULL,
    [City]        NVARCHAR (50) NULL,
    [Province]    NVARCHAR (50) NULL,
    [Email]       NVARCHAR (50) NULL,
    [Contact1]    NVARCHAR (50) NULL,
    [Contact2]    NVARCHAR (50) NULL,
    [AirtelMoney] NVARCHAR (50) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

CREATE TABLE [dbo].[DayClosings] (
    [DayId]       INT        IDENTITY (1, 1) NOT NULL,
    [ClosingDate] DATE       NULL,
    [TotalAmount] FLOAT (53) NULL,
    [PaidAmount]  FLOAT (53) NULL,
    PRIMARY KEY CLUSTERED ([DayId] ASC),
    UNIQUE NONCLUSTERED ([ClosingDate] ASC)
);

CREATE TABLE [dbo].[InvoiceDetails] (
    [InvoiceId]   INT           NULL,
    [ProductId]   INT           NULL,
    [ProductName] NVARCHAR (50) NULL,
    [RetailUnit]  FLOAT (53)    NULL,
    [UnitPrice]   FLOAT (53)    NULL,
    [Quantity]    FLOAT (53)    NULL,
    [Total]       FLOAT (53)    NULL
);

CREATE TABLE [dbo].[Invoices] (
    [Id]          INT        NOT NULL,
    [CustomerId]  INT        NULL,
    [InvoiceDate] DATE       NULL,
    [Credit]      BIT        NULL,
    [Total]       FLOAT (53) NULL,
    [Paid]        FLOAT (53) NULL,
    [UserId]      INT        NULL,
    [ShiftId]     INT        NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

CREATE TABLE [dbo].[Products] (
    [Id]                  INT           NOT NULL,
    [ProductName]         NVARCHAR (50) NULL,
    [ProductShape]        NVARCHAR (50) NULL,
    [ProductWeight]       FLOAT (53)    DEFAULT ((0)) NULL,
    [QuantityInStore]     FLOAT (53)    DEFAULT ((0)) NULL,
    [QuantityInShelves]   FLOAT (53)    DEFAULT ((0)) NULL,
    [QuantityInBox]       FLOAT (53)    DEFAULT ((0)) NULL,
    [QuantityMaxInShelve] FLOAT (53)    DEFAULT ((0)) NULL,
    [UnitPrice]           FLOAT (53)    DEFAULT ((0)) NULL,
    [PurchasePrice]       FLOAT (53)    DEFAULT ((0)) NULL,
    [SellingPrice]        FLOAT (53)    DEFAULT ((0)) NULL,
    [ShelfCode]           VARCHAR (50)  NULL,
    [AlertThreshold]      FLOAT (53)    DEFAULT ((0)) NULL,
    [CreatedBy]           NVARCHAR (50) NULL,
    [DateCreated]         DATE          DEFAULT (getdate()) NULL,
    [DateModified]        DATE          DEFAULT (getdate()) NULL,
    [ExpiryDate]          DATE          DEFAULT (getdate()) NULL,
    [SupplierName]        NVARCHAR (50) NULL,
    [Store]               BIT           DEFAULT ((0)) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

CREATE TABLE [dbo].[Provinces] (
    [Value] NVARCHAR (50) NOT NULL,
    PRIMARY KEY CLUSTERED ([Value] ASC)
);

CREATE TABLE [dbo].[Purchases] (
    [Id]            INT            NOT NULL,
    [ProductName]   NVARCHAR (MAX) NULL,
    [SupplierName]  NVARCHAR (50)  NULL,
    [PurchasePrice] FLOAT (53)     NULL,
    [Quantity]      FLOAT (53)     NULL,
    [PurchaseDate]  DATE           NULL,
    [TotalPaid]     FLOAT (53)     NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

CREATE TABLE [dbo].[ShelfNumbers] (
    [Value] NVARCHAR (50) NOT NULL,
    PRIMARY KEY CLUSTERED ([Value] ASC)
);

CREATE TABLE [dbo].[Shifts] (
    [Id]             INT            NOT NULL,
    [QuantitySold]   FLOAT (53)     NULL,
    [UserId]         INT            NULL,
    [TotalAmount]    FLOAT (53)     NULL,
    [PaidAmount]     FLOAT (53)     NULL,
    [CreditInvoices] INT            NULL,
    [CashInvoices]   INT            NULL,
    [Explanation]    NVARCHAR (MAX) NULL,
    [ClosedOn]       DATE           NULL,
    CONSTRAINT [PK_Shifts] PRIMARY KEY CLUSTERED ([Id] ASC)
);

CREATE TABLE [dbo].[Suppliers] (
    [Id]          INT           NOT NULL,
    [Name]        NVARCHAR (50) NULL,
    [City]        NVARCHAR (50) NULL,
    [Province]    NVARCHAR (50) NULL,
    [Email]       NVARCHAR (50) NULL,
    [Contact1]    NVARCHAR (50) NULL,
    [Contact2]    NVARCHAR (50) NULL,
    [AirtelMoney] NVARCHAR (50) NULL,
    [BankAccount] NVARCHAR (50) NULL,
    [Category]    NVARCHAR (50) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

CREATE TABLE [dbo].[Users] (
    [Id]       INT           NOT NULL,
    [Name]     NVARCHAR (50) NULL,
    [Username] NVARCHAR (50) NULL,
    [Pass]     NVARCHAR (50) NULL,
    [Role]     NVARCHAR (50) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

CREATE TABLE [dbo].[Variables] (
    [Variable] VARCHAR (50)  NOT NULL,
    [Value]    NVARCHAR (50) NULL,
    PRIMARY KEY CLUSTERED ([Variable] ASC)
);

INSERT INTO [dbo].[Variables] ([Variable], [Value]) VALUES (N'Shift', N'1')

CREATE TABLE [dbo].[Weights] (
    [Value] FLOAT (53) NOT NULL,
    CONSTRAINT [PK_Table] PRIMARY KEY CLUSTERED ([Value] ASC)
);


