using System;
using System.Collections.Generic;
using System.Text;

namespace LZW
{
    public class LZWDisplayedBiz
    {
        #region Private Data
        string _Sequence;
        string _Index;
        #endregion
        #region Constructor
        public LZWDisplayedBiz(string strIndex,string strSquence)
        {
            _Sequence = strSquence;
            _Index = strIndex;
        }
        #endregion
        #region public Properties
        public string Sequence
        {
            get
            {
                return _Sequence;
            }
        }
       
        public string Index
        {
            get
            {
                return _Index;
            }
        }
        #endregion
    }
}
