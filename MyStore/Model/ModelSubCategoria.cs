namespace Model
{
    public class ModelSubCategoria
    {
        public int Scat_cod { get; set; }
        public String Scat_nome { get; set; }
        public int FK_Cat_cod { get; set; }

        public ModelSubCategoria()
        {
            Scat_cod = 0;
            Scat_nome = "";
            FK_Cat_cod = 0;
        }
        public ModelSubCategoria(int _scat_cod, int _fk_cat_cod, String _scat_nome)
        {
            Scat_cod = _scat_cod;
            Scat_nome = _scat_nome;
            FK_Cat_cod = _fk_cat_cod;
        }
    }
}