using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Data;

namespace Pj.Teste
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestarObterPessoa_AD()
        {
            //Assert.IsTrue(NumeroRegistrosIgualHum(Pj_AD.Pessoas_AD.ObterPessoas_AD()));
            Assert.AreEqual(NumeroRegistros(Pj_AD.Pessoas_AD.ObterPessoas_AD()), 2);
        }

        [TestMethod]
        public void TestarObterPessoa_NG()
        {
            Assert.AreEqual(NumeroRegistros(PJ_NG.Pessoas_NG.ObterPessoas_NG()), 2);
        }

        [TestMethod]
        public void TestarNomeObterPessoa_NG()
        {
            Assert.AreEqual(NomePessoa(PJ_NG.Pessoas_NG.ObterPessoas_NG(), 1), "Joao");
            Assert.AreEqual(NomePessoa(PJ_NG.Pessoas_NG.ObterPessoas_NG(), 2), "Maria");
            Assert.AreEqual(NomePessoa(PJ_NG.Pessoas_NG.ObterPessoas_NG(), 3), "");
        }

        //private bool NumeroRegistrosIgualHum(DataTable dataTable)
        //{
        //    return (dataTable.Rows.Count == 1);
        //}

        private Int32 NumeroRegistros(DataTable dataTable)
        {
            return dataTable.Rows.Count;
        }

        private String NomePessoa(DataTable dataTable, Int32 ID_Pessoa)
        {
            foreach (DataRow item in dataTable.Rows)
            {
                if (Convert.ToInt32(item["ID_Pessoa"]) == ID_Pessoa)
                {
                    return item["Nome"].ToString();
                }
            }
            return "";
        }
    }
}
