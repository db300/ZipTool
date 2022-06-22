using System.IO;

namespace iHawkZipStdLibrary
{
    public class MyNameTransform : ICSharpCode.SharpZipLib.Core.INameTransform
    {
        #region INameTransform 成员

        public string TransformDirectory(string name)
        {
            return null;
        }

        public string TransformFile(string name)
        {
            return Path.GetFileName(name);
        }

        #endregion
    }
}