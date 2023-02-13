using System;
using UnityEngine;

namespace DefaultNamespace
{
    public class WeaponSwap : MonoBehaviour
    {
        [SerializeField] private GameObject weapon1;
        [SerializeField] private GameObject weapon2;
        [SerializeField] private GameObject weapon3;
        
        [SerializeField] private GameObject[] weapons;

        private void Update()
        {
            int num = 4;
            switch (num)
            {
                case 1:
                    transform.position = transform.position;
                    break;
            }
            if (Input.GetKeyDown(KeyCode.Alpha1))
            {
                SetWeapon(0);
                weapons[0].SetActive(true);
                weapons[1].SetActive(false);
                weapons[2].SetActive(false);

                
                
            }
            if (Input.GetKeyDown(KeyCode.Alpha2))
            {
                weapons[0].SetActive(false);
                weapons[1].SetActive(true);
                weapons[2].SetActive(false);

                
                
            }if (Input.GetKeyDown(KeyCode.Alpha3))
            {
                weapons[0].SetActive(false);
                weapons[1].SetActive(false);
                weapons[2].SetActive(true);

                private void SetWeapon(int weaponNumber)
                {
                    for (int i = 0; i < weapons.Length; i++)
                    {
                        //bool correctWeapon = (i == weaponNumber);
                        var currentWeapon = weapons[i];
                        if(i == weaponNumber)
                        {
                            currentWeapon.SetActive(true);
                        }
                        else
                        {
                            currentWeapon.SetActive(false);
                        }
                    }
                }
                
            }
        }
    }
}