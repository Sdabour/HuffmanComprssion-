using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
namespace Huffman
{
    /// <summary>
    /// This is A serialiazble class presents the cepher text 
    /// </summary>
    [Serializable]public class HuffmanCompressedFile
    {
        #region Private Data
        byte[] _ByteArr;
        Hashtable _CodeTable;
        byte _LastByteLength;
        #endregion
        #region Constructor
        public HuffmanCompressedFile(byte[] arrByte, Hashtable objCodeTable)
        {
            _ByteArr = arrByte;
            _CodeTable = objCodeTable;
        }
        #endregion
        #region Property
        public byte[] ByteArr
        {
            get
            {
                return _ByteArr;
            }
        }
        public Hashtable CodeTable
        {
            get
            {
                return _CodeTable;
            }
        }
        #endregion
        #region Public Method
        public static string DecompressString(string strMsg, Hashtable objHashTable)
        {
            int intIndex = 0;
            string strTemp = "";
            string Returned = "";
            object objTemp;
            while (strMsg.Length > intIndex)
            {
                intIndex++;
                strTemp = strMsg.Substring(0, intIndex);
                objTemp = objHashTable[strTemp];
                if (objTemp != null)
                {
                    Returned = Returned + objTemp.ToString();
                    strMsg = strMsg.Remove(0, strTemp.Length);
                    intIndex = 0;
                }

            }
            return Returned;
        }

        public static byte[] ConvertToBinary(string strMsg)
        {
            byte[] arrByte;
            int intLength = strMsg.Length / 8;
            if (strMsg.Length % 8 > 0)
                intLength++;
            arrByte = new byte[intLength];
            byte btRef;
            char[] arrChr = strMsg.ToCharArray();
            for (int intIndex = 0; intIndex < arrChr.Length; intIndex++)
            {
                int intOutIndex = intIndex / 8;
                int intInIndex = intIndex % 8;
                btRef = (byte)Math.Pow(2, intInIndex);
                if (arrChr[intIndex] == '1')
                    arrByte[intOutIndex] = (byte)(arrByte[intOutIndex] | btRef);
            }
            return arrByte;
        }
        public static string ConvertToString(byte[] arrByte)
        {
            string Returned = "";
            
                    BitArray arrBit = new BitArray(arrByte);
                    foreach (bool blTemp in arrBit)
                    {
                        if (blTemp)
                            Returned = Returned + "1";
                        else
                            Returned = Returned + "0";
                    }
             
            return Returned;
        }
        #endregion

    }
}
