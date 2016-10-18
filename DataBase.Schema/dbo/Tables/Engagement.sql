create table dbo.Engagements
(
	Id int not null identity (1, 1),
	Name nvarchar(100) not null,
	Description nvarchar(100),
	CONSTRAINT PK_Engagement primary KEY (Id), 
	CONSTRAINT UQ_Engagement_EngagementName unique (Name)
)