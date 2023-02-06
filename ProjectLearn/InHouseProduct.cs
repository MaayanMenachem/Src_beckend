namespace DefaultNamespace;
class InHouseProduct : Product
{ 
    
    //constractor
    public InHouseProduct(double discount) : base(discount)
    {
    }
public override double getDiscount()
{
    this.applyExtraDiscount();
    return discount;
};

public void applyExtraDiscount()
{
    discount = discount * 1.5;
}
}
