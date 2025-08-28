using Udemy_Session_12.Entities;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Udemy_Session_12.Services
{
    internal class ContractService
    {
        private readonly IPaymentService _paymentService;

        public ContractService(IPaymentService paymentService)
        {
            _paymentService = paymentService;
        }

        public void ProcessContract(Contract contract, int months)
        {
            double basicQuota = contract.TotalValue / months;

            for (int i = 1; i <= months; i++)
            {
                DateOnly dueDate = contract.Date.AddMonths(i);
                double quota = basicQuota + _paymentService.Interest(basicQuota, i);
                double fee = _paymentService.PaymentFee(quota);

                quota += fee;

                contract.Installments.Add(new Installment(dueDate, quota));
            }
        }
    }
}
