using System;
using System.Runtime.InteropServices;

namespace CSharpComLibTest
{
    [Guid("ECF2DF00-8EF6-49AE-9197-C5FEE10287B1")]
    [ComVisible(true)]
    public interface Interface_Methods
    {
        [DispId(1)]
        void Init(string userid, string password);
        [DispId(2)]
        bool Method2(string selCommand);
        [DispId(3)]
        bool Method3();
        [DispId(4)]
        void Method4(string insCommand);
        [DispId(5)]
        string Method5(int pos);
    }
}
