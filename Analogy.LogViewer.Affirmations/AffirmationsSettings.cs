namespace Analogy.LogViewer.Affirmations
{
    public class AffirmationsSettings
    {
        public int CheckInterval { get; set; }
        public string Address { get; set; }

        public AffirmationsSettings()
        {
            CheckInterval = 1000;
            Address = "https://www.affirmations.dev/";
        }
    }
}
