namespace NanatsuNoTaizai.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateDT_AbilitiesTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.DT_Abilities",
                c => new
                    {
                        AbilityID = c.Byte(nullable: false),
                        AbilityName = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.AbilityID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.DT_Abilities");
        }
    }
}
