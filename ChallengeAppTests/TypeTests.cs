namespace ChallengeAppTests
{
    public class TypeTests
    {
        [Test]
        public void IntAsValuableType()
        {
            int score1 = 10;
            int score2 = 10;

            Assert.AreEqual(score1, score2);
        }
        [Test]
        public void StringAsValuableType()
        {
            string name1 = "Anna";
            string name2 = "Anna";

            Assert.AreEqual(name1, name2);
        }
        [Test]
        public void VarAsReferenceType()
        {
            var em1 = GetEmployee("Anna");
            var em2 = GetEmployee("Anna");

            Assert.AreNotEqual(em1, em2);
        }
        private Employee GetEmployee(string name)
        {
            return new Employee(name);
        }
    }
}