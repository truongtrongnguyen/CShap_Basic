using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.Linq;
namespace Type_Attribute_Annotation
{
    internal class Su_Dung_Required
    {
        public void Demo()
        {
            User user = new User()
            {
                Name = "Nguyen",
                Age = 10,
                PhoneNumber = "0962958823",
                Email = "sdfsdfdsfs"
            };
            //Tạo ra một đối tượng context để kiêm tra dữ liệu
            ValidationContext context = new ValidationContext(user);

            List<ValidationResult> result = new List<ValidationResult>();

            //Kiểm tra dữ liệu user dựa trên ngữ cảnh contex và lưu kết quả vào biến result và true là kiểm tra tất cả cá thuộc tính
            bool kq = Validator.TryValidateObject(user, context, result, true);

            //Nếu kết quả trả vè true thì không có lỗi, còn false thì lỗi nó sễ được lưu ở biến result
            if(kq==false)
            {
                result.ToList().ForEach((ValidationResult er) =>
                {
                    Console.WriteLine(er.MemberNames.First());
                    Console.WriteLine(er.ErrorMessage);
                });
            }    
        }

    }
    class User
    {
        //Sử dụng thư viện:  using System.ComponentModel.DataAnnotations;
        [Required(ErrorMessage = "Name phai thiet lap")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Ten phai tu 3 den 50 ky tu")]
        public string Name { get; set; }
        [Range(18, 80, ErrorMessage = "Tuoi phai nam trong khoang 18-80")]
        public int Age { get; set; }
        [Phone]
        public string PhoneNumber { get; set; }

        [EmailAddress(ErrorMessage = "Email khong hop le")]
        public string Email { get; set; }
    }
}
