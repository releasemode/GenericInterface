# GenericInterface

 public interface IKafkaCustomer<T> where T : class
 {
        void ConsumeMessagesFromQueue();
 }
  
 public class KafkaCustomerA : IKafkaCustomer<KafkaCustomerA>
 {
        public void ConsumeMessagesFromQueue()
        {
            var a = "I am being called";
        }
 } 
  
 public class KafkaCustomerB : IKafkaCustomer<KafkaCustomerB>
 {
        public void ConsumeMessagesFromQueue()
        {
            var a = "I am being called";
        }
 }
  
 builder.Services.AddScoped<IKafkaCustomer<KafkaCustomerA>,KafkaCustomerA>();
 builder.Services.AddScoped<IKafkaCustomer<KafkaCustomerB>, KafkaCustomerB>();
  
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
  
