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
		private const int SaltSize = 16; // Size of salt in bytes
		private const int HashSize = 20; // Size of hash in bytes
		private const int Iterations = 10000; // Number of iterations

		// Hashes the password using PBKDF2
		public static string HashPassword(string password)
		{
			// Generate a random salt
			byte[] salt = new byte[SaltSize];
			using (var rng = new RNGCryptoServiceProvider())
			{
				rng.GetBytes(salt);
			}

			// Create the PBKDF2 instance and hash the password
			using (var pbkdf2 = new Rfc2898DeriveBytes(password, salt, Iterations, HashAlgorithmName.SHA256))
			{
				byte[] hash = pbkdf2.GetBytes(HashSize);

				// Combine the salt and hash into a single string for storage
				byte[] hashBytes = new byte[SaltSize + HashSize];
				Array.Copy(salt, 0, hashBytes, 0, SaltSize);
				Array.Copy(hash, 0, hashBytes, SaltSize, HashSize);

				return Convert.ToBase64String(hashBytes);
			}
		}

		public static bool VerifyPassword(string password, string hashedPassword)
		{
			// Convert the stored hash from Base64 string to byte array
			byte[] hashBytes = Convert.FromBase64String(hashedPassword);

			// Extract the salt from the stored hash
			byte[] salt = new byte[SaltSize];
			Array.Copy(hashBytes, 0, salt, 0, SaltSize);

			// Extract the hash from the stored hash
			byte[] storedHash = new byte[HashSize];
			Array.Copy(hashBytes, SaltSize, storedHash, 0, HashSize);

			// Hash the input password with the extracted salt
			using (var pbkdf2 = new Rfc2898DeriveBytes(password, salt, Iterations, HashAlgorithmName.SHA256))
			{
				byte[] hash = pbkdf2.GetBytes(HashSize);

				// Compare the computed hash with the stored hash
				for (int i = 0; i < HashSize; i++)
				{
					if (hash[i] != storedHash[i])
					{
						return false;
					}
				}
				return true;
			}
		}
	}
}
