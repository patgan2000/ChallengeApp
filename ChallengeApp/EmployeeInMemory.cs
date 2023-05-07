namespace ChallengeApp
{
    public class EmployeeInMemory : EmployeeBase
    {
        public event GrageAddedDelagate GradeAdded;

        private List<float> grades = new List<float>();

        public EmployeeInMemory(string name, string surname)
            : base(name, surname)
        {
        }

        public override void AddGrade(float grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                this.grades.Add(grade);
                if(GradeAdded != null)
                {
                    GradeAdded(this, new EventArgs());
                }
            }
            else
            {
                throw new Exception("Invalid grade value.");
            }
            
        }

        public override void AddGrade(double grade)
        {
            float gradeAsFloat = (float)grade;
            this.AddGrade(gradeAsFloat);
        }

        public override void AddGrade(byte grade)
        {
            float gradeAsFloat = (float)grade;
            this.AddGrade(gradeAsFloat);
        }

        public override void AddGrade(short grade)
        {
            float gradeAsFloat = (float)grade;
            this.AddGrade(gradeAsFloat);
        }

        public override void AddGrade(int grade)
        {
            float gradeAsFloat = (float)grade;
            this.AddGrade(gradeAsFloat);
        }

        public override void AddGrade(char grade)
        {
            float gradeAsFloat = (float)grade;
            this.AddGrade(gradeAsFloat);
        }

        public override void AddGrade(long grade)
        {
            float gradeAsFloat = (float)grade;
            this.AddGrade(gradeAsFloat);
        }

        public override void AddGrade(string grade)
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

        public override Statistics GetStatistics()
        {
            var statistics = new Statistics();
            statistics.Avr = 0;
            statistics.Min = float.MaxValue;
            statistics.Max = float.MinValue;

            foreach (var grade in this.grades)
            {
                statistics.Max = Math.Max(statistics.Max, grade);
                statistics.Min = Math.Min(statistics.Min, grade);
                statistics.Avr += grade;
            }
            statistics.Avr /= this.grades.Count;

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
