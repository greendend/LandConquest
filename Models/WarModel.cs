﻿using LandConquestDB.Entities;
using LandConquest.Forms;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows;
using LandConquestDB;
using LandConquestDB.Models;

namespace LandConquest.Models
{
    public class WarModel
    {
        public static void DeclareAWar(String war_id, Land landAttacker, Land landDefender)
        {
            String Query = "INSERT INTO dbo.WarData (war_id, land_attacker_id, land_defender_id, datetime_start) VALUES (@war_id, @land_attacker_id, @land_defender_id, @datetime_start)";

            var Command = new SqlCommand(Query, DbContext.GetSqlConnection());
            // int datetimeResult;
            Command.Parameters.AddWithValue("@war_id", war_id);
            Command.Parameters.AddWithValue("@land_attacker_id", landAttacker.LandId);
            Command.Parameters.AddWithValue("@land_defender_id", landDefender.LandId);
            Command.Parameters.AddWithValue("@datetime_start", DateTime.UtcNow);

            Command.ExecuteNonQuery();

            Command.Dispose();
        }

        public static War GetWarById(War war)
        {
            String query = "SELECT * FROM dbo.WarData WHERE war_id = @war_id";
            var command = new SqlCommand(query, DbContext.GetSqlConnection());
            command.Parameters.AddWithValue("@war_id", war.WarId);

            using (var reader = command.ExecuteReader())
            {
                var warId = reader.GetOrdinal("war_id");
                var landAttackerId = reader.GetOrdinal("land_attacker_id");
                var landDefenderId = reader.GetOrdinal("land_defender_id");
                var warDateTimeStart = reader.GetOrdinal("datetime_start");

                while (reader.Read())
                {
                    war.WarId = (reader.GetString(warId));
                    war.LandAttackerId = (reader.GetInt32(landAttackerId));
                    war.LandDefenderId = (reader.GetInt32(landDefenderId));
                    war.WarDateTimeStart = (reader.GetDateTime(warDateTimeStart));
                }
            }

            command.Dispose();
            return war;
        }

        public static int SelectLastIdOfWars()
        {
            String stateQuery = "SELECT * FROM dbo.WarData ORDER BY war_id DESC";
            var stateCommand = new SqlCommand(stateQuery, DbContext.GetSqlConnection());
            string state_max_id = "";
            int count = 0;
            using (var reader = stateCommand.ExecuteReader())
            {
                var stateId = reader.GetOrdinal("war_id");
                while (reader.Read())
                {
                    state_max_id = reader.GetString(stateId);
                    count++;
                }
            }

            stateCommand.Dispose();
            return count;
        }

        public static List<War> GetWarsInfo(List<War> wars)
        {
            String query = "SELECT * FROM dbo.WarData";
            List<String> warssWarId = new List<String>();
            List<Int32> warsLandAttackerId = new List<Int32>();
            List<Int32> warsLandDefenderId = new List<Int32>();
            List<DateTime> warsWarDateTimeStart = new List<DateTime>();

            var command = new SqlCommand(query, DbContext.GetSqlConnection());

            using (var reader = command.ExecuteReader())
            {
                var warId = reader.GetOrdinal("war_id");
                var landAttackerId = reader.GetOrdinal("land_attacker_id");
                var landDefenderId = reader.GetOrdinal("land_defender_id");
                var warDateTimeStart = reader.GetOrdinal("datetime_start");

                while (reader.Read())
                {
                    warssWarId.Add(reader.GetString(warId));
                    warsLandAttackerId.Add(reader.GetInt32(landAttackerId));
                    warsLandDefenderId.Add(reader.GetInt32(landDefenderId));
                    warsWarDateTimeStart.Add(reader.GetDateTime(warDateTimeStart));
                }
            }

            command.Dispose();

            for (int i = 0; i < warssWarId.Count; i++)
            {
                wars[i].WarId = warssWarId[i];
                wars[i].LandAttackerId = warsLandAttackerId[i];
                wars[i].LandDefenderId = warsLandDefenderId[i];
                wars[i].WarDateTimeStart = warsWarDateTimeStart[i];
            }

            warssWarId = null;
            warsLandAttackerId = null;
            warsLandDefenderId = null;
            warsWarDateTimeStart = null;

            return wars;
        }

        public static int ReturnNumberOfCell(int row, int column)
        {
            int index = (row - 1) * 30 + column - 1;
            return index;
        }

