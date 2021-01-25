using System;
using System.IO;

namespace m64bytes2string
{
    class Program
    {
        static void Main(string[] args)
        {
            File.WriteAllText("Strings.txt",GetString(File.ReadAllBytes(args[0])));
        }

        public static bool AutoDetectStartEndQuotationMarks { get; set; } = true;

        public static string GetString(byte[] bytes)
        {
            string txt = "";
            foreach (byte b in bytes)
            {
                switch (b)
                {
                    case 0x0:
                        {
                            txt += "0";
                            break;
                        }

                    case 0x1:
                        {
                            txt += "1";
                            break;
                        }

                    case 0x2:
                        {
                            txt += "2";
                            break;
                        }

                    case 0x3:
                        {
                            txt += "3";
                            break;
                        }

                    case 0x4:
                        {
                            txt += "4";
                            break;
                        }

                    case 0x5:
                        {
                            txt += "5";
                            break;
                        }

                    case 0x6:
                        {
                            txt += "6";
                            break;
                        }

                    case 0x7:
                        {
                            txt += "7";
                            break;
                        }

                    case 0x8:
                        {
                            txt += "8";
                            break;
                        }

                    case 0x9:
                        {
                            txt += "9";
                            break;
                        }

                    case 0xA:
                        {
                            txt += "A";
                            break;
                        }

                    case 0xB:
                        {
                            txt += "B";
                            break;
                        }

                    case 0xC:
                        {
                            txt += "C";
                            break;
                        }

                    case 0xD:
                        {
                            txt += "D";
                            break;
                        }

                    case 0xE:
                        {
                            txt += "E";
                            break;
                        }

                    case 0xF:
                        {
                            txt += "F";
                            break;
                        }

                    case 0x10:
                        {
                            txt += "G";
                            break;
                        }

                    case 0x11:
                        {
                            txt += "H";
                            break;
                        }

                    case 0x12:
                        {
                            txt += "I";
                            break;
                        }

                    case 0x13:
                        {
                            txt += "J";
                            break;
                        }

                    case 0x14:
                        {
                            txt += "K";
                            break;
                        }

                    case 0x15:
                        {
                            txt += "L";
                            break;
                        }

                    case 0x16:
                        {
                            txt += "M";
                            break;
                        }

                    case 0x17:
                        {
                            txt += "N";
                            break;
                        }

                    case 0x18:
                        {
                            txt += "O";
                            break;
                        }

                    case 0x19:
                        {
                            txt += "P";
                            break;
                        }

                    case 0x1A:
                        {
                            txt += "Q";
                            break;
                        }

                    case 0x1B:
                        {
                            txt += "R";
                            break;
                        }

                    case 0x1C:
                        {
                            txt += "S";
                            break;
                        }

                    case 0x1D:
                        {
                            txt += "T";
                            break;
                        }

                    case 0x1E:
                        {
                            txt += "U";
                            break;
                        }

                    case 0x1F:
                        {
                            txt += "V";
                            break;
                        }

                    case 0x20:
                        {
                            txt += "W";
                            break;
                        }

                    case 0x21:
                        {
                            txt += "X";
                            break;
                        }

                    case 0x22:
                        {
                            txt += "Y";
                            break;
                        }

                    case 0x23:
                        {
                            txt += "Z";
                            break;
                        }

                    case 0x24:
                        {
                            txt += "a";
                            break;
                        }

                    case 0x25:
                        {
                            txt += "b";
                            break;
                        }

                    case 0x26:
                        {
                            txt += "c";
                            break;
                        }

                    case 0x27:
                        {
                            txt += "d";
                            break;
                        }

                    case 0x28:
                        {
                            txt += "e";
                            break;
                        }

                    case 0x29:
                        {
                            txt += "f";
                            break;
                        }

                    case 0x2A:
                        {
                            txt += "g";
                            break;
                        }

                    case 0x2B:
                        {
                            txt += "h";
                            break;
                        }

                    case 0x2C:
                        {
                            txt += "i";
                            break;
                        }

                    case 0x2D:
                        {
                            txt += "j";
                            break;
                        }

                    case 0x2E:
                        {
                            txt += "k";
                            break;
                        }

                    case 0x2F:
                        {
                            txt += "l";
                            break;
                        }

                    case 0x30:
                        {
                            txt += "m";
                            break;
                        }

                    case 0x31:
                        {
                            txt += "n";
                            break;
                        }

                    case 0x32:
                        {
                            txt += "o";
                            break;
                        }

                    case 0x33:
                        {
                            txt += "p";
                            break;
                        }

                    case 0x34:
                        {
                            txt += "q";
                            break;
                        }

                    case 0x35:
                        {
                            txt += "r";
                            break;
                        }

                    case 0x36:
                        {
                            txt += "s";
                            break;
                        }

                    case 0x37:
                        {
                            txt += "t";
                            break;
                        }

                    case 0x38:
                        {
                            txt += "u";
                            break;
                        }

                    case 0x39:
                        {
                            txt += "v";
                            break;
                        }

                    case 0x3A:
                        {
                            txt += "w";
                            break;
                        }

                    case 0x3B:
                        {
                            txt += "x";
                            break;
                        }

                    case 0x3C:
                        {
                            txt += "y";
                            break;
                        }

                    case 0x3D:
                        {
                            txt += "z";
                            break;
                        }

                    case 0x3E:
                        {
                            txt += "'";
                            break;
                        }

                    case 0x3F:
                        {
                            txt += ".";
                            break;
                        }

                    case 0x50:
                        {
                            txt += "↑"; // [Up]
                            break;
                        }

                    case 0x51:
                        {
                            txt += "↓"; // [Down]
                            break;
                        }

                    case 0x52:
                        {
                            txt += "←"; // [Left]
                            break;
                        }

                    case 0x53:
                        {
                            txt += "→"; // [Right]
                            break;
                        }

                    case 0x54:
                        {
                            txt += "[A]";
                            break;
                        }

                    case 0x55:
                        {
                            txt += "[B]";
                            break;
                        }

                    case 0x56:
                        {
                            txt += "[C]";
                            break;
                        }

                    case 0x57:
                        {
                            txt += "[Z]";
                            break;
                        }

                    case 0x58:
                        {
                            txt += "[R]";
                            break;
                        }

                    case 0x6F:
                        {
                            txt += ",";
                            break;
                        }

                    case 0xD0:
                        {
                            txt += "/";
                            break;
                        }

                    case 0xD1:
                        {
                            txt += "the";
                            break;
                        }

                    case 0xD2:
                        {
                            txt += "you";
                            break;
                        }

                    case 0x9E:
                        {
                            txt += " ";
                            break;
                        }

                    case 0x9F:
                        {
                            txt += "-";
                            break;
                        }

                    case 0xE0:
                        {
                            txt += "{starsleft}";
                            break;
                        }

                    case 0xE1:
                        {
                            txt += "(";
                            break;
                        }

                    case 0xE2:
                        {
                            txt += ")(";
                            break;
                        }

                    case 0xE3:
                        {
                            txt += ")";
                            break;
                        }

                    case 0xE4:
                        {
                            txt += "+";
                            break;
                        }

                    case 0xE5:
                        {
                            txt += "&";
                            break;
                        }

                    case 0xE6:
                        {
                            txt += ":";
                            break;
                        }

                    case 0xF2:
                        {
                            txt += "!";
                            break;
                        }

                    case 0xF4:
                        {
                            txt += "?";
                            break;
                        }

                    case 0xF5:
                        {
                            if (AutoDetectStartEndQuotationMarks)
                                txt += "\"";
                            else
                                txt += "{sqm}";
                            break;
                        }

                    case 0xF6:
                        {
                            if (AutoDetectStartEndQuotationMarks)
                                txt += "\"";
                            else
                                txt += "{eqm}";
                            break;
                        }

                    case 0xF7:
                        {
                            txt += "~";
                            break;
                        }

                    case 0xF9:
                        {
                            txt += "$";
                            break;
                        }

                    case 0xFA:
                        {
                            txt += "★"; // [star]
                            break;
                        }

                    case 0xFB:
                        {
                            txt += "[x]";
                            break;
                        }

                    case 0xFC:
                        {
                            txt += "•"; // [•]
                            break;
                        }

                    case 0xFD:
                        {
                            txt += "☆"; // [emptystar]
                            break;
                        }

                    case 0xFE:
                        {
                            txt += "\n";
                            break;
                        }

                    case 0xFF:
                        {
                            break;
                        }
                }
            }

            return txt;
        }
    }
}
