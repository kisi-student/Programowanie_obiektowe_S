using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Lab3
{
    /// <summary>
    /// Katalog
    /// </summary>
    public class Catalog : IItemManagement
    {
        public IList<Item> Items { get; set; }
        public string ThematicDepartment { get; set; }

        public Catalog(IList<Item> items)
        {
            Items = items;
            ThematicDepartment = "NONE";
        }

        public Catalog(string thematicDepartment, IList<Item> items)
        {
            Items = items;
            ThematicDepartment = thematicDepartment;
        }

        public void AddItem(Item item)
        {
            Items.Add(item);
        }

        public Item FindItem(Expression<Func<Item, bool>> predicate)
        {
            var item = Items.First(predicate.Compile());
            return item;
        }

        public Item FindItemBy(string title)
        {
            foreach (var item in Items)
                if (String.Compare(item.Title, title, StringComparison.Ordinal) == 0)
                    return item;
            return null;
        }

        public Item FindItemBy(int id)
        {
            foreach (var item in Items)
                if (item.Id == id)
                    return item;
            return null;
        }
        public override string ToString()
        {
            var str = "CATALOG:\r\n";
            str += $"Thematic department {ThematicDepartment} \r\n ITEMS: \r\n";
            foreach (var item in Items)
                str += item + "\r\n";
            return str;
        }

        public void ShowAllItems()
        {
            var str = "Catalog ITEMS: \r\n";
            foreach (var item in Items)
                str += item + "\r\n";
            Console.WriteLine(str);
        }

    }
}
