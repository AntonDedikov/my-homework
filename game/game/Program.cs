using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace game
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            float startHealthMirrorAssassin = 100;
            float healthMirrorAssassin = 100;
            float damageMirrorAssassin = 10;
            float critDamadeMirrorAssassin;
            float armorMirrorAssassin = 80;
            float healthRecovery = healthMirrorAssassin / 100 * 15;
            bool assasinShild = false;
            bool lastBreath = false;
            bool reflectionClone = false;
            bool chanceCloneTakeDamage = false;
            int TimeInMeasurement = 0;

            float startHilthCrazyAlchemist = 200;
            float healthCrazyAlchemist = 200;
            float damageCrazyAlchemist = 10;
            float critDamageCrazyAlchemist;
            float armorCrazyAlchemist = 70;
            int alchemistGolem = 0;
            float damageAlchemistGolem = 3;
            int golemHealth = 5;
            float golemArmor = 0.5f;
            string userInput;

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Вы играете за Зеркального Ассасина." +
                "\nВаша цель победить Безумного Алхимика" +
                "\nУдачи и будте бдительны");


            while (healthMirrorAssassin > 0 && healthCrazyAlchemist > 0)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\nИспользуйте способности:");
                if (lastBreath == false)
                {
                    if (TimeInMeasurement == 0)
                    {
                        Console.WriteLine("1 - щит - возвращает 50% урона атакующему");
                        Console.WriteLine("2 - побег в зеркальное измерение - Ассасин становится не уязвим, " +
                            "\n и восполняет 15% здоровья за ход");
                        Console.WriteLine("3 - зов отражения - из отражения выходит клон," +
                            " который атакует как Ассасин," +
                            " \n и имеющий 50% вероятность принять на себя урон(клон при этом исчезает)");
                        Console.WriteLine("4 - последний вздох - разбивает щит на осколки " +
                            "наносящие рандомное кол-во урона");
                        userInput = Console.ReadLine();
                        if (reflectionClone == true)
                        {
                            while (userInput == "3")
                            {
                                Console.WriteLine("Можно призвать только одного клона");
                                userInput = Console.ReadLine();
                            }
                        }
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        switch (userInput)
                        {
                            case "1":
                                Console.WriteLine("\nЩит использован");
                                assasinShild = true;
                                break;
                            case "2":
                                Console.WriteLine("\nПобег");
                                TimeInMeasurement +=2;
                                break;
                            case "3":
                                Console.WriteLine("\nПризыв клона");
                                reflectionClone = true;
                                break;
                            case "4":
                                Console.WriteLine("\nЩит разбит");
                                lastBreath = true;
                                critDamadeMirrorAssassin = rand.Next(500, 1000);
                                healthCrazyAlchemist -= (damageMirrorAssassin / 100 * critDamadeMirrorAssassin)
                                    / 100 * armorCrazyAlchemist;
                                Console.WriteLine("\nАссасин нанес " + (damageMirrorAssassin / 100
                                    * critDamadeMirrorAssassin) + " урона и лишился сверх сил");
                                break;
                            default:
                                Console.WriteLine("\nПроявление мазохизма");
                                break;
                        }
                    }

                    if (TimeInMeasurement > 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("До выхода из измерения " + TimeInMeasurement + " хода");
                        Console.WriteLine("1 - Атаковать со спины \n2 - востанавится");
                        userInput = Console.ReadLine();
                        switch (userInput)
                        {
                            case "1":
                                Console.WriteLine("\nАтака co cпины");
                                critDamadeMirrorAssassin = rand.Next(100, 300);
                                healthCrazyAlchemist -= (damageMirrorAssassin / 100 * critDamadeMirrorAssassin)
                                    / 100 * armorCrazyAlchemist;
                                TimeInMeasurement = 0;
                                Console.WriteLine("Ассасин нанес " + (damageMirrorAssassin / 100
                                    * critDamadeMirrorAssassin) + " урона.");
                                break;
                            case "2":
                                healthMirrorAssassin += healthRecovery;
                                Console.WriteLine("\nВостановление здоровья на 30% " + "(" + healthRecovery + ")");
                                if (healthMirrorAssassin > startHealthMirrorAssassin)
                                {
                                    healthMirrorAssassin = startHealthMirrorAssassin;
                                }
                                break;
                            default:
                                Console.WriteLine("\nОжидание");
                                break;

                        }
                    }
                }



                 else
                {
                    Console.WriteLine("1 - удар кинжалом");
                    userInput = Console.ReadLine();
                    if(userInput == "1")
                    {
                        critDamadeMirrorAssassin = rand.Next(100, 300);
                        healthCrazyAlchemist -= (damageMirrorAssassin / 100 * critDamadeMirrorAssassin)
                            / 100 * armorCrazyAlchemist;
                        Console.WriteLine("\nАссасин нанес " + damageMirrorAssassin / 100 
                            * critDamadeMirrorAssassin + " урона.");
                    }
                    else
                    {
                        Console.WriteLine("\nОтчаяние");
                    }
                 }



                if (reflectionClone == true)
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    critDamadeMirrorAssassin = rand.Next(100, 300);
                    healthCrazyAlchemist -= (damageMirrorAssassin / 100 * critDamadeMirrorAssassin)
                        / 100 * armorCrazyAlchemist;
                    Console.WriteLine("\nКлон нанес " + damageMirrorAssassin / 100
                        * critDamadeMirrorAssassin + " урона.");
                    chanceCloneTakeDamage = Convert.ToBoolean(rand.Next(0, 2));

                }


                Console.ForegroundColor = ConsoleColor.Red;
                if (TimeInMeasurement == 0)
                {
                    damageAlchemistGolem = 3;
                    damageAlchemistGolem = alchemistGolem * damageAlchemistGolem;
                    if (assasinShild == true)
                    {
                        critDamageCrazyAlchemist = rand.Next(90, 250);
                        healthMirrorAssassin -= (((damageCrazyAlchemist / 100 * critDamageCrazyAlchemist)
                            + damageAlchemistGolem)/ 100 * armorMirrorAssassin) / 2;
                        healthCrazyAlchemist -= (((damageCrazyAlchemist / 100 * critDamageCrazyAlchemist)
                            + damageAlchemistGolem)/ 100 * armorCrazyAlchemist) / 2;

                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine("\nАлхимик нанес " + ((damageCrazyAlchemist / 100 * critDamageCrazyAlchemist)
                            + damageAlchemistGolem) + " урона,  големы "
                        + damageAlchemistGolem + " половина урона было отражено и возвращено");
                        assasinShild = false;
                    }

                    else if(reflectionClone == true && chanceCloneTakeDamage == true)
                    {
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine("\nАлхимик нанес " + damageCrazyAlchemist + " урона клону,  големы "
                            + damageAlchemistGolem);
                        Console.WriteLine("\nКлон исчез");
                        reflectionClone = false;
                    }

                    else
                    {
                        critDamageCrazyAlchemist = rand.Next(90, 250);
                        healthMirrorAssassin -= ((damageCrazyAlchemist / 100 * critDamageCrazyAlchemist)
                            + damageAlchemistGolem) / 100 * armorMirrorAssassin;
                        Console.WriteLine("\nАлхимик нанес " + damageCrazyAlchemist / 100 * critDamageCrazyAlchemist 
                            + " урона,  големы "+ damageAlchemistGolem);
                    }       
                    Console.WriteLine("\nПризыв каменного голема");
                    alchemistGolem++;



                    if (healthCrazyAlchemist < startHilthCrazyAlchemist / 100 * 50)
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("\nСлияние с големами");
                        healthCrazyAlchemist += alchemistGolem * golemHealth;
                        damageCrazyAlchemist += alchemistGolem * damageAlchemistGolem / 2;
                        armorCrazyAlchemist -= alchemistGolem * golemArmor;
                        Console.WriteLine("Здоровье Алхимика " + healthCrazyAlchemist 
                            + "\nСила Алхимика " + damageCrazyAlchemist 
                            + "\nЗащита Алхимика " + (100 - armorCrazyAlchemist));
                        alchemistGolem = 0;
                    }
                }

                else if (reflectionClone == true && chanceCloneTakeDamage == true)
                {
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine("\nАлхимик нанес " + damageCrazyAlchemist + " урона клону,  големы "
                        + damageAlchemistGolem);
                    Console.WriteLine("\nКлон исчез");
                    reflectionClone = false;
                    alchemistGolem++;
                    TimeInMeasurement--;
                }


                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nПризыв каменного голема");
                    alchemistGolem++;
                    TimeInMeasurement--;
                }


                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\nЖизнь Безумного Алхимика " + healthCrazyAlchemist);
                Console.WriteLine("Количество големов " + alchemistGolem);

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\nЖизнь Зеркального Ассасина " + healthMirrorAssassin);
                if(reflectionClone == true)
                {
                    Console.Write("Состояние клона - в бою\n");
                }
                else 
                {
                    Console.WriteLine("Клон в зеркальном измерении\n");
                }
            }


            if(healthCrazyAlchemist < 1)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\nВы победили!");
            }
            else if(healthMirrorAssassin < 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nВы проиграли. Игра окончена");
            }   
            Console.ReadKey();
        }
    }
}
