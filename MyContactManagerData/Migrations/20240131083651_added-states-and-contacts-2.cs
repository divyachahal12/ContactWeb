using Microsoft.EntityFrameworkCore.Migrations;

namespace MyContactManagerData.Migrations
{
    public partial class addedstatesandcontacts2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "States",
                columns: new[] { "Id", "Abbreviation", "Name" },
                values: new object[,]
                {
                    { 1, "AL", "Alabama" },
                    { 28, "NE", "Nebraska" },
                    { 29, "NV", "Nevada" },
                    { 30, "NH", "New Hampshire" },
                    { 31, "NJ", "New Jersey" },
                    { 32, "NM", "New Mexico" },
                    { 33, "NY", "New York" },
                    { 34, "NC", "North Carolina" },
                    { 35, "ND", "North Dakota" },
                    { 36, "OH", "Ohio" },
                    { 37, "OK", "Oklahoma" },
                    { 27, "MT", "Montana" },
                    { 38, "OR", "Oregon" },
                    { 40, "RI", "Rhode Island" },
                    { 41, "SC", "South Carolina" },
                    { 42, "SD", "South Dakota" },
                    { 43, "TN", "Tennessee" },
                    { 44, "TX", "Texas" },
                    { 45, "UT", "Utah" },
                    { 46, "VT", "Vermont" },
                    { 47, "VA", "Virginia" },
                    { 48, "WA", "Washington" },
                    { 49, "WV", "West Virginia" },
                    { 39, "PA", "Pennsylvania" },
                    { 50, "WI", "Wisconsin" },
                    { 26, "MO", "Missouri" },
                    { 24, "MN", "Minnesota" },
                    { 2, "AK", "Alaska" },
                    { 3, "AZ", "Arizona" },
                    { 4, "AR", "Arkansas" },
                    { 5, "CA", "California" },
                    { 6, "CO", "Colorado" },
                    { 7, "CT", "Connecticut" },
                    { 8, "DE", "Delaware" },
                    { 9, "DC", "District of Columbia" },
                    { 10, "FL", "Florida" },
                    { 11, "GA", "Georgia" },
                    { 25, "MS", "Mississippi" },
                    { 12, "HI", "Hawaii" },
                    { 14, "IL", "Illinois" },
                    { 15, "IN", "Indiana" },
                    { 16, "IA", "Iowa" }
                });

            migrationBuilder.InsertData(
                table: "States",
                columns: new[] { "Id", "Abbreviation", "Name" },
                values: new object[,]
                {
                    { 17, "KS", "Kansas" },
                    { 18, "KY", "Kentucky" },
                    { 19, "LA", "Louisiana" },
                    { 20, "ME", "Maine" },
                    { 21, "MD", "Maryland" },
                    { 22, "MS", "Massachusetts" },
                    { 23, "MI", "Michigan" },
                    { 13, "ID", "Idaho" },
                    { 51, "WY", "Wyoming" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: 51);
        }
    }
}
