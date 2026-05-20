/*bool flag = true;
int value = 2;
int suma = 0;
if (flag)
{
    
    Console.WriteLine($"Inside the code block: {value}");
}
value = 10;
//Console.WriteLine($"Outside the code block: {value}");*/


/*int[] numbers = { 4, 8, 15, 16, 23, 42 };
int total = 0;
bool found = false;
foreach (int number in numbers)
{
 
    total += number;

    if (number == 42)  found = true;

}

if (found)     Console.WriteLine("Set contains 42");

Console.WriteLine($"Total: {total}");*/

/*int employeeLevel = 100;
string employeeName = "John Smith";

string title = "";

switch (employeeLevel)
{
    case 100:
    case 200:
        title = "Senior Associate";
        break;
    case 300:
        title = "Manager";
        break;
    case 400:
        title = "Senior Manager";
        break;
    default:
        title = "Associate";
        break;
}

Console.WriteLine($"{employeeName}, {title}");*/

// SKU = Stock Keeping Unit. 
// SKU value format: <product #>-<2-letter color code>-<size code>
/*string sku = "01-MN-L";

string[] product = sku.Split('-');

string type = "";
string color = "";
string size = "";

switch (product[0])
{
    case "01":
        type = "Sweat shirt";
        break;
    case "02":
        type = "T-Shirt";
        break;
    case "03":
        type = "Sweat pants";
        break;
    default:
        type = "Other";
        break;
}

switch (product[1])
{
    case "BL":
        color = "Black";
        break;
    case "MN":
        color = "Maroon";
        break;
    default:
        color = "White";
        break;
}


switch (product[2])
{
    case "S":
        size = "Small";
        break;
    case "M":
        size = "Medium";
        break;
    case "L":
        size = "Large";
        break;
    default:
        size = "One Size Fits All";
        break;
}

Console.WriteLine($"Product: {size} {color} {type}");*/


/*for (int i = 0; i < 10; i++)
{
    Console.WriteLine(i);
}*/

/*for (int i = 10; i >= 0; i--)
{
    Console.WriteLine(i);
}*/

/*for (int i = 0; i < 10; i += 3)
{
    Console.WriteLine(i);
}*/

/*for (int i = 0; i < 10; i++)
{
    Console.WriteLine(i);
    if (i == 7) break;
}*/

/*string[] names = { "Alex", "Eddie", "David", "Michael" };
for (int i = names.Length - 1; i >= 0; i--)
{
    Console.WriteLine(names[i]);
}*/

/*string[] names = { "Alex", "Eddie", "David", "Michael" };
foreach (var name in names)
{
    // Can't do this:
    if (name == "David") name = "Sammy";
}
*/
/*string[] names = { "Alex", "Eddie", "David", "Michael" };
for (int i = 0; i < names.Length; i++)
    if (names[i] == "David") names[i] = "Sammy";

foreach (var name in names) Console.WriteLine(name);*/