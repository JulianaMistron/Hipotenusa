double cateto1, cateto2;

Console.WriteLine("Digite o primeiro cateto:");
cateto1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Digite o segundo cateto:");
cateto2 = Convert.ToDouble(Console.ReadLine());

double hipotenusa = Math.Sqrt((cateto1 * cateto1) + (cateto2 * cateto2));

Console.WriteLine("A hipotenusa é: " + hipotenusa);

Console.ReadLine();