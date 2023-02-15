using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace DefaultNamespace
{
    public class WeaponSwap : MonoBehaviour
    {

        [SerializeField] private GameObject[] weapons;

        private void Update()
        {
            int num = 4;
            //switch (num)
            
                if (Input.GetKeyDown(KeyCode.Alpha1))
            {
                SetWeapon(0);
                
            }
            if (Input.GetKeyDown(KeyCode.Alpha2))
            {
                SetWeapon(1);
                
            }

            if (Input.GetKeyDown(KeyCode.Alpha3))
            {
                SetWeapon(2);
            }
            if (Input.GetKeyDown(KeyCode.Alpha4))
            {
                SetWeapon(3);
            }

             void SetWeapon(int weaponNumber)
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
