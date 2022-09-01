namespace MinimumAmoutofTime
{
    class Program
    {
        public static void Main()
        {
            string[] garbage = { "G", "P", "GP", "GG" };
            int[] travelBetwinHouse = { 2, 4, 3 };
            Console.WriteLine("Minimum Time is: {0}", GarbageCollection(garbage, travelBetwinHouse));

            garbage = new string[]{"MMM", "PGM", "GP" };
            travelBetwinHouse = new int[]{3,10 };
            Console.WriteLine("Minimum Time is: {0}", GarbageCollection(garbage, travelBetwinHouse));


        }



        
        static int GarbageCollection(string[] garbage, int[] travel)
        {
            int count = 0;
            char[] typeGarbage = { 'M','G', 'P' };
            for(int i = 0; i < typeGarbage.Length; i++)       
            {
                int laststop = 0;                             
                for (int j = 0; j < garbage.Length; j++)      
                {
                    
                    if (garbage[j].Contains(typeGarbage[i]))
                    {
                        
                        for (int k = 0; k < garbage[j].Length; k++)        // в мусорном баке может быть несколько едениц одного типа мусора
                        {
                            if (garbage[j][k] == typeGarbage[i])
                            {
                                count++;
                            }
                        }


                        for (; laststop < j; laststop++)                  // суммирование маршрута от последнего сбора мусора
                        {
                            count+=travel[laststop];
                        }
                        laststop = j;                                     // обновление последней остановки garbage[j].Contains(typeGarbage[i])


                    }
                }
            }
            return count;
        }
        
    }
}

//[2,4,3]

//The glass garbage truck:
//1.Collects the glass garbage at house 0      1
//2. Travels from house 0 to house 1           1+2
//3. Travels from house 1 to house 2           3+4
//4. Collects the glass garbage at house 2     7+1
//5. Travels from house 2 to house 3           8+3
//6. Collects the glass garbage at house 3     11+2
//Altogether, it takes 13 minutes to pick up all the glass garbage.
//Since there is no metal garbage, we do not need to consider the metal garbage truck.
//Therefore, it takes a total of 8 + 13 = 21 minutes to collect all the garbage.