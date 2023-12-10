using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneralLink.Kernel.Builder
{
    internal class BuildeParameter
    {
        public string IP { get; set; }

        public int Port { get; set; }

        public class Builder 
        {
            private readonly BuildeParameter _context = new BuildeParameter();

            public Builder SetIP(string ip)
            {
                _context.IP = string.IsNullOrWhiteSpace(ip) ? throw new ArgumentNullException($"{nameof(ip)} Cannot be empty") : ip;
                return this;
            }

            public Builder SetPort(int port)
            {
                _context.Port = port;
                return this;
            }

            public BuildeParameter Build()
            {
                return _context;
            }
        }
    }
}
