namespace Specification_2
{
    public class Mobile
    {
        public BrandName BrandName { get; set; }
        public MobileType Type { get; set; }
        public int Cost;
        public string GetDescription()
        {
            return "The mobile is of brand : " + this.BrandName + " and of type : " + this.Type;
        }

        public Mobile(BrandName brandName, MobileType type, int cost = 0)
        {
            this.BrandName = brandName;
            this.Type = type;
            this.Cost = cost;
        }
    }

    public enum BrandName
    {
        Samsung,
        Apple,
        Htc
    }

    public enum MobileType
    {
        Basic,
        Smart
    }

}
