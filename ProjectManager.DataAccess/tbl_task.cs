//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProjectManager.DataAccess
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbl_task
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_task()
        {
            this.tbl_users = new HashSet<tbl_users>();
        }
    
        public int task_id { get; set; }
        public Nullable<int> parent_id { get; set; }
        public Nullable<int> project_id { get; set; }
        public string task { get; set; }
        public Nullable<System.DateTime> start_date { get; set; }
        public Nullable<System.DateTime> end_date { get; set; }
        public Nullable<int> priority { get; set; }
        public string status { get; set; }
    
        public virtual tbl_project tbl_project { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_users> tbl_users { get; set; }
        public virtual tbl_parent_task tbl_parent_task { get; set; }
    }
}
