
using Spectre.Console;

namespace PoS.EntityFrameWork.TheCsharpAcademy  // 2 Create class
{
    internal class ProductController
    {
        internal static void AddProduct(Product product)
        {
            using var db = new ProductContext();
            db.Add(product);
            db.SaveChanges();
        }

        internal static void DeleteProduct(Product product)
        {
            using var db = new ProductContext();
            db.Remove(product);
            db.SaveChanges();
        }

        internal static List<Product> GetProducts()
        {
            using var db = new ProductContext();
            var products = db.products.ToList<Product>();

            return products;
        }

        internal static Product GetProductsById(int id)
        {
            using var db = new ProductContext();
            var product = db.products.SingleOrDefault(x => x.Id == id);

            return product;
        }

        internal static void UpdateProduct(Product product)
        {
            using var db = new ProductContext();
            db.Update(product);
            db.SaveChanges();
        }
        internal static void Quit()
        {
            throw new NotImplementedException();
        }

    }
}
