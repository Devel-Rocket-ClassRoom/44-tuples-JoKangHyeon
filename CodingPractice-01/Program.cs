using System;
using System.Net.Cache;

Console.WriteLine();
Console.WriteLine("## 1. 튜플 리터럴");

var tuple = ("Bob", 23);
Console.WriteLine(tuple.Item1);
Console.WriteLine(tuple.Item2);



Console.WriteLine();
Console.WriteLine("### 2-1. 같은 타입의 튜플");

var tuple1 = (12, 34, 56);
Console.WriteLine($"{tuple1.Item1}, {tuple1.Item2}, {tuple1.Item3}");



Console.WriteLine();
Console.WriteLine("### 2-2. 서로 다른 타입의 튜플");

var tuple2 = ("Hello", 100, true, 3.14);
Console.WriteLine($"{tuple2.Item1}, {tuple2.Item2}, {tuple2.Item3}, {tuple2.Item4}");



Console.WriteLine();
Console.WriteLine("### 3-1. 기본 명시적 타입");

(string, int) tuple3 = ("Alice", 25);
Console.WriteLine($"{tuple3.Item1}, {tuple3.Item2}");



Console.WriteLine();
Console.WriteLine("### 3-2. 이름이 있는 명시적 타입");

(ushort Width, ushort Height) tuple4 = (1920, 1080);
Console.WriteLine($"해상도: {tuple4.Width} x {tuple4.Height}");



Console.WriteLine();
Console.WriteLine("## 4. 튜플의 값 타입 특성");

var tuple5 = ("Bob", 23);
var tuple6 = tuple5;
tuple6.Item1 = "Joe";

Console.WriteLine($"원본: ({tuple5.Item1}, {tuple5.Item2})");
Console.WriteLine($"복사본: ({tuple6.Item1}, {tuple6.Item2})");



Console.WriteLine();
Console.WriteLine("## 5. 생성 시 이름 지정");

var tuple7 = (Name: "Bob", Age: 23);
Console.WriteLine(tuple7.Name);
Console.WriteLine(tuple7.Age);
Console.WriteLine(tuple7.Item1);
Console.WriteLine(tuple7.Item2);



Console.WriteLine();
Console.WriteLine("## 6. 요소 이름 지정 예제");

var tuple8 = (Name: "철수", IsStudent: true, OrderPrice: 1000);
Console.WriteLine($"{tuple8}(학생: {tuple8.IsStudent}) - 주문: {tuple8.OrderPrice}원");



Console.WriteLine();
Console.WriteLine("## 7. 타입 선언에서 이름 지정");

(string name, int age, char gender) tuple9 = ("Bob", 23, 'M');
Console.WriteLine($"이름: {tuple9.name}");
Console.WriteLine($"나이: {tuple9.age}");
Console.WriteLine($"성별: {tuple9.gender}");



Console.WriteLine();
Console.WriteLine("## 8. 요소 이름 자동 추론\r\n");

DateTime date = DateTime.Now;
var tuple10 = (date.Day, date.Month, date.Year);
Console.WriteLine($"일: {tuple10.Day}");
Console.WriteLine($"월: {tuple10.Month}");
Console.WriteLine($"년: {tuple10.Year}");