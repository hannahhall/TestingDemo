using System.Collections.Generic;

namespace TreeFarm.Tests
{
    public class Farm
    {

        public List<Tree> TreeList = new List<Tree>();

        public void AddTree(Tree tree) 
        {
            TreeList.Add(tree);
        }

        public void RemoveTree(Tree tree)
        {
            TreeList.Remove(tree);

        }

        public List<Tree> ListAll()
        {
            return TreeList;
        }
    }
}