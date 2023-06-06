using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    public class TreeOriginal<TItem> where TItem : IComparable<TItem>
    {
        public TItem NodeData { get; set; }
        public TreeOriginal<TItem> LeftTree { get; set; }
        public TreeOriginal<TItem> RightTree { get; set; }

        public TreeOriginal(TItem nodeValue)
        {
            NodeData = nodeValue;
            LeftTree = null;
            RightTree = null;
        }

        public void Insert(TItem newItem)
        {
            TItem currentNodeValue = NodeData;
            if (currentNodeValue.CompareTo(newItem) > 0)
            {
                // Insert the new item into the left subtree
                if (LeftTree == null)
                {
                    LeftTree = new TreeOriginal<TItem>(newItem);
                }
                else
                {
                    LeftTree.Insert(newItem);
                }
            }
            else
            {
                // Insert the new item into the right subtree
                if (RightTree == null)
                {
                    RightTree = new TreeOriginal<TItem>(newItem);
                }
                else
                {
                    RightTree.Insert(newItem);
                }
            }
        }

        public string WalkTree()
        {
            string result = "";

            if (LeftTree != null)
            {
                result = LeftTree.WalkTree();
            }

            result += string.Format(" {0} ", NodeData.ToString());

            if (RightTree != null)
            {
                result += RightTree.WalkTree();
            }

            return result;
        }
    }
}
