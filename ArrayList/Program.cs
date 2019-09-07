using System;
using System.Collections;//.Generic; убираем т.к. это не динамический массив
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayListLes
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            list.Add(36);
            list.Add("hellow");
            list.Add('!');
            foreach(object i in list)
            {
                Console.Write( i + " " );
            }
            Console.WriteLine("\n items in list -" + list.Count);//число  элементов в массиве
            Console.WriteLine(new String('-', 30));
            list.AddRange(new double[] { 2.3, 1.1, 25.6, 74, 7 });
            for(int j=0; j<list.Count;j++)
            {
                Console.WriteLine(list[j] + " ");
            }
            Console.WriteLine("\n items in list - " + list.Count);
            Console.WriteLine(new String('-', 30));
            list.Insert(2, "world");
            for (int j = 0; j < list.Count; j++)
            {
                Console.WriteLine(list[j] + " ");
            }
            Console.WriteLine("\n items in list - " + list.Count);
            Console.WriteLine(new String('-', 30));
            ArrayList sList = new ArrayList()
            {
                'I',' ','a','m',' ','s','t','u','d','y','i','n','g',' ','c','#'
            };//создаем новый малый массив чаров
            list.InsertRange(list.Count , sList);// sList  вставляем в общий лист
            for (int j = 0; j < list.Count; j++)
            {
                Console.Write(list[j] + " ");
            }
            Console.WriteLine("\n items in list - " + list.Count);
            Console.WriteLine(new String('-', 30));
            list.Add ("Hellow");
            Console.WriteLine(list.IndexOf("hellow"));
            Console.WriteLine(list.LastIndexOf("Hellow"));
            for (int j = 0; j < list.Count; j++)
            {
                Console.Write(list[j] + " ");
            }
            Console.WriteLine("\n items in list - " + list.Count);
            Console.WriteLine(new String('-', 30));
            list.Remove("hellow");// удаляем элемент массива по значению
            for (int j = 0; j < list.Count; j++)
            {
                Console.Write(list[j] + " ");
            }
            Console.WriteLine("\n items in list - " + list.Count);
            Console.WriteLine(new String('-', 30));
            list.RemoveAt(list.IndexOf("Hellow"));// удаляем элемент по индексу
            for (int j = 0; j < list.Count; j++)
            {
                Console.Write(list[j] + " ");
            }
            Console.WriteLine("\n items in list - " + list.Count);
            Console.WriteLine(new String('-', 30));
            list.RemoveRange(3,3);
            for (int j = 0; j < list.Count; j++)
            {
                Console.Write(list[j] + " ");
            }
            Console.WriteLine("\n items in list - " + list.Count);
            Console.WriteLine(new String('-', 30));
            list.Add(70);
            list.Insert(3, 70);
            list.Insert(9, 70);

            for (int j = 0; j < list.Count; j++)
            {
                Console.Write(list[j] + " ");
            }
            Console.WriteLine("\n items in list - " + list.Count);
            Console.WriteLine(new String('-', 30));
            while (list.Contains(70))// метод Contains ищит элемент в списке по значению
            {
                list.Remove(70);
            }
            for (int j = 0; j < list.Count; j++)
            {
                Console.Write(list[j] + " ");
            }
            Console.WriteLine("\n items in list - " + list.Count);
            Console.WriteLine(new String('-', 30));
            IEnumerator x = list.GetEnumerator();
            while(x.MoveNext())
            {
                Console.Write(x.Current + ",");
            }

            Console.ReadKey();
        }
    }
}
