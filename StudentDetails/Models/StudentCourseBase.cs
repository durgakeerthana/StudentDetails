﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;

namespace WebApplication44.Models
{
    public class StudentCourseBase
    {

        public int id { get; set; }
        public string course1 { get; set; }
        public Nullable<int> duration { get; set; }

        private ICollection<StudentInfo> studentInfo;

        public virtual ICollection<StudentInfo> GetStudentInfo()
        {
            return studentInfo;
        }

        public virtual void SetStudentInfo(ICollection<StudentInfo> value)
        {
            studentInfo = value;
        }
    }
}