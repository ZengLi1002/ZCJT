//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ZCJT.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class SysModuleOperate
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string KeyCode { get; set; }
        public string ModuleId { get; set; }
        public bool IsValid { get; set; }
        public int Sort { get; set; }
    
        public virtual SysModule SysModule { get; set; }
    }
}
