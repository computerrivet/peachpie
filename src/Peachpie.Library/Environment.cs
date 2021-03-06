﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pchp.Library
{
    /// <summary>
    /// Environment constants and functions.
    /// </summary>
    public static class Environment
    {
        public const int PHP_MAJOR_VERSION = 7;
        public const int PHP_MINOR_VERSION = 0;
        public const int PHP_RELEASE_VERSION = 0;
        public const int PHP_VERSION_ID = PHP_MAJOR_VERSION * 10000 + PHP_MINOR_VERSION * 100 + PHP_RELEASE_VERSION;
        public static readonly string PHP_VERSION = PHP_MAJOR_VERSION + "." + PHP_MINOR_VERSION + "." + PHP_RELEASE_VERSION + PHP_EXTRA_VERSION;

        public const string PHP_EXTRA_VERSION = "-peach";
        public static readonly string PHP_OS = "WinNT"; //Environment.OSVersion.Platform == PlatformID.Win32NT? "WINNT" : "WIN32", false); // TODO: GENERICS (Unix)

        //_constants.Add("PHP_SAPI", (System.Web.HttpContext.Current == null) ? "cli" : "isapi", false);
        //_constants.Add("DIRECTORY_SEPARATOR", FullPath.DirectorySeparatorString, false);
        //_constants.Add("PATH_SEPARATOR", Path.PathSeparator.ToString(), false);

        public const long PHP_INT_SIZE = sizeof(long);
        public const long PHP_INT_MIN = long.MinValue;
        public const long PHP_INT_MAX = long.MaxValue;

        public const object NULL = null;
        public const bool TRUE = true;
        public const bool FALSE = false;

        public static readonly string PHP_EOL = System.Environment.NewLine;
    }
}
