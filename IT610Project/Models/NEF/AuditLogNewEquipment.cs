using System.ComponentModel.DataAnnotations;

namespace IT610Project.Models.NEF
{
    public class AuditLogNewEquipment
    {
        // Identity column
        [Key]
        [ScaffoldColumn(false)]
        public int Id { get; set; }

        // Form Field
        [ScaffoldColumn(false)]
        public string? FormField { get; set; }

        // Previous Value of form field
        [ScaffoldColumn(false)]
        public string? FormFieldPreviousValue { get; set; }

        // New value of form field
        [ScaffoldColumn(false)]
        public string? FormFieldNewValue { get; set; }

        // Date Created
        [ScaffoldColumn(false)]
        [DataType(DataType.DateTime)]
        public DateTime DateCreated { get; set; }

        // Date Read
        [ScaffoldColumn(false)]
        [DataType(DataType.DateTime)]
        public DateTime DateRead { get; set; }

        // Date Updated
        [ScaffoldColumn(false)]
        [DataType(DataType.DateTime)]
        public DateTime DateUpdated { get; set; }

        // Date Deleted
        [ScaffoldColumn(false)]
        [DataType(DataType.DateTime)]
        public DateTime DateDeleted { get; set; }

        // Audit Log Time Stamp
        [ScaffoldColumn(false)]
        [DataType(DataType.DateTime)]
        public DateTime AuditLogTimeStamp { get; set; } = DateTime.Now;

    }
}
