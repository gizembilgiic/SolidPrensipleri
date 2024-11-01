using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibility
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }

        public class Urun
        {
            public int Id { get; set; }
            public string Ad { get; set; }
            public decimal Fiyat { get; set; }
        }

        // Yanlış Yaklaşım

        #region Yanlış Yaklaşım
        //public class Urun
        //{
        //    public int Id { get; set; }
        //    public string Ad { get; set; }
        //    public decimal Fiyat { get; set; }




        //    public void UrunEkle()
        //    {
        //        // Ürün ekleme işlemleri
        //    }

        //    public void UrunSil()
        //    {
        //        // Ürün silme işlemleri
        //    }

        //    public void UrunGuncelle()
        //    {
        //        // Ürün güncelleme işlemleri
        //    }

        //    public void UrunRaporuOlustur()
        //    {
        //        // Ürün raporu oluşturma işlemleri
        //    }

        //}
        #endregion

        // DOĞRU KULLANIM

        public class UrunYonetimi
        {
            public void UrunEkle(Urun urun)
            {
                // Ürün ekleme işlemleri
            }

            public void UrunSil(int urunId)
            {
                // Ürün silme işlemleri
            }

            public void UrunGuncelle(Urun urun)
            {
                // Ürün güncelleme işlemleri
            }

        }

        public class UrunRaporYonetimi
        {
            public void UrunRaporuOlustur(List<Urun> urunler)
            {
                // Ürün raporu oluşturma işlemleri
            }
        }
    }
}
