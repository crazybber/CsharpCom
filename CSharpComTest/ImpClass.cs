using System;
using System.Runtime.InteropServices;

namespace CSharpComLibTest
{
    [Guid("B54AF8B4-CCC1-497F-8514-D876FAE3B803")]
    [ClassInterface(ClassInterfaceType.None)]
    [ComSourceInterfaces(typeof(Interface_Events))]
    [ProgId("CSharpComLibTest.ImpClass")]
    [ComVisible(true)]
    public class ImpClass : Interface_Methods
    {
        private string myConnection = null;

        public ImpClass()
        {
        }

        public void Init(string userid, string password)
        {
                string myConnectString = "user id=" + userid + ";password=" + password +
                    ";Database=NorthWind;Server=SKYWALKER;Connect Timeout=30";
                Console.WriteLine("i am init method,i got userid:{0},password:{1}",userid,password);
            myConnection = myConnectString;
        }

        public bool Method2(string selCommand)
        {
            Console.WriteLine("i am Method2 i got a string:{0}",selCommand);
            return true;
        }

        public bool Method3()
        {
            Console.WriteLine("i am Method3 and i will return true");
            return true;
        }

        public string Method5(int pos)
        {
            Console.WriteLine("i am Method4 and i get an pos:{0}",pos);
            return pos.ToString();
        }

        public void Method4(string insCommand)
        {
            Console.WriteLine("i am Method5 and i get an insCommand:{0}", insCommand);
        }
    }
}
