namespace Model
{
    public class ModelCategoria
    {
        public int Cat_cod { get; set; }
        public String Cat_nome { get; set; }

        public ModelCategoria()
        {
        }

        public ModelCategoria(int _cat_cod, String _cat_nome)
        {
            Cat_cod = _cat_cod;
            Cat_nome = _cat_nome;
        }
    }
}