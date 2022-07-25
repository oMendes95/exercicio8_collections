using System;
using System.Collections.Generic;

namespace CList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World Lista!");

            List<string> animais = new List<string>();
            
            animais.Add("Urso");
            animais.Add("Leão");
            animais.Add("Tigre");
            animais.Add("Pantera");

            animais.Insert(1, "Hiena");

            animais.Remove("Pantera");

            animais.RemoveAt(1);

            foreach (string animais1 in animais)
            {

                Console.WriteLine(animais1);

            }

        }
    }
}
