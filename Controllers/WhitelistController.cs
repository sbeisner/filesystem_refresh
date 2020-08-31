using filesystem_refresh.Data;
using Microsoft.AspNetCore.Mvc;

namespace filesystem_refresh.Controllers {

    [Route("api/[controller]")]
    public class FilesController: Controller {
       
        private WhitelistService _service;
        public FilesController(WhitelistService service)
        {
            _service = service;
        }
    }
}