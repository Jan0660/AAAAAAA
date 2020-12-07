using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AAAAAAA
{
    class Program
    {
        static void Main(string[] args)
        {
            //foreach (char ch in "abcdefghijklmnopqrstuvwxyz".ToUpper())
            //{
            //    yeet2(ch.ToString());
            //}
            string output = "";
            int i = -1;
            main:;
            i++;
            //main:;
            char curchar;
            try
            {
                curchar = "Hello world!".ToCharArray()[i];
            }
            catch(Exception exc)
            {
                goto finish;
            }
            if (output == "Hello world!")
            {
                goto finish;
            }
            #region else if
            else if (curchar.ToString() == "a")
            {
                goto add_a;
            }
            else if (curchar.ToString() == "b")
            {
                goto add_b;
            }
            else if (curchar.ToString() == "c")
            {
                goto add_c;
            }
            else if (curchar.ToString() == "d")
            {
                goto add_d;
            }
            else if (curchar.ToString() == "e")
            {
                goto add_e;
            }
            else if (curchar.ToString() == "f")
            {
                goto add_f;
            }
            else if (curchar.ToString() == "g")
            {
                goto add_g;
            }
            else if (curchar.ToString() == "h")
            {
                goto add_h;
            }
            else if (curchar.ToString() == "i")
            {
                goto add_i;
            }
            else if (curchar.ToString() == "j")
            {
                goto add_j;
            }
            else if (curchar.ToString() == "k")
            {
                goto add_k;
            }
            else if (curchar.ToString() == "l")
            {
                goto add_l;
            }
            else if (curchar.ToString() == "m")
            {
                goto add_m;
            }
            else if (curchar.ToString() == "n")
            {
                goto add_n;
            }
            else if (curchar.ToString() == "o")
            {
                goto add_o;
            }
            else if (curchar.ToString() == "p")
            {
                goto add_p;
            }
            else if (curchar.ToString() == "q")
            {
                goto add_q;
            }
            else if (curchar.ToString() == "r")
            {
                goto add_r;
            }
            else if (curchar.ToString() == "s")
            {
                goto add_s;
            }
            else if (curchar.ToString() == "t")
            {
                goto add_t;
            }
            else if (curchar.ToString() == "u")
            {
                goto add_u;
            }
            else if (curchar.ToString() == "v")
            {
                goto add_v;
            }
            else if (curchar.ToString() == "w")
            {
                goto add_w;
            }
            else if (curchar.ToString() == "x")
            {
                goto add_x;
            }
            else if (curchar.ToString() == "y")
            {
                goto add_y;
            }
            else if (curchar.ToString() == "z")
            {
                goto add_z;
            }
            else if (curchar.ToString() == "A")
            {
                goto add_A;
            }
            else if (curchar.ToString() == "B")
            {
                goto add_B;
            }
            else if (curchar.ToString() == "C")
            {
                goto add_C;
            }
            else if (curchar.ToString() == "D")
            {
                goto add_D;
            }
            else if (curchar.ToString() == "E")
            {
                goto add_E;
            }
            else if (curchar.ToString() == "F")
            {
                goto add_F;
            }
            else if (curchar.ToString() == "G")
            {
                goto add_G;
            }
            else if (curchar.ToString() == "H")
            {
                goto add_H;
            }
            else if (curchar.ToString() == "I")
            {
                goto add_I;
            }
            else if (curchar.ToString() == "J")
            {
                goto add_J;
            }
            else if (curchar.ToString() == "K")
            {
                goto add_K;
            }
            else if (curchar.ToString() == "L")
            {
                goto add_L;
            }
            else if (curchar.ToString() == "M")
            {
                goto add_M;
            }
            else if (curchar.ToString() == "N")
            {
                goto add_N;
            }
            else if (curchar.ToString() == "O")
            {
                goto add_O;
            }
            else if (curchar.ToString() == "P")
            {
                goto add_P;
            }
            else if (curchar.ToString() == "Q")
            {
                goto add_Q;
            }
            else if (curchar.ToString() == "R")
            {
                goto add_R;
            }
            else if (curchar.ToString() == "S")
            {
                goto add_S;
            }
            else if (curchar.ToString() == "T")
            {
                goto add_T;
            }
            else if (curchar.ToString() == "U")
            {
                goto add_U;
            }
            else if (curchar.ToString() == "V")
            {
                goto add_V;
            }
            else if (curchar.ToString() == "W")
            {
                goto add_W;
            }
            else if (curchar.ToString() == "X")
            {
                goto add_X;
            }
            else if (curchar.ToString() == "Y")
            {
                goto add_Y;
            }
            else if (curchar.ToString() == "Z")
            {
                goto add_Z;
            }
            else if (curchar.ToString() == " ")
            {
                goto add_space;
            }
            else if (curchar.ToString() == "!")
            {
                goto add_exclamation;
            }
            #endregion

            add_space:;
            output += " ";
            goto main;
            add_exclamation:;
            output += "!";
            goto main;
            #region add letters
            add_a:;
            output += "a";
            goto main;
            add_b:;
            output += "b";
            goto main;
            add_c:;
            output += "c";
            goto main;
            add_d:;
            output += "d";
            goto main;
            add_e:;
            output += "e";
            goto main;
            add_f:;
            output += "f";
            goto main;
            add_g:;
            output += "g";
            goto main;
            add_h:;
            output += "h";
            goto main;
            add_i:;
            output += "i";
            goto main;
            add_j:;
            output += "j";
            goto main;
            add_k:;
            output += "k";
            goto main;
            add_l:;
            output += "l";
            goto main;
            add_m:;
            output += "m";
            goto main;
            add_n:;
            output += "n";
            goto main;
            add_o:;
            output += "o";
            goto main;
            add_p:;
            output += "p";
            goto main;
            add_q:;
            output += "q";
            goto main;
            add_r:;
            output += "r";
            goto main;
            add_s:;
            output += "s";
            goto main;
            add_t:;
            output += "t";
            goto main;
            add_u:;
            output += "u";
            goto main;
            add_v:;
            output += "v";
            goto main;
            add_w:;
            output += "w";
            goto main;
            add_x:;
            output += "x";
            goto main;
            add_y:;
            output += "y";
            goto main;
            add_z:;
            output += "z";
            goto main;
            add_A:;
            output += "A";
            goto main;
            add_B:;
            output += "B";
            goto main;
            add_C:;
            output += "C";
            goto main;
            add_D:;
            output += "D";
            goto main;
            add_E:;
            output += "E";
            goto main;
            add_F:;
            output += "F";
            goto main;
            add_G:;
            output += "G";
            goto main;
            add_H:;
            output += "H";
            goto main;
            add_I:;
            output += "I";
            goto main;
            add_J:;
            output += "J";
            goto main;
            add_K:;
            output += "K";
            goto main;
            add_L:;
            output += "L";
            goto main;
            add_M:;
            output += "M";
            goto main;
            add_N:;
            output += "N";
            goto main;
            add_O:;
            output += "O";
            goto main;
            add_P:;
            output += "P";
            goto main;
            add_Q:;
            output += "Q";
            goto main;
            add_R:;
            output += "R";
            goto main;
            add_S:;
            output += "S";
            goto main;
            add_T:;
            output += "T";
            goto main;
            add_U:;
            output += "U";
            goto main;
            add_V:;
            output += "V";
            goto main;
            add_W:;
            output += "W";
            goto main;
            add_X:;
            output += "X";
            goto main;
            add_Y:;
            output += "Y";
            goto main;
            add_Z:;
            output += "Z";
            goto main;
            #endregion
            finish:;
            Console.WriteLine(output);
            Console.Read();
        }

        // im not going to be writing those 400 lines of shit myself
        static void yeet(string ch)
        {
            Console.WriteLine("add_" + ch + ":;");
            Console.WriteLine("output += \"" + ch + "\";");
            Console.WriteLine("goto main;");
        }

        static void yeet2(string ch)
        {
            Console.WriteLine("else if (curchar.ToString() == \"" + ch + "\") {");
            Console.WriteLine("goto add_" + ch + ";");
            Console.WriteLine("}");
        }
    }
}
