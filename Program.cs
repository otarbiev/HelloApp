using HelloApp;

Console.WriteLine("Введите число чтобы возвести его в куб: ");
int num = Convert.ToInt32(Console.ReadLine());
int numInCube = num * num;
Console.WriteLine($"{num} в кубе = {numInCube}");


Person ivan = new Person("Ivan", 26);
Person oleg = new Person("Oleg", 55);

oleg.Info();

//ivan.Run удалён
Console.WriteLine("Конфликт стр в мэйн ветке");
