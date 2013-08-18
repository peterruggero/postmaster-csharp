namespace Postmaster.io.Communication.Api.V1.Entities
{
    /// <summary>
    /// Optional status codes.
    /// </summary>
    public enum StatusCode
    {
        CreateShipmentSuccess = 0,
        CreateShipmentFailure,
        PostSuccess,
        PostFailure,
        GetSuccess,
        GetFailure
    }
}
