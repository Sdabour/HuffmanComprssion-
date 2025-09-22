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
    public class LZWDisplayedCol : List<LZWDisplayedBiz>
    {
        #region Private Data
        Hashtable _SequenceTable;
        #endregion
        #region Constructor
        public LZWDisplayedCol(Hashtable hsSequance)
        {
            _SequenceTable = hsSequance;
            foreach (DictionaryEntry objBiz in hsSequance)
            {
                Add(new LZWDisplayedBiz(objBiz.Key.ToString(),GetByteStr((byte[])objBiz.Value)));
            }
           

        }
        #endregion
        #region Public Properties
        #endregion
        #region Private Method
        string GetByteStr(byte[] arrByte)
        {
            string Returned = "";
            foreach (byte btTemp in arrByte)
            {
                if (Returned != "")
                    Returned += ",";
                Returned += btTemp.ToString();
 
            }
            return Returned;
        }
        #endregion
        #region Public Method
        public string GetInArr(string strIndex)
        {
            string Returned = "";
            if (_SequenceTable != null && _SequenceTable[strIndex] != null)
                Returned = GetByteStr((byte[])_SequenceTable[strIndex]);
            return Returned;
        }
        #endregion
    }
}
