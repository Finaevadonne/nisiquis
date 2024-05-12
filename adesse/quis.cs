// Initialize a variable to store the total number of accounts
int totalAccounts = profiles.Count;

// Check if the profiles list is not null to avoid a NullReferenceException
if (profiles != null)
{
    // Use string interpolation to create the message with the total accounts
    string message = $"Total accounts: {totalAccounts}";

    // Print the message to the console
    Console.WriteLine(message);
}
else
{
    // If profiles is null, print an error message
    Console.WriteLine("Error: The profiles list is null.");
}
