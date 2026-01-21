/*
 *Name :Om Patel
 *Lecture-3 Demo-1
 *class Box will be used to illustrate properties
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture3Demo1
{
    internal class Box
    {
        private int _iWidth;//baling field for the Width property 
        private int _iHeight;
        public int Width
        {
            get 
            {
                    return _iWidth;  
            }
            //if the user inputs a negative value, we'll assign the  corresponnding absolute value to the data member
            set 
            {
                _iWidth = value <0 ? -value : value; 
            }
        }
        public int Area
        {
           get{
                return _iWidth * _iHeight;
            }
        }

        //in this constructor, we are assigning a default value for the height parameter 
        //Note that using the property Width in the constructor for assigning the value
        //benefits from the validation test performed in the "set"s 
        public Box(int width, int height = 10)
        {
            Width = width;
            _iHeight = height;
        }

        public void Display()
        {
            Console.WriteLine($"_iWidth: {_iWidth}");
            Console.WriteLine($"Width: {Width}");
        }

        

    }
}
