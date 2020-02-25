namespace RestaurantRater.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changed_properties : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Restaurants", "Symbol", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Restaurants", "Symbol");
        }
    }
}
