using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class CharacterStatus : MonoBehaviour
{
    [SerializeField] float LifeMax;
    [SerializeField] float Speed;
    float Life;

    public float LifeMax1 { get => LifeMax; }
    public float Speed1 { get => Speed; }


    // Start is called before the first frame update
    void Awake()
    {
        Life = LifeMax;

    }

    // Update is called once per frame
    void Update()
    {

    }
    protected abstract void Teste();//obriga o filho a implementar
    protected virtual void Teste2()//Permite que o filho sobrescreva
    {

    }
    
    
}
