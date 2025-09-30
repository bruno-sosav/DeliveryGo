using System;

public class AgregarItemCommand : ICommand
{
    private readonly Carrito _carrito;
    private readonly Item _item;

    public AgregarItemCommand(Carrito c, Item i)
    {
        _carrito = c;
        _item = i;
    }

    public void Execute() => _carrito.Agregar(_item);//agregar un item al carrito
    public void Undo() => _carrito.Quitar(_item.Sku);//quita ese mismo item
}

public class QuitarItemCommand : ICommand
{
    private readonly Carrito _carrito;
    private readonly string _sku;
    private Item? _backup;

    public QuitarItemCommand(Carrito c, string sku)
    {
        _carrito = c;
        _sku = sku;
    }

    public void Execute() => _backup = _carrito.Quitar(_sku);//quita el item y guarda un backup

    public void Undo()//si habia backup lo vuelve a agregar
    {
        if (_backup != null)
            _carrito.Agregar(_backup);
    }
}

public class SetCantidadCommand : ICommand
{
    private readonly Carrito _carrito;
    private readonly string _sku;
    private readonly int _nueva;
    private int _anterior;

    public SetCantidadCommand(Carrito c, string sku, int nueva)
    {
        _carrito = c;
        _sku = sku;
        _nueva = nueva;
    }

    public void Execute()//guarda la cantidad anterior y la cambia por la nueva
    {
        if (_carrito.Quitar(_sku) is Item item)
        {
            _anterior = item.Cantidad;
            item.Cantidad = _nueva;
            _carrito.Agregar(item);
        }
    }

    public void Undo()//restaura la cantidad anterior
    {
        _carrito.SetCantidad(_sku, _anterior);
    }
}


