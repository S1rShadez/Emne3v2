namespace Parprogrammering_Arthur
{
    internal class Parson
    {
        private string _navn;
        private int _age;
        private string _hair;
        private string _introduction;
        private string _hobby;

        public Parson(string navn, int age, string hair, string introduction, string hobby)
        {
            _navn = navn;
            _age = age;
            _hair = hair;
            _introduction = introduction;
            _hobby = hobby;
        }

        public void SkrivOmMeg()
        {
            Console.WriteLine($"Hei, jeg heter {_navn}! Jeg er {_age} år gammel og jeg har {_hair} hår");
            Console.WriteLine(_introduction);
            Console.WriteLine(_hobby + "\n");
        }
    }
}
