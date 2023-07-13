using System;

namespace IQFeed.CSharpApiClient.Lookup.Chains.Equities
{
    public class EquityOptionMonthCode
    {
        public EquityOptionMonthCode(int month, OptionSide side)
        {
            Month = month;
            Side = side;
        }
        // make static lookup table and decode / encode by inversion.

        public int Month { get; }
        public OptionSide Side { get; }

        public static EquityOptionMonthCode Decode(string code)
        {
            switch (code)
            {
                // Calls
                case "A":
                    return new EquityOptionMonthCode(1, OptionSide.Call);
                case "B":
                    return new EquityOptionMonthCode(2, OptionSide.Call);
                case "C":
                    return new EquityOptionMonthCode(3, OptionSide.Call);
                case "D":
                    return new EquityOptionMonthCode(4, OptionSide.Call);
                case "E":
                    return new EquityOptionMonthCode(5, OptionSide.Call);
                case "F":
                    return new EquityOptionMonthCode(6, OptionSide.Call);
                case "G":
                    return new EquityOptionMonthCode(7, OptionSide.Call);
                case "H":
                    return new EquityOptionMonthCode(8, OptionSide.Call);
                case "I":
                    return new EquityOptionMonthCode(9, OptionSide.Call);
                case "J":
                    return new EquityOptionMonthCode(10, OptionSide.Call);
                case "K":
                    return new EquityOptionMonthCode(11, OptionSide.Call);
                case "L":
                    return new EquityOptionMonthCode(12, OptionSide.Call);
                // Puts
                case "M":
                    return new EquityOptionMonthCode(1, OptionSide.Put);
                case "N":
                    return new EquityOptionMonthCode(2, OptionSide.Put);
                case "O":
                    return new EquityOptionMonthCode(3, OptionSide.Put);
                case "P":
                    return new EquityOptionMonthCode(4, OptionSide.Put);
                case "Q":
                    return new EquityOptionMonthCode(5, OptionSide.Put);
                case "R":
                    return new EquityOptionMonthCode(6, OptionSide.Put);
                case "S":
                    return new EquityOptionMonthCode(7, OptionSide.Put);
                case "T":
                    return new EquityOptionMonthCode(8, OptionSide.Put);
                case "U":
                    return new EquityOptionMonthCode(9, OptionSide.Put);
                case "V":
                    return new EquityOptionMonthCode(10, OptionSide.Put);
                case "W":
                    return new EquityOptionMonthCode(11, OptionSide.Put);
                case "X":
                    return new EquityOptionMonthCode(12, OptionSide.Put);
                default:
                    throw new Exception();
            }
        }

        public static string Encode(EquityOptionMonthCode code)
        {
            int month = code.Month;
            OptionSide side = code.Side;
            switch (month)
            {
                case 1:
                    return side == OptionSide.Call ? "A" : "M";
                case 2:
                    return side == OptionSide.Call ? "B" : "N";
                case 3:
                    return side == OptionSide.Call ? "C" : "O";
                case 4:
                    return side == OptionSide.Call ? "D" : "P";
                case 5:
                    return side == OptionSide.Call ? "E" : "Q";
                case 6:
                    return side == OptionSide.Call ? "F" : "R";
                case 7:
                    return side == OptionSide.Call ? "G" : "S";
                case 8:
                    return side == OptionSide.Call ? "H" : "T";
                case 9:
                    return side == OptionSide.Call ? "I" : "U";
                case 10:
                    return side == OptionSide.Call ? "J" : "V";
                case 11:
                    return side == OptionSide.Call ? "K" : "W";
                case 12:
                    return side == OptionSide.Call ? "L" : "X";
                default:
                    throw new Exception();
            }
        }
    }
}