//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Ebys10
{

    using System.Linq;
    using System;
    using System.Collections.Generic;
    
    public partial class STUDENT
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public STUDENT()
        {
            this.TAKENCOURSES = new HashSet<TAKENCOURSES>();
        }
    
        public string StudentId { get; set; }
        public string StudentName { get; set; }
        public string SMentorId { get; set; }
    
        public virtual MENTOR MENTOR { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TAKENCOURSES> TAKENCOURSES { get; set; }
        public List<string> choosenCourses = new List<string>();
        public List<string> getSemesterCourse()
        {
            List<string> a = new List<string>();
            using (var db = new EbysVol9Entities())
            {
                var result = from k in db.SEMESTERCOURSE
                            
                             select new
                             {
                                 k.CourseId

                             };
                foreach (var item in result)
                {
                    a.Add(item.CourseId);
                }

            }

            return (a);

        
        }

    }
}