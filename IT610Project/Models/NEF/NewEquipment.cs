using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IT610Project.Models.NEF
{
    public class NewEquipment
    {
        // The data properties for the primary key
        [Key]
        [ScaffoldColumn(false)]
        public int Id { get; set; }

        // Control Number
        [DisplayName("Control Number")]
        [StringLength(15)]
        [Required(ErrorMessage = "Control Number is a required field and can be no longer than 15 characters")]
        public string? ControlNo { get; set; }

        // Serial Number
        [DisplayName("Serial Number")]
        [StringLength(30)]
        [Required(ErrorMessage = "Serial Number is a required field and can be nolonger than 30 character")]
        public string? Serial { get; set; }

        // System Key
        [DisplayName("System")]
        public int? SystemKey { get; set; }

        // Vendor key
        [DisplayName("Vendor")]
        [Required(ErrorMessage = "Vendor is a required field")]
        public int VendorKey { get; set; }

        // Model Key
        [DisplayName("Model")]
        [Required(ErrorMessage = "Model is a required field")]
        public int ModelKey { get; set; }

        // Equipment Status Key
        [DisplayName("Equipment Status")]
        [Required(ErrorMessage ="Equipment Status is a required field")]
        public int EquipmentStatKey { get; set; }

        // Equipment Condition Key
        [DisplayName("Equipment Condition")]
        [Required(ErrorMessage = "Equipment Condition is a required field")]
        public int EquipmentCondKey { get; set; }

        // Building Key
        [DisplayName("Building")]
        public int? BuildingKey { get; set; }

        // Charge to department key
        [DisplayName("Charge to Department Cost Center")]
        [Required(ErrorMessage = "Department Cost Center is a required field")]
        public int DeptCharg2Key { get; set; }

        // Department owner of equipment
        [DisplayName("Department Owner")]
        [Required(ErrorMessage = "Department Owner is a required field")]
        public int DeptOwnerKey { get; set; }

        // Software Revision
        [DisplayName("Software Revision")]
        [StringLength(32)]
        public string? SoftwareRev { get; set; }

        // Last Location
        [DisplayName("Last Location Seen")]
        [StringLength(200)]
        public string? LastLocation { get; set; }

        // Date Located
        [DisplayName("Date Last Located")]
        [DataType(DataType.Date)]
        public DateTime? LocatedOn { get; set; }

        // Notes
        [DisplayName("Notes")]
        [DataType(DataType.MultilineText)]
        public string? Notes { get; set; }

        //Purchase Date
        [DisplayName("Purchase Date")]
        [Required(ErrorMessage = "Purchase Date is a required field")]
        [DataType(DataType.Date)]
        public DateTime? PurchaseDate { get; set; }

        //Purchase Cost
        [DisplayName("Purchase Cost")]
        [Required(ErrorMessage = "Purchase Cost is a required field. Cannot be larger than 15 digits to the left of the decimal point and two to the right")]
        [Column(TypeName = "decimal(15, 2)")]
        [DataType(DataType.Currency)]
        public decimal? PurchaseCost { get; set; }

        // Purchase order number
        [DisplayName("Purchase Order Number")]
        [StringLength(30)]
        [Required(ErrorMessage = "Purchase Order Number is a required field and can be no longer than 30 character")]
        public string? PurchaseOrderNo { get; set; }

        // Parts Warranty
        [DisplayName("Parts Warranty")]
        [DataType(DataType.Date)]
        public DateTime? WarrExpirePart { get; set; }

        // Labor Warranty
        [DisplayName("Labor Warranty")]
        [DataType(DataType.Date)]
        public DateTime? WarrExpireLabor { get; set; }

        //Room number
        [DisplayName("Room Number")]
        [StringLength(8)]
        public string? RoomNo { get; set; }

        //Floor Number
        [DisplayName("Floor Number")]
        [StringLength(4)]
        public string? FloorNo { get; set; }

        //Initial Location
        [DisplayName("Initial Location")]
        [StringLength(120)]
        public string? InitialLoc { get; set; }

        // Below here is all the custom fields for the web applicaton

        // Date Created
        [ScaffoldColumn(false)]
        [DataType(DataType.DateTime)]
        public DateTime DateCreated { get; set; } = DateTime.Now;

        //Date Submitted
        [ScaffoldColumn(false)]
        [DataType(DataType.DateTime)]
        public DateTime DateSubmitted { get; set; }

        // Date Approved
        [ScaffoldColumn(false)]
        [DataType(DataType.DateTime)]
        public DateTime DateApproved { get; set; }

        // Submitted
        [ScaffoldColumn(false)]
        public bool Submitted { get; set; }

        //Approved
        [ScaffoldColumn(false)]
        public bool Approved { get; set; }

        //Approver
        [ScaffoldColumn(false)]
        public int Approver { get; set; }

        // Submitter
        [ScaffoldColumn(false)]
        public int Submitter { get; set; }

        // Creator 
        [ScaffoldColumn(false)]
        public int Creator { get; set; }

        // Assigned to
        [ScaffoldColumn(false)]
        public int AssignedTo { get; set; }



    }
}
