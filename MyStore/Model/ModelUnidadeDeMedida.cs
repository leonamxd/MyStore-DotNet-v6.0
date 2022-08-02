namespace Model
{
    public class ModelUnidadeDeMedida
    {
        public int Umed_cod { get; set; }
        public String Umed_nome { get; set; }

        public ModelUnidadeDeMedida()
        {
        }

        public ModelUnidadeDeMedida(int _umed_cod, String _umed_nome)
        {
            Umed_cod = _umed_cod;
            Umed_nome = _umed_nome;
        }
    }
}