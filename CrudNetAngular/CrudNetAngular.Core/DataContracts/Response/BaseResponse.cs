namespace CrudNetAngular.Core.DataContracts.Response
{
    /// <summary>
    /// Base of the contract response
    /// </summary>
    public abstract class BaseResponse 
    { 
        public bool Success { get; set; } 
        public string Message { get; set; }
    }
}
