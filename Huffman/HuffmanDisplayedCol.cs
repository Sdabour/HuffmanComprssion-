using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
namespace Huffman
{
    /// <summary>
    /// developed by Eng.Sameh Mohamed Dabour 
    /// www.algorithmat.com
    /// </summary>
    public class HuffmanDisplayedCol : List<HuffmanDisplayedBiz>
    {
        #region Private Data
        #endregion
        #region Constructor
        public HuffmanDisplayedCol(Hashtable hsSequance)
        {
            //foreach (HuffmanSymbolBiz objBiz in objCol)
            foreach(DictionaryEntry objBiz in hsSequance)
            {
                //if (objBiz.IsSequence)
                //{

                    Add(new HuffmanDisplayedBiz((HuffmanSymbolBiz)objBiz.Value));
                //}
            }
            SortCol();
 
        }
        #endregion
        #region Public Properties
        #endregion  
        #region Public Method
        public void SortCol()
        {
            HuffmanDisplayedBiz objTemp;

            for (int intIndex = 0; intIndex < Count; intIndex++)
            {

                for (int intIndex1 = intIndex + 1; intIndex1 < Count; intIndex1++)
                {

                    if (this[intIndex].Probability < this[intIndex1].Probability
                        || this[intIndex].Code.Length > this[intIndex1].Code.Length)
                    {
                        objTemp = this[intIndex];
                        this[intIndex] = this[intIndex1];
                        this[intIndex1] = objTemp;

                    }

                }


            }

        }
        #endregion
    }
}
