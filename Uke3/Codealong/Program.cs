namespace Codealong
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var bil = new Car();
            //bil.Drive();

            var bil1 = new Race("1");
            var bil2 = new Race("2");

            Thread thread1 = new Thread(new ThreadStart(bil1.DriveRace));
            Thread thread2 = new Thread(new ThreadStart(bil2.DriveRace));

            thread1.Start();
            thread2.Start();
        }
    }
}
