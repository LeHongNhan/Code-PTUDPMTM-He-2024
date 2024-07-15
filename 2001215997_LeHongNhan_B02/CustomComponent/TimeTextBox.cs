using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace CustomComponent
{
    public class TimeTextBox:MaskedTextBox
    {
        public TimeTextBox() {
            this.Mask = "00:00:00";
            this.ValidatingType = typeof(TimeSpan); // Optional: For time validation
            this.TypeValidationCompleted += TimeTextBox_TypeValidationCompleted;
        }

        private void TimeTextBox_TypeValidationCompleted(object sender, TypeValidationEventArgs e)
        {
            if (!e.IsValidInput)
            {
                MessageBox.Show("Nhập không đúng định dạng thời gian", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public (int, int, int) GetTime()
        {
            if (TimeSpan.TryParse(this.Text, out TimeSpan time))
            {
                return (time.Hours, time.Minutes, time.Seconds);
            }
            else
            {
                throw new FormatException("Invalid time format");
            }
        }
    }
}
