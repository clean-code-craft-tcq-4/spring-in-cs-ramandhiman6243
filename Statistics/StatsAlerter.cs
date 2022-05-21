namespace Statistics
{
    public class StatsAlerter
    {
        private float maxThreshold;
        private IAlerter[] alerters;

        public StatsAlerter(float maxThreshold, IAlerter[] alerters)
        {
            this.maxThreshold = maxThreshold;
            this.alerters = alerters;
        }

        public void checkAndAlert(System.Collections.Generic.List<double> stats)
        {
            StatsComputer statsComputer = new StatsComputer();
            statsComputer.CalculateStatistics(stats);

            if (statsComputer.max > maxThreshold)
            {
                for (int i = 0; i < alerters.Length; i++)
                {
                    alerters[i].Alert();
                }
            }
        }
    }
}