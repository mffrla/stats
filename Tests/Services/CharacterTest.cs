using MFFStats.Models.Domain;
using MFFStats.Models.Requests;
using MFFStats.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace MFFStats.Tests.Services
{
    [TestClass]
    public class CharacterTest
    {
        [TestMethod]
        public void CharacterService_SelectAll_Test()
        {
            CharacterService svc = new CharacterService();
            List<Character> modelList = svc.SelectAll();
            Assert.IsNotNull(modelList);
        }

        [TestMethod]
        public void CharacterService_SelectById_Test()
        {
            int id = 1;
            CharacterService svc = new CharacterService();
            Character model = svc.SelectById(id);
            Assert.IsNotNull(model, "Value is null");
        }

        [TestMethod]
        public void CharacterService_Insert_Test()
        {
            CharacterService svc = new CharacterService();
            var model = svc.Insert(
                new CharacterAddRequest()
                {
                    Name = "Test"
                    , TypeId = 1
                    , SpeciesId = 1
                    , GenderId = 1
                    , SideId = 1
                    , Tier2 = true
                    , PhysicalAtk = 9999
                    , EnergyAtk = 9999
                    , AtkSpeed = 100
                    , CritRate = 1
                    , CritDmg = 115
                    , IgnoreDef = 0
                    , IgnoreDodge = 0
                    , FireDmg = 0
                    , ColdDmg = 0
                    , LightningDmg = 0
                    , PoisonDmg = 0
                    , MindDmg = 0
                    , PhysicalDef = 9999
                    , EnergyDef = 9999
                    , HP = 9999
                    , RecoveryRate = 100
                    , Dodge = 0
                    , FireResist = 0
                    , ColdResist = 0
                    , LightningResist = 0
                    , PoisonResist = 0
                    , MindResist = 0
                    , MoveSpd = 100
                    , Debuff = 0
                    , SkillCooldown = 0
                });
            Assert.IsInstanceOfType(model, typeof(int), "Expected result to be an int");
            Assert.IsTrue(model > 0, "Expected result to be greater than 0");
        }

        [TestMethod]
        public void CharacterService_Update_Test()
        {
            CharacterService svc = new CharacterService();
            svc.Update(new CharacterUpdateRequest()
            {
                Id = 10
                , Name = "Update"
                , TypeId = 1
                , SpeciesId = 1
                , GenderId = 1
                , SideId = 1
                , Tier2 = true
                , PhysicalAtk = 9999
                , EnergyAtk = 9999
                , AtkSpeed = 100
                , CritRate = 1
                , CritDmg = 115
                , IgnoreDef = 0
                , IgnoreDodge = 0
                , FireDmg = 0
                , ColdDmg = 0
                , LightningDmg = 0
                , PoisonDmg = 0
                , MindDmg = 0
                , PhysicalDef = 9999
                , EnergyDef = 9999
                , HP = 9999
                , RecoveryRate = 100
                , Dodge = 0
                , FireResist = 0
                , ColdResist = 0
                , LightningResist = 0
                , PoisonResist = 0
                , MindResist = 0
                , MoveSpd = 100
                , Debuff = 0
                , SkillCooldown = 0
            });
        }

        [TestMethod]
        public void CharacterService_Delete_Test()
        {
            int id = 12;
            CharacterService svc = new CharacterService();
            svc.Delete(id);
        }
    }
}
