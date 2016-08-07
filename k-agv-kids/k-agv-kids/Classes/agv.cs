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

       
    }
}
