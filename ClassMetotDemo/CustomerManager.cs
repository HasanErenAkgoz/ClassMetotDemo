using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
   public class CustomerManager
    {
        public void Add(Customer customer)
        {
            customer.MusteriAdı = "Eren";
            customer.MusteriSoyad = "Akgöz";
            customer.MusteriMail = "HasanErenAkgz@gmail.com";
            customer.MusteriTc = "111111111";
            Console.WriteLine(customer.MusteriTc+" Eklendi");
        }
        public void Add(int Tc)
        {
            Console.WriteLine(Tc+" Numaralı müşteri silindi");
        }
    }
}
