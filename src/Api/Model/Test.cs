namespace Api.Model
{
    public class Test
    {
        public int Id { get; set; }
        public string Descriptions { get; set; }
        public string Anwser { get; set; }
        public Test(int id, string descriptions, string anwser)
        {
            Id = id;
            Descriptions = descriptions;
            Anwser = anwser;
        }

    }
}
