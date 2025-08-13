// See https://aka.ms/new-console-template for more information
using System.Globalization;
using System.Reflection.Metadata;
using Microsoft.VisualBasic;

Console.WriteLine("Hello, World!");

Console.WriteLine("");

Console.WriteLine("qual seu nome");

//  ">?<"  INDICA QUE A VARIAVEL PODE RECEBER VALOR NULO 
//    |
string? name = Console.ReadLine();
Console.WriteLine(
    $"Seja Bem-Vindo {name}"
);


int[] numbers;
numbers = new int[5];

int[] numbers2 = new int[5];

//atribuindo valores para o vetor 

numbers2[0] = 1;
numbers2[1] = 2;
numbers2[2] = 3;
numbers2[3] = 4;
numbers2[4] = 5;

//declarando e inicializando com valores 

int [] numbers3 =
    new int[]{1, 2, 3, 4, 5};

int[] numbers4 = { 1, 2, 3, 4, 5 };
//preenchendo um vetor com os 12 meses do ano

string[] months = new string[12];


for (int i = 1; i <= 12; i++)
{
    DateTime firstDay =
        new DateTime(DateTime.Now.Year, i, 1);

    string monthName = firstDay.ToString(
        "MMMM", CultureInfo.CreateSpecificCulture("EN")
    );

    months[i - 1] = monthName;

}

foreach (var month in months) {
    Console.WriteLine(month);
}

int[,] numbers52 = new int[5, 2];
int[,,] numbers523 = new int[5, 2, 3];

int[, ] nmb = new int[,] {
    { 1,  2, -9},
    { 5,  7, 10},
    { 6,115, 54}
    
    };

int myNumber = nmb[2, 1];
Console.WriteLine("Imprimindo valor da matriz");
Console.WriteLine(myNumber);
