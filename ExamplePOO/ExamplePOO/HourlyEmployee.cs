namespace ExamplePOO
{
    public class HourlyEmployee : Employee
    {

        public float Hours { get; set; }
        public decimal HoursValue { get; set; }

        public override decimal GetValueToPay()
        {

            return (decimal)Hours * HoursValue;


        }
        public override string ToString()
        {
            return $"{base.ToString()}" +
                $"\n\tHours: {$"{Hours:N2}",18} " +
                $"\n\tHours value...............: {$"{HoursValue:c2}",18} " +
                $"\n\tValue to pay..............: {$"{GetValueToPay():C2}",18}";
        }
    }
}
