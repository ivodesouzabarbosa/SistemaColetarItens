using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;
using UnityEngine.Pool;

public class ItensControl : MonoBehaviour
{
    [SerializeField] int _numberFrutas;
    [SerializeField] int _numberLivros;

    [SerializeField] List<Transform> _posFrutas;
    [SerializeField] List<Transform> _posLivros;


    private void Start()
    {
        Invoke("ItensOn", 1);
    }

    void ItensOn()
    {
        Shuffle(_posFrutas);
        for (int i = 0; i < 3; i++)
        {
            FrutasOn(i);
        }
        Shuffle(_posLivros);
        for (int i = 0; i < 3; i++)
        {
            LivrosOn(i);
        }
    }

    void FrutasOn(int value)
    {
        GameObject bullet = FrutaPool.SharedInstance.GetPooledObject();
        if (bullet != null)
        {
            bullet.transform.position = _posFrutas[value].transform.position;
           // bullet.transform.rotation = turret.transform.rotation;
            bullet.SetActive(true);
        }
    }
    void LivrosOn(int value)
    {
        GameObject bullet = LivroPool.SharedInstance.GetPooledObject();
        if (bullet != null)
        {
            bullet.transform.position = _posLivros[value].transform.position;
           // bullet.transform.rotation = turret.transform.rotation;
            bullet.SetActive(true);
        }
    }
    public void Shuffle(List<Transform> lists)
    {
        for (int j = lists.Count - 1; j > 0; j--)
        {
            int rnd = UnityEngine.Random.Range(0, j + 1);
            Transform temp = lists[j];
            lists[j] = lists[rnd];
            lists[rnd] = temp;
        }
    }

}
