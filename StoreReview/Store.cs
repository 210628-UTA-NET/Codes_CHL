using System;
using System.Text.RegularExpressions;

namespace StoreReview
{
    public class Store
    {
        private string _city; ///Backing Field.
        public Store()
        {
            
        }
        public string Name {get; set;}
        public string City{ 
            
           get
           {
               return _city;
           }
            
           set
           {
                if (!Regex.IsMatch(value,"@^[A-Za-z .]+$"))
                {
                    throw new Exception("City can only hold letters. Try again.");
                }
            }
            
        }
        
        public string State {get; set;}
        
    }
}
