using System;
using Haq.GitPilot1.CLib1;

namespace GitConsol1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            GitClass gitClass = new GitClass();
            gitClass.PrintGitClass();
        }
    }
}
