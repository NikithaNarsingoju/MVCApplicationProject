//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MVCApplicationProject
{
    using System;
    using System.Collections.Generic;
    
    public partial class Student
    {
        public int RollNo { get; set; }
        public string studentName { get; set; }
        public Nullable<int> classId { get; set; }
        public Nullable<int> subjectId { get; set; }
    
        public virtual Class Class { get; set; }
        public virtual Subject Subject { get; set; }
    }
}
