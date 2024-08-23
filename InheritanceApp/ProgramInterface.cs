namespace InheritanceApp;

class ProgramInterface
{

    public interface IPaymentProcessor
    {
        void ProcessPayment(decimal amount);
    }

    public class CreditCardProcessor : IPaymentProcessor
    {
        public void ProcessPayment(decimal amount)
        {
            Console.WriteLine("Processint payment of " + amount);
        }
    }

    public class PayPalProcessor : IPaymentProcessor
    {
        public void ProcessPayment(decimal amount)
        {
            Console.WriteLine("Processing paypal payment of " + amount);
        }
    }

    public class PaymentService
    {
        private readonly IPaymentProcessor _processor;

        public PaymentService(IPaymentProcessor processor)
        {
            _processor = processor;
        }

        public void ProcessOrderPayment(decimal amount)
        {
            _processor.ProcessPayment(amount);
        }
    }

    //static void Main(string[] args)
    //{
    //    IPaymentProcessor processPay = new PayPalProcessor();
    //    processPay.ProcessPayment(10);

    //    PaymentService servicePay = new PaymentService(processPay);
    //    servicePay.ProcessOrderPayment(15.0m);
    //}

}

