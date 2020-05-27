namespace CrudNetAngular.DataContracts.Response
{
    public sealed class DeveloperResponse : BaseResponse
    {
        /// <summary>
        /// Name of developer
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Skype of developer
        /// </summary>
        public string Skype { get; set; }
        /// <summary>
        /// Phone number of developer
        /// </summary>
        public string PhoneNumber { get; set; }
        /// <summary>
        /// Linkedin of developer
        /// </summary>
        public string Linkedin { get; set; }
        /// <summary>
        /// City of developer
        /// </summary>
        public string City { get; set; }
        /// <summary>
        /// State of developer
        /// </summary>
        public string State { get; set; }
        /// <summary>
        /// Portfolio of developer
        /// </summary>
        public string Portfolio { get; set; }
    }
}
