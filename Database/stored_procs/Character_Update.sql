CREATE PROCEDURE [dbo].[Character_Update]
	@id INT OUTPUT
	, @name NVARCHAR(50)
	, @typeId INT
	, @speciesId INT
	, @genderId INT
	, @sideId INT
	, @tier2 INT
	, @physicalAtk INT
	, @energyAtk INT
	, @atkSpeed DECIMAL(5,2)
	, @critRate DECIMAL(5,2)
	, @critDmg DECIMAL(5,2)
	, @ignoreDef DECIMAL(5,2)
	, @ignoreDodge DECIMAL(5,2)
	, @fireDmg DECIMAL(5,2)
	, @coldDmg DECIMAL(5,2)
	, @lightningDmg DECIMAL(5,2)
	, @poisonDmg DECIMAL(5,2)
	, @mindDmg DECIMAL(5,2)
	, @physicalDef INT
	, @energyDef INT
	, @hp INT
	, @recoveryRate DECIMAL(5,2)
	, @dodge DECIMAL(5,2)
	, @fireResist DECIMAL(5,2)
	, @coldResist DECIMAL(5,2)
	, @lightningResist DECIMAL(5,2)
	, @poisonResist DECIMAL(5,2)
	, @mindResist DECIMAL(5,2)
	, @moveSpd DECIMAL(5,2)
	, @debuff DECIMAL(5,2)
	, @skillCooldown DECIMAL(5,2)
AS
/*

DECLARE
	@_id INT = 9
	, @_name NVARCHAR(50) = 'Update'
	, @_typeId INT = 1
	, @_speciesId INT = 1
	, @_genderId INT = 1
	, @_sideId INT = 1
	, @_tier2 INT = 1
	, @_physicalAtk INT = 9999
	, @_energyAtk INT = 9999
	, @_atkSpeed DECIMAL(5,2) = 100.00
	, @_critRate DECIMAL(5,2) = 1.00
	, @_critDmg DECIMAL(5,2) = 115.00
	, @_ignoreDef DECIMAL(5,2) = 0.00
	, @_ignoreDodge DECIMAL(5,2) = 0.00
	, @_fireDmg DECIMAL(5,2) = 0.00
	, @_coldDmg DECIMAL(5,2) = 0.00
	, @_lightningDmg DECIMAL(5,2) = 0.00
	, @_poisonDmg DECIMAL(5,2) = 0.00
	, @_mindDmg DECIMAL(5,2) = 0.00
	, @_physicalDef INT = 9999
	, @_energyDef INT = 9999
	, @_hp INT = 9999
	, @_recoveryRate DECIMAL(5,2) = 100.00
	, @_dodge DECIMAL(5,2) = 0.00
	, @_fireResist DECIMAL(5,2) = 0.00
	, @_coldResist DECIMAL(5,2) = 0.00
	, @_lightningResist DECIMAL(5,2) = 0.00
	, @_poisonResist DECIMAL(5,2) = 0.00
	, @_mindResist DECIMAL(5,2) = 0.00
	, @_moveSpd DECIMAL(5,2) = 100.00
	, @_debuff DECIMAL(5,2) = 0.00
	, @_skillCooldown DECIMAL(5,2) = 0.00
EXECUTE [dbo].[Character_Update]
	@_id OUTPUT
	, @_name
	, @_typeId
	, @_speciesId
	, @_genderId
	, @_sideId
	, @_tier2
	, @_physicalAtk
	, @_energyAtk
	, @_atkSpeed
	, @_critRate
	, @_critDmg
	, @_ignoreDef
	, @_ignoreDodge
	, @_fireDmg
	, @_coldDmg
	, @_lightningDmg
	, @_poisonDmg
	, @_mindDmg
	, @_physicalDef
	, @_energyDef
	, @_hp
	, @_recoveryRate
	, @_dodge
	, @_fireResist
	, @_coldResist
	, @_lightningResist
	, @_poisonResist
	, @_mindResist
	, @_moveSpd
	, @_debuff
	, @_skillCooldown
SELECT * FROM [dbo].[Character] WHERE Id = @_id;

*/
BEGIN
	UPDATE [dbo].[Character]
	SET
		[Name] = @name
		, [TypeId] = @typeId
		, [SpeciesId] = @speciesId
		, [GenderId] = @genderId
		, [SideId] = @sideId
		, [Tier2] = @tier2
		, [PhysicalAtk] = @physicalAtk
		, [EnergyAtk] = @energyAtk
		, [AtkSpeed] = @atkSpeed
		, [CritRate] = @critRate
		, [CritDmg] = @critDmg
		, [IgnoreDef] = @ignoreDef
		, [IgnoreDodge] = @ignoreDodge
		, [FireDmg] = @fireDmg
		, [ColdDmg] = @coldDmg
		, [LightningDmg] = @lightningDmg
		, [PoisonDmg] = @poisonDmg
		, [MindDmg] = @mindDmg
		, [PhysicalDef] = @physicalDef
		, [EnergyDef] = @energyDef
		, [HP] = @hp
		, [RecoveryRate] = @recoveryRate
		, [Dodge] = @dodge
		, [FireResist] = @fireResist
		, [ColdResist] = @coldResist
		, [LightningResist] = @lightningResist
		, [PoisonResist] = @poisonResist
		, [MindResist] = @mindResist
		, [MoveSpd] = @moveSpd
		, [Debuff] = @debuff
		, [SkillCooldown] = @skillCooldown
	WHERE Id = @id
END