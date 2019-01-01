using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebService_TcknDogrulama
{
    class Program
    {
        static void Main(string[] args)
        {
        loop:
            bool flag = false;
            try
            {
                Console.Write("T.C. Kimlik Numarasını Giriniz: ");
                string Tckn = Console.ReadLine();

                Console.Write("İsim Giriniz: ");
                string isim = Console.ReadLine();

                Console.Write("İsim Giriniz: ");
                string soyad = Console.ReadLine();

                Console.Write("Doğum Yılını Giriniz(Örnek:1990): ");
                int dogumYili = int.Parse(Console.ReadLine());

                webService_tcknDogrulama.KPSPublic tcknDogrula = new webService_tcknDogrulama.KPSPublic();
                bool result = tcknDogrula.TCKimlikNoDogrula(Convert.ToInt64(Tckn), isim.ToUpper().Trim(), soyad.ToUpper().Trim(), dogumYili);
                if (result == true) Console.WriteLine("\nT.C. KİMLİK NUMARASI DOĞRU !!!");
                else Console.WriteLine("\nT.C. KİMLİK NUMARASI YANLIŞ !!!");


                Console.Write("\nYeniden İşlem Yapmak İster Misiniz? (E/H): ");
                string again = Console.ReadLine();

                if (again == "e" || again == "E")
                {
                    Console.Clear();
                    flag = true;
                    goto loop;
                }
                else
                {
                    flag = false;
                }

                if (flag == false) goto son;

            }
            catch (Exception ex)
            {
                Console.WriteLine("\n\nBİLİNMEYEN HATA OLUŞTU !!!\n HATA MESAJI: " + ex.ToString() + "");
            }
            Console.ReadKey();
        son: ;
        }
    }
}
