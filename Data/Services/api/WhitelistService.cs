using System.Collections.Generic;

namespace filesystem_refresh.Data {

    public interface WhitelistService {

        void addWhitelist(Whitelist whitelist);
        Whitelist GetWhitelist();

        List<string> getPaths();

        void updatePaths(List<string> newPaths);
    }
}