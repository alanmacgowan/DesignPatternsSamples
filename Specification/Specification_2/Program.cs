using Specification_2;

//Based on https://www.codeproject.com/Articles/670115/Specification-pattern-in-Csharp

List<Mobile> mobiles = new List<Mobile>
{
    new Mobile(BrandName.Samsung, MobileType.Smart, 700),
    new Mobile(BrandName.Apple, MobileType.Smart, 800),
    new Mobile(BrandName.Htc, MobileType.Basic),
    new Mobile(BrandName.Samsung, MobileType.Basic)
};

ISpecification<Mobile> samsungExpSpec = new ExpressionSpecification<Mobile>(o => o.BrandName == BrandName.Samsung);
ISpecification<Mobile> htcExpSpec = new ExpressionSpecification<Mobile>(o => o.BrandName == BrandName.Htc);
ISpecification<Mobile> SamsungAndHtcSpec = samsungExpSpec.And(htcExpSpec);

ISpecification<Mobile> SamsungHtcExpSpec = samsungExpSpec.Or(htcExpSpec);
ISpecification<Mobile> NoSamsungExpSpec = new ExpressionSpecification<Mobile>(o => o.BrandName != BrandName.Samsung);

ISpecification<Mobile> brandExpSpec = new ExpressionSpecification<Mobile>(o => o.Type == MobileType.Smart);
ISpecification<Mobile> premiumSpecification = new PremiumSpecification<Mobile>(600);
ISpecification<Mobile> complexSpec = (samsungExpSpec.Or(htcExpSpec)).And(brandExpSpec);
ISpecification<Mobile> linqNonLinqExpSpec = NoSamsungExpSpec.And(premiumSpecification);

Console.WriteLine("\n***Samsung mobiles*****\n");

var result = mobiles.FindAll(o => samsungExpSpec.IsSatisfiedBy(o));
result.ForEach(o => Console.WriteLine(o.GetDescription()));

Console.WriteLine("\n*****Htc mobiles********\n");

result = mobiles.FindAll(o => htcExpSpec.IsSatisfiedBy(o));
result.ForEach(o => Console.WriteLine(o.GetDescription()));

Console.WriteLine("\n****Htc and samsung mobiles*******\n");

result = mobiles.FindAll(o => SamsungHtcExpSpec.IsSatisfiedBy(o));
result.ForEach(o => Console.WriteLine(o.GetDescription()));

Console.WriteLine("\n****Not samsung*******\n");

result = mobiles.FindAll(o => NoSamsungExpSpec.IsSatisfiedBy(o));
result.ForEach(o => Console.WriteLine(o.GetDescription()));

Console.WriteLine("\n****Htc and samsung mobiles (only smart)*******\n");

result = mobiles.FindAll(o => complexSpec.IsSatisfiedBy(o));
result.ForEach(o => Console.WriteLine(o.GetDescription()));

Console.WriteLine("\n****All premium mobile phones*******\n");

result = mobiles.FindAll(o => premiumSpecification.IsSatisfiedBy(o));
result.ForEach(o => Console.WriteLine(o.GetDescription()));


Console.WriteLine("\n****All premium mobile phones except samsung*******\n");

result = mobiles.FindAll(o => linqNonLinqExpSpec.IsSatisfiedBy(o));
result.ForEach(o => Console.WriteLine(o.GetDescription()));

Console.ReadLine();
