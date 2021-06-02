// using System;

// public class Example
// {
//     public static void Main()
//     {
//         string[] dinosaurs = { "Compsognathus",
//             "Amargasaurus",   "Oviraptor",      "Velociraptor",
//             "Deinonychus",    "Dilophosaurus",  "Gallimimus",
//             "Triceratops" };

//         Console.WriteLine();
//         foreach (string dinosaur in dinosaurs)
//         {
//             Console.WriteLine(dinosaur);
//         }

//         Console.WriteLine(
//             "\nArray.FindIndex(dinosaurs, EndsWithSaurus): {0}",
//             Array.FindIndex(dinosaurs, EndsWithSaurus));

//         Console.WriteLine(
//             "\nArray.FindIndex(dinosaurs, 2, EndsWithSaurus): {0}",
//             Array.FindIndex(dinosaurs, 2, EndsWithSaurus));

//         Console.WriteLine(
//             "\nArray.FindIndex(dinosaurs, 2, 3, EndsWithSaurus): {0}",
//             Array.FindIndex(dinosaurs, 2, 5, EndsWithSaurus));
//     }

//     private static bool EndsWithSaurus(String s)
//     {
//         if ((s.Length > 5) &&
//             (s.Substring(s.Length - 6).ToLower() == "saurus"))
//         {
//             return true;
//         }
//         else
//         {
//             return false;
//         }
//     }
// }
