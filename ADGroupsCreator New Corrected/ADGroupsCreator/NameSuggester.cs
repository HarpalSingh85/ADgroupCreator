using System;
using System.Text.RegularExpressions;

namespace ADGroupsCreator
{
    internal class NameSuggester
    {
        public string builder { get; private set; }
        public string Suffix { get; private set; }
        string _start = "DS_DATA";
        Regex rgx = new Regex("[^a-zA-Z0-9_]");
        Regex rgxhypen = new Regex("_[_+]");

        internal NameSuggester(string _share,string _suffix)
        {
            string[] _words = _share.Split('\\');
                        
            if (_suffix.Equals("Read Only"))
            {
                Suffix = "_R";
            }
            if(_suffix.Equals("Modify"))
            {
                Suffix = "_M";
            }

            if(_share.Length <= 30 && _share.Length > 15)
            {
                string _builder = _start +'_'+ _words[2].Substring(4) + '_' + _words[ _words.Length - 1] + Suffix;
                builder = _builder.ToUpper().Replace(' ','_');
                builder = rgx.Replace(builder, "");
                builder = rgxhypen.Replace(builder, "_");

            }
            else if(_share.Length > 30 && _share.Length <= 50)
            {
                string _builder = _start + '_' + _words[2].Substring(4) + '_' + _words[_words.Length - 2] + '_' + _words[_words.Length - 1] + Suffix;
                builder = _builder.ToUpper().Replace(' ', '_');
                builder = rgx.Replace(builder, "");
                builder = rgxhypen.Replace(builder, "_");
            }
            else
            {
                string _builder = _start + '_' + _words[2].Substring(4) + '_' + _words[4] + '_' + _words[_words.Length - 2] + '_' + _words[_words.Length - 1] + Suffix;
                builder = _builder.ToUpper().Replace(' ', '_');
                builder = rgx.Replace(builder, "");
                builder = rgxhypen.Replace(builder, "_");
            }
            
        }

        internal string suggestName()
        {
            try
            {

                if (builder.Length > 58)
                {

                    string[] _wordlist = builder.Split('_');
                    int _val;

                    string _builder = _wordlist[0] + '_' + _wordlist[1] + '_' + _wordlist[2] + '_' + _wordlist[3] + '_' + _wordlist[(_wordlist.Length - 3)] + '_' + _wordlist[(_wordlist.Length - 2)] + '_' + _wordlist[(_wordlist.Length - 1)];
                    if (_builder.Length < 45)
                    {
                        if ((_wordlist.Length % 2) == 0)
                        {
                            _val = (int)Math.Round(((_wordlist.Length / 2) - 1.0), 0);
                        }
                        else
                        {
                            _val = (int)Math.Round(((_wordlist.Length / 2.0)), 0);
                        }
                        _builder = _wordlist[0] + '_' + _wordlist[1] + '_' + _wordlist[2] + '_' + _wordlist[3] + '_' + _wordlist[_val] + '_' + _wordlist[(_wordlist.Length - 2)] + '_' + _wordlist[(_wordlist.Length - 1)];
                    }

                    builder = _builder.ToUpper().Replace(' ', '_');
                    builder = rgx.Replace(builder, "");
                    builder = rgxhypen.Replace(builder,"_");


                }

                return builder;
            }

            catch(Exception Ex)
            {
                throw Ex;
            }
        }
       
    }
}
