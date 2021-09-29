using Microsoft.EntityFrameworkCore.Migrations;

namespace DoctorWho.Db.Migrations
{
    public partial class View : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
                migrationBuilder.Sql(@"CREATE VIEW viewEpisodes AS(
                    select  *,
                    DoctorWho.dbo.fnAuthors(E.EpisodeId) as Authors,
                    DoctorWho.dbo.fnDoctors(E.EpisodeId) as Doctors,
                    DoctorWho.dbo.fnEnemies(E.EpisodeId) as Enemies ,
                    DoctorWho.dbo.fnCompanions(E.EpisodeId) as Companions from Episode E)");

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("Drop view viewEpisodes");

        }
    }
}
