namespace er_jobboard.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FirstModel : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.tb_jobboard", "description", c => c.String(maxLength: 150));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.tb_jobboard", "description", c => c.String(maxLength: 100));
        }
    }
}
