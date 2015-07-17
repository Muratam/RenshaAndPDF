using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;

namespace WindowsFormsApplication1 {
    public partial class Form1 : Form {
        public Form1() {InitializeComponent();}
        [System.Runtime.InteropServices.DllImport("gdi32.dll")]
        private static extern bool BitBlt(IntPtr hdcDest, int nXDest, int nYDest, int nWidth, int nHeight, IntPtr hdcSrc, int nXSrc, int nYSrc, int dwRop);
        private const int SRCCOPY = 0xCC0020;
        [DllImport("user32")]
        static extern IntPtr GetDC(IntPtr hWnd);
        [DllImport("user32")]
        static extern int ReleaseDC(IntPtr hWnd, IntPtr hDC);
        [DllImport("user32")]
        public static extern bool InvalidateRect(IntPtr hwnd, IntPtr lpRect, bool bErase);


        private int X1 = 0, W = 100, Y1 = 0, H = 100;
        private const int DrawSleepTime = 60;
        private int X2 { get { return X1 + W; } }
        private int Y2 { get { return Y1 + H; } }
        bool Dayed = false;
        string NowDay = "files";
        string DayName { get {
            if (Dayed) return NowDay;
            else {
                Dayed = true; NowDay =
                    DateTime.Now.Month + "" + DateTime.Now.Day + "_" + 
                    DateTime.Now.Hour + "" + DateTime.Now.Minute;
                return DayName;
            }
        } }
        string DirectoryName { get {return Application.StartupPath + "/" + DayName; } }


        int n = 0;
        private void Start_Click(object sender, EventArgs e) {
            EraceRect();
            if (!Directory.Exists(DirectoryName)) Directory.CreateDirectory(DirectoryName);
            
            Rectangle rc = Screen.PrimaryScreen.Bounds;
            Bitmap bmp = new Bitmap(W, H,PixelFormat.Format32bppArgb);
            Graphics g = Graphics.FromImage(bmp);
            g.CopyFromScreen(X1,Y1, 0, 0, new Size(W,H), CopyPixelOperation.SourceCopy);
            bmp.Save(DirectoryName + "/"+(++n)+".png",ImageFormat.Png);
            bmp.Dispose();
            DrawRect();
            this.Text = "" + n + "pngFiles";
        }

        private void MakePDF_Click(object sender, EventArgs e) {
            System.Diagnostics.Process.Start("http://smallpdf.com/jp/jpg-to-pdf");
            System.Threading.Thread.Sleep(3000);
            System.Diagnostics.Process.Start(DirectoryName);
        }

        protected override void OnClosing(CancelEventArgs e) {
            EraceRect();
            base.OnClosing(e);
        }


        private void EraceRect() {
            InvalidateRect(IntPtr.Zero, IntPtr.Zero, true);
            System.Threading.Thread.Sleep(DrawSleepTime);
        }

        private void DrawRect() {
            EraceRect();
            IntPtr hDC = GetDC((IntPtr)0);
            using (Graphics g = Graphics.FromHdc(hDC)) {
                using (Pen pen = new Pen(Color.LimeGreen, 5)) {
                    g.DrawLines(pen, new Point[] { 
                    new Point(X1, Y1), new Point(X1, Y2), new Point(X2, Y2), new Point(X2, Y1) ,new Point(X1, Y1)
                });}
                g.Dispose();
            }
            ReleaseDC((IntPtr)0, hDC);
        
        }

        private void TextBoxChanged(object sender, EventArgs e) {

            try { X1 = int.Parse(this.X1Tx.Text); } catch { X1 = 0; }
            try { W = int.Parse(this.X2Tx.Text); } catch { W = 100; }
            try { Y1 = int.Parse(this.Y1Tx.Text); } catch { Y1 = 0; }
            try { H = int.Parse(this.Y2Tx.Text); } catch { H = 100; }

            DrawRect();
        }

        private void Form1_Load(object sender, EventArgs e) {
            DrawRect();
        }
    }
}
