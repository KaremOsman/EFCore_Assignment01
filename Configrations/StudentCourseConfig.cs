using Assignment01.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Assignment01.Configrations
{
    public class StudentCourseConfig : IEntityTypeConfiguration<Student_Coures>
    {
        public void Configure(EntityTypeBuilder<Student_Coures> builder)
        {
            builder.HasKey(SC => new {SC.Stud_Id, SC.Course_Id });
        }
    }
}
