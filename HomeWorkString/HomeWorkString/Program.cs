using System;

namespace HomeWorkString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(NameReverse("Abqulqadir"));
            
        }
    
    
    
    
    
    
    static string NameReverse(string name)
            
        {
            string result = "";
            for (int i = name.Length - 1; i >= 0; i--)
                result += name[i];
            return result;

        
        
        }
        
    
    }
}
