using MineSharp.Core.Common;

namespace MineSharp.Bot.IntegrationTests.Tests;

public static class WindowTests
{
    public static Task TestInventoryUpdate()
    {
        return IntegrationTest.RunTest("testInventoryUpdate", async (bot, source) =>
        {
            await bot.Windows!.WaitForInventory();
            await bot.Chat!.SendChat("/clear");

            bot.Windows!.Inventory!.OnSlotChanged += (window, index) =>
            {
                var slot = window.GetSlot(index);
                if (slot.Item?.Info.Name == "diamond" && slot.Item?.Count == 33)
                {
                    source.TrySetResult(true);
                }
            };
        }, commandDelay: 1000);
    }

    public static Task TestOpenContainer()
    {
        return IntegrationTest.RunTest("testOpenContainer", async (bot, source) =>
        {
            await bot.Windows!.WaitForInventory();
            await bot.World!.WaitForChunks();

            await Task.Delay(1000);

            var blockPos = new Position(17, -58, 24);
            var block = bot.World!.World!.GetBlockAt(blockPos);

            var window = await bot.Windows!.OpenContainer(block);
            await Task.Delay(1000);
            var slot = window.GetSlot(0);

            await Task.Delay(1000);
            
            source.TrySetResult(
                window.Slots.Length == 3 * 9
                && slot.Item?.Info.Name == "soul_sand"
                && slot.Item?.Count == 48);
        });
    }
}
