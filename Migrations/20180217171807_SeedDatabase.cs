using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace carApp.Migrations
{
    public partial class SeedDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Makes (Name) VALUES ('Tesla')");
            migrationBuilder.Sql("INSERT INTO Makes (Name) VALUES ('Honda')");
            migrationBuilder.Sql("INSERT INTO Makes (Name) VALUES ('Toyota')");

            migrationBuilder.Sql("INSERT INTO Models (Name, MakeId) VALUES ('ModelS',(Select ID from Makes Where Name='Tesla'))");
            migrationBuilder.Sql("INSERT INTO Models (Name, MakeId) VALUES ('ModelX',(Select ID from Makes Where Name='Tesla'))");
            migrationBuilder.Sql("INSERT INTO Models (Name, MakeId) VALUES ('Model3',(Select ID from Makes Where Name='Tesla'))");

            migrationBuilder.Sql("INSERT INTO Models (Name, MakeId) VALUES ('Accord',(Select ID from Makes Where Name='Honda'))");
            migrationBuilder.Sql("INSERT INTO Models (Name, MakeId) VALUES ('Civic',(Select ID from Makes Where Name='Honda'))");
            migrationBuilder.Sql("INSERT INTO Models (Name, MakeId) VALUES ('Jazz',(Select ID from Makes Where Name='Honda'))");

            migrationBuilder.Sql("INSERT INTO Models (Name, MakeId) VALUES ('Rav4',(Select ID from Makes Where Name='Toyota'))");
            migrationBuilder.Sql("INSERT INTO Models (Name, MakeId) VALUES ('Prius',(Select ID from Makes Where Name='Toyota'))");
            migrationBuilder.Sql("INSERT INTO Models (Name, MakeId) VALUES ('Outlander',(Select ID from Makes Where Name='Toyota'))");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("Delete from Makes where Name in ('Tesla','Honda','Toyota')");
            

        }
    }
}
