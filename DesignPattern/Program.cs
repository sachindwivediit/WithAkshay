namespace DesignPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var result = Singleton.GetInstance();

            //Console.WriteLine(result.GetType());


            Thread thread1 = new Thread(() => TestSingleton());
            Thread thread2 = new Thread(() => TestSingleton());

            thread1.Start();
            thread2.Start();

            thread1.Join();
            thread2.Join();
        }

        private static void TestSingleton()
        {
            var result = Singleton.GetInstance();
            Console.WriteLine(result.GetHashCode());
        }
    }


    //1st class should be sealed so that we can stop further level of inheritance
    //2nd declare static field which is having return type of Singleton or class type 
    //3rd defien constructor as private so that object cannot be created 
    //4th define the method which will retrun return type of Singleton or class type 
    public sealed class Singleton
    {
        private static Singleton instance = null;
        private static readonly object padlock = new object();

        private Singleton()
        {

        }

        public static Singleton GetInstance()
        {
            lock (padlock) //t1 t2 t3 
            {
                if (instance == null)
                {
                    instance = new Singleton();
                }
            }
            return instance;
        }
    }
}
