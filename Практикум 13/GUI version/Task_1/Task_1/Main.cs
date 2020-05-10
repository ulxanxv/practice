using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Task_1 {
    public partial class Main : Form {

        public Main() {
            InitializeComponent();

            // Обработчик на нажатие по кнопкам
            listSoftwareButton.Click += ListSoftwareButton_Click;
            listActivatedSoftwareButton.Click += ListActivatedSoftwareButton_Click;
        }

        private void ListActivatedSoftwareButton_Click(object sender, EventArgs e) {
            findActivatedSoftware(getSoftwares(File.ReadAllText("data.xml").Replace('\n', ' ').Replace('\r', ' ')));
        }

        private void ListSoftwareButton_Click(object sender, EventArgs e) {
            outputSoftwares(getSoftwares(File.ReadAllText("data.xml").Replace('\n', ' ').Replace('\r', ' ')));
        }

        /// <summary>
        /// Поиск активированного ПО
        /// </summary>
        /// <param name="softwares"></param>
        private void findActivatedSoftware(Software[] softwares) {
            listActivatedSoftware.Text = string.Format
                (
                    "||—————————————————||\r\n" +
                    "||АКТИВИРОВАННОЕ ПО||\r\n" +
                    "||—————————————————||\r\n"
                );


            for (int i = 0; i < softwares.Length; ++i) {
                if (softwares[i].use()) {
                    listActivatedSoftware.Text += "—————————————————\r\n";
                    listActivatedSoftware.Text += "Информация о " + softwares[i].ToString() + "\r\n";
                    listActivatedSoftware.Text += softwares[i].info();
                }
            }
        }

        /// <summary>
        /// Вывод всех ПО
        /// </summary>
        /// <param name="softwares"></param>
        private void outputSoftwares(Software[] softwares) {
            listSoftware.Text = string.Format
                (
                    "||—————————————————||\r\n" +
                    "||    СПИСОК ПО    ||\r\n" +
                    "||—————————————————||\r\n"
                );


            for (int i = 0; i < softwares.Length; ++i) {
                listSoftware.Text += "—————————————————\r\n";
                listSoftware.Text += "Информация о " + softwares[i].ToString() + "\r\n";
                listSoftware.Text += softwares[i].info();
                listSoftware.Text += "Можно ли использовать дальше? " + (softwares[i].use() ? "Да\r\n" : "Нет\r\n");
            }
        }

        /// <summary>
        /// Чтение из строки в массив
        /// </summary>
        private Software[] getSoftwares(string data) {
            // Бесплатное ПО
            MatchCollection freewares = Regex.Matches(data, "<freeware>(.*?)</freeware>");
            // Условно-бесплатное ПО
            MatchCollection sharewares = Regex.Matches(data, "<shareware>(.*?)</shareware>");
            // Платное ПО
            MatchCollection commercialSoftwares = Regex.Matches(data, "<commercialsoftware>(.*?)</commercialsoftware>");

            int size = freewares.Count + sharewares.Count + commercialSoftwares.Count,
                softwaresSize = 0;

            Software[] softwares = new Software[size];

            for (int x = 0; x < freewares.Count; ++x) {

                softwares[softwaresSize++] = new Freeware
                    (
                        Regex.Match(freewares[x].Value, "<name>(.*?)</name>").Groups[1].Value,
                        Regex.Match(freewares[x].Value, "<producer>(.*?)</producer>").Groups[1].Value
                    );

            }

            for (int x = 0; x < sharewares.Count; ++x) {

                softwares[softwaresSize++] = new Shareware
                    (
                        DateTime.Parse(Regex.Match(sharewares[x].Value, "<activationDate>(.*?)</activationDate>").Groups[1].Value),
                        int.Parse(Regex.Match(sharewares[x].Value, "<howDays>(.*?)</howDays>").Groups[1].Value),
                        Regex.Match(sharewares[x].Value, "<name>(.*?)</name>").Groups[1].Value,
                        Regex.Match(sharewares[x].Value, "<producer>(.*?)</producer>").Groups[1].Value,
                        DateTime.Parse(Regex.Match(sharewares[x].Value, "<installDate>(.*?)</installDate>").Groups[1].Value),
                        int.Parse(Regex.Match(sharewares[x].Value, "<freeTerm>(.*?)</freeTerm>").Groups[1].Value)
                    );

            }

            for (int x = 0; x < commercialSoftwares.Count; ++x) {

                softwares[softwaresSize++] = new CommercialSoftware
                    (
                        DateTime.Parse(Regex.Match(commercialSoftwares[x].Value, "<activationDate>(.*?)</activationDate>").Groups[1].Value),
                        int.Parse(Regex.Match(commercialSoftwares[x].Value, "<howDays>(.*?)</howDays>").Groups[1].Value),
                        Regex.Match(commercialSoftwares[x].Value, "<name>(.*?)</name>").Groups[1].Value,
                        Regex.Match(commercialSoftwares[x].Value, "<producer>(.*?)</producer>").Groups[1].Value,
                        DateTime.Parse(Regex.Match(commercialSoftwares[x].Value, "<installDate>(.*?)</installDate>").Groups[1].Value),
                        double.Parse(Regex.Match(commercialSoftwares[x].Value, "<price>(.*?)</price>").Groups[1].Value),
                        int.Parse(Regex.Match(commercialSoftwares[x].Value, "<useTerm>(.*?)</useTerm>").Groups[1].Value)
                    );

            }

            return softwares;
        }
    }
}
