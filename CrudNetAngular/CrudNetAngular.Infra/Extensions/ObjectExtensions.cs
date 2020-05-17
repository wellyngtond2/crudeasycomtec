using Newtonsoft.Json;

namespace CrudNetAngular.Infra.Extensions
{
    /// <summary>Object extension methods.</summary>
    public static class ObjectExtensions
    {        /// <summary>
             /// Creates a new instance of the current object without references to the original.
             /// </summary>
             /// <typeparam name="T">Type of the object to be cloned.</typeparam>
             /// <param name="source">Object to be cloned.</param>
             /// <returns>Return a new instance of T filed with the data of the original object.</returns>
        public static T Clone<T>(this T source) where T : class, new()
        {
            if (source == null) return default(T);

            string serializedData = JsonConvert.SerializeObject(source);

            return JsonConvert.DeserializeObject<T>(serializedData);
        }
    }
}
