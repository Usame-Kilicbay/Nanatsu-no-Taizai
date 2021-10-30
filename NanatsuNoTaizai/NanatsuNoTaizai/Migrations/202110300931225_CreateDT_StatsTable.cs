namespace NanatsuNoTaizai.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateDT_StatsTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.DT_Stats",
                c => new
                    {
                        StatisticID = c.Byte(nullable: false),
                        Magic = c.Int(nullable: false),
                        Strength = c.Int(nullable: false),
                        Spirit = c.Int(nullable: false),
                        Power = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.StatisticID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.DT_Stats");
        }
    }
}
