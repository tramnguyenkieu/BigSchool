namespace BigSchool.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateCategoryTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO CATEGORIES (ID, NAME) VALUES(1,'Devolopment')");
            Sql("INSERT INTO CATEGORIES (ID, NAME) VALUES(1,'Business')");
            Sql("INSERT INTO CATEGORIES (ID, NAME) VALUES(1,'Marketing')");
        }
        
        public override void Down()
        {
            //thay 
        }
    }
}
