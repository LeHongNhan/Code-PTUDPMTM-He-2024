using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeHongNhan_B01
{
    public class xuLyMatran
    {
        int hang;

        public int Hang
        {
            get { return hang; }
            set { hang = value; }
        }
        int cot;

        public int Cot
        {
            get { return cot; }
            set { cot = value; }
        }
        public xuLyMatran(int hang, int cot)
        {
            this.cot = cot;
            this.hang = hang;
        }
        public Panel _BanCo { get; set; }
        public xuLyMatran() { }
        public void phatSinhOCo(ProgressBar progressBar1, Panel pnlBanCo, int hang, int cot)
        {
            this._BanCo= pnlBanCo;
            progressBar1.Maximum = hang * cot;
            _BanCo.Controls.Clear();
            int left = 0;
            int top = 0;
            for (int i = 0; i < hang; i++)
            {
                for (int j = 0; j < cot; j++)
                {
                    Button B = new Button();
                    B.Size = new Size(40, 40);
                    B.Left = left;
                    B.Top = top;
                    _BanCo.Controls.Add(B);
                    B.Click += B_Click;
                    progressBar1.Value = progressBar1.Value + 1;
                    left += 40;
                }
                left = 0;
                top += 40;
                pnlBanCo = this._BanCo;
            }
        }
        void B_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.Text != String.Empty)
            {
                MessageBox.Show("Không đánh 1 ô 2 lần");
                return;
            }
            if (MaTran.checkO)
            {
                btn.Text = "O";
                MaTran.checkO = false;
            }
            else
            {
                btn.Text = "X";
                MaTran.checkO = true;
            }
            if (checkWin(btn, _BanCo))
            {
                MessageBox.Show((btn.Text == "O") ? "O chiến thắng!" : "X chiến thắng!");
            }
        }
        /// <summary>
        /// Check 4 trường hợp khong Enum
        /// </summary>
        /// <param name="btn">Nút sẽ đánh xuống và bị xét</param>
        /// <param name="pnlBanCo">Truyền vào panel chứa những nút cờ</param>
        /// <returns></returns>
        private bool checkWin(Button btn, Panel pnlBanCo)
        {
            int row = pnlBanCo.Controls.IndexOf(btn) / Cot;
            int col = pnlBanCo.Controls.IndexOf(btn) % Cot;

            for (int i = col - 4; i <= col; i++)
            {
                if (i < 0 || i >= Cot) continue;
                Button otherBtn = (Button)pnlBanCo.Controls[row * Cot + i];
                if (otherBtn.Text != btn.Text || otherBtn.Text == String.Empty) break;
                if (i == col - 4) return true; 
            }
            for (int i = row - 4; i <= row; i++)
            {
                if (i < 0 || i >= Hang) continue;
                Button otherBtn = (Button)pnlBanCo.Controls[i * Cot + col];
                if (otherBtn.Text != btn.Text || otherBtn.Text == String.Empty) break;
                if (i == row - 4) return true; 
            }
            for (int i = row - 4, j = col - 4; i <= row && j <= col; i++, j++)
            {
                if (i < 0 || i >= Hang || j < 0 || j >= Cot) continue;
                Button otherBtn = (Button)pnlBanCo.Controls[i * Cot + j];
                if (otherBtn.Text != btn.Text || otherBtn.Text == String.Empty) break;
                if (i == row - 4 && j == col - 4) return true; 
            }
            return false;
        }
    }
}
