namespace MvcOnlineTicariOtomasyon.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class denemekargo9 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.mesajlars", "Konu", c => c.String(maxLength: 40, unicode: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.mesajlars", "Konu", c => c.String(maxLength: 50, unicode: false));
        }
    }
}
