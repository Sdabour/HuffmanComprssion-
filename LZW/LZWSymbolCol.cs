using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
namespace LZW
{
    /// <summary>
    /// developed by Eng.Sameh Mohamed Dabour 
    /// www.algorithmat.com
    /// </summary>
    public class LZWSymbolCol:CollectionBase
    {
        #region Private Data
        byte []_ByteArr;
        Hashtable _CodeTable;
        Hashtable _ByteTable;
        
        int[] _OutArr;
        #endregion
        #region Constructors
        public LZWSymbolCol(byte[] arrByte)
        {
            _ByteArr = arrByte;
            FillHashTableInitially();
            _OutArr = GetHashIndex(0);



        }
        #endregion
        #region Public Properties
        public LZWSymbolBiz this[int intIndex]
        {
            get
            {
                return (LZWSymbolBiz)List[intIndex];
            }
        }
        public int[] OutArr
        {
            get 
            {
                return _OutArr;
            }
        }
        public Hashtable CodeTable
        {
            get
            {
                return _CodeTable;
            }
        }
        public string ByteArrStr
        {
            get
            {
                string Returned = "";
                if (_ByteArr == null)
                    _ByteArr = new byte[0];
                int intCount = 0;
                foreach (byte btTemp in _ByteArr)
                {
                    if (intCount == 5000)
                        break;
                    if (Returned != "")
                        Returned += ",";
                    intCount++;
                    Returned += btTemp.ToString();
                }
                return Returned;
            }
        }
        public string OutShortArrStr
        {
            get
            {
                string Returned = "";
                if (_OutArr == null)
                    _OutArr = new int[0];
                int intCount = 0;
                foreach (int intTemp in _OutArr)
                {
                    if (intCount == 5000)
                        break;
                    intCount++;
                    if (Returned != "")
                        Returned += ",";
                   
                    Returned += intTemp.ToString();
                }
                return Returned;
            }
        }
        public int MainArrayLen
        {
            get
            {
                return _ByteArr.Length;
            }
        }
        #endregion
        #region Private Methods
        int GetIndex(byte btSymbol)
        {
            int intIndex = -1;
          
            foreach (LZWSymbolBiz objBiz in this)
            {
                intIndex++;
                if (objBiz.ByteArr.Length== 1 && (byte)objBiz.ByteArr[0] == btSymbol)
                    return intIndex;
 
            }
            return -1;
        }
        int GetIndex(byte[] arrByte)
        {
            int intIndex = -1;

            foreach (LZWSymbolBiz objBiz in this)
            {
                intIndex++;
                if (objBiz.Equals(arrByte))
                    return intIndex;

            }
            return -1;
        }
        int GetIndex(ArrayList lstByte)
        {
            int intIndex = -1;

            foreach (LZWSymbolBiz objBiz in this)
            {
                intIndex++;
                if (objBiz.Equals(lstByte))
                    return intIndex;

            }
            return -1;
        }
        void FillHashTableInitially()
        {
            _ByteTable = new Hashtable();
            _CodeTable = new Hashtable();
            LZWSymbolBiz objBiz;
            string strByte;
            foreach (byte btSymbol in _ByteArr)
            {
                strByte = btSymbol.ToString();
                if (_ByteTable[strByte] == null)
                {
                    objBiz = new LZWSymbolBiz();
                    objBiz.ByteArr = new byte[1];
                    objBiz.ByteArr[0]= btSymbol;
                    objBiz.Index = Count.ToString();
                    _CodeTable.Add(objBiz.Index, objBiz.ByteArr);
                    Add(objBiz);
                    _ByteTable.Add(objBiz.ByteStr, objBiz.Index);
 
                }
            }
 
        }
        int [] GetHashIndex(int intIndex)
        {
            int[] Returned= new int[0];
           
            ArrayList lstByte = new ArrayList();
            ArrayList lstResult = new ArrayList();
            LZWSymbolBiz objTempBiz;
            int intTempIndex;
            int intCurrentIndex;
            int intPreviousIndex = 0;
            string strByte;
            while (intIndex < _ByteArr.Length)
            {
                intTempIndex = intIndex;
                byte btTemp = _ByteArr[intIndex];
                lstByte.Add(btTemp);
                //intCurrentIndex = GetIndex(lstByte);
                strByte = GetByteStr(lstByte);
                object objTemp = _ByteTable[strByte];
                if (objTemp != null)
                    intCurrentIndex = int.Parse(objTemp.ToString());
                else
                    intCurrentIndex = -1;
                if (intCurrentIndex == -1)
                {
                    objTempBiz = new LZWSymbolBiz();
                    objTempBiz.Index = Count.ToString();
                    objTempBiz.ByteArr = ConvertLstToByteArray(lstByte);
                    lstByte = new ArrayList();
                    _CodeTable.Add(objTempBiz.Index, objTempBiz.ByteArr);
                    _ByteTable.Add(strByte, objTempBiz.Index);
                    Add(objTempBiz);
                    //out the byte array
                    lstResult.Add(intPreviousIndex);

                }
                else
                {
                   // lstResult.Add(btTemp);
                    intPreviousIndex = intCurrentIndex;
                    intIndex++;
                }

            }
            Returned = ConvertLstToShortArray(lstResult);
            return Returned;
        }
        byte[] ConvertLstToByteArray(ArrayList lstArr)
        {
            byte[] Returned = new byte[lstArr.Count];
            for (int intIndex = 0; intIndex < lstArr.Count; intIndex++)
            {
                Returned[intIndex] = (byte)lstArr[intIndex];
            }
            return Returned;
        }
        string GetByteStr(ArrayList lstByte)
        {
            string Returned = "";
            foreach(object objTemp in lstByte)
            {
            if (Returned != "")
                Returned += ",";
            Returned += objTemp.ToString();
            }
            return Returned;
        }
        int[] ConvertLstToShortArray(ArrayList lstArr)
        {
            int[] Returned = new int[lstArr.Count];
            for (int intIndex = 0; intIndex < lstArr.Count; intIndex++)
            {
                Returned[intIndex] = (int)lstArr[intIndex];
            }
            return Returned;
        }
        #endregion
        #region Public Methods
        public void Add(LZWSymbolBiz objBiz)
        {
            List.Add(objBiz);
        }
        
        #endregion
    }
}
