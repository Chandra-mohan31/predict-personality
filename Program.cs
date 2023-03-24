namespace Task_24_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Personality trait application!");
            //personality trait application

            //general information
            Console.WriteLine("Enter your Name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter the date you are born: ");

            string date = Console.ReadLine();
            Console.WriteLine("Enter your month you were born : ");

            string month = Console.ReadLine();
            Console.WriteLine("Enter the year you were born: ");

            string year = Console.ReadLine();   

            string Dob = date + "/" + month +"/" + year;

            //Be a mentalist

            Console.WriteLine("Are you an Introvert: yes//no\n");
            string isIntrovert = Console.ReadLine();
            Console.WriteLine("Are you a happy inside: yes//no\n");
            string isHappyInside = Console.ReadLine();
            Console.WriteLine("Rate yourself on the basis of peacefulness: 1-10\n");
            int peacefullnes = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Rate yourself on the basis of using social media: 1-10\n");
            int useOfSocialMedia = Convert.ToInt32(Console.ReadLine());


            if (isIntrovert == "yes" && isHappyInside == "yes")
            {
                Console.WriteLine("You are a happy person with genuine feelings!");
            }
            else if (isIntrovert == "yes" && isHappyInside == "no")
            {
                Console.WriteLine("You are Broken,dont worry things will get right!");
            }
            else if(isHappyInside == "yes" && peacefullnes > 5)
            {
                Console.WriteLine("You are a peacefull and will always be happy!");
            }else if(useOfSocialMedia >= 6)
            {
                Console.WriteLine("Do you honestly get value of it: yes//no\n");
                string resp = Console.ReadLine();
                if(resp == "yes" && peacefullnes > 5)
                {
                    Console.WriteLine("You are modern and with good self control!");
                }
            }

            //Mimic Ptolemy

            Console.WriteLine("Lets find your Partner:\n");
            



            //calendar man
            Console.WriteLine(CalculateAge(Convert.ToDateTime(Dob)));
            
        }
        static string CalculateAge(DateTime Dob)
        {
            DateTime Now = DateTime.Now;
            int Years = new DateTime(DateTime.Now.Subtract(Dob).Ticks).Year - 1;
            DateTime PastYearDate = Dob.AddYears(Years);
            int Months = 0;
            for (int i = 1; i <= 12; i++)
            {
                if (PastYearDate.AddMonths(i) == Now)
                {
                    Months = i;
                    break;
                }
                else if (PastYearDate.AddMonths(i) >= Now)
                {
                    Months = i - 1;
                    break;
                }
            }
            //int Days = Now.Subtract(PastYearDate.AddMonths(Months)).Days;
            
            return $"Your current Age is : {Convert.ToString(Years)} years {Convert.ToString(Months)} months";
        }
    }
}