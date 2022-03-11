using System;
using System.Collections.Generic;
using System.Linq;

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
        private KvNode RootNode = new KvNode
        {
            NodeValue = "#",
            Path = "/",
        };

        public string Get(string path)
        {
            Queue<string> pathQ = PathHierarchy(path);

            var node = TraverseGet(RootNode, pathQ);

            if (node != null)
            {
                return node.NodeValue;
            }
            return null;
        }

        private static Queue<string> PathHierarchy(string path)
        {
            if (string.IsNullOrEmpty(path))
            {
                throw new ArgumentNullException("path");
            }
            var paths = path.Split('/').ToArray();
            var pathQ = new Queue<string>(paths);
            return pathQ;
        }

        private KvNode TraverseGet(KvNode node, Queue<string> pathQ)
        {
            if (node == null) return null;
            if (pathQ.Count() == 0) return null;

            string subPath = DequeueNextSubPath(pathQ);

            var pathNode = node.ChildNodes.FirstOrDefault(x => x.Path.Equals($"/{subPath}", StringComparison.CurrentCultureIgnoreCase));
            if (pathNode == null)
            {
                throw new ArgumentException($"Node does not exists. Node: {subPath}");
            }
            if (pathQ.Count() != 0)
            {
                pathNode = TraverseGet(pathNode, pathQ);
            }
            return pathNode;
        }

        private static string DequeueNextSubPath(Queue<string> pathQ)
        {
            var subPath = pathQ.Dequeue();
            if (string.IsNullOrEmpty(subPath))
            {
                subPath = pathQ.Dequeue();
            }

            return subPath;
        }

        public bool Set(string path, string value)
        {
            Queue<string> pathQ = PathHierarchy(path);

            var node = TraverseGet(RootNode, pathQ);
            if(node != null)
            {
                node.NodeValue = value;
                return true;
            }
            return false;
        }

        private bool TraverseCreate(KvNode node, Queue<string> pathQ, string value)
        {
            string subPath = DequeueNextSubPath(pathQ);

            var pathNode = node.ChildNodes.FirstOrDefault(x => x.Path.Equals($"/{subPath}", StringComparison.CurrentCultureIgnoreCase));
            //Node not found.
            if (pathNode == null)
            {
                //Means the input path requested has more levels and invalid
                if (pathQ.Count() != 0)
                {
                    throw new ArgumentException($"Node does not exists. Node: {subPath}");
                }

                //If this is the last path to be created, create it
                if (pathQ.Count() == 0)
                {
                    node.ChildNodes.Add(new KvNode
                    {
                        Path = $"/{subPath}",
                        NodeValue = value
                    });
                    return true;
                }
            }

            //Existing Node
            if (pathQ.Count() == 0)
            {
                throw new ArgumentException($"Node Exists. NodePath: {pathNode.Path}");
            }
            //More to go
         
            TraverseCreate(pathNode, pathQ, value);
            return false;
        }

        public bool Create(string path, string value)
        {
            if (path.Trim().Equals("/"))
            {
                throw new ArgumentNullException("Cannot modify the root node.");
            }

            Queue<string> pathQ = PathHierarchy(path);

            return TraverseCreate(RootNode, pathQ, value);
        }

        public bool Delete(string path)
        {
            if (path.Trim().Equals("/"))
            {
                throw new ArgumentNullException("Cannot modify the root node.");
            }

            Queue<string> pathQ = PathHierarchy(path);

            return TraverseDelete(RootNode, pathQ);
        }

        private bool TraverseDelete(KvNode node, Queue<string> pathQ)
        {
            string subPath = DequeueNextSubPath(pathQ);

            var pathNode = node.ChildNodes.FirstOrDefault(x => x.Path.Equals($"/{subPath}", StringComparison.CurrentCultureIgnoreCase));
            //Node not found.
            if (pathNode == null)
            {
                throw new ArgumentException($"Node does not exists. Node: {subPath}");
            }

            //Existing Node and no more traversal
            if (pathQ.Count() == 0)
            {
                node.ChildNodes.RemoveAll(x => x.Path.Equals($"/{subPath}"));
                return true;
            }
            //More to go
            TraverseDelete(pathNode, pathQ);
            
            return false;
        }
    }
}
