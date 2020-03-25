using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Memento
{
    public class Gamer
    {
        public int Money { get; set; }
        IList<string> Fruits = new List<string>();
        readonly Random random = new Random();
        static readonly string[] fruitsName = { "リンゴ", "ぶどう", "バナナ", "みかん" };
        public Gamer(int money)
        {
            this.Money = money;
        }

        public void Bet()
        {
            int dice = random.Next(6) + 1;
            if (dice == 1)
            {
                Money = 100;
                Console.WriteLine("所持金が増えました。");
            }
            else if (dice == 2)
            {
                Money /= 2;
                Console.WriteLine("所持金が半分になりました。");
            }
            else if (dice == 6)
            {
                string f = GetFruits();
                Console.WriteLine("フルーツ（" + f + "）をもらいました。");
                Fruits.Add(f);
            }
            else
            {
                Console.WriteLine("何も起こりませんでした。");
            }
        }

        public Memento CreateMemento()
        {
            Memento memento = new Memento(Money);
            Fruits.Where(fruit => fruit.StartsWith("おいしい"))
                .ToList()
                .ForEach(deliciousFruit => memento.AddFruit(deliciousFruit));
            return memento;
        }

        public void RestoreMemento(Memento memento)
        {
            Money = memento.Money;
            Fruits = memento.Fruits;
        }

        public override string ToString()
        {
            var stringBuilder = new StringBuilder();
            foreach (var fruit in Fruits)
            {
                stringBuilder.Append(fruit + ",");
            }
            return $"[money = {Money}, fruits = {stringBuilder}]";
        }

        private string GetFruits()
        {
            string prefix = random.Next(2) == 1 ? "おいしい" : string.Empty;
            return prefix + fruitsName[random.Next(fruitsName.Length - 1)];
        }
    }
}
