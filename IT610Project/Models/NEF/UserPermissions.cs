using System.ComponentModel.DataAnnotations;

namespace IT610Project.Models.NEF
{
    public class UserPermissions
    {
        // Identity for table
        [Key]
        [ScaffoldColumn(false)]
        public int Id { get; set; }

        // Employee Key from MediMizer
        [ScaffoldColumn(false)]
        public int EmployeeKey { get; set; }

        // Employee Code from MediMizer
        [ScaffoldColumn(false)]
        public int EmployeeCode { get; set; }

        // Employee Name from MediMizer
        [ScaffoldColumn(false)]
        public int EmployeeName { get; set; }

        // Able to Login
        [ScaffoldColumn(false)]
        public bool Login { get; set; } = true;

        // Permission to create new Equipment entry
        [ScaffoldColumn(false)]
        public bool CreateNew { get; set; } = true;

        // Permission to save a new equipment entry
        [ScaffoldColumn(false)]
        public bool CreateSave { get; set; } = true;

        // Permission to delete a new equipment entry
        [ScaffoldColumn(false)]
        public bool CreateDelete { get; set; } = false;

        // Permission to read the submitted forms
        [ScaffoldColumn(false)]
        public bool SubmittedRead { get; set; } = true;

        // Permission to Update the submitted forms
        [ScaffoldColumn(false)]
        public bool SubmittedUpdate { get; set; } = false;

        // Permission to delete a submitted form
        [ScaffoldColumn(false)]
        public bool SubmittedDelete { get; set; } = false;

        // Permission to read the approved forms
        [ScaffoldColumn(false)]
        public bool ApprovedRead { get; set; } = true;

        // Permission to reject submitted forms
        [ScaffoldColumn(false)]
        public bool Reject { get; set; } = false;

        // Date User was created
        [ScaffoldColumn(false)]
        [DataType(DataType.DateTime)]
        public DateTime UserCreated { get; set; } = DateTime.Now;
    }
}
