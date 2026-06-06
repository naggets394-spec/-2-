using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Практическая_работа__1_КИС
{
    internal class Cat: IAnimal, IWarriors
    {
        string type;
        string movementType;
        string livingEnvironment;
        int lifeExpectancy;
        int kids;
        string name;
        string faith;
        public Cat(string name)
        {
            try
            {
                type = "Кошка обыкновенная";
                movementType = "ходьба";
                livingEnvironment = "Тайга";
                lifeExpectancy = 15;
                kids = 6;
                this.name = name;
                faith = "...Какое звездное племя?";
                TurnIntoWarriors();
                Out();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        public void TurnIntoWarriors()
        {
            Random rand = new Random();
            if (rand.Next(2) == 0)
            {
                MessageBox.Show("Подождите, это же кошки! Взошла полная луна и они случайно обрели разум и стали котами-воителями. " +
                    "Они охраняеют границы и собирают траву для целителей. Ой, подождите, что это там за кот на вершине холма..?",
                    "Звезденое племя пришло!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                faith = "Сильнее всего на свете";
            }
            else MessageBox.Show("Луна взошла на небо... Но кошки не обратили внимание. Может, это было что-то важное? Ладно, проехали...", 
                "Звездное племя..? Нет, просто луна", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void Out()
        {
            MessageBox.Show(
                "Информация о Кошке: " +
                $"\nВид: {type}" +
                $"\nТип передвижения: {movementType}" +
                $"\nСреда обитания {livingEnvironment}" +
                $"\nСредняя продолжительность жизни: {lifeExpectancy}" +
                $"\nКоличесвто потомства за выводок: {kids}" +
                $"\nВера в звездное племя: {faith}" +
                $"\nИ звать его {name}",
                "Вы создали кощечку, ура!", MessageBoxButtons.OK, MessageBoxIcon.Information
                );
            
            Event();
        }
        public void Event()
        {
            while (true)
            {
                MessageBox.Show("Заполнение готово! Сейчас мы посмотрим как кощки будут жить следующие 5 лет", "Ура приключение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                int num = 5;
                if (num > 0)
                {
                    Random random = new Random();
                    int kidsnum = 1;
                    for (int i = 1; i <= num; i++)
                    {
                        int rand = random.Next(1, 4);
                        if (rand == 1)
                        {
                            kidsnum = (kidsnum / 2 + 1) * kids;
                            if (lifeExpectancy == i)
                            {
                                kidsnum--;
                            }
                            MessageBox.Show($"Год {i}:\nГод выдался благоприятным! Выдры живут очень хорошо своей кошачьей жизнью. Все потомство выжило.\nКоличество особей: {kidsnum}", "Ура приключение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        if (rand == 2)
                        {
                            if (kidsnum > 1)
                            {
                                kidsnum = ((kidsnum / 2 + 1) * kids) / 2;
                            }
                            else kidsnum = kidsnum = ((kidsnum / 2 + 1) * kids) / 2;
                            if (lifeExpectancy == i)
                            {
                                kidsnum--;
                            }
                            MessageBox.Show($"Год {i}:\nГод был холодным, но еды хватало. Часть потомства кошек умерла.\nКоличество особей: {kidsnum}", "Ура приключение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        if (rand == 3)
                        {

                            int n = random.Next(1, 10);
                            kidsnum -= n;
                            if (lifeExpectancy == i)
                            {
                                kidsnum--;
                            }
                            if (kidsnum <= 0)
                            {
                                MessageBox.Show($"Год {i}:\nГод оказался слишклм тяжелым. Потомство кошек не выжило. Некоторые так же же не выжили. Все ваши вкошки вымерли((", "Что-то не задалось...", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                break;
                            }
                            if (kidsnum > 0)
                            {
                                MessageBox.Show($"Год {i}:\nГод оказался слишклм тяжелым. Потомство не выжило. Некоторые кошки так же же не выжили. Количество особей: {kidsnum}", "Ура приключение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }

                        }

                    }
                    break;
                }
                else MessageBox.Show("Так не интересно. Еще раз");
            }
        }

        ~Cat()
        {
            MessageBox.Show("Инопланетяне забрали всех кошек", "Конец", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
