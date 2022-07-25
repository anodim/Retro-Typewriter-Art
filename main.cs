using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;

class Solution
{
    public static void Main(string[] args)
    {
        string input = Console.ReadLine();

        List<Cmd> lstCmd = new List<Cmd>();
        foreach (string strCmd in input.Split(" "))
        {
            Cmd cmd = new Cmd();
            string strInt = "";

            if (strCmd.EndsWith("sp"))
            {
                strInt = strCmd.Substring(0, strCmd.Length - 2);
                cmd.Chara = ' ';
            }
            else if (strCmd.EndsWith("bS"))
            {
                strInt = strCmd.Substring(0, strCmd.Length - 2);
                cmd.Chara = '\\';
            }
            else if (strCmd.EndsWith("sQ"))
            {
                strInt = strCmd.Substring(0, strCmd.Length - 2);
                cmd.Chara = '\'';
            }
            else if (strCmd.EndsWith("nl"))
            {
                strInt = "1";
                cmd.Chara = '\n';
            }
            else
            {
                strInt = strCmd.Substring(0, strCmd.Length - 1);
                cmd.Chara = strCmd.Last();
            }

            cmd.Nb = int.Parse(strInt);

            lstCmd.Add(cmd);
        }

        foreach (Cmd cmd in lstCmd)
        {
            Console.Write(cmd.ToString());
        }
    }

    public class Cmd
    {
        public int Nb { get; set; }
        public char Chara { get; set; }

        public Cmd()
        {
            Nb = 0;
            Chara = '^';
        }

        public override string ToString()
        {
            string aReturn = "";
            for (int i = 0; i < Nb; ++i)
            {
                aReturn += Chara;
            }

            return aReturn;
        }
    }
}
