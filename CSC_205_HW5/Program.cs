using System;

namespace CSC_205_HW5
{
    public class CaptainCrunch
    {
        public static string Encode(string input, int shift)
        {
            char[] buffer = input.ToCharArray();

            for (int i = 0; i < buffer.Length; i++)
            {
                char letter = buffer[i];

                if (char.IsLetter(letter))
                {
                    char offset = char.IsUpper(letter) ? 'A' : 'a';
                    letter = (char)((letter + shift - offset) % 26 + offset);
                }

                buffer[i] = letter;
            }

            return new string(buffer);
        }

        public static void Main(string[] args)
        {
            // Encode example
            string encoded = Encode("Hello World", 13);
            Console.WriteLine("Encoded: " + encoded);

            // Decode example
            string decoded = Encode(encoded, -13);
            Console.WriteLine("Decoded: " + decoded);
        }
    }
}
