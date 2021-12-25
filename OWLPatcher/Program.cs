using System;
using System.Collections.Generic;
using System.Linq;
using Mutagen.Bethesda;
using Mutagen.Bethesda.FormKeys.SkyrimSE;
using Mutagen.Bethesda.Synthesis;
using Mutagen.Bethesda.Skyrim;
using System.Threading.Tasks;

namespace ListMaker
{
    public class Program
    {
        public static Task<int> Main(string[] args)
        {
            return SynthesisPipeline.Instance
                .SetTypicalOpen(GameRelease.SkyrimSE, "OpenWorldLootPatch.esp")
                .AddPatch<ISkyrimMod, ISkyrimModGetter>(RunPatch)
                .Run(args);
        }

        public static void RunPatch(IPatcherState<ISkyrimMod, ISkyrimModGetter> state)
        {
            var lvliMapWeap = LVLIMapWeap.CreateMap();
            

            foreach (var leveledList in state.LoadOrder.PriorityOrder.LeveledItem().WinningOverrides())
            {
                if (lvliMapWeap.ContainsValue(leveledList.FormKey)) continue;
                
                if (leveledList.Entries == null) continue;

                for (var i = 0; i < leveledList.Entries.Count; i++)
                {
                    var entry = leveledList.Entries[i];
                    if (entry.Data == null) continue;
                    if (!lvliMapWeap.ContainsKey(entry.Data.Reference.FormKey)) continue;
                    if (leveledList.EditorID == null) continue;
                    if (leveledList.EditorID.Contains("OWL_")) continue;

                    var modifiedList = state.PatchMod.LeveledItems.GetOrAddAsOverride(leveledList);
                    modifiedList.Entries![i].Data!.Reference.SetTo(lvliMapWeap[entry.Data.Reference.FormKey]);
                }
            }

            foreach (var npc in state.LoadOrder.PriorityOrder.Npc().WinningOverrides())
            {
                if (npc.Items == null) continue;

                for (var i = 0; i < npc.Items.Count; i++)
                {
                    var entry = npc.Items[i];
                    if (!lvliMapWeap.ContainsKey(entry.Item.Item.FormKey)) continue;
                    var modifiedNpc = state.PatchMod.Npcs.GetOrAddAsOverride(npc);
                    modifiedNpc.Items![i].Item.Item.SetTo(lvliMapWeap[entry.Item.Item.FormKey]);
                }
            }

            var lvliMapArmor = LVLIMapArmor.CreateMap();
            foreach (var leveledList in state.LoadOrder.PriorityOrder.LeveledItem().WinningOverrides())
            {
                if (lvliMapArmor.ContainsValue(leveledList.FormKey)) continue;

                if (leveledList.Entries == null) continue;

                for (var i = 0; i < leveledList.Entries.Count; i++)
                {
                    var entry = leveledList.Entries[i];
                    if (entry.Data == null) continue;
                    if (!lvliMapArmor.ContainsKey(entry.Data.Reference.FormKey)) continue;
                    if (leveledList.EditorID == null) continue;
                    if (leveledList.EditorID.Contains("Outfit")) continue;
                    if (leveledList.EditorID.Contains("OWL_")) continue;

                    var modifiedList = state.PatchMod.LeveledItems.GetOrAddAsOverride(leveledList);
                    modifiedList.Entries![i].Data!.Reference.SetTo(lvliMapArmor[entry.Data.Reference.FormKey]);
                }
            }

            foreach (var container in state.LoadOrder.PriorityOrder.Container().WinningOverrides())
            {
                if (container.Items == null) continue;

                for (var i = 0; i < container.Items.Count; i++)
                {
                    var entry = container.Items[i];

                    if (entry.Item.Item == null) continue;
                    if (!lvliMapWeap.ContainsKey(entry.Item.Item.FormKey) && !lvliMapArmor.ContainsKey(entry.Item.Item.FormKey)) continue;

                    var modifiedContainer = state.PatchMod.Containers.GetOrAddAsOverride(container);
                    if (lvliMapWeap.ContainsKey(entry.Item.Item.FormKey)) {
                        modifiedContainer.Items![i].Item.Item.SetTo(lvliMapWeap[entry.Item.Item.FormKey]);
                    } else {
                        modifiedContainer.Items![i].Item.Item.SetTo(lvliMapArmor[entry.Item.Item.FormKey]);
                    }
                }
            }
        }
    }
}
