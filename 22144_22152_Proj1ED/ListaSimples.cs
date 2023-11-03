using System;
using System.Collections.Generic;

public class ListaSimples<Dado> where Dado : IComparable<Dado>,
    ICriterioDeSeparacao
{
    NoLista<Dado> primeiro, ultimo, atual, anterior;
    int quantosNos;
    bool primeiroAcessoDoPercurso;

    public ListaSimples()
    { 
        primeiro = ultimo = anterior = atual = null; 
        quantosNos = 0; 
        primeiroAcessoDoPercurso = false; 
    }

    public bool EstaVazia
    {
        get => primeiro == null;
    }

    public NoLista<Dado> Primeiro { get => primeiro; }
    public NoLista<Dado> Ultimo { get => ultimo; }
    public NoLista<Dado> Atual { get => atual;  }
    public NoLista<Dado> Anterior { get => anterior; }

    public List<Dado> Lista() 
    {
        var lista = new List<Dado>();
        atual = primeiro; 
        while (atual != null) 
        { 
            lista.Add(atual.Info);
            atual = atual.Prox; 
        }
        return lista;
    }

    public void IniciarPercursoSequencial()
    {
        primeiroAcessoDoPercurso = true;
        atual = primeiro;
        anterior = null;
    }

    public void InserirAntesDoInicio(Dado novoDado)
    {
        var novoNo = new NoLista<Dado>(novoDado);
        if (EstaVazia)          // se a lista está vazia, estamos
            ultimo = novoNo;    // incluindo o 1o e o último nós!
        
        novoNo.Prox = primeiro;
        primeiro = novoNo;
        quantosNos++;
    }

    public void InserirAposFim(Dado novoDado)
    {
        var novoNo = new NoLista<Dado>(novoDado);
        if (EstaVazia)
            primeiro = novoNo;
        else
            ultimo.Prox = novoNo;

        ultimo = novoNo;
        ultimo.Prox = null;
        quantosNos++;
    }

    public bool PodePercorrer() //verifica se é possível percorrer o percurso
    {
        if (!primeiroAcessoDoPercurso)
        {
            anterior = atual;
            atual = atual.Prox;
        }
        else
            primeiroAcessoDoPercurso = false;

        return atual != null;
    }

    public void InserirAposFim(NoLista<Dado> noExistente)
    {
        if (EstaVazia)
            primeiro = noExistente;
        else
            ultimo.Prox = noExistente;

        ultimo = noExistente;
        ultimo.Prox = null;

        quantosNos++;
    }

    ////////////////// Exercícios 1 a 4
    ///
    public int QuantosNos()
    {
        int contador = 0;

        atual = primeiro;
        while (atual != null)
        {
            contador++;

            atual = atual.Prox;
        }
        return contador;
    }

    public int QuantosNos2()
    {
        int contador = 0;
        for (atual = primeiro; atual != null; atual = atual.Prox, contador++);
        return contador;
    }

    // exercício 2

    public void Separar(ref ListaSimples<Dado> l1, ref ListaSimples<Dado> l2)
    {
        l1 = new ListaSimples<Dado>();
        l2 = new ListaSimples<Dado>();
        atual = primeiro;
        while (atual != null)
        {
            var proximoNo = atual.Prox;
            if (atual.Info.PodeSeparar())
                l1.InserirAposFim(atual);
            else
                l2.InserirAposFim(atual);
            atual = proximoNo;
        }
        this.primeiro = this.ultimo = null;
        this.quantosNos = 0;
    }

    public ListaSimples<Dado> Juntar(ListaSimples<Dado> outra)
    {
        var nova = new ListaSimples<Dado>();
        this.atual = this.primeiro;
        outra.atual = outra.primeiro;
        while (this.atual != null && outra.atual != null)
        {
            if (this.atual.Info.CompareTo(outra.atual.Info) < 0)
            {
                var proximoNo = this.atual.Prox;
                nova.InserirAposFim(this.atual);
                this.atual = proximoNo;
            }
            else
                if (outra.atual.Info.CompareTo(this.atual.Info) < 0)
                {
                    var proximoNo = outra.atual.Prox;
                    nova.InserirAposFim(outra.atual);
                    outra.atual = proximoNo;
                }
                else  // empate de chaves
                {
                    var proximoNo = outra.atual.Prox;
                    nova.InserirAposFim(outra.atual);
                    outra.atual = proximoNo;
                    // desliga nó da lista this e avança nessa lista
                    proximoNo = this.atual.Prox;
                    this.atual.Prox = null;
                    this.atual = proximoNo;

                }
        }
        // terminar de ligar os nós da lista que não foi percorrida
        // na sua totalidade

        this.primeiro = this.ultimo = this.atual = this.anterior = null;
        this.quantosNos = 0;
        outra.primeiro = outra.ultimo = outra.atual = outra.anterior = null;
        outra.quantosNos = 0;

        return nova;
    }
}

