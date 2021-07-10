using System;

namespace HouseFunction
{
    public class House
    {   
        private string _color;

        private int _price;
        

        //This is a constructor, or special method called when an object is initialized.
        public House()
        {
            Console.WriteLine("The constructor of this class was used.");            
            _color = "Red";
        }

        //remove get or set? make it read-only or write-only
        //        
        //implementation on getting and setting naming fields.
        public int Price
        {
            get
            {
                return _price;
            }
            set
            {
                _price = value;
            }
        }

        public string Name 
        { 
            get; 
            set; 
        }

        //Java way to get information from fields.
        public string getColor()
        {
            return _color;
        }

        //Some methods have parameters to send information.
        public void setColor(string p_color)
        {
            _color = p_color;
        }
         
    }
}