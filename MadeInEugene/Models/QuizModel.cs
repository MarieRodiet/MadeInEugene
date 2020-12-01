using System;
namespace MadeInEugene.Models
{
    public class QuizModel
    {
        public string congratulation { get;  set; }

        public string UserAnswer1 { get; set; }
        public string CorrectOrNot1 { get; set; }

        public string UserAnswer2 { get; set; }
        public string CorrectOrNot2 { get; set; }

        public string UserAnswer3 { get; set; }
        public string CorrectOrNot3 { get; set; }

        public string UserAnswer4 { get; set; }
        public string CorrectOrNot4 { get; set; }

        public string UserAnswer5 { get; set; }
        public string CorrectOrNot5 { get; set; }

        public string UserAnswer6 { get; set; }
        public string CorrectOrNot6 { get; set; }

        public string UserAnswer7 { get; set; }
        public string CorrectOrNot7 { get; set; }

        public string UserAnswer8 { get; set; }
        public string CorrectOrNot8 { get; set; }

        public string UserAnswer9 { get; set; }
        public string CorrectOrNot9 { get; set; }

        public string UserAnswer10 { get; set; }
        public string CorrectOrNot10 { get; set; }

        public void CheckAnswers()
        {

            CorrectOrNot1 = UserAnswer1 == "by hand" ? "Right" : "Wrong. Hand washing dishes can use up to 50 percent more water than a water-saving, energy-efficient dishwasher. However, dishwashers made before 1994 use more water than current models. Look for units with the Energy Star rating.";
            CorrectOrNot2 = UserAnswer2 == "neither" ? "Right" : "Wrong. Manufacturing and disposing of both paper and plastic bags harms the environment. Bring your own reusable bags instead";
            CorrectOrNot3 = UserAnswer3 == "false" ? "Right" : "Wrong. Many appliances continue to use energy for features like clocks and remote control sensors even when they’re turned off. According to the Department of Energy, the electricity consumed by televisions that are turned off but still plugged in costs U.S. households more than $750 million a year";
            CorrectOrNot4 = UserAnswer4 == "false" ? "Right" : "Wrong. Hybrid cars perform on par with or better than conventional cars in drivability and safety testing.";
            CorrectOrNot5 = UserAnswer5 == "10" ? "Right" : "Wrong. Only about 10 percent of global energy comes from renewables. The remaining 92 percent comes from non-renewable sources like oil, coal and natural gas.";
            CorrectOrNot6 = UserAnswer6 == "30" ? "Right" : "Wrong. According to the U.S. Environment Protection Agency, CFLs use 2/3 less energy than standard incandescent bulbs and last up to 10 times longer. Replacing a 60-watt incandescent with a 13-watt CFL will save about $30 in energy costs over the life of a bulb.";
            CorrectOrNot7 = UserAnswer7 == "false" ? "Right" : "Wrong. It is always better to turn lights off when not in use. And there is no additional energy requirement for starting a CFL bulb.";
            CorrectOrNot8 = UserAnswer8 == "false" ? "Right" : "Wrong. The EPA estimates you save about 15 percent on fuel by driving 55 miles rather than 65 miles per hour. Properly inflated tires and a well-tuned engine also improve fuel economy.";
            CorrectOrNot9 = UserAnswer9 == "5" ? "Right" : "Wrong. Each degree you drop the thermostat during winter saves about 5 percent on your heating bill. For air conditioning, set the thermostat to 78 degrees Fahrenheit or higher.";
            CorrectOrNot10 = UserAnswer10 == "all" ? "Right" : "Wrong. All of these materials can produce paper. Hemp, the more humane and clean option, requires less land acreage to grow than timber, has fewer chemical byproducts, and can be recycled more frequently than tree timber.";


            if (CorrectOrNot1 == "Right" && CorrectOrNot2 == "Right" && CorrectOrNot3 == "Right" && CorrectOrNot4 == "Right" && CorrectOrNot5 == "Right" && CorrectOrNot6 == "Right" && CorrectOrNot7 == "Right" && CorrectOrNot8 == "Right" && CorrectOrNot9 == "Right" && CorrectOrNot10 == "Right")
            {
                congratulation = "Congratulations!";
            }
        }
    }
}
