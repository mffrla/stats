using MFFStats.Models.Domain;
using MFFStats.Models.Requests;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace MFFStats.Services
{
    public class CharacterService : BaseService
    {
        public int Insert(CharacterAddRequest model)
        {
            int id = 0;
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("Character_Insert", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    AddValues(model, cmd);

                    SqlParameter param = new SqlParameter("@Id", SqlDbType.Int);
                    param.Direction = ParameterDirection.Output;
                    cmd.Parameters.Add(param);

                    cmd.ExecuteNonQuery();
                    id = (int)cmd.Parameters["@Id"].Value;
                }
                conn.Close();
            }
            return id;
        }

        public Character SelectById(int id)
        {
            Character model = new Character();
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("Character_SelectById", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Id", id);
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        model = Mapper(reader);
                    }
                }
                conn.Close();
            }
            return model;
        }

        public List<Character> SelectAll()
        {
            List<Character> charList = new List<Character>();
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("Character_SelectAll", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                    while (reader.Read())
                    {
                        Character model;
                        try
                        {
                            model = Mapper(reader);
                        }
                        catch (Exception ex)
                        {
                            string msg = ex.Message;
                            throw;
                        }
                        charList.Add(model);
                    }
                }
                conn.Close();
            }
            return charList;
        }

        public void Update(CharacterUpdateRequest model)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("Character_Update", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Id", model.Id);
                    AddValues(model, cmd);

                    cmd.ExecuteNonQuery();
                }
                conn.Close();
            }
        }

        public void Delete(int id)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("Character_Delete", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Id", id);
                    cmd.ExecuteNonQuery();
                }
                conn.Close();
            }
        }

        private Character Mapper(SqlDataReader reader)
        {
            Character model = new Character();
            int index = 0;
            model.Id = reader.GetInt32(index++);
            model.Name = reader.GetString(index++);
            model.Type = reader.GetString(index++);
            model.Species = reader.GetString(index++);
            model.Gender = reader.GetString(index++);
            model.Side = reader.GetString(index++);
            model.Tier2 = reader.GetBoolean(index++);
            model.PhysicalAtk = reader.GetInt32(index++);
            model.EnergyAtk = reader.GetInt32(index++);
            model.AtkSpeed = reader.GetDecimal(index++);
            model.CritRate = reader.GetDecimal(index++);
            model.CritDmg = reader.GetDecimal(index++);
            model.IgnoreDef = reader.GetDecimal(index++);
            model.IgnoreDodge = reader.GetDecimal(index++);
            model.FireDmg = reader.GetDecimal(index++);
            model.ColdDmg = reader.GetDecimal(index++);
            model.LightningDmg = reader.GetDecimal(index++);
            model.PoisonDmg = reader.GetDecimal(index++);
            model.MindDmg = reader.GetDecimal(index++);
            model.PhysicalDef = reader.GetInt32(index++);
            model.EnergyDef = reader.GetInt32(index++);
            model.HP = reader.GetInt32(index++);
            model.RecoveryRate = reader.GetDecimal(index++);
            model.Dodge = reader.GetDecimal(index++);
            model.FireResist = reader.GetDecimal(index++);
            model.ColdResist = reader.GetDecimal(index++);
            model.LightningResist = reader.GetDecimal(index++);
            model.PoisonResist = reader.GetDecimal(index++);
            model.MindResist = reader.GetDecimal(index++);
            model.MoveSpd = reader.GetDecimal(index++);
            model.Debuff = reader.GetDecimal(index++);
            model.SkillCooldown = reader.GetDecimal(index++);

            return model;
        }

        private static void AddValues(CharacterAddRequest model, SqlCommand cmd)
        {
            cmd.Parameters.AddWithValue("@Name", model.Name);
            cmd.Parameters.AddWithValue("@TypeId", model.TypeId);
            cmd.Parameters.AddWithValue("@SpeciesId", model.SpeciesId);
            cmd.Parameters.AddWithValue("@GenderId", model.GenderId);
            cmd.Parameters.AddWithValue("@SideId", model.SideId);
            cmd.Parameters.AddWithValue("@Tier2", model.Tier2);
            cmd.Parameters.AddWithValue("@PhysicalAtk", model.PhysicalAtk);
            cmd.Parameters.AddWithValue("@EnergyAtk", model.EnergyAtk);
            cmd.Parameters.AddWithValue("@AtkSpeed", model.AtkSpeed);
            cmd.Parameters.AddWithValue("@CritRate", model.CritRate);
            cmd.Parameters.AddWithValue("@CritDmg", model.CritDmg);
            cmd.Parameters.AddWithValue("@IgnoreDef", model.IgnoreDef);
            cmd.Parameters.AddWithValue("@IgnoreDodge", model.IgnoreDodge);
            cmd.Parameters.AddWithValue("@FireDmg", model.FireDmg);
            cmd.Parameters.AddWithValue("@ColdDmg", model.ColdDmg);
            cmd.Parameters.AddWithValue("@LightningDmg", model.LightningDmg);
            cmd.Parameters.AddWithValue("@PoisonDmg", model.PoisonDmg);
            cmd.Parameters.AddWithValue("@MindDmg", model.MindDmg);
            cmd.Parameters.AddWithValue("@PhysicalDef", model.PhysicalDef);
            cmd.Parameters.AddWithValue("@EnergyDef", model.EnergyDef);
            cmd.Parameters.AddWithValue("@HP", model.HP);
            cmd.Parameters.AddWithValue("@RecoveryRate", model.RecoveryRate);
            cmd.Parameters.AddWithValue("@Dodge", model.Dodge);
            cmd.Parameters.AddWithValue("@FireResist", model.FireResist);
            cmd.Parameters.AddWithValue("@ColdResist", model.ColdResist);
            cmd.Parameters.AddWithValue("@LightningResist", model.LightningResist);
            cmd.Parameters.AddWithValue("@PoisonResist", model.PoisonResist);
            cmd.Parameters.AddWithValue("@MindResist", model.MindResist);
            cmd.Parameters.AddWithValue("@MoveSpd", model.MoveSpd);
            cmd.Parameters.AddWithValue("@Debuff", model.Debuff);
            cmd.Parameters.AddWithValue("@SkillCooldown", model.SkillCooldown);
        }
    }
}
