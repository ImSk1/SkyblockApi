using System;
using System.Net;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;


namespace Skyblock
{
    public class TalismansModel
    {
        public string profile_id { get; set; }
        public string cute_name { get; set; }
        public List<Talisman> talismans { get; set; }
    }
    public class Texture
    {
        public string Value { get; set; }
    }

    public class Properties
    {
        public List<Texture> textures { get; set; }
    }

    public class SkullOwner
    {
        public string Id { get; set; }
        public Properties Properties { get; set; }
    }

    public class Display
    {
        public List<string> Lore { get; set; }
        public string Name { get; set; }
    }

    public class ExtraAttributes
    {
        public string modifier { get; set; }
        public string originTag { get; set; }
        public string id { get; set; }
        public string uuid { get; set; }
        public string timestamp { get; set; }
        public string personal_compact_0 { get; set; }
        public string personal_compact_2 { get; set; }
        public string personal_compact_1 { get; set; }
        public string personal_compact_4 { get; set; }
        public string personal_compact_3 { get; set; }
        public string personal_compact_5 { get; set; }
        public List<int> new_year_cake_bag_data { get; set; }
        public int? blood_god_kills { get; set; }
    }

    public class Tag
    {
        public int HideFlags { get; set; }
        public SkullOwner SkullOwner { get; set; }
        public Display display { get; set; }
        public ExtraAttributes ExtraAttributes { get; set; }
        public List<object> ench { get; set; }
    }

    public class Extra
    {
        public int hpbs { get; set; }
        public int anvil_uses { get; set; }
        public object timestamp { get; set; }
        public string reforge { get; set; }
    }

    public class Stats
    {
        public int strength { get; set; }
        public int crit_chance { get; set; }
        public int crit_damage { get; set; }
        public int health { get; set; }
        public int speed { get; set; }
        public double intelligence { get; set; }
    }

    public class ContainsItem
    {
        public bool isInactive { get; set; }
        public bool inBackpack { get; set; }
        public int item_index { get; set; }
        public int backpackIndex { get; set; }
        public string itemId { get; set; }
    }

    public class Talisman
    {
        public bool isUnique { get; set; }
        public bool isInactive { get; set; }
        public int id { get; set; }
        public int Count { get; set; }
        public Tag tag { get; set; }
        public int Damage { get; set; }
        public Extra extra { get; set; }
        public string display_name { get; set; }
        public string display_name_print { get; set; }
        public string texture_path { get; set; }
        public string rarity { get; set; }
        public string type { get; set; }
        public string equipmentType { get; set; }
        public Stats stats { get; set; }
        public int item_index { get; set; }
        public string itemId { get; set; }
        public string base_name { get; set; }
        public string reforge { get; set; }
        public List<ContainsItem> containsItems { get; set; }
    }
}