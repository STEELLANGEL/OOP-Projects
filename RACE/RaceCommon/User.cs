namespace RaceCommon
{
    public class User
    {
        public string Name { get; set; }
        public int Score { get; set; }
        public int Coin { get; set; }
        public string SaveTime { get; set; }

        public User()
        {
            Name = "неизвестно";
            Score = 0;
            Coin = 0;
            SaveTime = "время";
        }
    }
}
