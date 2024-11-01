using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversionPrinciple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //IOdemeServisi nakitOdeme = new NakitOdemeServisi();
            //OdemeIslemleri odemeIslemleri = new OdemeIslemleri(nakitOdeme);
            //odemeIslemleri.OdemeYap(123456);

            //Console.ReadKey();  

            Console.WriteLine("*******************************");

            IOdemeServisi paypalOdeme = new PaypalOdemeServisi();
            OdemeIslemleri odemeIslemleri = new OdemeIslemleri(paypalOdeme);
            odemeIslemleri.OdemeYap(123456);

            Console.ReadKey();
        }
    }

    // YANLIŞ ÖRNEK
    #region Yanlış Örnek
    //public class PaypalOdemeServisi
    //{
    //    public void OdemeYap()
    //    {

    //    }
    //}
    //public class OdemeIslemleri : PaypalOdemeServisi
    //{
    //    private readonly PaypalOdemeServisi _paypalOdemeServisi;
    //    public OdemeIslemleri()
    //    {
    //        _paypalOdemeServisi = new PaypalOdemeServisi(); // Doğrudan bir bağımlılık
    //    }
    //    public void OdemeYap()
    //    {
    //        _paypalOdemeServisi.OdemeYap();
    //    }
    //} 
    #endregion

    // DOĞRU KULLANIM

    public interface IOdemeServisi
    {
        void OdemeYap(decimal tutar);
    }
    public class PaypalOdemeServisi : IOdemeServisi
    {
        public void OdemeYap(decimal tutar)
        {
            Console.WriteLine("Paypal ödemesi");
        }
    }
    public class NakitOdemeServisi : IOdemeServisi
    {
        public void OdemeYap(decimal tutar)
        {
            Console.WriteLine("Nakit ödeme");
        }
    }
    public class OdemeIslemleri
    {
        private readonly IOdemeServisi _odemeServisi;
        public OdemeIslemleri(IOdemeServisi odemeServisi)
        {
            _odemeServisi = odemeServisi;
        }
        public void OdemeYap(decimal tutar)
        {
            _odemeServisi.OdemeYap(tutar);
        }
    }
}
