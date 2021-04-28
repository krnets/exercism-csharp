public class RailFenceCipher
{
    private readonly int Rails;

    public RailFenceCipher(int rails) => Rails = rails;

    public string Encode(string input) => Transpose(input, true);
    public string Decode(string input) => Transpose(input, false);

    private string Transpose(string input, bool encrypt)
    {
        var transposed = new char[input.Length];

        for (int i = 0, k = 0; i < Rails; i++)
        {
            int pos = i;
            bool down = true;

            while (pos < input.Length)
            {
                if (encrypt)
                    transposed[k++] = input[pos];
                else transposed[pos] = input[k++];

                if (i == 0 || i == Rails - 1)
                    pos += 2 * (Rails - 1);
                else if (down)
                {
                    pos += 2 * (Rails - i - 1);
                    down = false;
                }
                else
                {
                    pos += 2 * i;
                    down = true;
                }
            }
        }

        return string.Concat(transposed);
    }
}