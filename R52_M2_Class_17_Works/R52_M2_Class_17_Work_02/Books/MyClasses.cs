using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R52_M2_Class_17_Work_02.Books
{
    public enum Format { PDF, EPub, Kindle }
    public class Book
    {
        public Book() { }
        public Book(string title, decimal price, DateTime publishDate, string category)
        {
            Title = title;
            Price = price;
            PublishDate = publishDate;
            Category = category;
        }

        public string Title { get; set; }
        public decimal Price { get; set; }
        public DateTime PublishDate { get; set; }
        public string Category { get; set; }
        public virtual string Details()
        {
            return $"{Title}, {Category}\nPrice: {Price:0.00}";
        }
    }
    public sealed class PrintBook : Book
    {
        public PrintBook() { }
        public PrintBook(string title, decimal price, DateTime publishDate, string category, decimal shippingCharge):base(title, price, publishDate, category)
        {
            ShippingCharge = shippingCharge;
        }

        public decimal ShippingCharge { get; set; }
        public override string Details()
        {
            return $"{base.Details()} + {ShippingCharge} Ship Charge";
        }

    }
    public sealed class EBook : Book
    {
        public EBook() { }
        public EBook(string title, decimal price, DateTime publishDate, string category, Format format, bool companionCD) : base(title, price, publishDate, category)
        {
            Format = format;
            CompanionCD = companionCD;
        }

        public Format Format { get; set; }
        public bool CompanionCD { get; set; }
        public override string Details()
        {
            return  $"{Title}, {Category} {Format} Format {(CompanionCD ? "with CD" :"")} \nPrice: {Price:0.00}";
        }

    }
}
