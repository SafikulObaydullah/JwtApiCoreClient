namespace CRUD_Repository_Ajax.ViewModel
{
   public class ProductVM
   {
      public int Id { get; set; }
      public string ProductCode { get; set; }
      public string ProductName { get; set; }
      public decimal UnitPrice { get; set; }
      public ICollection<SalesDetailVM> SalesDetails { get; set; }
   }
}
