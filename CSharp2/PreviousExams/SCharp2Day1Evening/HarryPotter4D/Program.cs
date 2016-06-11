using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarryPotter4D
{
    class Program
    {
        static byte[, , ,] hypercube;
        static List<basilisk> basils = new List<basilisk>();
        static basilisk harry;
        static int harryMovesCount = 0;

        static void Main(string[] args)
        {
            init();
            int basilsCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < basilsCount; i++)
            {
                AddBasil();
            }


            string command = Console.ReadLine();
            while (command != "END")
            {
                string[] splited = command.Split(' ');
                string subject = splited[0];
                string dimention = splited[1];
                int movement = int.Parse(splited[2]);

                if (subject == "@")
                {
                    MoveHarry(command);
                    if (hypercube[harry.x, harry.y, harry.z, harry.b] > 0)
                    {
                        char killer = GetKiller();
                        Console.WriteLine(" {0}: \"Step {1} was the worst you ever made.\"", killer, harryMovesCount);
                        Console.WriteLine(" {0}: \"You will regret until the rest of your life... All 3 seconds of it!\"", killer, harryMovesCount);
                        return;
                    }
                }
                else
                {
                    //bassilMoves
                    basilisk currentBasil = MoveBasil(command);
                    //Check new coordinates for harry
                    if (CheckForHarry(currentBasil.x, currentBasil.y, currentBasil.z, currentBasil.b))
                    {
                        Console.WriteLine(" {0}: \"You thought you could escape, didn't you?\" - {1}", subject, harryMovesCount);
                        return;
                    }
                }
                command = Console.ReadLine();
            }
            Console.WriteLine(" @: \"I am the chosen one!\" - {0}", harryMovesCount);
        }

        public static void init()
        {
            int[] dimentions = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            hypercube = new byte[dimentions[0], dimentions[1], dimentions[2], dimentions[3]];


            dimentions = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            harry = new basilisk("@", dimentions[0], dimentions[1], dimentions[2], dimentions[3], basils.Count);
            //basils.Add(harry);
            //hypercube[dimentions[0], dimentions[1], dimentions[2], dimentions[3]] += 1;
        }
        public static void AddBasil()
        {
            string[] dimentions = Console.ReadLine().Split(' ').ToArray();

            basils.Add(new basilisk(dimentions[0],
                int.Parse(dimentions[1]),
                int.Parse(dimentions[2]),
                int.Parse(dimentions[3]),
                int.Parse(dimentions[4]),
                basils.Count));
            hypercube[int.Parse(dimentions[1]), int.Parse(dimentions[2]), int.Parse(dimentions[3]), int.Parse(dimentions[4])] += 1;


        }
        public static void MoveHarry(string command)
        {
            string[] splited = command.Split(' ');
            string subject = splited[0];
            string dimention = splited[1];
            int movement = int.Parse(splited[2]);

            //HARRY MOVES
            harryMovesCount++;
            //hypercube[harry.x, harry.y, harry.z, harry.y] -= 1;

            if (dimention == "A")
            {
                if (harry.x + movement >= hypercube.GetLength(0)
                    || harry.x + movement < 0)
                {
                    if (harry.x + movement >= hypercube.GetLength(0))
                    {
                        harry.x = hypercube.GetLength(0) - 1;
                    }
                    else
                    {
                        harry.x = 0;
                    }
                }
                else
                {
                    harry.x += movement;
                }
            }
            else if (dimention == "B")
            {
                if (harry.y + movement >= hypercube.GetLength(1)
                    || harry.y + movement < 0)
                {
                    if (harry.y + movement >= hypercube.GetLength(1))
                    {
                        harry.y = hypercube.GetLength(1) - 1;
                    }
                    else
                    {
                        harry.y = 0;
                    }
                }
                else
                {
                    harry.y += movement;
                }
            }
            else if (dimention == "C")
            {
                if (harry.z + movement >= hypercube.GetLength(2)
                    || harry.z + movement < 0)
                {
                    if (harry.z + movement >= hypercube.GetLength(2))
                    {
                        harry.z = hypercube.GetLength(2) - 1;
                    }
                    else
                    {
                        harry.z = 0;
                    }
                }
                else
                {
                    harry.z += movement;
                }
            }
            else
            {
                if (harry.b + movement >= hypercube.GetLength(3)
                    || harry.b + movement < 0)
                {
                    if (harry.b + movement >= hypercube.GetLength(3))
                    {
                        harry.b = hypercube.GetLength(3) - 1;
                    }
                    else
                    {
                        harry.b = 0;
                    }
                }
                else
                {
                    harry.b += movement;
                }
            }
            //hypercube[harry.x, harry.y, harry.z, harry.y] += 1;
        }
        public static basilisk MoveBasil(string command)
        {
            string[] splited = command.Split(' ');
            string subject = splited[0];
            string dimention = splited[1];
            int movement = int.Parse(splited[2]);

            int baslIndex = GetBasilIndex(subject);
            basilisk currentBasil = basils[baslIndex];

            hypercube[currentBasil.x, currentBasil.y, currentBasil.z, currentBasil.b] -= 1;

            if (dimention == "A")
            {
                if (currentBasil.x + movement >= hypercube.GetLength(0)
                    || currentBasil.x + movement < 0)
                {
                    if (currentBasil.x + movement >= hypercube.GetLength(0))
                    {
                        currentBasil.x = hypercube.GetLength(0) - 1;
                    }
                    else
                    {
                        currentBasil.x = 0;
                    }
                }
                else
                {
                    currentBasil.x += movement;
                }
            }
            else if (dimention == "B")
            {
                if (currentBasil.y + movement >= hypercube.GetLength(1)
                    || currentBasil.y + movement < 0)
                {
                    if (currentBasil.y + movement >= hypercube.GetLength(1))
                    {
                        currentBasil.y = hypercube.GetLength(1) - 1;
                    }
                    else
                    {
                        currentBasil.y = 0;
                    }
                }
                else
                {
                    currentBasil.y += movement;
                }
            }
            else if (dimention == "C")
            {
                if (currentBasil.z + movement >= hypercube.GetLength(2)
                    || currentBasil.z + movement < 0)
                {
                    if (currentBasil.z + movement >= hypercube.GetLength(2))
                    {
                        currentBasil.z = hypercube.GetLength(2) - 1;
                    }
                    else
                    {
                        currentBasil.z = 0;
                    }
                }
                else
                {
                    currentBasil.z += movement;
                }
            }
            else
            {
                if (currentBasil.b + movement >= hypercube.GetLength(3)
                    || currentBasil.b + movement < 0)
                {
                    if (currentBasil.b + movement >= hypercube.GetLength(3))
                    {
                        currentBasil.b = hypercube.GetLength(3) - 1;
                    }
                    else
                    {
                        currentBasil.b = 0;
                    }
                }
                else
                {
                    currentBasil.b += movement;
                }
            }

            hypercube[currentBasil.x, currentBasil.y, currentBasil.z, currentBasil.b] += 1;
            basils[baslIndex].x = currentBasil.x;
            basils[baslIndex].y = currentBasil.y;
            basils[baslIndex].z = currentBasil.z;
            basils[baslIndex].b = currentBasil.b;

            return currentBasil;
        }
        public static char GetKiller()
        {
            char kille = '-';

            List<basilisk> theOnes = basils.Where(x => x.x == harry.x
                && x.y == harry.y
                && x.z == harry.z
                && x.b == harry.b).OrderBy(x => x.name).ToList();

            if (theOnes.Count > 0)
            {
                kille = theOnes[0].name.ToCharArray()[0];
            }

            return kille;
        }
        public static int GetBasilIndex(string name)
        {
            int index = -1;

            index = basils.Where(x => x.name == name).ToArray()[0].index;

            return index;
        }
        public static bool CheckForHarry(int x, int y, int z, int b)
        {
            if (harry.x == x &&
                harry.y == y &&
                harry.z == z &&
                harry.b == b)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }


    public class basilisk
    {

        public int x;
        public int y;
        public int z;
        public int b;
        public int index;
        public string name;

        public basilisk(string name, int x, int y, int z, int b, int index)
        {
            this.name = name;
            this.x = x;
            this.y = y;
            this.z = z;
            this.b = b;
            this.index = index;
        }
    }
}