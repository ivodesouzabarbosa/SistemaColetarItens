using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;
using UnityEngine.Pool;

public class PlayerPontos : MonoBehaviour
{
   [SerializeField] int _pontos;
   public void SomarPontos(int value)
   {
       // _pontos = _pontos + value;
        _pontos += value;
   }

    
}
