using System;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Windows.Forms;
using System.Diagnostics;


namespace prores
{
    public partial class Form1 : Form
    {
        private static string PR_PROXY = "0";
        private static string PR_LT = "1";
        private static string PR_SQ = "2";
        private static string PR_HQ = "3";

        private string profile = PR_HQ;
        private int qscale = 5;

        public Form1()
        {
            InitializeComponent();

            if (!File.Exists(Application.StartupPath + "\\ffmpeg"))
            {
                //MessageBox.Show("ffmpeg not exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //Environment.Exit(0);
                File.WriteAllBytes(Application.StartupPath + "\\ffmpeg", Properties.Resources.ffmpeg);
            }

            chk();
            chk2();

            menuStrip1.Renderer = new ToolStripProfessionalRenderer(new TestColorTable());
        }

        public class TestColorTable : ProfessionalColorTable
        {
            public override Color MenuItemSelected
            {
                get { return Color.FromArgb(51, 204, 255); }
            }
        }

        private void AddToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.FileName = "";
            ofd.InitialDirectory = "";
            ofd.Filter =
                "Video File(*.*)|*.*";
            ofd.FilterIndex = 2;
            ofd.Title = "Open";
            ofd.RestoreDirectory = true;

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                checkedListBox1.Items.Add(ofd.FileName, true);
            }
        }

        private bool ffmpeg_r = false;
        private void Encode(object sender, EventArgs e)
        {
            foreach (var item in checkedListBox1.CheckedItems.OfType<string>().ToList())
            {
                Process p = new Process();
                p.SynchronizingObject = this;
                p.StartInfo.FileName = System.Windows.Forms.Application.StartupPath + "\\ffmpeg";
                p.StartInfo.CreateNoWindow = true;
                p.StartInfo.UseShellExecute = false;
                p.StartInfo.RedirectStandardError = true;
                p.ErrorDataReceived += p_OutputDataReceived;
                p.StartInfo.Arguments = "-y -threads " + (Environment.ProcessorCount - 1) + " -i \"" + item + "\" -c:v prores_ks -profile:v " + profile + " -qscale:v " + qscale + " -vendor ap10 -pix_fmt yuv422p10le -acodec pcm_s16le -ar 48000 \"" + System.IO.Path.ChangeExtension(item, "prores.mov") + "\"";
                p.Exited += new EventHandler(p_Exited);
                p.EnableRaisingEvents = true;
                p.Start();
                p.BeginErrorReadLine();
                ffmpeg_r = true;
                while (ffmpeg_r)
                {
                    Application.DoEvents();
                    System.Threading.Thread.Sleep(32);
                }
                System.Threading.Thread.Sleep(32);
                d = false;
                checkedListBox1.Items.Remove(item);
                progressBar1.Value = 0;
                this.Text = "";
            }
        }

        private bool d = false;
        private double ffmpeg_dur = 0;

        void p_OutputDataReceived(object sender, DataReceivedEventArgs e)
        {
            if (e.Data != null)
            {
                string str = e.Data;

                if (!d)
                {
                    if (str.Contains("Duration: N/A"))
                    {
                        MessageBox.Show("File does not contain any stream", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        ffmpeg_r = false;
                        return;
                    }
                    else if (str.Contains("Invalid data found when processing input"))
                    {
                        MessageBox.Show("Invalid data found when processing input", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        ffmpeg_r = false;
                        return;
                    }

                    if (str.Contains("Duration:"))
                    {
                        d = true;
                        string s1 = str.Substring(str.IndexOf("Duration: ") + 10, 8);
                        string[] dur = s1.Split(':');
                        ffmpeg_dur = (double.Parse(dur[0]) * 3600) + (double.Parse(dur[1]) * 60) + double.Parse(dur[2]);
                    }
                }


                if (d && str.Contains("time="))
                {
                    string[] dur = str.Substring(str.IndexOf("time=") + 5, 8).Split(':');
                    double ffmpeg_time = (double.Parse(dur[0]) * 3600) + (double.Parse(dur[1]) * 60) + double.Parse(dur[2]);
                    int prog = (int)((ffmpeg_time / ffmpeg_dur) * 100);
                    if (prog > 100 || prog < 0)
                    {
                        prog = 100;
                    }
                    this.Text = str;
                    progressBar1.Value = prog;
                }
            }
        }

        private void p_Exited(object sender, EventArgs e)
        {
            ffmpeg_r = false;
            return;
        }

        private void QuitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void proRes422HQToolStripMenuItem_Click(object sender, EventArgs e)
        {
            profile = PR_HQ;
            chk();
        }

        private void proRes422ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            profile = PR_SQ;
            chk();
        }

        private void proRes422LTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            profile = PR_LT;
            chk();
        }

        private void proRes422ProxyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            profile = PR_PROXY;
            chk();
        }

        private void chk()
        {
            switch (profile)
            {
                case "0":
                    proRes422HQToolStripMenuItem.Checked = false;
                    proRes422ToolStripMenuItem.Checked = false;
                    proRes422LTToolStripMenuItem.Checked = false;
                    proRes422ProxyToolStripMenuItem.Checked = true;
                    break;
                case "1":
                    proRes422HQToolStripMenuItem.Checked = false;
                    proRes422ToolStripMenuItem.Checked = false;
                    proRes422LTToolStripMenuItem.Checked = true;
                    proRes422ProxyToolStripMenuItem.Checked = false;
                    break;
                case "2":
                    proRes422HQToolStripMenuItem.Checked = false;
                    proRes422ToolStripMenuItem.Checked = true;
                    proRes422LTToolStripMenuItem.Checked = false;
                    proRes422ProxyToolStripMenuItem.Checked = false;
                    break;
                case "3":
                    proRes422HQToolStripMenuItem.Checked = true;
                    proRes422ToolStripMenuItem.Checked = false;
                    proRes422LTToolStripMenuItem.Checked = false;
                    proRes422ProxyToolStripMenuItem.Checked = false;
                    break;
                default:
                    proRes422HQToolStripMenuItem.Checked = true;
                    proRes422ToolStripMenuItem.Checked = false;
                    proRes422LTToolStripMenuItem.Checked = false;
                    proRes422ProxyToolStripMenuItem.Checked = false;
                    break;
            }
        }

        private void chk2()
        {
            switch (qscale)
            {
                case 1:
                    toolStripMenuItem2.Checked = true;
                    q5ToolStripMenuItem.Checked = false;
                    q9ToolStripMenuItem.Checked = false;
                    q11ToolStripMenu.Checked = false;
                    q13ToolStripMenu.Checked = false;
                    q20ToolStripMenu.Checked = false;
                    break;
                case 5:
                    toolStripMenuItem2.Checked = false;
                    q5ToolStripMenuItem.Checked = true;
                    q9ToolStripMenuItem.Checked = false;
                    q11ToolStripMenu.Checked = false;
                    q13ToolStripMenu.Checked = false;
                    q20ToolStripMenu.Checked = false;
                    break;
                case 9:
                    toolStripMenuItem2.Checked = false;
                    q5ToolStripMenuItem.Checked = false;
                    q9ToolStripMenuItem.Checked = true;
                    q11ToolStripMenu.Checked = false;
                    q13ToolStripMenu.Checked = false;
                    q20ToolStripMenu.Checked = false;
                    break;
                case 11:
                    toolStripMenuItem2.Checked = false;
                    q5ToolStripMenuItem.Checked = false;
                    q9ToolStripMenuItem.Checked = false;
                    q11ToolStripMenu.Checked = true;
                    q13ToolStripMenu.Checked = false;
                    q20ToolStripMenu.Checked = false;
                    break;
                case 13:
                    toolStripMenuItem2.Checked = false;
                    q5ToolStripMenuItem.Checked = false;
                    q9ToolStripMenuItem.Checked = false;
                    q11ToolStripMenu.Checked = false;
                    q13ToolStripMenu.Checked = true;
                    q20ToolStripMenu.Checked = false;
                    break;
                case 20:
                    toolStripMenuItem2.Checked = false;
                    q5ToolStripMenuItem.Checked = false;
                    q9ToolStripMenuItem.Checked = false;
                    q11ToolStripMenu.Checked = false;
                    q13ToolStripMenu.Checked = false;
                    q20ToolStripMenu.Checked = true;
                    break;
                default:
                    toolStripMenuItem2.Checked = false;
                    q5ToolStripMenuItem.Checked = true;
                    q9ToolStripMenuItem.Checked = false;
                    q11ToolStripMenu.Checked = false;
                    q13ToolStripMenu.Checked = false;
                    q20ToolStripMenu.Checked = false;
                    break;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (var item in checkedListBox1.CheckedItems.OfType<string>().ToList())
            {
                checkedListBox1.Items.Remove(item);
            }
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            qscale = 1;
            chk2();
        }

        private void q5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            qscale = 5;
            chk2();
        }

        private void q9ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            qscale = 9;
            chk2();
        }

        private void q11ToolStripMenu_Click(object sender, EventArgs e)
        {
            qscale = 11;
            chk2();
        }

        private void q13ToolStripMenu_Click(object sender, EventArgs e)
        {
            qscale = 13;
            chk2();
        }

        private void q20ToolStripMenu_Click(object sender, EventArgs e)
        {
            qscale = 20;
            chk2();
        }

        new private void DragDrop(object sender,System.Windows.Forms.DragEventArgs e)
        {
            string[] fileName = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            checkedListBox1.Items.Add(fileName[0], true);
        }

        new private void DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Encode(null, null);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AddToolStripMenuItem_Click(null, null);
        }
    }
}
