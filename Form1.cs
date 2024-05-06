using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net.Http;
using System.Windows.Forms;

namespace Background_Remover
{
    public partial class Form1 : Form
    {
        private string fileName;

        public Form1()
        {
            InitializeComponent();
        }

        private void ImageLoaderButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog
            {
                Filter = "Images (*.jpg, *.png, *.jpeg)|*.jpg; *.png; *.jpeg"
            };

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                fileName = fileDialog.FileName;
                PreviewPictureBox.Image = ScaleImageToFit(Image.FromFile(fileName), PreviewPictureBox);
                RemoveBackgButton.Enabled = true;
            }
            else
            {
                MessageBox.Show("Image loading is canceled!", "Canceled!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void RemoveBackgButton_Click(object sender, EventArgs e)
        {
            using (var client = new HttpClient())
            using (var formData = new MultipartFormDataContent())
            {
                formData.Headers.Add("X-Api-Key", "7JvYMMWzRBgHB1Sj7t4ndLob");
                formData.Add(new ByteArrayContent(File.ReadAllBytes(fileName)), "image_file", "file.jpg");
                formData.Add(new StringContent("auto"), "size");
                var response = client.PostAsync("https://api.remove.bg/v1.0/removebg", formData).Result;

                if (response.IsSuccessStatusCode)
                {
                    string pathToDocuments = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                    FileStream fileStream = new FileStream(pathToDocuments + "\\no-bg.png", FileMode.Create, FileAccess.Write, FileShare.None);
                    response.Content.CopyToAsync(fileStream).ContinueWith((copyTask) => { fileStream.Close(); });
                    RemoveBackgButton.Enabled = false;
                    PreviewPictureBox.Image = null;
                    Process.Start("explorer.exe", pathToDocuments);
                    MessageBox.Show("Background successfully removed!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("response.Content.ReadAsStringAsync().Result!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private Image ScaleImageToFit(Image image, PictureBox pictureBox)
        {
            float ratio = Math.Min((float)pictureBox.Width / image.Width, (float)pictureBox.Height / image.Height);
            int newWidth = (int)(image.Width * ratio);
            int newHeight = (int)(image.Height * ratio);
            return new Bitmap(image, new Size(newWidth, newHeight));
        }
    }
}
