namespace Statistics
{
    public class EmailAlert : IAlerter
    {
        public bool emailSent;

        public void Alert()
        {
            emailSent = true;
        }
    }
}