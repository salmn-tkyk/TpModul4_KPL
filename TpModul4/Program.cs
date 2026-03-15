// See https://aka.ms/new-console-template for more information

using TpModul4;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== Output Table-Driven (Kode Pos) ===");

        KodePos.Kelurahan kel1 = KodePos.Kelurahan.Batununggal;
        Console.WriteLine($"Kelurahan: {kel1}, Kode Pos: {KodePos.GetKodePos(kel1)}");

        KodePos.Kelurahan kel2 = KodePos.Kelurahan.Cijaura;
        Console.WriteLine($"Kelurahan: {kel2}, Kode Pos: {KodePos.GetKodePos(kel2)}");

        Console.WriteLine();



        Console.WriteLine("=== Output State-Based (Door Machine) ===");

        DoorMachine pintu = new DoorMachine();

        pintu.BukaPintu();
        pintu.KunciPintu();
    }
}
