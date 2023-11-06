namespace SortApp.Models;
public class Product:IComparable,ICloneable
{
    #region //to hide the code block #region and #endregion
    public string? Name { get; set; }
    public double Price { get; set; }
    public Product(string? name, double price)
    {
        Name = name;
        Price = price;
    }

    public Product()
    {
    }
    public override string ToString()
    {
        return $"{Name,-10} - {Price+"$",-10}";
        
    }

    #endregion
    // public int CompareTo(object? obj)
    // {
    //     // throw new NotImplementedException();
    //     // Product other = obj;
    //     // Product other = (Product)obj;
    //     // Product? other = (Product)obj ?? new Product();
    //     Product? other = (Product?)obj ?? new Product();
    //     // Product? other = obj as Product;
    //     return this.Price.CompareTo(other.Price);
        /* if (this.Price<other.Price)
        {
            return 1;
        }
        else if (this.Price==other.Price)
        {
            return 0;
        }
        else{
            return -1;
        } */

    // }

    //ters 
    public int CompareTo(object? obj)
    {
        var k = -1;
        // throw new NotImplementedException();
        // Product other = obj;
        // Product other = (Product)obj;
        // Product? other = (Product)obj ?? new Product();
        Product? other = (Product?)obj ?? new Product();
        // Product? other = obj as Product;
        /* if (this.Price<other.Price)
        {
            return -1;
        }
        else if (this.Price==other.Price)
        {
            return 0;
        }
        else{
            return 1;
        } */
        return k*this.Price.CompareTo(other.Price);
    }

    public object Clone()
    {
        return new Product(){
            Name = this.Name,
            Price = this.Price
        };
    }

    //Isime gore

    /*  public int CompareTo(object? obj)
     {
         var k = -1;
         // throw new NotImplementedException();
         // Product other = obj;
         // Product other = (Product)obj;
         // Product? other = (Product)obj ?? new Product();
         Product? other = (Product?)obj ?? new Product();
         // Product? other = obj as Product;
         /* if (this.Name<other.Name)
         {
             return -1;
         }
         else if (this.Name==other.Name)
         {
             return 0;
         }
         else{
             return 1;
         } 
         return k*this.Name.CompareTo(other.Name);
     } */

}