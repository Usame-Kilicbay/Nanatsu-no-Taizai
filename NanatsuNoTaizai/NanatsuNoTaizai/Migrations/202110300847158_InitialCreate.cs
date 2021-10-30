namespace NanatsuNoTaizai.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.DT_Character",
                c => new
                    {
                        CharacterID = c.Byte(nullable: false),
                        CharacterName = c.String(maxLength: 50),
                        CharacterAge = c.Short(nullable: false),
                    })
                .PrimaryKey(t => t.CharacterID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.DT_Character");
        }
    }
}
