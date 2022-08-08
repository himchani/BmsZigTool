using System;
using System.Threading;

namespace FWDLlibrary
{
    public delegate int DMethod(TInfo o);

    //쓰레드풀용 사용자클래스
    public class TPool
    {
        private bool[] _fs;
        public object _dMethod;

        //생성자
        public TPool(int n, DMethod method)
        {
            _dMethod = (object)method;
            _fs = new bool[n];
        }

        //완료체크
        public bool Check()
        {
            foreach (bool _b in _fs)
            {
                if (!_b)
                    return false;
            }

            return true;
        }

        //실행
        public void Run(Object i)
        {
            TInfo ti = (TInfo)i;

            //int n = (int)i;
            int n = ti.Index;

            //실행함수처리
            DMethod d = (DMethod)ti.DMethod;

            int cnt = d(ti);

            //flag 처리
            _fs[n] = true;
        }
    }

    public class TInfo
    {
        public int Index;
        public int Msg;
        public DMethod DMethod;

        public TInfo(int i, int m, DMethod dm)
        {
            Index = i;
            Msg = m;
            DMethod = dm;
        }
    }
}