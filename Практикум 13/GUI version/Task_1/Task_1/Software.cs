using System;

namespace Task_1 {
    abstract class Software {

        protected DateTime activationDate;
        protected int howDays;

        public Software(DateTime activationDate, int howDays) {
            this.activationDate = activationDate;
            this.howDays = howDays;
        }

        abstract public String info();
        abstract public bool use();
        abstract public override string ToString();
    }
}
