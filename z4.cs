// Dictionary<string, string> phonebook = new Dictionary<string, string>();

// while (true)
// {
//     Console.WriteLine("1-dobavit, 2-naity, 3-posmotret, vihod-viyti");
//     string cmd = Console.ReadLine();

//     if (cmd == "vihod") break;

//     if (cmd == "1")
//     {
//         Console.Write("imya: ");
//         string name = Console.ReadLine();
//         Console.Write("nomer: ");
//         string phone = Console.ReadLine();
//         phonebook.Add(name, phone);
//     }
//     else if (cmd == "2")
//     {
//         Console.Write("imya: ");
//         string name = Console.ReadLine();
//         if (phonebook.ContainsKey(name))
//             Console.WriteLine($"{name}: {phonebook[name]}");
//         else
//             Console.WriteLine("netu");
//     }
//     else if (cmd == "3")
//     {
//         foreach (var p in phonebook)
//             Console.WriteLine($"{p.Key}: {p.Value}");
//     }
// }