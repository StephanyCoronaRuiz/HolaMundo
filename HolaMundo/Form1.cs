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
                    "Por favor, llena ambos campos de contraseña.",
                    "Campos vacíos",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            if (!isValid) {
            MessageBox.Show(
            "La contraseña no cumple con las características requeridas:\n\n" +
            "- Al menos una letra mayúscula\n" +
            "- Al menos una letra minúscula\n" +
            "- Al menos un número\n" +
            "- Al menos un símbolo (como !, @, #, etc.)",
            "Error de validación",
            MessageBoxButtons.OK,
            MessageBoxIcon.Warning
        );
                return;
            }

            if (!textBox1.Text.Equals(textBox2.Text)){
                MessageBox.Show(
                     "Las contraseñas no son iguales.",
                     "Contraseñas no coinciden",
                     MessageBoxButtons.OK,
                     MessageBoxIcon.Warning
                 );
                return;
            }

            MessageBox.Show(
            "Contraseña correcta.\n\nSe han verificado todos los criterios con éxito.",
            "Validación Exitosa",
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
