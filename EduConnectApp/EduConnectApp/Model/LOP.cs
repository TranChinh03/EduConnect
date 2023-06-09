//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EduConnectApp.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class LOP
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LOP()
        {
            this.GIANGDAYs = new HashSet<GIANGDAY>();
            this.HOCTAPs = new HashSet<HOCTAP>();
            this.KETQUAs = new HashSet<KETQUA>();
            this.NHANXETs = new HashSet<NHANXET>();
            this.TBMONs = new HashSet<TBMON>();
            this.THANHTICHes = new HashSet<THANHTICH>();
            this.THIs = new HashSet<THI>();
        }
    
        public int MALOP { get; set; }
        public string TENLOP { get; set; }
        public Nullable<int> SISO { get; set; }
        public string NAMHOC { get; set; }
        public Nullable<int> GVCN { get; set; }
        public Nullable<int> LOPTRUONG { get; set; }
        public Nullable<int> MAKHOI { get; set; }
        public Nullable<bool> DELETED { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GIANGDAY> GIANGDAYs { get; set; }
        public virtual GIAOVIEN GIAOVIEN { get; set; }
        public virtual HOCSINH HOCSINH { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HOCTAP> HOCTAPs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KETQUA> KETQUAs { get; set; }
        public virtual KHOI KHOI { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NHANXET> NHANXETs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBMON> TBMONs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<THANHTICH> THANHTICHes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<THI> THIs { get; set; }
    }
}
