using GameBackend.Entities.DALs;
using GameBackend.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameBackend
{
    public partial class Giris : Form
    {
        public Giris()
        {
            InitializeComponent();
        }
        PlayerDAL _playerDal = new PlayerDAL();
        private void TbxGirisPwd_TextChanged(object sender, EventArgs e)
        {
            tbxGirisPwd.ForeColor = Color.Black;
            tbxGirisPwd.PasswordChar = '●';
        }

        private void BtnGiris_Click(object sender, EventArgs e)
        {
            var girisHakki = 0;
            while (girisHakki < 3)
            {
                try
                {
                    _playerDal.CheckLogin(tbxGirisNatID.Text, tbxGirisPwd.Text);
                    break;
                }
                catch (Exception)
                {
                    MessageBox.Show("Giriş bilgileriniz hatalı!");
                    girisHakki += 1;
                }
            }
            
            

        }

        private void LLblKayit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }
    }
}
