using System;

(string name, int age, int grade) CreateStudent(string name, int age, int grade) => (name, age, grade);
void PrintStudent((string name, int age, int grade) student) => Console.WriteLine($"{student.name} - 나이: {student.age}세, 학년: {student.grade}학년");

var student1 = CreateStudent("철수", 16, 1);
var student2 = CreateStudent("영희", 17, 2);
var student3 = CreateStudent("민수", 18, 3);

Console.WriteLine("=== 학생 정보 출력 ===");
PrintStudent(student1);
PrintStudent(student2);
PrintStudent(student3);

Console.WriteLine();
Console.WriteLine("=== 첫 번째 학생 분해 ===");
(string name, int age, int grade) = student1;
Console.WriteLine($"이름: {name}");
Console.WriteLine($"나이: {age}");
Console.WriteLine($"학년: {grade}");