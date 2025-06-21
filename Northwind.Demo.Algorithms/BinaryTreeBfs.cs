using Northwind.Demo.Algorithms;

[TestClass]
public class BinaryTreeBfs
{
    [TestMethod]
    public void TestMethod1()
    {
    }
    public List<int> LevelOrder(TreeNode root)
    {
        var list = new List<int>();
        if (root == null) return list; // 防止空树

        Queue<TreeNode> queue = new Queue<TreeNode>();
        queue.Enqueue(root);

        while (queue.Count > 0)
        {
            TreeNode node = queue.Dequeue();
            list.Add(node.val); // 假设 val 是 int 类型，不用 .Value

            if (node.left != null)
                queue.Enqueue(node.left);

            if (node.right != null)
                queue.Enqueue(node.right);
        }

        return list;
    }
}
