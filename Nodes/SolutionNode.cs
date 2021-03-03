using System.Collections.ObjectModel;
using System.Linq;

namespace TreeView.ContextMenu.Avalonia.Example.Nodes
{
    public class SolutionNode : INode
    {
        public INode Parent { get; }

        public string Header { get; }

        public ObservableCollection<INode> Children { get; }

        public SolutionNode(INode parent, int idx)
        {
            Parent = parent;
            Header = $"{nameof(SolutionNode)} {idx}";
            Children = new ObservableCollection<INode>(Enumerable.Range(0, 4).Select(i => new ProjectNode(this, i)));
        }
    }
}