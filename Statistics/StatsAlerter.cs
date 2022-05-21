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

        public void checkAndAlert(System.Collections.Generic.List<float> s)
        {

        }
    }
}