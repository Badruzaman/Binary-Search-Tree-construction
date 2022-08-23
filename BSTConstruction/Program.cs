

BST bst = new BST(15);
bst.insert(9);
bst.insert(16);
bst.insert(10);
bst.insert(8);
bool IsContain = bst.Contains(10);
Console.WriteLine("10 contains {0} ", IsContain);
bst.print(bst);
Console.ReadKey();

class BST
{
    private int value;
    public BST left;
    public BST right;
    public BST(int value)
    {
        this.value = value;
    }
    public void insert(int value)
    {
        if (this.value > value)
        {
            if(left == null)
            {
                left = new BST(value);
            }
            else
            {
                left.insert(value);
            }
        }
        else
        {
            if (right == null)
            {
                right = new BST(value);
            }
            else
            {
                right.insert(value);
            }
        }

    }
    public bool Contains(int value)
    {
        if(value < this.value)
        {
            if(left == null)
            {
                return false;
            }
            else
            {
                return left.Contains(value);
            }
        }
        else if( this.value < value)
        {
            if(right == null)
            {
                return false;
            }
            else
            {
                return right.Contains(value);
            }
        }
        else
        {
            return true;
        }
    }
    public void Remove(int value)
    {

    }
    public void print(BST bst)
    {
        BST node = bst;
        if (node != null)
        {
            Console.Write(" " + node.value);
            node.print(node.left);
            node.print(node.right);
        }
    }
}


