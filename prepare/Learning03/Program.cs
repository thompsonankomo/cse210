using System;

public class Fraction
{
    static void Main(string[] args)
    {
        private int_top;
        private int_bottom;

        public fraction()
        {
            _top =4;
            _bottom =5;
        }
        public Fraction (int WholeNumber)
        {
            _top = WholeNumber;
            _bottom = 1;
        }
        public Fraction (int top , int bottom)
        {
            _top = top;
            _bottom = bottom;
        }
        public string GetFractionString()
        {
            string text =$"{_top}/ {_bottom}";
            return text();
        }
        

    }
}