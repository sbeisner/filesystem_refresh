using System;

namespace filesystem_refresh.Data {
    
    public class File {
        public int id { get; set; }
        public string name { get; set; }
        public string type { get; set; }

        public string dir_path { get; set; }
        public DateTime timeCreated { get; set; }

        public DateTime lastEdited { get; set; }
    }
}