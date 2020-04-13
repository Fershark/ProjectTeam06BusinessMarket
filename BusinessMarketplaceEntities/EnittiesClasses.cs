using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessMarketplaceEntitiesNS
{
    [Table("Businesses")]
    public partial class Business
    {
        public Business()
        {
            Products = new HashSet<Product>();
            Orders = new HashSet<Order>();
        }

        [DisplayName("Business ID")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        [DisplayName("Name")]
        public string Name { get; set; }

        [Required]
        [StringLength(100)]
        [DisplayName("Address")]
        public string Address { get; set; }

        [Required]
        [Index(IsUnique = true)]
        [StringLength(50)]
        [DisplayName("Email")]
        public string Email { get; set; }

        [Required]
        [DisplayName("Is Admin")]
        public bool IsAdmin { get; set; }

        public virtual ICollection<Product> Products { get; set; }
        public virtual ICollection<Order> Orders { get; set; }

        public override string ToString()
        {
            return Id + ": " + Name;
        }
    }

    [Table("Products")]
    public partial class Product
    {
        public Product()
        {
            Orders = new HashSet<Order>();
        }

        [DisplayName("Product ID")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        [DisplayName("Name")]
        public string Name { get; set; }

        [Required]
        [StringLength(250)]
        [DisplayName("Description")]
        public string Description { get; set; }

        [Required]
        [DisplayName("QuantityInStock")]
        public int QuantityInStock { get; set; }

        [Required]
        [DisplayName("Price")]
        public decimal Price { get; set; }

        [Required]
        [DisplayName("Business ID")]
        [ForeignKey("Business")]
        public int BusinessId { get; set; }
        public virtual Business Business { get; set; }

        [Required]
        [DisplayName("Category ID")]
        [ForeignKey("Category")]
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }

        public virtual ICollection<Order> Orders { get; set; }

        //Used to display the price formatted
        [NotMapped]
        [DisplayName("Price")]
        public string PriceString
        {
            get
            {
                return Price.ToString("c");
            }
        }

        //Used to display only the category name only
        [NotMapped]
        [DisplayName("Category")]
        public string CategoryName
        {
            get
            {
                if (Category != null)
                    return Category.Name;
                return "";
            }
        }

        //Used to display only the business name only
        [NotMapped]
        [DisplayName("Business")]
        public string BusinessName
        {
            get
            {
                if (Business != null)
                    return Business.Name;
                return "";
            }
        }

        public override string ToString()
        {
            return Id + ": " + Name;
        }
    }

    [Table("Categories")]
    public partial class Category
    {
        public Category()
        {
            Products = new HashSet<Product>();
        }

        [DisplayName("Category ID")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        [DisplayName("Name")]
        public string Name { get; set; }

        [Required]
        [StringLength(100)]
        [DisplayName("Description")]
        public string Description { get; set; }

        public virtual ICollection<Product> Products { get; set; }

        public override string ToString()
        {
            return Id + ": " + Name;
        }
    }

    [Table("Orders")]
    public partial class Order
    {
        public Order()
        {
            Products = new HashSet<Product>();
        }

        [DisplayName("Order ID")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [DisplayName("Order Date")]
        public DateTime OrderDate { get; set; }

        //Used to display the order date formatted
        [NotMapped]
        [DisplayName("Order Date")]
        public string OrderDateString
        {
            get
            {
                return OrderDate.ToString("yyyy-MM-dd HH:mm");
            }
        }


        [Required]
        [DisplayName("Total Price")]
        public decimal TotalPrice { get; set; }

        //Used to display the total price formatted
        [NotMapped]
        [DisplayName("Total Price")]
        public string TotalPriceString
        {
            get
            {
                return TotalPrice.ToString("c");
            }
        }

        [Required]
        [DisplayName("Business ID")]
        [ForeignKey("Business")]
        public int BusinessId { get; set; }
        public virtual Business Business { get; set; }

        public virtual ICollection<Product> Products { get; set; }

    }

    /// <summary>
    /// Temporary class used to display the product in the current and past orders
    /// </summary>
    public class ProductInOrder
    {
        [DisplayName("Name")]
        public string Name { get; set; }

        [DisplayName("Category")]
        public string CategoryName { get; set; }

        [DisplayName("Business")]
        public string BusinessName { get; set; }

        [DisplayName("Quantity")]
        public int Quantity { get; set; }

        [DisplayName("Price")]
        public string Price { get; set; }

        public Product Product { get; set; }

        public ProductInOrder(Product product)
        {
            Name = product.Name;
            BusinessName = product.BusinessName;
            CategoryName = product.CategoryName;
            Price = product.PriceString;
            Quantity = 1;
            Product = product;
        }
    }
}
