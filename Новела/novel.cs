using System;

namespace InteractiveNovel
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("🎭 НОВЕЛЛА: КЛЮЧ ОТ ПРОШЛОГО");
            Console.WriteLine("Нажмите любую клавишу чтобы начать...");
            Console.ReadKey();
            Console.Clear();

            // Шаг 1-5
            Step1();
        }

        static void Step1()
        {
            Console.WriteLine("\n=== ШАГ 1 ===");
            Console.WriteLine("Вы — библиотекарь, который находит в архиве старинный дневник с загадочным ключом.");
            Console.WriteLine("В дневнике говорится о механизме, способном изменить одно событие прошлого.");
            WaitAndContinue();

            Console.WriteLine("\n=== ШАГ 2-4 ===");
            Console.WriteLine("Ключ подходит к потайной комнате в библиотеке. Внутри вы находите механизм с тремя кристаллами.");
            Console.WriteLine("1. Активировать красный кристалл");
            Console.WriteLine("2. Активировать синий кристалл");
            Console.WriteLine("3. Активировать зеленый кристалл");
            
            int choice = GetUserChoice(1, 3);
            
            if (choice == 1)
                StepWithRedCrystal();
            else if (choice == 2)
                StepWithBlueCrystal();
            else
                StepWithGreenCrystal();
        }

        static void StepWithRedCrystal()
        {
            Console.WriteLine("\n=== ШАГ 5-7 ===");
            Console.WriteLine("Красный кристалл переносит вас в прошлое! Вы в теле часовщика за день до пожара.");
            Console.WriteLine("Часы сломаны - это причина будущей трагедии.");
            WaitAndContinue();

            Console.WriteLine("\n=== ШАГ 8-10 ===");
            Console.WriteLine("У вас есть знания, но нет навыков. Что делать?");
            Console.WriteLine("1. Попытаться починить самому");
            Console.WriteLine("2. Попросить помощи у других часовщиков");
            Console.WriteLine("3. Ничего не делать - бояться изменить историю");
            
            int choice = GetUserChoice(1, 3);
            
            if (choice == 1)
                EndingParadox();
            else if (choice == 2)
                EndingHero();
            else
                EndingShadow();
        }

        static void StepWithBlueCrystal()
        {
            Console.WriteLine("\n=== ШАГ 5-7 ===");
            Console.WriteLine("Синий кристалл показывает вам возможные будущие. Вы видите последствия своих действий.");
            WaitAndContinue();

            Console.WriteLine("\nВы решаете вмешаться осторожно:");
            Console.WriteLine("1. Подсказать предку незаметно");
            Console.WriteLine("2. Оставить подсказки в дневнике");
            
            int choice = GetUserChoice(1, 2);
            
            if (choice == 1)
                EndingHistorian();
            else
                EndingCycle();
        }

        static void StepWithGreenCrystal()
        {
            Console.WriteLine("\n=== ШАГ 5-7 ===");
            Console.WriteLine("Зеленый кристалл дает вам навыки предка! Теперь вы можете починить часы.");
            WaitAndContinue();

            Console.WriteLine("\nВы успешно чините механизм и предотвращаете пожар!");
            Console.WriteLine("Возвращаясь в настоящее, вы обнаруживаете...");
            WaitAndContinue();
            
            EndingHero();
        }

        // КОНЦОВКИ
        static void EndingHistorian()
        {
            Console.WriteLine("\n🎭 КОНЦОВКА ИСТОРИКА");
            Console.WriteLine("В дневнике записано, что пожар все равно случился, но в меньших масштабах.");
            Console.WriteLine("История изменилась незначительно, но ваша семья получила медаль за спасение города.");
            Console.WriteLine("Вы понимаете, что прошлое сопротивляется радикальным переменам.");
            ShowEndingArt();
        }

        static void EndingParadox()
        {
            Console.WriteLine("\n💥 КОНЦОВКА ПАРАДОКСА");
            Console.WriteLine("Библиотека исчезла! Она была построена на месте сгоревшего дома.");
            Console.WriteLine("Вы стоите на пустыре и не помните, кто вы такой. Прошлое стерло вас.");
            ShowEndingArt();
        }

        static void EndingHero()
        {
            Console.WriteLine("\n🏆 КОНЦОВКА ГЕРОЯ");
            Console.WriteLine("Библиотека теперь носит имя вашего предка!");
            Console.WriteLine("В холле висит его портрет и история о том, как он предотвратил катастрофу.");
            Console.WriteLine("Ваша жизнь стала лучше - семья не потеряла все в пожаре.");
            ShowEndingArt();
        }

        static void EndingShadow()
        {
            Console.WriteLine("\n👤 КОНЦОВКА ТЕНИ");
            Console.WriteLine("Дневник теперь пуст. Никто, кроме вас, не помнит старую реальность.");
            Console.WriteLine("Вы становитесь хранителем тайны двух временных линий.");
            ShowEndingArt();
        }

        static void EndingCycle()
        {
            Console.WriteLine("\n🔁 КОНЦОВКА ЦИКЛА");
            Console.WriteLine("Вернувшись в комнату, вы видите - один кристалл потускнел.");
            Console.WriteLine("Это был не единственный шанс! Где-то есть другие 'точки поломки'.");
            Console.WriteLine("Ваше путешествие только начинается...");
            ShowEndingArt();
        }

        // ВСПОМОГАТЕЛЬНЫЕ МЕТОДЫ
        static void WaitAndContinue()
        {
            Console.WriteLine("\nНажмите любую клавишу чтобы продолжить...");
            Console.ReadKey();
        }

        static int GetUserChoice(int min, int max)
        {
            while (true)
            {
                Console.Write($"\nВведите число от {min} до {max}: ");
                if (int.TryParse(Console.ReadLine(), out int choice) && choice >= min && choice <= max)
                    return choice;
                Console.WriteLine("Неверный ввод! Попробуйте снова.");
            }
        }

        static void ShowEndingArt()
        {
            Console.WriteLine("\n" + new string('=', 50));
            Console.WriteLine("🎉 ИГРА ЗАВЕРШЕНА!");
            Console.WriteLine("Спасибо за прохождение!");
            Console.WriteLine(new string('=', 50));
            Console.WriteLine("\nНажмите любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}