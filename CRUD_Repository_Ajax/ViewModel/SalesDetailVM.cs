using System.ComponentModel.DataAnnotations.Schema;

namespace CRUD_Repository_Ajax.ViewModel
{
   public class SalesDetailVM
   {
      public int Id { get; set; }
      [ForeignKey("SalesMaster")]
      public int SalesMasterID { get; set; }
      [ForeignKey("Product")]
      public int ProductID { get; set; }

      public decimal TotalPrice { get; set; }
      public decimal Qty { get; set; }
      public SalesMasterVM SalesMaster { get; set; }
      public ProductVM Product { get; set; }
   }
}
