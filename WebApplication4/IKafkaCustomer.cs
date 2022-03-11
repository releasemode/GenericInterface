namespace WebApplication4
{
    public interface IKafkaCustomer<T> where T : class
    {
        void ConsumeMessagesFromQueue();
    }
}
