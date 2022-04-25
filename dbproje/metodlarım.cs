using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dbproje;

namespace dbproje
{
    public class metodlarım
    {
        public static void HataKaydı(Exception ex)
        {
            string strPath = @"C:\Users\aleyn\Documents\Log.txt";
            if (!File.Exists(strPath))
            {
                File.Create(strPath).Dispose();
            }
            using (StreamWriter sw = File.AppendText(strPath))
            {
                sw.WriteLine("=============Hata Kaydı==========="); //Error Logging
                sw.WriteLine("===========oluşma zamanı============= " + DateTime.Now); //start
                sw.WriteLine("hata mesajı: " + ex.Message); //error message
                sw.WriteLine("Stack Trace: " + ex.StackTrace);
                sw.WriteLine("===========Bitiş zamanı============= " + DateTime.Now); //end
            }
        }

    }
}
