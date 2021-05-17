using GameBackend.Entities;
using GameBackend.Entities.DALs;
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
    public partial class Kayıt : Form
    {
        public Kayıt()
        {
            InitializeComponent();
        }

        PlayerDAL _playerDal = new PlayerDAL();

        private void BtnSubscribe_Click(object sender, EventArgs e)
        {
            _playerDal.Add( new Player
            {
                NationalID = txtBoxNatID.Text,
                FirstName = txtBoxName.Text,
                LastName = txtBoxSurname.Text,
                YearOfBirth = Convert.ToInt32(txtBoxYoB.Text),
                Password = txtBoxPwd.Text
            });
            MessageBox.Show("Player added!");
            var giris = new Giris();
            giris.Activate();
            giris.Show();
            
        }

        private void TxtBoxPwd_TextChanged(object sender, EventArgs e)
        {
            txtBoxPwd.ForeColor = Color.Black;
            txtBoxPwd.PasswordChar = '●';
        }

        private void Kayıt_Load(object sender, EventArgs e)
        {

        }

        private void LLblGiris_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var giris = new Giris();
            giris.Activate();
            giris.Show();
        }
    }
}
