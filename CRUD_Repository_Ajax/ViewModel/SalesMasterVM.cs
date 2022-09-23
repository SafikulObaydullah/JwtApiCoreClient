namespace CRUD_Repository_Ajax.ViewModel
{
   public class SalesMasterVM
   {
      public SalesMasterVM()
      {
         SalesDetails = new HashSet<SalesDetailVM>();
      }
      public int Id { get; set; }
      public string InvoiceNO { get; set; }
      //public int ProductID { get; set; }
      public DateTime SalesDate { get; set; }
      public decimal TotalPrice { get; set; }
      public decimal TotalQty { get; set; }

      public ICollection<SalesDetailVM> SalesDetails { get; set; }
   }
}
