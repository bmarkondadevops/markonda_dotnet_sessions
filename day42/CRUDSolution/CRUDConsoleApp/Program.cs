using CRUDLibrary;

CRUDOperation curdOperation = new CRUDOperation();

// Inserting a new product
Products newProduct = new Products { ProductName = "pens", Price = 5.00m };
curdOperation.InsertProduct(newProduct);

// Reading all products
List<Products> allProducts = curdOperation.GetAllProducts();

foreach (var product in allProducts)
{
    Console.WriteLine($"ID: {product.ProductID}, Name: {product.ProductName}, Price: {product.Price}");
}


//// Updating an existing product
Products updatedProduct = allProducts[0];
updatedProduct.Price = 89.99m;
curdOperation.UpdateProduct(updatedProduct);


// Deleting a product by ID
int productIdToDelete = allProducts[0].ProductID;

//curdOperation.DeleteProduct(productIdToDelete);

Console.WriteLine("Product deleted successfully.");

Console.ReadKey();
