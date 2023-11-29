namespace Codealong
{
    internal class Car
    {
        private int speed = 10;
        private int distance = 0;
        private int maxDistance = 1000;

        public void Drive()
        {
            while (distance < maxDistance)
            {
                if (distance < 500)
                {
                    distance += speed;
                    speed += 10;
                }
                else if (distance > 500)
                {
                    distance += speed;
                    speed -= 10;
                }
            }

            Console.WriteLine("Bilen har nådd målet");
        }
    }
}
