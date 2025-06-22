namespace Northwind.Demo.Algorithms;

[TestClass]
public class ArrayBinaryTree
{
    public List<int> tree = [1, 2, 3, 4, 5, 6, 7, 8];
    public List<int> res = [];

    [TestMethod]
    public void TestMethod1()
    {
    }
    public int Size() { return tree.Count; }
    public int? Val(int i)
    {
        if (i < 0 || i >= Size())
        {
            return null;
        }
        return tree[i];
    }
    public int Left(int i)
    {
        return 2 * i + 1;
    }
    public int Right(int i)
    {
        return 2 * i + 2;
    }
    public int Parent(int i)
    {
        return (i - 1) / 2;
    }
    public void LevelOrder()
    {
        for (var i = 0; i < Size(); i++)
        {
            if (Val(i).HasValue)
            {
                res.Add(Val(i)!.Value);
            }
        }
    }

    /* 前序遍历 */
    public void PreOrder(int i)
    {
        if (!Val(i).HasValue)
        {
            return;
        }
        res.Add(Val(i)!.Value);
        PreOrder(Left(i));
        PreOrder(Right(i));
    }

    /* 中序遍历 */
    public void InOrder(int i)
    {
        if (!Val(i).HasValue)
        {
            return;
        }
        InOrder(Left(i));
        res.Add(Val(i)!.Value);
        InOrder(Right(i));
    }
    /* 后序遍历 */
    public void PostOrder(int i)
    {
        if (!Val(i).HasValue)
        {
            return;
        }
        PostOrder(Left(i));
        PostOrder(Right(i));
        res.Add(Val(i)!.Value);
    }
}
