namespace ExtensionMethods
{
    using System.Text;

    public static class StringBuilderExtensions
    {
        public static StringBuilder SubString(this StringBuilder input, int index)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = index; i < input.Length; i++)
            {
                sb.Append(input[i]);
            }

            return sb;
        }

        public static StringBuilder SubString(this StringBuilder input, int index, int length)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < length; i++)
            {
                sb.Append(input[index]);
                index++;

                if (index == input.Length)
                {
                    break;
                }
            }

            return sb;
        }
    }
}
