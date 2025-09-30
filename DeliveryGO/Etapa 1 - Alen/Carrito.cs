using System;

public class Carrito
{
    private Dictionary<string, Item> _items = new();

    public void Agregar(Item i)//si el producto ya existe aumenta la cantidad en caso de que no agrega un nuevo item
    {
        if (_items.ContainsKey(i.Sku))
            _items[i.Sku].Cantidad += i.Cantidad;
        else
            _items[i.Sku] = i;
    }

    public Item? Quitar(string sku)//elimina un item y devuelve una copia del que saco,sku es un identificador unico
    {
        if (_items.TryGetValue(sku, out var item))
        {
            _items.Remove(sku);
            return item;
        }
        return null;
    }

    public bool SetCantidad(string sku, int nueva)//cambia la cantidad de un item
    {
        if (_items.TryGetValue(sku, out var item))
        {
            item.Cantidad = nueva;
            return true;
        }
        return false;
    }

    public decimal Subtotal()//muestra el item su precio y cantidad
    {
        return _items.Values.Sum(i => i.Precio * i.Cantidad);
    }
}

