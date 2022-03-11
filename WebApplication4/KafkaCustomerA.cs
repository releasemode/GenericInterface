namespace WebApplication4
{
    public class KafkaCustomerA : IKafkaCustomer<KafkaCustomerA>
    {
        public void ConsumeMessagesFromQueue()
        {
            var a = "I am being called";
        }
    }
}
