using System;
using System.Windows.Forms;

namespace Components {
    public partial class Main : Form {
        public Main() {
            InitializeComponent();

            this.Load += Main_Load;

            this.firstButton.Click              += Button_Click;
            this.exeptionsButton.Click          += Button_Click;
            this.statusStripButton.Click        += Button_Click;
            this.statusStripButton2.Click       += Button_Click;
            this.paintButton.Click              += Button_Click;
            this.createThreadButton.Click       += Button_Click;
            this.workWithXMLButton.Click        += Button_Click;
            this.menuButton.Click               += Button_Click;
            this.createContextButton.Click      += Button_Click;
            this.classButton.Click              += Button_Click;
            this.separatorButton.Click          += Button_Click;
            this.nonStandartButton.Click        += Button_Click;
            this.getAllFontsButton.Click        += Button_Click;
            this.workWithTreeViewButton.Click   += Button_Click;
            this.styleButton.Click              += Button_Click;
            this.viewCatalogsButton.Click       += Button_Click;
            this.createClassButton.Click        += Button_Click;
            this.useLinkButton.Click            += Button_Click;
            this.showOneForMoreButton.Click     += Button_Click;
            this.cBTreeViewButton.Click         += Button_Click;
            this.tabControlButton.Click         += Button_Click;
            this.sendDataButton.Click           += Button_Click;
            this.chooseColorButton.Click        += Button_Click;
            this.saveSettingsButton.Click       += Button_Click;
            this.chooseFontButton.Click         += Button_Click;
            this.dialogForFileButton.Click      += Button_Click;
            this.dialogCloseFileButton.Click    += Button_Click;
            this.exampleBtnButton.Click         += Button_Click;
        }

        private void Button_Click(object sender, EventArgs e) {
            switch ((sender as ToolStripDropDownItem).Text.Split(' ')[0]) {
                case "#1": new First().ShowDialog(); break;
                case "#2": new Second().ShowDialog(); break;
                case "#3": new Third().ShowDialog(); break;
                case "#4": new Fourth().ShowDialog(); break;
                case "#5": new Fifth().ShowDialog(); break;
                case "#6": new Sixth().ShowDialog(); break;
                case "#7": new Seventh().ShowDialog(); break;
                case "#8": new Eighth().ShowDialog(); break;
                case "#9": new Ninth().ShowDialog(); break;
                case "#10": new Tenth().ShowDialog(); break;
                case "#11": new Eleventh().ShowDialog(); break;
                case "#12": new Twelfth().ShowDialog(); break;
                case "#13": new Thirteenth().ShowDialog(); break;
                case "#14": new Fourteenth().ShowDialog(); break;
                case "#17": new Seventeenth().ShowDialog(); break;
                case "#18": new Eighteenth().ShowDialog(); break;
                case "#21": new TwentyFirst().ShowDialog(); break;
                case "#22": new TwentyTwo().ShowDialog(); break;
                case "#23": new TwentyThird().ShowDialog(); break;
                case "#24": new TwentyFour().ShowDialog(); break;
                case "#25": new TwentyFive().ShowDialog(); break;
                case "#26": new TwentySixth().ShowDialog(); break;
                case "#27": new TwentySeventh().ShowDialog(); break;
                case "#28": new TwentyEight().ShowDialog(); break;
                case "#29": new TwentyNinth().ShowDialog(); break;
                case "#30": new Thirtieth().ShowDialog(); break;
                case "#31": new ThirtyFirst().ShowDialog(); break;
                case "#32": new ThirtySecond().ShowDialog(); break;
            }
        }

        private void Main_Load(object sender, EventArgs e) {
            MessageBox.Show("В списке меню есть такие пункты, где нумерация сбивается — она не сбивается, потому что некоторые уроки являются прямыми продолжениями предыдущих, но позиционируются как отдельные!", "Предупреждение");
        }

    }
}
