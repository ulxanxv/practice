using System;
using System.Collections.Generic;
using System.Text;

namespace Task_1 {
    abstract class Software {

        protected DateTime activationDate;
        protected int howDays;

        public Software(DateTime activationDate, int howDays) {
            this.activationDate = activationDate;
            this.howDays        = howDays;
        }

        abstract public void info();
        abstract public bool use();

        abstract public override string ToString();
    }
}
