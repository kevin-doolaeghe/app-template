using backend.Models;

namespace backend.DTOs {

    public class UserGetDto {

        public int Id { get; set; }

        public string? Name { get; set; }

        public string? Email { get; set; }

        public static UserGetDto ToDto(User item) {
            return new UserGetDto {
                Id = item.Id,
                Name = item.Name,
                Email = item.Email,
            };
        }
    }

    public class UserPostDto {

        public string? Name { get; set; }

        public string? Email { get; set; }

        public string? Password { get; set; }

        public static User ToItem(UserPostDto dto) {
            return new User {
                Name = dto.Name,
                Email = dto.Email,
                Password = dto.Password,
            };
        }
    }
}
