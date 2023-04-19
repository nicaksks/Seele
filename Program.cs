using SeeleAPI.Core.HonkaiAPI;

namespace Seele
{
    class Program
    {
        public static async Task<int> Main(string[] args)
        {
             //Honkai ID || HoYoLAB ID || Cookie Token || lToken || DS;
            var account = await HonkaiAPI.Request("", "", "", "", "");
            var info = account.role;
            var stats = account.stats;
            var preference = account.preference;

            //Example
            Console.WriteLine("< ACCOUNT >");
            Console.WriteLine($"Nickname {info?.nickname} - Account Level {info?.level} | Region: {info?.region?.ToUpper()} \n");
            Console.WriteLine($"Days on Hyperion {stats?.active_day_number} \nAchievements: {stats?.achievement_number}\n");
            Console.WriteLine($"< COLLECTION > \n\nValkyrie(s) Owned: {stats?.armor_number} \nValkyries (SSS) {stats?.sss_armor_number} \nStigamata(s) Owned: {stats?.stigmata_number} \nOutfits: {stats?.suit_number} \nWeapon Owned: {stats?.weapon_number} \n");
            Console.WriteLine($"< ABYSS > \n\nAbyss: {preference?.abyss} \nAbyss Floor: {stats?.abyss_floor} \nAbyss Score: {stats?.abyss_score}");

            Console.Write("\nClick any key to close the terminal.");
            Console.ReadKey();
            Environment.Exit(0);

            return 0;
        }
    }
}

