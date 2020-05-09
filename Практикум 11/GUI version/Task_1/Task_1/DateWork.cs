using System;

namespace Task_1 {
    class DateWork {
        private DateTime date;

        public DateTime Date {
            get {
                return date;
            }
            set {
                date = value;
            }
        }

        /// <summary>
        /// Високосный год или нет
        /// </summary>
        public bool LeapYear {
            get {
                if (date.Year % 4 == 0) {
                    if (date.Year % 100 == 0) {
                        if (date.Year % 400 == 0) {
                            return true;
                        } else {
                            return false;
                        }
                    } else {
                        return true;
                    }
                } else {
                    return false;
                }
            }
        }

        /// <summary>
        /// По умолчанию устанавливается 01.01.2009
        /// </summary>
        public DateWork() {
            date = DateTime.Parse("01.01.2009");
        }

        public DateWork(string dateTime) {
            date = DateTime.Parse(dateTime);
        }

        public string yesterdayDate() {
            return date.AddDays(-1).ToShortDateString();
        }

        public string tomorrowDate() {
            return date.AddDays(1).ToShortDateString();
        }

        public int howEnd() {
            return DateTime.DaysInMonth(date.Year, date.Month) - date.Day;
        }
    }
}
