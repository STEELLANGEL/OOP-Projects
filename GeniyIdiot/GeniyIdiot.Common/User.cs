namespace GeniyIdiot.Common
{
    public class User
    {
        public string Name { get; set; }
        public int RightAnsweresCount { get; set; }
        public string Diagnos { get; set; }

        public User(string name)
        {
            Name = name;
            Diagnos = "Неизвестен";
        }

        public void RightAnseresAccept()
        {
            RightAnsweresCount++;
        }
    }
}
