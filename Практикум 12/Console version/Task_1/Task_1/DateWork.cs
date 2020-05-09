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

        public string this[int days] {
            get {
                return date.AddDays(days).ToShortDateString();
            }
        }

        public static bool operator !(DateWork dateWork) {
            if (dateWork.Date.Day != DateTime.DaysInMonth(dateWork.Date.Year, dateWork.Date.Month)) {
                return true;
            } else {
                return false;
            }
        }

        public static bool operator true(DateWork dateWork) {
            if (dateWork.Date.DayOfYear == 1) {
                return true;
            } else {
                return false;
            }
        }

        public static bool operator false(DateWork dateWork) {
            if (dateWork.Date.DayOfYear != 1) {
                return true;
            } else {
                return false;
            }
        }

        public static bool operator &(DateWork dateWork1, DateWork dateWork2) {
            if (dateWork1.Date == dateWork2.Date) {
                return true;
            } else {
                return false;
            }
        }

        public static explicit operator string(DateWork dateWork) {
            return dateWork.Date.ToString();
        }

        public static explicit operator DateWork(string dateWork) {
            return new DateWork(DateTime.Parse(dateWork));
        }

        public DateWork() {
            this.date = DateTime.Parse("01.01.2009");
        }

        public DateWork(DateTime date) {
            this.date = date;
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
