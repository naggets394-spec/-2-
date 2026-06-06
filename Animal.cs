using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Практическая_работа__1_КИС
{
    internal class Animals
    {
        string type;
        string movementType;
        string livingEnvironment;
        int lifeExpectancy;
        int kids;
        string name;
        protected string Type { get; set; } = "Неопределен";
        protected string MovementType { get; set; } = "Неопределен";
        protected string LivingEnvironment { get; set; } = "Неопределен";
        protected int LifeExpectancy { get; set; } = 1;
        protected int Kids { get; set; } = 1;
        protected string Name { get; set; } = "Неопределен";

        //public Animals(string type, string movementType, string livingInvironment, int lifeExpectancy, int kids, string name)
        //{
        //    this.type = type;
        //    this.movementType = movementType;
        //    this.livingEnvironment = livingInvironment;
        //    this.lifeExpectancy = lifeExpectancy;
        //    this.kids = kids;
        //    this.name = name;
        //}
        protected virtual void Event(int Kids)
        {
            while (true)
            {
                MessageBox.Show("Заполнение готово! Сейчас мы посмотрим как эти маленькие миньенчики будут жить следующие 5 лет", "Ура приключение", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                            kidsnum = (kidsnum / 2 + 1) * Kids;
                            if (LifeExpectancy == i)
                            {
                                kidsnum--;
                            }
                            MessageBox.Show($"Год {i}:\nГод выдался благоприятным! {Type} живут очень хорошо. Все потомство выжило.\nКоличество особей: {kidsnum}", "Ура приключение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        if (rand == 2)
                        {
                            if (kidsnum > 1)
                            {
                                kidsnum = ((kidsnum / 2 + 1) * Kids) / 2;
                            }
                            else kidsnum = kidsnum = ((kidsnum / 2 + 1) * Kids) / 2;
                            if (LifeExpectancy == i)
                            {
                                kidsnum--;
                            }
                            MessageBox.Show($"Год {i}:\nГод был холодным, но еды хватало. Часть потомства умерла.\nКоличество особей: {kidsnum}", "Ура приключение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        if (rand == 3)
                        {

                            int n = random.Next(1, 10);
                            kidsnum -= n;
                            if (LifeExpectancy == i)
                            {
                                kidsnum--;
                            }
                            if (kidsnum <= 0)
                            {
                                MessageBox.Show($"Год {i}:\nГод оказался слишклм тяжелым. Потомство не выжило. Некоторые так же же не выжили. Все особи вымерли((", "Что-то не задалось...", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                break;
                            }
                            if (kidsnum > 0)
                            {
                                MessageBox.Show($"Год {i}:\nГод оказался слишклм тяжелым. Потомство не выжило. Некоторые так же же не выжили. Количество особей: {kidsnum}", "Ура приключение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }

                        }

                    }
                    break;
                }
                else MessageBox.Show("Так не интересно. Еще раз");
            }
        }
        public virtual void Out(string Type, int Kids, string MovementType, string LivingEnvironment, int LifeExpectancy, string Name)
        {
            MessageBox.Show(
                "Информация о животном: " +
                $"\nВид: {Type}" +
                $"\nТип передвижения: {MovementType}" +
                $"\nСреда обитания {LivingEnvironment}" +
                $"\nСредняя продолжительность жизни: {LifeExpectancy}" +
                $"\nКоличесвто потомства за выводок: {Kids}" +
                $"\nИ звать его {Name}",
                "Вы создали малышарика!", MessageBoxButtons.OK, MessageBoxIcon.Information
                );
            Event(Kids);
        }
        ~Animals()
        {
            MessageBox.Show("Инопланетяне забрали всех животных", "Конец", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
