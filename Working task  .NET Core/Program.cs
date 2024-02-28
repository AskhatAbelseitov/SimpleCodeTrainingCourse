using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

int[] myArray = { 1, 10, 18, 290, 890, 345 };


Index index1 = new Index(1);
Index index2 = new Index(2);

Range range = new Range(index1, index2);

Console.WriteLine(myArray[range]);
