using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MVC_Core_DbFirst.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "PankajBatch");

            migrationBuilder.CreateTable(
                name: "Person",
                schema: "PankajBatch",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Age = table.Column<int>(type: "int", nullable: true),
                    Address = table.Column<string>(type: "varchar(300)", unicode: false, maxLength: 300, nullable: true),
                    PhoneNo = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Person__3214EC07ED972CA7", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProdID = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    Category = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    Price = table.Column<double>(type: "float", nullable: true),
                    Description = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Products__042785C5A577B5DE", x => x.ProdID);
                });

            migrationBuilder.CreateTable(
                name: "StudentInfo",
                columns: table => new
                {
                    RollNo = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    Age = table.Column<short>(type: "smallint", nullable: false),
                    LocalAddr = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    PerAddr = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    PhoneNo = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    SchoolName = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true, defaultValue: "Air Force School")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__StudentI__7886D5A0C840120B", x => x.RollNo);
                });

            migrationBuilder.CreateTable(
                name: "StudentMarks",
                columns: table => new
                {
                    srNo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RollNo = table.Column<int>(type: "int", nullable: true),
                    Physics = table.Column<int>(type: "int", nullable: false),
                    Chem = table.Column<int>(type: "int", nullable: false),
                    Maths = table.Column<int>(type: "int", nullable: false),
                    TotalMarks = table.Column<int>(type: "int", nullable: true, computedColumnSql: "(([Physics]+[Chem])+[Maths])", stored: false),
                    Perc = table.Column<int>(type: "int", nullable: true, computedColumnSql: "((([Physics]+[Chem])+[Maths])/(3))", stored: false)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK__StudentMa__RollN__68487DD7",
                        column: x => x.RollNo,
                        principalTable: "StudentInfo",
                        principalColumn: "RollNo");
                });

            migrationBuilder.CreateIndex(
                name: "IX_StudentMarks_RollNo",
                table: "StudentMarks",
                column: "RollNo");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Person",
                schema: "PankajBatch");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "StudentMarks");

            migrationBuilder.DropTable(
                name: "StudentInfo");
        }
    }
}
