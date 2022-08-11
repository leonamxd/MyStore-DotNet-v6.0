namespace Model
{
    public class ModelProduto
    {
        public int Pro_cod { get; set; }
        public String Pro_nome { get; set; }
        public String Pro_descricao { get; set; }
        public byte[] Pro_foto { get; set; }
        public Double Pro_valorPago { get; set; }
        public Double Pro_valorVenda { get; set; }
        public int Pro_quantidade { get; set; }
        public int Umed_cod { get; set; }
        public int Cat_cod { get; set; }
        public int Scat_cod { get; set; }

        public ModelProduto()
        {
            Pro_cod = 0;
            Pro_nome = "";
            Pro_descricao = "";
            Pro_valorPago = 0;
            Pro_valorVenda = 0;
            Umed_cod = 0;
            Cat_cod = 0;
            Scat_cod = 0;
        }

        public ModelProduto(int _pro_cod, String _pro_nome, String _pro_descriocao,
             String _pro_foto, Double pro_valorPago, Double _pro_valorVenda,
             int _pro_quantidade, int _umed_cod, int _cat_cod, int _scat_cod)
        {
            Pro_cod = _pro_cod;
            Pro_nome = _pro_nome;
            Pro_descricao = _pro_descriocao;
            CarregaImagem(_pro_foto);
            Pro_valorPago = pro_valorPago;
            Pro_valorVenda = _pro_valorVenda;
            Pro_quantidade = _pro_quantidade;
            Umed_cod = _umed_cod;
            Cat_cod = _cat_cod;
            Scat_cod = _scat_cod;
        }

        public ModelProduto(int _pro_cod, String _pro_nome, String _pro_descriocao,
             Byte[] _pro_foto, Double pro_valorPago, Double _pro_valorVenda,
             int _pro_quantidade, int _umed_cod, int _cat_cod, int _scat_cod)
        {
            Pro_cod = _pro_cod;
            Pro_nome = _pro_nome;
            Pro_descricao = _pro_descriocao;
            Pro_foto = _pro_foto;
            Pro_valorPago = pro_valorPago;
            Pro_valorVenda = _pro_valorVenda;
            Pro_quantidade = _pro_quantidade;
            Umed_cod = _umed_cod;
            Cat_cod = _cat_cod;
            Scat_cod = _scat_cod;
        }

        public void CarregaImagem(String _pro_foto)
        {
            try
            {
                if (!string.IsNullOrEmpty(_pro_foto))
                {
                    FileInfo arqImage = new FileInfo(_pro_foto);
                    FileStream fs = new FileStream(_pro_foto, FileMode.Open, FileAccess.Read, FileShare.Read);
                    Pro_foto = new byte[Convert.ToInt32(arqImage.Length)];
                    int iBytesRead = fs.Read(Pro_foto, 0, Convert.ToInt32(arqImage.Length));
                    fs.Close();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }
    }
}