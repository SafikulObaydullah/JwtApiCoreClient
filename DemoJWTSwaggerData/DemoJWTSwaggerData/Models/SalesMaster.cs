using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoJWTSwaggerData.Models
{
   public class SalesDetail
   {
      public int Id { get; set; }
      [ForeignKey("SalesMaster")]
      public int SalesMasterID { get; set; }
      [ForeignKey("Product")]
      public int ProductID { get; set; }

      public decimal TotalPrice { get; set; }
      public decimal Qty { get; set; }
      public SalesMaster SalesMaster { get; set; }
      [ValidateNever]
      public Product Product { get; set; }
   }

   public class SalesMaster
   {
      public SalesMaster()
      {
         SalesDetails = new HashSet<SalesDetail>();
      }
      public int Id { get; set; }
      public string InvoiceNO { get; set; }
      //public int ProductID { get; set; }
      public DateTime SalesDate { get; set; }
      public decimal TotalPrice { get; set; }
      public decimal TotalQty { get; set; }
      [ValidateNever]
      public ICollection<SalesDetail> SalesDetails { get; set; }
   }

   public class Product
   {
      public int Id { get; set; }
      public string ProductCode { get; set; }
      public string ProductName { get; set; }
      public decimal UnitPrice { get; set; }
      [ValidateNever]
      public ICollection<SalesDetail> SalesDetails { get; set; }
   }
}
