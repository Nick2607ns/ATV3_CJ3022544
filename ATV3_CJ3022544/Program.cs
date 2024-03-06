// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//questão 1

int n;

Console.WriteLine("Digite um numero");
n = int.Parse(Console.ReadLine());
if (n % 2 == 0)
{
    Console.WriteLine("o numero é par");


}
else {
    Console.WriteLine("o numero é impar");

}

//Questão 2

int lad1, lad2, lad3;

Console.WriteLine("digite o 1 lado do triangulo");
    lad1 = int.Parse(Console.ReadLine());

Console.WriteLine(" digite o 2 lado triangulo");
lad2 = int.Parse(Console.ReadLine());

Console.WriteLine(" digite o 3 lafo do triangulo");
lad3 = int.Parse(Console.ReadLine());

if ((lad1 == lad2) && (lad2 == lad3))
{
    Console.WriteLine(" triangulo equilatero");
};
 if ((lad1 == lad2) || (lad2 == lad3) || (lad1 == lad3))
{
    Console.WriteLine(" trianguo isoeles");
}
    Console.WriteLine(" triangulo isoceles");
 if((lad1 != lad2) && ((lad2 != lad3) && (lad1 != lad3)))
{
    Console.WriteLine(" triangulo escaleno");

}

// questão 3

int nc, n1;

Console.WriteLine(" qual numero estou pensand0 entre 1 a 100?");
n1 = int.Parse(Console.ReadLine());


nc = new Random().Next(1, 100);

if (( nc > n1))
{
    Console.WriteLine(" O numero é menor");
}

if ((nc < n1))
{
    Console.WriteLine(" o numero é maior");
}

if ((n1 == nc))
{
        Console.WriteLine(" VOCÊ VENCEU!");
  
}




