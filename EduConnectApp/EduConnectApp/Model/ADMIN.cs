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
    
    public partial class ADMIN
    {
        public int MAAD { get; set; }
        public string TENAD { get; set; }
        public Nullable<int> MALOGIN { get; set; }
        public Nullable<bool> DELETED { get; set; }
        public string AVA { get; set; }
    
        public virtual LOGIN LOGIN { get; set; }
    }
}
