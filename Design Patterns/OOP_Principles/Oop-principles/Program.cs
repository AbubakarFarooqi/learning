using OopPrinciples.Encapsulation;

BadBankAccount account = new BadBankAccount();
account.Deposit(1000); // Directly accessing the public field

Console.WriteLine($"Account Balance: {account.Withdraw(50)}"); // Output: Account Balance: 1000