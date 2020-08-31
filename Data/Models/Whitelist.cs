using System;
using System.Collections.Generic;

namespace filesystem_refresh.Data {

    public class Whitelist {

        public int id { get; set; }

        public string username { get; set; }

        public int length { get; set; }

        public DateTime lastEdited { get; set; }

        public List<string> paths { get; set; }
    }
}