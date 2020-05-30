using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlockChain
{
    public class Blockchain
    {
        private int previoushash = 0;
        private int currenthash;
        private List<string> BLOK = new List<string>();
        public void createBlog(string veri)
        {
            List<string> blok = new List<string>();
            blok.Add(getpreHash().ToString());
            blok.Add(veri);
            getHash();
            previoushash = currenthash;
            BLOK = blok;
        }
        public List<string> GetBlock()
        {
            return BLOK;
        }

        public int getHash()
        { 
                currenthash = BLOK.GetHashCode();
                return currenthash; 
        }
        public int getpreHash()
        {
            return previoushash;
        }
    }
}
