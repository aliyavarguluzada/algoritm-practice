//Task •Ədədin kubunu göstərən proqram yazın.

//using System.Reflection.Metadata.Ecma335;

//string cubeNumber = Console.ReadLine();

//int cubeNum;

//bool cubeCase = int.TryParse(cubeNumber, out cubeNum);


//for (int i = 0; i < 2; i++)
//{
//    int opCube = cubeNum *= cubeNum;
//    Console.WriteLine(opCube);
//}


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



Console.WriteLine("Enter the first angle");
string angle1 = Console.ReadLine();
int angle_1;
bool case1 = int.TryParse(angle1 , out angle_1);


Console.WriteLine("Enter the second angle");

string angle2 = Console.ReadLine();
int angle_2;
bool case2 = int.TryParse(angle2, out angle_2);

int triangle = angle_1 + angle_2;

int angle_3 = 180 - (angle_1 + angle_2);

if (triangle > 180)
{
    Console.WriteLine("the sum of a triangle cannot exceed 180 degrees");
    return;
}
else
{
    Console.WriteLine("The 3rd angle is " + angle_3);
}










