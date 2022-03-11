namespace WebApplication4
{
    public class Customer : ICustomer
    {
        //   private readonly IEnumerable<IKafkaCustomer<KafkaCustomerA>> _kafkaCustomer;
        private readonly IKafkaCustomer<KafkaCustomerA> _kafkaCustomerA;
        private readonly IKafkaCustomer<KafkaCustomerB> _kafkaCustomerB;
        //public Customer(IEnumerable<IKafkaCustomer> kafkaCustomer)
        //{
        //    _kafkaCustomer = kafkaCustomer;
        //}
        public Customer(IKafkaCustomer<KafkaCustomerA> kafkaCustomerA, 
                        IKafkaCustomer<KafkaCustomerB> kafkaCustomerB)
        {
            _kafkaCustomerA = kafkaCustomerA;
            _kafkaCustomerB = kafkaCustomerB;
        }
        public void CallCustomerA()
        {
            _kafkaCustomerA.ConsumeMessagesFromQueue();
        }

        public void CallCustomerB()
        {
            _kafkaCustomerB.ConsumeMessagesFromQueue();
        }
    }
}
