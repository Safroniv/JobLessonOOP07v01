using System.Linq;

namespace JobLessonOOP07v01Part01
{
    class ACoder : ICoder
    {
        /// <summary>
        /// Метод кодирования строки с увеличением значения +1
        /// </summary>
        /// <param name="encode">Строка для кодирования</param>
        /// <returns>Возвращает закодированную строку</returns>
        public string Encode(string encode)
        {
            string encodeText = "";
            string symbols = " !@#$%^&*()!№;%:?<>|/{}[]-_=+";
            for (int i = 0; i < encode.Length; i++)
            {
                if (encode[i] == 'я' || encode[i] == 'Я')
                {
                    encodeText += (char)(encode[i] - 31);
                }
                else if (encode[i] == 'z' || encode[i] == 'Z')
                {
                    encodeText += (char)(encode[i] - 25);
                }
                else if (symbols.Contains(encode[i]))
                {
                    encodeText += encode[i];
                }
                else encodeText += (char)(encode[i] + 1);
            }
            return encodeText;

        }
        /// <summary>
        /// Метод декодирования строки с уменьшением значения -1
        /// </summary>
        /// <param name="decode">Строка для декодирования</param>
        /// <returns>Возвращает декодированную строку</returns>
        public string Decode(string decode)
        {
            string decodeText = "";
            for (int i = 0; i < decode.Length; i++)
            {
                if (decode[i] == 'а' || decode[i] == 'А')
                {
                    decodeText += (char)(decode[i] + 31);
                }
                else if (decode[i] == 'a' || decode[i] == 'A')
                {
                    decodeText += (char)(decode[i] + 25);
                }
                else if (decode[i] == ' ' || decode[i] == '!' || decode[i] == '?')
                {
                    decodeText += (char)(decode[i]);
                }
                else
                    decodeText += (char)(decode[i] - 1);
            }
            return decodeText;
        }
    }
}
