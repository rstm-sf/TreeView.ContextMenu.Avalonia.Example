using System.Collections.ObjectModel;
using System.Linq;

namespace TreeView.ContextMenu.Avalonia.Example.Nodes
{
    public class RootNode : INode
    {
        public INode Parent => null;

        public string Header => nameof(RootNode);

        public ObservableCollection<INode> Children { get; }

        public RootNode()
        {
            Children = new ObservableCollection<INode>(Enumerable.Range(0, 4).Select(i => new SolutionNode(this, i)));
        }
    }
}