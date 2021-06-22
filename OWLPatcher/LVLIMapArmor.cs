using Mutagen.Bethesda;
using Mutagen.Bethesda.FormKeys.SkyrimSE;
using Mutagen.Bethesda.Plugins;
using System.Collections.Generic;

namespace ListMaker
{
    public static class LVLIMapArmor
    {
        public static Dictionary<FormKey, FormKey> CreateMap()
        {
            var lists = new Dictionary<string, FormKey>()
            {
                { "OWL_Armor_Bonemold_Boots",                    new FormKey("Open World Loot.esp",0x0008EC) },
                { "OWL_Armor_Bonemold_Cuirass",                  new FormKey("Open World Loot.esp",0x0008EA) },
                { "OWL_Armor_Bonemold_Gauntlets",                new FormKey("Open World Loot.esp",0x0008EB) },
                { "OWL_Armor_Bonemold_Helmet",                   new FormKey("Open World Loot.esp",0x0008E9) },
                { "OWL_Armor_Bonemold_Shield",                   new FormKey("Open World Loot.esp",0x0008ED) },
                { "OWL_Armor_ChitinHeavy_Boots",                 new FormKey("Open World Loot.esp",0x0008E2) },
                { "OWL_Armor_ChitinHeavy_Cuirass",               new FormKey("Open World Loot.esp",0x0008E0) },
                { "OWL_Armor_ChitinHeavy_Gauntlets",             new FormKey("Open World Loot.esp",0x0008E1) },
                { "OWL_Armor_ChitinHeavy_Helmet",                new FormKey("Open World Loot.esp",0x0008DF) },
                { "OWL_Armor_ChitinHeavy_Shield",                new FormKey("Open World Loot.esp",0x0008E3) },
                { "OWL_Armor_ChitinLight_Boots",                 new FormKey("Open World Loot.esp",0x0008E7) },
                { "OWL_Armor_ChitinLight_Cuirass",               new FormKey("Open World Loot.esp",0x0008E5) },
                { "OWL_Armor_ChitinLight_Gauntlets",             new FormKey("Open World Loot.esp",0x0008E6) },
                { "OWL_Armor_ChitinLight_Helmet",                new FormKey("Open World Loot.esp",0x0008E4) },
                { "OWL_Armor_ChitinLight_Shield",                new FormKey("Open World Loot.esp",0x0008E8) },
                { "OWL_Armor_Daedric_Boots",                     new FormKey("Open World Loot.esp",0x000893) },
                { "OWL_Armor_Daedric_Cuirass",                   new FormKey("Open World Loot.esp",0x000891) },
                { "OWL_Armor_Daedric_Gauntlets",                 new FormKey("Open World Loot.esp",0x000892) },
                { "OWL_Armor_Daedric_Helmet",                    new FormKey("Open World Loot.esp",0x000890) },
                { "OWL_Armor_Daedric_Shield",                    new FormKey("Open World Loot.esp",0x000894) },
                { "OWL_Armor_DragonHeavy_Boots",                 new FormKey("Open World Loot.esp",0x000898) },
                { "OWL_Armor_DragonHeavy_Cuirass",               new FormKey("Open World Loot.esp",0x000896) },
                { "OWL_Armor_DragonHeavy_Gauntlets",             new FormKey("Open World Loot.esp",0x000897) },
                { "OWL_Armor_DragonHeavy_Helmet",                new FormKey("Open World Loot.esp",0x000895) },
                { "OWL_Armor_DragonHeavy_Shield",                new FormKey("Open World Loot.esp",0x000899) },
                { "OWL_Armor_DragonLight_Boots",                 new FormKey("Open World Loot.esp",0x00089D) },
                { "OWL_Armor_DragonLight_Cuirass",               new FormKey("Open World Loot.esp",0x00089B) },
                { "OWL_Armor_DragonLight_Gauntlets",             new FormKey("Open World Loot.esp",0x00089C) },
                { "OWL_Armor_DragonLight_Helmet",                new FormKey("Open World Loot.esp",0x00089A) },
                { "OWL_Armor_DragonLight_Shield",                new FormKey("Open World Loot.esp",0x00089E) },
                { "OWL_Armor_Dwarven_Boots",                     new FormKey("Open World Loot.esp",0x00087A) },
                { "OWL_Armor_Dwarven_Cuirass",                   new FormKey("Open World Loot.esp",0x000878) },
                { "OWL_Armor_Dwarven_Gauntlets",                 new FormKey("Open World Loot.esp",0x000879) },
                { "OWL_Armor_Dwarven_Helmet",                    new FormKey("Open World Loot.esp",0x000877) },
                { "OWL_Armor_Dwarven_Shield",                    new FormKey("Open World Loot.esp",0x00087B) },
                { "OWL_Armor_Ebony_Boots",                       new FormKey("Open World Loot.esp",0x00088E) },
                { "OWL_Armor_Ebony_Cuirass",                     new FormKey("Open World Loot.esp",0x00088C) },
                { "OWL_Armor_Ebony_Gauntlets",                   new FormKey("Open World Loot.esp",0x00088D) },
                { "OWL_Armor_Ebony_Helmet",                      new FormKey("Open World Loot.esp",0x00088B) },
                { "OWL_Armor_Ebony_Shield",                      new FormKey("Open World Loot.esp",0x00088F) },
                { "OWL_Armor_Elven_Boots",                       new FormKey("Open World Loot.esp",0x00087F) },
                { "OWL_Armor_Elven_Cuirass",                     new FormKey("Open World Loot.esp",0x00087D) },
                { "OWL_Armor_Elven_Gauntlets",                   new FormKey("Open World Loot.esp",0x00087E) },
                { "OWL_Armor_Elven_Helmet",                      new FormKey("Open World Loot.esp",0x00087C) },
                { "OWL_Armor_Elven_Shield",                      new FormKey("Open World Loot.esp",0x000880) },
                { "OWL_Armor_Fur_Boots",                         new FormKey("Open World Loot.esp",0x000998) },
                { "OWL_Armor_Fur_Cuirass",                       new FormKey("Open World Loot.esp",0x000996) },
                { "OWL_Armor_Fur_Gauntlets",                     new FormKey("Open World Loot.esp",0x000997) },
                { "OWL_Armor_Fur_Helmet",                        new FormKey("Open World Loot.esp",0x000995) },
                { "OWL_Armor_Glass_Boots",                       new FormKey("Open World Loot.esp",0x000889) },
                { "OWL_Armor_Glass_Cuirass",                     new FormKey("Open World Loot.esp",0x000887) },
                { "OWL_Armor_Glass_Gauntlets",                   new FormKey("Open World Loot.esp",0x000888) },
                { "OWL_Armor_Glass_Helmet",                      new FormKey("Open World Loot.esp",0x000886) },
                { "OWL_Armor_Glass_Shield",                      new FormKey("Open World Loot.esp",0x00088A) },
                { "OWL_Armor_HideStudded_Boots",                 new FormKey("Open World Loot.esp",0x0008B6) },
                { "OWL_Armor_HideStudded_Cuirass",               new FormKey("Open World Loot.esp",0x0008B4) },
                { "OWL_Armor_HideStudded_Gauntlets",             new FormKey("Open World Loot.esp",0x0008B5) },
                { "OWL_Armor_HideStudded_Helmet",                new FormKey("Open World Loot.esp",0x0008B3) },
                { "OWL_Armor_HideStudded_Shield",                new FormKey("Open World Loot.esp",0x0008B7) },
                { "OWL_Armor_Iron_Boots",                        new FormKey("Open World Loot.esp",0x000870) },
                { "OWL_Armor_Iron_Cuirass",                      new FormKey("Open World Loot.esp",0x00086E) },
                { "OWL_Armor_Iron_Gauntlets",                    new FormKey("Open World Loot.esp",0x00086F) },
                { "OWL_Armor_Iron_Helmet",                       new FormKey("Open World Loot.esp",0x00086D) },
                { "OWL_Armor_Iron_Shield",                       new FormKey("Open World Loot.esp",0x000871) },
                { "OWL_Armor_Leather_Boots",                     new FormKey("Open World Loot.esp",0x0008BB) },
                { "OWL_Armor_Leather_Cuirass",                   new FormKey("Open World Loot.esp",0x0008B9) },
                { "OWL_Armor_Leather_Gauntlets",                 new FormKey("Open World Loot.esp",0x0008BA) },
                { "OWL_Armor_Leather_Helmet",                    new FormKey("Open World Loot.esp",0x0008B8) },
                { "OWL_Armor_Nordic_Boots",                      new FormKey("Open World Loot.esp",0x0008A2) },
                { "OWL_Armor_Nordic_Cuirass",                    new FormKey("Open World Loot.esp",0x0008A0) },
                { "OWL_Armor_Nordic_Gauntlets",                  new FormKey("Open World Loot.esp",0x0008A1) },
                { "OWL_Armor_Nordic_Helmet",                     new FormKey("Open World Loot.esp",0x00089F) },
                { "OWL_Armor_Nordic_Shield",                     new FormKey("Open World Loot.esp",0x0008A3) },
                { "OWL_Armor_Orcish_Boots",                      new FormKey("Open World Loot.esp",0x000884) },
                { "OWL_Armor_Orcish_Cuirass",                    new FormKey("Open World Loot.esp",0x000882) },
                { "OWL_Armor_Orcish_Gauntlets",                  new FormKey("Open World Loot.esp",0x000883) },
                { "OWL_Armor_Orcish_Helmet",                     new FormKey("Open World Loot.esp",0x000881) },
                { "OWL_Armor_Orcish_Shield",                     new FormKey("Open World Loot.esp",0x000885) },
                { "OWL_Armor_Scaled_Boots",                      new FormKey("Open World Loot.esp",0x0008C0) },
                { "OWL_Armor_Scaled_Cuirass",                    new FormKey("Open World Loot.esp",0x0008BE) },
                { "OWL_Armor_Scaled_Gauntlets",                  new FormKey("Open World Loot.esp",0x0008BF) },
                { "OWL_Armor_Scaled_Helmet",                     new FormKey("Open World Loot.esp",0x0008BD) },
                { "OWL_Armor_StalhrimHeavy_Boots",               new FormKey("Open World Loot.esp",0x0008A7) },
                { "OWL_Armor_StalhrimHeavy_Cuirass",             new FormKey("Open World Loot.esp",0x0008A5) },
                { "OWL_Armor_StalhrimHeavy_Gauntlets",           new FormKey("Open World Loot.esp",0x0008A6) },
                { "OWL_Armor_StalhrimHeavy_Helmet",              new FormKey("Open World Loot.esp",0x0008A4) },
                { "OWL_Armor_StalhrimHeavy_Shield",              new FormKey("Open World Loot.esp",0x0008A8) },
                { "OWL_Armor_StalhrimLight_Boots",               new FormKey("Open World Loot.esp",0x0008AC) },
                { "OWL_Armor_StalhrimLight_Cuirass",             new FormKey("Open World Loot.esp",0x0008AA) },
                { "OWL_Armor_StalhrimLight_Gauntlets",           new FormKey("Open World Loot.esp",0x0008AB) },
                { "OWL_Armor_StalhrimLight_Helmet",              new FormKey("Open World Loot.esp",0x0008A9) },
                { "OWL_Armor_StalhrimLight_Shield",              new FormKey("Open World Loot.esp",0x0008AD) },
                { "OWL_Armor_SteelPlate_Boots",                  new FormKey("Open World Loot.esp",0x0008B1) },
                { "OWL_Armor_SteelPlate_Cuirass",                new FormKey("Open World Loot.esp",0x0008AF) },
                { "OWL_Armor_SteelPlate_Gauntlets",              new FormKey("Open World Loot.esp",0x0008B0) },
                { "OWL_Armor_SteelPlate_Helmet",                 new FormKey("Open World Loot.esp",0x0008AE) },
                { "OWL_Armor_Steel_Boots",                       new FormKey("Open World Loot.esp",0x000875) },
                { "OWL_Armor_Steel_Cuirass",                     new FormKey("Open World Loot.esp",0x000873) },
                { "OWL_Armor_Steel_Gauntlets",                   new FormKey("Open World Loot.esp",0x000874) },
                { "OWL_Armor_Steel_Helmet",                      new FormKey("Open World Loot.esp",0x000872) },
                { "OWL_Armor_Steel_Shield",                      new FormKey("Open World Loot.esp",0x000876) },

            };

            var armorMap = new Dictionary<string, Dictionary<string, (FormKey ArmorA, FormKey ArmorB, FormKey ArmorC, FormKey ArmorD)>>()
            {
                ["Bonemold"] = new Dictionary<string, (FormKey ArmorA, FormKey ArmorB, FormKey ArmorC, FormKey ArmorD)>()
                {
                    { "Boots",                      (Dragonborn.Armor.DLC2ArmorBonemoldBoots.FormKey , Dragonborn.Armor.DLC2ArmorBonemoldImprovedBoots.FormKey,FormKey.Null,FormKey.Null) },
                    { "Cuirass",                    (Dragonborn.Armor.DLC2ArmorBonemoldCuirassVariant01.FormKey,Dragonborn.Armor.DLC2ArmorBonemoldCuirassVariant02.FormKey,Dragonborn.Armor.DLC2ArmorBonemoldImprovedCuirass.FormKey,FormKey.Null) },
                    { "Gauntlets",                  (Dragonborn.Armor.DLC2ArmorBonemoldGauntlets.FormKey,Dragonborn.Armor.DLC2ArmorBonemoldImprovedGauntlets.FormKey,FormKey.Null,FormKey.Null) },
                    { "Helmet",                     (Dragonborn.Armor.DLC2ArmorBonemoldHelmet.FormKey,Dragonborn.Armor.DLC2ArmorBonemoldImprovedHelmet.FormKey,FormKey.Null,FormKey.Null) },
                    { "Shield",                     (Dragonborn.Armor.DLC2ArmorBonemoldShield.FormKey,Dragonborn.Armor.DLC2ArmorBonemoldImprovedShield.FormKey,FormKey.Null,FormKey.Null) },
                },
                ["ChitinHeavy"] = new Dictionary<string, (FormKey ArmorA, FormKey ArmorB, FormKey ArmorC, FormKey ArmorD)>()
                {
                    { "Boots",                      (Dragonborn.Armor.DLC2ArmorChitinHeavyBoots.FormKey , FormKey.Null,FormKey.Null,FormKey.Null) },
                    { "Cuirass",                    (Dragonborn.Armor.DLC2ArmorChitinHeavyCuirass.FormKey,FormKey.Null,FormKey.Null,FormKey.Null) },
                    { "Gauntlets",                  (Dragonborn.Armor.DLC2ArmorChitinHeavyGauntlets.FormKey,FormKey.Null,FormKey.Null,FormKey.Null) },
                    { "Helmet",                     (Dragonborn.Armor.DLC2ArmorChitinHeavyHelmet.FormKey,FormKey.Null,FormKey.Null,FormKey.Null) },
                    { "Shield",                     (FormKey.Null,FormKey.Null,FormKey.Null,FormKey.Null) },
                },
                ["ChitinLight"] = new Dictionary<string, (FormKey ArmorA, FormKey ArmorB, FormKey ArmorC, FormKey ArmorD)>()
                {
                    { "Boots",                      (Dragonborn.Armor.DLC2ArmorChitinLightBoots.FormKey , FormKey.Null,FormKey.Null,FormKey.Null) },
                    { "Cuirass",                    (Dragonborn.Armor.DLC2ArmorChitinLightCuirass.FormKey,FormKey.Null,FormKey.Null,FormKey.Null) },
                    { "Gauntlets",                  (Dragonborn.Armor.DLC2ArmorChitinLightGauntlets.FormKey,FormKey.Null,FormKey.Null,FormKey.Null) },
                    { "Helmet",                     (Dragonborn.Armor.DLC2ArmorChitinLightHelmet.FormKey,FormKey.Null,FormKey.Null,FormKey.Null) },
                    { "Shield",                     (Dragonborn.Armor.DLC2ArmorChitinShield.FormKey,FormKey.Null,FormKey.Null,FormKey.Null) },
                },
                ["Daedric"] = new Dictionary<string, (FormKey ArmorA, FormKey ArmorB, FormKey ArmorC, FormKey ArmorD)>()
                {
                    { "Boots",                      (Skyrim.Armor.ArmorDaedricBoots.FormKey , FormKey.Null,FormKey.Null,FormKey.Null) },
                    { "Cuirass",                    (Skyrim.Armor.ArmorDaedricCuirass.FormKey,FormKey.Null,FormKey.Null,FormKey.Null) },
                    { "Gauntlets",                  (Skyrim.Armor.ArmorDaedricGauntlets.FormKey,FormKey.Null,FormKey.Null,FormKey.Null) },
                    { "Helmet",                     (Skyrim.Armor.ArmorDaedricHelmet.FormKey,FormKey.Null,FormKey.Null,FormKey.Null) },
                    { "Shield",                     (Skyrim.Armor.ArmorDaedricShield.FormKey,FormKey.Null,FormKey.Null,FormKey.Null) },
                },
                ["DragonHeavy"] = new Dictionary<string, (FormKey ArmorA, FormKey ArmorB, FormKey ArmorC, FormKey ArmorD)>()
                {
                    { "Boots",                      (Skyrim.Armor.ArmorDragonplateBoots.FormKey , FormKey.Null,FormKey.Null,FormKey.Null) },
                    { "Cuirass",                    (Skyrim.Armor.ArmorDragonplateCuirass.FormKey,FormKey.Null,FormKey.Null,FormKey.Null) },
                    { "Gauntlets",                  (Skyrim.Armor.ArmorDragonplateGauntlets.FormKey,FormKey.Null,FormKey.Null,FormKey.Null) },
                    { "Helmet",                     (Skyrim.Armor.ArmorDragonplateHelmet.FormKey,FormKey.Null,FormKey.Null,FormKey.Null) },
                    { "Shield",                     (Skyrim.Armor.ArmorDragonplateShield.FormKey,FormKey.Null,FormKey.Null,FormKey.Null) },
                },
                ["DragonLight"] = new Dictionary<string, (FormKey ArmorA, FormKey ArmorB, FormKey ArmorC, FormKey ArmorD)>()
                {
                    { "Boots",                      (Skyrim.Armor.ArmorDragonscaleBoots.FormKey , FormKey.Null,FormKey.Null,FormKey.Null) },
                    { "Cuirass",                    (Skyrim.Armor.ArmorDragonscaleCuirass.FormKey,FormKey.Null,FormKey.Null,FormKey.Null) },
                    { "Gauntlets",                  (Skyrim.Armor.ArmorDragonscaleGauntlets.FormKey,FormKey.Null,FormKey.Null,FormKey.Null) },
                    { "Helmet",                     (Skyrim.Armor.ArmorDragonscaleHelmet.FormKey,FormKey.Null,FormKey.Null,FormKey.Null) },
                    { "Shield",                     (Skyrim.Armor.ArmorDragonscaleShield.FormKey,FormKey.Null,FormKey.Null,FormKey.Null) },
                },
                ["Dwarven"] = new Dictionary<string, (FormKey ArmorA, FormKey ArmorB, FormKey ArmorC, FormKey ArmorD)>()
                {
                    { "Boots",                      (Skyrim.Armor.ArmorDwarvenBoots.FormKey , FormKey.Null,FormKey.Null,FormKey.Null) },
                    { "Cuirass",                    (Skyrim.Armor.ArmorDwarvenCuirass.FormKey,FormKey.Null,FormKey.Null,FormKey.Null) },
                    { "Gauntlets",                  (Skyrim.Armor.ArmorDwarvenGauntlets.FormKey,FormKey.Null,FormKey.Null,FormKey.Null) },
                    { "Helmet",                     (Skyrim.Armor.ArmorDwarvenHelmet.FormKey,FormKey.Null,FormKey.Null,FormKey.Null) },
                    { "Shield",                     (Skyrim.Armor.ArmorDwarvenShield.FormKey,FormKey.Null,FormKey.Null,FormKey.Null) },
                },
                ["Ebony"] = new Dictionary<string, (FormKey ArmorA, FormKey ArmorB, FormKey ArmorC, FormKey ArmorD)>()
                {
                    { "Boots",                      (Skyrim.Armor.ArmorEbonyBoots.FormKey , FormKey.Null,FormKey.Null,FormKey.Null) },
                    { "Cuirass",                    (Skyrim.Armor.ArmorEbonyCuirass.FormKey,FormKey.Null,FormKey.Null,FormKey.Null) },
                    { "Gauntlets",                  (Skyrim.Armor.ArmorEbonyGauntlets.FormKey,FormKey.Null,FormKey.Null,FormKey.Null) },
                    { "Helmet",                     (Skyrim.Armor.ArmorEbonyHelmet.FormKey,FormKey.Null,FormKey.Null,FormKey.Null) },
                    { "Shield",                     (Skyrim.Armor.ArmorEbonyShield.FormKey,FormKey.Null,FormKey.Null,FormKey.Null) },
                },
                ["Elven"] = new Dictionary<string, (FormKey ArmorA, FormKey ArmorB, FormKey ArmorC, FormKey ArmorD)>()
                {
                    { "Boots",                      (Skyrim.Armor.ArmorElvenBoots.FormKey , Skyrim.Armor.ArmorElvenLightBoots.FormKey,FormKey.Null,FormKey.Null) },
                    { "Cuirass",                    (Skyrim.Armor.ArmorElvenCuirass.FormKey,Skyrim.Armor.ArmorElvenLightCuirass.FormKey,Skyrim.Armor.ArmorElvenGildedCuirass.FormKey,FormKey.Null) },
                    { "Gauntlets",                  (Skyrim.Armor.ArmorElvenGauntlets.FormKey,Skyrim.Armor.ArmorElvenLightGauntlets.FormKey,FormKey.Null,FormKey.Null) },
                    { "Helmet",                     (Skyrim.Armor.ArmorElvenHelmet.FormKey,Skyrim.Armor.ArmorElvenLightHelmet.FormKey,FormKey.Null,FormKey.Null) },
                    { "Shield",                     (Skyrim.Armor.ArmorElvenShield.FormKey,FormKey.Null,FormKey.Null,FormKey.Null) },
                },
                ["Fur"] = new Dictionary<string, (FormKey ArmorA, FormKey ArmorB, FormKey ArmorC, FormKey ArmorD)>()
                {
                    { "Boots",                      (Skyrim.Armor.ArmorBanditBoots.FormKey ,FormKey.Null,FormKey.Null,FormKey.Null) },
                    { "Cuirass",                    (Skyrim.Armor.ArmorBanditCuirass.FormKey,Skyrim.Armor.ArmorBanditCuirass1.FormKey,Skyrim.Armor.ArmorBanditCuirass2.FormKey,Skyrim.Armor.ArmorBanditCuirass3.FormKey) },
                    { "Gauntlets",                  (Skyrim.Armor.ArmorBanditGauntlets.FormKey,FormKey.Null,FormKey.Null,FormKey.Null) },
                    { "Helmet",                     (Skyrim.Armor.ArmorBanditHelmet.FormKey,FormKey.Null,FormKey.Null,FormKey.Null) },
                    { "Shield",                     (FormKey.Null,FormKey.Null,FormKey.Null,FormKey.Null) },
                },
                ["Glass"] = new Dictionary<string, (FormKey ArmorA, FormKey ArmorB, FormKey ArmorC, FormKey ArmorD)>()
                {
                    { "Boots",                      (Skyrim.Armor.ArmorGlassBoots.FormKey , FormKey.Null,FormKey.Null,FormKey.Null) },
                    { "Cuirass",                    (Skyrim.Armor.ArmorGlassCuirass.FormKey,FormKey.Null,FormKey.Null,FormKey.Null) },
                    { "Gauntlets",                  (Skyrim.Armor.ArmorGlassGauntlets.FormKey,FormKey.Null,FormKey.Null,FormKey.Null) },
                    { "Helmet",                     (Skyrim.Armor.ArmorGlassHelmet.FormKey,FormKey.Null,FormKey.Null,FormKey.Null) },
                    { "Shield",                     (Skyrim.Armor.ArmorGlassShield.FormKey,FormKey.Null,FormKey.Null,FormKey.Null) },
                },
                ["HideStudded"] = new Dictionary<string, (FormKey ArmorA, FormKey ArmorB, FormKey ArmorC, FormKey ArmorD)>()
                {
                    { "Boots",                      (Skyrim.Armor.ArmorHideBoots.FormKey , FormKey.Null,FormKey.Null,FormKey.Null) },
                    { "Cuirass",                    (Skyrim.Armor.ArmorHideCuirass.FormKey,Skyrim.Armor.ArmorStuddedCuirass.FormKey,FormKey.Null,FormKey.Null) },
                    { "Gauntlets",                  (Skyrim.Armor.ArmorHideGauntlets.FormKey,FormKey.Null,FormKey.Null,FormKey.Null) },
                    { "Helmet",                     (Skyrim.Armor.ArmorHideHelmet.FormKey,FormKey.Null,FormKey.Null,FormKey.Null) },
                    { "Shield",                     (Skyrim.Armor.ArmorHideShield.FormKey,FormKey.Null,FormKey.Null,FormKey.Null) },
                },
                ["Iron"] = new Dictionary<string, (FormKey ArmorA, FormKey ArmorB, FormKey ArmorC, FormKey ArmorD)>()
                {
                    { "Boots",                      (Skyrim.Armor.ArmorIronBoots.FormKey , FormKey.Null,FormKey.Null,FormKey.Null) },
                    { "Cuirass",                    (Skyrim.Armor.ArmorIronCuirass.FormKey,Skyrim.Armor.ArmorIronBandedCuirass.FormKey,FormKey.Null,FormKey.Null) },
                    { "Gauntlets",                  (Skyrim.Armor.ArmorIronGauntlets.FormKey,FormKey.Null,FormKey.Null,FormKey.Null) },
                    { "Helmet",                     (Skyrim.Armor.ArmorIronHelmet.FormKey,FormKey.Null,FormKey.Null,FormKey.Null) },
                    { "Shield",                     (Skyrim.Armor.ArmorIronShield.FormKey,Skyrim.Armor.ArmorIronBandedShield.FormKey,FormKey.Null,FormKey.Null) },
                },
                ["Leather"] = new Dictionary<string, (FormKey ArmorA, FormKey ArmorB, FormKey ArmorC, FormKey ArmorD)>()
                {
                    { "Boots",                      (Skyrim.Armor.ArmorLeatherBoots.FormKey , FormKey.Null,FormKey.Null,FormKey.Null) },
                    { "Cuirass",                    (Skyrim.Armor.ArmorLeatherCuirass.FormKey,FormKey.Null,FormKey.Null,FormKey.Null) },
                    { "Gauntlets",                  (Skyrim.Armor.ArmorLeatherGauntlets.FormKey,FormKey.Null,FormKey.Null,FormKey.Null) },
                    { "Helmet",                     (Skyrim.Armor.ArmorLeatherHelmet.FormKey,FormKey.Null,FormKey.Null,FormKey.Null) },
                    { "Shield",                     (FormKey.Null,FormKey.Null,FormKey.Null,FormKey.Null) },
                },
                ["Nordic"] = new Dictionary<string, (FormKey ArmorA, FormKey ArmorB, FormKey ArmorC, FormKey ArmorD)>()
                {
                    { "Boots",                      (Dragonborn.Armor.DLC2ArmorNordicHeavyBoots.FormKey , FormKey.Null,FormKey.Null,FormKey.Null) },
                    { "Cuirass",                    (Dragonborn.Armor.DLC2ArmorNordicHeavyCuirass.FormKey,FormKey.Null,FormKey.Null,FormKey.Null) },
                    { "Gauntlets",                  (Dragonborn.Armor.DLC2ArmorNordicHeavyGauntlets.FormKey,FormKey.Null,FormKey.Null,FormKey.Null) },
                    { "Helmet",                     (Dragonborn.Armor.DLC2ArmorNordicHeavyHelmet.FormKey,FormKey.Null,FormKey.Null,FormKey.Null) },
                    { "Shield",                     (Dragonborn.Armor.DLC2ArmorNordicShield.FormKey,FormKey.Null,FormKey.Null,FormKey.Null) },
                },
                ["Orcish"] = new Dictionary<string, (FormKey ArmorA, FormKey ArmorB, FormKey ArmorC, FormKey ArmorD)>()
                {
                    { "Boots",                      (Skyrim.Armor.ArmorOrcishBoots.FormKey , FormKey.Null,FormKey.Null,FormKey.Null) },
                    { "Cuirass",                    (Skyrim.Armor.ArmorOrcishCuirass.FormKey,FormKey.Null,FormKey.Null,FormKey.Null) },
                    { "Gauntlets",                  (Skyrim.Armor.ArmorOrcishGauntlets.FormKey,FormKey.Null,FormKey.Null,FormKey.Null) },
                    { "Helmet",                     (Skyrim.Armor.ArmorOrcishHelmet.FormKey,FormKey.Null,FormKey.Null,FormKey.Null) },
                    { "Shield",                     (Skyrim.Armor.ArmorOrcishShield.FormKey,FormKey.Null,FormKey.Null,FormKey.Null) },
                },
                ["Scaled"] = new Dictionary<string, (FormKey ArmorA, FormKey ArmorB, FormKey ArmorC, FormKey ArmorD)>()
                {
                    { "Boots",                      (Skyrim.Armor.ArmorScaledBoots.FormKey , FormKey.Null,FormKey.Null,FormKey.Null) },
                    { "Cuirass",                    (Skyrim.Armor.ArmorScaledCuirass.FormKey,Skyrim.Armor.ArmorScaledCuirassB.FormKey,FormKey.Null,FormKey.Null) },
                    { "Gauntlets",                  (Skyrim.Armor.ArmorScaledGauntlets.FormKey,FormKey.Null,FormKey.Null,FormKey.Null) },
                    { "Helmet",                     (Skyrim.Armor.ArmorScaledHelmet.FormKey,FormKey.Null,FormKey.Null,FormKey.Null) },
                    { "Shield",                     (FormKey.Null,FormKey.Null,FormKey.Null,FormKey.Null) },
                },
                ["StalhrimHeavy"] = new Dictionary<string, (FormKey ArmorA, FormKey ArmorB, FormKey ArmorC, FormKey ArmorD)>()
                {
                    { "Boots",                      (Dragonborn.Armor.DLC2ArmorStalhrimHeavyBoots.FormKey , FormKey.Null,FormKey.Null,FormKey.Null) },
                    { "Cuirass",                    (Dragonborn.Armor.DLC2ArmorStalhrimHeavyCuirass.FormKey,FormKey.Null,FormKey.Null,FormKey.Null) },
                    { "Gauntlets",                  (Dragonborn.Armor.DLC2ArmorStalhrimHeavyGauntlets.FormKey,FormKey.Null,FormKey.Null,FormKey.Null) },
                    { "Helmet",                     (Dragonborn.Armor.DLC2ArmorStalhrimHeavyHelmet.FormKey,FormKey.Null,FormKey.Null,FormKey.Null) },
                    { "Shield",                     (FormKey.Null,FormKey.Null,FormKey.Null,FormKey.Null) },
                },
                ["StalhrimLight"] = new Dictionary<string, (FormKey ArmorA, FormKey ArmorB, FormKey ArmorC, FormKey ArmorD)>()
                {
                    { "Boots",                      (Dragonborn.Armor.DLC2ArmorStalhrimLightBoots.FormKey , FormKey.Null,FormKey.Null,FormKey.Null) },
                    { "Cuirass",                    (Dragonborn.Armor.DLC2ArmorStalhrimLightCuirass.FormKey,FormKey.Null,FormKey.Null,FormKey.Null) },
                    { "Gauntlets",                  (Dragonborn.Armor.DLC2ArmorStalhrimLightGauntlets.FormKey,FormKey.Null,FormKey.Null,FormKey.Null) },
                    { "Helmet",                     (Dragonborn.Armor.DLC2ArmorStalhrimLightHelmet.FormKey,FormKey.Null,FormKey.Null,FormKey.Null) },
                    { "Shield",                     (Dragonborn.Armor.DLC2ArmorStalhrimShield.FormKey,FormKey.Null,FormKey.Null,FormKey.Null) },
                },
                ["SteelPlate"] = new Dictionary<string, (FormKey ArmorA, FormKey ArmorB, FormKey ArmorC, FormKey ArmorD)>()
                {
                    { "Boots",                      (Skyrim.Armor.ArmorSteelPlateBoots.FormKey , FormKey.Null,FormKey.Null,FormKey.Null) },
                    { "Cuirass",                    (Skyrim.Armor.ArmorSteelPlateCuirass.FormKey,FormKey.Null,FormKey.Null,FormKey.Null) },
                    { "Gauntlets",                  (Skyrim.Armor.ArmorSteelPlateGauntlets.FormKey,FormKey.Null,FormKey.Null,FormKey.Null) },
                    { "Helmet",                     (Skyrim.Armor.ArmorSteelPlateHelmet.FormKey,FormKey.Null,FormKey.Null,FormKey.Null) },
                    { "Shield",                     (FormKey.Null,FormKey.Null,FormKey.Null,FormKey.Null) },
                },
                ["Steel"] = new Dictionary<string, (FormKey ArmorA, FormKey ArmorB, FormKey ArmorC, FormKey ArmorD)>()
                {
                    { "Boots",                      (Skyrim.Armor.ArmorSteelBootsA.FormKey , Skyrim.Armor.ArmorSteelBootsB.FormKey,FormKey.Null,FormKey.Null) },
                    { "Cuirass",                    (Skyrim.Armor.ArmorSteelCuirassA.FormKey,Skyrim.Armor.ArmorSteelCuirassB.FormKey,FormKey.Null,FormKey.Null) },
                    { "Gauntlets",                  (Skyrim.Armor.ArmorSteelGauntletsA.FormKey,Skyrim.Armor.ArmorSteelGauntletsB.FormKey,FormKey.Null,FormKey.Null) },
                    { "Helmet",                     (Skyrim.Armor.ArmorSteelHelmetA.FormKey,Skyrim.Armor.ArmorSteelHelmetB.FormKey,FormKey.Null,FormKey.Null) },
                    { "Shield",                     (Skyrim.Armor.ArmorSteelShield.FormKey,FormKey.Null,FormKey.Null,FormKey.Null) },
                }
            };

            string[] materials =
            {
                "Bonemold",
                "ChitinHeavy",
                "ChitinLight",
                "Daedric",
                "DragonHeavy",
                "DragonLight",
                "Dwarven",
                "Ebony",
                "Elven",
                "Fur",
                "Glass",
                "HideStudded",
                "Iron",
                "Leather",
                "Nordic",
                "Orcish",
                "Scaled",
                "StalhrimHeavy",
                "StalhrimLight",
                "SteelPlate",
                "Steel"
            };

            string[] armorTypes =
            {
                "Boots",
                "Cuirass",
                "Gauntlets",
                "Helmet",
                "Shield"
            };

            var lvliMap = new Dictionary<FormKey, FormKey>(); ;

            foreach (var material in materials)
            {
                foreach (var armorType in armorTypes)
                {
                    var key = armorMap[material][armorType];

                    if (key.ArmorA != FormKey.Null)
                    {
                        lvliMap[key.ArmorA] = lists["OWL_Armor" + "_" + material + "_" + armorType];

                    }
                    if (key.ArmorB != FormKey.Null)
                    {
                        lvliMap[key.ArmorB] = lists["OWL_Armor" + "_" + material + "_" + armorType];
                    }
                    if (key.ArmorC != FormKey.Null)
                    {
                        lvliMap[key.ArmorC] = lists["OWL_Armor" + "_" + material + "_" + armorType];
                    }
                    if (key.ArmorD != FormKey.Null)
                    {
                        lvliMap[key.ArmorD] = lists["OWL_Armor" + "_" + material + "_" + armorType];
                    }
                }
            }

            return lvliMap;
        }
    }
}
