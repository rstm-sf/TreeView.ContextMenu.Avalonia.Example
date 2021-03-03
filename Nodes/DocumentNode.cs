using System.Collections.ObjectModel;

namespace TreeView.ContextMenu.Avalonia.Example.Nodes
{
    public class DocumentNode : INode
    {
        public INode Parent { get; }

        public string Header { get; }

        public ObservableCollection<INode> Children { get; }

        public DocumentNode(INode parent, int idx)
        {
            Parent = parent;
            Header = $"{nameof(DocumentNode)} {idx}";
            Children = new ObservableCollection<INode>();
        }
    }
}