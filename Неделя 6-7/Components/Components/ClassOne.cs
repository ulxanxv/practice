using System.Windows.Forms;

namespace Components {
    public class ClassOne : ISomeInterface {
        public void someMethod() {
            MessageBox.Show("Я ClassOne!");
        }
    }
}
