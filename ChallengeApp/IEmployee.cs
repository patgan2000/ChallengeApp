using static ChallengeApp.EmployeeBase;

namespace ChallengeApp
{
    public interface IEmployee
    {
        string Name { get; }

        string Surname { get; }

        void AddGrade(string grade);

        void AddGrade(double grade);

        void AddGrade(byte grade);

        void AddGrade(short grade);

        void AddGrade(float grade);

        void AddGrade(int grade);

        event GrageAddedDelagate GradeAdded;

        Statistics GetStatistics();
    }
}
