using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    [SerializeField] private string _nome;
    [SerializeField] private int _tipo;
    [SerializeField] private int _valor;

    [SerializeField] MeshRenderer _textura;
    [SerializeField] GameObject _partSaida;
    protected virtual void Start()
    {
        _textura = GetComponent<MeshRenderer>();
    }

    public virtual void DestroyItem()
    {

    }

    protected virtual void ConstroiItem()
    {

    }

    //pesquisar get set C#
    public virtual string Nome
    { 
     get { return _nome; } //get
     set { _nome = value; } // set
      
    }
    public virtual int Tipo
    {
        get { return _tipo; } //get
        set { _tipo = value; } // set

    }
    public virtual int Valor
    {
        get { return _valor; } //get
        set { _valor = value; } // set

    }
    public virtual MeshRenderer Textura
    {
        get { return _textura; } //get
        set { _textura = value; } // set
    }

    public virtual GameObject PartSaida
    {
        get { return _partSaida; } //get
        set { _partSaida = value; } // set
    }


}
