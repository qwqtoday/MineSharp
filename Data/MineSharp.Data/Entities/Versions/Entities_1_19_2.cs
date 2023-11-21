using MineSharp.Core.Common;
using MineSharp.Core.Common.Entities;

namespace MineSharp.Data.Entities.Versions;

internal class Entities_1_19_2 : DataVersion<EntityType, EntityInfo>
{
    private static Dictionary<EntityType, EntityInfo> Values { get; } = new Dictionary<EntityType, EntityInfo>()
    {
        { EntityType.Allay, new EntityInfo(0, "allay", "Allay", 0.35f, 0.6f, MobType.Mob, EntityCategory.PassiveMobs) },
        { EntityType.AreaEffectCloud, new EntityInfo(1, "area_effect_cloud", "Area Effect Cloud", 6f, 0.5f, MobType.Other, EntityCategory.Unknown) },
        { EntityType.ArmorStand, new EntityInfo(2, "armor_stand", "Armor Stand", 0.5f, 1.975f, MobType.Living, EntityCategory.Immobile) },
        { EntityType.Arrow, new EntityInfo(3, "arrow", "Arrow", 0.5f, 0.5f, MobType.Projectile, EntityCategory.Projectiles) },
        { EntityType.Axolotl, new EntityInfo(4, "axolotl", "Axolotl", 0.75f, 0.42f, MobType.Animal, EntityCategory.PassiveMobs) },
        { EntityType.Bat, new EntityInfo(5, "bat", "Bat", 0.5f, 0.9f, MobType.Ambient, EntityCategory.PassiveMobs) },
        { EntityType.Bee, new EntityInfo(6, "bee", "Bee", 0.7f, 0.6f, MobType.Animal, EntityCategory.PassiveMobs) },
        { EntityType.Blaze, new EntityInfo(7, "blaze", "Blaze", 0.6f, 1.8f, MobType.Hostile, EntityCategory.HostileMobs) },
        { EntityType.Boat, new EntityInfo(8, "boat", "Boat", 1.375f, 0.5625f, MobType.Other, EntityCategory.Vehicles) },
        { EntityType.ChestBoat, new EntityInfo(9, "chest_boat", "Boat with Chest", 1.375f, 0.5625f, MobType.Other, EntityCategory.Vehicles) },
        { EntityType.Cat, new EntityInfo(10, "cat", "Cat", 0.6f, 0.7f, MobType.Animal, EntityCategory.PassiveMobs) },
        { EntityType.CaveSpider, new EntityInfo(11, "cave_spider", "Cave Spider", 0.7f, 0.5f, MobType.Hostile, EntityCategory.HostileMobs) },
        { EntityType.Chicken, new EntityInfo(12, "chicken", "Chicken", 0.4f, 0.7f, MobType.Animal, EntityCategory.PassiveMobs) },
        { EntityType.Cod, new EntityInfo(13, "cod", "Cod", 0.5f, 0.3f, MobType.WaterCreature, EntityCategory.PassiveMobs) },
        { EntityType.Cow, new EntityInfo(14, "cow", "Cow", 0.9f, 1.4f, MobType.Animal, EntityCategory.PassiveMobs) },
        { EntityType.Creeper, new EntityInfo(15, "creeper", "Creeper", 0.6f, 1.7f, MobType.Hostile, EntityCategory.HostileMobs) },
        { EntityType.Dolphin, new EntityInfo(16, "dolphin", "Dolphin", 0.9f, 0.6f, MobType.WaterCreature, EntityCategory.PassiveMobs) },
        { EntityType.Donkey, new EntityInfo(17, "donkey", "Donkey", 1.3964844f, 1.5f, MobType.Animal, EntityCategory.PassiveMobs) },
        { EntityType.DragonFireball, new EntityInfo(18, "dragon_fireball", "Dragon Fireball", 1f, 1f, MobType.Projectile, EntityCategory.Projectiles) },
        { EntityType.Drowned, new EntityInfo(19, "drowned", "Drowned", 0.6f, 1.95f, MobType.Hostile, EntityCategory.HostileMobs) },
        { EntityType.ElderGuardian, new EntityInfo(20, "elder_guardian", "Elder Guardian", 1.9975f, 1.9975f, MobType.Hostile, EntityCategory.HostileMobs) },
        { EntityType.EndCrystal, new EntityInfo(21, "end_crystal", "End Crystal", 2f, 2f, MobType.Other, EntityCategory.Immobile) },
        { EntityType.EnderDragon, new EntityInfo(22, "ender_dragon", "Ender Dragon", 16f, 8f, MobType.Mob, EntityCategory.HostileMobs) },
        { EntityType.Enderman, new EntityInfo(23, "enderman", "Enderman", 0.6f, 2.9f, MobType.Hostile, EntityCategory.HostileMobs) },
        { EntityType.Endermite, new EntityInfo(24, "endermite", "Endermite", 0.4f, 0.3f, MobType.Hostile, EntityCategory.HostileMobs) },
        { EntityType.Evoker, new EntityInfo(25, "evoker", "Evoker", 0.6f, 1.95f, MobType.Hostile, EntityCategory.HostileMobs) },
        { EntityType.EvokerFangs, new EntityInfo(26, "evoker_fangs", "Evoker Fangs", 0.5f, 0.8f, MobType.Other, EntityCategory.HostileMobs) },
        { EntityType.ExperienceOrb, new EntityInfo(27, "experience_orb", "Experience Orb", 0.5f, 0.5f, MobType.Other, EntityCategory.Unknown) },
        { EntityType.EyeOfEnder, new EntityInfo(28, "eye_of_ender", "Eye of Ender", 0.25f, 0.25f, MobType.Other, EntityCategory.Unknown) },
        { EntityType.FallingBlock, new EntityInfo(29, "falling_block", "Falling Block", 0.98f, 0.98f, MobType.Other, EntityCategory.Unknown) },
        { EntityType.FireworkRocket, new EntityInfo(30, "firework_rocket", "Firework Rocket", 0.25f, 0.25f, MobType.Projectile, EntityCategory.Projectiles) },
        { EntityType.Fox, new EntityInfo(31, "fox", "Fox", 0.6f, 0.7f, MobType.Animal, EntityCategory.PassiveMobs) },
        { EntityType.Frog, new EntityInfo(32, "frog", "Frog", 0.5f, 0.5f, MobType.Animal, EntityCategory.PassiveMobs) },
        { EntityType.Ghast, new EntityInfo(33, "ghast", "Ghast", 4f, 4f, MobType.Mob, EntityCategory.HostileMobs) },
        { EntityType.Giant, new EntityInfo(34, "giant", "Giant", 3.6f, 12f, MobType.Hostile, EntityCategory.HostileMobs) },
        { EntityType.GlowItemFrame, new EntityInfo(35, "glow_item_frame", "Glow Item Frame", 0.5f, 0.5f, MobType.Other, EntityCategory.Immobile) },
        { EntityType.GlowSquid, new EntityInfo(36, "glow_squid", "Glow Squid", 0.8f, 0.8f, MobType.WaterCreature, EntityCategory.PassiveMobs) },
        { EntityType.Goat, new EntityInfo(37, "goat", "Goat", 0.9f, 1.3f, MobType.Animal, EntityCategory.PassiveMobs) },
        { EntityType.Guardian, new EntityInfo(38, "guardian", "Guardian", 0.85f, 0.85f, MobType.Hostile, EntityCategory.HostileMobs) },
        { EntityType.Hoglin, new EntityInfo(39, "hoglin", "Hoglin", 1.3964844f, 1.4f, MobType.Animal, EntityCategory.HostileMobs) },
        { EntityType.Horse, new EntityInfo(40, "horse", "Horse", 1.3964844f, 1.6f, MobType.Animal, EntityCategory.PassiveMobs) },
        { EntityType.Husk, new EntityInfo(41, "husk", "Husk", 0.6f, 1.95f, MobType.Hostile, EntityCategory.HostileMobs) },
        { EntityType.Illusioner, new EntityInfo(42, "illusioner", "Illusioner", 0.6f, 1.95f, MobType.Hostile, EntityCategory.HostileMobs) },
        { EntityType.IronGolem, new EntityInfo(43, "iron_golem", "Iron Golem", 1.4f, 2.7f, MobType.Mob, EntityCategory.PassiveMobs) },
        { EntityType.Item, new EntityInfo(44, "item", "Item", 0.25f, 0.25f, MobType.Other, EntityCategory.Unknown) },
        { EntityType.ItemFrame, new EntityInfo(45, "item_frame", "Item Frame", 0.5f, 0.5f, MobType.Other, EntityCategory.Immobile) },
        { EntityType.Fireball, new EntityInfo(46, "fireball", "Fireball", 1f, 1f, MobType.Projectile, EntityCategory.Projectiles) },
        { EntityType.LeashKnot, new EntityInfo(47, "leash_knot", "Leash Knot", 0.375f, 0.5f, MobType.Other, EntityCategory.Immobile) },
        { EntityType.LightningBolt, new EntityInfo(48, "lightning_bolt", "Lightning Bolt", 0f, 0f, MobType.Other, EntityCategory.Unknown) },
        { EntityType.Llama, new EntityInfo(49, "llama", "Llama", 0.9f, 1.87f, MobType.Animal, EntityCategory.PassiveMobs) },
        { EntityType.LlamaSpit, new EntityInfo(50, "llama_spit", "Llama Spit", 0.25f, 0.25f, MobType.Projectile, EntityCategory.Projectiles) },
        { EntityType.MagmaCube, new EntityInfo(51, "magma_cube", "Magma Cube", 2.04f, 2.04f, MobType.Mob, EntityCategory.HostileMobs) },
        { EntityType.Marker, new EntityInfo(52, "marker", "Marker", 0f, 0f, MobType.Other, EntityCategory.Unknown) },
        { EntityType.Minecart, new EntityInfo(53, "minecart", "Minecart", 0.98f, 0.7f, MobType.Other, EntityCategory.Vehicles) },
        { EntityType.ChestMinecart, new EntityInfo(54, "chest_minecart", "Minecart with Chest", 0.98f, 0.7f, MobType.Other, EntityCategory.Vehicles) },
        { EntityType.CommandBlockMinecart, new EntityInfo(55, "command_block_minecart", "Minecart with Command Block", 0.98f, 0.7f, MobType.Other, EntityCategory.Vehicles) },
        { EntityType.FurnaceMinecart, new EntityInfo(56, "furnace_minecart", "Minecart with Furnace", 0.98f, 0.7f, MobType.Other, EntityCategory.Vehicles) },
        { EntityType.HopperMinecart, new EntityInfo(57, "hopper_minecart", "Minecart with Hopper", 0.98f, 0.7f, MobType.Other, EntityCategory.Vehicles) },
        { EntityType.SpawnerMinecart, new EntityInfo(58, "spawner_minecart", "Minecart with Spawner", 0.98f, 0.7f, MobType.Other, EntityCategory.Vehicles) },
        { EntityType.TntMinecart, new EntityInfo(59, "tnt_minecart", "Minecart with TNT", 0.98f, 0.7f, MobType.Other, EntityCategory.Vehicles) },
        { EntityType.Mule, new EntityInfo(60, "mule", "Mule", 1.3964844f, 1.6f, MobType.Animal, EntityCategory.PassiveMobs) },
        { EntityType.Mooshroom, new EntityInfo(61, "mooshroom", "Mooshroom", 0.9f, 1.4f, MobType.Animal, EntityCategory.PassiveMobs) },
        { EntityType.Ocelot, new EntityInfo(62, "ocelot", "Ocelot", 0.6f, 0.7f, MobType.Animal, EntityCategory.PassiveMobs) },
        { EntityType.Painting, new EntityInfo(63, "painting", "Painting", 0.5f, 0.5f, MobType.Other, EntityCategory.Immobile) },
        { EntityType.Panda, new EntityInfo(64, "panda", "Panda", 1.3f, 1.25f, MobType.Animal, EntityCategory.PassiveMobs) },
        { EntityType.Parrot, new EntityInfo(65, "parrot", "Parrot", 0.5f, 0.9f, MobType.Animal, EntityCategory.PassiveMobs) },
        { EntityType.Phantom, new EntityInfo(66, "phantom", "Phantom", 0.9f, 0.5f, MobType.Mob, EntityCategory.HostileMobs) },
        { EntityType.Pig, new EntityInfo(67, "pig", "Pig", 0.9f, 0.9f, MobType.Animal, EntityCategory.PassiveMobs) },
        { EntityType.Piglin, new EntityInfo(68, "piglin", "Piglin", 0.6f, 1.95f, MobType.Hostile, EntityCategory.HostileMobs) },
        { EntityType.PiglinBrute, new EntityInfo(69, "piglin_brute", "Piglin Brute", 0.6f, 1.95f, MobType.Hostile, EntityCategory.HostileMobs) },
        { EntityType.Pillager, new EntityInfo(70, "pillager", "Pillager", 0.6f, 1.95f, MobType.Hostile, EntityCategory.HostileMobs) },
        { EntityType.PolarBear, new EntityInfo(71, "polar_bear", "Polar Bear", 1.4f, 1.4f, MobType.Animal, EntityCategory.PassiveMobs) },
        { EntityType.Tnt, new EntityInfo(72, "tnt", "Primed TNT", 0.98f, 0.98f, MobType.Other, EntityCategory.Unknown) },
        { EntityType.Pufferfish, new EntityInfo(73, "pufferfish", "Pufferfish", 0.7f, 0.7f, MobType.WaterCreature, EntityCategory.PassiveMobs) },
        { EntityType.Rabbit, new EntityInfo(74, "rabbit", "Rabbit", 0.4f, 0.5f, MobType.Animal, EntityCategory.PassiveMobs) },
        { EntityType.Ravager, new EntityInfo(75, "ravager", "Ravager", 1.95f, 2.2f, MobType.Hostile, EntityCategory.HostileMobs) },
        { EntityType.Salmon, new EntityInfo(76, "salmon", "Salmon", 0.7f, 0.4f, MobType.WaterCreature, EntityCategory.PassiveMobs) },
        { EntityType.Sheep, new EntityInfo(77, "sheep", "Sheep", 0.9f, 1.3f, MobType.Animal, EntityCategory.PassiveMobs) },
        { EntityType.Shulker, new EntityInfo(78, "shulker", "Shulker", 1f, 1f, MobType.Mob, EntityCategory.HostileMobs) },
        { EntityType.ShulkerBullet, new EntityInfo(79, "shulker_bullet", "Shulker Bullet", 0.3125f, 0.3125f, MobType.Projectile, EntityCategory.Projectiles) },
        { EntityType.Silverfish, new EntityInfo(80, "silverfish", "Silverfish", 0.4f, 0.3f, MobType.Hostile, EntityCategory.HostileMobs) },
        { EntityType.Skeleton, new EntityInfo(81, "skeleton", "Skeleton", 0.6f, 1.99f, MobType.Hostile, EntityCategory.HostileMobs) },
        { EntityType.SkeletonHorse, new EntityInfo(82, "skeleton_horse", "Skeleton Horse", 1.3964844f, 1.6f, MobType.Animal, EntityCategory.HostileMobs) },
        { EntityType.Slime, new EntityInfo(83, "slime", "Slime", 2.04f, 2.04f, MobType.Mob, EntityCategory.HostileMobs) },
        { EntityType.SmallFireball, new EntityInfo(84, "small_fireball", "Small Fireball", 0.3125f, 0.3125f, MobType.Projectile, EntityCategory.Projectiles) },
        { EntityType.SnowGolem, new EntityInfo(85, "snow_golem", "Snow Golem", 0.7f, 1.9f, MobType.Mob, EntityCategory.PassiveMobs) },
        { EntityType.Snowball, new EntityInfo(86, "snowball", "Snowball", 0.25f, 0.25f, MobType.Projectile, EntityCategory.Projectiles) },
        { EntityType.SpectralArrow, new EntityInfo(87, "spectral_arrow", "Spectral Arrow", 0.5f, 0.5f, MobType.Projectile, EntityCategory.Projectiles) },
        { EntityType.Spider, new EntityInfo(88, "spider", "Spider", 1.4f, 0.9f, MobType.Hostile, EntityCategory.HostileMobs) },
        { EntityType.Squid, new EntityInfo(89, "squid", "Squid", 0.8f, 0.8f, MobType.WaterCreature, EntityCategory.PassiveMobs) },
        { EntityType.Stray, new EntityInfo(90, "stray", "Stray", 0.6f, 1.99f, MobType.Hostile, EntityCategory.HostileMobs) },
        { EntityType.Strider, new EntityInfo(91, "strider", "Strider", 0.9f, 1.7f, MobType.Animal, EntityCategory.PassiveMobs) },
        { EntityType.Tadpole, new EntityInfo(92, "tadpole", "Tadpole", 0.4f, 0.3f, MobType.WaterCreature, EntityCategory.PassiveMobs) },
        { EntityType.Egg, new EntityInfo(93, "egg", "Thrown Egg", 0.25f, 0.25f, MobType.Projectile, EntityCategory.Projectiles) },
        { EntityType.EnderPearl, new EntityInfo(94, "ender_pearl", "Thrown Ender Pearl", 0.25f, 0.25f, MobType.Projectile, EntityCategory.Projectiles) },
        { EntityType.ExperienceBottle, new EntityInfo(95, "experience_bottle", "Thrown Bottle o' Enchanting", 0.25f, 0.25f, MobType.Projectile, EntityCategory.Projectiles) },
        { EntityType.Potion, new EntityInfo(96, "potion", "Potion", 0.25f, 0.25f, MobType.Projectile, EntityCategory.Projectiles) },
        { EntityType.Trident, new EntityInfo(97, "trident", "Trident", 0.5f, 0.5f, MobType.Projectile, EntityCategory.Projectiles) },
        { EntityType.TraderLlama, new EntityInfo(98, "trader_llama", "Trader Llama", 0.9f, 1.87f, MobType.Animal, EntityCategory.PassiveMobs) },
        { EntityType.TropicalFish, new EntityInfo(99, "tropical_fish", "Tropical Fish", 0.5f, 0.4f, MobType.WaterCreature, EntityCategory.PassiveMobs) },
        { EntityType.Turtle, new EntityInfo(100, "turtle", "Turtle", 1.2f, 0.4f, MobType.Animal, EntityCategory.PassiveMobs) },
        { EntityType.Vex, new EntityInfo(101, "vex", "Vex", 0.4f, 0.8f, MobType.Hostile, EntityCategory.HostileMobs) },
        { EntityType.Villager, new EntityInfo(102, "villager", "Villager", 0.6f, 1.95f, MobType.Passive, EntityCategory.PassiveMobs) },
        { EntityType.Vindicator, new EntityInfo(103, "vindicator", "Vindicator", 0.6f, 1.95f, MobType.Hostile, EntityCategory.HostileMobs) },
        { EntityType.WanderingTrader, new EntityInfo(104, "wandering_trader", "Wandering Trader", 0.6f, 1.95f, MobType.Passive, EntityCategory.PassiveMobs) },
        { EntityType.Warden, new EntityInfo(105, "warden", "Warden", 0.9f, 2.9f, MobType.Hostile, EntityCategory.HostileMobs) },
        { EntityType.Witch, new EntityInfo(106, "witch", "Witch", 0.6f, 1.95f, MobType.Hostile, EntityCategory.HostileMobs) },
        { EntityType.Wither, new EntityInfo(107, "wither", "Wither", 0.9f, 3.5f, MobType.Hostile, EntityCategory.HostileMobs) },
        { EntityType.WitherSkeleton, new EntityInfo(108, "wither_skeleton", "Wither Skeleton", 0.7f, 2.4f, MobType.Hostile, EntityCategory.HostileMobs) },
        { EntityType.WitherSkull, new EntityInfo(109, "wither_skull", "Wither Skull", 0.3125f, 0.3125f, MobType.Projectile, EntityCategory.Projectiles) },
        { EntityType.Wolf, new EntityInfo(110, "wolf", "Wolf", 0.6f, 0.85f, MobType.Animal, EntityCategory.PassiveMobs) },
        { EntityType.Zoglin, new EntityInfo(111, "zoglin", "Zoglin", 1.3964844f, 1.4f, MobType.Hostile, EntityCategory.HostileMobs) },
        { EntityType.Zombie, new EntityInfo(112, "zombie", "Zombie", 0.6f, 1.95f, MobType.Hostile, EntityCategory.HostileMobs) },
        { EntityType.ZombieHorse, new EntityInfo(113, "zombie_horse", "Zombie Horse", 1.3964844f, 1.6f, MobType.Animal, EntityCategory.HostileMobs) },
        { EntityType.ZombieVillager, new EntityInfo(114, "zombie_villager", "Zombie Villager", 0.6f, 1.95f, MobType.Hostile, EntityCategory.HostileMobs) },
        { EntityType.ZombifiedPiglin, new EntityInfo(115, "zombified_piglin", "Zombified Piglin", 0.6f, 1.95f, MobType.Hostile, EntityCategory.HostileMobs) },
        { EntityType.Player, new EntityInfo(116, "player", "Player", 0.6f, 1.8f, MobType.Player, EntityCategory.Unknown) },
        { EntityType.FishingBobber, new EntityInfo(117, "fishing_bobber", "Fishing Bobber", 0.25f, 0.25f, MobType.Projectile, EntityCategory.Projectiles) },
    };
    public override Dictionary<EntityType, EntityInfo> Palette => Values;
}
