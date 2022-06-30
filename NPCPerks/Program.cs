using System;

namespace NPCPerks
{
    class Program
    {
        static void Main(string[] args)
        {
            NPCSkills mySkills = (NPCSkills) 0;
            
            Console.WriteLine("How many NPC's are there?");
            int npcNum = Int32.Parse(Console.ReadLine());
            
            for (int i = 0; i < npcNum; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    int x = Convert.ToInt32(Math.Pow(2, j));
                    NPCSkills currentSkill = (NPCSkills) x;

                    System.Console.WriteLine($"NPC {j} | Answer with 'yes' or 'no'");
                    System.Console.WriteLine($"Does he have {currentSkill}");
                    string input = Console.ReadLine();

                    if (input == "yes")
                    {
                        mySkills += x;
                    }

                    else
                    {
                        continue;
                    }
                }
                

            }

            System.Console.WriteLine(mySkills);
        }
    }
}
