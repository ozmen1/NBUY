using BlogApp.Shared.Utilities.Result.Complex_Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.Shared.Entities.Abstract
{
    public class DtoGetBase 
    {
        public virtual ResultStatus ResultStatus { get; set; }
    }
}
