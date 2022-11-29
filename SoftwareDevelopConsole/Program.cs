using ..приложения.проекта.на.SBeregovoy.SoftDevelop.Persistance.;
using SBeregovoy.SoftDevelop.Domain;
using SBeregovoy.SoftDevelop.Persistance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBeregovoy.SoftDevelop.SoftwareDevelopConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello");
        }
    }
}



//Часть 2....0.Cоздаем проект - project name->SoftwareDevelopConsole, Solution name-> SBeregovoy.SoftWareDevelop
//1) Нужно добавить зависимости(новый проект):
//1.1.Кликаем на Solution и кликаем на Add -> New Project
//1.2. Определяем его в class library
//1.3. namespace-> Domain(но на самом деле туда должно было быть наименование
//"SBeregovoy.SoftDeveloper")
//1.3.1. Кликаем в SoftDevelopConsole и нажимаем на Properties и переименоваваем
//на SBeregovoy.SoftDevelop.SoftDevelopConsole(Assebly и Default)
//1.4. Тоже самое делаем в Domain -> SBeregovoy.SoftDevelop.Domain
//1.5) Для проверки кликаем на на SoftDevelopConsole --> add --> Class

//(SBeregovoy -> Наш личный namespace, SoftwareDevelop-> namespace приложения, SoftwareDevelopConsole-> 
//namespace проекта )

//2. в SoftwareDevelopConsole -> Program.cs корректируем
//namespace на SBeregovoy.SoftDevelop.SoftDevelopConsole
//3. в Domain тоже самое

//4. Создаем еще одина проект(хранилище) -> library class (.NET Standard)
//4.1. name -> Persistance
//4.2. Properties-> namespace SBeregovoy.SoftDevelop.Persistance

//5. Создаем unit тесты-> SoftwareDevelopTests
//5.1. Properties -> SBeregovoy.SoftDevelop.SoftwareDevelopTests
//5.2. namespace -> SBeregovoy.SoftDevelop.SoftwareDevelopTests


//ЗАВИСИМОСТИ:
//6. Domain -> тот проект, который будет везде использоваться
//6.1. Persistance -> add -> Project Reference -> Domain(галочка)
//6.2. SoftDevelopConsole-> Project Reference -> Domain и Persistance
//6.3. SoftwareDevelopTests -> Project Reference -> Domain и Persistance

//ПРОВЕРКА НА ТЕСТЫ:
//Test-> run all tests(нужно чтоб они правильно скомпилировались)

//7.В Domain -> class1.cs переименовываем на Person.cs(class тоже)
//8. в Program.cs добавляем Person для проверки, и каким образом он его выводит (Person person)
//9. using Domain и Persistance

//_______________________________________________________________
//ВЫВОД:
//Domain -> отвечает за хранение базовых объектов(бизнес логика)
//Persistance -> отвечает за хранение

//______________________________________________________________
//ОТВЕТЫ: Переименование папки также будет зависеть на class.... Framework и Core = они отличаются,
//но не значительно


//===========================================================
//ЧАСТЬ 3
//1. Что такое base
//2. public (statc), private-> модификаторы
//- если стоит static, нет необходимости создавать объект класса, а если static нет, то стоит 
//создавать экземпляр класса. Со static - Он доступен для всех экземпляров!!!
//3. public const byte <---???
//4. Property Decimal <--- 14:40
//5. get и set
//6. Наследование
//7. List <>
//8. Установка Property