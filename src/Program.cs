using ModellbasierteSoftwareEntwicklung.src;

Console.WriteLine("Modellbasierte Software Entwicklung : Generics in C#!");

Menu menu = new Menu();
char key = 'x';

while (key!='0')
{
	menu.PrintMenu();
	key = menu.HandleMenuInput();
}