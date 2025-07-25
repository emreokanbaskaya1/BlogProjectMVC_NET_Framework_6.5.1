﻿namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_writertitle_add : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Writers", "WriteTitle", c => c.String(maxLength: 200));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Writers", "WriteTitle");
        }
    }
}
