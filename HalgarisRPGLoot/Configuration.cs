namespace HalgarisRPGLoot
{
    public class GlobalConfiguration
    {
        public Configuration WeaponConfiguration { get; set; }
        public Configuration ArmorConfiguration { get; set; }
    }
    
    public class Configuration
    {
        public Rarity[] Rarities { get; set; }
        public int MinimalIconicLevel { get; set; }
        public int IconicEnchantments { get; set; }
    }

    public class Rarity
    {
        public string Name { get; set; }
        public int NumberToGenerate { get; set; }
        public int Enchantments { get; set; }
    }
}