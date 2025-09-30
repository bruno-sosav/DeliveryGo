using System;

public interface ICarritoPort
{
    void Run(ICommand cmd);
    void Undo();
    void Redo();
    decimal Subtotal();
}

public class CarritoPort : ICarritoPort
{
    private readonly Carrito _carrito = new();//modelo con items
    private readonly EditorCarrito _editor = new();//maneja los comandos undo y redo

    public void Run(ICommand cmd) => _editor.Run(cmd);
    public void Undo() => _editor.Undo();
    public void Redo() => _editor.Redo();
    public decimal Subtotal() => _carrito.Subtotal();

    // Para exponer el carrito
    public Carrito Carrito => _carrito;
}
