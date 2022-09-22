using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoLibrary.AudioBook;
using DemoLibrary.GeneralInterface;

namespace DemoLibrary
{
    public  interface IBorrowableAudioBook: IAudioBook,IBorrowable
    {
    }
}
