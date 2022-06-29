using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance__Access_Modifiers
{
    class Account
    {
        static void Login()
        {
            string Mail;
            string Password;
            Console.WriteLine("Mail:");
            Mail = Console.ReadLine();
            Console.WriteLine("Pasword:");
            Password = Console.ReadLine();
            if (Mail == "Azerrh@code.edu.az" && Password == "Necesen567")
            {
                Console.WriteLine("Girish olundu");
            }
            else
            {
                Console.WriteLine("Parol sehfdir");
            }
        }
        
    }
}
