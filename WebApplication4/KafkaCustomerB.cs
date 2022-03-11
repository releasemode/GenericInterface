namespace WebApplication4
{
    public class KafkaCustomerB : IKafkaCustomer<KafkaCustomerB>
    {
        public void ConsumeMessagesFromQueue()
        {
            var a = "I am being called";
        }
    }
}
