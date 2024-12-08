using Api.Abstractions;
using Api.Model;

namespace Api.implamentations
{
    public class TestService : ITestService
    {
        private readonly Test[] tests = new[]
        {
            new Test(1,"What is the test number?","1"),
            new Test(2,"What is the test number?","2"),
            new Test(3,"What is the test number?","3"),
            new Test(4,"What is the test number?","4"),
            new Test(5,"What is the test number?","5"),
        };

        public string WriteAnwser(int id,string anwser, string[] answersUser)
        {
            if (anwser == tests[id-1].Anwser)
            {
                answersUser[id-1] = "true"; 
                return "OK";
            }
            else
            {
                answersUser[id-1] = "false";
                return "false";
            }
        }

        public string PrintTest(int id)
        {
            return tests[id-1].Descriptions;
        }

        public string[] PrintAwners(string[] answersUser)
        {
            return answersUser;
        }

        public string[] ResetAwners(string[] answersUser)
        {
            for (int i = 0; i < 5; i++)
                answersUser[i] = "false";
            return answersUser;
        }
    }
}
