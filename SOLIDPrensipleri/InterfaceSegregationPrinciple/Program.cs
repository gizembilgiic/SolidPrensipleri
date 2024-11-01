using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregationPrinciple
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
    // YANLIŞ ÖRNEK
    #region Yanlış Örnek
    //public interface ITicaretServisi
    //{
    //    void SiparisIsle();
    //    void MusteriSikayetYonet();
    //    void UrunStokGuncelle();
    //}
    //public class MusteriServisi : ITicaretServisi
    //{
    //    public void MusteriSikayetYonet()
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public void SiparisIsle()
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public void UrunStokGuncelle()
    //    {
    //        throw new NotImplementedException();
    //    }
    //} 
    #endregion


    // DOĞRU ÖRNEK
    public interface ISiparisIslemeServisi
    {
        void SiparisIsle();
    }
    public interface IMusteriHizmetleriServisi
    {
        void MusteriSikayetYonet();
    }
    public interface IUrunYonetimServisi
    {
        void UrunStokGuncelle();
    }
    public class MusteriHizmetleri : IMusteriHizmetleriServisi
    {
        public void MusteriSikayetYonet()
        {
            throw new NotImplementedException();
        }
    }
}