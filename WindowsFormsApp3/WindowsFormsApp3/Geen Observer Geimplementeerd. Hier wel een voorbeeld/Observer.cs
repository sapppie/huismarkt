using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HuizenmarktApp.Observer
{
    public class Observer
    {
        private delegate void ColorEventHandler(string _color);
        private event ColorEventHandler ColorChangedEvent;
        private TextBox txt;

        public Observer(TextBox _txt)
        {
            this.ColorChangedEvent += new ColorEventHandler(Observer_ColorChangedEvent);
            this.txt = _txt;
        }

        private void OnChange(string _color)
        {
            if (ColorChangedEvent != null)
            {
                ColorChangedEvent(_color);
            }
        }

        public void Update(string _color)
        {
            OnChange(_color);
        }

        private void Observer_ColorChangedEvent(string _color)
        {
            switch (_color)
            {
                case "RED":
                  //  txt.BackColor = Color.Red;
                    break;
                case "BLUE":
                  //  txt.BackColor = Color.Blue;
                    break;
                case "GREEN":
                  //  txt.BackColor = Color.Green;
                    break;
                default:
                   // txt.BackColor = Color.Gray;
                    break;
            }
        }
    }
}
