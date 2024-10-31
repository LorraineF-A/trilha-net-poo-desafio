using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

internal class Program
{
    private static void Main(string[] args)
    {
        Nokia nok1 = new Nokia("(21)3333-8765", "Nokia-TijoloMASTER", "587889988-98", 4);

        nok1.InstalarAplicativo("XP INVESTIMENTOS");

        Console.WriteLine("\n");

        Iphone ipho1 = new Iphone(numero: "(21)11111-9898",
                                "Iphone-$FacadaMaster",
                                "6548644987-98",
                                3);
        ipho1.InstalarAplicativo("WhatsApp");
    }
}