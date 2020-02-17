﻿using UnityEngine;

public class InventoryUI : MonoBehaviour
{
    public Transform itemsParent;
    private InventoryBehaviour inventory;
    private InventorySlot[] slots;

    public GameObject inventoryUI;
    private void Start()
    {
        inventory = InventoryBehaviour.instance;
        inventory.onItemChangedCallback += UpdateUI;

        slots = itemsParent.GetComponentsInChildren<InventorySlot>();
    }

    
    private void Update()
    {
        if (Input.GetButtonDown("Inventory"))
        {
            inventoryUI.SetActive(!inventoryUI.activeSelf);
        } 
    }

    private void UpdateUI()
    {
        for (int i = 0; i < slots.Length; i++)
        {
            if (i < inventory.items.Count)
            {
                slots[i].AddItem(inventory.items[i]);
            }
            else
            {
                slots[i].ClearSlot();
            }
        }
    }
}