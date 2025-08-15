using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq.Expressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YakuzaMTTextureCreator
{
    public partial class MainForm : Form
    {
        private string? redPath;
        private string? bluePath;
        private string? greenPath;
        private string? alphaPath;

        //Why are you glitched
        //Why isn't the picturebox working correctly all the time
        //Why the glitched pixels
        //I must be missing something
        private Image previewDragonEngine = Properties.Resources.nopreview_image_dragonengine;
        private Image previewOldEngine = Properties.Resources.nopreview_image;
        private Image? noPreviewPath;
        
        //I messed up with the green and blue channel, might still be some mistakes left in this code
        private string textRed = "Specular";
        private string textGreen = "Ambient Occlusion";
        private string textBlue = "Specular Power Multiplier";
        private string textAlpha = "";

        private Bitmap? bitmapRed = null;
        private Bitmap? bitmapGreen = null;
        private Bitmap? bitmapBlue = null;
        private Bitmap? bitmapAlpha = null;

        ToolTip engineTooltip = new ToolTip();

        public MainForm()
        {
            InitializeComponent();

            comboBoxEngineType.SelectedIndex = 0;
            engineTooltip.SetToolTip(comboBoxEngineType, "Old Engine: Yakuza 0, Yakuza Kiwami, Yakuza 3, Yakuza 4, etc.\nDragon Engine: Yakuza Kiwami 2, Yakuza 6, Yakuza: Like a Dragon, etc.");
            noPreviewPath = previewOldEngine;

            lblRed.MouseEnter += (s, e) => ShowPreview(redPath);
            lblBlue.MouseEnter += (s, e) => ShowPreview(bluePath);
            lblGreen.MouseEnter += (s, e) => ShowPreview(greenPath);
            lblAlpha.MouseEnter += (s, e) => ShowPreview(alphaPath);

            lblRed.MouseLeave += (s, e) => HidePreview();
            lblBlue.MouseLeave += (s, e) => HidePreview();
            lblGreen.MouseLeave += (s, e) => HidePreview();
            lblAlpha.MouseLeave += (s, e) => HidePreview();
        }

        private void ShowPreview(string path)
        {
            if (path != null)
            {
                SafeDispose(ref previewBox);
                previewBox.Image = new Bitmap(path);
            }
        }

        private void ShowPreview(Image path)
        {
            if (path != null)
            {
                SafeDispose(ref previewBox);
                previewBox.Image = new Bitmap(path);
            }
        }

        private void HidePreview()
        {
            //previewBox.Image = Properties.Resources.nopreview_image;
        }

        private void btnSelectRed_Click(object sender, EventArgs e)
        {
            string path = SelectPNGFile();
            if (path != null)
            {
                redPath = path;
                lblRed.Text = $"{textRed}: {Path.GetFileName(redPath)}";
                SafeDispose(ref bitmapRed);
                bitmapRed = new Bitmap(path);
            }
        }

        private void btnSelectBlue_Click(object sender, EventArgs e)
        {
            string path = SelectPNGFile();
            if (path != null)
            {
                bluePath = path;
                lblBlue.Text = $"{textBlue}: {Path.GetFileName(bluePath)}";
                SafeDispose(ref bitmapBlue);
                bitmapBlue = new Bitmap(path);
            }
        }

        private void btnSelectGreen_Click(object sender, EventArgs e)
        {
            string path = SelectPNGFile();
            if (path != null)
            {
                greenPath = path;
                lblGreen.Text = $"{textGreen}: {Path.GetFileName(greenPath)}";
                SafeDispose(ref bitmapGreen);
                bitmapGreen = new Bitmap(path);
            }
        }

        private void btnPatternMask_Click(object sender, EventArgs e)
        {
            string path = SelectPNGFile();
            if (path != null)
            {
                alphaPath = path;
                lblAlpha.Text = $"{textAlpha}: {Path.GetFileName(alphaPath)}";
                SafeDispose(ref bitmapAlpha);
                bitmapAlpha = new Bitmap(path);
            }
        }

        private string SelectPNGFile()
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "PNG files (*.png)|*.png";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    return ofd.FileName;
                }
            }
            return null;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (bitmapRed == null || bitmapGreen == null || bitmapBlue == null)
            {
                MessageBox.Show("Please select all three required PNGs first.", "Missing Requirements", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            PixelFormat pixelFormatForImage = PixelFormat.Format32bppRgb;
            bool patternMaskHasAlpha;

            if (bitmapAlpha != null)
            {
                patternMaskHasAlpha = HasAlphaChannel(bitmapAlpha);
                pixelFormatForImage = PixelFormat.Format32bppArgb;

                if (bitmapRed.Width != bitmapGreen.Width || bitmapRed.Height != bitmapGreen.Height || bitmapRed.Width != bitmapBlue.Width || bitmapRed.Height != bitmapBlue.Height || bitmapRed.Width != bitmapAlpha.Width || bitmapRed.Height != bitmapAlpha.Height)
                {
                    MessageBox.Show("All input PNGs must have the same dimensions.", "Size Mismatch", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                patternMaskHasAlpha = false;
                pixelFormatForImage = PixelFormat.Format32bppRgb;

                if (bitmapRed.Width != bitmapGreen.Width || bitmapRed.Height != bitmapGreen.Height || bitmapRed.Width != bitmapBlue.Width || bitmapRed.Height != bitmapBlue.Height)
                {
                    MessageBox.Show("All input PNGs must have the same dimensions.", "Size Mismatch", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            //I'm ass at programming
            using (bitmapRed) using (bitmapGreen) using (bitmapBlue) using (bitmapAlpha)
            {
                int width = bitmapRed.Width;
                int height = bitmapRed.Height;

                bool redHasAlpha = HasAlphaChannel(bitmapRed);
                bool blueHasAlpha = HasAlphaChannel(bitmapBlue);
                bool greenHasAlpha = HasAlphaChannel(bitmapGreen);

                Color rColor;
                Color gColor;
                Color bColor;
                Color aColor;

                Bitmap finalImage = new Bitmap(width, height, pixelFormatForImage);

                var bdRed = bitmapRed.LockBits(new Rectangle(0, 0, width, height), ImageLockMode.ReadOnly, PixelFormat.Format32bppArgb);
                var bdBlue = bitmapBlue.LockBits(new Rectangle(0, 0, width, height), ImageLockMode.ReadOnly, PixelFormat.Format32bppArgb);
                var bdGreen = bitmapGreen.LockBits(new Rectangle(0, 0, width, height), ImageLockMode.ReadOnly, PixelFormat.Format32bppArgb);
                var bdFinal = finalImage.LockBits(new Rectangle(0, 0, width, height), ImageLockMode.WriteOnly, PixelFormat.Format32bppArgb);

                BitmapData? bdAlpha = null;
                if (pixelFormatForImage == PixelFormat.Format32bppArgb && bitmapAlpha != null)
                {
                    bdAlpha = bitmapAlpha.LockBits(new Rectangle(0, 0, width, height), ImageLockMode.ReadOnly, PixelFormat.Format32bppArgb);
                }

                //fuck it
                unsafe
                {
                    byte* ptrRed = (byte*)bdRed.Scan0;
                    byte* ptrBlue = (byte*)bdBlue.Scan0;
                    byte* ptrGreen = (byte*)bdGreen.Scan0;
                    byte* ptrFinal = (byte*)bdFinal.Scan0;
                    byte* ptrAlpha = bdAlpha != null ? (byte*)bdAlpha.Scan0 : null;

                    int stride = bdRed.Stride;

                    for (int y = 0; y < height; y++)
                    {
                        byte* rowRed = ptrRed + (y * stride);
                        byte* rowGreen = ptrGreen + (y * stride);
                        byte* rowBlue = ptrBlue + (y * stride);
                        byte* rowFinal = ptrFinal + (y * stride);
                        byte* rowAlpha = ptrAlpha != null ? ptrAlpha + (y * stride) : null;

                        for (int x = 0; x < width; x++)
                        {
                            int idx = x * 4;

                            //Order is BGRA in memory
                            byte redR = rowRed[idx + 2];
                            byte redA = rowRed[idx + 3];

                            byte blueR = rowBlue[idx + 2];
                            byte blueA = rowBlue[idx + 3];

                            byte greenR = rowGreen[idx + 2];
                            byte greenA = rowGreen[idx + 3];

                            byte r = redHasAlpha ? (byte)((redR * redA) / 255) : redR;
                            byte g = greenHasAlpha ? (byte)((greenR * greenA) / 255) : greenR;
                            byte b = blueHasAlpha ? (byte)((blueR * blueA) / 255) : blueR;

                            byte a = 255;
                            if (pixelFormatForImage == PixelFormat.Format32bppArgb && rowAlpha != null)
                            {
                                byte pmR = rowAlpha[idx + 2];
                                byte pmA = rowAlpha[idx + 3];
                                a = patternMaskHasAlpha ? (byte)((pmR * pmA) / 255) : pmR;
                            }

                            //Write BGRA
                            rowFinal[idx + 0] = b;  //Blue
                            rowFinal[idx + 1] = g;  //Green
                            rowFinal[idx + 2] = r;  //Red
                            rowFinal[idx + 3] = a;  //Alpha
                        }
                    }
                }

                bitmapRed.UnlockBits(bdRed);
                bitmapBlue.UnlockBits(bdBlue);
                bitmapGreen.UnlockBits(bdGreen);
                finalImage.UnlockBits(bdFinal);

                if (bdAlpha != null)
                {
                    bitmapAlpha.UnlockBits(bdAlpha);
                }

                using (SaveFileDialog sfd = new SaveFileDialog())
                {
                    sfd.Filter = "PNG Image|*.png";
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        finalImage.Save(sfd.FileName, ImageFormat.Png);
                        MessageBox.Show("Combined PNG created successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

                //Reload the textures
                SafeDispose(ref bitmapRed);
                bitmapRed = new Bitmap(redPath);
                SafeDispose(ref bitmapBlue);
                bitmapBlue = new Bitmap(bluePath);
                SafeDispose(ref bitmapGreen);
                bitmapGreen = new Bitmap(greenPath);

                if (bdAlpha != null)
                {
                    SafeDispose(ref bitmapAlpha);
                    bitmapAlpha = new Bitmap(alphaPath);
                }
            }
        }

        private bool HasAlphaChannel(Bitmap bmp)
        {
            return (bmp.PixelFormat == PixelFormat.Format32bppArgb || bmp.PixelFormat == PixelFormat.Format32bppPArgb || bmp.PixelFormat == PixelFormat.Format64bppArgb || bmp.PixelFormat == PixelFormat.Format64bppPArgb);
        }

        private void comboBoxEngineType_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBoxEngineType.SelectedIndex)
            {
                case 0:
                    flowLayoutPanel5.Enabled = false;
                    flowLayoutPanel5.Visible = false;
                    textRed = "Specular";
                    textGreen = "Ambient Occlusion";
                    textBlue = "Specular Power Multiplier";
                    textAlpha = "";
                    noPreviewPath = previewOldEngine;
                    ShowPreview(noPreviewPath);
                    DeleteAlpha();
                    break;
                case 1:
                    flowLayoutPanel5.Enabled = true;
                    flowLayoutPanel5.Visible = true;
                    textRed = "Metallic/Specular";
                    textGreen = "Ambient Occlusion";
                    textBlue = "Glossiness/Roughness";
                    textAlpha = "Pattern Mask";
                    noPreviewPath = previewDragonEngine;
                    ShowPreview(noPreviewPath);
                    break;
                default:
                    flowLayoutPanel5.Enabled = false;
                    flowLayoutPanel5.Visible = false;
                    textRed = "Specular";
                    textGreen = "Ambient Occlusion";
                    textBlue = "Specular Power Multiplier";
                    textAlpha = "";
                    noPreviewPath = previewOldEngine;
                    ShowPreview(noPreviewPath);
                    DeleteAlpha();
                    break;
            }

            UpdateText();
        }

        //Why did I make the mistake of switch green and blue
        //This is soo shit to fix
        private void UpdateText()
        {
            btnSelectRed.Text = "Select " + textRed + " PNG*";
            btnSelectGreen.Text = "Select " + textGreen + " PNG*";
            btnSelectBlue.Text = "Select " + textBlue + " PNG*";
            btnAlpha.Text = "Select " + textAlpha + " PNG";

            if (lblRed.Text != "No Image Selected")
            {
                lblRed.Text = $"{textRed}: {Path.GetFileName(redPath)}";
            }

            if (lblBlue.Text != "No Image Selected")
            {
                lblBlue.Text = $"{textBlue}: {Path.GetFileName(bluePath)}";
            }

            if (lblGreen.Text != "No Image Selected")
            {
                lblGreen.Text = $"{textGreen}: {Path.GetFileName(greenPath)}";
            }

            if (lblAlpha.Text != "No Image Selected")
            {
                lblAlpha.Text = $"{textAlpha}: {Path.GetFileName(alphaPath)}";
            }
        }

        private void btnDeleteAlpha_Click(object sender, EventArgs e)
        {
            DeleteAlpha();
        }

        private void DeleteAlpha()
        {
            alphaPath = null;
            lblAlpha.Text = "No Image Selected";
            bitmapAlpha = null;
            ShowPreview(noPreviewPath);
        }

        private void btnDeleteRed_Click(object sender, EventArgs e)
        {
            redPath = null;
            lblRed.Text = "No Image Selected";
            bitmapRed = null;
            ShowPreview(noPreviewPath);
        }

        private void btnDeleteGreen_Click(object sender, EventArgs e)
        {
            greenPath = null;
            lblGreen.Text = "No Image Selected";
            bitmapGreen = null;
            ShowPreview(noPreviewPath);
        }

        private void btnDeleteBlue_Click(object sender, EventArgs e)
        {
            bluePath = null;
            lblBlue.Text = "No Image Selected";
            bitmapBlue = null;

        }
        void SafeDispose(ref Bitmap? bmp)
        {
            if (bmp != null)
            {
                bmp.Dispose();
                bmp = null;
            }
        }

        void SafeDispose(ref CheckerboardPictureBox pictureBox)
        {
            if (pictureBox != null)
            {
                if (pictureBox.Image != null)
                {
                    pictureBox.Image.Dispose();
                    pictureBox.Image = null;
                }
            }
        }
    }
}