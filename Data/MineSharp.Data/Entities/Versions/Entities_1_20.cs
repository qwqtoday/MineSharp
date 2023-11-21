using MineSharp.Core.Common;
using MineSharp.Core.Common.Entities;

namespace MineSharp.Data.Entities.Versions;

internal class Entities_1_20 : DataVersion<EntityType, EntityInfo>
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
        { EntityType.BlockDisplay, new EntityInfo(8, "block_display", "Block Display", 0f, 0f, MobType.Other, EntityCategory.Immobile) },
        { EntityType.Boat, new EntityInfo(9, "boat", "Boat", 1.375f, 0.5625f, MobType.Other, EntityCategory.Vehicles) },
        { EntityType.Camel, new EntityInfo(10, "camel", "Camel", 1.7f, 2.375f, MobType.Animal, EntityCategory.PassiveMobs) },
        { EntityType.Cat, new EntityInfo(11, "cat", "Cat", 0.6f, 0.7f, MobType.Animal, EntityCategory.PassiveMobs) },
        { EntityType.CaveSpider, new EntityInfo(12, "cave_spider", "Cave Spider", 0.7f, 0.5f, MobType.Hostile, EntityCategory.HostileMobs) },
        { EntityType.ChestBoat, new EntityInfo(13, "chest_boat", "Boat with Chest", 1.375f, 0.5625f, MobType.Other, EntityCategory.Vehicles) },
        { EntityType.ChestMinecart, new EntityInfo(14, "chest_minecart", "Minecart with Chest", 0.98f, 0.7f, MobType.Other, EntityCategory.Vehicles) },
        { EntityType.Chicken, new EntityInfo(15, "chicken", "Chicken", 0.4f, 0.7f, MobType.Animal, EntityCategory.PassiveMobs) },
        { EntityType.Cod, new EntityInfo(16, "cod", "Cod", 0.5f, 0.3f, MobType.WaterCreature, EntityCategory.PassiveMobs) },
        { EntityType.CommandBlockMinecart, new EntityInfo(17, "command_block_minecart", "Minecart with Command Block", 0.98f, 0.7f, MobType.Other, EntityCategory.Vehicles) },
        { EntityType.Cow, new EntityInfo(18, "cow", "Cow", 0.9f, 1.4f, MobType.Animal, EntityCategory.PassiveMobs) },
        { EntityType.Creeper, new EntityInfo(19, "creeper", "Creeper", 0.6f, 1.7f, MobType.Hostile, EntityCategory.HostileMobs) },
        { EntityType.Dolphin, new EntityInfo(20, "dolphin", "Dolphin", 0.9f, 0.6f, MobType.WaterCreature, EntityCategory.PassiveMobs) },
        { EntityType.Donkey, new EntityInfo(21, "donkey", "Donkey", 1.3964844f, 1.5f, MobType.Animal, EntityCategory.PassiveMobs) },
        { EntityType.DragonFireball, new EntityInfo(22, "dragon_fireball", "Dragon Fireball", 1f, 1f, MobType.Projectile, EntityCategory.Projectiles) },
        { EntityType.Drowned, new EntityInfo(23, "drowned", "Drowned", 0.6f, 1.95f, MobType.Hostile, EntityCategory.HostileMobs) },
        { EntityType.Egg, new EntityInfo(24, "egg", "Thrown Egg", 0.25f, 0.25f, MobType.Projectile, EntityCategory.Projectiles) },
        { EntityType.ElderGuardian, new EntityInfo(25, "elder_guardian", "Elder Guardian", 1.9975f, 1.9975f, MobType.Hostile, EntityCategory.HostileMobs) },
        { EntityType.EndCrystal, new EntityInfo(26, "end_crystal", "End Crystal", 2f, 2f, MobType.Other, EntityCategory.Immobile) },
        { EntityType.EnderDragon, new EntityInfo(27, "ender_dragon", "Ender Dragon", 16f, 8f, MobType.Mob, EntityCategory.HostileMobs) },
        { EntityType.EnderPearl, new EntityInfo(28, "ender_pearl", "Thrown Ender Pearl", 0.25f, 0.25f, MobType.Projectile, EntityCategory.Projectiles) },
        { EntityType.Enderman, new EntityInfo(29, "enderman", "Enderman", 0.6f, 2.9f, MobType.Hostile, EntityCategory.HostileMobs) },
        { EntityType.Endermite, new EntityInfo(30, "endermite", "Endermite", 0.4f, 0.3f, MobType.Hostile, EntityCategory.HostileMobs) },
        { EntityType.Evoker, new EntityInfo(31, "evoker", "Evoker", 0.6f, 1.95f, MobType.Hostile, EntityCategory.HostileMobs) },
        { EntityType.EvokerFangs, new EntityInfo(32, "evoker_fangs", "Evoker Fangs", 0.5f, 0.8f, MobType.Other, EntityCategory.HostileMobs) },
        { EntityType.ExperienceBottle, new EntityInfo(33, "experience_bottle", "Thrown Bottle o' Enchanting", 0.25f, 0.25f, MobType.Projectile, EntityCategory.Projectiles) },
        { EntityType.ExperienceOrb, new EntityInfo(34, "experience_orb", "Experience Orb", 0.5f, 0.5f, MobType.Other, EntityCategory.Unknown) },
        { EntityType.EyeOfEnder, new EntityInfo(35, "eye_of_ender", "Eye of Ender", 0.25f, 0.25f, MobType.Other, EntityCategory.Unknown) },
        { EntityType.FallingBlock, new EntityInfo(36, "falling_block", "Falling Block", 0.98f, 0.98f, MobType.Other, EntityCategory.Unknown) },
        { EntityType.FireworkRocket, new EntityInfo(37, "firework_rocket", "Firework Rocket", 0.25f, 0.25f, MobType.Projectile, EntityCategory.Projectiles) },
        { EntityType.Fox, new EntityInfo(38, "fox", "Fox", 0.6f, 0.7f, MobType.Animal, EntityCategory.PassiveMobs) },
        { EntityType.Frog, new EntityInfo(39, "frog", "Frog", 0.5f, 0.5f, MobType.Animal, EntityCategory.PassiveMobs) },
        { EntityType.FurnaceMinecart, new EntityInfo(40, "furnace_minecart", "Minecart with Furnace", 0.98f, 0.7f, MobType.Other, EntityCategory.Vehicles) },
        { EntityType.Ghast, new EntityInfo(41, "ghast", "Ghast", 4f, 4f, MobType.Mob, EntityCategory.HostileMobs) },
        { EntityType.Giant, new EntityInfo(42, "giant", "Giant", 3.6f, 12f, MobType.Hostile, EntityCategory.HostileMobs) },
        { EntityType.GlowItemFrame, new EntityInfo(43, "glow_item_frame", "Glow Item Frame", 0.5f, 0.5f, MobType.Other, EntityCategory.Immobile) },
        { EntityType.GlowSquid, new EntityInfo(44, "glow_squid", "Glow Squid", 0.8f, 0.8f, MobType.WaterCreature, EntityCategory.PassiveMobs) },
        { EntityType.Goat, new EntityInfo(45, "goat", "Goat", 0.9f, 1.3f, MobType.Animal, EntityCategory.PassiveMobs) },
        { EntityType.Guardian, new EntityInfo(46, "guardian", "Guardian", 0.85f, 0.85f, MobType.Hostile, EntityCategory.HostileMobs) },
        { EntityType.Hoglin, new EntityInfo(47, "hoglin", "Hoglin", 1.3964844f, 1.4f, MobType.Animal, EntityCategory.HostileMobs) },
        { EntityType.HopperMinecart, new EntityInfo(48, "hopper_minecart", "Minecart with Hopper", 0.98f, 0.7f, MobType.Other, EntityCategory.Vehicles) },
        { EntityType.Horse, new EntityInfo(49, "horse", "Horse", 1.3964844f, 1.6f, MobType.Animal, EntityCategory.PassiveMobs) },
        { EntityType.Husk, new EntityInfo(50, "husk", "Husk", 0.6f, 1.95f, MobType.Hostile, EntityCategory.HostileMobs) },
        { EntityType.Illusioner, new EntityInfo(51, "illusioner", "Illusioner", 0.6f, 1.95f, MobType.Hostile, EntityCategory.HostileMobs) },
        { EntityType.Interaction, new EntityInfo(52, "interaction", "Interaction", 0f, 0f, MobType.Other, EntityCategory.Immobile) },
        { EntityType.IronGolem, new EntityInfo(53, "iron_golem", "Iron Golem", 1.4f, 2.7f, MobType.Mob, EntityCategory.PassiveMobs) },
        { EntityType.Item, new EntityInfo(54, "item", "Item", 0.25f, 0.25f, MobType.Other, EntityCategory.Unknown) },
        { EntityType.ItemDisplay, new EntityInfo(55, "item_display", "Item Display", 0f, 0f, MobType.Other, EntityCategory.Immobile) },
        { EntityType.ItemFrame, new EntityInfo(56, "item_frame", "Item Frame", 0.5f, 0.5f, MobType.Other, EntityCategory.Immobile) },
        { EntityType.Fireball, new EntityInfo(57, "fireball", "Fireball", 1f, 1f, MobType.Projectile, EntityCategory.Projectiles) },
        { EntityType.LeashKnot, new EntityInfo(58, "leash_knot", "Leash Knot", 0.375f, 0.5f, MobType.Other, EntityCategory.Immobile) },
        { EntityType.LightningBolt, new EntityInfo(59, "lightning_bolt", "Lightning Bolt", 0f, 0f, MobType.Other, EntityCategory.Unknown) },
        { EntityType.Llama, new EntityInfo(60, "llama", "Llama", 0.9f, 1.87f, MobType.Animal, EntityCategory.PassiveMobs) },
        { EntityType.LlamaSpit, new EntityInfo(61, "llama_spit", "Llama Spit", 0.25f, 0.25f, MobType.Projectile, EntityCategory.Projectiles) },
        { EntityType.MagmaCube, new EntityInfo(62, "magma_cube", "Magma Cube", 2.04f, 2.04f, MobType.Mob, EntityCategory.HostileMobs) },
        { EntityType.Marker, new EntityInfo(63, "marker", "Marker", 0f, 0f, MobType.Other, EntityCategory.Unknown) },
        { EntityType.Minecart, new EntityInfo(64, "minecart", "Minecart", 0.98f, 0.7f, MobType.Other, EntityCategory.Vehicles) },
        { EntityType.Mooshroom, new EntityInfo(65, "mooshroom", "Mooshroom", 0.9f, 1.4f, MobType.Animal, EntityCategory.PassiveMobs) },
        { EntityType.Mule, new EntityInfo(66, "mule", "Mule", 1.3964844f, 1.6f, MobType.Animal, EntityCategory.PassiveMobs) },
        { EntityType.Ocelot, new EntityInfo(67, "ocelot", "Ocelot", 0.6f, 0.7f, MobType.Animal, EntityCategory.PassiveMobs) },
        { EntityType.Painting, new EntityInfo(68, "painting", "Painting", 0.5f, 0.5f, MobType.Other, EntityCategory.Immobile) },
        { EntityType.Panda, new EntityInfo(69, "panda", "Panda", 1.3f, 1.25f, MobType.Animal, EntityCategory.PassiveMobs) },
        { EntityType.Parrot, new EntityInfo(70, "parrot", "Parrot", 0.5f, 0.9f, MobType.Animal, EntityCategory.PassiveMobs) },
        { EntityType.Phantom, new EntityInfo(71, "phantom", "Phantom", 0.9f, 0.5f, MobType.Mob, EntityCategory.HostileMobs) },
        { EntityType.Pig, new EntityInfo(72, "pig", "Pig", 0.9f, 0.9f, MobType.Animal, EntityCategory.PassiveMobs) },
        { EntityType.Piglin, new EntityInfo(73, "piglin", "Piglin", 0.6f, 1.95f, MobType.Hostile, EntityCategory.HostileMobs) },
        { EntityType.PiglinBrute, new EntityInfo(74, "piglin_brute", "Piglin Brute", 0.6f, 1.95f, MobType.Hostile, EntityCategory.HostileMobs) },
        { EntityType.Pillager, new EntityInfo(75, "pillager", "Pillager", 0.6f, 1.95f, MobType.Hostile, EntityCategory.HostileMobs) },
        { EntityType.PolarBear, new EntityInfo(76, "polar_bear", "Polar Bear", 1.4f, 1.4f, MobType.Animal, EntityCategory.PassiveMobs) },
        { EntityType.Potion, new EntityInfo(77, "potion", "Potion", 0.25f, 0.25f, MobType.Projectile, EntityCategory.Projectiles) },
        { EntityType.Pufferfish, new EntityInfo(78, "pufferfish", "Pufferfish", 0.7f, 0.7f, MobType.WaterCreature, EntityCategory.PassiveMobs) },
        { EntityType.Rabbit, new EntityInfo(79, "rabbit", "Rabbit", 0.4f, 0.5f, MobType.Animal, EntityCategory.PassiveMobs) },
        { EntityType.Ravager, new EntityInfo(80, "ravager", "Ravager", 1.95f, 2.2f, MobType.Hostile, EntityCategory.HostileMobs) },
        { EntityType.Salmon, new EntityInfo(81, "salmon", "Salmon", 0.7f, 0.4f, MobType.WaterCreature, EntityCategory.PassiveMobs) },
        { EntityType.Sheep, new EntityInfo(82, "sheep", "Sheep", 0.9f, 1.3f, MobType.Animal, EntityCategory.PassiveMobs) },
        { EntityType.Shulker, new EntityInfo(83, "shulker", "Shulker", 1f, 1f, MobType.Mob, EntityCategory.HostileMobs) },
        { EntityType.ShulkerBullet, new EntityInfo(84, "shulker_bullet", "Shulker Bullet", 0.3125f, 0.3125f, MobType.Projectile, EntityCategory.Projectiles) },
        { EntityType.Silverfish, new EntityInfo(85, "silverfish", "Silverfish", 0.4f, 0.3f, MobType.Hostile, EntityCategory.HostileMobs) },
        { EntityType.Skeleton, new EntityInfo(86, "skeleton", "Skeleton", 0.6f, 1.99f, MobType.Hostile, EntityCategory.HostileMobs) },
        { EntityType.SkeletonHorse, new EntityInfo(87, "skeleton_horse", "Skeleton Horse", 1.3964844f, 1.6f, MobType.Animal, EntityCategory.HostileMobs) },
        { EntityType.Slime, new EntityInfo(88, "slime", "Slime", 2.04f, 2.04f, MobType.Mob, EntityCategory.HostileMobs) },
        { EntityType.SmallFireball, new EntityInfo(89, "small_fireball", "Small Fireball", 0.3125f, 0.3125f, MobType.Projectile, EntityCategory.Projectiles) },
        { EntityType.Sniffer, new EntityInfo(90, "sniffer", "Sniffer", 1.9f, 1.75f, MobType.Animal, EntityCategory.PassiveMobs) },
        { EntityType.SnowGolem, new EntityInfo(91, "snow_golem", "Snow Golem", 0.7f, 1.9f, MobType.Mob, EntityCategory.PassiveMobs) },
        { EntityType.Snowball, new EntityInfo(92, "snowball", "Snowball", 0.25f, 0.25f, MobType.Projectile, EntityCategory.Projectiles) },
        { EntityType.SpawnerMinecart, new EntityInfo(93, "spawner_minecart", "Minecart with Monster Spawner", 0.98f, 0.7f, MobType.Other, EntityCategory.Vehicles) },
        { EntityType.SpectralArrow, new EntityInfo(94, "spectral_arrow", "Spectral Arrow", 0.5f, 0.5f, MobType.Projectile, EntityCategory.Projectiles) },
        { EntityType.Spider, new EntityInfo(95, "spider", "Spider", 1.4f, 0.9f, MobType.Hostile, EntityCategory.HostileMobs) },
        { EntityType.Squid, new EntityInfo(96, "squid", "Squid", 0.8f, 0.8f, MobType.WaterCreature, EntityCategory.PassiveMobs) },
        { EntityType.Stray, new EntityInfo(97, "stray", "Stray", 0.6f, 1.99f, MobType.Hostile, EntityCategory.HostileMobs) },
        { EntityType.Strider, new EntityInfo(98, "strider", "Strider", 0.9f, 1.7f, MobType.Animal, EntityCategory.PassiveMobs) },
        { EntityType.Tadpole, new EntityInfo(99, "tadpole", "Tadpole", 0.4f, 0.3f, MobType.WaterCreature, EntityCategory.PassiveMobs) },
        { EntityType.TextDisplay, new EntityInfo(100, "text_display", "Text Display", 0f, 0f, MobType.Other, EntityCategory.Immobile) },
        { EntityType.Tnt, new EntityInfo(101, "tnt", "Primed TNT", 0.98f, 0.98f, MobType.Other, EntityCategory.Unknown) },
        { EntityType.TntMinecart, new EntityInfo(102, "tnt_minecart", "Minecart with TNT", 0.98f, 0.7f, MobType.Other, EntityCategory.Vehicles) },
        { EntityType.TraderLlama, new EntityInfo(103, "trader_llama", "Trader Llama", 0.9f, 1.87f, MobType.Animal, EntityCategory.PassiveMobs) },
        { EntityType.Trident, new EntityInfo(104, "trident", "Trident", 0.5f, 0.5f, MobType.Projectile, EntityCategory.Projectiles) },
        { EntityType.TropicalFish, new EntityInfo(105, "tropical_fish", "Tropical Fish", 0.5f, 0.4f, MobType.WaterCreature, EntityCategory.PassiveMobs) },
        { EntityType.Turtle, new EntityInfo(106, "turtle", "Turtle", 1.2f, 0.4f, MobType.Animal, EntityCategory.PassiveMobs) },
        { EntityType.Vex, new EntityInfo(107, "vex", "Vex", 0.4f, 0.8f, MobType.Hostile, EntityCategory.HostileMobs) },
        { EntityType.Villager, new EntityInfo(108, "villager", "Villager", 0.6f, 1.95f, MobType.Passive, EntityCategory.PassiveMobs) },
        { EntityType.Vindicator, new EntityInfo(109, "vindicator", "Vindicator", 0.6f, 1.95f, MobType.Hostile, EntityCategory.HostileMobs) },
        { EntityType.WanderingTrader, new EntityInfo(110, "wandering_trader", "Wandering Trader", 0.6f, 1.95f, MobType.Passive, EntityCategory.PassiveMobs) },
        { EntityType.Warden, new EntityInfo(111, "warden", "Warden", 0.9f, 2.9f, MobType.Hostile, EntityCategory.HostileMobs) },
        { EntityType.Witch, new EntityInfo(112, "witch", "Witch", 0.6f, 1.95f, MobType.Hostile, EntityCategory.HostileMobs) },
        { EntityType.Wither, new EntityInfo(113, "wither", "Wither", 0.9f, 3.5f, MobType.Hostile, EntityCategory.HostileMobs) },
        { EntityType.WitherSkeleton, new EntityInfo(114, "wither_skeleton", "Wither Skeleton", 0.7f, 2.4f, MobType.Hostile, EntityCategory.HostileMobs) },
        { EntityType.WitherSkull, new EntityInfo(115, "wither_skull", "Wither Skull", 0.3125f, 0.3125f, MobType.Projectile, EntityCategory.Projectiles) },
        { EntityType.Wolf, new EntityInfo(116, "wolf", "Wolf", 0.6f, 0.85f, MobType.Animal, EntityCategory.PassiveMobs) },
        { EntityType.Zoglin, new EntityInfo(117, "zoglin", "Zoglin", 1.3964844f, 1.4f, MobType.Hostile, EntityCategory.HostileMobs) },
        { EntityType.Zombie, new EntityInfo(118, "zombie", "Zombie", 0.6f, 1.95f, MobType.Hostile, EntityCategory.HostileMobs) },
        { EntityType.ZombieHorse, new EntityInfo(119, "zombie_horse", "Zombie Horse", 1.3964844f, 1.6f, MobType.Animal, EntityCategory.HostileMobs) },
        { EntityType.ZombieVillager, new EntityInfo(120, "zombie_villager", "Zombie Villager", 0.6f, 1.95f, MobType.Hostile, EntityCategory.HostileMobs) },
        { EntityType.ZombifiedPiglin, new EntityInfo(121, "zombified_piglin", "Zombified Piglin", 0.6f, 1.95f, MobType.Hostile, EntityCategory.HostileMobs) },
        { EntityType.Player, new EntityInfo(122, "player", "Player", 0.6f, 1.8f, MobType.Player, EntityCategory.Unknown) },
        { EntityType.FishingBobber, new EntityInfo(123, "fishing_bobber", "Fishing Bobber", 0.25f, 0.25f, MobType.Projectile, EntityCategory.Projectiles) },
    };
    public override Dictionary<EntityType, EntityInfo> Palette => Values;
}
