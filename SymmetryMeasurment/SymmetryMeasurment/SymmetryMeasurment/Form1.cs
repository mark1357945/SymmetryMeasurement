/*
 * 
 * 對稱性分析軟體Symmetry Measurement的GUI介面, 需先開啟Matlab分析軟體Symmetry Calculator搭配使用
 * 
 * Instrument
 *  1.輸入"病患ID"、選擇"資料存放資料夾"路徑
 *  2.按下"開始", 病患開始動作
 *  3.錄製結束, 按下"暫停"
 * 
 * Process
 *  1.按下"開始"錄製骨架資料, 結束後資料會丟到選定資料夾內
 *  2.Matlab分析軟體Symmetry Calculator在選定資料夾捕捉到新的骨架資料後, 計算對稱性結果並將他輸出到選定資料夾
 *  3.Symmetry Measurement捕捉到結果後, 顯示在右側的結果欄上
 * 
 * Input
 *  經由Kinect錄影獲得的人體骨架資料
 * 
 * Output
 *  顯示此人的對稱性量化結果於程式介面
 *  
 * Extra
 *  1.Symmetry Measurement和Symmetry Calculator所選用的資料夾必須為同一個
 *  2.若想將此次結果存入使用者以前的紀錄, 需要將產出的資料手動複製到該病患名稱的資料夾下 
 * 
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace SymmetryMeasurment
{
    public partial class Form1 : Form
    {
        ///////////////////////////////////////////////// 
        /////////////       參數設定       //////////////
        ///////////////////////////////////////////////// 

            

        ////////////////////////////////////////////////
        /////////////       公用變數       /////////////
        //////////////////////////////////////////////// 
        
        // 暫停的時候有骨架也不會抓資料
        Boolean isStart = false;

        // 按下開始時, 將選擇的資料夾路徑存起來
        String DirectoryPath = "";
        String SubjectID = ""; 
        
        //////////////////////////////////////////////// 
        //////////////       函式區       //////////////
        //////////////////////////////////////////////// 

        public Form1()
        {
            InitializeComponent();
        }

        // 選擇Data所在的資料夾
        private void Choose_MainDirectory(object sender, EventArgs e)
        {
            FolderBrowserDialog path = new FolderBrowserDialog();
            path.ShowDialog();
            this.textBox_directory.Text = path.SelectedPath;
        }

        // 顯示使用說明
        private void Show_Instrument(object sender, EventArgs e)
        {
            MessageBox.Show(" 對稱性分析軟體Symmetry Measurement的GUI介面, \n"
                            + " 需先開啟Matlab分析軟體Symmetry Calculator搭配使用\n"
                            + "\n"
                            + " Instrument\n"
                            + "  0.執行Matlab分析軟體Symmetry Calculator, 讓其開著執行\n"
                            + "  1.輸入\"病患ID\"、選擇\"資料存放資料夾\"路徑\n"
                            + "  2.按下\"開始\", 病患開始動作\n"
                            + "  3.錄製結束, 按下\"暫停\", 觀看結果\n"
                            + " \n"
                            + " Process\n"
                            + "  1.按下\"開始\"錄製骨架資料, 結束後資料會丟到選定資料夾內\n"
                            + "  2.Matlab分析軟體Symmetry Calculator在選定資料夾捕捉到新\n"
                            + "    的骨架資料後, 計算對稱性結果並將他輸出到選定資料夾\n"
                            + "  3.Symmetry Measurement捕捉到結果後, 顯示在右側的結果欄上\n"
                            + " \n"
                            + " Input\n"
                            + "  經由Kinect錄影獲得的人體骨架資料\n"
                            + " \n"
                            + " Output\n"
                            + "  顯示病患的對稱性量化結果於程式介面\n"
                            + "  \n"
                            + " Extra\n"
                            + "  1.Symmetry Measurement和Symmetry Calculator所選用的資料夾\n"
                            + "    必須為同一個\n"
                            + "  2.若想將此次結果存入使用者以前的紀錄, \n"
                            + "    需要將產出的資料手動複製到該病患名稱的資料夾下 \n"
                            + " \n"
                            + "\n");
        }

        // 改變isStart來改變"抓資料/暫停抓資料"狀態
        // 按下開始檢查資料夾是否存在, 沒有的話創造
        private void Start_Capture(object sender, EventArgs e)
        {
            button_start.Enabled = false;
            button_pause.Enabled = true;
            DirectoryPath = textBox_directory.Text;
            SubjectID = textBox_subjectID.Text;

            if (!Directory.Exists(DirectoryPath+"//Old Data"))
            {
                //新增Past資料夾
                Directory.CreateDirectory(DirectoryPath+"//Old Data");
            }
            
            if (!Directory.Exists(DirectoryPath + "//Old Data//" + SubjectID))
            {
                //新增使用者資料夾
                Directory.CreateDirectory(DirectoryPath + "//Old Data//" + SubjectID);
            }

            isStart = true;
        }
        private void Pause_Capture(object sender, EventArgs e)
        {
            button_pause.Enabled = false;
            button_start.Enabled = true;
            isStart = false;
        }


        // 將對稱性的計算結果, 以文字顯示在GroupBox_Self和GroupBox_Past內
        private void Show_result(object sender, EventArgs e) //******************
        {
            ColorLabel label = new ColorLabel();
            label.Text = "ABC";
            label.AppendText("DEF", Color.Red);
            label.AppendText("G", Color.Blue);
            label.AppendText("H", Color.Yellow);
            label.Location = new Point(23, 30);
            label.Font = new Font("標楷體", 16, FontStyle.Italic);
            label.Size = new Size(250, 500);
            groupBox_Self.Controls.Add(label);
        }
        
        ////////////============================= Reference ===================================//////////////
        ////////////============================= Reference ===================================//////////////

        // 一個ColorLabel可以使用很多個顏色文字
        class ColorLabel : Control
        {
            public ColorLabel()
                : base()
            {
                this.textList = new List<string>();
                this.colorList = new List<Color>();
                this.Padding = new Padding(0);
            }

            List<string> textList;
            List<Color> colorList;

            public void AppendText(string text, Color color)
            {
                if (!string.IsNullOrEmpty(text))
                {
                    this.textList.Add(text);
                    this.colorList.Add(color);
                    base.Text = string.Concat(this.textList.ToArray());
                }
            }

            public override string Text
            {
                get
                {
                    return base.Text;
                }
                set
                {
                    //base.Text = value;                                 
                    this.textList.Clear();
                    this.colorList.Clear();
                    this.AppendText(value, Color.Empty);
                }
            }

            protected override void OnPaint(PaintEventArgs e)
            {
                base.OnPaint(e);
                float x = 0;
                for (int i = 0; i < this.textList.Count; i++)
                {
                    Color c = this.colorList[i];
                    using (Brush brush = new SolidBrush(c == Color.Empty ? this.ForeColor : c))
                    {
                        string str = this.textList[i];
                        e.Graphics.DrawString(str, this.Font, brush, x, 0);
                        x += e.Graphics.MeasureString(str, this.Font, this.ClientSize.Width, StringFormat.GenericTypographic).Width;
                        if (x > this.ClientSize.Width)
                            break;
                    }
                }
            }
        }

        ////////////============================= Reference ===================================//////////////
        ////////////============================= Reference ===================================//////////////
    }
}
