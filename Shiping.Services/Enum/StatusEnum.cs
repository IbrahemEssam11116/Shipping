namespace Shiping.Services.Enum
{
    public enum StatusEnum
    {
        New = 1,
        Preparing = 2,
        PickedUp = 3,
        Shipped = 4,
        Delivered = 5,
        Failed = 6,
        FailedFeesCollected = 7,
        CouldNotReachClient = 8,
        ClientReschedule = 9,
        Cancelled = 10,
        ReturnedToShipper = 11,
        NotReceived = 12,
        CODReceived = 13,
        MissingInfo = 14,
        OnHold = 15,
        CustomerCancelled = 16,
        NotReady = 17,
        ReceivedAtWarehouse = 18,
        Resend = 19,
        Ready = 20,
        Duplicated = 21,
        MissingPiece = 22,
        Paid=23
    }
}
