using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;
using static System.Console;

Person bob = new Person("Bob", 45);
(string name1, int age1) = bob;
WriteLine(name1);
WriteLine(age1);
bob.Print();

class Person
{
    string name;
    int age;
    public Person(string name, int age)
    {
        this.name = name;
        this.age = age;
    }
    public void Deconstruct(out string personName ,out int personAge)//это деконструктор- Ключевое слово out
        //делает вывод слова во вне разрывает поля класса и выводит слова по отдельности это нужно для работы с файлами
    {
        personName = name;
        personAge = age;
    }
    public void Print()
    {
        WriteLine($"Имя:{name} Возраст: {age}");
    }
}

/*class Program
{
    static void Main(string[] args)
    {
        Person Bob = new Person("Bob", 45);
        (string name, int age) = Bob;
        WriteLine(name);
        WriteLine(age);
        Bob.Print();
    }
}*/
//Пространство имен
/*using Base.PersonTypes;
Base.OrganisationTypes.Company microsoft = new("Microsoft");
Person Ivan = new("Ivan", microsoft);
Ivan.Print();
namespace Base
{
    namespace PersonTypes
    {
        class Person
        {
            string name;
            OrganisationTypes.Company company;
            public Person(string name, OrganisationTypes.Company company)
            {
                this.name = name;
                this.company = company;
            }
            public void Print()
            {
                WriteLine($"Имя: {name} ");
                company.Print();
            }
        }
    }
    namespace OrganisationTypes
    {
        class Company
        {
            string title;
            public Company(string title) => this.title = title;// =>Лямда опертор это аналог фигурных скобок если в 
//методе есть всего одна строка
            public void Print() => WriteLine($"Название компании: {title}");
        }
    }
// get=>name == get{return name;}
// required - это модификатор поля с обязательной записью т.е в этой переменой обязательна инициализация
}*/
//модификаторы доступа

/*class State//все равно, что internal State
{
    string defaultVar = "default";//все равно, что private string
    private string privateVar = "private"; //поле доступно только из текущего класса
    //доступно из текущего класса и производных классов, которые определены в этом проекте
    protected private string protectedPrivateVar = "protected private";
    protected string protectedVar = "protected";//доступно из текущего класса и производных классов
    internal string internalVar = "internal";//доступно в любом месте текущего проекта
    //доступно в любом месте текущего проекта и из классов-наследников в других проектах
    protected internal string protectedInternalVar = "protected internal";
    public string publicVar = "public";//доступно в любом месте программы, а так же для других программ и сборок
    void Print() => WriteLine(defaultVar);
    private void PrintPrivate() => WriteLine(privateVar);
    protected private void PrintProtectedPrivate() => WriteLine(protectedPrivateVar);
    protected void PrintProtected() => WriteLine(protectedVar);
    internal void PrintInternal() => WriteLine(internalVar);
    protected internal void PrintProtectedInternal() => WriteLine(protectedInternalVar);
    public void PrintPublic() => WriteLine(publicVar);
}*/

//Блок init
/*Person person = new() {Name="Bred"};
//person.Name = "Ted";
WriteLine(person.Name);
WriteLine(person.Email);
//первый способ
/*public class Person
{
    public string Name { get; init; } = "Undefined";
}*/
//второй способ
/*public class Person
{
    public Person(string name) => Name = name;
    public string Name { get; init; }
}*/
//третий способ
/*public class Person
{
    public string Name { get; init; } = "";
}*/

//четвертый способ
/*public class Person
{
    string name = "";
    public string Name
    {
        get { return name; }
        init
        {
            name = value;
            Email = $"{value}@gmail.com";
        }
    }
    public string Email { get; init; }
}*/
//required С#11
/*Person ted = new Person() { Name = "Ted", Age = 22 };
public class Person
{

    public required string Name { get; set; }
    public required int Age { get; set; }
}*/