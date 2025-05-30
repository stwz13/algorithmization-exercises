using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace ConsoleApp6
{
    unsafe class BinaryTreeProgram
    {
        struct TreeNode
        {
            public int id;
            public string name;
            public TreeNode* left;
            public TreeNode* right;

            public TreeNode(int id, string name)
            {
                this.id = id;
                this.name = name;
                left = null;
                right = null;
            }

            public void Print() => Console.WriteLine($"{id} {name}");
            
        }

        struct BinaryTree
        {
            public TreeNode* head_node;

            public void Add(int id, string name)
            {
                TreeNode* ptr_node = (TreeNode*)Marshal.AllocHGlobal(sizeof(TreeNode));

                *ptr_node = new TreeNode(id, name);


                if (head_node == null)
                {
                    head_node = ptr_node;
                    return;
                }


                TreeNode* current = head_node;

                while (true)
                {
                    if (ptr_node->id < current->id)
                    {
                        if (current->left == null)
                        {
                            current->left = ptr_node;
                            break;
                        }
                        current = current->left;
                    }
                    else
                    {
                        if (current->right == null)
                        {
                            current->right = ptr_node;
                            break;
                        }
                        current = current->right;
                    }
                }

            }
            public void PrintTree()
            {
                Queue<TreeNode> queue = new Queue<TreeNode>();
                queue.Enqueue(*head_node);

                while (queue.Count != 0)
                {
                    var curr_node = queue.Dequeue();
                    curr_node.Print();
                    if (curr_node.left != null) queue.Enqueue(*(curr_node.left));
                    if (curr_node.right != null) queue.Enqueue(*(curr_node.right));

                }
            }


        }

        static void Main()
        {
            BinaryTree tree = new BinaryTree();

            tree.Add(8, "Сахар");
            tree.Add(23, "Мука");
            tree.Add(15, "Соль");
            tree.Add(3, "Молоко");
            tree.Add(35, "Печенье");

            tree.PrintTree();

            
        }
    }

}
