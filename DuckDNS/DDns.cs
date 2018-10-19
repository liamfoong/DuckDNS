using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;

namespace DuckDNS
{
    class DDns
    {
        private const string FILENAME = "DuckDNS.cfg";
        public string Domain;
        public string Token;
        public string Interval;
        public string Smtp;
        public string Port;
        public bool IsEnableSsl;
        public string Username;
        public string Password;
        public string EmailFrom;
        public string EmailTo;
        public bool IsIpUpdateNotify;
        public bool SavePassword { get; set; }
        public string MaxEmail;

        private WebClient cli = new WebClient();

        public bool Update(out string result, out Form1.DuckDnsResponse res)
        {
            res = null;
            string url = $"https://www.duckdns.org/update?domains={Domain}&token={Token}&verbose=true";
            string data = cli.DownloadString(url);
            result = data;

            if (data.PadRight(2).Substring(0,2) == "OK")
            {
                var dataList = data.Split(new string[] { "\n" }, StringSplitOptions.None);
                res = new Form1.DuckDnsResponse();
                res.ResponseStatus = dataList[0];
                res.Ip = dataList[1];
                res.UpdateStatus = dataList[3]; // array[2] is blank line
            }

            return data.PadRight(2).Substring(0, 2) == "OK";
        }

        public void Load()
        {
            string[] data = null;
            if (File.Exists(FILENAME)) try
                {
                    data = File.ReadAllLines(FILENAME);
                }
                catch { }; //Silent read errors
            Domain = data != null && data.Length > 0 ? data[0] : "";
            Token = data != null && data.Length > 1 ? CharSwitch(data[1]) : "";
            Interval = data != null && data.Length > 2 ? data[2] : "30m";
            Smtp = data != null && data.Length > 3 ? data[3] : "";
            Port = data != null && data.Length > 4 ? data[4] : "";
            IsEnableSsl = data != null && data.Length > 5 && Convert.ToBoolean(data[5]);
            Username = data != null && data.Length > 6 ? data[6] : "";
            Password = data != null && data.Length > 7 ? data[7] : "";
            EmailFrom = data != null && data.Length > 8 ? data[8] : "";
            EmailTo = data != null && data.Length > 9 ? data[9] : "";
            IsIpUpdateNotify = data != null && data.Length > 10 && Convert.ToBoolean(data[10]);
            SavePassword = data != null && data.Length > 11 && Convert.ToBoolean(data[11]);
            MaxEmail = data != null && data.Length > 12 ? data[12] : "";
        }

        public void Save()
        {
            var password = (SavePassword)? Password: "";
            string[] data =
            {
                Domain, CharSwitch(Token), Interval, Smtp,Port,IsEnableSsl.ToString(),Username,password,
                EmailFrom,EmailTo,IsIpUpdateNotify.ToString(), SavePassword.ToString(), MaxEmail
            };
            try
            {
                File.WriteAllLines(FILENAME, data);
            }
            catch { }; //Silent write errors (for read-only fs)
        }

        private string CharSwitch(string str){ // Super basic, but more than nothing
            string a = "abcdef0123456789";
            string b = "f9031ace7d86524b";
            StringBuilder sb = new StringBuilder(str);
            for (int i = 0; i < sb.Length; i++)
            {
                int chi = a.IndexOf(sb[i]);
                if (chi >= 0)
                    sb[i] = b[chi];
            }
            return sb.ToString();
        }
    }
}
