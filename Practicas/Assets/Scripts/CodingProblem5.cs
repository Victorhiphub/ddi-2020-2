using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CodingProblem5 : MonoBehaviour
{
    void Start()
    {
    int [] num ={12,345,7896,2,6};
    string nums="";
    int pairs=0;
    Debug.Log("Output: "+par(num,pairs,nums));
    }
    
    public int par(int[] num,int pairs,string nums)
    {
        int count=0;
        for(int i=0;i<num.Length;i++)
        {
            nums ="" + num[i];
            for(int j=0; j< nums.Length; j++)
            {
                count+=1;
            }
            if(count%2==0)
            {
                pairs+=1;
            }
        count=0;
        }
    return pairs;

    }
}
