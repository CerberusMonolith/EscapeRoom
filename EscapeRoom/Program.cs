namespace EscapeRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            string playerName;

            // 1. Запрос имени игрока
            Console.WriteLine("Добро пожаловать в Escape Room!");
            Console.WriteLine("Вы просыпаетесь в неизвестной комнате и пытаетесь вспомнить своё имя");
            Console.Write("Введите свое имя: ");
            playerName = Console.ReadLine();
            Console.WriteLine("Вы решаете осмотреть комнату и видите разнообразные предметы интерьера. Величественную статую рядом с дверью с разъёмами под три предмета, ящик в углу комнаты, хлипкую вентиляцию на одной из стен комнаты которую при желании можно сорвать , кровать из под которой что-то поблёскивает и тумбочку около неё на которой что-то лежит ");

            // 2. Цикл
            bool escaped = false;
            bool hasKey = false;
            bool hasLockpick = false;
            int ventilationAttempts = 0;
            bool[] artifactsFound = new bool[3];

            while (!escaped)
            {
                Console.WriteLine("\nЧто вы хотите сделать?");
                Console.WriteLine("1. Открыть дверь");
                Console.WriteLine("2. Заглянуть под кровать");
                Console.WriteLine("3. Открыть ящик в углу комнаты");
                Console.WriteLine("4. Открыть вентиляцию");
                Console.WriteLine("5. Взглянуть на тумбочку");
                Console.WriteLine("6. Взглянуть на статую рядом с дверью");

                int choice = Convert.ToInt32(Console.ReadLine());

                // 3. Действия
                switch (choice)
                {
                    case 1: // Открыть дверь
                        if (hasLockpick)
                        {
                            Console.WriteLine($"{playerName}, вы открыли дверь и сбежали из неизвестной комнаты!");
                            escaped = true;
                        }
                        else
                        {
                            Console.WriteLine($"{playerName}, вам нужна отмычка , чтобы взломать замок.");
                        }
                        break;

                    case 2: // Заглянуть под кровать
                        if (!artifactsFound[0])
                        {
                            Console.WriteLine($"{playerName}, вы нашли первый артефакт!");
                            artifactsFound[0] = true;
                        }
                        break;

                    case 3: // Открыть ящик
                        if (hasKey)
                        {
                            Console.WriteLine($"{playerName}, вы открыли ящик.");
                            hasLockpick = true;
                            Console.WriteLine($"{playerName}, вы нашли отмычку!");
                        }
                        else
                        {
                            Console.WriteLine($"{playerName}, вам нужен ключ от ящика.");
                        }
                        break;

                    case 4: // Открыть вентиляцию
                        ventilationAttempts++;
                        if (ventilationAttempts == 3 && !artifactsFound[1])
                        {
                            Console.WriteLine($"{playerName}, вы нашли второй артефакт!");
                            artifactsFound[1] = true;
                        }
                        break;

                    case 5: // Взглянуть на тумбочку
                        if (!artifactsFound[2])
                        {
                            Console.WriteLine($"{playerName}, вы нашли третий артефакт!");
                            artifactsFound[2] = true;
                        }
                        break;

                    case 6: // Взглянуть на статую
                        if (artifactsFound[0] && artifactsFound[1] && artifactsFound[2])
                        {
                            Console.WriteLine($"{playerName}, вы активировали статую и получили ключ!");
                            hasKey = true;
                        }
                        break;

                    default:
                        Console.WriteLine("Неверный выбор.");
                        break;
                }
            }

            Console.WriteLine("Вы успешно сбежали. Поздравляю!");
            Console.ReadKey();
        }
    }
}





  