﻿//Task •Ədədin kubunu göstərən proqram yazın.


//int cubeNumber = Convert.ToInt32(Console.ReadLine());


//int result = cubeNumber ** 3;
//Console.WriteLine(result);


//•Düzbucaqlı fiqurumuz var. İstifadəçidən düzbucaqlının eni və uzunluğunu alaraq onun perimetr və sahəsini hesablayan proqram yazın


//Console.WriteLine("Enter width:");
//int width = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("Enter length:");
//int length = Convert.ToInt32(Console.ReadLine());

//int area = width * length;
//int perimeter = width + length;
//Console.WriteLine("Perimeter is: " + perimeter);
//Console.WriteLine("area is: " + area);



/*
 * 
Üçbucağın 2 bucağının qiymətini istifadəçidən alın. 
İstifadəçinin yazdığı dəyər üçbucağın bucaqları cəmindən böyük olarsa o zaman istifadəçidən yenidən dəyər daxil etməsini tələb edin. 
Əgər daxil edilən hər iki dəyər uyğundursa üçbucağın 3cü bucağının ölçüsünü hesablayın. 
Misal: İstifadəçi 50 və 75 daxil edərsə 3cü tərəf 55ə bərabər olacaq.
 */



//Console.WriteLine("Enter the first angle");
//string angle1 = Console.ReadLine();
//int angle_1;
//bool case1 = int.TryParse(angle1, out angle_1);


//Console.WriteLine("Enter the second angle");

//string angle2 = Console.ReadLine();
//int angle_2;
//bool case2 = int.TryParse(angle2, out angle_2);

//int triangle = angle_1 + angle_2;

//int angle_3 = 180 - (angle_1 + angle_2);

//if (triangle > 180)
//{
//    Console.WriteLine("the sum of the angles of a triangle cannot exceed 180 degrees");
//    return;
//}
//else
//{
//    Console.WriteLine("The 3rd angle is " + angle_3);
//}


/*
45,67,89,23,55,88 və 93 rəqəmindən ibarət massivimiz var. 
İstifadəçidən hər hansı bir rəqəm yazmasını tələb edərək həmin rəqəmin massivdə olub olmaması yoxlayın. 
Əgər rəqəm ədəd varsa “xx rəqəmi massivdə var” və ya “xx rəqəmi massivdə yoxdur” şəklində ekrana yazı çıxardın
 */


int[] arrA = { 45, 67, 89, 23, 55, 88, 93 };


int number = Convert.ToInt32(Console.ReadLine());
bool a = false;
for (int i = 0; i < arrA.Length; i++)
{
   if(number == arrA[i])
    {
        a = true;
        break;
    }
}
if(a == false)
{
    Console.WriteLine("Yoxdur");
}
else if(a == true)
{
    Console.WriteLine("Var");
}



//•(8x+45):25-9 sadə düsturuna uyğun funksiya düzəldin. Funksiya x-ı qəbul edərək hesablama aparsın.


//int x = Convert.ToInt32(Console.ReadLine());

//int equation = (8 * x + 45) / 25 - 9;

//Console.WriteLine(equation);



//•ədədin faizini və faizinə görə ədədi tapan funksiya düzəldin.

//

//Console.WriteLine("enter operation number 1 or 2");

//int operation = Convert.ToInt32(Console.ReadLine());



//if (operation == 1)

//{
//    Console.WriteLine("Faizini tapmaq istediyin ededi daxil et");
//    int Number = Convert.ToInt32(Console.ReadLine());
//    Console.WriteLine("Faizi daxil et");
//    int perc = Convert.ToInt32(Console.ReadLine());
//    int percentNumber = Number * perc / 100;
//    Console.WriteLine(percentNumber);

//}
//else if (operation == 2)
//{
//    Console.WriteLine("Faizi daxil et");
//    int percent = Convert.ToInt32(Console.ReadLine());
//    Console.WriteLine("Faiz op alinan ededi daxil et");
//    int byNumber = Convert.ToInt32(Console.ReadLine());

//    int byPerc = byNumber * 100 / percent;
//    Console.WriteLine(byPerc);
//}


//•45,67,234,423,122,43,21,121  rəqəmlərindən ibarət massiv verilmişdir. Bu və bənzəri ədəd massivləri üçün.
// 1) Bütün ədədlərin cəmini tapan funksiya düzəldin.

//int[] newArry = { 45, 67, 234, 423, 122, 43, 21, 121 };


//int result = 0;
//for (int i = 0; i < newArry.Length; i++)
//{
//    result += newArry[i];
//}
//Console.WriteLine(result);

// 2)Ədədlərin ədədi ortasını tapan funksiya düzəldin		

//int average = result / newArry.Length;

//Console.WriteLine(average);

// 3)Massivdəki ədədlərin sayını tapan funksiya düzəldin

//int count = 0;
//for (int i = 0; i < newArry.Length; i++)
//{
//    count += 1;
//}
//Console.WriteLine(count);   



// 4)Massivdə 100dən boyük 200dən kiçik ədədlərin  sayını tapan funksiya düzəldin.


//for (int i = 0; i < newArry.Length; i++)
//{
//    if (newArry[i] > 100 && newArry[i] < 200)
//    {
//        Console.WriteLine(newArry[i]);
//    }
//}



// 5)Massivdəki cüt ədədləri tapan funksiya düzəldin


//for (int i = 0; i < newArry.Length; i++)
//{
//    if (newArry[i] % 2 == 0)
//    {
//        Console.WriteLine(newArry[i]);
//    }
//}



// 6) Massivdəki ən böyük ədədi tapan funksiya düzəldin


//int min = newArry[1];
//for (int i = 0; i < newArry.Length; i++)
//{
//    if (newArry[i] > min)
//    {
//        min = newArry[i];
//    }
//}

//Console.WriteLine(min);
















