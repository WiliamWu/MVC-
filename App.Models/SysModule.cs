//------------------------------------------------------------------------------
// <auto-generated>
//    此代码是根据模板生成的。
//
//    手动更改此文件可能会导致应用程序中发生异常行为。
//    如果重新生成代码，则将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace App.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class SysModule
    {
        public SysModule()
        {
            this.sysmodule1 = new HashSet<SysModule>();
        }
    
        public string Id { get; set; }
        public string Name { get; set; }
        public string EnglishName { get; set; }
        public string ParentId { get; set; }
        public string Url { get; set; }
        public string Iconic { get; set; }
        public Nullable<int> Sort { get; set; }
        public string Remark { get; set; }
        public Nullable<bool> State { get; set; }
        public string CreatePerson { get; set; }
        public Nullable<System.DateTime> CreateTime { get; set; }
        public bool IsLast { get; set; }
        public Nullable<System.DateTime> Version { get; set; }
    
        public virtual ICollection<SysModule> sysmodule1 { get; set; }
        public virtual SysModule sysmodule2 { get; set; }
    }
}