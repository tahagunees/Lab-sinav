public class Productmanager 
{

}


public class ElectronicProduct:Product
{
    // public ElectronicProduct(int id, string productName, double price) : base(id, productName, price)
    // {
    // }

    public Boolean isWireless { get; set; }
    public int warrantyPeriod { get; set; }
    public Boolean getWireless()
    {

    }
    public int getWarrantyPeriod(int value)
    {
        warrantyPeriod = value;
        return warrantyPeriod;
    }
    public void setWireless(Boolean value)
    {
        
    }
    public void setWarrantyPeriod(int value)
    {
        System.Console.WriteLine();
    }
    public ElectronicProduct(int id,string productName, double price,bool isWireless,int warrantyPeriod):base(id, productName,price)
    {
        
        
    }
}public class ElectronicProduct:Product
{
    // public ElectronicProduct(int id, string productName, double price) : base(id, productName, price)
    // {
    // }

    public Boolean isWireless { get; set; }
    public int warrantyPeriod { get; set; }
    public Boolean getWireless()
    {

    }
    public int getWarrantyPeriod(int value)
    {
        warrantyPeriod = value;
        return warrantyPeriod;
    }
    public void setWireless(Boolean value)
    {
        
    }
    public void setWarrantyPeriod(int value)
    {
        System.Console.WriteLine();
    }
    public ElectronicProduct(int id,string productName, double price,bool isWireless,int warrantyPeriod):base(id, productName,price)
    {
        
        
    }
}



public class ProductManager
{
    private List<Product> products; // Ürünleri saklamak için bir liste kullanılabilir.

    public ProductManager()
    {
        products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        products.Add(product);
    }

    public int CountProducts()
    {
        return products.Count; // Ürünlerin sayısını döndüren metot.
    }
}
