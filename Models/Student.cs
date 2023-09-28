using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class Student
    {
        
        public int Id { get; set; }//Mã sinh viên
        [Required(ErrorMessage = "Tên bắt buộc phải được nhập")]
        [StringLength(100, MinimumLength = 4,ErrorMessage = "Tên tối thiểu 4 ký tự, tối đa 100 ký tự")]
        public string? Name { get; set; }
        [Required(ErrorMessage = "Email bắt buộc phải được nhập")]
        [RegularExpression(@"[A-Za-z0-9._%+-]+@gmail.com", ErrorMessage = "Địa chỉ email có đuôi gmail.com")]
        public string? Email { get; set; }
        [Required(ErrorMessage = "Mật khẩu bắt buộc phải được nhập")]
        [StringLength(100, MinimumLength = 8, ErrorMessage ="Mật khẩu phải dài trên 8 kí tự")]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*\W).{8,}$", ErrorMessage ="Mật khẩu phải gồm chữ thường, chữ in hoa, chữ số và kí tự đặc biệt")]
        public string? Password { get; set; }
        [Required(ErrorMessage = "Phải chọn ngành")]
        public Branch? Branch { get; set; }//Ngành học
        [Required(ErrorMessage = "Phải chọn giới tính")]
        public Gender? Gender { get; set; }
        public bool IsRegular { get; set; }//Hệ: true-cq, false-phi cq
        [DataType(DataType.MultilineText)]
        [Required(ErrorMessage = "Địa chỉ bắt buộc phải được nhập")]
        public string? Address { get; set; }
       
        [Range(typeof(DateTime), "1/1/1963", "12/31/2005")]
        [DataType(DataType.Date)]
        [Required(ErrorMessage = "Ngày sinh bắt buộc phải được nhập")]
        public DateTime? DateOfBorth { get; set; }//Ngày sinh
        
        [Range(0.0,10.0, ErrorMessage = "Điểm bắt buộc phải được nhập  ở kiểu số thực và miền giá trị từ 0.0 đến 10.0")]
        [Required(ErrorMessage = "Hãy nhập điểm")]
        public float? Diem { get; set; }
        [Required(ErrorMessage ="Hãy chọn file ảnh")]
        public IFormFile Img { get; set; }
    }
}
