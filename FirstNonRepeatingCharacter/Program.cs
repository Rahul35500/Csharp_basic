using System;
using System.Collections.Generic;
// Given a string, find its first non-repeating character
namespace FirstNonRepeatingCharacter
{
    class Program
    {
         static public int FirstIndexedValue = int.MaxValue;
        static public Dictionary<char, CountInfo> DictionaryInformation = new Dictionary<char, CountInfo>();
         static public void FirstNonRepeating(string StringName)
        {
            GetCharacterFromDictionary(StringName);
            for (int i = 0; i < StringName.Length; i++)
            {
                if (DictionaryInformation[StringName[i]].Count == 1 && FirstIndexedValue > DictionaryInformation[StringName[i]].indexed)
                {
                    FirstIndexedValue = DictionaryInformation[StringName[i]].indexed;
                }
            }

            Display(StringName,FirstIndexedValue);
        }
        static public void GetCharacterFromDictionary(string StringName)
        {
            for (int i = 0; i < StringName.Length; i++)
            {

                if (DictionaryInformation.ContainsKey(StringName[i]))
                {
                    DictionaryInformation[StringName[i]].updateCount();
                }
                else
                {
                    DictionaryInformation[StringName[i]] = new CountInfo(i);
                }
            }

        }
       
        static public void Display(string StringName, int IndexedValue)
        {
            if (int.MaxValue == IndexedValue)
            {
                System.Console.WriteLine("All chararcter are repeating");
            }
            else
            {
                System.Console.WriteLine($"First non repeating character :{StringName[IndexedValue]}");
            }
        }

        static void Main(string[] args)
        {
            System.Console.WriteLine("Enter the string name");
            string StringName = Console.ReadLine();
            FirstNonRepeating(StringName);


            
        }
    }
}
