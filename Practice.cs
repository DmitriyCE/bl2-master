using System;
using System.ComponentModel;

namespace ConsoleApp7
{
    public class Practice
    {
        /// <summary>
        /// B2-P1/1. TypeConvert. Преобразование типов используя явное, неявное преобразование и класс Convert.
        /// </summary>
        public static void B2_P1_1_TypeConvert()
        {
            //CONVERSION (explicit, implicit, Convert)

            //1. CHAR CONVERSION 
            char sex = 'М';//to string
            string sex1 = Convert.ToString(sex); //"M"

            char place = '3';//to int
            int place1 = place;// int 3
            char hasFingerPrints = '0';//to boolean
            //bool hasFingerPrints1 = Convert.ToBoolean(hasFingerPrints);  Impossible to convert
            bool hasFingerPrintsBool = Convert.ToBoolean((int)hasFingerPrints); // true


            //2. STRING CONVERSION           
            string hasPhotoString = "True";//to bolean
            bool hasPhotoStringBool = Convert.ToBoolean(hasPhotoString);
            string flatNumber = "34";//to int
            int flatNumberInt = Convert.ToInt32(flatNumber); // int 34
            string visaPriceString = "34,23";//to float
            float visaPriceStringFloat = float.Parse(visaPriceString.Replace(",","."));
            string photoPriceString = "7.23";//to float
            float photoPriceStringFloat = float.Parse(photoPriceString);

            //3. BOOL CONVERSION
            bool hasFree2Pages = false;//to string, to char, to int
            string hasFree2PagesString = Convert.ToString(hasFree2Pages); //"false"
            //char hasFree2Pages2 = Convert.ToChar(hasFree2Pages); Impossible to convert
            int hasFree2PagesInt = Convert.ToInt32(hasFree2Pages); //0



            //4. DECIMAL CONVERSION
            double visaPrice = 60;//to int, to string // 60.0
            int visaPriceInt = (int)visaPrice; //60
            string visaPrice1 = visaPrice.ToString(); //"60"

            double finterPrintsPrice = 55.2;//to int, to string
            int finterPrintsPriceInt = Convert.ToInt32(finterPrintsPrice); // 55
            string finterPrintsPriceString = finterPrintsPrice.ToString(); // "55.2"

            //4. INT CONVERSION
            int birthYear = 2000;//to string, to double, to char
            string birthYearString = birthYear.ToString(); //"2000"
            double birthYearDouble = Convert.ToDouble(birthYear); // 2000.0
            char birthYearChar1 = Convert.ToChar(birthYear); // 'ߐ'
            char birhtYearChar = (char)birthYear; //'ߐ'

            int hasPhotoInt = 1;//to boolean
            bool hasPhotoIntBool = Convert.ToBoolean(hasPhotoInt); // false
        }
    }
}
