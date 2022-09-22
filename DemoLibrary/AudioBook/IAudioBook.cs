using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoLibrary.GeneralInterface;

namespace DemoLibrary.AudioBook
{
    public interface IAudioBook : ILibraryItem
    {
        public int RuntimeInMinutes { get; set; }

    }
}
