namespace NanatsuNoTaizai.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateCharactersColumnInDT_Abilities : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.DT_Character", "Ability_AbilityID", c => c.Byte());
            CreateIndex("dbo.DT_Character", "Ability_AbilityID");
            AddForeignKey("dbo.DT_Character", "Ability_AbilityID", "dbo.DT_Abilities", "AbilityID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.DT_Character", "Ability_AbilityID", "dbo.DT_Abilities");
            DropIndex("dbo.DT_Character", new[] { "Ability_AbilityID" });
            DropColumn("dbo.DT_Character", "Ability_AbilityID");
        }
    }
}
