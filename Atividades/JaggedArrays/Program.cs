// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int[][] numbers =
new int[4][];


numbers[0] = new int[] { 1, 2, 3, 4 };
numbers[1] = new int[] { 4 };
numbers[2] = new int[] { 5, 6, 7, 8, 9 };
numbers[3] = new int[] { 6, 5, 4 };


int[][] numbers2 =

{
new int[] { 1 },
new int[] { 2 },
new int[] { 3 },
new int[] { 4 }
};
//loop encadeado para percorrer jeguearray
//contador, flag, acumulador

for (int i = 0; i < numbers.Length; i++)
{
    Console.Write("[");
    for (int j = 0; j < numbers[i].Length; j++)
    {
        Console.Write($"{numbers[i][j]}");
    }
    Console.Write("]");
}
;

