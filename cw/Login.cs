using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cw
{
    public partial class Login : Form
    {
        Creator form_creator = new Creator();
        public Login()
        {
            InitializeComponent();
            tb_Password.PasswordChar = '*';
        }

        private void bt_Login_Click(object sender, EventArgs e)
        {
            if (tb_UserName.Text == "cuong" && tb_Password.Text == "123")
            {
                if (cb_Role.Text == "Creator Mode")
                {
                    MessageBox.Show("Login with Creator Role");
                    form_creator.ShowDialog();

                }
                if (cb_Role.Text == "Player Mode")
                {
                    MessageBox.Show("Login with Player Role");
                    Player form_player = new Player(form_creator.question_bank);
                    form_player.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("incorect username or password");
            }
        }
    }
}