        // WAR ENTER BLOCK                              -- January/07/2021 -- greendend
        public static void EnterInWar(War _war, Player player)
        {
            ArmyModel armyModel = new ArmyModel();
            Army army = new Army();
            BattleModel battleModel = new BattleModel();
            ArmyInBattle armyInBattle = new ArmyInBattle();
            War war = new War();


            army = ArmyModel.GetArmyInfo(player, army);

            war = WarModel.GetWarById(_war);

            int count = BattleModel.CheckPlayerParticipation(player, war);

            armyInBattle = CheckFreeArmies(army, player);

            if ((count == 0) && (armyInBattle.ArmySizeCurrent > 0)) // если игрок не участвует в войне
            {                                                       // и у него есть чем воивать (см. CheckFreeArmies())
                Random random = new Random();
                WarWindow window;

                if (player.PlayerCurrentRegion == war.LandAttackerId)
                {
                    armyInBattle.LocalLandId = ReturnNumberOfCell(20, random.Next(1, 30));
                    armyInBattle.ArmySide = 1;

                    BattleModel.InsertArmyIntoBattleTable(armyInBattle, war);

                    List<ArmyInBattle> armiesInBattle = new List<ArmyInBattle>();

                    armiesInBattle = BattleModel.GetArmiesInfo(armiesInBattle, war);

                    window = new WarWindow(player, armyInBattle, armiesInBattle, war);
                    window.Show();
                }
                else if (player.PlayerCurrentRegion == war.LandDefenderId)
                {
                    armyInBattle.LocalLandId = ReturnNumberOfCell(1, random.Next(1, 30));
                    armyInBattle.ArmySide = 0; // hueta

                    BattleModel.InsertArmyIntoBattleTable(armyInBattle, war);

                    List<ArmyInBattle> armiesInBattle = new List<ArmyInBattle>();
                    for (int i = 0; i < BattleModel.SelectLastIdOfArmies(war); i++)
                    {
                        armiesInBattle.Add(new ArmyInBattle());
                    }

                    armiesInBattle = BattleModel.GetArmiesInfo(armiesInBattle, war);


                    window = new WarWindow(player, armyInBattle, armiesInBattle, war);
                    window.Show();
                }
                else MessageBox.Show("You are not in any lands of war.\nPlease change your position!");

            }
            else
            {
                if ((player.PlayerCurrentRegion == war.LandDefenderId) || (player.PlayerCurrentRegion == war.LandAttackerId))
                {
                    List<ArmyInBattle> armiesInBattle = new List<ArmyInBattle>();
                    for (int i = 0; i < BattleModel.SelectLastIdOfArmies(war); i++)
                    {
                        armiesInBattle.Add(new ArmyInBattle());
                    }

                    armiesInBattle = BattleModel.GetArmiesInfo(armiesInBattle, war);

                    WarWindow window = new WarWindow(player, armyInBattle, armiesInBattle, war);
                    window.Show();
                }
                else MessageBox.Show("You are not in any lands of war.\nPlease change your position!");
            }
        }

        public static ArmyInBattle CheckFreeArmies(Army army, Player player)
        {
            ArmyInBattle freePlayerArmy = new ArmyInBattle();

            List<ArmyInBattle> armies = new List<ArmyInBattle>();
            armies = BattleModel.GetAllPlayerArmiesInfo(armies, player);

            freePlayerArmy.PlayerId = army.PlayerId;
            freePlayerArmy.ArmyId = army.ArmyId;
            freePlayerArmy.ArmySizeCurrent = army.ArmySizeCurrent;
            freePlayerArmy.ArmyType = army.ArmyType;
            freePlayerArmy.ArmyArchersCount = army.ArmyArchersCount;
            freePlayerArmy.ArmyInfantryCount = army.ArmyInfantryCount;
            freePlayerArmy.ArmySiegegunCount = army.ArmySiegegunCount;
            freePlayerArmy.ArmyHorsemanCount = army.ArmyHorsemanCount;

            for (int i = 0; i < armies.Count; i++)
            {
                freePlayerArmy.ArmySizeCurrent -= armies[i].ArmySizeCurrent;
                freePlayerArmy.ArmyArchersCount -= armies[i].ArmyArchersCount;
                freePlayerArmy.ArmyInfantryCount -= armies[i].ArmyInfantryCount;
                freePlayerArmy.ArmySiegegunCount -= armies[i].ArmySiegegunCount;
                freePlayerArmy.ArmyHorsemanCount -= armies[i].ArmyHorsemanCount;
            }

            return freePlayerArmy;
        }
    }
}
