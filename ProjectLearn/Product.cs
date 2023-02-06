namespace DefaultNamespace;

class Product
{
    public double discount = 20;

    public  virtual double getDiscount()
    {
        return discount;
    }
}