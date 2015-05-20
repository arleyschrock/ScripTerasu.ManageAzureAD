using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ScripTerasu.PowerShell.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Executor.Instance.ExcutePowershellCommands();
        }
    }
}
