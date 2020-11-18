using System;
using System.Collections.Generic;
using System.Text;

namespace FreshFruit
{
    public interface BucketEventListener
    {
        void onFailed();
        void onSucceed();
    }
}