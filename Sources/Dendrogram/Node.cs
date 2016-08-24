 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AggloCluster.Dendrogram
{
    public class Node<T>
    {
        private T contents;
        private List<Node<T>> children;

        public Node(T contents)
        {
            this.contents = contents;
            this.children = new List<Node<T>>();
        }

        public Node(Node<T> child0, Node<T> child1)
        {
            this.contents = default(T);

            List<Node<T>> list = new List<Node<T>>();
            list.Add(child0);
            list.Add(child1);

            this.children = list;
        }

        public T GetContents()
        {
            return contents;
        }

        public List<Node<T>> GetChildren()
        {
            return this.children;
        }
    }
}
