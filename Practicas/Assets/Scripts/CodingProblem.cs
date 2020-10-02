using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CodingProblem : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int [] nums={8,1,2,2,3};
        
        int[] tem = NumeroMenor(nums);
        for(int i=0;i<nums.Length;i++){
            Debug.Log("nums: "+ tem[i]);
        }
    }
    int[] NumeroMenor(int[] nums)
    {
        int[] temp = new int[nums.Length];
        int cont=0;
        for(int i=0;i<nums.Length;i++){
            cont=0;
            for(int j=0;j<nums.Length;j++){
                if(nums[i]>nums[j]){
                    cont++;
                }
            }
            temp[i]=cont;
        }
        return temp;
    }
}
