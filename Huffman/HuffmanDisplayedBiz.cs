using System;
using System.Collections.Generic;
using System.Text;

namespace Huffman
{
    /// <summary>
    /// developed by Eng.Sameh Mohamed Dabour 
    /// www.algorithmat.com
    /// </summary>
    public class HuffmanDisplayedBiz
    {
        #region Private Data
        HuffmanSymbolBiz _SymbolBiz;
        #endregion
        #region Constructor
        public HuffmanDisplayedBiz(HuffmanSymbolBiz objBiz)
        {
            _SymbolBiz = objBiz;
        }
        #endregion
        #region public Properties
        public string Sequence
        {
            get
            {
                return _SymbolBiz.Sequence;
            }
        }
        public double Probability
        {
            get
            {
                return _SymbolBiz.NativeProbability;
            }
        }
        public string Code
        {
            get
            {
                return _SymbolBiz.Code;
            }
        }
        #endregion
    }
}
