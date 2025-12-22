using System;
using System.Security.Cryptography;
using System.Text;

namespace WinFormsApp2
{
    public static class Security
    {
        public static string HashPassword(string password)
        {
            using var sha = SHA256.Create();
            var bytes = sha.ComputeHash(Encoding.UTF8.GetBytes(password));
            return Convert.ToBase64String(bytes);
        }
    }
}
