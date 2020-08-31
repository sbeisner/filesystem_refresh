using System;
using System.Collections.Generic;

namespace filesystem_refresh.Data {
    public static class wl_data {

        public static Whitelist whitelist => init_whitelist;
        
        static Whitelist init_whitelist = new Whitelist() {
            id = 0,
            username = Environment.UserName,
            length = 9,
            lastEdited = new DateTime(2020, 8, 31),
            paths = new List<string> {
                "C:\\Users\\Public\\Documents\\Intuit\\Quickbooks",
                "C:\\Users\\" + init_whitelist.username + "\\Desktop",
                "C:\\Users\\" + init_whitelist.username + "\\Documents",
                "C:\\Users\\" + init_whitelist.username + "\\Pictures",
                "C:\\Users\\" + init_whitelist.username + "\\Music",
                "C:\\Users\\" + init_whitelist.username + "\\Videos",
                "C:\\Users\\" + init_whitelist.username + "\\AppData\\Local\\Google\\Chrome\\User Data\\Default\\Bookmarks",
                "C:\\Users\\" + init_whitelist.username + "\\AppData\\Roaming\\Microsoft\\Signatures",
                "C:\\Users\\" + init_whitelist.username + "\\AppData\\Roaming\\Microsoft\\UProof"
            }
        };
    }
}