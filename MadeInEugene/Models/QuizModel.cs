using System;
namespace MadeInEugene.Models
{
    public class QuizModel
    {
        public string congratulation { get;  set; }

        public string Question1 { get; set; }
        public string Answer1 { get; set; }

        public string Question2 { get; set; }
        public string Answer2 { get; set; }

        public string Question3 { get; set; }
        public string Answer3 { get; set; }

        public string Question4 { get; set; }
        public string Answer4 { get; set; }

        public string Question5 { get; set; }
        public string Answer5 { get; set; }

        public string Question6 { get; set; }
        public string Answer6 { get; set; }

        public string Question7 { get; set; }
        public string Answer7 { get; set; }

        public string Question8 { get; set; }
        public string Answer8 { get; set; }

        public string Question9 { get; set; }
        public string Answer9 { get; set; }

        public string Question10 { get; set; }
        public string Answer10 { get; set; }

        public void CheckAnswers()
        {

            Answer1 = Question1 == "by hand" ? "Right" : "Wrong. Hand washing dishes can use up to 50 percent more water than a water-saving, energy-efficient dishwasher. However, dishwashers made before 1994 use more water than current models. Look for units with the Energy Star rating.";
            Answer2 = Question2 == "neither" ? "Right" : "Wrong. Manufacturing and disposing of both paper and plastic bags harms the environment. Bring your own reusable bags instead";
            Answer3 = Question3 == "false" ? "Right" : "Wrong. Many appliances continue to use energy for features like clocks and remote control sensors even when they’re turned off. According to the Department of Energy, the electricity consumed by televisions that are turned off but still plugged in costs U.S. households more than $750 million a year";
            Answer4 = Question4 == "false" ? "Right" : "Wrong. Hybrid cars perform on par with or better than conventional cars in drivability and safety testing.";
            Answer5 = Question5 == "10" ? "Right" : "Wrong. Only about 10 percent of global energy comes from renewables. The remaining 92 percent comes from non-renewable sources like oil, coal and natural gas.";
            Answer6 = Question6 == "30" ? "Right" : "Wrong. According to the U.S. Environment Protection Agency, CFLs use 2/3 less energy than standard incandescent bulbs and last up to 10 times longer. Replacing a 60-watt incandescent with a 13-watt CFL will save about $30 in energy costs over the life of a bulb.";
            Answer7 = Question7 == "false" ? "Right" : "Wrong. It is always better to turn lights off when not in use. And there is no additional energy requirement for starting a CFL bulb.";
            Answer8 = Question8 == "false" ? "Right" : "Wrong. The EPA estimates you save about 15 percent on fuel by driving 55 miles rather than 65 miles per hour. Properly inflated tires and a well-tuned engine also improve fuel economy.";
            Answer9 = Question9 == "5" ? "Right" : "Wrong. Each degree you drop the thermostat during winter saves about 5 percent on your heating bill. For air conditioning, set the thermostat to 78 degrees Fahrenheit or higher.";
            Answer10 = Question10 == "all" ? "Right" : "Wrong. All of these materials can produce paper. Hemp, the more humane and clean option, requires less land acreage to grow than timber, has fewer chemical byproducts, and can be recycled more frequently than tree timber.";


            if (Answer1 == "Right" && Answer2 == "Right" && Answer3 == "Right" && Answer4 == "Right" && Answer5 == "Right" && Answer6 == "Right" && Answer7 == "Right" && Answer8 == "Right" && Answer9 == "Right" && Answer10 == "Right")
            {
                congratulation = "Congratulations!";
            }
        }
    }
}
