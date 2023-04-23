using System.Diagnostics;

namespace ProductManager
{
    public class Manager
    {
        const int CAPACITY = 128;

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
        }

        public void AddProduct(Product product)
        {
            Debug.Assert(product != null);

            mProducts.Enqueue(product, product.Date);
        }

        public void RemoveProduct()
        {
            while (mProducts.Count != 0
                && (DateTime.UtcNow.AddHours(9) - mProducts.Peek().Date).TotalDays > 2)
            {
                mProducts.Dequeue();
            }
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
        }

        public List<Product> GetProducts()
        {
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
    }
}
