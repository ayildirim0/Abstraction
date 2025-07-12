using System.Threading.Tasks;

namespace Abstraction
{
    public abstract class Worker
    {
        public string Name { get; set; }
        public string SurName { get; set; }
        public string Department { get; set; }
        public abstract void Duty();// Soyut görev metodu
    }
    public class Work : Worker 
    {
        public override void Duty()
        {
            Console.WriteLine("Lütfen yaptığınız işi giriniz...");
            string task = Console.ReadLine();

            Console.WriteLine($"{Name} {SurName} şirketin {Department} departmanında {task} olarak çalışıyorum");
        }
    }
}