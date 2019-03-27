using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5.BLL
{


    public interface IAction
    {
        IList<C> Set<C>() where C : IObject;
    }


    public static class ActionExtension
    {
        public static C Get<C>(this IAction container, Func<C, bool> serchFn) where C : IObject
        {
            return container.Set<C>().SingleOrDefault(serchFn);
        }

        public static IList<C> GetList<C>(this IAction container, Func<C, bool> searchFn) where C : IObject
        {
            return container.Set<C>().Where(searchFn).ToList();
        }

        public static S Add<C, S>(this S container, C element) where C : IObject where S : IAction
        {
            container.Set<C>().Add(element);
            return container;
        }

        public static C Remove<C>(this IAction container, Func<C, bool> serchFn) where C : IObject
        {
            var obj = container.Set<C>().SingleOrDefault(serchFn);
            if (obj != null)
                container.Set<C>().Remove(obj);
            return obj;
        }

        public static C AddInto<C>(this C obj, IAction container) where C : IObject
        {
            container.Set<C>().Add(obj);
            return obj;
        }
    }

    public interface ISearchAction : IAction
    {
        Func<C, bool> SearchFn<C>(string searchId) where C : IObject;
    }

    public static class SearchActionExtension
    {
        public static C Get<C>(this ISearchAction container, string find) where C : IObject
        {
            return container.Get(container.SearchFn<C>(find));
        }

        public static IList<C> GetList<C>(this ISearchAction container, string find) where C : IObject
        {
            return container.GetList(container.SearchFn<C>(find));
        }
    }


    public static class PrintActionExtension
    {
        public static C Print<C>(this C obj) where C : IObject
        {
            Console.WriteLine(obj);
            return obj;
        }
        
        public static IList<S> Print<S>(this IList<S> set) where S : IObject
        {
            set.All(d => { Console.WriteLine(d); return true; });
            return set;
        }

        public static C PrintInfo<C>(this C obj) where C : IObject
        {
            obj.DisplayInfo();
            return obj;
        }

        public static IList<C> PrintInfo<C>(this IList<C> set) where C : IObject
        {
            set.All(d => { d.DisplayInfo(); return true; });
            return set;
        }
    }





    /*public abstract class Action<S> where S : Action<S>
    {

        abstract protected IList<C> Set<C>() where C : IObject;

        public C Get<C>(string id) where C : IObject
        {
            return Set<C>().SingleOrDefault(e => e.CheckFn == id);
        }


        public S Add<C>(C element) where C : IObject
        {
            Set<C>().Add(element);
            return (S)this;
        }

        public S Print<C>() where C : IObject
        {
            Set<C>().All(c => { Console.WriteLine(c); return true; });
            return (S)this;
        }


        public S PrintInfo<C>() where C : IObject
        {
            Set<C>().All(c => { c.DisplayInfo(); return true; });
            return (S)this;
        }
    }*/
}
