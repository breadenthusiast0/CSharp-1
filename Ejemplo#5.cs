interface IMusica
{
    void Tocar();
}

class Instrumento
{
    public void Afinar()
    {
        Console.WriteLine("Afinando el instrumento");
    }
}

class Piano : Instrumento, IMusica
{
    public void Tocar()
    {
        Console.WriteLine("Tocando el piano");
    }
}