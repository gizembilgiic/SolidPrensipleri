using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosedPrinciple
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }

    #region Yanlış Örnek
    //// YANLIŞ ÖRNEK
    //public class OdemeIslemleri
    //{
    //    public void Ode(string odemeTuru)
    //    {
    //        if(odemeTuru == "KrediKarti")
    //        {
    //            // Kredi Kartı ile Ödeme İşlemleri
    //        }
    //        else if (odemeTuru == "Nakit")
    //        {
    //            // Nakit ile Ödeme İşlemleri
    //        }
    //        else if (odemeTuru == "Paypal")
    //        {
    //            // Paypal ile Ödeme İşlemleri
    //        }
    //        // Yeni ödeme türü oldukça sınıf değiştirilmek zorunda
    //    }
    //} 
    #endregion

    // DOĞRU ÖRNEK
    public abstract class Odeme
    {
        public abstract void Ode();
    }
    public class KrediKartiIleOdeme : Odeme
    {
        public override void Ode()
        {
            throw new NotImplementedException();
        }
    }
    public class NakitIleOdeme : Odeme
    {
        public override void Ode()
        {
            throw new NotImplementedException();
        }
    }
    public class PaypalIleOdeme : Odeme
    {
        public override void Ode()
        {
            throw new NotImplementedException();
        }
    }
}
