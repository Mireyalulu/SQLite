using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace prac7
{
   public interface ISQLite
    {
        string GetLocalFilePath(string Filename);
    }
}
