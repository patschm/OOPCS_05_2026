using System.Diagnostics;
using System.Text;

//string s = "";
StringBuilder s = new StringBuilder();

Stopwatch w = new Stopwatch();

w.Start();
for(int i = 0; i < 100_000; i++)
{
   // s += i;
   s.Append(i.ToString());
}
w.Stop();
System.Console.WriteLine(w.Elapsed);
