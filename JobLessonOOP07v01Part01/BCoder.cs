using System.Linq;

namespace JobLessonOOP07v01Part01
{
    class BCoder : ICoder
    {
        /// <summary>
        /// Метод кодирования строки с заменой i-й позиции, на букву на i-й позиции с конца алфавита
        /// </summary>
        /// <param name="encode">Строка для кодирования</param>
        /// <returns>Возвращает закодированную строку</returns>
        public string Encode(string encode)
        {
            string symbols = " !@#$%^&*()!№;%:?<>|/{}[]-_=+";
            string encodeText = "";
            for (int i = 0; i < encode.Length; i++)
            {
                if (symbols.Contains(encode[i]))
                {
                    encodeText += encode[i];
                }
                //рус прописные
                if ((char)encode[i] > 1039 && (char)encode[i] < 1072)
                {
                    if ((char)encode[i] > 1039 && (char)encode[i] < 1055)
                        encodeText += (char)(1040 + 31 - (encode[i] - 1040));
                    else encodeText += (char)(1071 - 31 - (encode[i] - 1071));
                }
                //рус строчные
                if ((char)encode[i] > 1071 && (char)encode[i] < 1104)
                {
                    if ((char)encode[i] > 1071 && (char)encode[i] < 1087)
                        encodeText += (char)(1072 + 31 - (encode[i] - 1072));
                    else encodeText += (char)(1103 - 31 - (encode[i] - 1103));
                }
                //eng прописные
                if ((char)encode[i] > 64 && (char)encode[i] < 91)
                {
                    if ((char)encode[i] > 64 && (char)encode[i] < 78)
                        encodeText += (char)(65 + 25 - (encode[i] - 65));
                    else encodeText += (char)(90 - 25 - (encode[i] - 90)); 
                }
                //eng строчные
                if ((char)encode[i] > 96 && (char)encode[i] < 123)
                {
                    if ((char)encode[i] > 96 && (char)encode[i] < 123)
                        encodeText += (char)(97 + 25 - (encode[i] - 97));
                    else encodeText += (char)(122 - 25 - (encode[i] - 122));
                }
            }
            return encodeText;
        }
        public string Decode(string decode)
        {
            return Encode(decode);
        }
    }
}
