namespace Tracker.Application.Features.DTO
{
    #region CompanyDto
    public class CompanyDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Notes { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
        public AddressDto address { get; set; }

    } 
    #endregion
}
