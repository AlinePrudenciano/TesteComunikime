namespace ComunikimeTest.Api.Models
{
    public class StockModel : BaseModel
    {
        public StockModel() : base()
        {

        }

        public int ProductId { get; set; }
        public ProductModel Product { get; set; }

        public int Amount { get; set; }
    }
}
