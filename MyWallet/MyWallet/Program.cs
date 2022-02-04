using System;

namespace MyWallet
{
    class Program
    {
        public static int password = 123456;
        static void Main(string[] args)
        { 
           int password = 0;
            Console.Clear();
            Autentification(password);
        } 
        static void AboutApp()
        {
            Console.WriteLine("***About RSSWallet***\n");
            Console.WriteLine("This app was created in 31.10.2021 at 10:56 pm by " +
                "Doniyorbek.\n The name of application means Wallet for RSS (R = Recieve, S = Save, S = Send)");
        }
        static void MainMenu()
        {
            Console.WriteLine("\t\tWelcome to RSSWallet \n");
            Console.WriteLine("***Main Menu***\n");
            Console.WriteLine("1. My Balance");
            Console.WriteLine("2. Send Money");
            Console.WriteLine("3. Change Password");
            Console.WriteLine("4. About App");
            Console.WriteLine("5. Exit");

            int next = int.Parse(Console.ReadLine());

            switch (next)
            {
                case 1:
                    Console.Clear();

                    Console.WriteLine("\t\t RSSWallet \n");
                    Console.WriteLine("***Balance***\n");
                    
                    MyBalance();
                    
                    Console.WriteLine("\n1. Previous window");
                    Console.WriteLine("2. Exit");

                    int cly = int.Parse(Console.ReadLine());
                    
                    switch (cly)
                    {
                        case 1:
                            Console.Clear();
                    
                            MainMenu();
                            break;
                        case 2:
                            Console.Clear();
                            
                            goto location3;
                    }
                    break;
                case 2:
                    
                    Console.Clear();
                    
                    Console.WriteLine("\t\t RSSWallet \n");
                    Console.WriteLine("***Sending Money***");
                    
                    break;
                case 3:
                    Console.WriteLine("\t\t RSSWallet \n");
                    Console.WriteLine("***Changing Password***\n");

                    Console.Clear();
                    
                    ChangingPassword();
                    
                    break;
                case 4:
                    Console.Clear();
                    
                    AboutApp();
                    
                    Console.WriteLine("\n1. Previous window");
                    Console.WriteLine("2. Exit");

                    int zed = int.Parse(Console.ReadLine());
                    
                    switch (zed)
                    {
                        case 1:
                            Console.Clear();
                    
                            MainMenu();
                            break;
                        case 2:
                            Console.Clear();
                            
                            goto location3;
                    }
                    break;
                case 5:
                    
                    location3:
                    
                    Console.Clear();
                    
                    Console.WriteLine("GoodBye :)");
                    break;
            }
        }
        static void Autentification(int password1)
        {
            location1:
            
            Console.Write("Please enter the password: ");
            
            password1 = int.Parse(Console.ReadLine());

            if (password1 == password)
            {
                Console.Clear();
            
                MainMenu();
            }
            else
            {
                Console.Clear();
                
                goto location1;
            }
        }
        static void ChangingPassword()
        {
            
            Console.Write("Enter the last password: ");
            
            int lastPassword = int.Parse(Console.ReadLine());

            if (lastPassword == password)
            {
                Console.Write("Enter new password: ");
                
                int newPassword = int.Parse(Console.ReadLine());
                
                Console.Write("Confirm new one: ");
                
                int confirmPass = int.Parse(Console.ReadLine());

                if (newPassword == confirmPass)
                {
                    password = newPassword;
                
                    Console.Clear();
                    
                    Console.WriteLine("The password has been changed Successfully :)\n");
                    
                    Autentification(password);
                }
                else
                {
                    Console.Clear();
                    
                    ChangingPassword();
                }
            }
            else
            {
                Console.Clear();
                
                MainMenu();
            }
        }
        static void MyBalance()
        {
            decimal balance = 0.00m;
            
            Console.WriteLine($"Balance: {balance} $");
        }
    }
}
