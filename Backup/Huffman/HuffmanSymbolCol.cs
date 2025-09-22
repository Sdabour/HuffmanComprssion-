using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
namespace Huffman
{
    public class HuffmanSymbolCol:List<HuffmanSymbolBiz>
    {
        /// <summary>
        /// this class presents colection of symbols
        /// </summary>
        #region Private Data
        Hashtable _CodeTable;
        Hashtable _letterTable;
        string _MainMsg;
        string _CompressedMsg;
        //HuffmanSymbolBiz _NextBiz;
        double _AvgLen;
        int _Len;
        int _ResultLen;
        #endregion

        #region Constructor
        public HuffmanSymbolCol(string strMsg)
        {
            _MainMsg = strMsg;
          
            Add(strMsg);
            AdjustProbabilityForSymbols();
            OrderTheCollection();
            FillLetterTable();
            SetCodeString(this);
            AdjustAvgLen();
            AdjustLen();
            FillCodeTable();
            CompressMsg();
            AdjustResultLen();
 
        }
        public HuffmanSymbolCol()
        {
           

        }
      
        #endregion
        #region Public properties
       
        public int TotalCount
        {
            get
            {
                int Returned=0;
                foreach (HuffmanSymbolBiz objBiz in this)
                {
                    Returned = Returned + objBiz.Count;

                }
                return Returned;
            }
        }
        public Hashtable LetterTable
        {
            get
            {
                return _letterTable;
            }
        }
        public Hashtable CodeTable
        {
            set
            {
                _CodeTable = value;
            }
            get
            {
                return _CodeTable;
            }
        }
        public string CompressedMsg
        {
            set
            {
                _CompressedMsg = value;
            }
            get
            {
                return _CompressedMsg;
            }
        }
        public double AvgLen
        {
            get
            {
                return _AvgLen;
            }
        }
        public int Len
        {
            get
            {
                return _Len;
            }
        }
        public int ResultLen
        {
            get
            {
                return _ResultLen;
            }
        }
        public double Entropy
        {
            get
            {
                double Returned = 0;
                foreach (HuffmanSymbolBiz objBiz in this)
                    Returned += objBiz.Entropy;
                return Returned;
            }
        }
        #endregion
        #region Private Method
        int GetIndex(HuffmanSymbolBiz objBiz)
        {
            int Returned = -1;
            for (int intIndex = 0; intIndex < Count; intIndex++)
            {
                if (this[intIndex].Sequence == objBiz.Sequence)
                {
                    Returned = intIndex;
                    break;
                }
            }
            return Returned;
        }
        void OrderTheCollection()
        {
            HuffmanSymbolBiz objTempBiz;
            for (int intIndex = 0; intIndex < Count; intIndex++)
            {

                for (int intIndex1 = intIndex + 1; intIndex1 < Count; intIndex1++)
                {

                    if (this[intIndex].Probability < this[intIndex1].Probability)
                    {
                        objTempBiz = this[intIndex];
                        this[intIndex] = this[intIndex1];
                        this[intIndex1] = objTempBiz;

                    }

                }


            }

        }
        void  SetCodeString(HuffmanSymbolCol objCol)
        {
            string strCode = "";
            string strTemp1 = "";
            string strTemp2 = "";
            bool blLetter1=false;
            bool blLetter2 = false;
            HuffmanSymbolBiz objTempBiz2 = new HuffmanSymbolBiz();//Present Refrence for objCol[count-2];
            HuffmanSymbolBiz objTempBiz1 = new HuffmanSymbolBiz();//Present refrence for objCol[Count-1];
                                                                  //Note These refrences used to keep track of the deleted items from the collection 
                                                                  //after replacing it it keep it life in memory to prevent it from garbage collector
            objTempBiz2.Code = "";
            if (objCol.Count >= 3)
            {
               if (objCol[objCol.Count - 2].IsSequence)
                {
                    strTemp2 = objCol[objCol.Count - 2].Sequence;
                    blLetter2 = true;
                }
                if (objCol[objCol.Count - 1].IsSequence)
                {
                    strTemp1 = objCol[objCol.Count - 1].Sequence;
                    blLetter1 = true;
                }
                objCol[objCol.Count-2].Probability += objCol[Count-1].Probability;
                objCol[objCol.Count-2].IsSequence = false;
                objTempBiz2 = objCol[objCol.Count - 2];
               // objCol.NextBiz = objCol[objCol.Count - 2];
                objTempBiz1 = objCol[objCol.Count - 1];
                objCol.RemoveAt(objCol.Count-1);
                objCol.OrderTheCollection();
                SetCodeString(objCol) ;
                strCode = objTempBiz2.Code;
                if(blLetter1)
                    ((HuffmanSymbolBiz)_letterTable[strTemp1]).Code = strCode + "1";
                if(blLetter2)
                     ((HuffmanSymbolBiz)_letterTable[strTemp2]).Code = strCode + "0";
                 objTempBiz1.Code = strCode + "1";
                 objTempBiz2.Code = strCode + "0";
               
            }
            else if (objCol.Count > 1)
            {
                if (objCol[1].IsSequence )
                {
                    blLetter1 = true;
                    strTemp1 = objCol[1].Sequence;
                }
                if (objCol[0].IsSequence)
                {
                    blLetter2 = true;
                    strTemp2 = objCol[0].Sequence;
                }
                if (blLetter1)
                    ((HuffmanSymbolBiz)_letterTable[strTemp1]).Code = "1";
                if (blLetter2)
                    ((HuffmanSymbolBiz)_letterTable[strTemp2]).Code = "0";
                objCol[0].Code = "0";
                if (objCol.Count > 1)
                    objCol[1].Code = "1";
 
            }
            if (!blLetter1)
                strCode += "1";
            else
                strCode += "0";
            

        }
        void FillLetterTable()
        {
            _letterTable = new Hashtable();
            foreach (HuffmanSymbolBiz objBiz in this)
            {
                _letterTable.Add(objBiz.Sequence, objBiz);
            }
        }
        void FillCodeTable()
        {
            _CodeTable = new Hashtable();
            foreach (DictionaryEntry  objBiz in _letterTable)
            {
                _CodeTable.Add(((HuffmanSymbolBiz)objBiz.Value).Code, objBiz.Key);
            }
        }
       void  Add(HuffmanSymbolBiz objBiz)
        {
            int intIndex = GetIndex(objBiz);
            if (intIndex == -1)
               base.Add(objBiz);
            else
            {
                this[intIndex].Count += 1;
            }


        }
       void Add(string strMsg)
        {
            char[] arrChr = strMsg.ToCharArray();
            HuffmanSymbolBiz objBiz;
            foreach (char chrLetter in arrChr)
            {
                if (chrLetter == '\0')
                    break;
                objBiz = new HuffmanSymbolBiz(chrLetter.ToString());

                this.Add(objBiz);

            }
        }
         void AdjustProbabilityForSymbols()
         {
            int intTtotalCount = TotalCount;
            foreach (HuffmanSymbolBiz objBiz in this)
            {
                objBiz.Probability = (double)objBiz.Count / intTtotalCount;
                objBiz.NativeProbability = objBiz.Probability;
            }

        }

