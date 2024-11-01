using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiscovSubstitutionPrinciple
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }

    // YANLIŞ ÖRNEK

    #region Yanlış Örnek
    //public class Konaklama
    //{
    //    public virtual void SabahKahvaltisi() { }
    //    public virtual void AksamYemegi() { }
    //}
    //public class Oda : Konaklama
    //{
    //    public override void SabahKahvaltisi()
    //    {
    //        // SabahKahvaltisi kahvaltı hizmeti
    //    }
    //    public override void AksamYemegi()
    //    {
    //        throw new NotImplementedException(); // Normal oda servisinde oda servisi yok.
    //    }
    //}
    //public class SuitOda : Konaklama
    //{
    //    public override void SabahKahvaltisi()
    //    {
    //        // SabahKahvaltisi kahvaltı hizmeti
    //    }
    //    public override void AksamYemegi()
    //    {
    //        // Akşam yemeği hizmeti
    //    }
    //} 
    #endregion

    // DOĞRU ÖRNEK

    public abstract class Konaklama
    {
        public abstract void SabahKahvaltisi();
    }
    public class Oda : Konaklama
    {
        public override void SabahKahvaltisi()
        {
            Console.WriteLine("Rezervasyon İşlemleri");
        }
    }
    public class Suit : Konaklama
    {
        public override void SabahKahvaltisi()
        {
            Console.WriteLine("Kahvaltı İşlemleri");
        }
        public void AksamYemegi()
        {
            Console.WriteLine("Akşam yemeği İşlemleri");
        }
    }
}
