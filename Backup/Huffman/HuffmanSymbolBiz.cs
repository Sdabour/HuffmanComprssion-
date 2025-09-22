using System;
using System.Collections.Generic;
using System.Text;

namespace Huffman
{
    public class HuffmanSymbolBiz
    {
        /// <summary>
        /// This Class Is Used to Classify the Letters to be compressed
        /// </summary>
        #region Private Data
        string _Code;
        string _Sequence;
        double _Probability;
        double _NativeProbability;
        int _Count;
        bool _IsSequence;
        double _AvgLen;

        HuffmanSymbolBiz _PreviousBiz;
        #endregion
        #region Constructors
        public HuffmanSymbolBiz()
        {
            _Code = "";
        }
        public HuffmanSymbolBiz(string strSequence)
        {
            _Sequence = strSequence;
            _IsSequence = true;
            _Count = 1;
            _Code = "";
        }
        #endregion
        #region Public Properties
        public string Code
        {
            set
            {
                _Code = value;
            }
            get
            {
                return _Code;
            }
        }
        public string Sequence
        {
            set
            {
                _Sequence = value;
            }
            get
            {
                return _Sequence;
            }
        }
        public double Probability
        {
            set
            {
                _Probability = value;
            }
            get
            {
                return _Probability;
            }
        }
        public double NativeProbability
        {
            set
            {
                _NativeProbability = value;
            }
            get
            {
                return _NativeProbability;
            }
        }
        public int Count
        {
            set
            {
                _Count = value;
            }
            get
            {
                return _Count;
            }
        }
        public bool IsSequence
        {
            set
            {
                _IsSequence = value;
            }
            get
            {
                return _IsSequence;
            }
        }
        public HuffmanSymbolBiz PreviousBiz
        {
            set
            {
                _PreviousBiz = value;
            }
            get
            {
                return _PreviousBiz;
            }
        }
        public double AvgLen
        {
            set
            {
                _AvgLen = value;
            }
            get
            {
                return _AvgLen;
            }
        }
        public double Entropy 
        {
            get
            {
                double Returned = 0;
                Returned = -1*Math.Log(NativeProbability, 2) * NativeProbability;
                return Returned;
            }
        }
        #endregion
        #region Private Methods

        #endregion
        #region Public Methods
        public HuffmanSymbolBiz Copy()
        {
            HuffmanSymbolBiz Returned = new HuffmanSymbolBiz();
            Returned._Code = _Code;
            Returned._Count = _Count;
            Returned._Sequence = _Sequence;
            Returned._Probability = _Probability;
            Returned.IsSequence = _IsSequence;
            return Returned;
        }
        #endregion
    }
}
