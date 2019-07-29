using System;
using System.Collections.Generic;

namespace DNAcode
{
    public enum DNACode { A, G, T, C }
    class Program
    { 
        static void Main(string[] args)
        {
            string line;
            DNACode code;

            Console.Write("Please type DNA sequence (ex: 0102012):");
            while ((line = Console.ReadLine()) != null)
            {
                if (line == "exit")
                    break;
            
                foreach(char c in line)
                {
                    code = chr2dnacode(c);
                    Console.Write( dnacode2symbol(code) );
                }

                Console.WriteLine("");

                int i;
                for(i = 0; i< line.Length - 1; i++)
                {
                    char c = line[i];
                    code = chr2dnacode(c);
                    Console.Write(dnacode2aminobase(code) + "-");
                }

                if (line.Length > 0)
                    Console.Write(dnacode2aminobase(chr2dnacode(line[line.Length-1])));

            
                Console.WriteLine("");
                Console.WriteLine("");

                Console.Write("Please type DNA sequence (ex: 0102012):");
                //Console.WriteLine(line);
            }

        }

        static public DNACode chr2dnacode(char c)
        {
            switch (c)
            {
                case '0': return DNACode.A;
                case '1': return DNACode.G;
                case '2': return DNACode.T;
                case '3': return DNACode.C;
                default: return DNACode.A; // let it be 'A' for the error
            }
        }


        static public string dnacode2symbol(DNACode code)
        {
            switch (code)
            {
                case DNACode.A: return "A";
                case DNACode.G: return "G";
                case DNACode.T: return "T";
                //case DNACode.C: return "C";
                default: return "C";
            }            
        }

        static public string dnacode2aminobase(DNACode code)
        {
            switch (code)
            {
                case DNACode.A: return "Adenine";
                case DNACode.G: return "Guanine";
                case DNACode.T: return "Thymine";
                //case DNACode.C: return "Cytosine";
                default: return "Cytosine";
            }
        }
    }
}
