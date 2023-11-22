using MineSharp.Core.Common.Enchantments;

namespace MineSharp.Core.Common.Items;

public record ItemInfo(
    int Id,
    string Name,
    string DisplayName,
    int StackSize,
    int? MaxDurability,
    EnchantmentCategory[]? EnchantCategories,
    ItemType[]? RepairWith);