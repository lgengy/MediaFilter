
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;

namespace MediaFilter
{
    public class FileInfo_FileName_Sort : IComparer<FileInfo>
    {
        [DllImport("Shlwapi.dll", CharSet = CharSet.Unicode)]
        private static extern int StrCmpLogicalW(string param1, string param2);

        //前后文件名进行比较。
        public int Compare(FileInfo name1, FileInfo name2)
        {
            if (null == name1 && null == name2)
            {
                return 0;
            }
            if (null == name1)
            {
                return -1;
            }
            if (null == name2)
            {
                return 1;
            }
            return StrCmpLogicalW(name1.ToString(), name2.ToString());
        }
    }

    public class String_FileName_Sort : IComparer<string>
    {
        [DllImport("Shlwapi.dll", CharSet = CharSet.Unicode)]
        private static extern int StrCmpLogicalW(string param1, string param2);

        //前后文件名进行比较。
        public int Compare(string name1, string name2)
        {
            if (null == name1 && null == name2)
            {
                return 0;
            }
            if (null == name1)
            {
                return -1;
            }
            if (null == name2)
            {
                return 1;
            }
            return StrCmpLogicalW(name1, name2);
        }
    }
}
