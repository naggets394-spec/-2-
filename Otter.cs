using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Практическая_работа__1_КИС
{
    internal class Otter: IAnimal
    {
        string type;
        string movementType;
        string livingEnvironment;
        int lifeExpectancy;
        int kids;
        string name;
        public Otter(string name)
        {
            try
            {
                type = "Выдра обыкновенная";
                movementType = "на земле: прыжками, в воде: плаванием";
                livingEnvironment = "Тайга, болота, реки, побережья";
                lifeExpectancy = 13;
                kids = 4;
                this.name = name;
                Out();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        public void Out()
        {
            MessageBox.Show(
                "Информация о Выдре: " +
                $"\nВид: {type}" +
                $"\nТип передвижения: {movementType}" +
                $"\nСреда обитания {livingEnvironment}" +
                $"\nСредняя продолжительность жизни: {lifeExpectancy}" +
                $"\nКоличесвто потомства за выводок: {kids}" +
                $"\nИ звать его {name}",
                "Вы создали выдреныша, ура!", MessageBoxButtons.OK, MessageBoxIcon.Information
                );
            Event();
        }
        public void Event()
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
                            kidsnum = (kidsnum / 2 + 1) * kids;
                            if (lifeExpectancy == i)
                            {
                                kidsnum--;
                            }
                            MessageBox.Show($"Год {i}:\nГод выдался благоприятным! Выдры живут очень хорошо. Все потомство выжило.\nКоличество особей: {kidsnum}", "Ура приключение", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                            MessageBox.Show($"Год {i}:\nГод был холодным, но еды хватало. Часть потомства умерла.\nКоличество особей: {kidsnum}", "Ура приключение", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        ~Otter()
        {
            MessageBox.Show("Инопланетяне забрали всех выдр", "Конец", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
