using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResumeCraft_API.Models.Interfaces
{
    public interface IIdentifiable<T>
    {
        public T Id { get; set; }
    }
}
