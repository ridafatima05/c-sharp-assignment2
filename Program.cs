// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

//Q1

double discount = 0,discountAmount = 0;
int totalAmount = 0;
Console.WriteLine("Enter your Customer Type: 1. For Registered Customer 2. For Non-Registered Customer");
int customerType = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("How many transactions you have made this month?");
int transactions = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i<= transactions; i++)
{
    Console.WriteLine($"Enter amount of transaction: {i}");
    int amount = Convert.ToInt32(Console.ReadLine());
    totalAmount += amount;
}
switch (customerType){
    case 1:
    if (totalAmount > 200000){
        Console.WriteLine("You are eligible for 5.5% discount");
        discount = 0.055;
    }
    else if (totalAmount > 100000){
        Console.WriteLine("You are eligible for 5% discount");
        discount = 0.05;
    }
    else{
        Console.WriteLine("You are eligible for 3.5% discount");
        discount = 0.035;
    }
    break;
    case 2:
    if (totalAmount > 50000){
        Console.WriteLine("You are eligible for 2% discount");
        discount = 0.02;
    }
    else{
        Console.WriteLine("You are not eligible for any discount");
        discount = 0;
    }
    break;
    default:
    Console.WriteLine("Invalid customer type");
    discount = 0;
    break;
}
discountAmount = totalAmount * discount;
double finalAmount = totalAmount - discountAmount;
Console.WriteLine($"Total amount before discount: {totalAmount}");
Console.WriteLine($"Discount: {discount * 100}%");
Console.WriteLine($"Discount amount: {discountAmount}");
Console.WriteLine($"Total amount after discount: {finalAmount}");            

//q3:
Console.WriteLine("Enter total number of Patients:");
int n = Convert.ToInt32(Console.ReadLine());

string[] names = new string[n];
int[] age = new int[n];
string[] symptoms = new string[n];

for (int i = 0; i < n; i++)
{
    Console.WriteLine($"Enter the name of pateint {i+1}:");
    names[i] = Console.ReadLine();
    Console.WriteLine($"Enter the age of {names[i]}: ");
    age[i] = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter the Symptoms:");
    symptoms[i] = Console.ReadLine();
}

Console.WriteLine("\n--- All Patients Admitted ---");
for (int i = 0; i < n; i++)
{
    Console.WriteLine($"Patient {i + 1}: Name: {names[i]}, Age: {age[i]}, Symptoms: {symptoms[i]}");
}


//q4:
//MEDICATION REMINDER SYSTEM:
Console.WriteLine("Enter the number of medications to schedule:");
int n = Convert.ToInt32(Console.ReadLine());

string[] med_names = new string[n];
string[] schedules = new string[n];

for (int i = 0; i<n; i++)
{
    Console.WriteLine($"Enter details for Medication {i+1}:");
    med_names[i] = Console.ReadLine();
    Console.WriteLine($"Enter schedules/time for {med_names[i]}:");
    schedules[i] = Console.ReadLine();
}
Console.WriteLine("\n--- Medication Reminders ---");
for (int i = 0; i < n; i++)
{
    Console.WriteLine($"Reminder: Take {med_names[i]} as per schedule {schedules[i]}.");
}

//q5:
int chap = 3;
int section = 5;

for (int i = 1; i <= chap; i++)
{
    Console.WriteLine($"Chapter {i}");
    for (int j = 1; j<= section; j++)
    {
        Console.WriteLine($"Section {i}.{j}");

    }
    Console.WriteLine("\n");
}


int[,] arr1 = {
    {3, 4, 5},
    {6, 7, 9},
    {5, 6, 8},
    {6, 4, 4}
};

int[,] arr2 = {
    {6, 4, 2, 4},
    {5, 2, 3, 7},
    {7, 6, 4, 8}
};

int rows1 = arr1.GetLength(0);
int cols1 = arr1.GetLength(1);
int rows2 = arr2.GetLength(0);
int cols2 = arr2.GetLength(1);

int[,] arr3 = new int[rows1, cols2];       
for (int i = 0; i < rows1; i++)
{
    for (int j = 0; j < cols2; j++)
    {
        arr3[i, j] = 0;
        for (int k = 0; k < cols1; k++)
        {
            arr3[i, j] += arr1[i, k] * arr2[k, j];
        }
    }
}
Console.WriteLine("Array 3:");
for (int i = 0; i < rows1; i++)
{
    for (int j = 0; j < cols2; j++)
    {
        Console.Write(arr3[i, j] + "\t");
    }
        Console.WriteLine();
}
