namespace BookingApi.Exceptions
{
    public class FalsePassException : Exception
    {
        public FalsePassException() : base("Incorrect email address or password")
        { 
        }
    }
}