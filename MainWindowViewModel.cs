using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Reactive;
using ReactiveUI;
using TreeView.ContextMenu.Avalonia.Example.Nodes;

namespace TreeView.ContextMenu.Avalonia.Example
{
    public class MainWindowViewModel
    {
        public ObservableCollection<INode> Items { get; }

        public ObservableCollection<INode> SelectedItems { get; }

        public ReactiveCommand<INode, Unit> TraceCommand { get; }

        public MainWindowViewModel()
        {
            var root = new RootNode();
            Items = root.Children;
            SelectedItems = new ObservableCollection<INode>();
            TraceCommand = ReactiveCommand.Create((INode node) => Trace.WriteLine(node.Header));
        }
    }
}