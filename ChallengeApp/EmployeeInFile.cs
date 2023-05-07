using static ChallengeApp.EmployeeInMemory;

namespace ChallengeApp
{
    public class EmployeeInFile : EmployeeBase
    {
        public event GrageAddedDelagate GradeAdded;

        private const string fileName = "grades.txt";

        public EmployeeInFile(string name, string surname)
            : base(name,surname)
        {
        }

        public override void AddGrade(double grade)
        {
            using (var writer = File.AppendText(fileName))
            {
                writer.WriteLine(grade);
            }
        }

        public override void AddGrade(short grade)
        {
            using (var writer = File.AppendText(fileName))
            {
                writer.WriteLine(grade);
            }
        }

        public override void AddGrade(byte grade)
        {
            using (var writer = File.AppendText(fileName))
            {
                writer.WriteLine(grade);
            }
        }

        public override void AddGrade(float grade)
        {
            using (var writer = File.AppendText(fileName)) 
            {

                if (grade >= 0 && grade <= 100)
                {
                    writer.WriteLine(grade);
                    if (GradeAdded != null)
                    {
                        GradeAdded(this, new EventArgs());
                    }
                }
                else
                {
                    throw new Exception("Invalid grade value.");
                }
            }
        }

        public override void AddGrade(int grade)
        {
            using (var writer = File.AppendText(fileName))
            {
                writer.WriteLine(grade);
            }
        }

        public override void AddGrade(char grade)
        {
            using (var writer = File.AppendText(fileName))
            {
                writer.WriteLine(grade);
            }
        }

        public override void AddGrade(long grade)
        {
            using (var writer = File.AppendText(fileName))
            {
                writer.WriteLine(grade);
            }
        }

        public override void AddGrade(string grade)
        {
            using (var writer = File.AppendText(fileName))
            {
                writer.WriteLine(grade);
            }
        }

        public override Statistics GetStatistics()
        {
            var gradesFromFile = ReadGradesFromFile();
            var result = this.CountStatstic(gradesFromFile);
            return result;
        }

        private List<float> ReadGradesFromFile()
        {
            var grades = new List<float>();
            if (File.Exists($"{fileName}"))
            {
                using (var reader = File.OpenText($"{fileName}"))
                {
                    var line = reader.ReadLine();
                    while (line != null)
                    {
                        var number = float.Parse(line);
                        grades.Add(number);
                        line = reader.ReadLine();
                    }
                }
            }
            return grades;
        }

        private Statistics CountStatstic(List<float> grades)
        {
            var statistics = new Statistics();
            statistics.Avr = 0;
            statistics.Min = float.MaxValue;
            statistics.Max = float.MinValue;

            foreach (var grade in grades)
            {
                statistics.Max = Math.Max(statistics.Max, grade);
                statistics.Min = Math.Min(statistics.Min, grade);
                statistics.Avr += grade;
            }
            statistics.Avr /= grades.Count;

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
