using CRUDLibrary;

internal class Program
{
    private static void Main(string[] args)
    {
        CRUDOperation curdOperation = new CRUDOperation();

        // Inserting a new product
        Products newProduct = new Products { ProductName = "pens", Price = 5.00m };
        //curdOperation.InsertProduct(newProduct);


        // Reading all products
        List<Products> allProducts = curdOperation.GetAllProducts();

        foreach (var product in allProducts)
        {
            Console.WriteLine($"ID: {product.ProductID}, Name: {product.ProductName}, Price: {product.Price}");
        }


        //// Updating an existing product
        //Products updatedProduct = allProducts[0];

        Console.WriteLine("Enter productId");
        int givenProductId = System.Convert.ToInt32(Console.ReadLine());
        //updatedProduct.Price = 89.99m;
       // curdOperation.UpdateProduct(givenProductId);

        // Deleting a product by ID
        //int productIdToDelete = allProducts[0].ProductID;

        //curdOperation.DeleteProduct(productIdToDelete);
        //curdOperation.DeleteProduct();

      // Console.ReadKey();
    }
}