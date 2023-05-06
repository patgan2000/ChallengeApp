namespace ChallengeApp
{
    internal class Supervisor
    {
        private List<float> Grades = new List<float>();

        public string Name => "Jan";

        public string Surname => "Kowalski";

        public void AddGrade(double grade)
        {
            float gradeAsFloat = (float)grade;
            this.AddGrade(gradeAsFloat);
        }
        public void AddGrade(byte grade)
        {
            float gradeAsFloat = (float)grade;
            this.AddGrade(gradeAsFloat);
        }

        public void AddGrade(int grade)
        {
            float gradeAsFloat = grade;
            this.AddGrade(gradeAsFloat);
        }

        public void AddGrade(short grade)
        {
            float gradeAsFloat = (float)grade;
            this.AddGrade(gradeAsFloat);
        }
        public void AddGrade(float grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                this.Grades.Add(grade);
            }
            else
            {
                throw new Exception("Invalid Grade Value. Try again.");
            }
        }

        public void AddGrade(string grade)
        {
            switch (grade)
            {
                case "6":
                    AddGrade(100);
                    break;
                case "6-":
                case "-6":
                    AddGrade(95);
                    break;
                case "5+":
                case "+5":
                    AddGrade(85);
                    break;
                case "5":
                    AddGrade(80);
                    break;
                case "5-":
                case "-5":
                    AddGrade(75);
                    break;
                case "4+":
                case "+4":
                    AddGrade(65);
                    break;
                case "4":
                    AddGrade(60);
                    break;
                case "4-":
                case "-4":
                    AddGrade(55);
                    break;
                case "3+":
                case "+3":
                    AddGrade(45);
                    break;
                case "3":
                    AddGrade(40);
                    break;
                case "3-":
                case "-3":
                    AddGrade(35);
                    break;
                case "2+":
                case "+2":
                    AddGrade(25);
                    break;
                case "2":
                    AddGrade(20);
                    break;
                case "2-":
                case "-2":
                    AddGrade(15);
                    break;
                case "1+":
                case "+1":
                    AddGrade(5);
                    break;
                case "1":
                    AddGrade(0);
                    break;
                default:
                    throw new Exception("You entered a wrong character");
            }
        }

        public Statistics GetStatistics()
        {
            var statistics = new Statistics();
            statistics.Avr = 0;
            statistics.Min = float.MaxValue;
            statistics.Max = float.MinValue;

            foreach (var grade in this.Grades)
            {
                statistics.Max = Math.Max(statistics.Max, grade);
                statistics.Min = Math.Min(statistics.Min, grade);
                statistics.Avr += grade;
            }
            statistics.Avr /= this.Grades.Count;

            switch (statistics.Avr)
            {
                case var avr when avr >= 15:
                    statistics.AvrLetter = 'A';
                    break;
                case var avr when avr >= 12:
                    statistics.AvrLetter = 'B';
                    break;
                case var avr when avr >= 10:
                    statistics.AvrLetter = 'C';
                    break;
                case var avr when avr >= 8:
                    statistics.AvrLetter = 'D';
                    break;
                case var avr when avr >= 6:
                    statistics.AvrLetter = 'E';
                    break;
                default:
                    statistics.AvrLetter = 'F';
                    break;
            }

            return statistics;
        }
    }
}
