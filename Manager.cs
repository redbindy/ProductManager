using System.Diagnostics;
using System.Linq;

namespace ProductManager
{
    public class Manager
    {
        const int CAPACITY = 128;
        const string FILE_PATH = "./products.txt";

        private static Manager mInstance;
        public static Manager Instance
        {
            get
            {
                if (mInstance == null)
                {
                    mInstance = new Manager();
                }

                return mInstance;
            }
        }

        private PriorityQueue<Product, DateTime> mProducts;

        private Manager()
        {
            mProducts = new PriorityQueue<Product, DateTime>(CAPACITY);
            readData();
        }

        public void AddProduct(Product product)
        {
            Debug.Assert(product != null);

            mProducts.Enqueue(product, product.Date);
            saveData();
        }

        public void RemoveProduct()
        {
            while (mProducts.Count != 0
                && (DateTime.UtcNow.AddHours(9) - mProducts.Peek().Date).TotalDays > 2)
            {
                mProducts.Dequeue();
            }

            saveData();
        }

        public void RemoveProduct(string productName)
        {
            PriorityQueue<Product, DateTime> copiedProducts = new PriorityQueue<Product, DateTime>(CAPACITY);

            while (mProducts.Count != 0)
            {
                Product product = mProducts.Dequeue();

                if (product.Name != productName)
                {
                    copiedProducts.Enqueue(product, product.Date);
                }
            }

            mProducts = copiedProducts;

            saveData();
        }

        public List<Product> GetProducts()
        {
            readData();

            List<Product> retProducts = new List<Product>(CAPACITY);
            PriorityQueue<Product, DateTime> copiedProducts = new PriorityQueue<Product, DateTime>(CAPACITY);

            while (mProducts.Count != 0)
            {
                Product product = mProducts.Dequeue();

                retProducts.Add(product);
                copiedProducts.Enqueue(product, product.Date);
            }

            mProducts = copiedProducts;

            return retProducts;
        }

        private void saveData()
        {
            using (StreamWriter sw = new StreamWriter(FILE_PATH))
            {
                PriorityQueue<Product, DateTime> copiedProduct = new PriorityQueue<Product, DateTime>(CAPACITY);

                while (mProducts.Count != 0)
                {
                    Product product = mProducts.Dequeue();

                    int year = product.Date.ToLocalTime().Year;
                    int month = product.Date.ToLocalTime().Month;
                    int day = product.Date.ToLocalTime().Day;

                    sw.WriteLine($"{product.Name} {year} {month} {day}");

                    copiedProduct.Enqueue(product, product.Date);
                }

                mProducts = copiedProduct;
            }
        }

        private void readData()
        {
            if (!File.Exists(FILE_PATH))
            {
                return;
            }

            using (StreamReader sr = new StreamReader(FILE_PATH))
            {
                mProducts.Clear();

                while (!sr.EndOfStream)
                {
                    string data = sr.ReadLine();

                    string[] dataSet = data.Split(" ");

                    string name = dataSet[0];
                    int year = int.Parse(dataSet[1]);
                    int month = int.Parse(dataSet[2]);
                    int day = int.Parse(dataSet[3]);

                    Product product = new Product(name, new DateTime(year, month, day));

                    mProducts.Enqueue(product, product.Date);
                }
            }
        }
    }
}
