using System;
using System.Collections.Generic;

void AddItem(List<(string name, int quantity, int price)> inventory, string name, int quantity, int price)
{
    inventory.Add((name, quantity, price));
}

(string name, int price) FindMostExpensive(List<(string name, int quantity, int price)> inventory)
{
    string name = inventory[0].name;
    int price = inventory[0].price;

    foreach (var item in inventory)
    {
        if (item.price > price)
        {
            name = item.name;
            price = item.price;
        }
    }

    return (name, price);
}

(int totalValue, int totalCount) CalculateTotal(List<(string name, int quantity, int price)> inventory)
{
    int totalValue = 0;
    int totalCount = 0;

    foreach (var item in inventory)
    {
        totalValue += item.price * item.quantity;
        totalCount += item.quantity;
    }

    return (totalValue, totalCount);
}

List<(string name, int quantity, int price)> inventory = new();

AddItem(inventory, "체력 포션", 3, 500);
AddItem(inventory, "마나 포션", 5, 800);
AddItem(inventory, "해독제", 2, 300);
AddItem(inventory, "엘릭서", 1, 5000);

Console.WriteLine("=== 아이템 인벤토리 ===");
foreach (var item in inventory)
{
    Console.WriteLine($"{item.name} - 수량: {item.quantity}개, 단가: {item.price}원");
}


Console.WriteLine();
Console.WriteLine("=== 가장 비싼 아이템 ===");
var mostExpensiveItem = FindMostExpensive(inventory);
Console.WriteLine($"이름: {mostExpensiveItem.name}, 단가: {mostExpensiveItem.price}원");


Console.WriteLine();
Console.WriteLine("=== 인벤토리 합산 ===");
var inventoryTotal = CalculateTotal(inventory);
Console.WriteLine($"총 가치: {inventoryTotal.totalValue}원");
Console.WriteLine($"총 아이템 수: {inventoryTotal.totalCount}개");