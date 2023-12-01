Student stas = new Student("Сильверхенд Д.Д", 2077, "ТЮТЮнина 13", 89996662288, 8, "Программист");
Student vi = new Student("Киану Ч.Р. ", 1999, "КУКУнина 23", 89869487562, 7, "уборщик");
Student ponam = new Student("Уик Д.К.", 2014, "МУМУкина 90", 89008947683, 6, "коллектор");
Student[] mass = new Student[] { stas, vi, ponam };
for (int i = 0; i < mass.Length; i++){
    Console.WriteLine($"Ф.И.О. Студентa - {mass[i].fio}");
}
Console.WriteLine("Введите факультет -  Программист или уборщик или коллектор");
string facyltet = Convert.ToString(Console.ReadLine());
for (int i = 0; i < mass.Length; i++){
    if (mass[i].faculty == facyltet){
        Console.WriteLine($"Студент заданного факультета - {mass[i].fio}");
    }
}
Console.WriteLine("Введите нужный год");
int dAtA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(" Список студентов , поступивших после заданного года:");
for (int i = 0; i < mass.Length; i++){
    if (mass[i].data > dAtA){
        Console.WriteLine($"{mass[i].fio}, ");
    }
}
class Student{
    private string FIO;
    private int Data;
    private string Address;
    private long PhoneNumber;
    private int Course;
    private string Faculty;
    public Student(string FIO, int Data, string Address, long PhoneNumber, int Course, string Faculty){
        this.FIO = FIO;
        this.Data = Data;
        this.Address = Address;
        this.PhoneNumber = PhoneNumber;
        this.Course = Course;
        this.Faculty = Faculty;
    }
    public string fio{
        get{
            return FIO; // чтение Ф.И.О
        }
        set{
            FIO = value; // Запись Ф.И.О.
        }
    }
    public int data{
        get{
            return Data; // Чтение даты поступления
        }
        set{
            Data = value; // Запись даты поступления
        }
    }
    public string address{
        get{
            return Address; // Чтение адресса
        }
    }
    public long phonenumber{
        get{
            return PhoneNumber;  // Чтение номера телефон
        }
        set{
            PhoneNumber = value; // Запись номера телефона
        }
    }
    public int course{
        set{
            Course = value;  // Запись курсов
        }
    }
    public string faculty{
        get {
            return Faculty;  // Чтение  факультета
        }
    }
}
