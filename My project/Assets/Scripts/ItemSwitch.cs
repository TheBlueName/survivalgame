using UnityEngine;

public class ItemSwitch : MonoBehaviour
{
    public int selectedweapon = 0;

    void Start()
    {
        SelectWeapon();
    }

    void Update()
    {
        int previousSelectedWeapon = selectedweapon;
        
        if (Input.GetAxis("Mouse ScrollWheel") > 0f)
        {
            if (selectedweapon >= transform.childCount -1)
                selectedweapon = 0;
            else 
                selectedweapon++;
        }

        if (Input.GetAxis("Mouse ScrollWheel") < 0f)
        {
            if (selectedweapon <= 0)
                selectedweapon = transform.childCount - 1;
            else 
                selectedweapon--;
        }
        if (previousSelectedWeapon != selectedweapon)
        {
            SelectWeapon();
        }

    }

    void SelectWeapon ()
    {
        int i = 0;
        foreach (Transform weapon in transform)
        {
            if (i == selectedweapon)
                weapon.gameObject.SetActive(true);
            else
                weapon.gameObject.SetActive(false);
            i++;
        }
    }

    public void WeaponCurrent (int selectedweapon)
    {
    }

}
