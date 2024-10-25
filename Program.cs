namespace EscapeRoom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Приветствую! Как тебя зовут?");
            string playerName = Console.ReadLine();

           
            Console.WriteLine($"\n{playerName}, ты просыпаешься в комнате и пытаешься вспомнить свое имя. " +
                              "Ты видишь перед собой несколько объектов: " +
                              "дверь, кровать, ящик в углу, вентиляция, тумбочка, статуя рядом с дверью." +
                              "Что ты хочешь сделать?");

          
            bool hasKey = false;
            bool hasKeyStorage = false;
            bool hasArtifact1 = false;
            bool hasArtifact2 = false;
            bool hasArtifact3 = false;
            bool openedVentilation = false;

           
            while (true)
            {
               
                Console.WriteLine("\nВыбери действие (введи номер):");
                Console.WriteLine("1. Открыть дверь");
                Console.WriteLine("2. Заглянуть под кровать");
                Console.WriteLine("3. Открыть ящик в углу");
                Console.WriteLine("4. Открыть вентиляцию");
                Console.WriteLine("5. Взглянуть на тумбочку");
                Console.WriteLine("6. Взглянуть на статую");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1: 
                        if (hasKeyStorage)
                        {
                            Console.WriteLine("\nТы открываешь дверь ключом и выбегаешь на свободу! " +
                                              "Поздравляю, ты сбежал!");
                            return; 
                        }
                        else
                        {
                            Console.WriteLine("\nДверь заперта. Тебе нужен ключ.");
                        }
                        break;

                    case 2: 
                        if (!hasArtifact1)
                        {
                            Console.WriteLine($"\n{playerName}, ты нашел первый артефакт!");
                            hasArtifact1 = true;
                        }
                        else
                        {
                            Console.WriteLine("\nПод кроватью ничего интересного нет.");
                        }
                        break;

                    case 3: 
                        if (hasKey)
                        {
                            if (!hasKeyStorage)
                            {
                                Console.WriteLine($"\n{playerName}, ты нашел ключ от двери!");
                                hasKeyStorage = true;
                            }
                            else
                            {
                                Console.WriteLine("\nВ ящике больше ничего нет.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("\nЯщик заперт. Тебе нужен ключ.");
                        }
                        break;

                    case 4: 
                        if (!openedVentilation)
                        {
                            openedVentilation = true;
                            Console.WriteLine("\nТы пытаешься открыть вентиляцию...");
                            if (hasArtifact2)
                            {
                                Console.WriteLine($"\n{playerName}, ты нашел второй артефакт!");
                                hasArtifact2 = true;
                            }
                            else
                            {
                                openedVentilation = true;
                                Console.WriteLine("\nВентиляция закрыта. Попробуй еще раз.");
                            }
                        }
                        else
                        {
                            if (!hasArtifact2)
                            {
                                Console.WriteLine($"\n{playerName}, спустя три попытки открыть вентиляцию, ты нашел второй артефакт!");
                                hasArtifact2 = true;
                            }
                            else
                            {
                                Console.WriteLine("\nВентиляция пуста.");
                            }
                        }
                        break;

                    case 5: 
                        if (!hasArtifact3)
                        {
                            Console.WriteLine($"\n{playerName}, ты нашел третий артефакт!");
                            hasArtifact3 = true;
                        }
                        else
                        {
                            Console.WriteLine("\nНа тумбочке ничего интересного нет.");
                        }
                        break;

                    case 6: 
                        if (hasArtifact1 && hasArtifact2 && hasArtifact3)
                        {
                            if (!hasKey)
                            {
                                Console.WriteLine($"\n{playerName}, ты активировал статую и получил ключ от ящика!");
                                hasKey = true;
                            }
                            else
                            {
                                Console.WriteLine("\nСтатуя уже активирована.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("\nСтатуя выглядит странно. " +
                                              "Возможно, ее можно активировать чем-то.");
                        }
                        break;

                    default:
                        Console.WriteLine("\nНеверный выбор. Попробуй еще раз.");
                        break;
                }
            }
        }
    }
}