        void CompressMsg()
        {
            _CompressedMsg = "";
            foreach (char chrTemp in _MainMsg.ToCharArray())
            {
                if (chrTemp == '\0')
                    break;
                _CompressedMsg += ((HuffmanSymbolBiz)_letterTable[chrTemp.ToString()]).Code;
            }

        }
        void AdjustAvgLen()
        {
           
            double dblSum = 0;
            foreach (DictionaryEntry objBiz in _letterTable)
            {
                
                ((HuffmanSymbolBiz)objBiz.Value).AvgLen = ((HuffmanSymbolBiz)objBiz.Value).Code.Length 
                    * ((HuffmanSymbolBiz)objBiz.Value).NativeProbability;
                dblSum = dblSum + ((HuffmanSymbolBiz)objBiz.Value).AvgLen;

            }
            _AvgLen = dblSum;


        }
        void AdjustResultLen()
        {
            _ResultLen = 0;
            foreach (DictionaryEntry objBiz in _letterTable)
            {

                _ResultLen = _ResultLen + (((HuffmanSymbolBiz)objBiz.Value).Code.Length *
                    ((HuffmanSymbolBiz)objBiz.Value).Count);

            }
        }
        void AdjustLen()
        {
            _Len = 0;
            foreach (DictionaryEntry objBiz in _letterTable)
            {
                
                _Len = _Len + ((HuffmanSymbolBiz)objBiz.Value).Count ;

            }
            _Len = _Len * 8;

        }
        void AdjustEntroby()
        {

        }
        #endregion
        
        #region Public Methods
        public HuffmanSymbolCol Copy()
        {
            HuffmanSymbolCol Returned = new HuffmanSymbolCol("");
            foreach (HuffmanSymbolBiz objBiz in this)
            {
                Returned.Add(objBiz.Copy());

            }
            return Returned;
        }
      
        #endregion

    }
}
