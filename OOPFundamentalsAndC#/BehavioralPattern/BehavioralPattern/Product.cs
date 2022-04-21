namespace BehavioralPattern
{
    public class Product
    {
        private Guid _id;
        private decimal _finalPrice;
        private TaxContext _taxContext;
        private decimal _price;
        public Product(Guid id ,decimal price,TaxContext taxContext)
        {
            _id = id;
            _price = price;
            _taxContext = taxContext;
            _finalPrice = taxContext.CalculatePriceAfterTaxes(price);
        }
        public Guid Id { get { return _id; } }
        public string ?Name { get; set; }
        public string? CompanyName { get; set; }
        public string? Description { get; set; }
        public decimal Price { get { return _price; } }
        public TaxContext TaxContext { get { return _taxContext; } }
        public decimal FinalPrice { get { return _finalPrice; }}

        public override string ToString()
        {
            return $"Product:{Id} Name:{Name} produced by: {CompanyName} description:{Description} has price before tax:{Price} and price after tax:{FinalPrice}";
        }

    }
}