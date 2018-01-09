using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace Idnaf.SRecord
{
    class SrecParser
    {
        const string LTHex = "0123456789ABCDEF";
        private static byte[] baBinaryBuffer;
        private static byte[] SRecToArray(string strIn)
        {
            byte[] retVal;
            string strInTemp = strIn;
            strInTemp = strInTemp.Replace("S1", "");
            strInTemp = strInTemp.Replace("S2", "");
            strInTemp = strInTemp.Replace("S3", "");
            retVal = TxtToArray(strInTemp);
            return retVal;                        
        }
        private static void ParseS123(string strIn, int addresLen)
        {
            int address = 0;
            byte[] baSrecArray = SRecToArray(strIn);
            switch (addresLen)
            {
                case 2:
                    address = baSrecArray[1];
                    address = address << 8;
                    address = address + baSrecArray[2];
                    break;
                case 4:
                    address = baSrecArray[1];
                    address = address << 8;
                    address = address + baSrecArray[2];
                    address = address << 8;
                    address = address + baSrecArray[3];
                    address = address << 8;
                    address = address + baSrecArray[4];
                    break;
                case 8:
                    break;
            }

            //if ((address % 16 != 0) && isFirst)
            //{
            //    int addressTemp;
            //    //        0x1820 | ** ** ** ** ** ** ** ** ** ** ** ** 8B 89 9E FE
            //    //retVal += "Address| 00 01 02 03 04 05 06 07 08 09 0A 0B 0C 0D 0E 0F\r\n";
            //    //retVal += "-------+------------------------------------------------\r\n";
            //    for (int i = 0; i < (address % 16); i++)
            //    {
            //        addressTemp = address - (address % 16);
            //        if (i == 0)
            //            retVal += "0x" + addressTemp.ToString(stringFormat) + " | **";
            //        else
            //            retVal += " **";
            //    }
            //}
            //else
            //{
            //    if (isFirst)
            //    {
            //        //        0x1820 | ** ** ** ** ** ** ** ** ** ** ** ** 8B 89 9E FE
            //        retVal += "Address| 00 01 02 03 04 05 06 07 08 09 0A 0B 0C 0D 0E 0F\r\n";
            //        retVal += "-------+------------------------------------------------";
            //    }
            //}
            for (int i = (addresLen + 1); i < (baSrecArray[0]); i++)
            {
                //if (address % 16 != 0)
                //    retVal += " " + baSrecArray[i].ToString("X2");
                //else
                //{
                //        retVal += "\r\n0x" + address.ToString(stringFormat) + " | " + baSrecArray[i].ToString("X2");                    
                //}
                baBinaryBuffer[address] = baSrecArray[i];
                address++;
            }
            //return retVal;
        }
        static byte[] TxtToArray(string strTextIn)
        {
            string strTemp;
            byte[] bATR;

            if (strTextIn != "")
            {
                bATR = new byte[strTextIn.Length / 2];
                strTemp = strTextIn.Replace(" ", "");
                strTemp = strTemp.ToUpper();


                for (byte i = 0; i < (strTemp.Length / 2); i++)
                {
                    for (byte y = 0; y < LTHex.Length; y++)
                    {
                        if (strTemp[2 * i] == LTHex[y])
                        {
                            bATR[i] = y;
                            continue;
                        }
                    }

                    for (byte y = 0; y < LTHex.Length; y++)
                    {

                        if (strTemp[2 * i + 1] == LTHex[y])
                        {
                            bATR[i] <<= 4;
                            bATR[i] += y;
                            continue;
                        }
                    }
                }
                return bATR;
            }
            return bATR = null;
        }
        public static byte[] ParseSRec(string strFileName)
        {
            string strReadStream;
            // Make buffer
            baBinaryBuffer = new byte[65536];
            for (int i = 0; i < baBinaryBuffer.Length; i++)
            {
                baBinaryBuffer[i] = 0xFF;
            }
            try
            {
                StreamReader sr = new StreamReader(strFileName);
                bool isTerminate = false;
                while((sr.Peek() != -1) && !isTerminate)
                {
                    strReadStream = sr.ReadLine();
                    if(strReadStream.Length > 2)
                    {
                        switch(strReadStream[1])
                        {
                            case '0':
                                break;
                            case '1':
                                ParseS123(strReadStream, 2);
                                break;
                            case '2':
                                ParseS123(strReadStream, 4);
                                break;
                            case '3':
                                ParseS123(strReadStream, 8);
                                break;
                            case '7':case '8':case '9':
                                isTerminate = true;
                                break;                            
                        }

                    }
                }
                sr.Close();
            }
            catch (IOException ioe)
            { 
                
            }
            return baBinaryBuffer;
            
        }
    }
}
