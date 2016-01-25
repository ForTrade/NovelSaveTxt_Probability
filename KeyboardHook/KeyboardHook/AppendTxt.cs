using System;
using System.Collections.Generic;
using System.Text;

namespace KeyboardHook
{
    class AppendTxt
    {
        public static void Out(string cutN, string words)
        {
            System.IO.File.AppendAllText(
                string.Format("D:\\{0}--{1}.txt", DateTime.Now.ToString("yyyyMMdd"), cutN),
                string.Format("\t{0}\r\n", words),
                Encoding.Default
                );
        }
    }
}
