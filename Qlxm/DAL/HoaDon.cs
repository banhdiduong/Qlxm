//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Qlxm.DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class HoaDon
    {
        public int IDThue { get; set; }
        public int SoNgayThue { get; set; }
        public int SoNgayTraMuon { get; set; }
        public int TienThue { get; set; }
        public int TienPhat { get; set; }
        public int TongTien { get; set; }
    
        public virtual ThueXe ThueXe { get; set; }
    }
}
