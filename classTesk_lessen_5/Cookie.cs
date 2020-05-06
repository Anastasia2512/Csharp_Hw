using System;
using System.Collections.Generic;
using System.Text;

namespace classTesk_lssn_5
{
    class Cookie
    {
        private int numOfEggs;
        public int NumOfEggs
        {
            get { return numOfEggs; }
            set { numOfEggs = value; }
        }

        private int suger;
        public int Suger
        {
            get { return suger; }
            set { suger = value; }
        }

        private Double flour;
        public double Flour
        {
            get { return flour; }
            set { flour = value; }
        }

        private Boolean gluten;
        public Boolean Gluten
        {
            get { return gluten; }
            set { gluten = value; }
        }

    }
}
