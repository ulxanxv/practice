using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Task_1 {
    public partial class Main : Form {
        public Main() {
            InitializeComponent();

            // Обработчик на нажатие по кнопке
            outputButton.Click += OutButton_Click;
        }

        private void OutButton_Click(object sender, EventArgs e) {
            result();
        }

        private void result() {
            if (Directory.Exists(@"C:\temp")) { Directory.Delete(@"C:\temp", true); }

            // 1 пункт задания
            Directory.CreateDirectory(@"C:\temp\K1");
            Directory.CreateDirectory(@"C:\temp\K2");

            // 2 пункт задания
            File.Create(@"C:\temp\K1\t1.txt").Close();
            File.WriteAllText(@"C:\temp\K1\t1.txt", "Иванов Иван Иванович, 1965 года рождения, место жительства г. Саратов");

            File.Create(@"C:\temp\K1\t2.txt").Close();
            File.WriteAllText(@"C:\temp\K1\t2.txt", "Петров Сергей Федорович, 1966 года рождения, место жительства г.Энгельс");

            // 3 пункт задания
            File.Create(@"C:\temp\K2\t3.txt").Close();
            File.WriteAllText(@"C:\temp\K2\t3.txt", File.ReadAllText(@"C:\temp\K1\t1.txt"));
            File.AppendAllText(@"C:\temp\K2\t3.txt", File.ReadAllText(@"C:\temp\K1\t2.txt"));

            // 4 пункт задания
            output.Text += "Информация о — C:\\temp\\K1\\t1.txt" + "\n";
            output.Text += "Полное имя — " + new FileInfo(@"C:\temp\K1\t1.txt").FullName + "\n";
            output.Text += "Дата создания — " + new FileInfo(@"C:\temp\K1\t1.txt").CreationTime + "\n";
            output.Text += "Расширение —" + new FileInfo(@"C:\temp\K1\t1.txt").Extension + "\n";

            output.Text += "Информация о — C:\\temp\\K1\\t2.txt";
            output.Text += "Полное имя — " + new FileInfo(@"C:\temp\K1\t2.txt").FullName + "\n";
            output.Text += "Дата создания — " + new FileInfo(@"C:\temp\K1\t2.txt").CreationTime + "\n";
            output.Text += "Расширение —" + new FileInfo(@"C:\temp\K1\t2.txt").Extension + "\n";

            output.Text += "Информация о — C:\\temp\\K2\\t3.txt";
            output.Text += "Полное имя — " + new FileInfo(@"C:\temp\K2\t3.txt").FullName + "\n";
            output.Text += "Дата создания — " + new FileInfo(@"C:\temp\K2\t3.txt").CreationTime + "\n";
            output.Text += "Расширение —" + new FileInfo(@"C:\temp\K2\t3.txt").Extension + "\n";

            // 5 пункт задания
            File.Move(@"C:\temp\K1\t2.txt", @"C:\temp\K2\t2.txt");

            // 6 пункт задания
            File.Copy(@"C:\temp\K1\t1.txt", @"C:\temp\K2\t1.txt");

            // 7 пункт задания
            Directory.Move(@"C:\temp\K2", @"C:\temp\All");
            Directory.Delete(@"C:\temp\K1", true);

            // 8 пункт задания
            FileInfo[] fileInfo = new DirectoryInfo(@"C:\temp\All").GetFiles();
            output.Text += "\n\nИнформации о файлах и папках папки \"All\"\n";
            foreach (FileInfo info in fileInfo) {
                output.Text += "Полное имя — " + info.FullName + "\n";
                output.Text += "Дата создания — " + info.CreationTime + "\n";
                output.Text += "Расширение —" + info.Extension + "\n";
            }
        }
    }
}
