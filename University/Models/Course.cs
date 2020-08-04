using System.Collections.Generic;

namespace University.Models
{
  public class Course
  {
  
    public Course()
    {
      this.Students = new HashSet<CourseStudent>();
    }
    public string CourseName {get; set; }
    
    public int CourseNumber { get; set; }
    
    public int CourseId { get; set; }

    public ICollection<CourseStudent> Students { get; set; }

  }

}