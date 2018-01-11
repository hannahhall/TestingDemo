using System;
using System.Collections.Generic;
using Xunit;

namespace TreeFarm.Tests
{
    public class TreeFarm_FarmShould
    {
        [Fact]
        public void Add()
        {
            Farm farm = new Farm();
            Tree tree = new Tree();

            farm.AddTree(tree);

            Assert.Contains(tree, farm.TreeList);

        }

        [Fact]
        public void Remove()
        {
            Farm farm = new Farm();
            Tree tree = new Tree();
            farm.AddTree(tree);
            farm.RemoveTree(tree);

            Assert.DoesNotContain(tree, farm.TreeList);

        }

        [Fact]
        public void ListAll()
        {
            Farm farm = new Farm();
            Tree tree = new Tree();
            farm.AddTree(tree);

            List<Tree> expected = new List<Tree>()
            {
                tree
            };

            Assert.Equal(expected, farm.ListAll());
        }
        
    }


}