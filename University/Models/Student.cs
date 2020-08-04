using System;
using System.Collections.Generic;

namespace University.Models
{
  public class Student
  {
    public Student()
    {
      this.Courses = new HashSet<CourseStudent>();
    }

    public string Name { get; set; }
    public DateTime DateOfEnrollment { get; set; }
    public int StudentId { get; set; }
    public virtual ICollection<CourseStudent> Courses { get; set; }
  }
}