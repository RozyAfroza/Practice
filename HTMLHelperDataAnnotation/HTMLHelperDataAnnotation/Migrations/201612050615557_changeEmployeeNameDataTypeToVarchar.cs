namespace HTMLHelperDataAnnotation.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changeEmployeeNameDataTypeToVarchar : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Employees", "Name", c => c.String(nullable: false, maxLength: 20, unicode: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Employees", "Name", c => c.String(nullable: false, maxLength: 20));
        }
    }
}
