namespace Generieken;

internal struct Complex<W, V>
{
    public W Real { get; set; }
    public V Imaginary { get; set; }

    public override string ToString()
    {
        return $"({Real} + {Imaginary}i)";
    }
}
