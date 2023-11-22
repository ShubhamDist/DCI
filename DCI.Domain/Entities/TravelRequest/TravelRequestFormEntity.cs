using DCI.Domain.Entities.Base;
using System.ComponentModel.DataAnnotations;

namespace DCI.Domain.Entities.TravelRequest
{
    public class TravelRequestFormEntity
    {
        public TravelRequestEntity TravelRequest { get; set; }
        public List<TravelRequestTravelDetail>? TravelRequestTravelDetail { get; set; }
        public List<AccommodationEntity>? TravelRequestAccommodation { get; set; }
        public List<VehicleRequestEntity>? TravelRequestVehicleRequest { get; set; }
    }

    public class TravelRequestEntity : BaseEntity
    {
        public string? TourTravelNo { get; set; }
        public int EmployeeId { get; set; }
        public int TravelPurposeTypeDetailID { get; set; }
        public int TravelActivityTypeDetailID { get; set; }
        public int ProjectID { get; set; }
        public int ApprovalPathTypeDetailID { get; set; }
        public int ProjectManagerID { get; set; }
        public int DepartmentManagerID { get; set; }
        public string? VendorPONo { get; set; }
        public decimal? AdvanceAmount { get; set; } = 0;
        public string? AdvanceReason { get; set; }
        public string? Remarks { get; set; }

        [MaxLength(1)]
        public string? IsSiteVisit { get; set; } = "N";
        [MaxLength(1)]
        public string? IsSafetyDeclaration { get; set; } = "N";
        [MaxLength(1)]
        public string? IsApproved { get; set; } = "N";

    }
    public class TravelRequestTravelDetail
    {
        public int JourneyTypeTypeDetailID { get; set; }
        public string CityFrom { get; set; }
        public string CityTo { get; set; }
        //public DateTime? DateOfJourney { get; set; }
        public string? DateOfJourney { get; set; }
        public int TravelModeTypeDetailID { get; set; }
        public int TravelClassTypeDetailID { get; set; }
        public string ETD { get; set; }
        public string ETA { get; set; }
        public string VehicleNo { get; set; }
    }

    public class AccommodationEntity
    {
        //public DateTime? FromDate { get; set; }
        //public DateTime? ToDate { get; set; }
        public string? FromDate { get; set; }
        public string? ToDate { get; set; }
        public string City { get; set; }
        public string HotelGuestHouseName { get; set; }
        public string Remark { get; set; }
    }
    public class VehicleRequestEntity
    {
        public int VehicleTypeTypeDetailID { get; set; }
        //public DateTime? FromDate { get; set; }
        //public DateTime? ToDate { get; set; }    
        public string? FromDate { get; set; }
        public string? ToDate { get; set; }
        public string City { get; set; }
        public string Remark { get; set; }
    }
}
