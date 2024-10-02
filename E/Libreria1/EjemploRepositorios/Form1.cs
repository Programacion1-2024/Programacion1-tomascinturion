using CEntidades.Entidades;
using CLogica.Contracts;

namespace EjemploRepositorios
{
    public partial class Form1 : Form
    {
        private IAutorLogic _PersonaLogic;

        public Form1(IAutorLogic PersonaLogic)
        {
            _PersonaLogic = PersonaLogic;
            InitializeComponent();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            List<Autor> Personas = await _PersonaLogic.GetAll();
        }
    }
}
