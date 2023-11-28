namespace KuntoLps.Controllers
{
    public class Task6
    {
        static void Main(string[] args)
        {
            var rootNode = new TreeNode();
            while (true)
            {
                // create a new subtree of 10000 nodes 
                var newNode = new TreeNode();
                for (int i = 0; i < 10000; i++)
                {
                    var childNode = new TreeNode();
                    newNode.AddChild(childNode);
                }
                rootNode.AddChild(newNode);

                /// <summary>
                /// remove the old subtrees to free up memory
                /// </summary>
                if (rootNode.Children.Count > 10)
                {
                    rootNode.RemoveChildAt(0);
                }
            }
        }
    }
    class TreeNode
    {
        private readonly List<TreeNode> _children = new List<TreeNode>();
        public IReadOnlyList<TreeNode> Children => _children;
        public void AddChild(TreeNode child)
        {
            _children.Add(child);
        }
        public void RemoveChildAt(int index)
        {
            _children.RemoveAt(index);
        }
    }
}
