namespace Statistics
{
    public class LEDAlert : IAlerter
    {
        public bool ledGlows;

        public void Alert()
        {
            ledGlows = true;
        }
    }
}