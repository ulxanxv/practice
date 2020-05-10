using System;

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

        public override String info() {
            return  base.info() +
                    "Дата установки — " + installDate.ToShortDateString() + "\r\n" +
                    "Цена — " + price + "$ / MONTH" + "\r\n" +
                    "Срок использования — " + useTerm + "\r\n";
        }

        public override bool use() {
            return base.use();
        }

        public override string ToString() {
            return "Коммерческое ПО";
        }
    }
}
