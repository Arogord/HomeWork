namespace HomeWork10_5
{
    public class Program
    {
        public static void Main()
        {
            //В методе main создать сотрудников и попробовать вызвать метод GetAccess

            void GetAccess(Employee employee, AccesLevelType accesLevelType)
            {
                Type type = employee.GetType();
                object[] attributes = type.GetCustomAttributes(true);
                foreach (Attribute attribute in attributes)
                {
                    
                    if((attribute is AccessLevelAttribute accesseAtribute) && ((int)accesseAtribute.accesLevelType >= (int)accesLevelType))
                    {
                        Console.WriteLine("Access is allowed");
                        return;
                    }
                }
                Console.WriteLine("Access not allowed");
            }


            Worker worker = new Worker();
            Console.WriteLine("Worker");
            GetAccess(worker, AccesLevelType.Low);
            GetAccess(worker, AccesLevelType.Medium);
            GetAccess(worker, AccesLevelType.High);
            Console.WriteLine();

            Manager manager = new Manager();
            Console.WriteLine("Manager");
            GetAccess(manager, AccesLevelType.Low);
            GetAccess(manager, AccesLevelType.Medium);
            GetAccess(manager, AccesLevelType.High);
            Console.WriteLine();

            Director director = new Director();
            Console.WriteLine("Director");
            GetAccess(director, AccesLevelType.Low);
            GetAccess(director, AccesLevelType.Medium);
            GetAccess(director, AccesLevelType.High);
            Console.WriteLine();




        }
    }
}