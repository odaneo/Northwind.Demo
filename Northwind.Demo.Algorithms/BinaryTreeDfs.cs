namespace Northwind.Demo.Algorithms;

[TestClass]
public class BinaryTreeDfs
{
    private List<int> list = [];
    [TestMethod]
    public void TestMethod()
    {
        var r1 = new TreeNode(1);
        var r2 = new TreeNode(2);
        var r3 = new TreeNode(3);
        var r4 = new TreeNode(4);
        var r5 = new TreeNode(5);
        var r6 = new TreeNode(6);
        var r7 = new TreeNode(7);
        r1.left = r2;
        r1.right = r3;
        r2.right = r4;
        r4.left = r7;
        r3.left = r5;
        r3.right = r6;
    }

    //| 遍历方式 | 访问节点时机                      |
    //| ---- | --------------------------- |
    //| 前序遍历 | **进入节点时**（先访问根）             |
    //| 中序遍历 | **左子树后、访问右子树前**（左-根-右） |
    //| 后序遍历 | **离开节点时**（左右子树访问完后访问根）      |

    public void PreOrder(TreeNode? node)
    {
        if (node == null)
        {
            return;
        }

        list.Add(node.val);
        PreOrder(node.left);
        PreOrder(node.right);
    }
    public void PreOrderIterative(TreeNode? node)
    {
        if (node == null)
        {
            return;
        }
        Stack<TreeNode> stack = [];
        stack.Push(node);

        while (stack.Count > 0)
        {
            TreeNode treeNode = stack.Pop();
            list.Add(treeNode.val);
            if (treeNode.right != null)
            {
                stack.Push(treeNode.right);
            }
            if (treeNode.left != null)
            {
                stack.Push(treeNode.left);
            }
        }
    }
    public void InOrder(TreeNode? node)
    {
        if (node == null)
        {
            return;
        }
        InOrder(node.left);
        list.Add(node.val);
        InOrder(node.right);
    }
    public void InOrderIterative(TreeNode? node) // TODO: 需要多练习
    {
        if (node == null)
        {
            return;
        }
        Stack<TreeNode> stack = [];

        TreeNode current = node;

        while (current != null || stack.Count > 0)
        {
            while (current != null)
            {
                stack.Push(current);
                current = current.left;
            }

            current = stack.Pop();
            list.Add(current.val);
            current = current.right;
        }
    }
    public void PostOrder(TreeNode? node)
    {
        if (node == null)
        {
            return;
        }
        PostOrder(node.left);
        PostOrder(node.right);
        list.Add(node.val);
    }
    public void PostOrderIterative(TreeNode node) // TODO: 需要多练习
    {
        if (node == null) return;

        Stack<TreeNode> stack1 = [];
        Stack<TreeNode> stack2 = [];

        stack1.Push(node);

        while (stack1.Count > 0)
        {
            TreeNode treeNode = stack1.Pop();
            stack2.Push(treeNode);

            if (treeNode.left != null) stack1.Push(treeNode.left);
            if (treeNode.right != null) stack1.Push(treeNode.right);
        }

        while (stack2.Count > 0)
        {
            list.Add(stack2.Pop().val);
        }
    }
}
