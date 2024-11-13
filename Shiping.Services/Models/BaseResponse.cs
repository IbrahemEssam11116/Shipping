namespace Shipping.Models
{
    public class BaseResponse<T>
    {
        public ResponseStatus Status { get; set; }
        public string Message { get; set; }
        public T Result { get; set; }
    }

    public enum ResponseStatus
    {
        Success,
        Error,
        UnAuthorized
    }
}
