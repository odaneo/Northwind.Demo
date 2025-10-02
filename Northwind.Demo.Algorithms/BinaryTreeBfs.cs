namespace Northwind.Demo.Algorithms;

[TestClass]
public class BinaryTreeBfs
{
    [TestMethod]
    public void TestMethod()
    {
    }
    private List<int> Bfs(TreeNode root)
    {
        Queue<TreeNode> queue = [];
        List<int> result = [];

        if (root == null)
        {
            return result;
        }

        queue.Enqueue(root);

        while (queue.Count > 0)
        {
            TreeNode node = queue.Dequeue();
            result.Add(node.val);

            if (node.left != null)
            {
                queue.Enqueue(node.left);
            }
            if (node.right != null)
            {
                queue.Enqueue(node.right);
            }
        }
        return result;
    }
}
