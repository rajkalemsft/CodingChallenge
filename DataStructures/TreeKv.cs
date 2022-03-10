using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataStructures
{
    class KvNode
    {
        public KvNode()
        {
            ChildNodes = new List<KvNode>();
        }
        public List<KvNode> ChildNodes { get; set; }

        public string Path { get; set; }

        public string NodeValue { get; set; }

    }
    internal class TreeKv
    {
        private KvNode kv = new KvNode
        {
            NodeValue = "#",
            Path = "/",
        };

        public string Get(string path)
        {
            return "";
        }

        private KvNode Traverse(KvNode node, string path)
        {
            if (node == null) return null;
            if(string.IsNullOrEmpty(path)) return null;

            var nodesToVisit = path.Split('/');
            if(nodesToVisit.Length == 1)
            {
                return node.ChildNodes.FirstOrDefault(x=> x.Path.Equals(path));
            }


            return node;
        }

        public bool Set(string path, string value)
        {
            return false;
        }

        public bool Create(string path, string value)
        {
            return true;
        }

        public bool Delete(string path)
        {
            return true;
        }
    }
}
