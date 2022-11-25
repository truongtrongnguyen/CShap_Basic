using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Text.RegularExpressions;

namespace BT_co_ban
{
    internal class _300Code_Thieu_Nhi
    {
        //public void Demo1()     //Tên bài: Two Sum, TÌm vị trí của 2 số nếu bằng 9 thì trả về vị trí của 2 số đó
        public int[] Demo1()
        {
            int[] nums = new int[] { 8, 7, 10, 11, 2, 15 };
            int target = 9;

            //Hashtable hasMap = new Hashtable();
            //int num = 0;
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    num = nums[i];
            //    // Console.WriteLine($"{num}, {hasMap}");
            //    if (hasMap[target - num] != default)
            //    {
            //        Console.WriteLine($"[{i} {hasMap[target - num]}]".ToString());
            //        return;
            //    }
            //    hasMap[num] = i;
            //}

            //cÁCH 2:   https://www.c-sharpcorner.com/article/two-sum-leetcodes-solution-in-c-sharp-with-both-on-and-on2-approach/


            int arrayLength = nums.Length;
            Dictionary<int, int> resultDictionary = new Dictionary<int, int>();
            if (arrayLength == default || arrayLength < 2) return Array.Empty<int>();

            for(int i=0;i<arrayLength;i++)
            {
                int firstNumber = nums[i];
                int secondNumber = target - firstNumber;
                if(resultDictionary.TryGetValue(secondNumber, out int index))    //Lấy vị trí secondNumber trong mảng Dictionary nếu có thì trả về vị trí đó
                                                                                 // trong mảng Dictionary cùng với vị trí i hiện tại
                {
                    
                    return new[] { index,  i};
                }
                resultDictionary.Add(firstNumber, i);   // 2 dòng này có tác dụng là thêm phần tử i vào trong mảng reusultDictionry
                //resultDictionary[firstNumber] = i;
                Console.WriteLine(String.Join(" ", resultDictionary));
            }
            return Array.Empty<int>();
        } 

        public bool Demo2()     //Tên bài: Valid Parentheses
        {
            Stack stack = new Stack();
            string s = "()[]{}";
            foreach (var ch in s.ToCharArray())
            {
                if (ch == '(' || ch == '[' || ch == '{')
                {
                    stack.Push(ch);
                }
                //char top = (char)stack.Pop();
                else if (ch == ')' && stack.Count != 0 && (char)stack.Peek() == '(')
                {
                    stack.Pop();
                }
                else if (ch == ']' && stack.Count != 0 && (char)stack.Peek() == '[')
                {
                    stack.Pop();
                }
                else if (ch == '}' && stack.Count != 0 && (char)stack.Peek() == '{')
                {
                    stack.Pop();
                }
            }
            // Trả về true nếu stack không còn phần tử nào
            return stack.Count == 0;
        }

        #region - Demo 3
        public class Demo3
        {
            public class Node
            {
                public int data;
                public Node next;
            }
            static Node newNode(int key)
            {
                Node temp = new Node();
                temp.data = key;
                temp.next = null;
                return temp;
            }
            public void PrintsList(Node node)
            {
                while (node != null)
                {
                    Console.Write(node.data+" ");
                    node = node.next;
                }
            }
            public Node merge(Node h1, Node h2)
            {
                if (h1==null)
                {
                    return h2;
                }
                if(h2==null)
                {
                    return h1;
                }
                if(h1.data<h2.data)
                {
                    h1.next = merge(h1.next, h2);
                    return h1;
                }
                else//(h1.data>=h2.data)    
                {
                    h2.next = merge(h1, h2.next);
                    return h2;
                }
            }
            public void Demo()
            {
                Node head1 = newNode(1);
                head1.next = newNode(3);
                head1.next.next = newNode(5);
                head1.next.next.next = newNode(6);

                // 1.3.5 LinkedList created

                Node head2 = newNode(0);
                head2.next = newNode(1);
                head2.next.next = newNode(4);
                // 0.2.4 LinkedList created

                Node mergedhead = merge(head1, head2);

                PrintsList(mergedhead);
            }
        }
        #endregion

