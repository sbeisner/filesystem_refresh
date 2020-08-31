using System.Collections.Generic;

namespace filesystem_refresh.Data {

    public interface FileService {

        List<File> getAllFiles();

        File getFileById(int id);

        void updateFile(int id, File file);

        
    }
}