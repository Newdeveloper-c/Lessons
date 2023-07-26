using Tuple;

(int, string) vt1 = new();

vt1.Item1 = 1;
vt1.Item2 = "sdfas";

Console.WriteLine(vt1);

Tuple<int, string> vt2 = new(1, "234");
//vt2.Item1 = 2;

ValueTuple<SampleClass> spc = new ();

var result = (Sum: 0, Count: 0F);

var smp = SampleClass.GetSample();

var anonimObject = new { Name = "Tom", Age = 12 };
