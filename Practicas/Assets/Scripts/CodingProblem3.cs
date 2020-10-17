using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class CodingProblem3 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int target=9;
        int [] nums ={2,8,7,15};
        int [] output = new int[2];
        suma( target, nums, output);
        Debug.Log("["+output[0]+","+output[1]+"]");
    }
    // Update is called once per frame
  public int[] suma(int target,int[] nums,int[] output)
  {
      for(int i=0;i<nums.Length;i++)
      {
        for(int j=0;j<nums.Length;j++)
         if(nums[i]+nums[j]==target&&i!=j)
            {
              output[0]=i;
              output[1]=j;
              return output;
            }    
      }
      return output;
  }
}
