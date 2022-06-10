using TestEx;

#region задание 1
Array1A arr1A = new Array1A();
arr1A.calcCW();
arr1A.calcArr();

Array1B arr1B = new Array1B();
arr1B.calcArr();
#endregion

#region задание 2
//RecFunc rec = new RecFunc();
//rec._fibcalc();
//rec._pow();
#endregion

#region задание 3
//HashTable contacts = new HashTable();
//contacts.Insert("Мельникова Ксения Витальевна", "+375296457898");
//contacts.Insert("Иванова София Ивановна", "+375297653578");
//contacts.Insert("Пименов Максим Евгеньевич", "+375296458461");
//contacts.Insert("Богословский Артем Михайлович", "+375298453233");
//contacts.Insert("Сапсай Иван Алексеевич", "+375293357595");
//contacts.Insert("Храмова Полина Дмитриевна", "+375291278954");
//contacts.Insert("Власова Мария Борисовна", "+375291328945");
//contacts.Insert("Казанцева Елизавета Александровна", "+375291569875");

//void change()
//{
//    contacts.ShowContscts(contacts);
//    int numcheck(string? tmp)
//    {
//        if (!int.TryParse(tmp, out int num) || !(num > 0 && num < 5))
//        {
//            Console.WriteLine("Введите число от 1 до 4");
//            num = numcheck(Console.ReadLine());
//            return num;
//        }
//        else return num;
//    }
//    Console.WriteLine(@"Справочник контактов, выберите действие:
//1 - добавить номер контакта в справочник.
//2 - редактировать контакт.
//3 - поиск контакта.
//4 - удалить контакт.");

//    int usserCh = numcheck(Console.ReadLine());
//    string? fio;
//    string? number;
//    switch (usserCh)
//    {
//        case 1:
//            Console.WriteLine("Введите ФИО:");
//            fio = Console.ReadLine();
//            Console.WriteLine("Введите номер телефона:");
//            number = Console.ReadLine();
//            contacts.Insert(fio, number);
//            break;
//        case 2:
//            Console.WriteLine("Введите ФИО:");
//            fio = Console.ReadLine();
//            Console.WriteLine("Введите номер телефона:");
//            number = Console.ReadLine();
//            contacts.Edit(fio, number);
//            break;
//        case 3:
//            Console.WriteLine("Введите ФИО:");
//            fio = Console.ReadLine();
//            contacts.Search(fio);
//            break;
//        case 4:
//            Console.WriteLine("Введите ФИО:");
//            fio = Console.ReadLine();
//            contacts.Delete(fio);
//            break;
//    }
//    change();
//}

//change();
#endregion

#region задание 4

//Func func = new Func();
//void figure ()
//{
//    Console.WriteLine(@"
//Фигуры, выберите действие:
//1 - создать фигуру (квадрат, прямоугольник, ромб, круг).
//2 - проверить существование фигуры.
//3 - узнать площадь фигуры.
//4 - узнать периметр фигуры.");

//    double usserCh = func.ussercheck(Console.ReadLine());
//    int select;


//    switch (usserCh)
//    {
//        case 1:
//            func.createFigure(func.selectFigure());
//            break;
//        case 2:
//            func.checkEx(func.selectFigure());
//            break;
//        case 3:
//            select = func.selectFigure();
//            if (func.checkEx(select, true, false)) Console.WriteLine($"\r\nПлощадь фигуры = {func.Figures[select].square()}.");
//            break;
//        case 4:
//            select = func.selectFigure();
//            if (func.checkEx(select, true, false)) Console.WriteLine($"\r\nПлощадь фигуры = {func.Figures[select].perimeter()}.");
//            break;
//    }
//    figure();
//}
//figure();
#endregion