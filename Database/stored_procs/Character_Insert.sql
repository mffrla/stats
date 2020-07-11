CREATE PROCEDURE [dbo].[Character_Insert]
	@id INT OUTPUT
	, @name NVARCHAR(50)
	, @typeId INT
	, @speciesId INT
	, @genderId INT
	, @sideId INT
	, @tier2 BIT
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
	@_id INT = 0
	, @_name NVARCHAR(50) = 'Test'
	, @_typeId INT = 1
	, @_speciesId INT = 1
	, @_genderId INT = 1
	, @_sideId INT = 1
	, @_tier2 BIT = 0
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
EXECUTE [dbo].[Character_Insert]
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
	INSERT INTO [dbo].[Character]
		([Name]
		, [TypeId]
		, [SpeciesId]
		, [GenderId]
		, [SideId]
		, [Tier2]
		, [PhysicalAtk]
		, [EnergyAtk]
		, [AtkSpeed]
		, [CritRate]
		, [CritDmg]
		, [IgnoreDef]
		, [IgnoreDodge]
		, [FireDmg]
		, [ColdDmg]
		, [LightningDmg]
		, [PoisonDmg]
		, [MindDmg]
		, [PhysicalDef]
		, [EnergyDef]
		, [HP]
		, [RecoveryRate]
		, [Dodge]
		, [FireResist]
		, [ColdResist]
		, [LightningResist]
		, [PoisonResist]
		, [MindResist]
		, [MoveSpd]
		, [Debuff]
		, [SkillCooldown])
	VALUES
		(@name
		, @typeId
		, @speciesId
		, @genderId
		, @sideId
		, @tier2
		, @physicalAtk
		, @energyAtk
		, @atkSpeed
		, @critRate
		, @critDmg
		, @ignoreDef
		, @ignoreDodge
		, @fireDmg
		, @coldDmg
		, @lightningDmg
		, @poisonDmg
		, @mindDmg
		, @physicalDef
		, @energyDef
		, @hp
		, @recoveryRate
		, @dodge
		, @fireResist
		, @coldResist
		, @lightningResist
		, @poisonResist
		, @mindResist
		, @moveSpd
		, @debuff
		, @skillCooldown)
	SET @id = SCOPE_IDENTITY()
END