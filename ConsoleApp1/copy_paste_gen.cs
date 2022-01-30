using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp1
{
    public class Program
    {
        static void Main(string[] args)
        {
            //how many times it should run
            int counter = 1;
            //these can be increased as the script increased
            // first 4 can use decimals where as the last 2 have a higher max
            double int1 = 0;
            double int2 = 0;
            double int3 = 0;
            double int4 = 0;
            int int6 = 0;
            int int5 = 0;
            //these can't, can't remeber why i added it
            string string1 = "federations3.2100";
            string string2 = "";
            // this adds a new line and a tab stop for different indentations. useful if you want it to conain comments
            string tab1 = Environment.NewLine + "    ";
            string tab2 = Environment.NewLine + "        ";
            string tab3 = Environment.NewLine + "            ";
            string tab4 = Environment.NewLine + "                ";
            using (System.IO.StreamWriter file = 
                new System.IO.StreamWriter(@"C:\Users\dan20\Documents\stellaris_copy.txt", true)) {
                while ( counter >= 1 ) {
                    // the text to be wirriten + the variables use tab1 etc for tab spaces    
                    file.WriteLine("" +
                        "on_arch_site_finished = {" +
                        tab1 + "events = {" +
                            tab2 + "achievement." + int1 + " # Archaeologist achievement" +
                        tab1 + "} " +
                             tab1 + "random_events = { " +
                                tab1 + "90 = 0 " +
                                tab2 + "10 = " + string1 + " #Joint Operation: Genius Caeli " +
                            tab1 + "} " + Environment.NewLine +
                        "}" 
                    );
                    counter--;
                    // this is what you change after each run + examples
                    int1++;
                    int2 += 1;
                    int3 += 2;
                    int3 += int2;
                    int4 *= 1.5;
                    int5++;
                    int6++;
                }
            }
        }
    }
}
