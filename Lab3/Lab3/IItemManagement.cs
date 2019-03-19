using System;
using System.Linq.Expressions;

namespace Lab3
{
    /// <summary>
    /// IZarzadzaniePozycjami
    /// </summary>
   public interface IItemManagement
   {
       void ShowAllItems();
       Item FindItemBy(int id);
       Item FindItemBy(string title);
       Item FindItem(Expression<Func<Item, bool>> predicate);
   }
}
