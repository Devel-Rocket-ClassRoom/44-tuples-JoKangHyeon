using System;
using System.Collections.Generic;

Console.WriteLine();
Console.WriteLine("1. Equals 메서드");
var tuple1 = (1, 2);
var tuple2 = (1, 2);
var tuple3 = (3, 4);

Console.WriteLine(tuple1.Equals(tuple2));
Console.WriteLine(tuple1.Equals(tuple3));



Console.WriteLine();
Console.WriteLine("2. == 및 != 연산자");

Console.WriteLine(tuple1 == tuple2);
Console.WriteLine(tuple1 != tuple2);



Console.WriteLine();
Console.WriteLine("3. 타입 호환성 - 기본");

var tuple4 = ("Alice",25);
(string, int) tuple5 = tuple4;

Console.WriteLine($"{tuple5.Item1}, {tuple5.Item2}");



Console.WriteLine();
Console.WriteLine("4. 타입 호환성 - 주의사항");
(string name, int age, char sex) tuple6 = ("Bob", 23, 'M');
(string age, int sex, char name) tuple7 = tuple6;

Console.WriteLine(tuple7.age);
Console.WriteLine(tuple7.sex);
Console.WriteLine(tuple7.name);



Console.WriteLine();
Console.WriteLine("5. 제네릭과 튜플 - 리스트");

List<(string name, int age)> names = new List<(string name, int age)>()
{
    ("Alice",25),
    ("Bob",30),
    ("Charlie",35)
};

foreach (var name in names)
{
    Console.WriteLine($"{name.name}: {name.age}세");
}



Console.WriteLine();
Console.WriteLine("6. 딕셔너리의 키로 튜플 사용");

Dictionary<(int x, int y), string> dict = new()
{
    { (0, 0), "원점" },
    { (0, 1), "오른쪽" }
};

Console.WriteLine(dict[(0, 0)]);
Console.WriteLine(dict[(0, 1)]);



Console.WriteLine();
Console.WriteLine("7. System.Tuple 클래스");

Tuple<string,int> oldTuple1 = new Tuple<string, int>("Bob", 23);
var oldTuple2 = Tuple.Create("Alice", 25);

Console.WriteLine($"{oldTuple1.Item1}, {oldTuple1.Item2}");
Console.WriteLine($"{oldTuple2.Item1}, {oldTuple2.Item2}");