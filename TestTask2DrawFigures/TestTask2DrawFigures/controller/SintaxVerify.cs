using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestTask2DrawFigures.controller
{

    public static class SintaxVerify
    {
        enum State { S1, P1, P2, P3, P4, P5, ERROR };

        public static string verify(string subString)
        {
            int l = subString.Length;
            int indexCurrentString = 0;
            State currentState = State.S1;
            string resultString = null;
            bool key = true;
            while (key)
            {
                switch (currentState)
                {
                    case State.S1:
                        {
                            if (subString[indexCurrentString] == '[')
                            {
                                currentState = State.P1;

                            }
                            else currentState = State.ERROR;
                        }
                        break;
                    case State.P1:
                        {
                            if (char.IsDigit(subString[indexCurrentString]))
                            {
                                currentState = State.P2;

                            }

                            else currentState = State.ERROR;
                        }
                        break;
                    case State.P2:
                        {
                            if (char.IsDigit(subString[indexCurrentString]))
                            {
                                currentState = State.P2;
                            }
                            else
                                if (subString[indexCurrentString] == ',')
                                {
                                    currentState = State.P3;
                                }
                                else currentState = State.ERROR;
                        }
                        break;
                    case State.P3:
                        {
                            if (char.IsDigit(subString[indexCurrentString]))
                            {
                                currentState = State.P4;
                            }
                            else currentState = State.ERROR;
                        }
                        break;
                    case State.P4:
                        {
                            if (char.IsDigit(subString[indexCurrentString]))
                            {
                                currentState = State.P4;
                            }
                            else
                                if (subString[indexCurrentString] == ']')
                                {
                                    currentState = State.P5;
                                }
                                else currentState = State.ERROR;
                        }
                        break;
                    case State.P5:
                        {
                            if (indexCurrentString == subString.Length)
                            {
                                key = false;
                              
                            }
                            else
                                if (subString[indexCurrentString] == '[' && indexCurrentString < subString.Length)
                                {
                                    currentState = State.P1;
                                }
                                else currentState = State.ERROR;
                        }
                        break;
                    case State.ERROR:
                        {
                            key = false;
                            resultString = "error in posotion" + indexCurrentString;
                        }
                        break;
                }
                if (indexCurrentString < subString.Length)
                {
                    indexCurrentString++;
                }

            } return resultString;


        }




    }

}

