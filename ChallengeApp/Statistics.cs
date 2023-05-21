namespace ChallengeApp
{
    public class Statistics
    {
        public float Min { get; private set; }
        public float Max { get; private set; }

        public float Sum { get; private set; }

        public int Count { get; private set; }

        public float Avr 
        { 
            get 
            { 
                return this.Sum / this.Count;
            } 
        }
        public float AvrLetter 
        { 
            get 
            {
                switch (this.Avr)
                {
                    case var avr when avr >= 80:
                        return 'A';
                    case var avr when avr >= 60:
                        return 'B';
                    case var avr when avr >= 40:
                        return 'C';
                    case var avr when avr >= 20:
                        return 'D';
                    default:
                        return 'E';
                }
            } 
        
        }

        public Statistics()
        {
            this.Count = 0;
            this.Sum = 0;
            this.Max = float.MinValue;
            this.Min = float.MaxValue;

        }


        public void AddGrade(float grade)
        {
            this.Count++;
            this.Sum += grade;
            this.Min = Math.Min(grade, this.Min);
            this.Max = Math.Max(grade, this.Max);

        }
    }
}