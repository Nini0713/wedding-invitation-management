# wedding-invitation-management

## DATABASE AND DATA TYPE
CREATE TABLE [dbo].[INVITEES] (
[FirstName] VARCHAR (50) NOT NULL,
[LastName] VARCHAR (50) NOT NULL,
[PhoneNumber] NVARCHAR (50) NOT NULL,
[Email] NVARCHAR (50) NOT NULL,
[TableNumber] NCHAR (2) NOT NULL,
PRIMARY KEY CLUSTERED ([FirstName] ASC),
FOREIGN KEY ([TableNumber]) REFERENCES [dbo].[TBL] ([TableNumber])
);

![dbo INVITEES](https://github.com/user-attachments/assets/58e310b0-e071-428e-87e8-56af60fa0aae)


CREATE TABLE [dbo].[TBL] (
[TableNumber] NCHAR (2) NOT NULL,
PRIMARY KEY CLUSTERED ([TableNumber] ASC)
);

![dbo TBL](https://github.com/user-attachments/assets/94228621-a373-40c8-ab97-12d9b3f31ce4)


a. TABLE = INVITEES


![image](https://github.com/user-attachments/assets/16a33faa-e5a2-4cf8-9224-62d0694dc218)



b. TABLE = TBL


![image](https://github.com/user-attachments/assets/aff5430c-511f-4d91-99df-8bac55dc39db)

## FORM AND CODING QUERY


![image](https://github.com/user-attachments/assets/f2523ab1-c55f-48ef-8815-97498dc72ce9)




