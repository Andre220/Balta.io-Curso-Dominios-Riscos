using PaymentContext.Shared.ValueObjects;

namespace PaymentContext.Domain.ValueObjects
{
    public class Name : ValueObject
    {
        public Name(string firstName, string lastNameName)
        {
            FirstName = firstName;
            LastNameName = lastNameName;
        }

        public string FirstName { get; private set; }
        public string LastNameName { get; private set; }
    }
}