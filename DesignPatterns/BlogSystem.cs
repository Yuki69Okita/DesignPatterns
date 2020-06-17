using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns
{
    class BlogSystem
    {
        private class Blog
        {
            static SortedList<string, Blog> community = new SortedList<string, Blog>(100);
            string pages;
            string name;
            string gap = "\n";

            static public bool IsUnique(string name)
            {
                return community.ContainsKey(name);
            }

            internal Blog(string n)
            {
                name = n;
                community[n] = this;
            }

            internal void Add(string s)
            {
                pages += gap + s;
                Console.Write(gap + "------ " + name + "'s Blog ------");
                Console.Write(pages);
                Console.WriteLine(gap + "---------------------------");
            }

            public class MyBlog
            { 
                Blog myBlog;
                string password;
                string name;
                bool loggedIn = false;
                void Register()
                {
                    Console.WriteLine("Let's register you for Game blog..");
                    do
                    {
                        Console.WriteLine("All names in this Game blog must be unique!");
                        Console.Write("Type in a user name: ");
                        name = Console.ReadLine();
                    } while (Blog.IsUnique(name));
                    Console.Write("Type in a password: ");
                    password = Console.ReadLine();
                    Console.WriteLine("Thanks for registering.");
                }
                bool Authenticate()
                {
                    Console.Write("Welcome " + name + ". Please type in your password: ");
                    string supplied = Console.ReadLine();
                    if (supplied == password)
                    {
                        loggedIn = true;
                        Console.WriteLine("Logged.");
                        if (myBlog == null)
                        {
                            myBlog = new Blog(name);
                        }
                        return true;
                    }
                    Console.WriteLine("Incorrect password!");
                    return false;
                }

                public void Add(string message)
                {
                    Check();
                    if (loggedIn)
                    {
                        myBlog.Add(message);
                    }
                }
               
                void Check()
                {
                    if (!loggedIn)
                    {
                        if (password == null)
                        {
                            Register();
                        }
                        if (myBlog == null)
                        {
                            Authenticate();
                        }
                    }
                }
            }

        }

        public class MyOpenBlog : IBridge
        {
            Blog MyOpenB;
            string name;
            static int users;
            public MyOpenBlog(string n)
            {
                name = n;
                users++;
                MyOpenB = new Blog(name + "-" + users);
            }
            public void Add(string message)
            {
                MyOpenB.Add(message);
            }
        }
    }
}
