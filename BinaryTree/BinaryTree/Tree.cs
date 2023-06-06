using System;
using System.Collections.Generic;
using System.Text;

namespace BinaryTree
{
    public class Tree<TItem> where TItem : IComparable<TItem>
    {
        public TItem NodeData { get; set; }
        public Tree<TItem> LeftTree { get; set; }
        public Tree<TItem> RigthTree { get; set; }

        public Tree(TItem nodeValue)
        {
            this.NodeData = nodeValue;
            this.LeftTree = null; 
            this.RigthTree = null;
        }

        public void Insert(TItem newItem)
        {
            TItem currentNodeValue = this.NodeData;
            if (currentNodeValue.CompareTo(newItem) > 0 ) 
            {
                if(this.LeftTree == null)
                {
                    this.LeftTree = new Tree<TItem>(newItem);
                }
                else
                {
                    this.LeftTree.Insert(newItem);
                }
            } 
            else
            {
                if (this.RigthTree == null)
                {
                    this.RigthTree = new Tree<TItem>(newItem);
                }
                else
                {
                    this.RigthTree.Insert(newItem);
                }
            }
        }
        
        public string WalkTree()
        {
            string result = "";

            if (this.LeftTree != null)
            {
                result = this.LeftTree.WalkTree();
            }

            result += String.Format($"{this.NodeData.ToString()} ");

            if (this.RigthTree != null)
            {
                result += this.RigthTree.WalkTree();
            }

            return result;
        }
    }
}
