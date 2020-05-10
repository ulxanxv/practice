using System;

namespace Task_1 {
    class Freeware : Software {

        protected string name;
        protected string producer;

        public Freeware(DateTime activationDate, int howDays)
            : base(activationDate, howDays) {

            this.activationDate = activationDate;
            this.howDays = howDays;
        }

        // Так как ПО бесплатное — дней активации бесконечно (конечно, но очень много :) ).
        public Freeware(string name, string producer)
            : base(DateTime.Now, 65536) {

            this.name = name;
            this.producer = producer;
        }

        public override String info() {
            return  "Дата активации — " + activationDate.ToShortDateString() + "\r\n" +
                    "Дней активации — " + howDays + "\r\n" +
                    "Название — " + name + "\r\n" +
                    "Производитель — " + producer + "\r\n";
        }

        public override string ToString() {
            return "Бесплатное ПО";
        }

        public override bool use() {
            if (activationDate.AddDays(howDays) > DateTime.Now) {
                return true;
            } else {
                return false;
            }
        }
    }
}
