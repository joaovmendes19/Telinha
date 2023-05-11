using System;
using System.Windows.Forms;

namespace Views {

    public class Menu {

        public static void Menus() {

            Form menu = new Form();
            menu.Text = "Menu";
            menu.Size = new System.Drawing.Size(250, 270);
            menu.StartPosition = FormStartPosition.CenterScreen;
            menu.FormBorderStyle = FormBorderStyle.FixedSingle;
            menu.MaximizeBox = false;
            menu.MinimizeBox = false;Label lblId= new Label();
            lblId.Text = "Id:";
            lblId.Top = 25;
            lblId.Left = 10;
            lblId.Size = new System.Drawing.Size(100, 25);


            Label lblNome = new Label();
            lblNome.Text = "Nome:";
            lblNome.Top = 60;
            lblNome.Left = 10;
            lblNome.Size = new System.Drawing.Size(100, 25);

            TextBox txtNome = new TextBox();
            txtNome.Top = 60;
            txtNome.Left = 110;
            txtNome.Size = new System.Drawing.Size(100, 25);

            Button Ola = new Button();
            Ola.Text = "Ola";
            Ola.AutoSize = true;
            Ola.Location = new System.Drawing.Point(80, 100);
            Ola.Click += (sender, e) => {
                MessageBox.Show("Olá, " + txtNome.Text + "!");
            };

            

            
            Button sair = new Button();
            sair.Text = "SAIR";
            sair.AutoSize = true;
            sair.Location = new System.Drawing.Point( 80 , 140);
            sair.Click += (sender, e) => {
                menu.Close();
            };

            menu.Controls.Add(Ola);
            menu.Controls.Add(lblNome);
            menu.Controls.Add(txtNome);
            menu.Controls.Add(sair);

            menu.ShowDialog();
    }
       

}
}