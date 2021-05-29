using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CriptBySergo
{
    public class Cript
    {
        /**
         * Алгоритм для (де-)шифрование данных
         * KEY по умолчанию = 2021.
         * 
         */

        public static string Encode(string Text, int Key = 2021)
        {
            char[] arr = Text.ToCharArray();
            var encrypt = "";

            for ( int i = 0; i < arr.Length; i++ )
                encrypt += ( arr[i] * Key ).ToString() + '-';
            return encrypt;
        }

        public static string Decode(string Text, int Key = 2021)
        {
            string[] arr = Text.Split('-');
            var decrypt = "";

            for ( int i = 0; i < arr.Length - 1; i++ )
                decrypt += ( ( char )( Convert.ToInt32(arr[i]) / Key ) ).ToString();
            return decrypt;
        }
    }
}
