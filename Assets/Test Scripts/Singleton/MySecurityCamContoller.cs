using UnityEngine;


/*
 * usage:
 * public class MyAudioController : GenericSingletonClass<MyAudioController>
 * {
 * 
 * }
 */



    public class MySecurityCamContoller : my_unity_integration.GenericSingletonClass<MySecurityCamContoller>
{
        
        public int camCount;
        public TMPro.TMP_Text camCNT;
        void Start()
        {
            camCount = 0;
        }
        public void addCam()
        {
            camCount++;
            camCNT.text = camCount.ToString();
        }


    }

