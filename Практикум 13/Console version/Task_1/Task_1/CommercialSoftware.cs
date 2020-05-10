using System;
using System.Collections.Generic;
using System.Text;

namespace Task_1 {
    class CommercialSoftware : Freeware {

        private DateTime installDate;
        private double price;
        private int useTerm;

        public CommercialSoftware(DateTime activationDate, int howDays, string name, string producer, DateTime installDate, double price, int useTerm)
            : base(name, producer) {

            this.activationDate = activationDate;
            this.howDays = howDays;
            this.installDate = installDate;
            this.price = price;
            this.useTerm = useTerm;
        }

        public override void info() {
            base.info();

            Console.WriteLine("Дата установки — " + installDate.ToShortDateString());
            Console.WriteLine("Цена — " + price + "$ / MONTH");
            Console.WriteLine("Срок использования — " + useTerm);
        }

        public override bool use() {
            return base.use();
        }

        public override string ToString() {
            return "Коммерческое ПО";
        }
    }
}
