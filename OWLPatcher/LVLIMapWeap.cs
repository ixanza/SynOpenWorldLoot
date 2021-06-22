using Mutagen.Bethesda;
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
                    { "Arrow",                      (new FormKey("Skyrim.esm", 0x0139c0),FormKey.Null) },
                    { "BattleAxe",                  (new FormKey("Skyrim.esm", 0x0139b4),FormKey.Null) },
                    { "Bow",                        (new FormKey("Skyrim.esm", 0x0139b5),FormKey.Null) },
                    { "Dagger",                     (new FormKey("Skyrim.esm", 0x0139b6),FormKey.Null) },
                    { "GreatSword",                 (new FormKey("Skyrim.esm", 0x0139b7),FormKey.Null) },
                    { "Mace",                       (new FormKey("Skyrim.esm", 0x0139b8),FormKey.Null) },
                    { "Scimitar",                   (FormKey.Null,FormKey.Null)                        },
                    { "Sword",                      (new FormKey("Skyrim.esm", 0x0139b9),FormKey.Null) },
                    { "WarAxe",                     (new FormKey("Skyrim.esm", 0x0139b3),FormKey.Null) },
                    { "Warhammer",                  (new FormKey("Skyrim.esm", 0x0139ba),FormKey.Null) },
                },

                ["Dragonbone"] = new Dictionary<string, (FormKey WeaponA, FormKey WeaponB)>()
                {
                    { "Arrow",                      (new FormKey("Dawnguard.esm", 0x0176f4),FormKey.Null) },
                    { "BattleAxe",                  (new FormKey("Dawnguard.esm", 0x014fc3),FormKey.Null) },
                    { "Bow",                        (new FormKey("Dawnguard.esm", 0x0176f1),FormKey.Null) },
                    { "Dagger",                     (new FormKey("Dawnguard.esm", 0x014fcb),FormKey.Null) },
                    { "GreatSword",                 (new FormKey("Dawnguard.esm", 0x014fcc),FormKey.Null) },
                    { "Mace",                       (new FormKey("Dawnguard.esm", 0x014fcd),FormKey.Null) },
                    { "Scimitar",                   (FormKey.Null,FormKey.Null)                           },
                    { "Sword",                      (new FormKey("Dawnguard.esm", 0x014fce),FormKey.Null) },
                    { "WarAxe",                     (new FormKey("Dawnguard.esm", 0x014fcf),FormKey.Null) },
                    { "Warhammer",                  (new FormKey("Dawnguard.esm", 0x014fd0),FormKey.Null) },
                },

                ["Draugr"] = new Dictionary<string, (FormKey WeaponA, FormKey WeaponB)>()
                {
                    { "Arrow",                      (new FormKey("Skyrim.esm", 0x034182),FormKey.Null) },
                    { "BattleAxe",                  (new FormKey("Skyrim.esm", 0x01cb64),FormKey.Null) },
                    { "Bow",                        (new FormKey("Skyrim.esm", 0x0302ca),FormKey.Null) },
                    { "Dagger",                     (FormKey.Null,FormKey.Null)                        },
                    { "GreatSword",                 (new FormKey("Skyrim.esm", 0x0236a5),FormKey.Null) },
                    { "Mace",                       (FormKey.Null,FormKey.Null)                        },
                    { "Scimitar",                   (FormKey.Null,FormKey.Null)                        },
                    { "Sword",                      (new FormKey("Skyrim.esm", 0x02c66f),FormKey.Null) },
                    { "WarAxe",                     (new FormKey("Skyrim.esm", 0x02c672),FormKey.Null) },
                    { "Warhammer",                  (FormKey.Null,FormKey.Null)                        },
                },

                ["DraugrHoned"] = new Dictionary<string, (FormKey WeaponA, FormKey WeaponB)>()
                {
                    { "Arrow",                      (FormKey.Null,FormKey.Null)                        },
                    { "BattleAxe",                  (new FormKey("Skyrim.esm", 0x05bf12),FormKey.Null) },
                    { "Bow",                        (new FormKey("Skyrim.esm", 0x05d179),FormKey.Null) },
                    { "Dagger",                     (FormKey.Null,FormKey.Null)                        },
                    { "GreatSword",                 (new FormKey("Skyrim.esm", 0x05bf13),FormKey.Null) },
                    { "Mace",                       (FormKey.Null,FormKey.Null)                        },
                    { "Scimitar",                   (FormKey.Null,FormKey.Null)                        },
                    { "Sword",                      (new FormKey("Skyrim.esm", 0x05bf14),FormKey.Null) },
                    { "WarAxe",                     (new FormKey("Skyrim.esm", 0x05bf15),FormKey.Null) },
                    { "Warhammer",                  (FormKey.Null,FormKey.Null)                        },
                },

                ["Dwarven"] = new Dictionary<string, (FormKey WeaponA, FormKey WeaponB)>()
                {
                    { "Arrow",                      (new FormKey("Skyrim.esm", 0x0139bc),FormKey.Null) },
                    { "BattleAxe",                  (new FormKey("Skyrim.esm", 0x013994),FormKey.Null) },
                    { "Bow",                        (new FormKey("Skyrim.esm", 0x013995),FormKey.Null) },
                    { "Dagger",                     (new FormKey("Skyrim.esm", 0x013996),FormKey.Null) },
                    { "GreatSword",                 (new FormKey("Skyrim.esm", 0x013997),FormKey.Null) },
                    { "Mace",                       (new FormKey("Skyrim.esm", 0x013998),FormKey.Null) },
                    { "Scimitar",                   (FormKey.Null,FormKey.Null)                        },
                    { "Sword",                      (new FormKey("Skyrim.esm", 0x013999),FormKey.Null) },
                    { "WarAxe",                     (new FormKey("Skyrim.esm", 0x013993),FormKey.Null) },
                    { "Warhammer",                  (new FormKey("Skyrim.esm", 0x01399a),FormKey.Null) },
                },

                ["Ebony"] = new Dictionary<string, (FormKey WeaponA, FormKey WeaponB)>()
                {
                    { "Arrow",                      (new FormKey("Skyrim.esm", 0x0139bf),FormKey.Null) },
                    { "BattleAxe",                  (new FormKey("Skyrim.esm", 0x0139ac),FormKey.Null) },
                    { "Bow",                        (new FormKey("Skyrim.esm", 0x0139ad),FormKey.Null) },
                    { "Dagger",                     (new FormKey("Skyrim.esm", 0x0139ae),FormKey.Null) },
                    { "GreatSword",                 (new FormKey("Skyrim.esm", 0x0139af),FormKey.Null) },
                    { "Mace",                       (new FormKey("Skyrim.esm", 0x0139b0),FormKey.Null) },
                    { "Scimitar",                   (FormKey.Null,FormKey.Null)                        },
                    { "Sword",                      (new FormKey("Skyrim.esm", 0x0139b1),FormKey.Null) },
                    { "WarAxe",                     (new FormKey("Skyrim.esm", 0x0139ab),FormKey.Null) },
                    { "Warhammer",                  (new FormKey("Skyrim.esm", 0x0139b2),FormKey.Null) },
                },

                ["Elven"] = new Dictionary<string, (FormKey WeaponA, FormKey WeaponB)>()
                {
                    { "Arrow",                      (new FormKey("Skyrim.esm", 0x0139bd),FormKey.Null) },
                    { "BattleAxe",                  (new FormKey("Skyrim.esm", 0x01399c),FormKey.Null) },
                    { "Bow",                        (new FormKey("Skyrim.esm", 0x01399d),FormKey.Null) },
                    { "Dagger",                     (new FormKey("Skyrim.esm", 0x01399e),FormKey.Null) },
                    { "GreatSword",                 (new FormKey("Skyrim.esm", 0x01399f),FormKey.Null) },
                    { "Mace",                       (new FormKey("Skyrim.esm", 0x0139a0),FormKey.Null) },
                    { "Scimitar",                   (FormKey.Null,FormKey.Null)                        },
                    { "Sword",                      (new FormKey("Skyrim.esm", 0x0139a1),FormKey.Null) },
                    { "WarAxe",                     (new FormKey("Skyrim.esm", 0x01399b),FormKey.Null) },
                    { "Warhammer",                  (new FormKey("Skyrim.esm", 0x0139a2),FormKey.Null) },
                },

                ["Falmer"] = new Dictionary<string, (FormKey WeaponA, FormKey WeaponB)>()
                {
                    { "Arrow",                      (new FormKey("Skyrim.esm", 0x038341),FormKey.Null) },
                    { "BattleAxe",                  (FormKey.Null,FormKey.Null)                        },
                    { "Bow",                        (new FormKey("Skyrim.esm", 0x038340),FormKey.Null) },
                    { "Dagger",                     (FormKey.Null,FormKey.Null)                        },
                    { "GreatSword",                 (FormKey.Null,FormKey.Null)                        },
                    { "Mace",                       (FormKey.Null,FormKey.Null)                        },
                    { "Scimitar",                   (FormKey.Null,FormKey.Null)                        },
                    { "Sword",                      (new FormKey("Skyrim.esm", 0x02e6d1),FormKey.Null) },
                    { "WarAxe",                     (new FormKey("Skyrim.esm", 0x0302cd),FormKey.Null) },
                    { "Warhammer",                  (FormKey.Null,FormKey.Null)                        },
                },

                ["FalmerHoned"] = new Dictionary<string, (FormKey WeaponA, FormKey WeaponB)>()
                {
                    { "Arrow",                      (FormKey.Null,FormKey.Null)                        },
                    { "BattleAxe",                  (FormKey.Null,FormKey.Null)                        },
                    { "Bow",                        (new FormKey("Skyrim.esm", 0x0316e7),FormKey.Null) },
                    { "Dagger",                     (FormKey.Null,FormKey.Null)                        },
                    { "GreatSword",                 (FormKey.Null,FormKey.Null)                        },
                    { "Mace",                       (FormKey.Null,FormKey.Null)                        },
                    { "Scimitar",                   (FormKey.Null,FormKey.Null)                        },
                    { "Sword",                      (new FormKey("Skyrim.esm", 0x06f6ff),FormKey.Null) },
                    { "WarAxe",                     (new FormKey("Skyrim.esm", 0x06f700),FormKey.Null) },
                    { "Warhammer",                  (FormKey.Null,FormKey.Null)                        },
                },

                ["Forsworn"] = new Dictionary<string, (FormKey WeaponA, FormKey WeaponB)>()
                {
                    { "Arrow",                      (new FormKey("Skyrim.esm", 0x0cee9e),FormKey.Null) },
                    { "BattleAxe",                  (FormKey.Null,FormKey.Null)                        },
                    { "Bow",                        (new FormKey("Skyrim.esm", 0x0cee9b),FormKey.Null) },
                    { "Dagger",                     (FormKey.Null,FormKey.Null)                        },
                    { "GreatSword",                 (FormKey.Null,FormKey.Null)                        },
                    { "Mace",                       (FormKey.Null,FormKey.Null)                        },
                    { "Scimitar",                   (FormKey.Null,FormKey.Null)                        },
                    { "Sword",                      (new FormKey("Skyrim.esm", 0x0cade9),FormKey.Null) },
                    { "WarAxe",                     (new FormKey("Skyrim.esm", 0x0cc829),FormKey.Null) },
                    { "Warhammer",                  (FormKey.Null,FormKey.Null)                        },
                },

                ["Glass"] = new Dictionary<string, (FormKey WeaponA, FormKey WeaponB)>()
                {
                    { "Arrow",                      (new FormKey("Skyrim.esm", 0x0139be),FormKey.Null) },
                    { "BattleAxe",                  (new FormKey("Skyrim.esm", 0x0139a4),FormKey.Null) },
                    { "Bow",                        (new FormKey("Skyrim.esm", 0x0139a5),FormKey.Null) },
                    { "Dagger",                     (new FormKey("Skyrim.esm", 0x0139a6),FormKey.Null) },
                    { "GreatSword",                 (new FormKey("Skyrim.esm", 0x0139a7),FormKey.Null) },
                    { "Mace",                       (new FormKey("Skyrim.esm", 0x0139a8),FormKey.Null) },
                    { "Scimitar",                   (FormKey.Null,FormKey.Null)                        },
                    { "Sword",                      (new FormKey("Skyrim.esm", 0x0139a9),FormKey.Null) },
                    { "WarAxe",                     (new FormKey("Skyrim.esm", 0x0139a3),FormKey.Null) },
                    { "Warhammer",                  (new FormKey("Skyrim.esm", 0x0139aa),FormKey.Null) },
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
                    { "Sword",                      (new FormKey("Skyrim.esm", 0x0135b8),FormKey.Null) },
                    { "WarAxe",                     (FormKey.Null,FormKey.Null) },
                    { "Warhammer",                  (FormKey.Null,FormKey.Null)                        },
                },

                ["Iron"] = new Dictionary<string, (FormKey WeaponA, FormKey WeaponB)>()
                {
                    { "Arrow",                      (new FormKey("Skyrim.esm", 0x01397d),FormKey.Null) },
                    { "BattleAxe",                  (new FormKey("Skyrim.esm", 0x013980),FormKey.Null) },
                    { "Bow",                        (new FormKey("Skyrim.esm", 0x03b562),new FormKey("Skyrim.esm", 0x013985)) },
                    { "Dagger",                     (new FormKey("Skyrim.esm", 0x01397e),FormKey.Null) },
                    { "GreatSword",                 (new FormKey("Skyrim.esm", 0x01359d),FormKey.Null) },
                    { "Mace",                       (new FormKey("Skyrim.esm", 0x013982),FormKey.Null) },
                    { "Scimitar",                   (FormKey.Null,FormKey.Null)                        },
                    { "Sword",                      (new FormKey("Skyrim.esm", 0x012eb7),FormKey.Null) },
                    { "WarAxe",                     (new FormKey("Skyrim.esm", 0x013790),FormKey.Null) },
                    { "Warhammer",                  (new FormKey("Skyrim.esm", 0x013981),FormKey.Null) },
                },

                ["Nordic"] = new Dictionary<string, (FormKey WeaponA, FormKey WeaponB)>()
                {
                    { "Arrow",                      (new FormKey("Dragonborn.esm", 0x02623b),FormKey.Null) },
                    { "BattleAxe",                  (new FormKey("Dragonborn.esm", 0x01cdad),FormKey.Null) },
                    { "Bow",                        (new FormKey("Dragonborn.esm", 0x026232),FormKey.Null) },
                    { "Dagger",                     (new FormKey("Dragonborn.esm", 0x01cdae),FormKey.Null) },
                    { "GreatSword",                 (new FormKey("Dragonborn.esm", 0x01cdaf),FormKey.Null) },
                    { "Mace",                       (new FormKey("Dragonborn.esm", 0x01cdb0),FormKey.Null) },
                    { "Scimitar",                   (FormKey.Null,FormKey.Null)                            },
                    { "Sword",                      (new FormKey("Dragonborn.esm", 0x01cdb1),FormKey.Null) },
                    { "WarAxe",                     (new FormKey("Dragonborn.esm", 0x01cdb2),FormKey.Null) },
                    { "Warhammer",                  (new FormKey("Dragonborn.esm", 0x01cdb3),FormKey.Null) },
                },

                ["Orcish"] = new Dictionary<string, (FormKey WeaponA, FormKey WeaponB)>()
                {
                    { "Arrow",                      (new FormKey("Skyrim.esm", 0x0139bb),FormKey.Null) },
                    { "BattleAxe",                  (new FormKey("Skyrim.esm", 0x01398c),FormKey.Null) },
                    { "Bow",                        (new FormKey("Skyrim.esm", 0x01398d),FormKey.Null) },
                    { "Dagger",                     (new FormKey("Skyrim.esm", 0x01398e),FormKey.Null) },
                    { "GreatSword",                 (new FormKey("Skyrim.esm", 0x01398f),FormKey.Null) },
                    { "Mace",                       (new FormKey("Skyrim.esm", 0x013990),FormKey.Null) },
                    { "Scimitar",                   (FormKey.Null,FormKey.Null)                        },
                    { "Sword",                      (new FormKey("Skyrim.esm", 0x013991),FormKey.Null) },
                    { "WarAxe",                     (new FormKey("Skyrim.esm", 0x01398b),FormKey.Null) },
                    { "Warhammer",                  (new FormKey("Skyrim.esm", 0x013992),FormKey.Null) },
                },

                ["Silver"] = new Dictionary<string, (FormKey WeaponA, FormKey WeaponB)>()
                {
                    { "Arrow",                      (FormKey.Null,FormKey.Null)                         },
                    { "BattleAxe",                  (FormKey.Null,FormKey.Null)                         },
                    { "Bow",                        (FormKey.Null,FormKey.Null)                         },
                    { "Dagger",                     (FormKey.Null,FormKey.Null)                         },
                    { "GreatSword",                 (new FormKey("Skyrim.esm", 0x10c6fb),FormKey.Null)  },
                    { "Mace",                       (FormKey.Null,FormKey.Null)                         },
                    { "Scimitar",                   (FormKey.Null,FormKey.Null)                         },
                    { "Sword",                      (new FormKey("Skyrim.esm", 0x10aa19),FormKey.Null)  },
                    { "WarAxe",                     (FormKey.Null,FormKey.Null)                         },
                    { "Warhammer",                  (FormKey.Null,FormKey.Null)                         },
                },

                ["Stalhrim"] = new Dictionary<string, (FormKey WeaponA, FormKey WeaponB)>()
                {
                    { "Arrow",                      (new FormKey("Dragonborn.esm", 0x026239),FormKey.Null) },
                    { "BattleAxe",                  (new FormKey("Dragonborn.esm", 0x01cdb4),FormKey.Null) },
                    { "Bow",                        (new FormKey("Dragonborn.esm", 0x026231),FormKey.Null) },
                    { "Dagger",                     (new FormKey("Dragonborn.esm", 0x01cdb5),FormKey.Null) },
                    { "GreatSword",                 (new FormKey("Dragonborn.esm", 0x01cdb6),FormKey.Null) },
                    { "Mace",                       (new FormKey("Dragonborn.esm", 0x01cdb7),FormKey.Null) },
                    { "Scimitar",                   (FormKey.Null,FormKey.Null)                            },
                    { "Sword",                      (new FormKey("Dragonborn.esm", 0x01cdb8),FormKey.Null) },
                    { "WarAxe",                     (new FormKey("Dragonborn.esm", 0x01cdb9),FormKey.Null) },
                    { "Warhammer",                  (new FormKey("Dragonborn.esm", 0x01cdba),FormKey.Null) },
                },

                ["Steel"] = new Dictionary<string, (FormKey WeaponA, FormKey WeaponB)>()
                {
                    { "Arrow",                      (new FormKey("Skyrim.esm", 0x01397f),FormKey.Null) },
                    { "BattleAxe",                  (new FormKey("Skyrim.esm", 0x013984),FormKey.Null) },
                    { "Bow",                        (new FormKey("Skyrim.esm", 0x013841),FormKey.Null) },
                    { "Dagger",                     (new FormKey("Skyrim.esm", 0x013986),FormKey.Null) },
                    { "GreatSword",                 (new FormKey("Skyrim.esm", 0x013987),FormKey.Null) },
                    { "Mace",                       (new FormKey("Skyrim.esm", 0x013988),FormKey.Null) },
                    { "Scimitar",                   (FormKey.Null,FormKey.Null)                        },
                    { "Sword",                      (new FormKey("Skyrim.esm", 0x013989),FormKey.Null) },
                    { "WarAxe",                     (new FormKey("Skyrim.esm", 0x013983),FormKey.Null) },
                    { "Warhammer",                  (new FormKey("Skyrim.esm", 0x01398a),FormKey.Null) },
                },
                ["Alikr"] = new Dictionary<string, (FormKey WeaponA, FormKey WeaponB)>()
                {
                    { "Arrow",                      (FormKey.Null,FormKey.Null)                        },
                    { "BattleAxe",                  (FormKey.Null,FormKey.Null)                        },
                    { "Bow",                        (FormKey.Null,FormKey.Null)                        },
                    { "Dagger",                     (FormKey.Null,FormKey.Null)                        },
                    { "GreatSword",                 (FormKey.Null,FormKey.Null)                        },
                    { "Mace",                       (FormKey.Null,FormKey.Null)                        },
                    { "Scimitar",                   (new FormKey("Skyrim.esm", 0x07A91A),FormKey.Null)                        },
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
