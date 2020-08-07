namespace BiletaraKino.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MovieCinemaRooms",
                c => new
                    {
                        Movie_MovieId = c.Int(nullable: false),
                        CinemaRoom_CinemaRoomId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Movie_MovieId, t.CinemaRoom_CinemaRoomId })
                .ForeignKey("dbo.Movies", t => t.Movie_MovieId, cascadeDelete: true)
                .ForeignKey("dbo.CinemaRooms", t => t.CinemaRoom_CinemaRoomId, cascadeDelete: true)
                .Index(t => t.Movie_MovieId)
                .Index(t => t.CinemaRoom_CinemaRoomId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.MovieCinemaRooms", "CinemaRoom_CinemaRoomId", "dbo.CinemaRooms");
            DropForeignKey("dbo.MovieCinemaRooms", "Movie_MovieId", "dbo.Movies");
            DropIndex("dbo.MovieCinemaRooms", new[] { "CinemaRoom_CinemaRoomId" });
            DropIndex("dbo.MovieCinemaRooms", new[] { "Movie_MovieId" });
            DropTable("dbo.MovieCinemaRooms");
        }
    }
}
