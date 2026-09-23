// Console.Write("Studenti: ");
// int n = int.Parse(Console.ReadLine());

// Console.Write("Predmeti: ");
// int m = int.Parse(Console.ReadLine());

// int[,] osenki = new int[n, m];

// for (int i = 0; i < n; i++)
// {
//     Console.WriteLine($"Student {i + 1}:");
//     for (int j = 0; j < m; j++)
//     {
//         Console.Write($"Predmet {j + 1}: ");
//         osenki[i, j] = int.Parse(Console.ReadLine());
//     }
// }

// for (int i = 0; i < n; i++)
// {
//     double sum = 0;
//     for (int j = 0; j < m; j++)
//         sum += osenki[i, j];
//     Console.WriteLine($"Srednee {i + 1}: {sum / m}");
// }