using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
namespace BaiThucHanh1402.Models
{
    public class Giaiptb1
    {
        static void Main(string[] args)

        {

            

            double a, b, x;

            Console.Write("Nhap a = "); a = Double.Parse(Console.ReadLine());

            Console.Write("Nhap b = "); b = Double.Parse(Console.ReadLine());

            if (a == 0)

            {

                if (b == 0) Console.WriteLine("Phuong trinh co vo so nghiem");

                else Console.WriteLine("Phuong trinh vo nghiem");

            }

            else

            {

                x = (-b / a);

                Console.WriteLine("Phuong trinh co nghiem duy nhat x = " + x);

            }

            Console.ReadLine();

        }

    }

}

    