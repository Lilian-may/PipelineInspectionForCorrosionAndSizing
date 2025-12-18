using System;

namespace WinFormsApp2
{
    public static class Validators
    {
        public static decimal ParseDecimal(string input, string fieldName, decimal min, decimal max)
        {
            if (string.IsNullOrWhiteSpace(input))
                throw new ArgumentException($"{fieldName}: поле не может быть пустым.");

            if (!decimal.TryParse(input.Trim(), out var val))
                throw new ArgumentException($"{fieldName}: должно быть числом.");

            if (val < min || val > max)
                throw new ArgumentException($"{fieldName}: допустимый диапазон от {min} до {max}.");

            return val;
        }

        public static string Required(string input, string fieldName, int maxLen)
        {
            if (string.IsNullOrWhiteSpace(input))
                throw new ArgumentException($"{fieldName}: поле не может быть пустым.");

            var trimmed = input.Trim();
            if (trimmed.Length > maxLen)
                throw new ArgumentException($"{fieldName}: максимальная длина {maxLen} символов.");

            return trimmed;
        }

        public static string RequiredTextOnly(string input, string fieldName, int maxLen)
        {
            var text = Required(input, fieldName, maxLen);

            foreach (char c in text)
            {
                if (!char.IsLetter(c) && c != ' ' && c != '-' && c != '(' && c != ')' && c != '/')
                    throw new ArgumentException($"{fieldName}: допускаются только буквы, пробелы и знаки (-, /, (), -).");
            }

            return text;
        }

        public static void ValidateLogin(string login)
        {
            if (string.IsNullOrWhiteSpace(login))
                throw new ArgumentException("Логин не может быть пустым.");

            if (login.Length < 3 || login.Length > 30)
                throw new ArgumentException("Логин должен содержать от 3 до 30 символов.");

            foreach (char c in login)
            {
                if (!char.IsLetterOrDigit(c) && c != '_')
                    throw new ArgumentException("Логин может содержать только буквы, цифры и подчёркивание.");
            }
        }

        public static void ValidatePassword(string password)
        {
            if (string.IsNullOrWhiteSpace(password))
                throw new ArgumentException("Пароль не может быть пустым.");

            if (password.Length < 4)
                throw new ArgumentException("Пароль должен содержать минимум 4 символа.");
        }
    }
}
