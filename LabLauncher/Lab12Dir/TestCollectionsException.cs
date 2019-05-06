using System;

namespace LabLauncher.Lab12Dir
{
    class TestCollectionsException : ApplicationException
    {
        public TestCollectionsException() : base() { }
        public TestCollectionsException(string s) : base(s) { }
    }
}
