// DZ Lesson5(2)

const string Title1 = "1 КОФЕ СТАНДАРТНЫЙ";
const double Price1 = 69.00;
const double Number1 = 1.00;
const double Amount1 = 69.00;
Console.WriteLine("Название\t\tЦена\tКол.\tСумма");
Console.WriteLine($"{Title1}\t{Price1}\t{Number1}\t{Amount1}");

const string Title2 = "НДС с рассчитанной \nставкой 18%";
const double Amount2 = 10.53;
Console.WriteLine($"{Title2}\t\t\t\t{Amount2}");

const string Title3 = "2 РУЛЕТ-СПРИНГ ТВ ИЗ ";
const double Price3 = 70.00;
const double Number3 = 1.00;
const double Amount3 = 70.00;
Console.WriteLine($"{Title3}\t{Price3}\t{Number3}\t{Amount3}\t");
Console.WriteLine("КУ");
const string Title4 = "НДС с рассчитанной\nставкой 10%";
const double Amount4 = 6.36;
Console.WriteLine($"{Title4}\t\t\t\t{Amount4}\n");

Console.WriteLine("ИТОГО:\t\t\t\t\t139.00");

const double Means = 139.00;
const double NDS18 = 10.53;
const double NDS10 = 6.36;
Console.WriteLine($"Электронные средства\t\t\t{Means}");
Console.WriteLine($"НДС итога чека с\t\t\t{NDS18}");
Console.WriteLine("рассчитанной ставкой\n18%");
Console.WriteLine($"НДС итога чека с\t\t\t{NDS10}");
Console.WriteLine("рассчитанной ставкой\n10%");

Console.WriteLine("ВИД НАЛОГООБЛОЖЕНИЯ: ОСН");
const double REGNUMBER = 0000143873023483;
Console.WriteLine($"РЕГ.НОМЕР ККГ:{REGNUMBER}");
Console.WriteLine("ЗАВОД.№:");
const double FN = 8710000100265168;
const double FD = 6026;
const double FPD = 3322278314;
Console.WriteLine($"ФН №:{FN}");
Console.WriteLine($"ФД №:{FD}");
Console.WriteLine($"ФПД №:{FPD}");











