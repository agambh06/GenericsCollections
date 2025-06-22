using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsCollections
{
    internal class Class1 : ICollectionOperations
    {
        public Class1() { }
        public void StackOperations(Stack<DateTime> stack)
        {
            if (stack.Peek() < DateTime.Today)
            {
                stack.Pop();
                stack.Push(DateTime.Today);
            }
        }
        public void DictionaryOperations(Dictionary<string, int> dictionary)
        {
            foreach (KeyValuePair<string, int> entry in dictionary)
            {
                if (entry.Key == "scuba" && entry.Value == 6)
                {
                    dictionary.Add("scuba", 6);
                    break;
                }
            }
        }
        public void ListOperations(List<string> list)
        {
            DeleteTheMiddleElement(list);
            Delete6IfContainsMama(list);
            if (list.IndexOf("course59") % 2 != 0)
            {
                list.Reverse();
            }
            if (Is3OrMoreDifferentElements(list))
            {
                list.Insert(2, "2");
                list.Insert(3, "3");
                list.Insert(4, "4");
            }
        }
        public static bool Is3OrMoreDifferentElements(List<string> list)
        {
            List<string> DifferentElements = new List<string>();
            for (int i = 0; i < list.Count; i++)
            {
                if (!DifferentElements.Contains(list[i]))
                {
                    DifferentElements.Add(list[i]);
                }
            }
            return DifferentElements.Count() >= 3;
        }
        public void Delete6IfContainsMama(List<string> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].Equals("mama"))
                {
                    list[i] = "mama6";
                }
            }
        }
        public void DeleteTheMiddleElement(List<string> list)
        {
            int length = list.Count;
            if (length % 2 == 0)
            {
                list.RemoveAt(length / 2);
                list.RemoveAt(length / 2 + 1);
            }
            else
            {
                list.RemoveAt(length / 2);
            }
        }
    }
}
