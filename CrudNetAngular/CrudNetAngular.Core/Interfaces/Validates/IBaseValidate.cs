namespace CrudNetAngular.Core.Interfaces.Validates
{
    public interface IBaseValidate<TRequest>
    {
        bool IsValid(TRequest request);
    }
}
