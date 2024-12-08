using Api.Model;

namespace Api.Abstractions
{
    public interface ITestService
    {
        public string PrintTest(int id);
        public string WriteAnwser(int id, string anwser, string[] answersUser);
        public string[] PrintAwners(string[] answersUser);
        public string[] ResetAwners(string[] answersUser);
    }
}
