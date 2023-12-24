using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TarefaArvore.Model
{
    public class Arvore
    {
        public List<int> PrimeiraLista { get; set; } = new List<int>([3, 2, 1, 6, 0, 5]);
        public List<int> SegundaLista { get; set; } = new List<int>([7,5,13,9,1,6,4]);

        public string Exibirlistas(List<int> lista)
        {
            var sb = new StringBuilder();

            for (int i = 0; i < lista.Count; i++)
            {
                sb.Append(lista[i] + ",");
            }

            return sb.ToString();
        }

        private int ObtemPosicaoRaiz(List<int> lista)
        {
            int posicao = 0;
            int valorElemento = 0;
            for (int i = 0;i < lista.Count;i++)
            {
                if(i == 0)
                {
                    valorElemento = lista[i];
                }
                else if (lista[i] > valorElemento )
                {
                    valorElemento = lista[i];
                    posicao = i;
                }
            }

            return posicao;
        }

        public int ObtemValorRaiz(List<int> lista)
        {
            int valorRaiz = 0;
            for (int i = 0; i < lista.Count; i++)
            {
                if (i == 0)
                {
                    valorRaiz = lista[i];
                }
                else if (lista[i] > valorRaiz)
                {
                    valorRaiz = lista[i];
                }
            }

            return valorRaiz;
        }

        private List<int> MontarGalhosEsquerda(List<int> lista)
        {
            int posicaoRaiz = ObtemPosicaoRaiz(lista);
            List<int> galhosEsquerda = new List<int>();
            if (posicaoRaiz > 1 )
            {
                
                
                
                for (int i = 0; i < posicaoRaiz; i++)
                {
                    galhosEsquerda.Add(lista[i]);
                }
            }

            galhosEsquerda.Sort();
            galhosEsquerda.Reverse();

            return galhosEsquerda;
        }

        private List<int> MontarGalhosDireita(List<int> lista)
        {
            int tamanhoLista = lista.Count;
            int posicaoRaiz = ObtemPosicaoRaiz(lista);
            List<int> galhosDireita = new List<int>();

            if (posicaoRaiz!= tamanhoLista)
            {
                int inicioImpressaoElementos = posicaoRaiz + 1;
                
                for (int i = inicioImpressaoElementos; i < tamanhoLista; i++)
                {
                    galhosDireita.Add(lista[i]);
                }
            }
            galhosDireita.Sort();
            galhosDireita.Reverse();

            return galhosDireita;
        }

        public string ImprimirGalhosEsquerda(List<int> lista) 
        {
            List<int> listaIntToString =  MontarGalhosEsquerda(lista);
            StringBuilder sb = new StringBuilder();

            if (listaIntToString.Count > 0)
            {

                for (int i = 0; i < listaIntToString.Count; i++)
                {
                    sb.Append(listaIntToString[i] + ", ");
                }

                return sb.ToString();
            }
            else
            {
                sb.Append("Não existem dados a serem impressos");
                return sb.ToString();
            }
        }

        public string ImprimirGalhosDireita(List<int> lista) 
        {
            List<int> listaIntToString = MontarGalhosDireita(lista);
            StringBuilder sb = new StringBuilder();
            if (listaIntToString.Count > 0)
            {
                for (int i = 0; i < listaIntToString.Count; i++)
                {
                    sb.Append(listaIntToString[i] + ", ");
                }
                return sb.ToString();
            }
            else
            {
                sb.Append("Não existem dados a serem impressos");
                return sb.ToString();
            }
        }
    }
}
