using System.Diagnostics;

namespace ChallengeApp
{
    public class Employee
    {
        private List<float> Grades = new List<float>();
        public Employee(string Name, string Surname)
        {
            this.Name = Name;
            this.Surname = Surname;
        }
        public string Name { get; private set; }
        public string Surname { get; private set; }
        public void AddGrade(float grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                this.Grades.Add(grade);
            }
            else
            {
                Console.WriteLine("Invalid Grade Value. Try again.");
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
                Console.WriteLine("This is not a float value. Try again.");
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
            var index = 0;

            do
            {
                statistics.Max = Math.Max(statistics.Max, this.Grades[index]);
                statistics.Min = Math.Min(statistics.Min, this.Grades[index]);
                statistics.Avr += this.Grades[index];
                index++;
            }
            while (index < this.Grades.Count);

            return statistics;

        }

        public Statistics GetStatisticsForEach()
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
            return statistics;
        }

        public Statistics GetStatisticsFor()
        {
            var statistics = new Statistics();
            statistics.Avr = 0;
            statistics.Min = float.MaxValue;
            statistics.Max = float.MinValue;

            for (var index = 0; index < this.Grades.Count; index++)
            {
                statistics.Max = Math.Max(statistics.Max, Grades[index]);
                statistics.Min = Math.Min(statistics.Min, Grades[index]);
                statistics.Avr += Grades[index];
            }
            statistics.Avr /= this.Grades.Count;
            return statistics;
        }

        public Statistics GetStatisticsDoWhile()
        {
            var statistics = new Statistics();
            statistics.Avr = 0;
            statistics.Min = float.MaxValue;
            statistics.Max = float.MinValue;
            var index = 0;

            do
            {
                statistics.Max = Math.Max(statistics.Max, this.Grades[index]);
                statistics.Min = Math.Min(statistics.Min, this.Grades[index]);
                statistics.Avr += this.Grades[index];
                index++;
            }
            while (index < this.Grades.Count);

            statistics.Avr /= this.Grades.Count;
            return statistics;
        }

        public Statistics GetStatisticsWhile()
        {
            var statistics = new Statistics();
            statistics.Avr = 0;
            statistics.Min = float.MaxValue;
            statistics.Max = float.MinValue;
            var index = 0;

            while (index < Grades.Count)
            {
                statistics.Max = Math.Max(statistics.Max, this.Grades[index]);
                statistics.Min = Math.Min(statistics.Min, this.Grades[index]);
                statistics.Avr += this.Grades[index];
                index++;
            }
            statistics.Avr /= this.Grades.Count;
            return statistics;
        }

    }
}