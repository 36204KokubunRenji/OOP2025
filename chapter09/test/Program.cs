using static System.Net.Mime.MediaTypeNames;
using System.Reflection.Emit;

namespace test {
    internal class Program {
        static void Main(string[] args) {
            using System;
            using System.Windows.Forms;

public class TimeForm : Form {
            private Label timeLabel;
            private Timer timer;

            public TimeForm() {
                // フォームの設定
                this.Text = "リアルタイム時計";
                this.Width = 300;
                this.Height = 100;

                // Labelの作成
                timeLabel = new Label();
                timeLabel.Text = DateTime.Now.ToString("HH:mm:ss");
                timeLabel.AutoSize = true;
                timeLabel.Location = new System.Drawing.Point(10, 10);
                this.Controls.Add(timeLabel);

                // Timerの作成
                timer = new Timer();
                timer.Interval = 1000; // 1秒ごとに更新
                timer.Tick += Timer_Tick;
                timer.Start();
            }

            private void Timer_Tick(object sender, EventArgs e) {
                timeLabel.Text = DateTime.Now.ToString("HH:mm:ss");
            }

            [STAThread]
            public static void Main() {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new TimeForm());
            }
        }
    }
    }
}
