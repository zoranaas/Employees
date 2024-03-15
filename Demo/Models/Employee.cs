namespace Demo.Models
{
    public class Employee
    { 
        private string employeeName;
        private double totalTimeWorked;
        private DateTime starTimeUtc;
        private DateTime endTimeUtc;
        private int percentageOfWork;
       

        public string EmployeeName
        {
            get { return employeeName; }
            set { employeeName = value; }
        }

        public double TotalTimeWorked
        {
            get { return Math.Round(totalTimeWorked, 1); }
            set { totalTimeWorked = value; }
        }

        public DateTime StarTimeUtc
        {
            get { return starTimeUtc; }
            set { starTimeUtc = value; }
        }

        public DateTime EndTimeUtc
        {
            get { return endTimeUtc; }
            set { endTimeUtc = value; }
        }

        public int PercentageOfWork
        {
            get { return percentageOfWork; }
            set { percentageOfWork = value; }   
        }
    }
}
