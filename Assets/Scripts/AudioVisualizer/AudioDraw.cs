using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioDraw : MonoBehaviour
{
    // Start is called before the first frame update
    private Transform[] columns=new Transform[512];
    public GameObject cubePrefab;
public int band;
public float scaleSize,startScale;

Vector3 sizeDefault=Vector3.one;
     private void OnEnable() 
     {
         Vector3 columnPosition=Vector3.right;
         for(int i=0;i<columns.Length;i++)
         {
             columns[i]=Instantiate(cubePrefab,
                                    columnPosition * i,
                                    Quaternion.identity).transform;
         }    
        
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         for(int i=0;i<columns.Length;i++)
         {
             sizeDefault.y=(AudioSampler.samples[i]*scaleSize)+startScale;

             columns[i].localScale=sizeDefault;

         }   
    }
}
