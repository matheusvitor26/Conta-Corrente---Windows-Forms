using Data;
using System.Collections.Generic;
using System.Data;
using WebCrawler;

namespace Business
{
    public class Consultas
    {
        private DataAccess data = new DataAccess();

        public bool TesteConexao()
        {
            return true;
        }

        public void InsereConta(string nome, string saldo)
        {
            data.ExecuteNonQuery($"INSERT INTO CONTAS VALUES ('{nome}', {saldo})");
        }

        public DataSet ListarContas()
        {
            return data.ExecuteQuery("SELECT * FROM CONTAS WITH(NOLOCK) ORDER BY COD_CONTA");
        }

        public List<string> ConsultarConta(string numConta)
        {
            DataSet ds = data.ExecuteQuery($"SELECT * FROM CONTAS WITH(NOLOCK) WHERE COD_CONTA = {numConta}");
        
            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                float saldoDolar, saldoReais;
                List<string> dados = new List<string>();
                Cotacao cotacao = new Cotacao();

                saldoReais = float.Parse(ds.Tables[0].Rows[0]["SALDO"].ToString());
                saldoDolar = cotacao.GetCotacao();
                
                dados.Add(ds.Tables[0].Rows[0]["NOME"].ToString());
                dados.Add(ds.Tables[0].Rows[0]["SALDO"].ToString());
                dados.Add((saldoDolar * saldoReais).ToString());
                
                return dados;
            }

            return new List<string>();
        }

        public bool ExecutaTransacao(string numConta, string valor)
        {
            return data.ExecuteNonQuery($"UPDATE CONTAS WITH(ROWLOCK, READPAST, UPDLOCK) SET SALDO = SALDO + ({valor}) WHERE COD_CONTA = {numConta}");
        }
    }
}