using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace k_agv_kids
{
    class agv
    {
      
        public int type;

        
        //electric rate of CO2
        protected int e_co2 = 1;
        //electric rate of NO2
        protected int e_no2 = 1;

        //petrol rate of CO2
        protected int p_co2 = 2;
        //petrol rate of NO2
        protected int p_no2 = 2;

        //LPG rate of CO2
        protected int l_co2 = 1;
        //LPG rate of NO2
        protected int l_no2 = 2;
    


        //overloading the constructors
        

        /// <summary>
        /// Determines the type of AGV.
        /// <para>
        /// 1=electric
        /// </para>
        /// <para>
        /// 2=petrol
        /// </para>
        /// <para>
        /// 3=LPG
        /// </para>
        /// </summary>
        public agv(int agvType)
        {
            if (agvType > 3 || agvType < 0)
            {
                MessageBox.Show("Unsupported AGV type.Please check the class's API");
            }
            else
            {
                type = agvType;
            }
            
        }

        public agv() { }

        /// <summary>
        /// Function to check emissions CO2 of AGV
        /// </summary>
        /// <returns>Returns the predeclared emissions of selected AGV</returns>
        public int checkEmissionsCO2()
        {
            if (type == 1)
            {
                return e_co2;                  
            }
            else if (type == 2)
            {
                return p_co2;   
            }
            else
            {
                return l_co2;   
            }
        }

        /// <summary>
        /// Function to check emissions NO2 of AGV
        /// </summary>
        /// <returns>Returns the predeclared emissions of selected AGV</returns>
        public int checkEmissionsNO2()
        {
            if (type == 1)
            {
                return e_no2; 
            }
            else if (type == 2)
            {  
                return p_no2;
            }
            else 
            {
                return l_no2;
            }
            
        }
    }
}
