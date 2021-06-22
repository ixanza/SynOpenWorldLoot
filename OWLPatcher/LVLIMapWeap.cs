using Mutagen.Bethesda;
using Mutagen.Bethesda.FormKeys.SkyrimSE;
using Mutagen.Bethesda.Plugins;
using System.Collections.Generic;

namespace ListMaker
{
    public static class LVLIMapWeap
    {
        public static Dictionary<FormKey, FormKey> CreateMap()
        {
            var lists = new Dictionary<string, FormKey>()
            {
                { "OWL_Weapon_Daedric_Arrow",             new FormKey("Open World Loot.esp",0x0009B3) },
                { "OWL_Weapon_Dragonbone_Arrow",          new FormKey("Open World Loot.esp",0x0009C0) },
                { "OWL_Weapon_Draugr_Arrow",              new FormKey("Open World Loot.esp",0x0009B4) },
                //{ "OWL_Weapon_DraugrHoned_Arrow",         new FormKey("Open World Loot.esp",0x0008C3) },
                { "OWL_Weapon_Dwarven_Arrow",             new FormKey("Open World Loot.esp",0x0009B5) },
                { "OWL_Weapon_Ebony_Arrow",               new FormKey("Open World Loot.esp",0x0009B6) },
                { "OWL_Weapon_Elven_Arrow",               new FormKey("Open World Loot.esp",0x0009B7) },
                { "OWL_Weapon_Falmer_Arrow",              new FormKey("Open World Loot.esp",0x0009B8) },
                { "OWL_Weapon_Forsworn_Arrow",            new FormKey("Open World Loot.esp",0x0009B9) },
                { "OWL_Weapon_Glass_Arrow",               new FormKey("Open World Loot.esp",0x0009BA) },
                //{ "OWL_Weapon_Imperial_Arrow",            new FormKey("Open World Loot.esp",0x0008FD) },
                { "OWL_Weapon_Iron_Arrow",                new FormKey("Open World Loot.esp",0x0009BB) },
                { "OWL_Weapon_Nordic_Arrow",              new FormKey("Open World Loot.esp",0x0009BE) },
                { "OWL_Weapon_Orcish_Arrow",              new FormKey("Open World Loot.esp",0x0009BC) },
                //{ "OWL_Weapon_Silver_Arrow",              new FormKey("Open World Loot.esp",0x0008FA) },
                { "OWL_Weapon_Stalhrim_Arrow",            new FormKey("Open World Loot.esp",0x0009BF) },
                { "OWL_Weapon_Steel_Arrow",               new FormKey("Open World Loot.esp",0x0009BD) },
                { "OWL_Weapon_Daedric_BattleAxe",         new FormKey("Open World Loot.esp",0x000852) },
                { "OWL_Weapon_Dragonbone_BattleAxe",      new FormKey("Open World Loot.esp",0x00085A) },
                { "OWL_Weapon_Draugr_BattleAxe",          new FormKey("Open World Loot.esp",0x0008C3) },
                { "OWL_Weapon_DraugrHoned_BattleAxe",     new FormKey("Open World Loot.esp",0x0008C3) },
                { "OWL_Weapon_Dwarven_BattleAxe",         new FormKey("Open World Loot.esp",0x00082A) },
                { "OWL_Weapon_Ebony_BattleAxe",           new FormKey("Open World Loot.esp",0x00084A) },
                { "OWL_Weapon_Elven_BattleAxe",           new FormKey("Open World Loot.esp",0x000832) },
                { "OWL_Weapon_Forsworn_BattleAxe",        new FormKey("Open World Loot.esp",0x0008CB) },
                { "OWL_Weapon_Glass_BattleAxe",           new FormKey("Open World Loot.esp",0x000842) },
                { "OWL_Weapon_Imperial_BattleAxe",        new FormKey("Open World Loot.esp",0x0008FD) },
                { "OWL_Weapon_Iron_BattleAxe",            new FormKey("Open World Loot.esp",0x000808) },
                { "OWL_Weapon_Nordic_BattleAxe",          new FormKey("Open World Loot.esp",0x000862) },
                { "OWL_Weapon_Orcish_BattleAxe",          new FormKey("Open World Loot.esp",0x00083A) },
                { "OWL_Weapon_Silver_BattleAxe",          new FormKey("Open World Loot.esp",0x0008FA) },
                { "OWL_Weapon_Stalhrim_BattleAxe",        new FormKey("Open World Loot.esp",0x00086A) },
                { "OWL_Weapon_Steel_BattleAxe",           new FormKey("Open World Loot.esp",0x000822) },
                { "OWL_Weapon_Daedric_Bow",               new FormKey("Open World Loot.esp",0x000854) },
                { "OWL_Weapon_Dragonbone_Bow",            new FormKey("Open World Loot.esp",0x00085C) },
                { "OWL_Weapon_Draugr_Bow",                new FormKey("Open World Loot.esp",0x0008C4) },
                { "OWL_Weapon_DraugrHoned_Bow",           new FormKey("Open World Loot.esp",0x0008C4) },
                { "OWL_Weapon_Dwarven_Bow",               new FormKey("Open World Loot.esp",0x00082C) },
                { "OWL_Weapon_Ebony_Bow",                 new FormKey("Open World Loot.esp",0x00084C) },
                { "OWL_Weapon_Elven_Bow",                 new FormKey("Open World Loot.esp",0x000834) },
                { "OWL_Weapon_Forsworn_Bow",              new FormKey("Open World Loot.esp",0x0008CC) },
                { "OWL_Weapon_Glass_Bow",                 new FormKey("Open World Loot.esp",0x000844) },
                { "OWL_Weapon_Iron_Bow",                  new FormKey("Open World Loot.esp",0x00080A) },
                { "OWL_Weapon_Nordic_Bow",                new FormKey("Open World Loot.esp",0x000864) },
                { "OWL_Weapon_Orcish_Bow",                new FormKey("Open World Loot.esp",0x00083C) },
                { "OWL_Weapon_Stalhrim_Bow",              new FormKey("Open World Loot.esp",0x00086C) },
                { "OWL_Weapon_Steel_Bow",                 new FormKey("Open World Loot.esp",0x000824) },
                { "OWL_Weapon_Daedric_Dagger",            new FormKey("Open World Loot.esp",0x00084D) },
                { "OWL_Weapon_Dragonbone_Dagger",         new FormKey("Open World Loot.esp",0x000855) },
                { "OWL_Weapon_Draugr_Dagger",             new FormKey("Open World Loot.esp",0x0008C2) },
                { "OWL_Weapon_DraugrHoned_Dagger",        new FormKey("Open World Loot.esp",0x0008C2) },
                { "OWL_Weapon_Dwarven_Dagger",            new FormKey("Open World Loot.esp",0x000825) },
                { "OWL_Weapon_Ebony_Dagger",              new FormKey("Open World Loot.esp",0x000845) },
                { "OWL_Weapon_Elven_Dagger",              new FormKey("Open World Loot.esp",0x00082D) },
                { "OWL_Weapon_Forsworn_Dagger",           new FormKey("Open World Loot.esp",0x0008CA) },
                { "OWL_Weapon_Glass_Dagger",              new FormKey("Open World Loot.esp",0x00083D) },
                { "OWL_Weapon_Imperial_Dagger",           new FormKey("Open World Loot.esp",0x0008FC) },
                { "OWL_Weapon_Iron_Dagger",               new FormKey("Open World Loot.esp",0x000803) },
                { "OWL_Weapon_Nordic_Dagger",             new FormKey("Open World Loot.esp",0x00085D) },
                { "OWL_Weapon_Orcish_Dagger",             new FormKey("Open World Loot.esp",0x000835) },
                { "OWL_Weapon_Stalhrim_Dagger",           new FormKey("Open World Loot.esp",0x000865) },
                { "OWL_Weapon_Silver_Dagger",             new FormKey("Open World Loot.esp",0x0008F9) },
                { "OWL_Weapon_Steel_Dagger",              new FormKey("Open World Loot.esp",0x00081D) },
                { "OWL_Weapon_Daedric_GreatSword",        new FormKey("Open World Loot.esp",0x000851) },
                { "OWL_Weapon_Dragonbone_GreatSword",     new FormKey("Open World Loot.esp",0x000859) },
                { "OWL_Weapon_Draugr_GreatSword",         new FormKey("Open World Loot.esp",0x0008C3) },
                { "OWL_Weapon_DraugrHoned_GreatSword",    new FormKey("Open World Loot.esp",0x0008C3) },
                { "OWL_Weapon_Dwarven_GreatSword",        new FormKey("Open World Loot.esp",0x000829) },
                { "OWL_Weapon_Ebony_GreatSword",          new FormKey("Open World Loot.esp",0x000849) },
                { "OWL_Weapon_Elven_GreatSword",          new FormKey("Open World Loot.esp",0x000831) },
                { "OWL_Weapon_Forsworn_GreatSword",       new FormKey("Open World Loot.esp",0x0008CB) },
                { "OWL_Weapon_Glass_GreatSword",          new FormKey("Open World Loot.esp",0x000841) },
                { "OWL_Weapon_Imperial_GreatSword",       new FormKey("Open World Loot.esp",0x0008FD) },
                { "OWL_Weapon_Iron_GreatSword",           new FormKey("Open World Loot.esp",0x000807) },
                { "OWL_Weapon_Nordic_GreatSword",         new FormKey("Open World Loot.esp",0x000861) },
                { "OWL_Weapon_Orcish_GreatSword",         new FormKey("Open World Loot.esp",0x000839) },
                { "OWL_Weapon_Silver_GreatSword",         new FormKey("Open World Loot.esp",0x0008FA) },
                { "OWL_Weapon_Stalhrim_GreatSword",       new FormKey("Open World Loot.esp",0x000869) },
                { "OWL_Weapon_Steel_GreatSword",          new FormKey("Open World Loot.esp",0x000821) },
                { "OWL_Weapon_Daedric_Mace",              new FormKey("Open World Loot.esp",0x000850) },
                { "OWL_Weapon_Dragonbone_Mace",           new FormKey("Open World Loot.esp",0x000858) },
                { "OWL_Weapon_Draugr_Mace",               new FormKey("Open World Loot.esp",0x0008C2) },
                { "OWL_Weapon_DraugrHoned_Mace",          new FormKey("Open World Loot.esp",0x0008C2) },
                { "OWL_Weapon_Dwarven_Mace",              new FormKey("Open World Loot.esp",0x000828) },
                { "OWL_Weapon_Ebony_Mace",                new FormKey("Open World Loot.esp",0x000848) },
                { "OWL_Weapon_Elven_Mace",                new FormKey("Open World Loot.esp",0x000830) },
                { "OWL_Weapon_Forsworn_Mace",             new FormKey("Open World Loot.esp",0x0008CA) },
                { "OWL_Weapon_Glass_Mace",                new FormKey("Open World Loot.esp",0x000840) },
                { "OWL_Weapon_Imperial_Mace",             new FormKey("Open World Loot.esp",0x0008FC) },
                { "OWL_Weapon_Iron_Mace",                 new FormKey("Open World Loot.esp",0x000806) },
                { "OWL_Weapon_Nordic_Mace",               new FormKey("Open World Loot.esp",0x000860) },
                { "OWL_Weapon_Orcish_Mace",               new FormKey("Open World Loot.esp",0x000838) },
                { "OWL_Weapon_Silver_Mace",               new FormKey("Open World Loot.esp",0x0008F9) },
                { "OWL_Weapon_Stalhrim_Mace",             new FormKey("Open World Loot.esp",0x000868) },
                { "OWL_Weapon_Steel_Mace",                new FormKey("Open World Loot.esp",0x000820) },
                { "OWL_Weapon_Alikr_Scimitar",            new FormKey("Open World Loot.esp",0x0008EE) },
                { "OWL_Weapon_Daedric_Sword",             new FormKey("Open World Loot.esp",0x00084E) },
                { "OWL_Weapon_Dragonbone_Sword",          new FormKey("Open World Loot.esp",0x000856) },
                { "OWL_Weapon_Draugr_Sword",              new FormKey("Open World Loot.esp",0x0008C2) },
                { "OWL_Weapon_DraugrHoned_Sword",         new FormKey("Open World Loot.esp",0x0008C2) },
                { "OWL_Weapon_Dwarven_Sword",             new FormKey("Open World Loot.esp",0x000826) },
                { "OWL_Weapon_Ebony_Sword",               new FormKey("Open World Loot.esp",0x000846) },
                { "OWL_Weapon_Forsworn_Sword",            new FormKey("Open World Loot.esp",0x0008CA) },
                { "OWL_Weapon_Elven_Sword",               new FormKey("Open World Loot.esp",0x00082E) },
                { "OWL_Weapon_Glass_Sword",               new FormKey("Open World Loot.esp",0x00083E) },
                { "OWL_Weapon_Iron_Sword",                new FormKey("Open World Loot.esp",0x000804) },
                { "OWL_Weapon_Imperial_Sword",            new FormKey("Open World Loot.esp",0x0008FC) },
                { "OWL_Weapon_Nordic_Sword",              new FormKey("Open World Loot.esp",0x00085E) },
                { "OWL_Weapon_Orcish_Sword",              new FormKey("Open World Loot.esp",0x000836) },
                { "OWL_Weapon_Silver_Sword",              new FormKey("Open World Loot.esp",0x0008F9) },
                { "OWL_Weapon_Stalhrim_Sword",            new FormKey("Open World Loot.esp",0x000866) },
                { "OWL_Weapon_Steel_Sword",               new FormKey("Open World Loot.esp",0x00081E) },
                { "OWL_Weapon_Daedric_WarAxe",            new FormKey("Open World Loot.esp",0x00084F) },
                { "OWL_Weapon_Dragonbone_WarAxe",         new FormKey("Open World Loot.esp",0x000857) },
                { "OWL_Weapon_Draugr_WarAxe",             new FormKey("Open World Loot.esp",0x0008C2) },
                { "OWL_Weapon_DraugrHoned_WarAxe",        new FormKey("Open World Loot.esp",0x0008C2) },
                { "OWL_Weapon_Dwarven_WarAxe",            new FormKey("Open World Loot.esp",0x000827) },
                { "OWL_Weapon_Ebony_WarAxe",              new FormKey("Open World Loot.esp",0x000847) },
                { "OWL_Weapon_Elven_WarAxe",              new FormKey("Open World Loot.esp",0x00082F) },
                { "OWL_Weapon_Forsworn_WarAxe",           new FormKey("Open World Loot.esp",0x0008CA) },
                { "OWL_Weapon_Glass_WarAxe",              new FormKey("Open World Loot.esp",0x00083F) },
                { "OWL_Weapon_Iron_WarAxe",               new FormKey("Open World Loot.esp",0x000805) },
                { "OWL_Weapon_Imperial_WarAxe",           new FormKey("Open World Loot.esp",0x0008FC) },
                { "OWL_Weapon_Nordic_WarAxe",             new FormKey("Open World Loot.esp",0x00085F) },
                { "OWL_Weapon_Orcish_WarAxe",             new FormKey("Open World Loot.esp",0x000837) },
                { "OWL_Weapon_Silver_WarAxe",             new FormKey("Open World Loot.esp",0x0008F9) },
                { "OWL_Weapon_Stalhrim_WarAxe",           new FormKey("Open World Loot.esp",0x000867) },
                { "OWL_Weapon_Steel_WarAxe",              new FormKey("Open World Loot.esp",0x00081F) },
                { "OWL_Weapon_Daedric_Warhammer",         new FormKey("Open World Loot.esp",0x000853) },
                { "OWL_Weapon_Dragonbone_Warhammer",      new FormKey("Open World Loot.esp",0x00085B) },
                { "OWL_Weapon_Draugr_Warhammer",          new FormKey("Open World Loot.esp",0x0008C3) },
                { "OWL_Weapon_DraugrHoned_Warhammer",     new FormKey("Open World Loot.esp",0x0008C3) },
                { "OWL_Weapon_Dwarven_Warhammer",         new FormKey("Open World Loot.esp",0x00082B) },
                { "OWL_Weapon_Ebony_Warhammer",           new FormKey("Open World Loot.esp",0x00084B) },
                { "OWL_Weapon_Elven_Warhammer",           new FormKey("Open World Loot.esp",0x000833) },
                { "OWL_Weapon_Forsworn_Warhammer",        new FormKey("Open World Loot.esp",0x0008CB) },
                { "OWL_Weapon_Glass_Warhammer",           new FormKey("Open World Loot.esp",0x000843) },
                { "OWL_Weapon_Imperial_Warhammer",        new FormKey("Open World Loot.esp",0x0008FD) },
                { "OWL_Weapon_Iron_Warhammer",            new FormKey("Open World Loot.esp",0x000809) },
                { "OWL_Weapon_Nordic_Warhammer",          new FormKey("Open World Loot.esp",0x000863) },
                { "OWL_Weapon_Silver_Warhammer",          new FormKey("Open World Loot.esp",0x0008FA) },
                { "OWL_Weapon_Orcish_Warhammer",          new FormKey("Open World Loot.esp",0x00083B) },
                { "OWL_Weapon_Stalhrim_Warhammer",        new FormKey("Open World Loot.esp",0x00086B) },
                { "OWL_Weapon_Steel_Warhammer",           new FormKey("Open World Loot.esp",0x000823) },
            };

            var weaponMap = new Dictionary<string, Dictionary<string, (FormKey WeaponA, FormKey WeaponB)>>()
            {
                ["Daedric"] = new Dictionary<string, (FormKey WeaponA, FormKey WeaponB)>()
                {
                    { "Arrow",                      (Skyrim.Ammunition.DaedricArrow.FormKey , FormKey.Null) },
                    { "BattleAxe",                  (Skyrim.Weapon.DaedricBattleaxe.FormKey,FormKey.Null) },
                    { "Bow",                        (Skyrim.Weapon.DaedricBow.FormKey,FormKey.Null) },
                    { "Dagger",                     (Skyrim.Weapon.DaedricDagger.FormKey,FormKey.Null) },
                    { "GreatSword",                 (Skyrim.Weapon.DaedricGreatsword.FormKey,FormKey.Null) },
                    { "Mace",                       (Skyrim.Weapon.DaedricMace.FormKey,FormKey.Null) },
                    { "Scimitar",                   (FormKey.Null,FormKey.Null)                        },
                    { "Sword",                      (Skyrim.Weapon.DaedricSword.FormKey,FormKey.Null) },
                    { "WarAxe",                     (Skyrim.Weapon.DaedricWarAxe.FormKey,FormKey.Null) },
                    { "Warhammer",                  (Skyrim.Weapon.DaedricWarhammer.FormKey,FormKey.Null) },
                },

                ["Dragonbone"] = new Dictionary<string, (FormKey WeaponA, FormKey WeaponB)>()
                {
                    { "Arrow",                      (Dawnguard.Ammunition.DLC1DragonboneArrow.FormKey,FormKey.Null) },
                    { "BattleAxe",                  (Dawnguard.Weapon.DLC1DragonboneBattleaxe.FormKey,FormKey.Null) },
                    { "Bow",                        (Dawnguard.Weapon.DLC1DragonboneBow.FormKey,FormKey.Null) },
                    { "Dagger",                     (Dawnguard.Weapon.DLC1DragonboneDagger.FormKey,FormKey.Null) },
                    { "GreatSword",                 (Dawnguard.Weapon.DLC1DragonboneGreatsword.FormKey,FormKey.Null) },
                    { "Mace",                       (Dawnguard.Weapon.DLC1DragonboneMace.FormKey,FormKey.Null) },
                    { "Scimitar",                   (FormKey.Null,FormKey.Null)                           },
                    { "Sword",                      (Dawnguard.Weapon.DLC1DragonboneSword.FormKey,FormKey.Null) },
                    { "WarAxe",                     (Dawnguard.Weapon.DLC1DragonboneWarAxe.FormKey,FormKey.Null) },
                    { "Warhammer",                  (Dawnguard.Weapon.DLC1DragonboneWarhammer.FormKey,FormKey.Null) },
                },

                ["Draugr"] = new Dictionary<string, (FormKey WeaponA, FormKey WeaponB)>()
                {
                    { "Arrow",                      (Skyrim.Ammunition.DraugrArrow.FormKey,FormKey.Null) },
                    { "BattleAxe",                  (Skyrim.Weapon.DraugrBattleAxe.FormKey,FormKey.Null) },
                    { "Bow",                        (Skyrim.Weapon.DraugrBow.FormKey,FormKey.Null) },
                    { "Dagger",                     (FormKey.Null,FormKey.Null)                        },
                    { "GreatSword",                 (Skyrim.Weapon.DraugrGreatsword.FormKey,FormKey.Null) },
                    { "Mace",                       (FormKey.Null,FormKey.Null)                        },
                    { "Scimitar",                   (FormKey.Null,FormKey.Null)                        },
                    { "Sword",                      (Skyrim.Weapon.DraugrSword.FormKey,FormKey.Null) },
                    { "WarAxe",                     (Skyrim.Weapon.DraugrWarAxe.FormKey,FormKey.Null) },
                    { "Warhammer",                  (FormKey.Null,FormKey.Null)                        },
                },

                ["DraugrHoned"] = new Dictionary<string, (FormKey WeaponA, FormKey WeaponB)>()
                {
                    { "Arrow",                      (FormKey.Null,FormKey.Null)                        },
                    { "BattleAxe",                  (Skyrim.Weapon.DraugrBattleAxeHoned.FormKey,FormKey.Null) },
                    { "Bow",                        (Skyrim.Weapon.DraugrBowSupple.FormKey,FormKey.Null) },
                    { "Dagger",                     (FormKey.Null,FormKey.Null)                        },
                    { "GreatSword",                 (Skyrim.Weapon.DraugrGreatswordHoned.FormKey,FormKey.Null) },
                    { "Mace",                       (FormKey.Null,FormKey.Null)                        },
                    { "Scimitar",                   (FormKey.Null,FormKey.Null)                        },
                    { "Sword",                      (Skyrim.Weapon.DraugrSwordHoned.FormKey,FormKey.Null) },
                    { "WarAxe",                     (Skyrim.Weapon.DraugrWarAxeHoned.FormKey,FormKey.Null) },
                    { "Warhammer",                  (FormKey.Null,FormKey.Null)                        },
                },

                ["Dwarven"] = new Dictionary<string, (FormKey WeaponA, FormKey WeaponB)>()
                {
                    { "Arrow",                      (Skyrim.Ammunition.DwarvenArrow.FormKey,FormKey.Null) },
                    { "BattleAxe",                  (Skyrim.Weapon.DwarvenBattleaxe.FormKey,FormKey.Null) },
                    { "Bow",                        (Skyrim.Weapon.DwarvenBow.FormKey,FormKey.Null) },
                    { "Dagger",                     (Skyrim.Weapon.DwarvenDagger.FormKey,FormKey.Null) },
                    { "GreatSword",                 (Skyrim.Weapon.DwarvenGreatsword.FormKey,FormKey.Null) },
                    { "Mace",                       (Skyrim.Weapon.DwarvenMace.FormKey,FormKey.Null) },
                    { "Scimitar",                   (FormKey.Null,FormKey.Null)                        },
                    { "Sword",                      (Skyrim.Weapon.DwarvenSword.FormKey,FormKey.Null) },
                    { "WarAxe",                     (Skyrim.Weapon.DwarvenWarAxe.FormKey,FormKey.Null) },
                    { "Warhammer",                  (Skyrim.Weapon.DwarvenWarhammer.FormKey,FormKey.Null) },
                },

                ["Ebony"] = new Dictionary<string, (FormKey WeaponA, FormKey WeaponB)>()
                {
                    { "Arrow",                      (Skyrim.Ammunition.EbonyArrow.FormKey,FormKey.Null) },
                    { "BattleAxe",                  (Skyrim.Weapon.EbonyBattleaxe.FormKey,FormKey.Null) },
                    { "Bow",                        (Skyrim.Weapon.EbonyBow.FormKey,FormKey.Null) },
                    { "Dagger",                     (Skyrim.Weapon.EbonyDagger.FormKey,FormKey.Null) },
                    { "GreatSword",                 (Skyrim.Weapon.EbonyGreatsword.FormKey,FormKey.Null) },
                    { "Mace",                       (Skyrim.Weapon.EbonyMace.FormKey,FormKey.Null) },
                    { "Scimitar",                   (FormKey.Null,FormKey.Null)                        },
                    { "Sword",                      (Skyrim.Weapon.EbonySword.FormKey,FormKey.Null) },
                    { "WarAxe",                     (Skyrim.Weapon.EbonyWarAxe.FormKey,FormKey.Null) },
                    { "Warhammer",                  (Skyrim.Weapon.EbonyWarhammer.FormKey,FormKey.Null) },
                },

                ["Elven"] = new Dictionary<string, (FormKey WeaponA, FormKey WeaponB)>()
                {
                    { "Arrow",                      (Skyrim.Ammunition.ElvenArrow.FormKey,FormKey.Null) },
                    { "BattleAxe",                  (Skyrim.Weapon.ElvenBattleaxe.FormKey,FormKey.Null) },
                    { "Bow",                        (Skyrim.Weapon.ElvenBow.FormKey,FormKey.Null) },
                    { "Dagger",                     (Skyrim.Weapon.ElvenDagger.FormKey,FormKey.Null) },
                    { "GreatSword",                 (Skyrim.Weapon.ElvenGreatsword.FormKey,FormKey.Null) },
                    { "Mace",                       (Skyrim.Weapon.ElvenMace.FormKey,FormKey.Null) },
                    { "Scimitar",                   (FormKey.Null,FormKey.Null)                        },
                    { "Sword",                      (Skyrim.Weapon.ElvenSword.FormKey,FormKey.Null) },
                    { "WarAxe",                     (Skyrim.Weapon.ElvenWarAxe.FormKey,FormKey.Null) },
                    { "Warhammer",                  (Skyrim.Weapon.ElvenWarhammer.FormKey,FormKey.Null) },
                },

                ["Falmer"] = new Dictionary<string, (FormKey WeaponA, FormKey WeaponB)>()
                {
                    { "Arrow",                      (Skyrim.Ammunition.FalmerArrow.FormKey,FormKey.Null) },
                    { "BattleAxe",                  (FormKey.Null,FormKey.Null)                        },
                    { "Bow",                        (Skyrim.Weapon.FalmerBow.FormKey,FormKey.Null) },
                    { "Dagger",                     (FormKey.Null,FormKey.Null)                        },
                    { "GreatSword",                 (FormKey.Null,FormKey.Null)                        },
                    { "Mace",                       (FormKey.Null,FormKey.Null)                        },
                    { "Scimitar",                   (FormKey.Null,FormKey.Null)                        },
                    { "Sword",                      (Skyrim.Weapon.FalmerSword.FormKey,FormKey.Null) },
                    { "WarAxe",                     (Skyrim.Weapon.FalmerWarAxe.FormKey,FormKey.Null) },
                    { "Warhammer",                  (FormKey.Null,FormKey.Null)                        },
                },

                ["FalmerHoned"] = new Dictionary<string, (FormKey WeaponA, FormKey WeaponB)>()
                {
                    { "Arrow",                      (FormKey.Null,FormKey.Null)                        },
                    { "BattleAxe",                  (FormKey.Null,FormKey.Null)                        },
                    { "Bow",                        (Skyrim.Weapon.FalmerBowSupple.FormKey,FormKey.Null) },
                    { "Dagger",                     (FormKey.Null,FormKey.Null)                        },
                    { "GreatSword",                 (FormKey.Null,FormKey.Null)                        },
                    { "Mace",                       (FormKey.Null,FormKey.Null)                        },
                    { "Scimitar",                   (FormKey.Null,FormKey.Null)                        },
                    { "Sword",                      (Skyrim.Weapon.FalmerSwordHoned.FormKey,FormKey.Null) },
                    { "WarAxe",                     (Skyrim.Weapon.FalmerWarAxeHoned.FormKey,FormKey.Null) },
                    { "Warhammer",                  (FormKey.Null,FormKey.Null)                        },
                },

                ["Forsworn"] = new Dictionary<string, (FormKey WeaponA, FormKey WeaponB)>()
                {
                    { "Arrow",                      (Skyrim.Ammunition.ForswornArrow.FormKey,FormKey.Null) },
                    { "BattleAxe",                  (FormKey.Null,FormKey.Null)                        },
                    { "Bow",                        (Skyrim.Weapon.ForswornBow.FormKey,FormKey.Null) },
                    { "Dagger",                     (FormKey.Null,FormKey.Null)                        },
                    { "GreatSword",                 (FormKey.Null,FormKey.Null)                        },
                    { "Mace",                       (FormKey.Null,FormKey.Null)                        },
                    { "Scimitar",                   (FormKey.Null,FormKey.Null)                        },
                    { "Sword",                      (Skyrim.Weapon.ForswornSword.FormKey,FormKey.Null) },
                    { "WarAxe",                     (Skyrim.Weapon.ForswornAxe.FormKey,FormKey.Null) },
                    { "Warhammer",                  (FormKey.Null,FormKey.Null)                        },
                },

                ["Glass"] = new Dictionary<string, (FormKey WeaponA, FormKey WeaponB)>()
                {
                    { "Arrow",                      (Skyrim.Ammunition.GlassArrow.FormKey,FormKey.Null) },
                    { "BattleAxe",                  (Skyrim.Weapon.GlassBattleaxe.FormKey,FormKey.Null) },
                    { "Bow",                        (Skyrim.Weapon.GlassBow.FormKey,FormKey.Null) },
                    { "Dagger",                     (Skyrim.Weapon.GlassDagger.FormKey,FormKey.Null) },
                    { "GreatSword",                 (Skyrim.Weapon.GlassGreatsword.FormKey,FormKey.Null) },
                    { "Mace",                       (Skyrim.Weapon.GlassMace.FormKey,FormKey.Null) },
                    { "Scimitar",                   (FormKey.Null,FormKey.Null)                        },
                    { "Sword",                      (Skyrim.Weapon.GlassSword.FormKey,FormKey.Null) },
                    { "WarAxe",                     (Skyrim.Weapon.GlassWarAxe.FormKey,FormKey.Null) },
                    { "Warhammer",                  (Skyrim.Weapon.GlassWarhammer.FormKey,FormKey.Null) },
                },

                ["Imperial"] = new Dictionary<string, (FormKey WeaponA, FormKey WeaponB)>()
                {
                    { "Arrow",                      (FormKey.Null,FormKey.Null)                        },
                    { "BattleAxe",                  (FormKey.Null,FormKey.Null)                        },
                    { "Bow",                        (FormKey.Null,FormKey.Null) },
                    { "Dagger",                     (FormKey.Null,FormKey.Null)                        },
                    { "GreatSword",                 (FormKey.Null,FormKey.Null)                        },
                    { "Mace",                       (FormKey.Null,FormKey.Null)                        },
                    { "Scimitar",                   (FormKey.Null,FormKey.Null)                        },
                    { "Sword",                      (Skyrim.Weapon.Imperialsword.FormKey,FormKey.Null) },
                    { "WarAxe",                     (FormKey.Null,FormKey.Null) },
                    { "Warhammer",                  (FormKey.Null,FormKey.Null)                        },
                },

                ["Iron"] = new Dictionary<string, (FormKey WeaponA, FormKey WeaponB)>()
                {
                    { "Arrow",                      (Skyrim.Ammunition.IronArrow.FormKey,FormKey.Null) },
                    { "BattleAxe",                  (Skyrim.Weapon.IronBattleaxe.FormKey,FormKey.Null) },
                    { "Bow",                        (Skyrim.Weapon.HuntingBow.FormKey,Skyrim.Weapon.LongBow.FormKey) },
                    { "Dagger",                     (Skyrim.Weapon.IronDagger.FormKey,FormKey.Null) },
                    { "GreatSword",                 (Skyrim.Weapon.IronGreatsword.FormKey,FormKey.Null) },
                    { "Mace",                       (Skyrim.Weapon.IronMace.FormKey,FormKey.Null) },
                    { "Scimitar",                   (FormKey.Null,FormKey.Null)                        },
                    { "Sword",                      (Skyrim.Weapon.IronSword.FormKey,FormKey.Null) },
                    { "WarAxe",                     (Skyrim.Weapon.IronWarAxe.FormKey,FormKey.Null) },
                    { "Warhammer",                  (Skyrim.Weapon.IronWarhammer.FormKey,FormKey.Null) },
                },

                ["Nordic"] = new Dictionary<string, (FormKey WeaponA, FormKey WeaponB)>()
                {
                    { "Arrow",                      (Dragonborn.Ammunition.DLC2NordicArrow.FormKey,FormKey.Null) },
                    { "BattleAxe",                  (Dragonborn.Weapon.DLC2NordicBattleaxe.FormKey,FormKey.Null) },
                    { "Bow",                        (Dragonborn.Weapon.DLC2NordicBow.FormKey,FormKey.Null) },
                    { "Dagger",                     (Dragonborn.Weapon.DLC2NordicDagger.FormKey,FormKey.Null) },
                    { "GreatSword",                 (Dragonborn.Weapon.DLC2NordicGreatsword.FormKey,FormKey.Null) },
                    { "Mace",                       (Dragonborn.Weapon.DLC2NordicMace.FormKey,FormKey.Null) },
                    { "Scimitar",                   (FormKey.Null,FormKey.Null)                            },
                    { "Sword",                      (Dragonborn.Weapon.DLC2NordicSword.FormKey,FormKey.Null) },
                    { "WarAxe",                     (Dragonborn.Weapon.DLC2NordicWarAxe.FormKey,FormKey.Null) },
                    { "Warhammer",                  (Dragonborn.Weapon.DLC2NordicWarhammer.FormKey,FormKey.Null) },
                },

                ["Orcish"] = new Dictionary<string, (FormKey WeaponA, FormKey WeaponB)>()
                {
                    { "Arrow",                      (Skyrim.Ammunition.OrcishArrow.FormKey,FormKey.Null) },
                    { "BattleAxe",                  (Skyrim.Weapon.OrcishBattleaxe.FormKey,FormKey.Null) },
                    { "Bow",                        (Skyrim.Weapon.OrcishBow.FormKey,FormKey.Null) },
                    { "Dagger",                     (Skyrim.Weapon.OrcishDagger.FormKey,FormKey.Null) },
                    { "GreatSword",                 (Skyrim.Weapon.OrcishGreatsword.FormKey,FormKey.Null) },
                    { "Mace",                       (Skyrim.Weapon.OrcishMace.FormKey,FormKey.Null) },
                    { "Scimitar",                   (FormKey.Null,FormKey.Null)                        },
                    { "Sword",                      (Skyrim.Weapon.OrcishSword.FormKey,FormKey.Null) },
                    { "WarAxe",                     (Skyrim.Weapon.OrcishWarAxe.FormKey,FormKey.Null) },
                    { "Warhammer",                  (Skyrim.Weapon.OrcishWarhammer.FormKey,FormKey.Null) },
                },

                ["Silver"] = new Dictionary<string, (FormKey WeaponA, FormKey WeaponB)>()
                {
                    { "Arrow",                      (FormKey.Null,FormKey.Null)                         },
                    { "BattleAxe",                  (FormKey.Null,FormKey.Null)                         },
                    { "Bow",                        (FormKey.Null,FormKey.Null)                         },
                    { "Dagger",                     (FormKey.Null,FormKey.Null)                         },
                    { "GreatSword",                 (Skyrim.Weapon.SilverGreatsword.FormKey,FormKey.Null)  },
                    { "Mace",                       (FormKey.Null,FormKey.Null)                         },
                    { "Scimitar",                   (FormKey.Null,FormKey.Null)                         },
                    { "Sword",                      (Skyrim.Weapon.SilverSword.FormKey,FormKey.Null)  },
                    { "WarAxe",                     (FormKey.Null,FormKey.Null)                         },
                    { "Warhammer",                  (FormKey.Null,FormKey.Null)                         },
                },

                ["Stalhrim"] = new Dictionary<string, (FormKey WeaponA, FormKey WeaponB)>()
                {
                    { "Arrow",                      (Dragonborn.Ammunition.DLC2StalhrimArrow.FormKey,FormKey.Null) },
                    { "BattleAxe",                  (Dragonborn.Weapon.DLC2StalhrimBattleaxe.FormKey,FormKey.Null) },
                    { "Bow",                        (Dragonborn.Weapon.DLC2StalhrimBow.FormKey,FormKey.Null) },
                    { "Dagger",                     (Dragonborn.Weapon.DLC2StalhrimDagger.FormKey,FormKey.Null) },
                    { "GreatSword",                 (Dragonborn.Weapon.DLC2StalhrimGreatsword.FormKey,FormKey.Null) },
                    { "Mace",                       (Dragonborn.Weapon.DLC2StalhrimMace.FormKey,FormKey.Null) },
                    { "Scimitar",                   (FormKey.Null,FormKey.Null)                            },
                    { "Sword",                      (Dragonborn.Weapon.DLC2StalhrimSword.FormKey,FormKey.Null) },
                    { "WarAxe",                     (Dragonborn.Weapon.DLC2StalhrimWarAxe.FormKey,FormKey.Null) },
                    { "Warhammer",                  (Dragonborn.Weapon.DLC2StalhrimWarhammer.FormKey,FormKey.Null) },
                },

                ["Steel"] = new Dictionary<string, (FormKey WeaponA, FormKey WeaponB)>()
                {
                    { "Arrow",                      (Skyrim.Ammunition.SteelArrow.FormKey,FormKey.Null) },
                    { "BattleAxe",                  (Skyrim.Weapon.SteelBattleaxe.FormKey,FormKey.Null) },
                    { "Bow",                        (Skyrim.Weapon.ImperialBow.FormKey,FormKey.Null) },
                    { "Dagger",                     (Skyrim.Weapon.SteelDagger.FormKey,FormKey.Null) },
                    { "GreatSword",                 (Skyrim.Weapon.SteelGreatsword.FormKey,FormKey.Null) },
                    { "Mace",                       (Skyrim.Weapon.SteelMace.FormKey,FormKey.Null) },
                    { "Scimitar",                   (FormKey.Null,FormKey.Null)                        },
                    { "Sword",                      (Skyrim.Weapon.SteelSword.FormKey,FormKey.Null) },
                    { "WarAxe",                     (Skyrim.Weapon.SteelWarAxe.FormKey,FormKey.Null) },
                    { "Warhammer",                  (Skyrim.Weapon.SteelWarhammer.FormKey,FormKey.Null) },
                },
                ["Alikr"] = new Dictionary<string, (FormKey WeaponA, FormKey WeaponB)>()
                {
                    { "Arrow",                      (FormKey.Null,FormKey.Null)                        },
                    { "BattleAxe",                  (FormKey.Null,FormKey.Null)                        },
                    { "Bow",                        (FormKey.Null,FormKey.Null)                        },
                    { "Dagger",                     (FormKey.Null,FormKey.Null)                        },
                    { "GreatSword",                 (FormKey.Null,FormKey.Null)                        },
                    { "Mace",                       (FormKey.Null,FormKey.Null)                        },
                    { "Scimitar",                   (Skyrim.Weapon.Scimitar.FormKey,FormKey.Null)                        },
                    { "Sword",                      (FormKey.Null,FormKey.Null)                        },
                    { "WarAxe",                     (FormKey.Null,FormKey.Null)                        },
                    { "Warhammer",                  (FormKey.Null,FormKey.Null)                        },
                }
            };

            string[] materials =
            {
                "Alikr",
                "Daedric",
                "Dragonbone",
                "Draugr",
                "DraugrHoned",
                "Dwarven",
                "Ebony",
                "Elven",
                "Forsworn",
                "Glass",
                "Imperial",
                "Iron",
                "Nordic",
                "Orcish",
                "Silver",
                "Stalhrim",
                "Steel"
            };

            string[] weaponTypes =
            {
                "Arrow",
                "BattleAxe",
                "Bow",
                "Dagger",
                "GreatSword",
                "Mace",
                "Scimitar",
                "Sword",
                "WarAxe",
                "Warhammer"
            };

            var lvliMap = new Dictionary<FormKey, FormKey>(); ;

            foreach (var material in materials)
            {
                foreach (var weaponType in weaponTypes)
                {
                    var key = weaponMap[material][weaponType];

                    if (key.WeaponA != FormKey.Null)
                    {
                        lvliMap[key.WeaponA] = lists["OWL_Weapon" + "_" + material + "_" + weaponType];

                    }
                    if (key.WeaponB != FormKey.Null)
                    {
                        lvliMap[key.WeaponB] = lists["OWL_Weapon" + "_" + material + "_" + weaponType];
                    }
                }
            }

            return lvliMap;
        }
    }
}
