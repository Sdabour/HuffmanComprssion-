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
    public class LZWSymbolBiz
    {
        #region Private Data
       byte [] _ByteArr;
       string  _Index;
        #endregion
        #region Constructor
        public LZWSymbolBiz()
        {
            
 
        }
        #endregion
        #region Public Properties
        public byte[] ByteArr
        {
            set
            {
                _ByteArr = value;
            }
            get
            {
                return _ByteArr;
            }
        }
        public string Index
        {
            set
            {
                _Index = value;
            }
            get
            {
                return _Index;
            }
        }
        public string ByteStr
        {
            get
            {
                string Returned = "";
                foreach (byte btTemp in _ByteArr)
                {
                    if (Returned != "")
                        Returned = Returned + ",";
                    Returned = Returned + btTemp.ToString();
                }
                return Returned;
            }
        }
        #endregion
        #region Private Method
        #endregion
        #region Public Method
        public bool Equals(ArrayList arrByte)
        {
           
            if(arrByte.Count != _ByteArr.Length)
                return false;
            for (int intIndex = 0; intIndex < _ByteArr.Length; intIndex++)
            {
                if (_ByteArr[intIndex] != (byte)arrByte[intIndex])
                    return false;
            }
            return true;
        }
       
        #endregion
    }
}
