using System;

Console.WriteLine();
Console.WriteLine("1. 기본 튜플 반환");

(int, int) Tally() => (12, 3);

var t = Tally();
Console.WriteLine($"합계: {t.Item1}, 개수: {t.Item2}");



Console.WriteLine();
Console.WriteLine("2. 반환 튜플에 이름 지정");

(int Sum, int Count) Calculate() => (45, 6);

var c = Calculate();
Console.WriteLine($"합계: {c.Item1}, 개수: {c.Item2}");



Console.WriteLine();
Console.WriteLine("3. 표현식 본문으로 간결하게 작성");

(int first, int second) GetPair() => (100, 200);
var tuple = GetPair();
Console.WriteLine($"{tuple.first}, {tuple.second}");



Console.WriteLine();
Console.WriteLine("4. 최솟값과 최댓값 반환");

(int min, int max) FindMinMax(int[] nums)
{
    int minValue = int.MaxValue;
    int maxValue = int.MinValue;

    foreach (int num in nums)
    {
        if (num < minValue) minValue = num;
        if (num > maxValue) maxValue = num;
    }

    return (minValue, maxValue);
}

var minMax = FindMinMax(new[] { 5, 2, 8, 1, 9, 3 });
Console.WriteLine($"최솟값: {minMax.min}, 최댓값: {minMax.max}");



Console.WriteLine();
Console.WriteLine("5. 기본값 반환");

(int, int) ZeroZero() => default;
var zero = ZeroZero();
Console.WriteLine($"{zero.Item1}, {zero.Item2}");



Console.WriteLine();
Console.WriteLine("6. 분해 기본");

var tuple1 = ("Bob", 23);
(string name, int age) = tuple1;
Console.WriteLine($"이름: {name}");
Console.WriteLine($"나이: {age}");



Console.WriteLine();
Console.WriteLine("7. var를 사용한 분해");

var (sum, count) = Tally();
Console.WriteLine($"Sum: {sum}, Count: {count}");



Console.WriteLine();
Console.WriteLine("8. 기존 변수에 분해");

var tuple2 = ("Alice", 30);
(name, age) = tuple2;
Console.WriteLine($"{name}, {age}");



Console.WriteLine();
Console.WriteLine("9. 무시 패턴 (_)");

var tuple3 = ("Bob", 23, 'M');
(_, age, _) = tuple3;
Console.WriteLine($"나이: {age}");