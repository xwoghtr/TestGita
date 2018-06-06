using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    public class Generowanie3
    {
       public Dictionary<char, double> samo = new Dictionary<char, double>();
        public Dictionary<char, double> spol = new Dictionary<char, double>();
        public Generowanie3()
        {
            samo.Add('a', 0.0891);
            spol.Add('ą', 0.0099);
            spol.Add('b', 0.0147);
            spol.Add('c', 0.0396);
            spol.Add('ć', 0.004);
            spol.Add('d', 0.0325);
            samo.Add('e', 0.0766);
            spol.Add('ę', 0.0111);
            spol.Add('f', 0.003);
            spol.Add('g', 0.0142);
            spol.Add('h', 0.0108);
            samo.Add('i', 0.0821);
            spol.Add('j', 0.0228);
            spol.Add('k', 0.0351);
            spol.Add('l', 0.021);
            spol.Add('ł', 0.0182);
            spol.Add('m', 0.028);
            spol.Add('n', 0.0552);
            spol.Add('ń', 0.002);
            samo.Add('o', 0.0775);
            samo.Add('ó', 0.0085);
            spol.Add('p', 0.0313);
            spol.Add('q', 0.0014);
            spol.Add('r', 0.0469);
            spol.Add('s', 0.0432);
            spol.Add('ś', 0.0066);
            spol.Add('t', 0.0398);
            samo.Add('u', 0.025);
            spol.Add('v', 0.0004);
            spol.Add('w', 0.0465);
            spol.Add('x', 0.0002);
            samo.Add('y', 0.0376);
            spol.Add('z', 0.0564);
            spol.Add('ź', 0.0006);
            spol.Add('ż', 0.0083);
        }

        public char[] DozwoloneSamo(char c)
        {
            if (samo.ContainsKey(c))
                return samo.Select(a => a.Key).ToArray();
            return new char[0];
        }
        public char[] DozwoloneSpol(char c)
        {
            if (spol.ContainsKey(c))
                return spol.Select(a => a.Key).ToArray();
            else if (c == 'r')
                return new char[] { 'z' };
            else if (c == 's')
                return new char[] { 'z' };
            else if (c == 'c')
                return new char[] { 'z' };
            else if (c == 'c')
                return new char[] { 'h' };
            return new char[0];
        }
       
          

    public char GetRandomChar(char[] dozwoloneSamo, char[] dozwoloneSpol)
    {
        Dictionary<char, double> dozwolonelitery = new Dictionary<char, double>();
        foreach (var s in samo)
            if (dozwoloneSamo.Contains(s.Key))
                dozwolonelitery.Add(s.Key, s.Value);
        foreach (var s in spol)
            if (dozwoloneSpol.Contains(s.Key))
                    dozwolonelitery.Add(s.Key, s.Value);

        double sumprawdopodobienstw = dozwolonelitery.Sum(a => a.Value);
        Random rand = new Random();
        double randDouble = rand.NextDouble() * sumprawdopodobienstw;

        double start = 0;
        foreach (var s in dozwolonelitery)
        {
            start += s.Value;
            if (start >= randDouble)
                return s.Key;
        }
        return ';';

    }
}

} 
