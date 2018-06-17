using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace T4
{
    class Program
    {
        static void Main(string[] args)
        {
            Tenpower.Model.DTO.DevDoc aa = new Tenpower.Model.DTO.DevDoc() {  Author="ssss", DateInfo=DateTime.Now.Date, Id=Guid.NewGuid()};
            Tenpower.Model.DevDoc a2 = new Tenpower.Model.DevDoc();
            aa.AutoMap(a2);
            a2.Title = "郭美美";
            a2.AutoMap(aa);
            Console.ReadLine();
        }
    }
}
