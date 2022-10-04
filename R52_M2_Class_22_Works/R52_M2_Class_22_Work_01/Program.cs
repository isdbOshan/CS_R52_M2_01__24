using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R52_M2_Class_22_Work_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Member> list = new List<Member>
            {
                new Member{ Id=1, Name="M1", JoinDate=new DateTime(2019,11, 11)},
                new Member{ Id=2, Name="M2", JoinDate=new DateTime(2018,8,3)},
                new Member{ Id=3, Name="M3", JoinDate=new DateTime(2020,4, 5)},
                new Member{ Id=4, Name="M4", JoinDate=new DateTime(2021,3, 7)},
                new Member{ Id=5, Name="M5", JoinDate=new DateTime(2019,2, 7)}
            };
            list.OrderByDescending(x=> x.JoinDate)
                .ToList()
                .ForEach(x=> Console.WriteLine($"{x.Name}, {x.JoinDate:yyyy-MM-dd}"));
            Console.ReadLine();
        }
    }
    public class Member
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime JoinDate { get; set; }
        
    }
}
