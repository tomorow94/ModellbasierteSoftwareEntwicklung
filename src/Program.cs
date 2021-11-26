// See https://aka.ms/new-console-template for more information

using ModellbasierteSoftwareEntwicklung.GenericsExamples;
using ModellbasierteSoftwareEntwicklung.src.GenericsExamples;

Console.WriteLine("Modellbasierte Software Entwicklung : Generics in C#!");

char key = 'x';

while (key!='0')
{
	Console.WriteLine();
	Console.WriteLine("1 : print 'Check' examples");
	Console.WriteLine("0 : exit");
	Console.WriteLine();
	key = Console.ReadKey().KeyChar;
	switch (key)
	{
		case '1':
			CheckExamples.Print();
			break;
		default:
			break;
	}
}

