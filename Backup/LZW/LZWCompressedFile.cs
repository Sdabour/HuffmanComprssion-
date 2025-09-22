using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
namespace LZW
{
    /// <summary>
    /// This is A serialiazble class presents the cepher text 
    /// </summary>
    [Serializable]
    public class LZWCompressedFile
    {
        #region Private Data
        byte _ByteNoForPixel;
        Hashtable _CodeTable;
        int[] _OutArr;
       
        #endregion
        #region Constructor
        public LZWCompressedFile(byte btByteNoForPixel, Hashtable objCodeTable,
            int[] intOutArr)
        {
            _OutArr = intOutArr;
            _CodeTable = objCodeTable;
            _ByteNoForPixel = 8;// btByteNoForPixel;
        }
        public LZWCompressedFile(LZWSymbolCol objCol)
        {
            _OutArr = objCol.OutArr;
            _CodeTable = objCol.CodeTable;
            _ByteNoForPixel = 8;
        }
        #endregion
        #region Property
        public byte ByteNoForPixel
        {
            get
            {
                return _ByteNoForPixel;
            }
        }
        public Hashtable CodeTable
        {
            get
            {
                return _CodeTable;
            }
        }
        public int[] OutArr
        {
            get
            {
                return _OutArr;
            }
        }
        
      
     
        #endregion
        #region Public Method
        public ArrayList ConvertByteToArray(byte[] arrByte)
        {
            ArrayList Returned = new ArrayList();
            foreach (byte btTemp in arrByte)
            {
                Returned.Add(btTemp);
            }
            return Returned;
        }
        public byte[] GetImageByteArray()
        {
            ArrayList lstArr = new ArrayList();
            byte[] Returned = new byte[0];
            if (_OutArr == null || _OutArr.Length == 0)
                return Returned;
            foreach (int intEntry in _OutArr)
            {
                object objArr = _CodeTable[intEntry.ToString()];
                lstArr.AddRange(ConvertByteToArray((byte[])objArr));

            }
            Returned = new byte[lstArr.Count];
            for (int intIndex = 0; intIndex < lstArr.Count; intIndex++)
            {
                Returned[intIndex] = (byte)lstArr[intIndex];
            }
            return Returned;
                
        }
        #endregion

    }
}
