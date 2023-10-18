using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Xml.Linq;

class Program
{
    class Collections
    {
        ArrayList Collection = new ArrayList();

        // Добавление данных в коллекцию
        public virtual void CollectionAdd(string collections)
        {
            Collection.Add(collections);
        }

        //удаление данныз из коллекции
        public virtual void CollectionRemove(int N)
        {
            Collection.RemoveAt(N);
        }

        // получение элемента из коллекции по индексу
        public virtual string CollectionSet(int element1)
        {
            var element2 = Convert.ToString(Collection[element1]);

            return element2;
        }

        // получение длины коллекции 
        public int CollectionCount()
        {
            return Collection.Count;
        }

        public virtual void CollectionPrint()
        {
            int count = 0;
            foreach (string i in Collection)
            {
                Console.WriteLine("Индекс:" + $" {count++}  " + " Элемент: " + i);
            }

        }
    }

    class List : Collections
    {
        List<string> Collection = new List<string>();
    }

    class Stack : Collections
    {
        Stack<int> Collection = new Stack<int>();

        // Добавление данных в коллекцию
        public override void CollectionAdd(string collections)
        {
            Collection.Push(Convert.ToInt32(collections));
        }

        //удаление данныз из коллекции
        public override void CollectionRemove(int N)
        {
            ArrayList Collection1 = new ArrayList(Collection);

            Collection1.RemoveAt(N);

            Collection.Clear();

            for (int i = 0; i < Collection1.Count; ++i)
            {
                Collection.Push(Convert.ToInt32(Collection1[i]));
            }

            Collection1.Clear();
        }

        // получение элемента из коллекции по индексу
        public override string CollectionSet(int element1)
        {
            ArrayList Collection1 = new ArrayList(Collection);

            var element2 = Convert.ToString(Collection1[element1]);

            return element2;
        }

        public override void CollectionPrint()
        {
            int count = 0;
            foreach (int i in Collection)
            {
                Console.WriteLine("Индекс:" + $" {count++}  " + " Элемент: " + i);
            }
        }

        public int CollectionCount()
        {
            return Collection.Count;
        }
    }

    class Queue : Collections
    {
        Queue<double> Collection = new Queue<double>();

        // Добавление данных в коллекцию
        public override void CollectionAdd(string collections)
        {
            Collection.Enqueue(Convert.ToDouble(collections));
        }

        //удаление данныз из коллекции
        public override void CollectionRemove(int N)
        {
            ArrayList Collection1 = new ArrayList(Collection);

            Collection1.RemoveAt(N);

            Collection.Clear();

            for (int i = 0; i < Collection1.Count; ++i)
            {
                Collection.Enqueue(Convert.ToDouble(Collection1[i]));
            }

            Collection1.Clear();
        }

        // получение элемента из коллекции по индексу
        public override string CollectionSet(int element1)
        {
            ArrayList Collection1 = new ArrayList(Collection);

            var element2 = Convert.ToString(Collection1[element1]);

            return element2;
        }

        public override void CollectionPrint()
        {
            int count = 0;
            foreach (double i in Collection)
            {
                Console.WriteLine("Индекс:" + $" {count++}  " + " Элемент: " + i);
            }

        }

        public int CollectionCount()
        {
            return Collection.Count;
        }
    }

    static public void task1()
    {
        Console.WriteLine("ArrayList");

        Collections col1 = new Collections();

        col1.CollectionAdd("Tom");
        col1.CollectionAdd("3");
        col1.CollectionAdd("19");
        col1.CollectionAdd("Bob");
        col1.CollectionAdd("5,5");
        col1.CollectionPrint();

        Console.WriteLine();

        Console.WriteLine("Удаление элемента с индексом 2: ");
        col1.CollectionRemove(2);
        col1.CollectionPrint();

        Console.WriteLine();

        Console.WriteLine($"Элемент по индексу 3: {col1.CollectionSet(3)}");
        col1.CollectionPrint();

        Console.WriteLine();

        Console.WriteLine($"Длина коллекции: {col1.CollectionCount()}");

        Console.WriteLine();
    }

    static public void task2()
    {
        Console.WriteLine("List");

        List col2 = new List();

        col2.CollectionAdd("Tom");
        col2.CollectionAdd("Bob");
        col2.CollectionAdd("Any");
        col2.CollectionAdd("18,5");
        col2.CollectionAdd("5,31");
        col2.CollectionAdd("6");
        col2.CollectionPrint();

        Console.WriteLine();

        Console.WriteLine("Удаление элемента с индексом 2: ");
        col2.CollectionRemove(2);
        col2.CollectionPrint();

        Console.WriteLine();

        Console.WriteLine($"Элемент по индексу 3: {col2.CollectionSet(3)}");
        col2.CollectionPrint();

        Console.WriteLine();

        Console.WriteLine($"Длина коллекции: {col2.CollectionCount()}");

        Console.WriteLine();
    }

    static public void task3()
    {
        Console.WriteLine("Stack");

        Stack col3 = new Stack();

        col3.CollectionAdd("1");
        col3.CollectionAdd("2");
        col3.CollectionAdd("3");
        col3.CollectionAdd("4");
        col3.CollectionAdd("5");
        col3.CollectionPrint();

        Console.WriteLine();

        Console.WriteLine("Удаление элемента с индексом 2: ");
        col3.CollectionRemove(2);
        col3.CollectionPrint();

        Console.WriteLine();

        Console.WriteLine($"Элемент по индексу 3: {col3.CollectionSet(3)}");
        col3.CollectionPrint();

        Console.WriteLine();

        Console.WriteLine($"Длина коллекции: {col3.CollectionCount()}");

        Console.WriteLine();
    }

    static public void task4()
    {
        Console.WriteLine("Queue");

        Queue col4 = new Queue();

        Console.WriteLine("Заполнение: ");

        col4.CollectionAdd("1,1");
        col4.CollectionAdd("2,2");
        col4.CollectionAdd("3,3");
        col4.CollectionAdd("4,4");
        col4.CollectionAdd("5,5");
        col4.CollectionPrint();

        Console.WriteLine();

        Console.WriteLine("Удаление элемента с индексом 2: ");
        col4.CollectionRemove(2);
        col4.CollectionPrint();

        Console.WriteLine();

        Console.WriteLine($"Элемент по индексу 3: {col4.CollectionSet(3)}");
        col4.CollectionPrint();

        Console.WriteLine();

        Console.WriteLine($"Длина коллекции: {col4.CollectionCount()}");

        Console.WriteLine();
    }

    static public void Main()
    {
        task1();

        task2();

        task3();

        task4();
    }
}