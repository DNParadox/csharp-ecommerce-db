using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace csharpecommercedb.Migrations
{
    /// <inheritdoc />
    public partial class SecondMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customers_Orders_OrdersId",
                table: "Customers");

            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Orders_OrdersId",
                table: "Employees");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Payments_PaymentsId",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Employees_OrdersId",
                table: "Employees");

            migrationBuilder.DropIndex(
                name: "IX_Customers_OrdersId",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "OrdersId",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "OrdersId",
                table: "Customers");

            migrationBuilder.RenameColumn(
                name: "PaymentsId",
                table: "Orders",
                newName: "EmployeesId");

            migrationBuilder.RenameIndex(
                name: "IX_Orders_PaymentsId",
                table: "Orders",
                newName: "IX_Orders_EmployeesId");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Employees",
                newName: "Id");

            migrationBuilder.AddColumn<int>(
                name: "OrderId",
                table: "Payments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CustomersId",
                table: "Orders",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Customers_id",
                table: "Orders",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Employee_id",
                table: "Orders",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Payments_OrderId",
                table: "Payments",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_CustomersId",
                table: "Orders",
                column: "CustomersId");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Customers_CustomersId",
                table: "Orders",
                column: "CustomersId",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Employees_EmployeesId",
                table: "Orders",
                column: "EmployeesId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Payments_Orders_OrderId",
                table: "Payments",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Customers_CustomersId",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Employees_EmployeesId",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Payments_Orders_OrderId",
                table: "Payments");

            migrationBuilder.DropIndex(
                name: "IX_Payments_OrderId",
                table: "Payments");

            migrationBuilder.DropIndex(
                name: "IX_Orders_CustomersId",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "OrderId",
                table: "Payments");

            migrationBuilder.DropColumn(
                name: "CustomersId",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "Customers_id",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "Employee_id",
                table: "Orders");

            migrationBuilder.RenameColumn(
                name: "EmployeesId",
                table: "Orders",
                newName: "PaymentsId");

            migrationBuilder.RenameIndex(
                name: "IX_Orders_EmployeesId",
                table: "Orders",
                newName: "IX_Orders_PaymentsId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Employees",
                newName: "id");

            migrationBuilder.AddColumn<int>(
                name: "OrdersId",
                table: "Employees",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "OrdersId",
                table: "Customers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Employees_OrdersId",
                table: "Employees",
                column: "OrdersId");

            migrationBuilder.CreateIndex(
                name: "IX_Customers_OrdersId",
                table: "Customers",
                column: "OrdersId");

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_Orders_OrdersId",
                table: "Customers",
                column: "OrdersId",
                principalTable: "Orders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Orders_OrdersId",
                table: "Employees",
                column: "OrdersId",
                principalTable: "Orders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Payments_PaymentsId",
                table: "Orders",
                column: "PaymentsId",
                principalTable: "Payments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
