namespace CSharpCourse.Entities.Enums
{
    public enum OrderStatus : int
    {
        PendingPayment = 0,
        ProcessingPayment = 1,
        ShippedPayment = 2,
        Delivered = 3

    }
}