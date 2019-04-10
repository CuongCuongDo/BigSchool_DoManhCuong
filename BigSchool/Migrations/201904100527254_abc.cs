namespace BigSchool.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class abc : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Courses", name: "LectureId", newName: "LecturerId");
            RenameIndex(table: "dbo.Courses", name: "IX_LectureId", newName: "IX_LecturerId");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.Courses", name: "IX_LecturerId", newName: "IX_LectureId");
            RenameColumn(table: "dbo.Courses", name: "LecturerId", newName: "LectureId");
        }
    }
}
