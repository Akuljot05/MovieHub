namespace MovieHub.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {   //1. App-Data - AspNetUsers ~ the users you created
            //2. sql server object explorer -  AspNetRoles ~ the canmanagemovieroles
            //3. sql server object explorer - AspNetUserRoles ~ associate our admin user to the new role
            Sql(@"

INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'12b6b62e-3874-49a3-a0c8-25c00e9706e2', N'guest@moviehub.com', 0, N'AHkkvX/fLeVvaRsWDDqqLDGEru+Ud6H8F1OzlsExhuXWxmj6ttaeX5BJ7Lnt3AuVHg==', N'317ab2d3-990a-42e0-b88f-af5847c3b3b7', NULL, 0, 0, NULL, 1, 0, N'guest@moviehub.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'b54ea12a-14fb-4767-89d0-fdb6cb9ee0b0', N'admin@moviehub.com', 0, N'APaRmS2h7kLWXTgy43Yca9NO7XmQWMAGlXqr4u6gUBjhtmf7wbzfQ1ArcVAfzRqaeQ==', N'2d6cdbb7-bc35-4361-9849-5baba378f189', NULL, 0, 0, NULL, 1, 0, N'admin@moviehub.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'8e05c85c-baea-444c-b41f-9a9df24ef746', N'CanManageMovies')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'b54ea12a-14fb-4767-89d0-fdb6cb9ee0b0', N'8e05c85c-baea-444c-b41f-9a9df24ef746')


");
        }
        
        public override void Down()
        {
        }
    }
}
