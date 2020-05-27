using CrudNetAngular.DataContracts.Response;
using System.ComponentModel.DataAnnotations;

namespace CrudNetAngular.DataContracts.Request
{
    public sealed class DeveloperRequest : BaseRequest<BaseResponse>
    {
        /// <summary>
        /// Name of developer
        /// </summary>
        [Required]
        public string Name { get; set; }
        /// <summary>
        /// Skype of developer
        /// </summary>
        [Required]
        public string Skype { get; set; }
        /// <summary>
        /// Phone number of developer
        /// </summary>
        [Required]
        public string PhoneNumber { get; set; }
        /// <summary>
        /// Linkedin of developer
        /// </summary>
        public string Linkedin { get; set; }
        /// <summary>
        /// City of developer
        /// </summary>
        [Required]
        public string City { get; set; }
        /// <summary>
        /// State of developer
        /// </summary>
        [Required]
        public string State { get; set; }
        /// <summary>
        /// Portfolio of developer
        /// </summary>
        public string Portfolio { get; set; }
    }
}
