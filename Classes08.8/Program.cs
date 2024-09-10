namespace Classes08._8
{
    class Pet
    {
        public virtual void Sound()
        {
            Console.WriteLine($"Тварина видає звук");
        }
    }

    class Dog : Pet
    {
        public override void Sound()
        {
            Console.WriteLine($"Собака гавкає");
        }
    }

    class Cat : Pet
    {
        public override void Sound()
        {
            Console.WriteLine($"Кіт нявчить");
        }
    }

    class Bird : Pet
    {
        public override void Sound()
        {
            Console.WriteLine($"Пташка співає");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Pet[] pet = new Pet[]
            {
                new Dog(),
                new Cat(), 
                new Bird()
            };

            foreach (Pet p in pet)
            {
                p.Sound();

            }
        }
    }
}
