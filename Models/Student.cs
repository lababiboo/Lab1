namespace WebApplication1.Models
{
    public class Student
    {
        public int Id { get; set; }//Mã sinh viên
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public Branch? Branch { get; set; }//Ngành học
        public Gender? Gender { get; set; }
        public bool IsRegular { get; set; }//Hệ: true-cq, false-phi cq
        public string? Address { get; set; }
        public DateTime DateOfBorth { get; set; }//Ngày sinh

    }
}
