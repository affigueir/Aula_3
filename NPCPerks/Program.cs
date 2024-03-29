﻿using System;

namespace NPCPerks
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("How many NPC's are there?");
            int npcNum = Int32.Parse(Console.ReadLine());
            NPCSkills [] mySkills = new NPCSkills[npcNum];
            
            for (int i = 0; i < npcNum; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    int x = Convert.ToInt32(Math.Pow(2, j));
                    NPCSkills currentSkill = (NPCSkills) x;

                    System.Console.WriteLine($"NPC {i + 1} | Answer with 'yes' or 'no'");
                    System.Console.WriteLine($"Does he have {currentSkill}");
                    string input = Console.ReadLine();

                    if (input == "yes")
                    {
                        mySkills[i] += x;
                    }

                    else
                    {
                        continue;
                    }
                }
                
                //System.Console.WriteLine($"NPC {i + 1} has {mySkills[i]}\n");
            }

            
                /* foreach (NPCSkills item in mySkills)
                {
                    int i = 1;
                    System.Console.WriteLine($"NPC {i} has {item}");
                    if (i < npcNum)
                        i++;
                    else
                        continue;
                } */

                for (int i = 0; i< mySkills.Length; i++)
                {
                    NPCSkills skills = mySkills[i];
                    if(skills == (NPCSkills)10)
                        System.Console.WriteLine($"NPC {i + 1} has {skills} and shall win all fights!");

                    else
                        System.Console.WriteLine($"NPC {i + 1} has {skills}");
                }
            

        }
    }
}
