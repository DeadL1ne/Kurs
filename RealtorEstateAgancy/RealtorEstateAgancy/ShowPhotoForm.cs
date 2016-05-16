using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ParserAvito;
using System.Windows.Forms;

namespace RealtorEstateAgancy
{
    public partial class ShowPhotoForm : Form
    {
        private avitoId idAvito;
        public ShowPhotoForm(avitoId sender)
        {
            InitializeComponent();
            idAvito = sender;
        }
        WebParser wp = new WebParser();
        string sourcePage;
        int photoNum = 0;
        int maxPhoto = 0;
        private void ShowPhotoForm_Load(object sender, EventArgs e)
        {
            previousBtn.Enabled = false;
            sourcePage = wp.GetSourcePage(idAvito.Invoke());
            string url = wp.GetPhotoLink(sourcePage, photoNum);
            try
            {
                photoPictureBox.Load("http:" + url);
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Фотографии отстутствуют!");
                Close();
            }
        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            previousBtn.Enabled = true;
            photoNum++;
            string url = wp.GetPhotoLink(sourcePage, photoNum);
            try
            {
                photoPictureBox.Load("http:" + url);
            }
            catch (ArgumentException)
            {
                maxPhoto = photoNum;
                photoNum = 0;
                url = wp.GetPhotoLink(sourcePage, photoNum);
                photoPictureBox.Load("http:" + url);
            }
            if (maxPhoto == 0 && photoNum == 0)
                previousBtn.Enabled = false;
        }

        private void previousBtn_Click(object sender, EventArgs e)
        {
            if (maxPhoto == 0 && photoNum == 1)
                previousBtn.Enabled = false;
            if (photoNum == 0)
                photoNum = maxPhoto;
            photoNum--;
            string url = wp.GetPhotoLink(sourcePage, photoNum);
            photoPictureBox.Load("http:" + url);

        }
    }
}
