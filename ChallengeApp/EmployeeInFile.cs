namespace ChallengeApp
{
    public class EmployeeInFile : EmployeeBase
    {
        public override event GrageAddedDelagate GradeAdded;

        private const string fileName = "grades.txt";

        public EmployeeInFile(string name, string surname)
            : base(name,surname)
        {
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

        public override void AddGrade(double grade)
        {
            float floatGrade = (float)grade;
            this.AddGrade(floatGrade);
        }

        public override void AddGrade(short grade)
        {
            float floatGrade = (float)grade;
            this.AddGrade(floatGrade);
        }

        public override void AddGrade(byte grade)
        {
            float floatGrade = (float)grade;
            this.AddGrade(floatGrade);
        }

        public override void AddGrade(int grade)
        {
            float floatGrade = grade;
            this.AddGrade(floatGrade);
        }

        public override void AddGrade(char grade)
        {
            grade = Char.ToUpper(grade);
            switch (grade)
            {
                case 'A':
                    this.AddGrade(100);
                    break;
                case 'B':
                    this.AddGrade(80);
                    break;
                case 'C':
                    this.AddGrade(60);
                    break;
                case 'D':
                    this.AddGrade(40);
                    break;
                case 'E':
                    this.AddGrade(20);
                    break;
                default:
                    throw new Exception("Wrong letter");
            }
        }

        public override void AddGrade(long grade)
        {
            float floatGrade = (float)grade;
            this.AddGrade(floatGrade);
        }

        public override void AddGrade(string grade)
        {
            if (float.TryParse(grade, out float result))
            {
                this.AddGrade(result);
            }
            else
            {
                if (grade.Length > 1)
                {
                    throw new Exception("String is not float");
                }
                else
                {
                    this.AddGrade(grade[0]);
                }
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

            foreach (var grade in ReadGradesFromFile())
            {
                statistics.AddGrade(grade);
            }

            return statistics;
        }


    }
}
