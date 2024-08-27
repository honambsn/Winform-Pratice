using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace IncomeExpensesTrackingSystem
{
	internal class PasswordHash
	{
		private const int SaltSize = 16; // Kích thước của salt (bytes)
		private const int HashSize = 20; // Kích thước của hash (bytes)
		private const int Iterations = 10000; // Số vòng lặp cho PBKDF2

		// Phương thức để mã hóa mật khẩu
		public static string HashPassword(string password)
		{
			// Tạo salt ngẫu nhiên
			using (var rng = new RNGCryptoServiceProvider())
			{
				var salt = new byte[SaltSize];
				rng.GetBytes(salt);

				// Tạo hash từ mật khẩu và salt
				using (var pbkdf2 = new Rfc2898DeriveBytes(password, salt, Iterations))
				{
					var hash = pbkdf2.GetBytes(HashSize);

					// Kết hợp salt và hash thành một mảng byte
					var hashBytes = new byte[SaltSize + HashSize];
					Array.Copy(salt, 0, hashBytes, 0, SaltSize);
					Array.Copy(hash, 0, hashBytes, SaltSize, HashSize);

					// Chuyển đổi thành chuỗi base64
					return Convert.ToBase64String(hashBytes);
				}
			}
		}

		// Phương thức để xác minh mật khẩu
		public static bool VerifyPassword(string password, string hashedPassword)
		{
			// Chuyển đổi chuỗi base64 thành mảng byte
			var hashBytes = Convert.FromBase64String(hashedPassword);

			// Tách salt và hash từ mảng byte
			var salt = new byte[SaltSize];
			Array.Copy(hashBytes, 0, salt, 0, SaltSize);

			var hash = new byte[HashSize];
			Array.Copy(hashBytes, SaltSize, hash, 0, HashSize);

			// Tạo hash từ mật khẩu và salt
			using (var pbkdf2 = new Rfc2898DeriveBytes(password, salt, Iterations))
			{
				var computedHash = pbkdf2.GetBytes(HashSize);

				// So sánh hash đã lưu với hash được tính toán
				for (int i = 0; i < HashSize; i++)
				{
					if (hash[i] != computedHash[i])
					{
						return false;
					}
				}
			}

			return true;
		}
	}
}
