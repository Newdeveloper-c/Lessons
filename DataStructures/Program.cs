
//----------- list --------------

//var list = new List<int>() { 1, 2, 3};
//int[] arr = new[] { 4, 4, 5, 5, 6 };

//list.AddRange(arr);

//list.Remove(4);
//list.RemoveAll(x  => x == 5);


//list.Add(7);
//list.Add(8);
//list.Add(9);
//list.Add(10);

//Console.WriteLine( list.Capacity);
//Console.WriteLine();

//list.ForEach(x => Console.WriteLine(x));

//----------- arraylist --------------

//using System.Collections;

//var arraylist = new ArrayList() { 1, 'a', "abcd", 123.09M};

//Console.WriteLine(arraylist.Capacity);

//arraylist.Add(10);
//Console.WriteLine(arraylist.Capacity);

//foreach (var item in arraylist)
//    Console.WriteLine(item);


//----------- LinkedList --------------

//var linkedlist = new LinkedList<string>();

//for (int i = 0; i < 10; i++)
//    linkedlist.AddLast(i.ToString());

//foreach (var item in linkedlist)
//    Console.WriteLine(item);

//linkedlist.Clear();

//Console.WriteLine(linkedlist.First?.Value);
//Console.WriteLine(linkedlist.Last?.Value);

//----------- Dictionary --------------

//var dictioanry = new Dictionary<Student, string>()
//{
//    {new Student() {Id = 1, FullName = "Aliyev Vali"}, "college"},
//    {new Student() {Id = 2, FullName = "Madiyev Ilyos" }, "college" },
//    {new Student() {Id = 3, FullName = "Alimov Halim" }, "university" },
//};

//var newdict = dictioanry.Where(x => x.Value == "college");

//foreach (var dict in newdict)
//    Console.WriteLine(dict.Key.FullName);



//public class Student
//{
//    public int Id { get; set; }
//    public string FullName { get; set; }
//}

//---------- HashSet ---------

//using System.Diagnostics;

//var hashset = new HashSet<int>();
//var linkedlist = new LinkedList<int>(); 
//var list = new List<int>();


//var time = Stopwatch.StartNew();

//for(int i = 0; i < 10000000; i++)
//    hashset.Add(i);

////foreach(var item in hashset)
////    Console.WriteLine(item);

//time.Stop();
//Console.WriteLine(time.Elapsed.TotalSeconds.ToString());

//time = Stopwatch.StartNew();

//for (int i = 0; i < 10000000; i++)
//    linkedlist.AddLast(i);

////foreach (var item in linkedlist)
////    Console.WriteLine(item);

//time.Stop();
//Console.WriteLine(time.Elapsed.TotalSeconds.ToString());

//time = Stopwatch.StartNew();

//for (int i = 0; i < 10000000; i++)
//    list.Add(i);

////foreach (var item in linkedlist)
////    Console.WriteLine(item);

//time.Stop();
//Console.WriteLine(time.Elapsed.TotalSeconds.ToString());

//---------- queue -------

using System.Collections;

var queue = new Queue<int>();
for(int i = 0; i < 10; i++)
    queue.Enqueue(i);

RemoveCenter(5, queue);
foreach(int i in queue)
    Console.WriteLine(i);

d


void RemoveCenter<T>(int index, Queue<T> queue)
{
    if(index < 0 || index >= queue.Count) throw new IndexOutOfRangeException();

    T[] array = new T[queue.Count];
    queue.CopyTo(array, 0);
    queue.Clear();
    for(int i = 0; i < array.Length; i++)
    {
        if(i == index) continue;
        queue.Enqueue(array[i]);
    }
}