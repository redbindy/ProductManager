using System.Diagnostics;

namespace ProductManager
{
    public class Product
    {
        public string Name { get; }
        public DateTime Date { get; }

        public Product(string name, DateTime date)
        {
            Debug.Assert(name != null);

            Name = name;
            Date = date;
        }

        public ProductDTO toDTO()
        {
            return new ProductDTO(this);
        }

        public struct ProductDTO
        {
            public String Name { get; }
            public int Year { get; }
            public int Month { get; }
            public int Day { get; }

            public ProductDTO(string name, int year, int month, int day)
            {
                Debug.Assert(name != null);

                Name = name;
                Year = year;
                Month = month;
                Day = day;
            }

            public ProductDTO(Product product)
            {
                Name = product.Name;
                Year = product.Date.Year;
                Month = product.Date.Month;
                Day = product.Date.Day;
            }
        }
    }
}
