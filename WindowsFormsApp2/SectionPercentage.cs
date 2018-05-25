using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public class SectionPercentage
    {

    public float GetUPPercent(int finishID)
        {
          
            float upPercent;
            switch (finishID)
            {
                //NO FINISH
                case 1:
                case 3:
                case 6:
                    upPercent = 0.0f;
                    break;
                //ETCH PRIME
                case 2:
                    upPercent = 0.2f;
                    break;
                //TWO TONE WET
                case 4:
                case 10:
                    upPercent = 0.09f;
                    break;
                //JUST WET PAINT
                case 5:
                    upPercent = 0.15f;
                    break;
                //POWDER COATING AND TWO TONE FRAME/LEAF + TWO TONE COASTAL GRADE 
                case 7:
                case 11:
               
                    upPercent = 0.2f;

                    break;
                
                //COASTAL GRADE
                case 9:
                case 12:
                case 13:
                    upPercent = 0.1f;
                    break;

                case 14:
                    upPercent = 0.1f;
                    break;
                default:
                    upPercent = 0.2f;
                   
                    break;

            }
          
            return upPercent;
            
        }

        public float GetWWPercent(int finishID)
        {

            float wwPercent;
            switch (finishID)
            {
                //NO FINISH
                case 1:
                case 3:
                case 6:
                    wwPercent = 0.0f;
                    break;
                //ETCH PRIME
                case 2:
                    wwPercent = 0.2f;
                    break;
                //TWO TONE WET
                case 4:
                case 10:
                    wwPercent = 0.09f;
                    break;
                //JUST WET PAINT
                case 5:
                    wwPercent = 0.1f;
                    break;
                //POWDER COATING AND TWO TONE FRAME/LEAF + TWO TONE COASTAL GRADE 
                case 7:
                case 11:
                
                    wwPercent = 0.17f;

                    break;

                //COASTAL GRADE
                case 9:
                case 12:
                case 13:
                    wwPercent = 0.1f;

                    break;
                case 14:
                    wwPercent = 0.1f;
                    break;
                default:
                    wwPercent = 0.17f;

                    break;

            }

            return wwPercent;

        }

        public float GetETCHPercent(int finishID)
        {

            float etchPercent;
            switch (finishID)
            {
                //NO FINISH
                case 1:
                case 3:
                case 6:
                    etchPercent = 0.0f;
                    break;
                //ETCH PRIME
                case 2:
                    etchPercent = 0.2f;
                    break;
                //TWO TONE WET
                case 4:
                case 10:
                    etchPercent = 0.09f;
                    break;
                //JUST WET PAINT
                case 5:
                    etchPercent = 0.15f;
                    break;
                //POWDER COATING AND TWO TONE FRAME/LEAF + TWO TONE COASTAL GRADE 
                case 7:
                case 11:
                
                    etchPercent = 0.17f;

                    break;

                //COASTAL GRADE
                case 9:
                case 12:
                case 13:
                    etchPercent = 0.1f;

                    break;
                case 14:
                    etchPercent = 0.1f;
                    break;
                default:
                    etchPercent = 0.17f;

                    break;

            }

            return etchPercent;

        }

        public float GetSANDPercent(int finishID)
        {

            float sandPercent;
            switch (finishID)
            {
                //NO FINISH
                case 1:
                case 3:
                case 6:
                    sandPercent = 0.0f;
                    break;
                //ETCH PRIME
                case 2:
                    sandPercent = 0.2f;
                    break;
                //TWO TONE WET
                case 4:
                case 10:
                    sandPercent = 0.09f;
                    break;
                //JUST WET PAINT
                case 5:
                    sandPercent = 0.1f;
                    break;
                //POWDER COATING AND TWO TONE FRAME/LEAF + TWO TONE COASTAL GRADE 
                case 7:
                case 11:
                
                    sandPercent = 0.12f;

                    break;

                //COASTAL GRADE
                case 9:
                case 12:
                case 13:
                    sandPercent = 0.1f;

                    break;
                case 14:
                    sandPercent = 0.1f;
                    break;
                default:
                    sandPercent = 0.12f;

                    break;

            }

            return sandPercent;

           

        }

        public float GetPPPercent(int finishID)
        {

            float ppPercent;
            switch (finishID)
            {
                //NO FINISH
                case 1:
                case 3:
                case 6:
                    ppPercent = 0.0f;
                    break;
                //ETCH PRIME
                case 2:
                    ppPercent = 0.0f;
                    break;
                //TWO TONE WET
                case 4:
                case 10:
                    ppPercent = 0.0f;
                    break;
                //JUST WET PAINT
                case 5:
                    ppPercent = 0.0f;
                    break;
                //POWDER COATING AND TWO TONE FRAME/LEAF + TWO TONE COASTAL GRADE 
                case 7:
                case 11:
                
                    ppPercent = 0.0f;
                    break;
                //COASTAL GRADE
                case 9:
                case 12:
                case 13:
                    ppPercent = 0.2f;

                    break;
                case 14:
                    ppPercent = 0.1f;
                    break;
                default:
                    ppPercent = 0.0f;

                    break;

            }

            return ppPercent;



        }

        public float GetPCPercent(int finishID)
        {

            float pcPercent;
            switch (finishID)
            {
                //NO FINISH
                case 1:
                case 3:
                case 6:
                    pcPercent = 0.0f;
                    break;
                //ETCH PRIME
                case 2:
                    pcPercent = 0.0f;
                    break;
                //TWO TONE WET
                case 4:
                case 10:
                    pcPercent = 0.12f;
                    break;
                //JUST WET PAINT
                case 5:
                    pcPercent = 0.0f;
                    break;
                //POWDER COATING AND TWO TONE FRAME/LEAF + TWO TONE COASTAL GRADE 
                case 7:
                case 11:
                
                    pcPercent = 0.22f;

                    break;

                //COASTAL GRADE
                case 9:
                case 12:
                case 13:
                    pcPercent = 0.2f;

                    break;
                case 14:
                    pcPercent = 0.1f;
                    break;
                default:
                    pcPercent = 0.22f;

                    break;

            }

            return pcPercent;

        }

        public float GetOVENPercent(int finishID)
        {

            float ovenPercent;
            switch (finishID)
            {
                //NO FINISH
                case 1:
                case 3:
                case 6:
                    ovenPercent = 0.0f;
                    break;
                //ETCH PRIME
                case 2:
                    ovenPercent = 0.2f;
                    break;
                //TWO TONE WET
                case 4:
                case 10:
                    ovenPercent = 0.11f;
                    break;
                //JUST WET PAINT
                case 5:
                    ovenPercent = 0.1f;
                    break;
                //POWDER COATING AND TWO TONE FRAME/LEAF + TWO TONE COASTAL GRADE 
                case 7:
                case 11:
                
                    ovenPercent = 0.12f;

                    break;

                //COASTAL GRADE
                case 9:
                case 12:
                case 13:
                    ovenPercent = 0.1f;

                    break;
                case 14:
                    ovenPercent = 0.1f;
                    break;
                default:
                    ovenPercent = 0.12f;

                    break;

            }

            return ovenPercent;

        }

        public float GetWPPercent(int finishID)
        {

            float wpPercent;
            switch (finishID)
            {
                //NO FINISH
                case 1:
                case 3:
                case 6:
                    wpPercent = 0.0f;
                    break;
                //ETCH PRIME
                case 2:
                    wpPercent = 0.0f;
                    break;
                //TWO TONE WET
                case 4:
                case 10:
                    wpPercent = 0.15f;
                    break;
                //JUST WET PAINT
                case 5:
                    wpPercent = 0.2f;
                    break;
                //POWDER COATING AND TWO TONE FRAME/LEAF + TWO TONE COASTAL GRADE 
                case 7:
                case 11:
                
                    wpPercent = 0.0f;

                    break;

                //COASTAL GRADE
                case 9:
                case 12:
                case 13:
                    wpPercent = 0.0f;

                    break;
                case 14:
                    wpPercent = 0.1f;
                    break;
                default:
                    wpPercent = 0.0f;

                    break;

            }

            return wpPercent;

        }


        public float GetWETPercent(int finishID)
        {

            float wetPercent;
            switch (finishID)
            {
                //NO FINISH
                case 1:
                case 3:
                case 6:
                    wetPercent = 0.0f;
                    break;
                //ETCH PRIME
                case 2:
                    wetPercent = 0.0f;
                    break;
                //TWO TONE WET
                case 4:
                case 10:
                    wetPercent = 0.15f;
                    break;
                //JUST WET PAINT
                case 5:
                    wetPercent = 0.2f;
                    break;
                //POWDER COATING AND TWO TONE FRAME/LEAF + TWO TONE COASTAL GRADE 
                case 7:
                case 11:
                
                    wetPercent = 0.0f;

                    break;

                //COASTAL GRADE
                case 9:
                case 12:
                case 13:
                    wetPercent = 0.0f;

                    break;
                case 14:
                    wetPercent = 0.1f;
                    break;
                default:
                    wetPercent = 0.0f;

                    break;

            }

            return wetPercent;

        }

        public float GetOVEN2Percent(int finishID)
        {

            float oven2Percent;
            switch (finishID)
            {
                //NO FINISH
                case 1:
                case 3:
                case 6:
                    oven2Percent = 0.0f;
                    break;
                //ETCH PRIME
                case 2:
                    oven2Percent = 0.0f;
                    break;
                //TWO TONE WET
                case 4:
                case 10:
                    oven2Percent = 0.11f;
                    break;
                //JUST WET PAINT
                case 5:
                    oven2Percent = 0.0f;
                    break;
                //POWDER COATING AND TWO TONE FRAME/LEAF + TWO TONE COASTAL GRADE 
                case 7:
                case 11:
                
                    oven2Percent = 0.0f;

                    break;

                //COASTAL GRADE
                case 9:
                case 12:
                case 13:
                    oven2Percent = 0.1f;

                    break;
                case 14:
                    oven2Percent = 0.1f;
                    break;
                default:
                    oven2Percent = 0.0f;

                    break;

            }

            return oven2Percent;

        }
    }
     
        
}



