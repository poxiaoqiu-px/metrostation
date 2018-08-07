using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MetroStation.Migrations
{
    public partial class addentities : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
           
            migrationBuilder.CreateTable(
                name: "Apartment",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ApartmentName = table.Column<string>(nullable: true),
                    LineId = table.Column<int>(nullable: false),
                    StationId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Apartment", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Bed",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    RoomId = table.Column<int>(nullable: false),
                    BedNum = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bed", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BedUserMapping",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    LineId = table.Column<int>(nullable: false),
                    RecDate = table.Column<DateTime>(nullable: false),
                    ApartmentId = table.Column<int>(nullable: false),
                    RoomId = table.Column<int>(nullable: false),
                    BedId = table.Column<int>(nullable: false),
                    UserId = table.Column<int>(nullable: false),
                    AttendTime = table.Column<DateTime>(nullable: false),
                    CallTime = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BedUserMapping", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CrossingRoad",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    TableInfoId = table.Column<int>(nullable: false),
                    TurnRuleDetailId = table.Column<int>(nullable: false),
                    UserGroupId = table.Column<int>(nullable: false),
                    CrossingRoadName = table.Column<string>(nullable: true),
                    AttenStation = table.Column<string>(nullable: true),
                    AttenTime = table.Column<DateTime>(nullable: false),
                    AttenTrain = table.Column<string>(nullable: true),
                    TrainTime = table.Column<DateTime>(nullable: false),
                    RunTrain = table.Column<string>(nullable: true),
                    OffTrain = table.Column<string>(nullable: true),
                    OffTime = table.Column<DateTime>(nullable: false),
                    OffStation = table.Column<string>(nullable: true),
                    Miles = table.Column<decimal>(nullable: false),
                    Hours = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CrossingRoad", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Exam",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    LineId = table.Column<int>(nullable: false),
                    ExamTypeId = table.Column<int>(nullable: false),
                    ExamLevel = table.Column<int>(nullable: false),
                    ExamText = table.Column<string>(nullable: true),
                    Answer = table.Column<string>(nullable: true),
                    OptionA = table.Column<string>(nullable: true),
                    OptionB = table.Column<string>(nullable: true),
                    OptionC = table.Column<string>(nullable: true),
                    OptionD = table.Column<string>(nullable: true),
                    OptionE = table.Column<string>(nullable: true),
                    OptionF = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Exam", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ExamRecord",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<int>(nullable: false),
                    ExamTypeId = table.Column<int>(nullable: false),
                    ExamCount = table.Column<int>(nullable: false),
                    ErrorCount = table.Column<int>(nullable: false),
                    ExamDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExamRecord", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ExamRecordDetail",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ExamRecordId = table.Column<int>(nullable: false),
                    ExamId = table.Column<int>(nullable: false),
                    Answer = table.Column<string>(nullable: true),
                    IsCorrect = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExamRecordDetail", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ExamType",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    LineId = table.Column<int>(nullable: false),
                    ExamTypeName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExamType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Line",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    LineName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Line", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LogicLine",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    LogicLineName = table.Column<string>(nullable: true),
                    LineId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LogicLine", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RoleExamTypeMapping",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ExamTypeId = table.Column<int>(nullable: false),
                    RoleId = table.Column<int>(nullable: false),
                    ExamCount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoleExamTypeMapping", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Room",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    RoomName = table.Column<string>(nullable: true),
                    ApartmentId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Room", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Station",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    StationName = table.Column<string>(nullable: true),
                    StationAbbr = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Station", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StationCode",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    LineId = table.Column<int>(nullable: false),
                    StationId = table.Column<int>(nullable: false),
                    StationCodeName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StationCode", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StationLineMapping",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    StationId = table.Column<int>(nullable: false),
                    LogicLineId = table.Column<int>(nullable: false),
                    Sequence = table.Column<int>(nullable: false),
                    MileOffset = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StationLineMapping", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TableInfo",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    LineId = table.Column<int>(nullable: false),
                    TableName = table.Column<string>(nullable: true),
                    InsertTime = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TableInfo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TableInfoToDate",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    LineId = table.Column<int>(nullable: false),
                    TableInfoId = table.Column<int>(nullable: false),
                    RecDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TableInfoToDate", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TrainDetailInfo",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    TableInfoId = table.Column<int>(nullable: false),
                    TrainId = table.Column<string>(nullable: true),
                    Start = table.Column<int>(nullable: false),
                    End = table.Column<int>(nullable: false),
                    Interval = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrainDetailInfo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TrainSchedule",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    LineId = table.Column<int>(nullable: false),
                    TableInfoId = table.Column<int>(nullable: false),
                    StartStationId = table.Column<int>(nullable: false),
                    EndStationId = table.Column<int>(nullable: false),
                    StationId = table.Column<int>(nullable: false),
                    Sequence = table.Column<int>(nullable: false),
                    Arrive = table.Column<int>(nullable: false),
                    Depart = table.Column<int>(nullable: false),
                    Direction = table.Column<int>(nullable: false),
                    TrainId = table.Column<string>(nullable: true),
                    MidId = table.Column<string>(nullable: true),
                    LastId = table.Column<string>(nullable: true),
                    Arc_Ne = table.Column<string>(nullable: true),
                    Stop = table.Column<int>(nullable: false),
                    RTTime = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrainSchedule", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TurnRule",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    LineId = table.Column<int>(nullable: false),
                    TurnRuleName = table.Column<string>(nullable: true),
                    IncludeWeekend = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TurnRule", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TurnRuleDetail",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    TurnRuleId = table.Column<int>(nullable: false),
                    TurnRuleDetailName = table.Column<string>(nullable: true),
                    OnDuty = table.Column<bool>(nullable: false),
                    Sequence = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TurnRuleDetail", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserGroup",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    LineId = table.Column<int>(nullable: false),
                    UserGroupName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserGroup", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserLineMapping",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<int>(nullable: false),
                    LineId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserLineMapping", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserOnDutyRecord",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    UserTeamRecordId = table.Column<int>(nullable: false),
                    TableInfoId = table.Column<int>(nullable: false),
                    TurnRuleDetailId = table.Column<int>(nullable: false),
                    UserGroupId = table.Column<int>(nullable: false),
                    CrossingRoadName = table.Column<string>(nullable: true),
                    AttenStation = table.Column<string>(nullable: true),
                    AttenTime = table.Column<DateTime>(nullable: false),
                    AttenTrain = table.Column<string>(nullable: true),
                    TrainTime = table.Column<DateTime>(nullable: false),
                    RunTrain = table.Column<string>(nullable: true),
                    OffTrain = table.Column<string>(nullable: true),
                    OffTime = table.Column<DateTime>(nullable: false),
                    OffStation = table.Column<string>(nullable: true),
                    Miles = table.Column<decimal>(nullable: false),
                    Hours = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserOnDutyRecord", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserOnDutyRecordDetail",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    UserOnDutyRecordId = table.Column<int>(nullable: false),
                    RecDate = table.Column<DateTime>(nullable: false),
                    UserTypeId = table.Column<int>(nullable: false),
                    PlanUserId = table.Column<int>(nullable: false),
                    UserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserOnDutyRecordDetail", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserOnDutyUnit",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    UserTeamId = table.Column<int>(nullable: false),
                    UserId = table.Column<int>(nullable: false),
                    UserTypeId = table.Column<int>(nullable: false),
                    Sequence = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserOnDutyUnit", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserTeam",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    UserTeamName = table.Column<string>(nullable: true),
                    UserGroupId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserTeam", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserTeamPlan",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    LineId = table.Column<int>(nullable: false),
                    UserTeamId = table.Column<int>(nullable: false),
                    TurnRuleDetailId = table.Column<int>(nullable: false),
                    RecDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserTeamPlan", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserTeamRecord",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    LineId = table.Column<int>(nullable: false),
                    RecDate = table.Column<DateTime>(nullable: false),
                    UserTeamId = table.Column<int>(nullable: false),
                    Sequence = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserTeamRecord", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserTeamRecordDetail",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    UserTeamRecordId = table.Column<int>(nullable: false),
                    UserId = table.Column<int>(nullable: false),
                    UserTypeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserTeamRecordDetail", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserType",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    UserTypeName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserType", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Apartment");

            migrationBuilder.DropTable(
                name: "Bed");

            migrationBuilder.DropTable(
                name: "BedUserMapping");

            migrationBuilder.DropTable(
                name: "CrossingRoad");

            migrationBuilder.DropTable(
                name: "Exam");

            migrationBuilder.DropTable(
                name: "ExamRecord");

            migrationBuilder.DropTable(
                name: "ExamRecordDetail");

            migrationBuilder.DropTable(
                name: "ExamType");

            migrationBuilder.DropTable(
                name: "Line");

            migrationBuilder.DropTable(
                name: "LogicLine");

            migrationBuilder.DropTable(
                name: "RoleExamTypeMapping");

            migrationBuilder.DropTable(
                name: "Room");

            migrationBuilder.DropTable(
                name: "Station");

            migrationBuilder.DropTable(
                name: "StationCode");

            migrationBuilder.DropTable(
                name: "StationLineMapping");

            migrationBuilder.DropTable(
                name: "TableInfo");

            migrationBuilder.DropTable(
                name: "TableInfoToDate");

            migrationBuilder.DropTable(
                name: "TrainDetailInfo");

            migrationBuilder.DropTable(
                name: "TrainSchedule");

            migrationBuilder.DropTable(
                name: "TurnRule");

            migrationBuilder.DropTable(
                name: "TurnRuleDetail");

            migrationBuilder.DropTable(
                name: "UserGroup");

            migrationBuilder.DropTable(
                name: "UserLineMapping");

            migrationBuilder.DropTable(
                name: "UserOnDutyRecord");

            migrationBuilder.DropTable(
                name: "UserOnDutyRecordDetail");

            migrationBuilder.DropTable(
                name: "UserOnDutyUnit");

            migrationBuilder.DropTable(
                name: "UserTeam");

            migrationBuilder.DropTable(
                name: "UserTeamPlan");

            migrationBuilder.DropTable(
                name: "UserTeamRecord");

            migrationBuilder.DropTable(
                name: "UserTeamRecordDetail");

            migrationBuilder.DropTable(
                name: "UserType");

           
        }
    }
}
