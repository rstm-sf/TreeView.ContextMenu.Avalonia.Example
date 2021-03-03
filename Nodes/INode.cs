using System.Collections.ObjectModel;

namespace TreeView.ContextMenu.Avalonia.Example.Nodes
{
    public interface INode
    {
        INode Parent { get; }

        string Header { get; }
        
        ObservableCollection<INode> Children { get; }
    }
}