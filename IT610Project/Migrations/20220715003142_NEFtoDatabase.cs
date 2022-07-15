using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IT610Project.Migrations
{
    public partial class NEFtoDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AuditLogNewEquipment",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FormField = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FormFieldPreviousValue = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FormFieldNewValue = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateRead = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateDeleted = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AuditLogTimeStamp = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AuditLogNewEquipment", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AuditLogUserPermissions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FormField = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FormFieldPreviousValue = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FormFieldNewValue = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateRead = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateDeleted = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AuditLogTimeStamp = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AuditLogUserPermissions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "NewEquipment",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ControlNo = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    Serial = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    SystemKey = table.Column<int>(type: "int", nullable: true),
                    VendorKey = table.Column<int>(type: "int", nullable: false),
                    ModelKey = table.Column<int>(type: "int", nullable: false),
                    EquipmentStatKey = table.Column<int>(type: "int", nullable: false),
                    EquipmentCondKey = table.Column<int>(type: "int", nullable: false),
                    BuildingKey = table.Column<int>(type: "int", nullable: true),
                    DeptCharg2Key = table.Column<int>(type: "int", nullable: false),
                    DeptOwnerKey = table.Column<int>(type: "int", nullable: false),
                    SoftwareRev = table.Column<string>(type: "nvarchar(32)", maxLength: 32, nullable: true),
                    LastLocation = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    LocatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PurchaseDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PurchaseCost = table.Column<decimal>(type: "decimal(15,2)", nullable: false),
                    PurchaseOrderNo = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    WarrExpirePart = table.Column<DateTime>(type: "datetime2", nullable: true),
                    WarrExpireLabor = table.Column<DateTime>(type: "datetime2", nullable: true),
                    RoomNo = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: true),
                    FloorNo = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: true),
                    InitialLoc = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateSubmitted = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateApproved = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Submitted = table.Column<bool>(type: "bit", nullable: false),
                    Approved = table.Column<bool>(type: "bit", nullable: false),
                    Approver = table.Column<int>(type: "int", nullable: false),
                    Submitter = table.Column<int>(type: "int", nullable: false),
                    Creator = table.Column<int>(type: "int", nullable: false),
                    AssignedTo = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NewEquipment", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserPermissions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeKey = table.Column<int>(type: "int", nullable: false),
                    EmployeeCode = table.Column<int>(type: "int", nullable: false),
                    EmployeeName = table.Column<int>(type: "int", nullable: false),
                    Login = table.Column<bool>(type: "bit", nullable: false),
                    CreateNew = table.Column<bool>(type: "bit", nullable: false),
                    CreateSave = table.Column<bool>(type: "bit", nullable: false),
                    CreateDelete = table.Column<bool>(type: "bit", nullable: false),
                    SubmittedRead = table.Column<bool>(type: "bit", nullable: false),
                    SubmittedUpdate = table.Column<bool>(type: "bit", nullable: false),
                    SubmittedDelete = table.Column<bool>(type: "bit", nullable: false),
                    ApprovedRead = table.Column<bool>(type: "bit", nullable: false),
                    Reject = table.Column<bool>(type: "bit", nullable: false),
                    UserCreated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserPermissions", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AuditLogNewEquipment");

            migrationBuilder.DropTable(
                name: "AuditLogUserPermissions");

            migrationBuilder.DropTable(
                name: "NewEquipment");

            migrationBuilder.DropTable(
                name: "UserPermissions");
        }
    }
}
