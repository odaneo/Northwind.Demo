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
        List<int> list = [];
        if (root == null) return list;

        Queue<TreeNode> queue = [];
        queue.Enqueue(root);

        while (queue.Count > 0)
        {
            var a = queue.Dequeue();
            list.Add(a.val);

            if (a.left != null) queue.Enqueue(a.left);
            if (a.right != null) queue.Enqueue(a.right);
        }

        return list;
    }
}
