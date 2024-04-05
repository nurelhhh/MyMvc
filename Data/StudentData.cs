using MyMvc.Models;

namespace MyMvc.Data
{
    public static class StudentData
    {
        public static List<Student> GetAllData()
        {
            return new List<Student> {
                new Student
                {
                    Name = "Nurel",
                    StudentId = "2201812103"
                },
                new Student
                {
                    Name = "Hakeem",
                    StudentId = "BR2020TEST"
                }
            };
        }
    }
}
