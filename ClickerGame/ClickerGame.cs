

namespace ClickerGame
{
    internal class ClickerGame
    {
        public int points = 0;
        public int pointsPerClick = 1;
        public int pointsPerClickIncrease = 1;

        public void ClickForPoints()
        {
            points += pointsPerClick;
        }

        public void BuyUpgrade()
        {
            if (points < 10) return;
            points -= 10;
            pointsPerClick += pointsPerClickIncrease;
        }

        public void BuySuperUpgrade()
        {
            if (points < 100) return;
            points -= 100;
            pointsPerClickIncrease += 1;
        }
    }
}
