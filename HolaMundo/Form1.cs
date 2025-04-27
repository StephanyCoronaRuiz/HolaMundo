using System.Text.RegularExpressions;

namespace HolaMundo
{
    public partial class Form1 : Form
    {
        string pattern = @"^(?=.*[A-Z])(?=.*[a-z])(?=.*\d)(?=.*[^a-zA-Z0-9]).+$";
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            bool isValid = Regex.IsMatch(textBox1.Text, pattern);

            if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show(
                    "Por favor, llena ambos campos de contrase�a.",
                    "Campos vac�os",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            if (!isValid) {
            MessageBox.Show(
            "La contrase�a no cumple con las caracter�sticas requeridas:\n\n" +
            "- Al menos una letra may�scula\n" +
            "- Al menos una letra min�scula\n" +
            "- Al menos un n�mero\n" +
            "- Al menos un s�mbolo (como !, @, #, etc.)",
            "Error de validaci�n",
            MessageBoxButtons.OK,
            MessageBoxIcon.Warning
        );
                return;
            }

            if (!textBox1.Text.Equals(textBox2.Text)){
                MessageBox.Show(
                     "Las contrase�as no son iguales.",
                     "Contrase�as no coinciden",
                     MessageBoxButtons.OK,
                     MessageBoxIcon.Warning
                 );
                return;
            }

            MessageBox.Show(
            "Contrase�a correcta.\n\nSe han verificado todos los criterios con �xito.",
            "Validaci�n Exitosa",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information
            );

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
