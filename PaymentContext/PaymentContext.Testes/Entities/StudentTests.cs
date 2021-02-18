using Microsoft.VisualStudio.TestTools.UnitTesting;
using PaymentContext.Domain.Entities;
using PaymentContext.Domain.Enums;
using PaymentContext.Domain.ValueObjects;

namespace PaymentContext.Testes.Entities
{
    [TestClass]
    public class StudentTests
    {
        [TestMethod]
        public void TestMethod()
        {
            var subscription = new Subscription(null);
            var student = new Student(new Name("André","Santos"), new Document("12345678912", EDocumentType.CPF), new Email("AndreTeste@gmail.com"));
            student.AddSubscription(subscription);
        }
    }
}