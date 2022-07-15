class Program
{
    public const int IS_PART_TIME = 1;
    public const int Is_FULL_TIME = 2;

    public static int computeEmpWage(string company, int empRateperHour, int numofworkingDays, int maxHoursPerMonth)
    {
        int empHrs = 0, totalEmpHrs = 0, totalWorkingDays = 0;

        while (totalEmpHrs <= maxHoursPerMonth && totalWorkingDays < numofworkingDays)
        {
            totalWorkingDays++;
            Random random = new Random();
            int empCheck = random.Next(0, 3);
            switch (empCheck)
            {
                case IS_PART_TIME:
                    empHrs = 4;
                    break;

                case Is_FULL_TIME:
                    empHrs = 8;
                    break;

                default:
                    empHrs = 0;
                    break;
            }

            totalEmpHrs += empHrs;
            Console.WriteLine("Day# : " + totalWorkingDays + " Emp Hrs:" + empHrs);
        }
        int totalEmpwage = totalEmpHrs * empRateperHour;
        Console.WriteLine("Total Emp Wage for company : " + company + " is; " + totalEmpwage);
        return totalEmpwage;
    }
    static void Main(string[] args)
    {
        computeEmpWage("DMart", 20, 2, 10);
        computeEmpWage("Reliance", 10, 4, 20);
    }
}

    