        public int Demo4() //Best Time to Buy and Sell Stock
        {
            int[] array = { 7, 1, 5, 3, 6, 4 };
            int profit = 0; //loi nhuan
            int maxProfit = 0;  //biến dùng để so sánh lấy lợi nhuận cao nhất
            if(array==null||array.Length<=1)
            {
                return profit;
            }
            int bp = array[0];//gia mua
            int sp = -1;//gia ban
            for(int i=1;i<array.Length;i++)
            {
                if (array[i] < bp)//lấy giá mua nhỏ nhất
                {
                    bp = array[i];
                    sp = 0; //reset the SP  
                }
                else if (array[i]>=sp)  //So sánh nếu thấy giá cao có lời thì tính 
                {
                    sp = array[i];
                    profit = sp - bp;
                    maxProfit = Math.Max(profit, maxProfit);
                }
                Console.WriteLine($"minPrice: {bp} | profit: {profit} | maxProfit: {maxProfit}");
            }
            return maxProfit;
        }


        public bool Demo5() //Valid Palindrome
        {
            string s = "A man, a plan, a canal: Panama";
            s = Regex.Replace(s, @"\W", "").ToLower();
            
            for (int i = 0; i < s.Length - 1;i++)
            {
                if (s[i] != s[s.Length - 1 - i])
                {
                    return false;
                }
            }
            return true;
        }

        #region DEMO 6
        public class Node
        {
            public int data;
            public Node left;
            public Node right;
            public Node(int value)
            {
                data = value;
            }
            public override string ToString()
            {
                return "Node: " + data;
            }
            public void InvertABinarySearchTree(Node Tree)
            {
                if (Tree == null) return;
                Node temp = Tree.left;
                Tree.left = Tree.right;
                Tree.right = temp;
                if(Tree.left!=null)
                {
                    InvertABinarySearchTree(Tree.left);
                }
                if (Tree.right != null)
                    InvertABinarySearchTree(Tree.right);
            }
        }
        public void Demo6()
        {

            Node c = new Node(1);
            c.right = new Node(2);
            c.left = new Node(3);
            Console.WriteLine(c.left.ToString());
            Console.WriteLine(c.right.ToString());
            c.InvertABinarySearchTree(c);
            Console.WriteLine(c.left.ToString());
            Console.WriteLine(c.right.ToString());
        }
        #endregion

        public int Demo7()     //Binary Search
        {
            int[] a = new int[] { -1, 0, 3, 5, 9, 12 };
            int target = 5;
            int low = 0;
            int hight = a.Length - 1;
            while(low<=hight)
            {
                int privot = hight + low / 2;
                int num = a[privot];
                if (target == num) return privot;
                else if (target < num) hight = privot - 1;
                else if (target > num) low = privot + 1;
            } 
            return -1;
        }
        public void Demo8() //Maximum Subarray
        {
            int[] a = new int[] { -2, 1, -3, 4, -1, 2, 1, -5, 4 };
            int max = a[0];
            int sum = a[0];
            for(int i=1;i<a.Length;i++)
            {
                int num = a[i];
                sum = Math.Max(num, sum+num);
                max = Math.Max(sum, max);
                Console.WriteLine(sum + " "+max);
                Console.WriteLine(max);
            }
        }

        #region 
        // Definition for a binary tree node.
        // https://leetcode.com/problems/lowest-common-ancestor-of-a-binary-search-tree/submissions/
        public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;
            public TreeNode(int x) { val = x; }
        }


        public class Solution
        {
            public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
            {
                var pVal = p.val;
                var qVal = q.val;
                var rootVal = root.val;

                if (pVal < rootVal && qVal < rootVal)
                {
                    return LowestCommonAncestor(root.left, p, q);
                }
                else if (pVal > rootVal && qVal > rootVal)
                {
                    return LowestCommonAncestor(root.right, p, q);
                }

                return root;
            }
        }
        #endregion
        public void Demo10()
        {

            //Hashtable hasMap = new Hashtable();
            //int num = 0;
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    num = nums[i];
            //    // Console.WriteLine($"{num}, {hasMap}");
            //    if (hasMap[target - num] != default)
            //    {
            //        Console.WriteLine($"[{i} {hasMap[target - num]}]".ToString());
            //        return;
            //    }
            //    hasMap[num] = i;
            //}

            var a_temp = Console.ReadLine().Split(' ');
            var a = Array.ConvertAll(a_temp, Int32.Parse);
            var maxCount = 0;
            var sortedList = a.OrderBy(x => x).ToList();

            for (int i = 0; i < sortedList.Count; i++)
            {
                var currentCount = 1;
                if (i > 0)
                    if (sortedList[i] == sortedList[i - 1])
                        continue;

                for (int j = i + 1; j < sortedList.Count; j++)
                {
                    if (Math.Abs(sortedList[j] - sortedList[i]) <= 1)
                        currentCount++;
                    else
                        break;
                }

                if (currentCount > maxCount)
                    maxCount = currentCount;
            }
            Console.WriteLine(maxCount);

        }
    }
}
