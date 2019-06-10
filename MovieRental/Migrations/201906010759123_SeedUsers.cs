namespace MovieRental.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'7a61a6a0-a908-4e12-b69d-9d38784bd705', N'Abid@gmail.com', 0, N'APytcPtZO9iOhbra/IA5YNipgdrjKP2DkHOQyJOmS8wYDtYyBRask8rCDA/ddnw6Jw==', N'c89fbb85-fa2e-4242-951b-2d9115355dec', NULL, 0, 0, NULL, 1, 0, N'Abid@gmail.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'c5d59fc2-6ff7-437e-bb13-bdcd8c1489e8', N'admin@movierental.com', 0, N'AEwwMH4lFP71/fLz46XcmM4Cua0DWBAKxTOtq4dfQ+OzUDfbxkjUIjC0zdPt/SRn5A==', N'c5fd5ec2-de5d-4c18-a4b5-8671a25ba376', NULL, 0, 0, NULL, 1, 0, N'admin@movierental.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'e014d5b2-2e99-4064-a096-500767fac7de', N'CanManageMovies')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'c5d59fc2-6ff7-437e-bb13-bdcd8c1489e8', N'e014d5b2-2e99-4064-a096-500767fac7de')

");
        }
        
        public override void Down()
        {
        }
    }
}
