namespace JobsRequirement
{
    public class Job
    {
        private string v1;
        private string v2;
        private string v3;
        private string v4;
        private int v5;
        private double v6;

        public Job(string v1, string v2, string v3, string v4, int v5, double v6)
        {
            this.v1 = v1;
            this.v2 = v2;
            this.v3 = v3;
            this.v4 = v4;
            this.v5 = v5;
            this.v6 = v6;
        }

        public double Salary { get; internal set; }
        public object Location { get; internal set; }
    }
}