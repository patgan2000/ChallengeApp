using System.Diagnostics;

namespace ChallengeApp
{
    public class Employee : Person
    {
        private List<float> Grades = new List<float>();

        public Employee()
        {
        }

        public Employee(string name)
           : base(name)
        {
        }

        public Employee(string name, string surname)
            : base(name, surname)
        {
        }

        public Employee(string name, string surname, char sex)
            : base (name, surname, sex)
        {
        }

        public Employee(string name, string surname, char sex, int age)
            : base (name,surname,sex,age)
        {
        }

        public void AddGrade(char grade)
        {
            switch (grade)
            {
                case 'A':
                case 'a':
                    AddGrade(6);
                    break;
                case 'B':
                case 'b':
                    AddGrade(5);
                    break;
                case 'C':
                case 'c':
                    AddGrade(4);
                    break;
                case 'D':
                case 'd':
                    AddGrade(3);
                    break;
                case 'E':
                case 'e':
                    AddGrade(2);
                    break;
                case 'F':
                case 'f':
                    AddGrade(1);
                    break;
                default:
                    throw new Exception("You entered a wrong character");
            }
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
            if (float.TryParse(grade, out float result))
            {
                this.AddGrade(result);
            }
            else
            {
                throw new Exception("This is not a float value. Try again.");
            }
        }
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


        public void AddGrade(short grade)
        {
            float gradeAsFloat = (float)grade;
            this.AddGrade(gradeAsFloat);
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