namespace Udemy_Session_12.Services
{
    internal class PaypalService : IPaymentService
    {
        private const double PaymentFeeRate = 0.01;
        private const double InterestRate = 0.02;

        public double PaymentFee(double amount)
        {
            return amount * PaymentFeeRate;
        }

        public double Interest(double amount, int month)
        {
            return amount * InterestRate * month;
        }
    }
}
