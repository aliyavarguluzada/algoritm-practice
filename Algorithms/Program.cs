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


Console.WriteLine("Enter width:");
int width = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter length:");
int length  = Convert.ToInt32(Console.ReadLine()); 

int area = width * length;
int perimeter = width + length;
Console.WriteLine("Perimeter is: " + perimeter);
Console.WriteLine("area is: " + area);