namespace PlayerManager2
{
    class Player
    {
        public Player(string name, int score)
        {
            this.Name = name;
            this.Score = score;
        }
        public string Name { get; private set; }
        public int Score { get; private set; }
    }
}