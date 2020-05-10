using System;

namespace Task_1 {
    class Shareware : Freeware {

        private DateTime installDate;
        private int freeTerm;

        public Shareware(DateTime activationDate, int howDays, string name, string producer, DateTime installDate, int freeTerm)
            : base(name, producer) {

            this.activationDate = activationDate;
            this.howDays = howDays;
            this.installDate = installDate;
            this.freeTerm = freeTerm;
        }

        public override String info() {
            return  base.info() +
                    "Дата установки — " + installDate.ToShortDateString() + "\r\n" +
                    "Срок бесплатного использования — " + freeTerm + "\r\n";
        }

        public override bool use() {
            return base.use();
        }

        public override string ToString() {
            return "Условно-бесплатное ПО";
        }
    }
}
