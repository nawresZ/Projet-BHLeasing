using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjetBHLeasing.Data.Migrations
{
    /// <inheritdoc />
    public partial class CreateMig : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "NVARCHAR2(450)", nullable: false),
                    Name = table.Column<string>(type: "NVARCHAR2(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "NVARCHAR2(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "NVARCHAR2(450)", nullable: false),
                    UserName = table.Column<string>(type: "NVARCHAR2(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "NVARCHAR2(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "NVARCHAR2(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "NVARCHAR2(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "NUMBER(1)", nullable: false),
                    PasswordHash = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "NUMBER(1)", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "NUMBER(1)", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "TIMESTAMP(7) WITH TIME ZONE", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "NUMBER(1)", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "NUMBER(10)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Client",
                columns: table => new
                {
                    IDrow = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    clientId = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    observations = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    montant = table.Column<double>(type: "BINARY_DOUBLE", nullable: true),
                    dateReglement = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: true),
                    dateAppel = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: true),
                    resultats = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    idAction = table.Column<int>(type: "NUMBER(10)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Client", x => x.IDrow);
                });

            migrationBuilder.CreateTable(
                name: "Profil",
                columns: table => new
                {
                    id_profil = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    Designation = table.Column<string>(type: "NVARCHAR2(255)", maxLength: 255, nullable: false),
                    b_systeme = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    id_user_modif = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    date_user_creat = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false),
                    date_user_modif = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Profil", x => x.id_profil);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    RoleId = table.Column<string>(type: "NVARCHAR2(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    ClaimValue = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    UserId = table.Column<string>(type: "NVARCHAR2(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    ClaimValue = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "NVARCHAR2(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "NVARCHAR2(128)", maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    UserId = table.Column<string>(type: "NVARCHAR2(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "NVARCHAR2(450)", nullable: false),
                    RoleId = table.Column<string>(type: "NVARCHAR2(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "NVARCHAR2(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "NVARCHAR2(128)", maxLength: 128, nullable: false),
                    Name = table.Column<string>(type: "NVARCHAR2(128)", maxLength: 128, nullable: false),
                    Value = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Utilisateur",
                columns: table => new
                {
                    id_user = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    ID_PROFIL = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    nom = table.Column<string>(type: "NVARCHAR2(100)", maxLength: 100, nullable: false),
                    Prenom = table.Column<string>(type: "NVARCHAR2(100)", maxLength: 100, nullable: false),
                    login = table.Column<string>(type: "NVARCHAR2(100)", maxLength: 100, nullable: false),
                    password = table.Column<string>(type: "NVARCHAR2(255)", maxLength: 255, nullable: false),
                    abreviation = table.Column<string>(type: "NVARCHAR2(10)", maxLength: 10, nullable: false),
                    id_user_responsable = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    statut = table.Column<string>(type: "NVARCHAR2(10)", maxLength: 10, nullable: false),
                    b_modifier_ptf = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    mail = table.Column<string>(type: "NVARCHAR2(255)", maxLength: 255, nullable: true),
                    date_derniers_acces = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: true),
                    id_user_modif = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    date_user_creat = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false),
                    date_user_modif = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false),
                    matricule = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    rib = table.Column<string>(type: "NVARCHAR2(20)", maxLength: 20, nullable: true),
                    id_departement = table.Column<int>(type: "NUMBER(10)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Utilisateur", x => x.id_user);
                    table.ForeignKey(
                        name: "FK_Utilisateur_Profil_ID_PROFIL",
                        column: x => x.ID_PROFIL,
                        principalTable: "Profil",
                        principalColumn: "id_profil",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "His_Relances",
                columns: table => new
                {
                    id_his_relance = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    id_relance = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    id_campagne = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    id_ptf = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    id_sinistre = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    code_client = table.Column<string>(type: "NVARCHAR2(10)", maxLength: 10, nullable: true),
                    id_action = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    id_sort = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    date_traitement = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: true),
                    date_rdv = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: true),
                    montant = table.Column<double>(type: "BINARY_DOUBLE", nullable: false),
                    id_disponibilite = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    id_solvabilite = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    id_moralite = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    observation = table.Column<string>(type: "NCLOB", maxLength: 4000, nullable: false),
                    infos = table.Column<string>(type: "NCLOB", maxLength: 4000, nullable: false),
                    ID_USER_MODIF = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    date_user_creat = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false),
                    date_user_modif = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false),
                    date_derniere_relance = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: true),
                    date_prochaine_relance = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: true),
                    provenance = table.Column<string>(type: "NVARCHAR2(20)", maxLength: 20, nullable: true),
                    IdProvenance = table.Column<int>(type: "NUMBER(10)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_His_Relances", x => x.id_his_relance);
                    table.ForeignKey(
                        name: "FK_His_Relances_Utilisateur_ID_USER_MODIF",
                        column: x => x.ID_USER_MODIF,
                        principalTable: "Utilisateur",
                        principalColumn: "id_user");
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "\"NormalizedName\" IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "\"NormalizedUserName\" IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_His_Relances_ID_USER_MODIF",
                table: "His_Relances",
                column: "ID_USER_MODIF");

            migrationBuilder.CreateIndex(
                name: "IX_Utilisateur_ID_PROFIL",
                table: "Utilisateur",
                column: "ID_PROFIL");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Client");

            migrationBuilder.DropTable(
                name: "His_Relances");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Utilisateur");

            migrationBuilder.DropTable(
                name: "Profil");
        }
    }
}
