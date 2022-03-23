using System;

namespace Event
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var some_event = new Event();

            some_event.OnKeyPressed += (Sender, Key) => Console.WriteLine(" You entered: " + Key);

            some_event.Run();
        }
    }

    public class Event
    {
        public event EventHandler<char> OnKeyPressed;

        public void Run()
        {
            while (true)
            {
                char key = Console.ReadKey().KeyChar;

                if (key == 'c') return;

                OnKeyPressed?.Invoke(this, key);
            }
        }
    }
}
