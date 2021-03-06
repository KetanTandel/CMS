USE [MenuTesting]
GO
/****** Object:  StoredProcedure [dbo].[FormMasterDetail]    Script Date: 17/04/2017 12:21:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[FormMasterDetail]
	@qtype varchar(250)=null,
	@id int=0,
	@mainmenuid int=Null,
	@formname varchar(MAX)=Null,
	@formtext varchar(MAX)=Null,
	@parentmenuid int=Null,
	@formdisplayorder int=Null,
	@param varchar(MAX)=Null,
	@insertOnUTC datetime=Null,
	@updateOnUTC datetime=Null
AS
	if(@qtype='Insert')
	insert into FormMaster(id, mainmenuid,formname,formtext,parentmenuid,formdisplayorder,[param],insertOnUTC) output inserted.id values(@id, @mainmenuid,@formname,@formtext,@parentmenuid,@formdisplayorder,@param,getdate())

	if(@qtype='SelectAll')
	Select f.id, f.mainmenuid, m.menuname mainmenu, f.formname, f.formtext, isnull(f.parentmenuid,0) parentmenuid, isnull(p.formtext,'') parentmenu, f.formdisplayorder, isnull(f.param,'') param From  FormMaster f inner join MainMenu m on f.mainmenuid = m.menuid left join FormMaster p on p.id = f.parentmenuid order by f.mainmenuid, f.formdisplayorder

	if(@qtype='SelectParentMenu')
	Select id,formtext From  FormMaster order by formdisplayorder

	if(@qtype='Update')
	update FormMaster set mainmenuid=@mainmenuid, formname=@formname, formtext=@formtext, parentmenuid=@parentmenuid, formdisplayorder=@formdisplayorder, [param]=@param, updateOnUTC=getdate() where id= @id

	if(@qtype='Delete')
	delete FormMaster  where id= @id

	if(@qtype='Select_Id')
	Select id,mainmenuid,formname,formtext,parentmenuid,formdisplayorder,[param] From  FormMaster where id= @id

	if(@qtype='CheckExist')
	Select * From  FormMaster where formname = @formname and id <> @id
GO
/****** Object:  StoredProcedure [dbo].[MainMenuDetail]    Script Date: 17/04/2017 12:21:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[MainMenuDetail]
	@qtype varchar(250)=null,
	@menuid int=0,
	@menuname varchar(250)=Null,
	@displayorder int=Null,
	@insertOnUTC datetime=Null,
	@updateOnUTC datetime=Null
AS
	if(@qtype='Insert')
	insert into MainMenu(menuid, menuname,displayorder,insertOnUTC) output inserted.menuid values(@menuid, @menuname,@displayorder,getdate())

	if(@qtype='SelectAll')
	Select menuid, menuname, displayorder From  MainMenu order by displayorder

	if(@qtype='SelectAllMenu')
	Select menuid, menuname From  MainMenu order by displayorder

	if(@qtype='Update')
	update MainMenu set menuname=@menuname,displayorder=@displayorder,updateOnUTC=getdate() where menuid= @menuid

	if(@qtype='Delete')
	delete MainMenu  where menuid= @menuid

	if(@qtype='Select_Id')
	Select menuid,menuname,displayorder,insertOnUTC,updateOnUTC From  MainMenu where menuid= @menuid

	if(@qtype='CheckExist')
	Select * From  MainMenu where menuname = @menuname and menuid <> @menuid
GO
/****** Object:  Table [dbo].[FormMaster]    Script Date: 17/04/2017 12:21:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[FormMaster](
	[id] [int] NOT NULL,
	[mainmenuid] [int] NULL,
	[formname] [varchar](max) NULL,
	[formtext] [varchar](max) NULL,
	[parentmenuid] [int] NULL,
	[formdisplayorder] [int] NULL,
	[param] [varchar](max) NULL,
	[insertOnUTC] [datetime] NULL,
	[updateOnUTC] [datetime] NULL,
 CONSTRAINT [PK_FormMaster] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[MainMenu]    Script Date: 17/04/2017 12:21:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[MainMenu](
	[menuid] [int] NOT NULL,
	[menuname] [varchar](250) NULL,
	[displayorder] [int] NULL,
	[insertOnUTC] [datetime] NULL,
	[updateOnUTC] [datetime] NULL,
 CONSTRAINT [PK_MainMenu] PRIMARY KEY CLUSTERED 
(
	[menuid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
ALTER TABLE [dbo].[FormMaster]  WITH CHECK ADD  CONSTRAINT [FK_FormMaster_MainMenu] FOREIGN KEY([mainmenuid])
REFERENCES [dbo].[MainMenu] ([menuid])
GO
ALTER TABLE [dbo].[FormMaster] CHECK CONSTRAINT [FK_FormMaster_MainMenu]
GO
