using System;

public interface ICommand
{
    void Execute();//ejecuta la accion
    void Undo();//deshace la accion
}

public class EditorCarrito
{
    private readonly Stack<ICommand> _undo = new();//guarda comandos ya ejecutados para poder deshacer
    private readonly Stack<ICommand> _redo = new();//guarda comandos deshechos para poder rehacer

    public void Run(ICommand cmd)//ejecuta el comando y lo guarda en undo
    {
        cmd.Execute();//ejecuta
        _undo.Push(cmd);//guarda
        _redo.Clear();//guarda los comandos deshechos
    }

    public void Undo()//undo se encarga de almacenar los dato
    {
        if (_undo.Any())//toma el ultimo comando de nudo lo deshace y lo pasa a redo
        {
            var cmd = _undo.Pop();
            cmd.Undo();
            _redo.Push(cmd);
        }
    }

    public void Redo()//toma lo ultimo de redo lo vuelve a ejecutar y lo manda a nudo
    {
        if (_redo.Any())
        {
            var cmd = _redo.Pop();
            cmd.Execute();
            _undo.Push(cmd);
        }
    }
}

