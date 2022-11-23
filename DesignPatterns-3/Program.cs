public interface IPayment
{
    public void Pay();
}

public class Cash : IPayment
{
    public void Pay()
    {
        // Paying with cash...
    }
}

public class CCard : IPayment
{
    public void Pay()
    {
        // Paying with bank card
    }
}


public class Taxi
{
    IPayment? _payment;

    public void GetPayment()
    {
        _payment.Pay();
    }

}

public class Bolt : Taxi
{

}

public class Uber : Taxi
{

}
