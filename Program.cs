using System;

public class ValidationException : Exception
{
    public ValidationException(string message) : base(message)
    {
    }
}

public class UserRegistrationSystem
{
    public static void Main(string[] args)
    {
        try
        {
            // Prompt the user to enter their name
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            // Prompt the user to enter their email
            Console.Write("Enter your email: ");
            string email = Console.ReadLine();

            // Prompt the user to enter their password
            Console.Write("Enter your password: ");
            string password = Console.ReadLine();

            // Validate the user input
            ValidateInput(name, email, password);

            // If the input is valid, display a success message
            Console.WriteLine("User registration successful!");
        }
        catch (ValidationException ex)
        {
            // Catch the ValidationException and display the error message to the user
            Console.WriteLine("Error: " + ex.Message);
        }
    }

    private static void ValidateInput(string name, string email, string password)
    {
        // Check for missing or invalid values
        if (string.IsNullOrEmpty(name))
        {
            throw new ValidationException("Name is required.");
        }

        if (string.IsNullOrEmpty(email))
        {
            throw new ValidationException("Email is required.");
        }

        if (string.IsNullOrEmpty(password))
        {
            throw new ValidationException("Password is required.");
        }

        // Check the minimum length requirements for name and password
        if (name.Length < 6)
        {
            throw new ValidationException("Name must have at least 6 characters.");
        }

        if (password.Length < 8)
        {
            throw new ValidationException("Password must have at least 8 characters.");
        }

        // You can add additional validation checks for email format, password complexity, etc.
        // For simplicity, this example only checks for length requirements.
    }
}