/* Copyright (C) 2008-2015 Peter Palotas, Jeffrey Jangli, Alexandr Normuradov
 *  
 *  Permission is hereby granted, free of charge, to any person obtaining a copy 
 *  of this software and associated documentation files (the "Software"), to deal 
 *  in the Software without restriction, including without limitation the rights 
 *  to use, copy, modify, merge, publish, distribute, sublicense, and/or sell 
 *  copies of the Software, and to permit persons to whom the Software is 
 *  furnished to do so, subject to the following conditions:
 *  
 *  The above copyright notice and this permission notice shall be included in 
 *  all copies or substantial portions of the Software.
 *  
 *  THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR 
 *  IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, 
 *  FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE 
 *  AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER 
 *  LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, 
 *  OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN 
 *  THE SOFTWARE. 
 */

using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.AccessControl;
using System.Security.Principal;
using SearchOption = System.IO.SearchOption;

namespace Alphaleonis.Win32.Filesystem
{
   /// <summary>Exposes static methods for creating, moving, and enumerating through directories and subdirectories.
   /// <para>This class cannot be inherited.</para>
   /// </summary>
   public static partial class Directory
   {
      #region .NET


      
      #region GetCreationTime

      #region .NET

      /// <summary>Gets the creation date and time of the specified directory.</summary>
      /// <param name="path">The directory for which to obtain creation date and time information.</param>
      /// <returns>A <see cref="System.DateTime"/> structure set to the creation date and time for the specified directory. This value is expressed in local time.</returns>
      [SecurityCritical]
      public static DateTime GetCreationTime(string path)
      {
         return File.GetCreationTimeInternal(null, path, false, PathFormat.Relative).ToLocalTime();
      }

      #endregion // .NET

      #region AlphaFS

      #region IsFullPath

      #region .NET

      /// <summary>[AlphaFS] Gets the creation date and time of the specified directory.</summary>
      /// <param name="path">The directory for which to obtain creation date and time information.</param>
      /// <param name="pathFormat">Indicates the format of the path parameter(s).</param>
      /// <returns>A <see cref="System.DateTime"/> structure set to the creation date and time for the specified directory. This value is expressed in local time.</returns>
      [SecurityCritical]
      public static DateTime GetCreationTime(string path, PathFormat pathFormat)
      {
         return File.GetCreationTimeInternal(null, path, false, pathFormat).ToLocalTime();
      }

      #endregion // .NET

      #endregion // IsFullPath

      #region Transacted

      #region IsFullPath

      /// <summary>[AlphaFS] Gets the creation date and time of the specified directory.</summary>
      /// <param name="transaction">The transaction.</param>
      /// <param name="path">The directory for which to obtain creation date and time information.</param>
      /// <param name="pathFormat">Indicates the format of the path parameter(s).</param>
      /// <returns>A <see cref="System.DateTime"/> structure set to the creation date and time for the specified directory. This value is expressed in local time.</returns>
      [SecurityCritical]
      public static DateTime GetCreationTime(KernelTransaction transaction, string path, PathFormat pathFormat)
      {
         return File.GetCreationTimeInternal(transaction, path, false, pathFormat).ToLocalTime();
      }

      #endregion // IsFullPath

      #region .NET

      /// <summary>[AlphaFS] Gets the creation date and time of the specified directory.</summary>
      /// <param name="transaction">The transaction.</param>
      /// <param name="path">The directory for which to obtain creation date and time information.</param>
      /// <returns>A <see cref="System.DateTime"/> structure set to the creation date and time for the specified directory. This value is expressed in local time.</returns>
      [SecurityCritical]
      public static DateTime GetCreationTime(KernelTransaction transaction, string path)
      {
         return File.GetCreationTimeInternal(transaction, path, false, PathFormat.Relative).ToLocalTime();
      }

      #endregion //.NET

      #endregion // Transacted

      #endregion // AlphaFS

      #endregion // GetCreationTime

      #region GetCreationTimeUtc

      #region .NET

      /// <summary>Gets the creation date and time, in Coordinated Universal Time (UTC) format, of the specified directory.</summary>
      /// <param name="path">The directory for which to obtain creation date and time information, in Coordinated Universal Time (UTC) format.</param>
      /// <returns>A <see cref="System.DateTime"/> structure set to the creation date and time for the specified directory. This value is expressed in UTC time.</returns>
      [SecurityCritical]
      public static DateTime GetCreationTimeUtc(string path)
      {
         return File.GetCreationTimeInternal(null, path, true, PathFormat.Relative);
      }

      #endregion // .NET

      #region AlphaFS

      #region IsFullPath

      #region .NET

      /// <summary>[AlphaFS] Gets the creation date and time, in Coordinated Universal Time (UTC) format, of the specified directory.</summary>
      /// <param name="path">The directory for which to obtain creation date and time information, in Coordinated Universal Time (UTC) format.</param>
      /// <param name="pathFormat">Indicates the format of the path parameter(s).</param>
      /// <returns>A <see cref="System.DateTime"/> structure set to the creation date and time for the specified directory. This value is expressed in UTC time.</returns>
      [SecurityCritical]
      public static DateTime GetCreationTimeUtc(string path, PathFormat pathFormat)
      {
         return File.GetCreationTimeInternal(null, path, true, pathFormat);
      }

      #endregion // .NET

      #endregion // IsFullPath

      #region Transacted

      #region IsFullPath

      #region .NET

      /// <summary>[AlphaFS] Gets the creation date and time, in Coordinated Universal Time (UTC) format, of the specified directory.</summary>
      /// <param name="transaction">The transaction.</param>
      /// <param name="path">The directory for which to obtain creation date and time information, in Coordinated Universal Time (UTC) format.</param>
      /// <param name="pathFormat">Indicates the format of the path parameter(s).</param>
      /// <returns>A <see cref="System.DateTime"/> structure set to the creation date and time for the specified directory. This value is expressed in UTC time.</returns>
      [SecurityCritical]
      public static DateTime GetCreationTimeUtc(KernelTransaction transaction, string path, PathFormat pathFormat)
      {
         return File.GetCreationTimeInternal(transaction, path, true, pathFormat);
      }

      #endregion // .NET

      #endregion // IsFullPath

      #region .NET

      /// <summary>[AlphaFS] Gets the creation date and time, in Coordinated Universal Time (UTC) format, of the specified directory.</summary>
      /// <param name="transaction">The transaction.</param>
      /// <param name="path">The directory for which to obtain creation date and time information, in Coordinated Universal Time (UTC) format.</param>
      /// <returns>A <see cref="System.DateTime"/> structure set to the creation date and time for the specified directory. This value is expressed in UTC time.</returns>
      [SecurityCritical]
      public static DateTime GetCreationTimeUtc(KernelTransaction transaction, string path)
      {
         return File.GetCreationTimeInternal(transaction, path, true, PathFormat.Relative);
      }

      #endregion //.NET

      #endregion // Transacted

      #endregion // AlphaFS

      #endregion // GetCreationTimeUtc

      #region GetCurrentDirectory (.NET)

      #region .NET

      /// <summary>Gets the current working directory of the application.</summary>
      /// <returns>The path of the current working directory without a backslash (\).</returns>
      [SuppressMessage("Microsoft.Design", "CA1024:UsePropertiesWhereAppropriate")]
      [SecurityCritical]
      public static string GetCurrentDirectory()
      {
         return System.IO.Directory.GetCurrentDirectory();
      }

      #endregion // .NET

      #endregion // GetCurrentDirectory (.NET)

      #region GetDirectories

      #region .NET

      /// <summary>Returns the names of subdirectories (including their paths) in the specified directory.
      /// </summary>
      /// <returns>An array of the full names (including paths) of subdirectories in the specified path, or an empty array if no directories are found.</returns>
      /// <remarks><para>The names returned by this method are prefixed with the directory information provided in path.</para>
      /// <para>
      /// The EnumerateDirectories and GetDirectories methods differ as follows: When you use EnumerateDirectories, you can start enumerating the collection of names
      /// before the whole collection is returned; when you use GetDirectories, you must wait for the whole array of names to be returned before you can access the array.
      /// Therefore, when you are working with many files and directories, EnumerateDirectories can be more efficient.
      /// </para>
      /// </remarks>
      /// <exception cref="ArgumentException">The path parameter contains invalid characters, is empty, or contains only white spaces.</exception>
      /// <exception cref="ArgumentNullException">path is <see langword="null"/>.</exception>      
      /// <param name="path">The directory to search.</param>
      [SecurityCritical]
      public static string[] GetDirectories(string path)
      {
         return EnumerateFileSystemEntryInfosInternal<string>(null, path, Path.WildcardStarMatchAll, DirectoryEnumerationOptions.Folders, PathFormat.Relative).ToArray();
      }

      /// <summary>Returns the names of subdirectories (including their paths) that match the specified search pattern in the specified directory.</summary>
      /// <returns>An array of the full names (including paths) of the subdirectories that match the search pattern in the specified directory, or an empty array if no directories are found.</returns>
      /// <remarks>
      /// The EnumerateDirectories and GetDirectories methods differ as follows: When you use EnumerateDirectories, you can start enumerating the collection of names
      /// before the whole collection is returned; when you use GetDirectories, you must wait for the whole array of names to be returned before you can access the array.
      /// Therefore, when you are working with many files and directories, EnumerateDirectories can be more efficient.
      /// </remarks>
      /// <exception cref="ArgumentException">The path parameter contains invalid characters, is empty, or contains only white spaces.</exception>
      /// <exception cref="ArgumentNullException">path is <see langword="null"/>.</exception>
      /// <param name="path">The directory to search.</param>
      /// <param name="searchPattern">
      /// <para>The search string to match against the names of directories in <paramref name="path"/>. This parameter can contain a</para>
      /// <para>combination of valid literal path and wildcard (<see cref="Path.WildcardStarMatchAll"/> and <see cref="Path.WildcardQuestion"/>)</para>
      /// <para>characters, but does not support regular expressions.</para>
      /// </param>
      [SecurityCritical]
      public static string[] GetDirectories(string path, string searchPattern)
      {
         return EnumerateFileSystemEntryInfosInternal<string>(null, path, searchPattern, DirectoryEnumerationOptions.Folders, PathFormat.Relative).ToArray();
      }

      /// <summary>Returns the names of the subdirectories (including their paths) that match the specified search pattern in the specified directory, and optionally searches subdirectories.</summary>
      /// <returns>An array of the full names (including paths) of the subdirectories that match the specified criteria, or an empty array if no directories are found.</returns>
      /// <remarks>
      /// The EnumerateDirectories and GetDirectories methods differ as follows: When you use EnumerateDirectories, you can start enumerating the collection of names
      /// before the whole collection is returned; when you use GetDirectories, you must wait for the whole array of names to be returned before you can access the array.
      /// Therefore, when you are working with many files and directories, EnumerateDirectories can be more efficient.
      /// </remarks>
      /// <exception cref="ArgumentException">The path parameter contains invalid characters, is empty, or contains only white spaces.</exception>
      /// <exception cref="ArgumentNullException">path is <see langword="null"/>.</exception>
      /// <param name="path">The directory to search.</param>
      /// <param name="searchPattern">
      /// <para>The search string to match against the names of directories in <paramref name="path"/>. This parameter can contain a</para>
      /// <para>combination of valid literal path and wildcard (<see cref="Path.WildcardStarMatchAll"/> and <see cref="Path.WildcardQuestion"/>)</para>
      /// <para>characters, but does not support regular expressions.</para>
      /// </param>
      /// <param name="searchOption">
      /// <para>One of the <see cref="SearchOption"/> enumeration values that specifies whether the <paramref name="searchOption"/></para>
      /// <para> should include only the current directory or should include all subdirectories.</para>
      /// </param>
      [SecurityCritical]
      public static string[] GetDirectories(string path, string searchPattern, SearchOption searchOption)
      {
         var directoryEnumerationOptions = DirectoryEnumerationOptions.Folders;

         if (searchOption == SearchOption.AllDirectories)
            directoryEnumerationOptions |= DirectoryEnumerationOptions.Recursive;

         return EnumerateFileSystemEntryInfosInternal<string>(null, path, searchPattern, directoryEnumerationOptions, PathFormat.Relative).ToArray();
      }

      #endregion // .NET

      #region AlphaFS

      #region Transacted

      #region .NET

      /// <summary>Returns the names of subdirectories (including their paths) in the specified directory.</summary>
      /// <returns>An array of the full names (including paths) of subdirectories in the specified path, or an empty array if no directories are found.</returns>
      /// <remarks>The names returned by this method are prefixed with the directory information provided in path.</remarks>
      /// <remarks>
      /// The EnumerateDirectories and GetDirectories methods differ as follows: When you use EnumerateDirectories, you can start enumerating the collection of names
      /// before the whole collection is returned; when you use GetDirectories, you must wait for the whole array of names to be returned before you can access the array.
      /// Therefore, when you are working with many files and directories, EnumerateDirectories can be more efficient.
      /// </remarks>
      /// <exception cref="ArgumentException">The path parameter contains invalid characters, is empty, or contains only white spaces.</exception>
      /// <exception cref="ArgumentNullException">path is <see langword="null"/>.</exception>
      /// <param name="transaction">The transaction.</param>
      /// <param name="path">The directory to search.</param>
      [SecurityCritical]
      public static string[] GetDirectories(KernelTransaction transaction, string path)
      {
         return EnumerateFileSystemEntryInfosInternal<string>(transaction, path, Path.WildcardStarMatchAll, DirectoryEnumerationOptions.Folders, PathFormat.Relative).ToArray();
      }

      /// <summary>Returns the names of subdirectories (including their paths) that match the specified search pattern in the specified directory.</summary>
      /// <returns>An array of the full names (including paths) of the subdirectories that match the search pattern in the specified directory, or an empty array if no directories are found.</returns>
      /// <remarks>
      /// The EnumerateDirectories and GetDirectories methods differ as follows: When you use EnumerateDirectories, you can start enumerating the collection of names
      /// before the whole collection is returned; when you use GetDirectories, you must wait for the whole array of names to be returned before you can access the array.
      /// Therefore, when you are working with many files and directories, EnumerateDirectories can be more efficient.
      /// </remarks>
      /// <exception cref="ArgumentException">The path parameter contains invalid characters, is empty, or contains only white spaces.</exception>
      /// <exception cref="ArgumentNullException">path is <see langword="null"/>.</exception>
      /// <param name="transaction">The transaction.</param>
      /// <param name="path">The directory to search.</param>
      /// <param name="searchPattern">
      /// <para>The search string to match against the names of directories in <paramref name="path"/>. This parameter can contain a</para>
      /// <para>combination of valid literal path and wildcard (<see cref="Path.WildcardStarMatchAll"/> and <see cref="Path.WildcardQuestion"/>)</para>
      /// <para>characters, but does not support regular expressions.</para>
      /// </param>
      [SecurityCritical]
      public static string[] GetDirectories(KernelTransaction transaction, string path, string searchPattern)
      {
         return EnumerateFileSystemEntryInfosInternal<string>(transaction, path, searchPattern, DirectoryEnumerationOptions.Folders, PathFormat.Relative).ToArray();
      }

      /// <summary>Returns the names of the subdirectories (including their paths) that match the specified search pattern in the specified directory, and optionally searches subdirectories.</summary>
      /// <returns>An array of the full names (including paths) of the subdirectories that match the specified criteria, or an empty array if no directories are found.</returns>
      /// <remarks>
      /// The EnumerateDirectories and GetDirectories methods differ as follows: When you use EnumerateDirectories, you can start enumerating the collection of names
      /// before the whole collection is returned; when you use GetDirectories, you must wait for the whole array of names to be returned before you can access the array.
      /// Therefore, when you are working with many files and directories, EnumerateDirectories can be more efficient.
      /// </remarks>
      /// <exception cref="ArgumentException">The path parameter contains invalid characters, is empty, or contains only white spaces.</exception>
      /// <exception cref="ArgumentNullException">path is <see langword="null"/>.</exception>
      /// <param name="transaction">The transaction.</param>
      /// <param name="path">The directory to search.</param>
      /// <param name="searchPattern">
      /// <para>The search string to match against the names of directories in <paramref name="path"/>. This parameter can contain a</para>
      /// <para>combination of valid literal path and wildcard (<see cref="Path.WildcardStarMatchAll"/> and <see cref="Path.WildcardQuestion"/>)</para>
      /// <para>characters, but does not support regular expressions.</para>
      /// </param>
      /// <param name="searchOption">
      /// <para>One of the <see cref="SearchOption"/> enumeration values that specifies whether the <paramref name="searchOption"/></para>
      /// <para> should include only the current directory or should include all subdirectories.</para>
      /// </param>
      [SecurityCritical]
      public static string[] GetDirectories(KernelTransaction transaction, string path, string searchPattern, SearchOption searchOption)
      {
         var directoryEnumerationOptions = DirectoryEnumerationOptions.Folders;

         if (searchOption == SearchOption.AllDirectories)
            directoryEnumerationOptions |= DirectoryEnumerationOptions.Recursive;

         return EnumerateFileSystemEntryInfosInternal<string>(transaction, path, searchPattern, directoryEnumerationOptions, PathFormat.Relative).ToArray();
      }

      #endregion // .NET

      #endregion // Transacted

      #endregion // AlphaFS

      #endregion // GetDirectories

      #region GetDirectoryRoot

      #region .NET

      /// <summary>Returns the volume information, root information, or both for the specified path.</summary>
      /// <param name="path">The path of a file or directory.</param>
      /// <returns>The volume information, root information, or both for the specified path, or <see langword="null"/> if <paramref name="path"/> path does not contain root directory information.</returns>
      [SecurityCritical]
      public static string GetDirectoryRoot(string path)
      {
         return GetDirectoryRootInternal(null, path, PathFormat.Relative);
      }

      #endregion // .NET

      #region AlphaFS

      #region IsFullPath

      #region .NET

      /// <summary>Returns the volume information, root information, or both for the specified path.</summary>
      /// <returns>The volume information, root information, or both for the specified path, or <see langword="null"/> if <paramref name="path"/> path does not contain root directory information.</returns>
      /// <param name="path">The path of a file or directory.</param>
      /// <param name="pathFormat">Indicates the format of the path parameter(s).</param>
      [SecurityCritical]
      public static string GetDirectoryRoot(string path, PathFormat pathFormat)
      {
         return GetDirectoryRootInternal(null, path, pathFormat);
      }

      #endregion // .NET

      #endregion // IsFullPath

      #region Transacted

      #region IsFullPath

      #region .NET

      /// <summary>Returns the volume information, root information, or both for the specified path.</summary>
      /// <returns>The volume information, root information, or both for the specified path, or <see langword="null"/> if <paramref name="path"/> path does not contain root directory information.</returns>
      /// <param name="transaction">The transaction.</param>
      /// <param name="path">The path of a file or directory.</param>
      /// <param name="pathFormat">Indicates the format of the path parameter(s).</param>
      [SecurityCritical]
      public static string GetDirectoryRoot(KernelTransaction transaction, string path, PathFormat pathFormat)
      {
         return GetDirectoryRootInternal(transaction, path, pathFormat);
      }

      #endregion // .NET

      #endregion // IsFullPath

      #region .NET

      /// <summary>[AlphaFS] Returns the volume information, root information, or both for the specified path.</summary>
      /// <param name="transaction">The transaction.</param>
      /// <param name="path">The path of a file or directory.</param>
      /// <returns>The volume information, root information, or both for the specified path, or <see langword="null"/> if <paramref name="path"/> path does not contain root directory information.</returns>
      [SecurityCritical]
      public static string GetDirectoryRoot(KernelTransaction transaction, string path)
      {
         return GetDirectoryRootInternal(transaction, path, PathFormat.Relative);
      }

      #endregion // .NET

      #endregion // Transacted

      #endregion // AlphaFS

      #endregion // GetDirectoryRoot

      #region GetFiles

      #region .NET

      /// <summary>Returns the names of files (including their paths) in the specified directory.</summary>
      /// <returns>An array of the full names (including paths) for the files in the specified directory, or an empty array if no files are found.</returns>
      /// <remarks>The returned file names are appended to the supplied <paramref name="path"/> parameter.</remarks>
      /// <remarks>The order of the returned file names is not guaranteed; use the Sort() method if a specific sort order is required. </remarks>
      /// <remarks>
      /// The EnumerateFiles and GetFiles methods differ as follows: When you use EnumerateFiles, you can start enumerating the collection of names
      /// before the whole collection is returned; when you use GetFiles, you must wait for the whole array of names to be returned before you can access the array.
      /// Therefore, when you are working with many files and directories, EnumerateFiles can be more efficient.
      /// </remarks>
      /// <exception cref="ArgumentException">The path parameter contains invalid characters, is empty, or contains only white spaces.</exception>
      /// <exception cref="ArgumentNullException">path is <see langword="null"/>.</exception>
      /// <param name="path">The directory to search.</param>
      [SecurityCritical]
      public static string[] GetFiles(string path)
      {
         return EnumerateFileSystemEntryInfosInternal<string>(null, path, Path.WildcardStarMatchAll, DirectoryEnumerationOptions.Files, PathFormat.Relative).ToArray();
      }

      /// <summary>Returns the names of files (including their paths) that match the specified search pattern in the specified directory.</summary>
      /// <returns>An array of the full names (including paths) for the files in the specified directory that match the specified search pattern, or an empty array if no files are found.</returns>
      /// <remarks>The returned file names are appended to the supplied <paramref name="path"/> parameter.</remarks>
      /// <remarks>The order of the returned file names is not guaranteed; use the Sort() method if a specific sort order is required. </remarks>
      /// <remarks>
      /// The EnumerateFiles and GetFiles methods differ as follows: When you use EnumerateFiles, you can start enumerating the collection of names
      /// before the whole collection is returned; when you use GetFiles, you must wait for the whole array of names to be returned before you can access the array.
      /// Therefore, when you are working with many files and directories, EnumerateFiles can be more efficient.
      /// </remarks>
      /// <exception cref="ArgumentException">The path parameter contains invalid characters, is empty, or contains only white spaces.</exception>
      /// <exception cref="ArgumentNullException">path is <see langword="null"/>.</exception>
      /// <param name="path">The directory to search.</param>
      /// <param name="searchPattern">
      /// <para>The search string to match against the names of directories in <paramref name="path"/>. This parameter can contain a</para>
      /// <para>combination of valid literal path and wildcard (<see cref="Path.WildcardStarMatchAll"/> and <see cref="Path.WildcardQuestion"/>)</para>
      /// <para>characters, but does not support regular expressions.</para>
      /// </param>
      [SecurityCritical]
      public static string[] GetFiles(string path, string searchPattern)
      {
         return EnumerateFileSystemEntryInfosInternal<string>(null, path, searchPattern, DirectoryEnumerationOptions.Files, PathFormat.Relative).ToArray();
      }

      /// <summary>Gets the names of the subdirectories (including their paths) that match the specified search pattern in the current directory, and optionally searches subdirectories.</summary>
      /// <returns>An array of the full names (including paths) for the files in the specified directory that match the specified search pattern and option, or an empty array if no files are found.</returns>
      /// <remarks>The returned file names are appended to the supplied <paramref name="path"/> parameter.</remarks>
      /// <remarks>The order of the returned file names is not guaranteed; use the Sort() method if a specific sort order is required. </remarks>
      /// <remarks>
      /// The EnumerateFiles and GetFiles methods differ as follows: When you use EnumerateFiles, you can start enumerating the collection of names
      /// before the whole collection is returned; when you use GetFiles, you must wait for the whole array of names to be returned before you can access the array.
      /// Therefore, when you are working with many files and directories, EnumerateFiles can be more efficient.
      /// </remarks>
      /// <exception cref="ArgumentException">The path parameter contains invalid characters, is empty, or contains only white spaces.</exception>
      /// <exception cref="ArgumentNullException">path is <see langword="null"/>.</exception>
      /// <param name="path">The directory to search.</param>
      /// <param name="searchPattern">
      /// <para>The search string to match against the names of directories in <paramref name="path"/>. This parameter can contain a</para>
      /// <para>combination of valid literal path and wildcard (<see cref="Path.WildcardStarMatchAll"/> and <see cref="Path.WildcardQuestion"/>)</para>
      /// <para>characters, but does not support regular expressions.</para>
      /// </param>
      /// <param name="searchOption">
      /// <para>One of the <see cref="SearchOption"/> enumeration values that specifies whether the <paramref name="searchOption"/></para>
      /// <para> should include only the current directory or should include all subdirectories.</para>
      /// </param>
      [SecurityCritical]
      public static string[] GetFiles(string path, string searchPattern, SearchOption searchOption)
      {
         var directoryEnumerationOptions = DirectoryEnumerationOptions.Files;

         if (searchOption == SearchOption.AllDirectories)
            directoryEnumerationOptions |= DirectoryEnumerationOptions.Recursive;

         return EnumerateFileSystemEntryInfosInternal<string>(null, path, searchPattern, directoryEnumerationOptions, PathFormat.Relative).ToArray();
      }

      #endregion // .NET

      #region AlphaFS

      #region Transacted

      #region .NET

      /// <summary>Returns the names of files (including their paths) in the specified directory.</summary>
      /// <returns>An array of the full names (including paths) for the files in the specified directory, or an empty array if no files are found.</returns>
      /// <remarks>The returned file names are appended to the supplied <paramref name="path"/> parameter.</remarks>
      /// <remarks>The order of the returned file names is not guaranteed; use the Sort() method if a specific sort order is required. </remarks>
      /// <remarks>
      /// The EnumerateFiles and GetFiles methods differ as follows: When you use EnumerateFiles, you can start enumerating the collection of names
      /// before the whole collection is returned; when you use GetFiles, you must wait for the whole array of names to be returned before you can access the array.
      /// Therefore, when you are working with many files and directories, EnumerateFiles can be more efficient.
      /// </remarks>
      /// <exception cref="ArgumentException">The path parameter contains invalid characters, is empty, or contains only white spaces.</exception>
      /// <exception cref="ArgumentNullException">path is <see langword="null"/>.</exception>
      /// <param name="transaction">The transaction.</param>
      /// <param name="path">The directory to search.</param>
      [SecurityCritical]
      public static string[] GetFiles(KernelTransaction transaction, string path)
      {
         return EnumerateFileSystemEntryInfosInternal<string>(transaction, path, Path.WildcardStarMatchAll, DirectoryEnumerationOptions.Files, PathFormat.Relative).ToArray();
      }

      /// <summary>Returns the names of files (including their paths) that match the specified search pattern in the specified directory.</summary>
      /// <returns>An array of the full names (including paths) for the files in the specified directory that match the specified search pattern, or an empty array if no files are found.</returns>
      /// <remarks>The returned file names are appended to the supplied <paramref name="path"/> parameter.</remarks>
      /// <remarks>The order of the returned file names is not guaranteed; use the Sort() method if a specific sort order is required. </remarks>
      /// <remarks>
      /// The EnumerateFiles and GetFiles methods differ as follows: When you use EnumerateFiles, you can start enumerating the collection of names
      /// before the whole collection is returned; when you use GetFiles, you must wait for the whole array of names to be returned before you can access the array.
      /// Therefore, when you are working with many files and directories, EnumerateFiles can be more efficient.
      /// </remarks>
      /// <exception cref="ArgumentException">The path parameter contains invalid characters, is empty, or contains only white spaces.</exception>
      /// <exception cref="ArgumentNullException">path is <see langword="null"/>.</exception>
      /// <param name="transaction">The transaction.</param>
      /// <param name="path">The directory to search.</param>
      /// <param name="searchPattern">
      /// <para>The search string to match against the names of directories in <paramref name="path"/>. This parameter can contain a</para>
      /// <para>combination of valid literal path and wildcard (<see cref="Path.WildcardStarMatchAll"/> and <see cref="Path.WildcardQuestion"/>)</para>
      /// <para>characters, but does not support regular expressions.</para>
      /// </param>
      [SecurityCritical]
      public static string[] GetFiles(KernelTransaction transaction, string path, string searchPattern)
      {
         return EnumerateFileSystemEntryInfosInternal<string>(transaction, path, searchPattern, DirectoryEnumerationOptions.Files, PathFormat.Relative).ToArray();
      }

      /// <summary>Gets the names of the subdirectories (including their paths) that match the specified search pattern in the current directory, and optionally searches subdirectories.</summary>
      /// <returns>An array of the full names (including paths) for the files in the specified directory that match the specified search pattern and option, or an empty array if no files are found.</returns>
      /// <remarks>The returned file names are appended to the supplied <paramref name="path"/> parameter.</remarks>
      /// <remarks>The order of the returned file names is not guaranteed; use the Sort() method if a specific sort order is required. </remarks>
      /// <remarks>
      /// The EnumerateFiles and GetFiles methods differ as follows: When you use EnumerateFiles, you can start enumerating the collection of names
      /// before the whole collection is returned; when you use GetFiles, you must wait for the whole array of names to be returned before you can access the array.
      /// Therefore, when you are working with many files and directories, EnumerateFiles can be more efficient.
      /// </remarks>
      /// <exception cref="ArgumentException">The path parameter contains invalid characters, is empty, or contains only white spaces.</exception>
      /// <exception cref="ArgumentNullException">path is <see langword="null"/>.</exception>
      /// <param name="transaction">The transaction.</param>
      /// <param name="path">The directory to search.</param>
      /// <param name="searchPattern">
      /// <para>The search string to match against the names of directories in <paramref name="path"/>. This parameter can contain a</para>
      /// <para>combination of valid literal path and wildcard (<see cref="Path.WildcardStarMatchAll"/> and <see cref="Path.WildcardQuestion"/>)</para>
      /// <para>characters, but does not support regular expressions.</para>
      /// </param>
      /// <param name="searchOption">
      /// <para>One of the <see cref="SearchOption"/> enumeration values that specifies whether the <paramref name="searchOption"/></para>
      /// <para> should include only the current directory or should include all subdirectories.</para>
      /// </param>
      [SecurityCritical]
      public static string[] GetFiles(KernelTransaction transaction, string path, string searchPattern, SearchOption searchOption)
      {
         var directoryEnumerationOptions = DirectoryEnumerationOptions.Files;

         if (searchOption == SearchOption.AllDirectories)
            directoryEnumerationOptions |= DirectoryEnumerationOptions.Recursive;

         return EnumerateFileSystemEntryInfosInternal<string>(transaction, path, searchPattern, directoryEnumerationOptions, PathFormat.Relative).ToArray();
      }

      #endregion // .NET

      #endregion // Transacted

      #endregion // AlphaFS

      #endregion // GetFiles

      #region GetFileSystemEntries

      #region .NET

      /// <summary>Returns the names of all files and subdirectories in the specified directory.</summary>
      /// <returns>An string[] array of the names of files and subdirectories in the specified directory.</returns>
      /// <remarks>
      /// The EnumerateFileSystemEntries and GetFileSystemEntries methods differ as follows: When you use EnumerateFileSystemEntries,
      /// you can start enumerating the collection of entries before the whole collection is returned; when you use GetFileSystemEntries,
      /// you must wait for the whole array of entries to be returned before you can access the array.
      /// Therefore, when you are working with many files and directories, EnumerateFiles can be more efficient.
      /// </remarks>
      /// <exception cref="ArgumentException">The path parameter contains invalid characters, is empty, or contains only white spaces.</exception>
      /// <exception cref="ArgumentNullException">path is <see langword="null"/>.</exception>
      /// <param name="path">The directory for which file and subdirectory names are returned.</param>
      [SecurityCritical]
      public static string[] GetFileSystemEntries(string path)
      {
         return EnumerateFileSystemEntryInfosInternal<string>(null, path, Path.WildcardStarMatchAll, DirectoryEnumerationOptions.FilesAndFolders, PathFormat.Relative).ToArray();
      }

      /// <summary>Returns an array of file system entries that match the specified search criteria.</summary>
      /// <returns>An string[] array of file system entries that match the specified search criteria.</returns>
      /// <remarks>
      /// The EnumerateFileSystemEntries and GetFileSystemEntries methods differ as follows: When you use EnumerateFileSystemEntries,
      /// you can start enumerating the collection of entries before the whole collection is returned; when you use GetFileSystemEntries,
      /// you must wait for the whole array of entries to be returned before you can access the array.
      /// Therefore, when you are working with many files and directories, EnumerateFiles can be more efficient.
      /// </remarks>
      /// <exception cref="ArgumentException">The path parameter contains invalid characters, is empty, or contains only white spaces.</exception>
      /// <exception cref="ArgumentNullException">path is <see langword="null"/>.</exception>
      /// <param name="path">The path to be searched.</param>
      /// <param name="searchPattern">
      /// <para>The search string to match against the names of directories in <paramref name="path"/>. This parameter can contain a</para>
      /// <para>combination of valid literal path and wildcard (<see cref="Path.WildcardStarMatchAll"/> and <see cref="Path.WildcardQuestion"/>)</para>
      /// <para>characters, but does not support regular expressions.</para>
      /// </param>
      [SecurityCritical]
      public static string[] GetFileSystemEntries(string path, string searchPattern)
      {
         return EnumerateFileSystemEntryInfosInternal<string>(null, path, searchPattern, DirectoryEnumerationOptions.FilesAndFolders, PathFormat.Relative).ToArray();
      }

      /// <summary>Gets an array of all the file names and directory names that match a <paramref name="searchPattern"/> in a specified path, and optionally searches subdirectories.</summary>
      /// <returns>An string[] array of file system entries that match the specified search criteria.</returns>
      /// <remarks>
      /// The EnumerateFileSystemEntries and GetFileSystemEntries methods differ as follows: When you use EnumerateFileSystemEntries,
      /// you can start enumerating the collection of entries before the whole collection is returned; when you use GetFileSystemEntries,
      /// you must wait for the whole array of entries to be returned before you can access the array.
      /// Therefore, when you are working with many files and directories, EnumerateFiles can be more efficient.
      /// </remarks>
      /// <exception cref="ArgumentException">The path parameter contains invalid characters, is empty, or contains only white spaces.</exception>
      /// <exception cref="ArgumentNullException">path is <see langword="null"/>.</exception>
      /// <param name="path">The directory to search.</param>
      /// <param name="searchPattern">
      /// <para>The search string to match against the names of directories in <paramref name="path"/>. This parameter can contain a</para>
      /// <para>combination of valid literal path and wildcard (<see cref="Path.WildcardStarMatchAll"/> and <see cref="Path.WildcardQuestion"/>)</para>
      /// <para>characters, but does not support regular expressions.</para>
      /// </param>
      /// <param name="searchOption">
      /// <para>One of the <see cref="SearchOption"/> enumeration values that specifies whether the <paramref name="searchOption"/></para>
      /// <para> should include only the current directory or should include all subdirectories.</para>
      /// </param>
      [SecurityCritical]
      public static string[] GetFileSystemEntries(string path, string searchPattern, SearchOption searchOption)
      {
         var directoryEnumerationOptions = DirectoryEnumerationOptions.FilesAndFolders;

         if (searchOption == SearchOption.AllDirectories)
            directoryEnumerationOptions |= DirectoryEnumerationOptions.Recursive;

         return EnumerateFileSystemEntryInfosInternal<string>(null, path, searchPattern, directoryEnumerationOptions, PathFormat.Relative).ToArray();
      }

      #endregion // .NET

      #region AlphaFS

      #region Transacted

      #region .NET

      /// <summary>Returns the names of all files and subdirectories in the specified directory.</summary>
      /// <returns>An string[] array of the names of files and subdirectories in the specified directory.</returns>
      /// <remarks>
      /// The EnumerateFileSystemEntries and GetFileSystemEntries methods differ as follows: When you use EnumerateFileSystemEntries,
      /// you can start enumerating the collection of entries before the whole collection is returned; when you use GetFileSystemEntries,
      /// you must wait for the whole array of entries to be returned before you can access the array.
      /// Therefore, when you are working with many files and directories, EnumerateFiles can be more efficient.
      /// </remarks>
      /// <exception cref="ArgumentException">The path parameter contains invalid characters, is empty, or contains only white spaces.</exception>
      /// <exception cref="ArgumentNullException">path is <see langword="null"/>.</exception>
      /// <param name="transaction">The transaction.</param>
      /// <param name="path">The directory for which file and subdirectory names are returned.</param>
      [SecurityCritical]
      public static string[] GetFileSystemEntries(KernelTransaction transaction, string path)
      {
         return EnumerateFileSystemEntryInfosInternal<string>(transaction, path, Path.WildcardStarMatchAll, DirectoryEnumerationOptions.FilesAndFolders, PathFormat.Relative).ToArray();
      }

      /// <summary>Returns an array of file system entries that match the specified search criteria.</summary>
      /// <returns>An string[] array of file system entries that match the specified search criteria.</returns>
      /// <remarks>
      /// The EnumerateFileSystemEntries and GetFileSystemEntries methods differ as follows: When you use EnumerateFileSystemEntries,
      /// you can start enumerating the collection of entries before the whole collection is returned; when you use GetFileSystemEntries,
      /// you must wait for the whole array of entries to be returned before you can access the array.
      /// Therefore, when you are working with many files and directories, EnumerateFiles can be more efficient.
      /// </remarks>
      /// <exception cref="ArgumentException">The path parameter contains invalid characters, is empty, or contains only white spaces.</exception>
      /// <exception cref="ArgumentNullException">path is <see langword="null"/>.</exception>
      /// <param name="transaction">The transaction.</param>
      /// <param name="path">The path to be searched.</param>
      /// <param name="searchPattern">
      /// <para>The search string to match against the names of directories in <paramref name="path"/>. This parameter can contain a</para>
      /// <para>combination of valid literal path and wildcard (<see cref="Path.WildcardStarMatchAll"/> and <see cref="Path.WildcardQuestion"/>)</para>
      /// <para>characters, but does not support regular expressions.</para>
      /// </param>
      [SecurityCritical]
      public static string[] GetFileSystemEntries(KernelTransaction transaction, string path, string searchPattern)
      {
         return EnumerateFileSystemEntryInfosInternal<string>(transaction, path, searchPattern, DirectoryEnumerationOptions.FilesAndFolders, PathFormat.Relative).ToArray();
      }

      /// <summary>Gets an array of all the file names and directory names that match a <paramref name="searchPattern"/> in a specified path, and optionally searches subdirectories.</summary>
      /// <returns>An string[] array of file system entries that match the specified search criteria.</returns>
      /// <remarks>
      /// The EnumerateFileSystemEntries and GetFileSystemEntries methods differ as follows: When you use EnumerateFileSystemEntries,
      /// you can start enumerating the collection of entries before the whole collection is returned; when you use GetFileSystemEntries,
      /// you must wait for the whole array of entries to be returned before you can access the array.
      /// Therefore, when you are working with many files and directories, EnumerateFiles can be more efficient.
      /// </remarks>
      /// <exception cref="ArgumentException">The path parameter contains invalid characters, is empty, or contains only white spaces.</exception>
      /// <exception cref="ArgumentNullException">path is <see langword="null"/>.</exception>
      /// <param name="transaction">The transaction.</param>
      /// <param name="path">The directory to search.</param>
      /// <param name="searchPattern">
      /// <para>The search string to match against the names of directories in <paramref name="path"/>. This parameter can contain a</para>
      /// <para>combination of valid literal path and wildcard (<see cref="Path.WildcardStarMatchAll"/> and <see cref="Path.WildcardQuestion"/>)</para>
      /// <para>characters, but does not support regular expressions.</para>
      /// </param>
      /// <param name="searchOption">
      /// <para>One of the <see cref="SearchOption"/> enumeration values that specifies whether the <paramref name="searchOption"/></para>
      /// <para> should include only the current directory or should include all subdirectories.</para>
      /// </param>
      [SecurityCritical]
      public static string[] GetFileSystemEntries(KernelTransaction transaction, string path, string searchPattern, SearchOption searchOption)
      {
         var directoryEnumerationOptions = DirectoryEnumerationOptions.FilesAndFolders;

         if (searchOption == SearchOption.AllDirectories)
            directoryEnumerationOptions |= DirectoryEnumerationOptions.Recursive;

         return EnumerateFileSystemEntryInfosInternal<string>(transaction, path, searchPattern, directoryEnumerationOptions, PathFormat.Relative).ToArray();
      }

      #endregion // .NET

      #endregion // Transacted

      #endregion // AlphaFS

      #endregion // GetFileSystemEntries

      #region GetLastAccessTime

      #region .NET

      /// <summary>Gets the date and time that the specified directory was last accessed.</summary>
      /// <param name="path">The directory for which to obtain access date and time information.</param>
      /// <returns>A <see cref="System.DateTime"/> structure set to the date and time that the specified directory was last accessed. This value is expressed in local time.</returns>
      [SecurityCritical]
      public static DateTime GetLastAccessTime(string path)
      {
         return File.GetLastAccessTimeInternal(null, path, false, PathFormat.Relative).ToLocalTime();
      }

      #endregion // .NET

      #region AlphaFS

      #region IsFullPath

      /// <summary>[AlphaFS] Gets the date and time that the specified directory was last accessed.</summary>
      /// <param name="path">The directory for which to obtain access date and time information.</param>
      /// <param name="pathFormat">Indicates the format of the path parameter(s).</param>
      /// <returns>A <see cref="System.DateTime"/> structure set to the date and time that the specified directory was last accessed. This value is expressed in local time.</returns>
      [SecurityCritical]
      public static DateTime GetLastAccessTime(string path, PathFormat pathFormat)
      {
         return File.GetLastAccessTimeInternal(null, path, false, pathFormat).ToLocalTime();
      }

      #endregion // IsFullPath

      #region Transacted

      #region IsFullPath

      /// <summary>[AlphaFS] Gets the date and time that the specified directory was last accessed.</summary>
      /// <param name="transaction">The transaction.</param>
      /// <param name="path">The directory for which to obtain access date and time information.</param>
      /// <param name="pathFormat">Indicates the format of the path parameter(s).</param>
      /// <returns>A <see cref="System.DateTime"/> structure set to the date and time that the specified directory was last accessed. This value is expressed in local time.</returns>
      [SecurityCritical]
      public static DateTime GetLastAccessTime(KernelTransaction transaction, string path, PathFormat pathFormat)
      {
         return File.GetLastAccessTimeInternal(transaction, path, false, pathFormat).ToLocalTime();
      }

      #endregion // IsFullPath

      #region .NET

      /// <summary>[AlphaFS] Gets the date and time that the specified directory was last accessed.</summary>
      /// <param name="transaction">The transaction.</param>
      /// <param name="path">The directory for which to obtain access date and time information.</param>
      /// <returns>A <see cref="System.DateTime"/> structure set to the date and time that the specified directory was last accessed. This value is expressed in local time.</returns>
      [SecurityCritical]
      public static DateTime GetLastAccessTime(KernelTransaction transaction, string path)
      {
         return File.GetLastAccessTimeInternal(transaction, path, false, PathFormat.Relative).ToLocalTime();
      }

      #endregion // .NET

      #endregion // Transacted

      #endregion // AlphaFS

      #endregion // GetLastAccessTime

      #region GetLastAccessTimeUtc

      #region .NET

      /// <summary>Gets the date and time, in coordinated universal time (UTC), that the specified directory was last accessed.</summary>
      /// <param name="path">The directory for which to obtain access date and time information.</param>
      /// <returns>A <see cref="System.DateTime"/> structure set to the date and time that the specified directory was last accessed. This value is expressed in UTC time.</returns>
      [SecurityCritical]
      public static DateTime GetLastAccessTimeUtc(string path)
      {
         return File.GetLastAccessTimeInternal(null, path, true, PathFormat.Relative);
      }

      #endregion // .NET

      #region AlphaFS

      #region IsFullPath

      #region .NET

      /// <summary>[AlphaFS] Gets the date and time, in coordinated universal time (UTC), that the specified directory was last accessed.</summary>
      /// <param name="path">The directory for which to obtain access date and time information.</param>
      /// <param name="pathFormat">Indicates the format of the path parameter(s).</param>
      /// <returns>A <see cref="System.DateTime"/> structure set to the date and time that the specified directory was last accessed. This value is expressed in UTC time.</returns>
      [SecurityCritical]
      public static DateTime GetLastAccessTimeUtc(string path, PathFormat pathFormat)
      {
         return File.GetLastAccessTimeInternal(null, path, true, pathFormat);
      }

      #endregion // .NET

      #endregion // IsFullPath

      #region Transacted

      #region IsFullPath

      #region .NET

      /// <summary>[AlphaFS] Gets the date and time, in coordinated universal time (UTC), that the specified directory was last accessed.</summary>
      /// <param name="transaction">The transaction.</param>
      /// <param name="path">The directory for which to obtain access date and time information.</param>
      /// <param name="pathFormat">Indicates the format of the path parameter(s).</param>
      /// <returns>A <see cref="System.DateTime"/> structure set to the date and time that the specified directory was last accessed. This value is expressed in UTC time.</returns>
      [SecurityCritical]
      public static DateTime GetLastAccessTimeUtc(KernelTransaction transaction, string path, PathFormat pathFormat)
      {
         return File.GetLastAccessTimeInternal(transaction, path, true, pathFormat);
      }

      #endregion // .NET

      #endregion // IsFullPath

      #region .NET

      /// <summary>[AlphaFS] Gets the date and time, in coordinated universal time (UTC), that the specified directory was last accessed.</summary>
      /// <param name="transaction">The transaction.</param>
      /// <param name="path">The directory for which to obtain access date and time information.</param>
      /// <returns>A <see cref="System.DateTime"/> structure set to the date and time that the specified directory was last accessed. This value is expressed in UTC time.</returns>
      [SecurityCritical]
      public static DateTime GetLastAccessTimeUtc(KernelTransaction transaction, string path)
      {
         return File.GetLastAccessTimeInternal(transaction, path, true, PathFormat.Relative);
      }

      #endregion // .NET

      #endregion // Transacted

      #endregion // AlphaFS

      #endregion // GetLastAccessTimeUtc

      #region GetLastWriteTime

      #region .NET

      /// <summary>Gets the date and time that the specified directory was last written to.</summary>
      /// <param name="path">The directory for which to obtain write date and time information.</param>
      /// <returns>A <see cref="System.DateTime"/> structure set to the date and time that the specified directory was last written to. This value is expressed in local time.</returns>
      [SecurityCritical]
      public static DateTime GetLastWriteTime(string path)
      {
         return File.GetLastWriteTimeInternal(null, path, false, PathFormat.Relative).ToLocalTime();
      }

      #endregion //.NET

      #region AlphaFS

      #region IsFullPath

      #region .NET

      /// <summary>[AlphaFS] Gets the date and time that the specified directory was last written to.</summary>
      /// <param name="path">The directory for which to obtain write date and time information.</param>
      /// <param name="pathFormat">Indicates the format of the path parameter(s).</param>
      /// <returns>A <see cref="System.DateTime"/> structure set to the date and time that the specified directory was last written to. This value is expressed in local time.</returns>
      [SecurityCritical]
      public static DateTime GetLastWriteTime(string path, PathFormat pathFormat)
      {
         return File.GetLastWriteTimeInternal(null, path, false, pathFormat).ToLocalTime();
      }

      #endregion //.NET

      #endregion // IsFullPath

      #region Transacted

      #region IsFullPath

      #region .NET

      /// <summary>[AlphaFS] Gets the date and time that the specified directory was last written to.</summary>
      /// <param name="transaction">The transaction.</param>
      /// <param name="path">The directory for which to obtain write date and time information.</param>
      /// <param name="pathFormat">Indicates the format of the path parameter(s).</param>
      /// <returns>A <see cref="System.DateTime"/> structure set to the date and time that the specified directory was last written to. This value is expressed in local time.</returns>
      [SecurityCritical]
      public static DateTime GetLastWriteTime(KernelTransaction transaction, string path, PathFormat pathFormat)
      {
         return File.GetLastWriteTimeInternal(transaction, path, false, pathFormat).ToLocalTime();
      }

      #endregion //.NET

      #endregion // IsFullPath

      #region .NET

      /// <summary>[AlphaFS] Gets the date and time that the specified directory was last written to.</summary>
      /// <param name="transaction">The transaction.</param>
      /// <param name="path">The directory for which to obtain write date and time information.</param>
      /// <returns>A <see cref="System.DateTime"/> structure set to the date and time that the specified directory was last written to. This value is expressed in local time.</returns>
      [SecurityCritical]
      public static DateTime GetLastWriteTime(KernelTransaction transaction, string path)
      {
         return File.GetLastWriteTimeInternal(transaction, path, false, PathFormat.Relative).ToLocalTime();
      }

      #endregion // .NET

      #endregion // Transacted

      #endregion // AlphaFS

      #endregion // GetLastWriteTime

      #region GetLastWriteTimeUtc

      #region .NET

      /// <summary>Gets the date and time, in coordinated universal time (UTC) time, that the specified directory was last written to.</summary>
      /// <param name="path">The directory for which to obtain write date and time information.</param>
      /// <returns>A <see cref="System.DateTime"/> structure set to the date and time that the specified directory was last written to. This value is expressed in UTC time.</returns>
      [SecurityCritical]
      public static DateTime GetLastWriteTimeUtc(string path)
      {
         return File.GetLastWriteTimeInternal(null, path, true, PathFormat.Relative);
      }

      #endregion // .NET

      #region AlphaFS

      #region IsFullPath

      #region .NET

      /// <summary>[AlphaFS] Gets the date and time, in coordinated universal time (UTC) time, that the specified directory was last written to.</summary>
      /// <param name="path">The directory for which to obtain write date and time information.</param>
      /// <param name="pathFormat">Indicates the format of the path parameter(s).</param>
      /// <returns>A <see cref="System.DateTime"/> structure set to the date and time that the specified directory was last written to. This value is expressed in UTC time.</returns>
      [SecurityCritical]
      public static DateTime GetLastWriteTimeUtc(string path, PathFormat pathFormat)
      {
         return File.GetLastWriteTimeInternal(null, path, true, pathFormat);
      }

      #endregion // .NET

      #endregion // IsFullPath

      #region Transacted

      #region IsFullPath

      #region .NET

      /// <summary>[AlphaFS] Gets the date and time, in coordinated universal time (UTC) time, that the specified directory was last written to.</summary>
      /// <param name="transaction">The transaction.</param>
      /// <param name="path">The directory for which to obtain write date and time information.</param>
      /// <param name="pathFormat">Indicates the format of the path parameter(s).</param>
      /// <returns>A <see cref="System.DateTime"/> structure set to the date and time that the specified directory was last written to. This value is expressed in UTC time.</returns>
      [SecurityCritical]
      public static DateTime GetLastWriteTimeUtc(KernelTransaction transaction, string path, PathFormat pathFormat)
      {
         return File.GetLastWriteTimeInternal(transaction, path, true, pathFormat);
      }

      #endregion // .NET

      #endregion // IsFullPath

      #region .NET

      /// <summary>[AlphaFS] Gets the date and time, in coordinated universal time (UTC) time, that the specified directory was last written to.</summary>
      /// <param name="transaction">The transaction.</param>
      /// <param name="path">The directory for which to obtain write date and time information.</param>
      /// <returns>A <see cref="System.DateTime"/> structure set to the date and time that the specified directory was last written to. This value is expressed in UTC time.</returns>
      [SecurityCritical]
      public static DateTime GetLastWriteTimeUtc(KernelTransaction transaction, string path)
      {
         return File.GetLastWriteTimeInternal(transaction, path, true, PathFormat.Relative);
      }

      #endregion // .NET

      #endregion // Transacted

      #endregion // AlphaFS

      #endregion // GetLastWriteTimeUtc

      #region GetLogicalDrives

      #region .NET

      /// <summary>Retrieves the names of the logical drives on this computer in the form "&lt;drive letter&gt;:\".</summary>
      /// <returns>An array of type <see cref="String"/> that represents the logical drives on a computer.</returns>
      [SecurityCritical]
      public static string[] GetLogicalDrives()
      {
         return EnumerateLogicalDrivesInternal(false, false).Select(drive => drive.Name).ToArray();
      }

      #endregion // .NET

      #region AlphaFS

      /// <summary>[AlphaFS] Retrieves the names of the logical drives on this computer in the form "&lt;drive letter&gt;:\".</summary>
      /// <param name="fromEnvironment">Retrieve logical drives as known by the Environment.</param>
      /// <param name="isReady">Retrieve only when accessible (IsReady) logical drives.</param>
      /// <returns>An array of type <see cref="String"/> that represents the logical drives on a computer.</returns>
      [SecurityCritical]
      public static string[] GetLogicalDrives(bool fromEnvironment, bool isReady)
      {
         return EnumerateLogicalDrivesInternal(fromEnvironment, isReady).Select(drive => drive.Name).ToArray();
      }

      #endregion // AlphaFS

      #endregion // GetLogicalDrives

      #region GetParent

      #region .NET

      /// <summary>Retrieves the parent directory of the specified path, including both absolute and relative paths.</summary>
      /// <param name="path">The path for which to retrieve the parent directory.</param>
      /// <returns>The parent directory, or <see langword="null"/> if <paramref name="path"/> is the root directory, including the root of a UNC server or share name.</returns>
      [SecurityCritical]
      public static DirectoryInfo GetParent(string path)
      {
         return GetParentInternal(null, path, PathFormat.Relative);
      }

      #endregion // .NET

      #region AlphaFS

      #region IsFullPath

      #region .NET

      /// <summary>Retrieves the parent directory of the specified path, including both absolute and relative paths.</summary>
      /// <returns>The parent directory, or <see langword="null"/> if <paramref name="path"/> is the root directory, including the root of a UNC server or share name.</returns>
      /// <param name="path">The path for which to retrieve the parent directory.</param>
      /// <param name="pathFormat">Indicates the format of the path parameter(s).</param>
      [SecurityCritical]
      public static DirectoryInfo GetParent(string path, PathFormat pathFormat)
      {
         return GetParentInternal(null, path, pathFormat);
      }

      #endregion // .NET

      #endregion // IsFullPath

      #region Transacted

      #region IsFullPath

      #region .NET

      /// <summary>Retrieves the parent directory of the specified path, including both absolute and relative paths.</summary>
      /// <returns>The parent directory, or <see langword="null"/> if <paramref name="path"/> is the root directory, including the root of a UNC server or share name.</returns>
      /// <param name="transaction">The transaction.</param>
      /// <param name="path">The path for which to retrieve the parent directory.</param>
      /// <param name="pathFormat">Indicates the format of the path parameter(s).</param>
      [SecurityCritical]
      public static DirectoryInfo GetParent(KernelTransaction transaction, string path, PathFormat pathFormat)
      {
         return GetParentInternal(transaction, path, pathFormat);
      }

      #endregion // .NET

      #endregion // IsFullPath

      #region .NET

      /// <summary>[AlphaFS] Retrieves the parent directory of the specified path, including both absolute and relative paths.</summary>
      /// <param name="transaction">The transaction.</param>
      /// <param name="path">The path for which to retrieve the parent directory.</param>
      /// <returns>The parent directory, or <see langword="null"/> if <paramref name="path"/> is the root directory, including the root of a UNC server or share name.</returns>
      [SecurityCritical]
      public static DirectoryInfo GetParent(KernelTransaction transaction, string path)
      {
         return GetParentInternal(transaction, path, PathFormat.Relative);
      }

      #endregion // .NET

      #endregion // Transacted

      #endregion // AlphaFS

      #endregion // GetParent

      #region Move

      #region .NET

      /// <summary>Moves a file or a directory and its contents to a new location.</summary>
      /// <remarks>
      /// <para>This method does not work across disk volumes.</para>
      /// <para>Whenever possible, avoid using short file names (such as XXXXXX~1.XXX) with this method.</para>
      /// <para>If two directories have equivalent short file names then this method may fail and raise an exception and/or result in undesirable behavior.</para>
      /// </remarks>
      /// <exception cref="ArgumentException">The path parameter contains invalid characters, is empty, or contains only white spaces.</exception>
      /// <exception cref="ArgumentNullException">path is <see langword="null"/>.</exception>
      /// <exception cref="DirectoryNotFoundException"/>
      /// <exception cref="IOException"/>
      /// <exception cref="NotSupportedException"/>
      /// <exception cref="UnauthorizedAccessException"/>
      /// <param name="sourcePath">The source directory path.</param>
      /// <param name="destinationPath">The destination directory path.</param>
      [SecurityCritical]
      public static void Move(string sourcePath, string destinationPath)
      {
         CopyMoveInternal(null, sourcePath, destinationPath, null, MoveOptions.None, null, null, PathFormat.Relative);
      }

      #endregion // .NET

      #region AlphaFS

      #region IsFullPath

      #region .NET

      /// <summary>[AlphaFS] Moves a file or a directory and its contents to a new location.</summary>
      /// <remarks>
      /// <para>This method does not work across disk volumes.</para>
      /// <para>Whenever possible, avoid using short file names (such as XXXXXX~1.XXX) with this method.</para>
      /// <para>If two directories have equivalent short file names then this method may fail and raise an exception and/or result in undesirable behavior.</para>
      /// </remarks>
      /// <exception cref="ArgumentException">The path parameter contains invalid characters, is empty, or contains only white spaces.</exception>
      /// <exception cref="ArgumentNullException">path is <see langword="null"/>.</exception>
      /// <exception cref="DirectoryNotFoundException"/>
      /// <exception cref="IOException"/>
      /// <exception cref="NotSupportedException"/>
      /// <exception cref="UnauthorizedAccessException"/>
      /// <param name="sourcePath">The source directory path.</param>
      /// <param name="destinationPath">The destination directory path.</param>
      /// <param name="pathFormat">Indicates the format of the path parameter(s).</param>
      [SecurityCritical]
      public static void Move(string sourcePath, string destinationPath, PathFormat pathFormat)
      {
         CopyMoveInternal(null, sourcePath, destinationPath, null, MoveOptions.None, null, null, pathFormat);
      }

      #endregion // .NET

      #endregion // IsFullPath

      #region Transacted

      #region IsFullPath

      #region .NET

      /// <summary>[AlphaFS] Moves a file or a directory and its contents to a new location.</summary>
      /// <remarks>
      /// <para>This method does not work across disk volumes.</para>
      /// <para>Whenever possible, avoid using short file names (such as XXXXXX~1.XXX) with this method.</para>
      /// <para>If two directories have equivalent short file names then this method may fail and raise an exception and/or result in undesirable behavior.</para>
      /// </remarks>
      /// <exception cref="ArgumentException">The path parameter contains invalid characters, is empty, or contains only white spaces.</exception>
      /// <exception cref="ArgumentNullException">path is <see langword="null"/>.</exception>
      /// <exception cref="DirectoryNotFoundException"/>
      /// <exception cref="IOException"/>
      /// <exception cref="NotSupportedException"/>
      /// <exception cref="UnauthorizedAccessException"/>
      /// <param name="transaction">The transaction.</param>
      /// <param name="sourcePath">The source directory path.</param>
      /// <param name="destinationPath">The destination directory path.</param>
      /// <param name="pathFormat">Indicates the format of the path parameter(s).</param>
      [SecurityCritical]
      public static void Move(KernelTransaction transaction, string sourcePath, string destinationPath, PathFormat pathFormat)
      {
         CopyMoveInternal(transaction, sourcePath, destinationPath, null, MoveOptions.None, null, null, pathFormat);
      }

      #endregion // .NET

      #endregion // IsFullPath

      #region .NET

      /// <summary>[AlphaFS] Moves a file or a directory and its contents to a new location.</summary>
      /// <remarks>
      /// <para>This method does not work across disk volumes.</para>
      /// <para>Whenever possible, avoid using short file names (such as XXXXXX~1.XXX) with this method.</para>
      /// <para>If two directories have equivalent short file names then this method may fail and raise an exception and/or result in undesirable behavior.</para>
      /// </remarks>
      /// <exception cref="ArgumentException">The path parameter contains invalid characters, is empty, or contains only white spaces.</exception>
      /// <exception cref="ArgumentNullException">path is <see langword="null"/>.</exception>
      /// <exception cref="DirectoryNotFoundException"/>
      /// <exception cref="IOException"/>
      /// <exception cref="NotSupportedException"/>
      /// <exception cref="UnauthorizedAccessException"/>
      /// <param name="transaction">The transaction.</param>
      /// <param name="sourcePath">The source directory path.</param>
      /// <param name="destinationPath">The destination directory path.</param>
      [SecurityCritical]
      public static void Move(KernelTransaction transaction, string sourcePath, string destinationPath)
      {
         CopyMoveInternal(transaction, sourcePath, destinationPath, null, MoveOptions.None, null, null, PathFormat.Relative);
      }

      #endregion // .NET

      #endregion // Transacted

      #endregion // AlphaFS

      #endregion // Move

      #region SetAccessControl

      #region .NET

      /// <summary>Applies access control list (ACL) entries described by a <see cref="DirectorySecurity"/> object to the specified directory.</summary>
      /// <param name="path">A directory to add or remove access control list (ACL) entries from.</param>
      /// <param name="directorySecurity">A <see cref="DirectorySecurity "/> object that describes an ACL entry to apply to the directory described by the path parameter.</param>
      [SuppressMessage("Microsoft.Design", "CA1011:ConsiderPassingBaseTypesAsParameters")]
      [SecurityCritical]
      public static void SetAccessControl(string path, DirectorySecurity directorySecurity)
      {
         File.SetAccessControlInternal(path, null, directorySecurity, AccessControlSections.All, PathFormat.Relative);
      }

      /// <summary>Applies access control list (ACL) entries described by a <see cref="DirectorySecurity"/> object to the specified directory.</summary>
      /// <param name="path">A directory to add or remove access control list (ACL) entries from.</param>
      /// <param name="directorySecurity">A <see cref="DirectorySecurity "/> object that describes an ACL entry to apply to the directory described by the path parameter.</param>
      /// <param name="includeSections">One or more of the <see cref="AccessControlSections"/> values that specifies the type of access control list (ACL) information to set.</param>
      /// <remarks>Note that unlike <see cref="System.IO.File.SetAccessControl"/> this method does <b>not</b> automatically
      /// determine what parts of the specified <see cref="DirectorySecurity"/> instance has been modified. Instead, the
      /// parameter <paramref name="includeSections"/> is used to specify what entries from <paramref name="directorySecurity"/> to apply to <paramref name="path"/>.</remarks>
      [SuppressMessage("Microsoft.Design", "CA1011:ConsiderPassingBaseTypesAsParameters")]
      [SecurityCritical]
      public static void SetAccessControl(string path, DirectorySecurity directorySecurity, AccessControlSections includeSections)
      {
         File.SetAccessControlInternal(path, null, directorySecurity, includeSections, PathFormat.Relative);
      }

      #endregion // .NET

      #region AlphaFS

      #region IsFullPath

      #region .NET

      /// <summary>[AlphaFS] Applies access control list (ACL) entries described by a <see cref="DirectorySecurity"/> object to the specified directory.</summary>
      /// <param name="path">A directory to add or remove access control list (ACL) entries from.</param>
      /// <param name="directorySecurity">A <see cref="DirectorySecurity "/> object that describes an ACL entry to apply to the directory described by the path parameter.</param>
      /// <param name="pathFormat">Indicates the format of the path parameter(s).</param>
      [SuppressMessage("Microsoft.Design", "CA1011:ConsiderPassingBaseTypesAsParameters")]
      [SecurityCritical]
      public static void SetAccessControl(string path, DirectorySecurity directorySecurity, PathFormat pathFormat)
      {
         File.SetAccessControlInternal(path, null, directorySecurity, AccessControlSections.All, pathFormat);
      }

      /// <summary>[AlphaFS] Applies access control list (ACL) entries described by a <see cref="DirectorySecurity"/> object to the specified directory.</summary>
      /// <param name="path">A directory to add or remove access control list (ACL) entries from.</param>
      /// <param name="directorySecurity">A <see cref="DirectorySecurity "/> object that describes an ACL entry to apply to the directory described by the path parameter.</param>
      /// <param name="includeSections">One or more of the <see cref="AccessControlSections"/> values that specifies the type of access control list (ACL) information to set.</param>
      /// <param name="pathFormat">Indicates the format of the path parameter(s).</param>
      /// <remarks>Note that unlike <see cref="System.IO.File.SetAccessControl"/> this method does <b>not</b> automatically
      /// determine what parts of the specified <see cref="DirectorySecurity"/> instance has been modified. Instead, the
      /// parameter <paramref name="includeSections"/> is used to specify what entries from <paramref name="directorySecurity"/> to apply to <paramref name="path"/>.</remarks>
      [SuppressMessage("Microsoft.Design", "CA1011:ConsiderPassingBaseTypesAsParameters")]
      [SecurityCritical]
      public static void SetAccessControl(string path, DirectorySecurity directorySecurity, AccessControlSections includeSections, PathFormat pathFormat)
      {
         File.SetAccessControlInternal(path, null, directorySecurity, includeSections, pathFormat);
      }

      #endregion // .NET

      #endregion // IsFullPath

      #endregion // AlphaFS

      #endregion // SetAccessControl

      #region SetCreationTime

      #region .NET

      /// <summary>Sets the date and time the directory was created.</summary>
      /// <param name="path">The directory for which to set the creation date and time information.</param>
      /// <param name="creationTime">A <see cref="System.DateTime"/> containing the value to set for the creation date and time of <paramref name="path"/>. This value is expressed in local time.</param>
      [SecurityCritical]
      public static void SetCreationTime(string path, DateTime creationTime)
      {
         File.SetFsoDateTimeInternal(true, null, path, creationTime.ToUniversalTime(), null, null, PathFormat.Relative);
      }

      #endregion // .NET

      #region AlphaFS

      #region IsFullPath

      #region .NET

      /// <summary>[AlphaFS] Sets the date and time the directory was created.</summary>
      /// <param name="path">The directory for which to set the creation date and time information.</param>
      /// <param name="pathFormat">Indicates the format of the path parameter(s).</param>
      /// <param name="creationTime">A <see cref="System.DateTime"/> containing the value to set for the creation date and time of <paramref name="path"/>. This value is expressed in local time.</param>
      [SecurityCritical]
      public static void SetCreationTime(string path, DateTime creationTime, PathFormat pathFormat)
      {
         File.SetFsoDateTimeInternal(true, null, path, creationTime.ToUniversalTime(), null, null, pathFormat);
      }

      #endregion // .NET

      #endregion // IsFullPath

      #region Transacted

      #region IsFullPath

      #region .NET

      /// <summary>[AlphaFS] Sets the date and time the directory was created.</summary>
      /// <param name="transaction">The transaction.</param>
      /// <param name="path">The directory for which to set the creation date and time information.</param>
      /// <param name="creationTime">A <see cref="System.DateTime"/> containing the value to set for the creation date and time of <paramref name="path"/>. This value is expressed in local time.</param>
      /// <param name="pathFormat">Indicates the format of the path parameter(s).</param>
      [SecurityCritical]
      public static void SetCreationTime(KernelTransaction transaction, string path, DateTime creationTime, PathFormat pathFormat)
      {
         File.SetFsoDateTimeInternal(true, transaction, path, creationTime.ToUniversalTime(), null, null, pathFormat);
      }

      #endregion // .NET

      #endregion // IsFullPath

      #region .NET

      /// <summary>[AlphaFS] Sets the date and time the directory was created.</summary>
      /// <param name="transaction">The transaction.</param>
      /// <param name="path">The directory for which to set the creation date and time information.</param>
      /// <param name="creationTime">A <see cref="System.DateTime"/> containing the value to set for the creation date and time of <paramref name="path"/>. This value is expressed in local time.</param>
      [SecurityCritical]
      public static void SetCreationTime(KernelTransaction transaction, string path, DateTime creationTime)
      {
         File.SetFsoDateTimeInternal(true, transaction, path, creationTime.ToUniversalTime(), null, null, PathFormat.Relative);
      }

      #endregion // .NET

      #endregion // Transacted

      #endregion // AlphaFS

      #endregion // SetCreationTime

      #region SetCreationTimeUtc

      #region .NET

      /// <summary>Sets the date and time, in coordinated universal time (UTC), that the directory was created.</summary>
      /// <param name="path">The directory for which to set the creation date and time information.</param>
      /// <param name="creationTimeUtc">A <see cref="System.DateTime"/> containing the value to set for the creation date and time of <paramref name="path"/>. This value is expressed in UTC time.</param>
      [SecurityCritical]
      public static void SetCreationTimeUtc(string path, DateTime creationTimeUtc)
      {
         File.SetFsoDateTimeInternal(true, null, path, creationTimeUtc, null, null, PathFormat.Relative);
      }

      #endregion // .NET

      #region AlphaFS

      #region IsFullPath

      #region .NET

      /// <summary>[AlphaFS] Sets the date and time, in coordinated universal time (UTC), that the directory was created.</summary>
      /// <param name="path">The directory for which to set the creation date and time information.</param>
      /// <param name="creationTimeUtc">A <see cref="System.DateTime"/> containing the value to set for the creation date and time of <paramref name="path"/>. This value is expressed in UTC time.</param>
      /// <param name="pathFormat">Indicates the format of the path parameter(s).</param>
      [SecurityCritical]
      public static void SetCreationTimeUtc(string path, DateTime creationTimeUtc, PathFormat pathFormat)
      {
         File.SetFsoDateTimeInternal(true, null, path, creationTimeUtc, null, null, pathFormat);
      }

      #endregion // .NET

      #endregion // IsFullPath

      #region Transacted

      #region IsFullPath

      #region .NET

      /// <summary>[AlphaFS] Sets the date and time, in coordinated universal time (UTC), that the directory was created.</summary>
      /// <param name="transaction">The transaction.</param>
      /// <param name="path">The directory for which to set the creation date and time information.</param>
      /// <param name="creationTimeUtc">A <see cref="System.DateTime"/> containing the value to set for the creation date and time of <paramref name="path"/>. This value is expressed in UTC time.</param>
      /// <param name="pathFormat">Indicates the format of the path parameter(s).</param>
      [SecurityCritical]
      public static void SetCreationTimeUtc(KernelTransaction transaction, string path, DateTime creationTimeUtc, PathFormat pathFormat)
      {
         File.SetFsoDateTimeInternal(true, transaction, path, creationTimeUtc, null, null, pathFormat);
      }

      #endregion // .NET

      #endregion // IsFullPath

      #region .NET

      /// <summary>[AlphaFS] Sets the date and time, in coordinated universal time (UTC), that the directory was created.</summary>
      /// <param name="transaction">The transaction.</param>
      /// <param name="path">The directory for which to set the creation date and time information.</param>
      /// <param name="creationTimeUtc">A <see cref="System.DateTime"/> containing the value to set for the creation date and time of <paramref name="path"/>. This value is expressed in UTC time.</param>
      [SecurityCritical]
      public static void SetCreationTimeUtc(KernelTransaction transaction, string path, DateTime creationTimeUtc)
      {
         File.SetFsoDateTimeInternal(true, transaction, path, creationTimeUtc, null, null, PathFormat.Relative);
      }

      #endregion // .NET

      #endregion // Transacted

      #endregion // AlphaFS

      #endregion // SetCreationTimeUtc

      #region SetCurrentDirectory (.NET)

      #region .NET

      /// <summary>Sets the application's current working directory to the specified directory.</summary>
      /// <param name="path">The path to which the current working directory is set.</param>
      [SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods", MessageId = "0")]
      [SecurityCritical]
      public static void SetCurrentDirectory(string path)
      {
         if (Utils.IsNullOrWhiteSpace(path))
            throw new ArgumentNullException("path");

         string pathRp = Path.GetRegularPathInternal(path, false, false, false, true);

         // System.IO SetCurrentDirectory() does not handle long paths.
         System.IO.Directory.SetCurrentDirectory(path.Length > 255 ? Path.GetShort83Path(pathRp) : pathRp);
      }

      #endregion // .NET

      #endregion // SetCurrentDirectory (.NET)

      #region SetLastAccessTime

      #region .NET

      /// <summary>Sets the date and time that the specified directory was last accessed.</summary>
      /// <param name="path">The file for which to set the access date and time information.</param>
      /// <param name="lastAccessTime">A <see cref="System.DateTime"/> containing the value to set for the last access date and time of <paramref name="path"/>. This value is expressed in local time.</param>
      [SecurityCritical]
      public static void SetLastAccessTime(string path, DateTime lastAccessTime)
      {
         File.SetFsoDateTimeInternal(true, null, path, null, lastAccessTime.ToUniversalTime(), null, PathFormat.Relative);
      }

      #endregion // .NET

      #region AlphaFS

      #region IsFullPath

      #region .NET

      /// <summary>[AlphaFS] Sets the date and time that the specified directory was last accessed.</summary>
      /// <param name="path">The file for which to set the access date and time information.</param>
      /// <param name="lastAccessTime">A <see cref="System.DateTime"/> containing the value to set for the last access date and time of <paramref name="path"/>. This value is expressed in local time.</param>
      /// <param name="pathFormat">Indicates the format of the path parameter(s).</param>
      [SecurityCritical]
      public static void SetLastAccessTime(string path, DateTime lastAccessTime, PathFormat pathFormat)
      {
         File.SetFsoDateTimeInternal(true, null, path, null, lastAccessTime.ToUniversalTime(), null, pathFormat);
      }

      #endregion // .NET

      #endregion // IsFullPath

      #region Transacted

      #region IsFullPath

      #region .NET

      /// <summary>[AlphaFS] Sets the date and time that the specified directory was last accessed.</summary>
      /// <param name="transaction">The transaction.</param>
      /// <param name="path">The directory for which to set the access date and time information.</param>
      /// <param name="lastAccessTime">A <see cref="System.DateTime"/> containing the value to set for the last access date and time of <paramref name="path"/>. This value is expressed in local time.</param>
      /// <param name="pathFormat">Indicates the format of the path parameter(s).</param>
      [SecurityCritical]
      public static void SetLastAccessTime(KernelTransaction transaction, string path, DateTime lastAccessTime, PathFormat pathFormat)
      {
         File.SetFsoDateTimeInternal(true, transaction, path, null, lastAccessTime.ToUniversalTime(), null, pathFormat);
      }

      #endregion // .NET

      #endregion // IsFullPath

      #region .NET

      /// <summary>[AlphaFS] Sets the date and time that the specified directory was last accessed.</summary>
      /// <param name="transaction">The transaction.</param>
      /// <param name="path">The directory for which to set the access date and time information.</param>
      /// <param name="lastAccessTime">A <see cref="System.DateTime"/> containing the value to set for the last access date and time of <paramref name="path"/>. This value is expressed in local time.</param>
      [SecurityCritical]
      public static void SetLastAccessTime(KernelTransaction transaction, string path, DateTime lastAccessTime)
      {
         File.SetFsoDateTimeInternal(true, transaction, path, null, lastAccessTime.ToUniversalTime(), null, PathFormat.Relative);
      }

      #endregion // .NET

      #endregion // Transacted

      #endregion // AlphaFS

      #endregion // SetLastAccessTime

      #region SetLastAccessTimeUtc

      #region .NET

      /// <summary>Sets the date and time, in coordinated universal time (UTC), that the specified directory was last accessed.</summary>
      /// <param name="path">The directory for which to set the access date and time information.</param>
      /// <param name="lastAccessTimeUtc">A <see cref="System.DateTime"/> containing the value to set for the last access date and time of <paramref name="path"/>. This value is expressed in UTC time.</param>
      [SecurityCritical]
      public static void SetLastAccessTimeUtc(string path, DateTime lastAccessTimeUtc)
      {
         File.SetFsoDateTimeInternal(true, null, path, null, lastAccessTimeUtc, null, PathFormat.Relative);
      }

      #endregion // .NET

      #region AlphaFS

      #region IsFullPath

      #region .NET

      /// <summary>[AlphaFS] Sets the date and time, in coordinated universal time (UTC), that the specified directory was last accessed.</summary>
      /// <param name="path">The directory for which to set the access date and time information.</param>
      /// <param name="lastAccessTimeUtc">A <see cref="System.DateTime"/> containing the value to set for the last access date and time of <paramref name="path"/>. This value is expressed in UTC time.</param>
      /// <param name="pathFormat">Indicates the format of the path parameter(s).</param>
      [SecurityCritical]
      public static void SetLastAccessTimeUtc(string path, DateTime lastAccessTimeUtc, PathFormat pathFormat)
      {
         File.SetFsoDateTimeInternal(true, null, path, null, lastAccessTimeUtc, null, pathFormat);
      }

      #endregion // .NET

      #endregion // IsFullPath

      #region Transacted

      #region IsFullPath

      #region .NET

      /// <summary>[AlphaFS] Sets the date and time, in coordinated universal time (UTC), that the specified directory was last accessed.</summary>
      /// <param name="transaction">The transaction.</param>
      /// <param name="path">The directory for which to set the access date and time information.</param>
      /// <param name="lastAccessTimeUtc">A <see cref="System.DateTime"/> containing the value to set for the last access date and time of <paramref name="path"/>. This value is expressed in UTC time.</param>
      /// <param name="pathFormat">Indicates the format of the path parameter(s).</param>
      [SecurityCritical]
      public static void SetLastAccessTimeUtc(KernelTransaction transaction, string path, DateTime lastAccessTimeUtc, PathFormat pathFormat)
      {
         File.SetFsoDateTimeInternal(true, transaction, path, null, lastAccessTimeUtc, null, pathFormat);
      }

      #endregion // .NET

      #endregion // IsFullPath

      #region .NET

      /// <summary>[AlphaFS] Sets the date and time, in coordinated universal time (UTC), that the specified directory was last accessed.</summary>
      /// <param name="transaction">The transaction.</param>
      /// <param name="path">The directory for which to set the access date and time information.</param>
      /// <param name="lastAccessTimeUtc">A <see cref="System.DateTime"/> containing the value to set for the last access date and time of <paramref name="path"/>. This value is expressed in UTC time.</param>
      [SecurityCritical]
      public static void SetLastAccessTimeUtc(KernelTransaction transaction, string path, DateTime lastAccessTimeUtc)
      {
         File.SetFsoDateTimeInternal(true, transaction, path, null, lastAccessTimeUtc, null, PathFormat.Relative);
      }

      #endregion // .NET

      #endregion // Transacted

      #endregion // AlphaFS

      #endregion // SetLastAccessTimeUtc

      #region SetLastWriteTime

      #region .NET

      /// <summary>Sets the date and time that the specified directory was last written to.</summary>
      /// <param name="path">The directory for which to set the date and time information.</param>
      /// <param name="lastWriteTime">A <see cref="System.DateTime"/> containing the value to set for the last write date and time of <paramref name="path"/>. This value is expressed in local time.</param>
      [SecurityCritical]
      public static void SetLastWriteTime(string path, DateTime lastWriteTime)
      {
         File.SetFsoDateTimeInternal(true, null, path, null, null, lastWriteTime.ToUniversalTime(), PathFormat.Relative);
      }

      #endregion // .NET

      #region AlphaFS

      #region IsFullPath

      #region .NET

      /// <summary>[AlphaFS] Sets the date and time that the specified directory was last written to.</summary>
      /// <param name="path">The directory for which to set the date and time information.</param>
      /// <param name="lastWriteTime">A <see cref="System.DateTime"/> containing the value to set for the last write date and time of <paramref name="path"/>. This value is expressed in local time.</param>
      /// <param name="pathFormat">Indicates the format of the path parameter(s).</param>
      [SecurityCritical]
      public static void SetLastWriteTime(string path, DateTime lastWriteTime, PathFormat pathFormat)
      {
         File.SetFsoDateTimeInternal(true, null, path, null, null, lastWriteTime.ToUniversalTime(), pathFormat);
      }

      #endregion // .NET

      #endregion // IsFullPath

      #region Transacted

      #region IsFullPath

      #region .NET

      /// <summary>[AlphaFS] Sets the date and time that the specified directory was last written to.</summary>
      /// <param name="transaction">The transaction.</param>
      /// <param name="path">The directory for which to set the date and time information.</param>
      /// <param name="lastWriteTime">A <see cref="System.DateTime"/> containing the value to set for the last write date and time of <paramref name="path"/>. This value is expressed in local time.</param>
      /// <param name="pathFormat">Indicates the format of the path parameter(s).</param>
      [SecurityCritical]
      public static void SetLastWriteTime(KernelTransaction transaction, string path, DateTime lastWriteTime, PathFormat pathFormat)
      {
         File.SetFsoDateTimeInternal(true, transaction, path, null, null, lastWriteTime.ToUniversalTime(), pathFormat);
      }

      #endregion // .NET

      #endregion // IsFullPath

      #region .NET

      /// <summary>[AlphaFS] Sets the date and time that the specified directory was last written to.</summary>
      /// <param name="transaction">The transaction.</param>
      /// <param name="path">The directory for which to set the date and time information.</param>
      /// <param name="lastWriteTime">A <see cref="System.DateTime"/> containing the value to set for the last write date and time of <paramref name="path"/>. This value is expressed in local time.</param>
      [SecurityCritical]
      public static void SetLastWriteTime(KernelTransaction transaction, string path, DateTime lastWriteTime)
      {
         File.SetFsoDateTimeInternal(true, transaction, path, null, null, lastWriteTime.ToUniversalTime(), PathFormat.Relative);
      }

      #endregion // .NET

      #endregion // Transacted

      #endregion // AlphaFS

      #endregion // SetLastWriteTime

      #region SetLastWriteTimeUtc

      #region .NET

      /// <summary>Sets the date and time, in coordinated universal time (UTC), that the specified directory was last written to.</summary>
      /// <param name="path">The directory for which to set the date and time information.</param>
      /// <param name="lastWriteTimeUtc">A <see cref="System.DateTime"/> containing the value to set for the last write date and time of <paramref name="path"/>. This value is expressed in UTC time.</param>
      [SecurityCritical]
      public static void SetLastWriteTimeUtc(string path, DateTime lastWriteTimeUtc)
      {
         File.SetFsoDateTimeInternal(true, null, path, null, null, lastWriteTimeUtc, PathFormat.Relative);
      }

      #endregion // .NET

      #region AlphaFS

      #region IsFullPath

      #region .NET

      /// <summary>[AlphaFS] Sets the date and time, in coordinated universal time (UTC), that the specified directory was last written to.</summary>
      /// <param name="path">The directory for which to set the date and time information.</param>
      /// <param name="lastWriteTimeUtc">A <see cref="System.DateTime"/> containing the value to set for the last write date and time of <paramref name="path"/>. This value is expressed in UTC time.</param>
      /// <param name="pathFormat">Indicates the format of the path parameter(s).</param>
      [SecurityCritical]
      public static void SetLastWriteTimeUtc(string path, DateTime lastWriteTimeUtc, PathFormat pathFormat)
      {
         File.SetFsoDateTimeInternal(true, null, path, null, null, lastWriteTimeUtc, pathFormat);
      }

      #endregion // .NET

      #endregion // IsFullPath

      #region Transacted

      #region IsFullPath

      #region .NET

      /// <summary>[AlphaFS] Sets the date and time, in coordinated universal time (UTC), that the specified directory was last written to.</summary>
      /// <param name="transaction">The transaction.</param>
      /// <param name="path">The directory for which to set the date and time information.</param>
      /// <param name="lastWriteTimeUtc">A <see cref="System.DateTime"/> containing the value to set for the last write date and time of <paramref name="path"/>. This value is expressed in UTC time.</param>
      /// <param name="pathFormat">Indicates the format of the path parameter(s).</param>
      [SecurityCritical]
      public static void SetLastWriteTimeUtc(KernelTransaction transaction, string path, DateTime lastWriteTimeUtc, PathFormat pathFormat)
      {
         File.SetFsoDateTimeInternal(true, transaction, path, null, null, lastWriteTimeUtc, pathFormat);
      }

      #endregion // .NET

      #endregion // IsFullPath

      #region .NET

      /// <summary>[AlphaFS] Sets the date and time, in coordinated universal time (UTC), that the specified directory was last written to.</summary>
      /// <param name="transaction">The transaction.</param>
      /// <param name="path">The directory for which to set the date and time information.</param>
      /// <param name="lastWriteTimeUtc">A <see cref="System.DateTime"/> containing the value to set for the last write date and time of <paramref name="path"/>. This value is expressed in UTC time.</param>
      [SecurityCritical]
      public static void SetLastWriteTimeUtc(KernelTransaction transaction, string path, DateTime lastWriteTimeUtc)
      {
         File.SetFsoDateTimeInternal(true, transaction, path, null, null, lastWriteTimeUtc, PathFormat.Relative);
      }

      #endregion // .NET

      #endregion // Transacted

      #endregion // AlphaFS

      #endregion // SetLastWriteTimeUtc

      #endregion // .NET

      #region AlphaFS

      #region AddStream

      #region IsFullPath

      /// <summary>[AlphaFS] Adds an alternate data stream (NTFS ADS) to an existing directory.</summary>
      /// <param name="path">The path to an existing directory.</param>
      /// <param name="name">The name for the stream. If a stream with <paramref name="name"/> already exists, it will be overwritten.</param>
      /// <param name="contents">The lines to add to the stream.</param>
      /// <param name="pathFormat">Indicates the format of the path parameter(s).</param>
      [SecurityCritical]
      public static void AddStream(string path, string name, string[] contents, PathFormat pathFormat)
      {
         AlternateDataStreamInfo.AddStreamInternal(true, null, path, name, contents, pathFormat);
      }

      #endregion // IsFullPath

      /// <summary>[AlphaFS] Adds an alternate data stream (NTFS ADS) to an existing directory.</summary>
      /// <param name="path">The path to an existing directory.</param>
      /// <param name="name">The name for the stream. If a stream with <paramref name="name"/> already exists, it will be overwritten.</param>
      /// <param name="contents">The lines to add to the stream.</param>
      [SecurityCritical]
      public static void AddStream(string path, string name, string[] contents)
      {
         AlternateDataStreamInfo.AddStreamInternal(true, null, path, name, contents, PathFormat.Relative);
      }

      #region Transacted

      #region IsFullPath

      /// <summary>[AlphaFS] Adds an alternate data stream (NTFS ADS) to an existing directory.</summary>
      /// <param name="transaction">The transaction.</param>
      /// <param name="path">The path to an existing directory.</param>
      /// <param name="name">The name for the stream. If a stream with <paramref name="name"/> already exists, it will be overwritten.</param>
      /// <param name="contents">The lines to add to the stream.</param>
      /// <param name="pathFormat">Indicates the format of the path parameter(s).</param>
      [SecurityCritical]
      public static void AddStream(KernelTransaction transaction, string path, string name, string[] contents, PathFormat pathFormat)
      {
         AlternateDataStreamInfo.AddStreamInternal(true, transaction, path, name, contents, pathFormat);
      }

      #endregion // IsFullPath

      /// <summary>[AlphaFS] Adds an alternate data stream (NTFS ADS) to an existing directory.</summary>
      /// <param name="transaction">The transaction.</param>
      /// <param name="path">The path to an existing directory.</param>
      /// <param name="name">The name for the stream. If a stream with <paramref name="name"/> already exists, it will be overwritten.</param>
      /// <param name="contents">The lines to add to the stream.</param>
      [SecurityCritical]
      public static void AddStream(KernelTransaction transaction, string path, string name, string[] contents)
      {
         AlternateDataStreamInfo.AddStreamInternal(true, transaction, path, name, contents, PathFormat.Relative);
      }

      #endregion Transacted

      #endregion // AddStream

      #region Compress

      #region IsFullPath

      /// <summary>[AlphaFS] Compresses a directory using NTFS compression.</summary>
      /// <param name="path">A path that describes a directory to compress.</param>
      /// <remarks>This will only compress the root items, non recursive.</remarks>
      /// <param name="pathFormat">Indicates the format of the path parameter(s).</param>
      [SecurityCritical]
      public static void Compress(string path, PathFormat pathFormat)
      {
         CompressDecompressInternal(null, path, Path.WildcardStarMatchAll, DirectoryEnumerationOptions.FilesAndFolders, true, pathFormat);
      }

      /// <summary>[AlphaFS] Compresses a directory using NTFS compression.</summary>
      /// <param name="path">A path that describes a directory to compress.</param>
      /// <param name="directoryEnumerationOptions"><see cref="DirectoryEnumerationOptions"/> flags that specify how the directory is to be enumerated.</param>
      /// <param name="pathFormat">Indicates the format of the path parameter(s).</param>
      [SecurityCritical]
      public static void Compress(string path, DirectoryEnumerationOptions directoryEnumerationOptions, PathFormat pathFormat)
      {
         CompressDecompressInternal(null, path, Path.WildcardStarMatchAll, directoryEnumerationOptions, true, pathFormat);
      }

      #endregion // IsFullPath

      /// <summary>[AlphaFS] Compresses a directory using NTFS compression.</summary>
      /// <param name="path">A path that describes a directory to compress.</param>
      /// <remarks>This will only compress the root items, non recursive.</remarks>
      [SecurityCritical]
      public static void Compress(string path)
      {
         CompressDecompressInternal(null, path, Path.WildcardStarMatchAll, DirectoryEnumerationOptions.FilesAndFolders, true, PathFormat.Relative);
      }

      /// <summary>[AlphaFS] Compresses a directory using NTFS compression.</summary>
      /// <param name="path">A path that describes a directory to compress.</param>
      /// <param name="directoryEnumerationOptions"><see cref="DirectoryEnumerationOptions"/> flags that specify how the directory is to be enumerated.</param>
      [SecurityCritical]
      public static void Compress(string path, DirectoryEnumerationOptions directoryEnumerationOptions)
      {
         CompressDecompressInternal(null, path, Path.WildcardStarMatchAll, directoryEnumerationOptions, true, PathFormat.Relative);
      }

      #region Transacted

      #region IsFullPath

      /// <summary>[AlphaFS] Compresses a directory using NTFS compression.</summary>
      /// <param name="transaction">The transaction.</param>
      /// <param name="path">A path that describes a directory to compress.</param>
      /// <param name="pathFormat">Indicates the format of the path parameter(s).</param>
      /// <remarks>This will only compress the root items, non recursive.</remarks>
      [SecurityCritical]
      public static void Compress(KernelTransaction transaction, string path, PathFormat pathFormat)
      {
         CompressDecompressInternal(transaction, path, Path.WildcardStarMatchAll, DirectoryEnumerationOptions.FilesAndFolders, true, pathFormat);
      }

      /// <summary>[AlphaFS] Compresses a directory using NTFS compression.</summary>
      /// <param name="transaction">The transaction.</param>
      /// <param name="path">A path that describes a directory to compress.</param>
      /// <param name="directoryEnumerationOptions"><see cref="DirectoryEnumerationOptions"/> flags that specify how the directory is to be enumerated.</param>
      /// <param name="pathFormat">Indicates the format of the path parameter(s).</param>
      [SecurityCritical]
      public static void Compress(KernelTransaction transaction, string path, DirectoryEnumerationOptions directoryEnumerationOptions, PathFormat pathFormat)
      {
         CompressDecompressInternal(transaction, path, Path.WildcardStarMatchAll, directoryEnumerationOptions, true, pathFormat);
      }

      #endregion // IsFullPath

      /// <summary>[AlphaFS] Compresses a directory using NTFS compression.</summary>
      /// <param name="transaction">The transaction.</param>
      /// <param name="path">A path that describes a directory to compress.</param>
      /// <remarks>This will only compress the root items, non recursive.</remarks>
      [SecurityCritical]
      public static void Compress(KernelTransaction transaction, string path)
      {
         CompressDecompressInternal(transaction, path, Path.WildcardStarMatchAll, DirectoryEnumerationOptions.FilesAndFolders, true, PathFormat.Relative);
      }

      /// <summary>[AlphaFS] Compresses a directory using NTFS compression.</summary>
      /// <param name="transaction">The transaction.</param>
      /// <param name="path">A path that describes a directory to compress.</param>
      /// <param name="directoryEnumerationOptions"><see cref="DirectoryEnumerationOptions"/> flags that specify how the directory is to be enumerated.</param>
      [SecurityCritical]
      public static void Compress(KernelTransaction transaction, string path, DirectoryEnumerationOptions directoryEnumerationOptions)
      {
         CompressDecompressInternal(transaction, path, Path.WildcardStarMatchAll, directoryEnumerationOptions, true, PathFormat.Relative);
      }

      #endregion // Transacted

      #endregion // Compress

      #region Copy1

      #region IsFullPath

      /// <summary>[AlphaFS] Copies a file or a directory and its contents to a new location, <see cref="CopyOptions"/> can be specified.</summary>
      /// <remarks>
      /// <para>Option <see cref="CopyOptions.NoBuffering"/> is recommended for very large file transfers.</para>
      /// <para>Whenever possible, avoid using short file names (such as XXXXXX~1.XXX) with this method.</para>
      /// <para>If two directories have equivalent short file names then this method may fail and raise an exception and/or result in undesirable behavior.</para>
      /// </remarks>
      /// <exception cref="ArgumentException">The path parameter contains invalid characters, is empty, or contains only white spaces.</exception>
      /// <exception cref="ArgumentNullException">path is <see langword="null"/>.</exception>
      /// <exception cref="DirectoryNotFoundException"/>
      /// <exception cref="IOException"/>
      /// <exception cref="NotSupportedException"/>
      /// <exception cref="UnauthorizedAccessException"/>
      /// <param name="sourcePath">The source directory path.</param>
      /// <param name="destinationPath">The destination directory path.</param>
      /// <param name="copyOptions"><see cref="CopyOptions"/> that specify how the directory is to be copied. This parameter can be <see langword="null"/>.</param>
      /// <param name="pathFormat">Indicates the format of the path parameter(s).</param>
      [SecurityCritical]
      public static void Copy1(string sourcePath, string destinationPath, CopyOptions copyOptions, PathFormat pathFormat)
      {
         CopyMoveInternal(null, sourcePath, destinationPath, copyOptions, null, null, null, pathFormat);
      }

      /// <summary>[AlphaFS] Copies a file or a directory and its contents to a new location, <see cref="CopyOptions"/> can be specified,
      /// <para>and the possibility of notifying the application of its progress through a callback function.</para>
      /// </summary>
      /// <returns>Returns a <see cref="CopyMoveResult"/> class with the status of the Copy action.</returns>
      /// <remarks>
      /// <para>Option <see cref="CopyOptions.NoBuffering"/> is recommended for very large file transfers.</para>
      /// <para>Whenever possible, avoid using short file names (such as XXXXXX~1.XXX) with this method.</para>
      /// <para>If two directories have equivalent short file names then this method may fail and raise an exception and/or result in undesirable behavior.</para>
      /// </remarks>
      /// <exception cref="ArgumentException">The path parameter contains invalid characters, is empty, or contains only white spaces.</exception>
      /// <exception cref="ArgumentNullException">path is <see langword="null"/>.</exception>
      /// <exception cref="DirectoryNotFoundException"/>
      /// <exception cref="IOException"/>
      /// <exception cref="NotSupportedException"/>
      /// <exception cref="UnauthorizedAccessException"/>
      /// <param name="sourcePath">The source directory path.</param>
      /// <param name="destinationPath">The destination directory path.</param>
      /// <param name="copyOptions"><see cref="CopyOptions"/> that specify how the directory is to be copied. This parameter can be <see langword="null"/>.</param>
      /// <param name="progressHandler">A callback function that is called each time another portion of the directory has been copied. This parameter can be <see langword="null"/>.</param>
      /// <param name="userProgressData">The argument to be passed to the callback function. This parameter can be <see langword="null"/>.</param>
      /// <param name="pathFormat">Indicates the format of the path parameter(s).</param>
      [SecurityCritical]
      public static CopyMoveResult Copy1(string sourcePath, string destinationPath, CopyOptions copyOptions, CopyMoveProgressRoutine progressHandler, object userProgressData, PathFormat pathFormat)
      {
         return CopyMoveInternal(null, sourcePath, destinationPath, copyOptions, null, progressHandler, userProgressData, pathFormat);
      }

      #endregion // IsFullPath

      /// <summary>[AlphaFS] Copies a file or a directory and its contents to a new location, <see cref="CopyOptions"/> can be specified.</summary>
      /// <remarks>
      /// <para>Option <see cref="CopyOptions.NoBuffering"/> is recommended for very large file transfers.</para>
      /// <para>Whenever possible, avoid using short file names (such as XXXXXX~1.XXX) with this method.</para>
      /// <para>If two directories have equivalent short file names then this method may fail and raise an exception and/or result in undesirable behavior.</para>
      /// </remarks>
      /// <exception cref="ArgumentException">The path parameter contains invalid characters, is empty, or contains only white spaces.</exception>
      /// <exception cref="ArgumentNullException">path is <see langword="null"/>.</exception>
      /// <exception cref="DirectoryNotFoundException"/>
      /// <exception cref="IOException"/>
      /// <exception cref="NotSupportedException"/>
      /// <exception cref="UnauthorizedAccessException"/>
      /// <param name="sourcePath">The source directory path.</param>
      /// <param name="destinationPath">The destination directory path.</param>
      /// <param name="copyOptions"><see cref="CopyOptions"/> that specify how the directory is to be copied. This parameter can be <see langword="null"/>.</param>
      [SecurityCritical]
      public static void Copy1(string sourcePath, string destinationPath, CopyOptions copyOptions)
      {
         CopyMoveInternal(null, sourcePath, destinationPath, copyOptions, null, null, null, PathFormat.Relative);
      }

      /// <summary>[AlphaFS] Copies a file or a directory and its contents to a new location, <see cref="CopyOptions"/> can be specified,
      /// <para>and the possibility of notifying the application of its progress through a callback function.</para>
      /// </summary>
      /// <returns>Returns a <see cref="CopyMoveResult"/> class with the status of the Copy action.</returns>
      /// <remarks>
      /// <para>Option <see cref="CopyOptions.NoBuffering"/> is recommended for very large file transfers.</para>
      /// <para>Whenever possible, avoid using short file names (such as XXXXXX~1.XXX) with this method.</para>
      /// <para>If two directories have equivalent short file names then this method may fail and raise an exception and/or result in undesirable behavior.</para>
      /// </remarks>
      /// <exception cref="ArgumentException">The path parameter contains invalid characters, is empty, or contains only white spaces.</exception>
      /// <exception cref="ArgumentNullException">path is <see langword="null"/>.</exception>
      /// <exception cref="DirectoryNotFoundException"/>
      /// <exception cref="IOException"/>
      /// <exception cref="NotSupportedException"/>
      /// <exception cref="UnauthorizedAccessException"/>
      /// <param name="sourcePath">The source directory path.</param>
      /// <param name="destinationPath">The destination directory path.</param>
      /// <param name="copyOptions"><see cref="CopyOptions"/> that specify how the directory is to be copied. This parameter can be <see langword="null"/>.</param>
      /// <param name="progressHandler">A callback function that is called each time another portion of the directory has been copied. This parameter can be <see langword="null"/>.</param>
      /// <param name="userProgressData">The argument to be passed to the callback function. This parameter can be <see langword="null"/>.</param>
      [SecurityCritical]
      public static CopyMoveResult Copy1(string sourcePath, string destinationPath, CopyOptions copyOptions, CopyMoveProgressRoutine progressHandler, object userProgressData)
      {
         return CopyMoveInternal(null, sourcePath, destinationPath, copyOptions, null, progressHandler, userProgressData, PathFormat.Relative);
      }

      #region Transacted

      #region IsFullPath

      /// <summary>[AlphaFS] Copies a file or a directory and its contents to a new location, <see cref="CopyOptions"/> can be specified.</summary>
      /// <remarks>
      /// <para>Option <see cref="CopyOptions.NoBuffering"/> is recommended for very large file transfers.</para>
      /// <para>Whenever possible, avoid using short file names (such as XXXXXX~1.XXX) with this method.</para>
      /// <para>If two directories have equivalent short file names then this method may fail and raise an exception and/or result in undesirable behavior.</para>
      /// </remarks>
      /// <exception cref="ArgumentException">The path parameter contains invalid characters, is empty, or contains only white spaces.</exception>
      /// <exception cref="ArgumentNullException">path is <see langword="null"/>.</exception>
      /// <exception cref="DirectoryNotFoundException"/>
      /// <exception cref="IOException"/>
      /// <exception cref="NotSupportedException"/>
      /// <exception cref="UnauthorizedAccessException"/>
      /// <param name="transaction">The transaction.</param>
      /// <param name="sourcePath">The source directory path.</param>
      /// <param name="destinationPath">The destination directory path.</param>
      /// <param name="copyOptions"><see cref="CopyOptions"/> that specify how the directory is to be copied. This parameter can be <see langword="null"/>.</param>
      /// <param name="pathFormat">Indicates the format of the path parameter(s).</param>
      [SecurityCritical]
      public static void Copy1(KernelTransaction transaction, string sourcePath, string destinationPath, CopyOptions copyOptions, PathFormat pathFormat)
      {
         CopyMoveInternal(transaction, sourcePath, destinationPath, copyOptions, null, null, null, pathFormat);
      }

      /// <summary>[AlphaFS] Copies a file or a directory and its contents to a new location, <see cref="CopyOptions"/> can be specified,
      /// <para>and the possibility of notifying the application of its progress through a callback function.</para>
      /// </summary>
      /// <returns>Returns a <see cref="CopyMoveResult"/> class with the status of the Copy action.</returns>
      /// <remarks>
      /// <para>Option <see cref="CopyOptions.NoBuffering"/> is recommended for very large file transfers.</para>
      /// <para>Whenever possible, avoid using short file names (such as XXXXXX~1.XXX) with this method.</para>
      /// <para>If two directories have equivalent short file names then this method may fail and raise an exception and/or result in undesirable behavior.</para>
      /// </remarks>
      /// <exception cref="ArgumentException">The path parameter contains invalid characters, is empty, or contains only white spaces.</exception>
      /// <exception cref="ArgumentNullException">path is <see langword="null"/>.</exception>
      /// <exception cref="DirectoryNotFoundException"/>
      /// <exception cref="IOException"/>
      /// <exception cref="NotSupportedException"/>
      /// <exception cref="UnauthorizedAccessException"/>
      /// <param name="transaction">The transaction.</param>
      /// <param name="sourcePath">The source directory path.</param>
      /// <param name="destinationPath">The destination directory path.</param>
      /// <param name="copyOptions"><see cref="CopyOptions"/> that specify how the directory is to be copied. This parameter can be <see langword="null"/>.</param>
      /// <param name="progressHandler">A callback function that is called each time another portion of the directory has been copied. This parameter can be <see langword="null"/>.</param>
      /// <param name="userProgressData">The argument to be passed to the callback function. This parameter can be <see langword="null"/>.</param>
      /// <param name="pathFormat">Indicates the format of the path parameter(s).</param>
      [SecurityCritical]
      public static CopyMoveResult Copy1(KernelTransaction transaction, string sourcePath, string destinationPath, CopyOptions copyOptions, CopyMoveProgressRoutine progressHandler, object userProgressData, PathFormat pathFormat)
      {
         return CopyMoveInternal(transaction, sourcePath, destinationPath, copyOptions, null, progressHandler, userProgressData, pathFormat);
      }

      #endregion // IsFullPath

      /// <summary>[AlphaFS] Copies a file or a directory and its contents to a new location, <see cref="CopyOptions"/> can be specified.</summary>
      /// <remarks>
      /// <para>Option <see cref="CopyOptions.NoBuffering"/> is recommended for very large file transfers.</para>
      /// <para>Whenever possible, avoid using short file names (such as XXXXXX~1.XXX) with this method.</para>
      /// <para>If two directories have equivalent short file names then this method may fail and raise an exception and/or result in undesirable behavior.</para>
      /// </remarks>
      /// <exception cref="ArgumentException">The path parameter contains invalid characters, is empty, or contains only white spaces.</exception>
      /// <exception cref="ArgumentNullException">path is <see langword="null"/>.</exception>
      /// <exception cref="DirectoryNotFoundException"/>
      /// <exception cref="IOException"/>
      /// <exception cref="NotSupportedException"/>
      /// <exception cref="UnauthorizedAccessException"/>
      /// <param name="transaction">The transaction.</param>
      /// <param name="sourcePath">The source directory path.</param>
      /// <param name="destinationPath">The destination directory path.</param>
      /// <param name="copyOptions"><see cref="CopyOptions"/> that specify how the directory is to be copied. This parameter can be <see langword="null"/>.</param>
      [SecurityCritical]
      public static void Copy1(KernelTransaction transaction, string sourcePath, string destinationPath, CopyOptions copyOptions)
      {
         CopyMoveInternal(transaction, sourcePath, destinationPath, copyOptions, null, null, null, PathFormat.Relative);
      }

      /// <summary>[AlphaFS] Copies a file or a directory and its contents to a new location, <see cref="CopyOptions"/> can be specified,
      /// <para>and the possibility of notifying the application of its progress through a callback function.</para>
      /// </summary>
      /// <returns>Returns a <see cref="CopyMoveResult"/> class with the status of the Copy action.</returns>
      /// <remarks>
      /// <para>Option <see cref="CopyOptions.NoBuffering"/> is recommended for very large file transfers.</para>
      /// <para>Whenever possible, avoid using short file names (such as XXXXXX~1.XXX) with this method.</para>
      /// <para>If two directories have equivalent short file names then this method may fail and raise an exception and/or result in undesirable behavior.</para>
      /// </remarks>
      /// <exception cref="ArgumentException">The path parameter contains invalid characters, is empty, or contains only white spaces.</exception>
      /// <exception cref="ArgumentNullException">path is <see langword="null"/>.</exception>
      /// <exception cref="DirectoryNotFoundException"/>
      /// <exception cref="IOException"/>
      /// <exception cref="NotSupportedException"/>
      /// <exception cref="UnauthorizedAccessException"/>
      /// <param name="transaction">The transaction.</param>
      /// <param name="sourcePath">The source directory path.</param>
      /// <param name="destinationPath">The destination directory path.</param>
      /// <param name="copyOptions"><see cref="CopyOptions"/> that specify how the directory is to be copied. This parameter can be <see langword="null"/>.</param>
      /// <param name="progressHandler">A callback function that is called each time another portion of the directory has been copied. This parameter can be <see langword="null"/>.</param>
      /// <param name="userProgressData">The argument to be passed to the callback function. This parameter can be <see langword="null"/>.</param>
      [SecurityCritical]
      public static CopyMoveResult Copy1(KernelTransaction transaction, string sourcePath, string destinationPath, CopyOptions copyOptions, CopyMoveProgressRoutine progressHandler, object userProgressData)
      {
         return CopyMoveInternal(transaction, sourcePath, destinationPath, copyOptions, null, progressHandler, userProgressData, PathFormat.Relative);
      }

      #endregion // Transacted

      #endregion // Copy1

      #region CountFileSystemObjects

      #region IsFullPath

      /// <summary>[AlphaFS] Counts file system objects: files, folders or both) in a given directory.</summary>
      /// <param name="path">The directory path.</param>
      /// <param name="directoryEnumerationOptions"><see cref="DirectoryEnumerationOptions"/> flags that specify how the directory is to be enumerated.</param>
      /// <returns>The counted number of file system objects.</returns>
      /// <param name="pathFormat">Indicates the format of the path parameter(s).</param>
      /// <exception cref="System.UnauthorizedAccessException">An exception is thrown case of access errors.</exception>
      [SecurityCritical]
      public static long CountFileSystemObjects(string path, DirectoryEnumerationOptions directoryEnumerationOptions, PathFormat pathFormat)
      {
         return EnumerateFileSystemEntryInfosInternal<string>(null, path, Path.WildcardStarMatchAll, directoryEnumerationOptions, pathFormat).Count();
      }

      /// <summary>[AlphaFS] Counts file system objects: files, folders or both) in a given directory.</summary>
      /// <param name="path">The directory path.</param>
      /// <param name="searchPattern">
      /// <para>The search string to match against the names of directories in path. This parameter can contain a</para>
      /// <para>combination of valid literal path and wildcard (<see cref="Path.WildcardStarMatchAll"/> and <see cref="Path.WildcardQuestion"/>)</para>
      /// <para>characters, but does not support regular expressions.</para>
      /// </param>
      /// <param name="directoryEnumerationOptions"><see cref="DirectoryEnumerationOptions"/> flags that specify how the directory is to be enumerated.</param>
      /// <param name="pathFormat">Indicates the format of the path parameter(s).</param>
      /// <returns>The counted number of file system objects.</returns>
      /// <exception cref="System.UnauthorizedAccessException">An exception is thrown case of access errors.</exception>
      [SecurityCritical]
      public static long CountFileSystemObjects(string path, string searchPattern, DirectoryEnumerationOptions directoryEnumerationOptions, PathFormat pathFormat)
      {
         return EnumerateFileSystemEntryInfosInternal<string>(null, path, searchPattern, directoryEnumerationOptions, pathFormat).Count();
      }

      #endregion // IsFullPath

      /// <summary>[AlphaFS] Counts file system objects: files, folders or both) in a given directory.</summary>
      /// <param name="path">The directory path.</param>
      /// <param name="directoryEnumerationOptions"><see cref="DirectoryEnumerationOptions"/> flags that specify how the directory is to be enumerated.</param>
      /// <returns>The counted number of file system objects.</returns>
      /// <exception cref="System.UnauthorizedAccessException">An exception is thrown case of access errors.</exception>
      [SecurityCritical]
      public static long CountFileSystemObjects(string path, DirectoryEnumerationOptions directoryEnumerationOptions)
      {
         return EnumerateFileSystemEntryInfosInternal<string>(null, path, Path.WildcardStarMatchAll, directoryEnumerationOptions, PathFormat.Relative).Count();
      }

      /// <summary>[AlphaFS] Counts file system objects: files, folders or both) in a given directory.</summary>
      /// <param name="path">The directory path.</param>
      /// <param name="searchPattern">
      /// <para>The search string to match against the names of directories in path. This parameter can contain a</para>
      /// <para>combination of valid literal path and wildcard (<see cref="Path.WildcardStarMatchAll"/> and <see cref="Path.WildcardQuestion"/>)</para>
      /// <para>characters, but does not support regular expressions.</para>
      /// </param>
      /// <param name="directoryEnumerationOptions"><see cref="DirectoryEnumerationOptions"/> flags that specify how the directory is to be enumerated.</param>
      /// <returns>The counted number of file system objects.</returns>
      /// <exception cref="System.UnauthorizedAccessException">An exception is thrown case of access errors.</exception>
      [SecurityCritical]
      public static long CountFileSystemObjects(string path, string searchPattern, DirectoryEnumerationOptions directoryEnumerationOptions)
      {
         return EnumerateFileSystemEntryInfosInternal<string>(null, path, searchPattern, directoryEnumerationOptions, PathFormat.Relative).Count();
      }

      #region Transacted

      #region IsFullPath

      /// <summary>[AlphaFS] Counts file system objects: files, folders or both) in a given directory.</summary>
      /// <param name="transaction">The transaction.</param>
      /// <param name="path">The directory path.</param>
      /// <param name="directoryEnumerationOptions"><see cref="DirectoryEnumerationOptions"/> flags that specify how the directory is to be enumerated.</param>
      /// <param name="pathFormat">Indicates the format of the path parameter(s).</param>
      /// <returns>The counted number of file system objects.</returns>
      /// <exception cref="System.UnauthorizedAccessException">An exception is thrown case of access errors.</exception>
      [SecurityCritical]
      public static long CountFileSystemObjects(KernelTransaction transaction, string path, DirectoryEnumerationOptions directoryEnumerationOptions, PathFormat pathFormat)
      {
         return EnumerateFileSystemEntryInfosInternal<string>(transaction, path, Path.WildcardStarMatchAll, directoryEnumerationOptions, pathFormat).Count();
      }

      /// <summary>[AlphaFS] Counts file system objects: files, folders or both) in a given directory.</summary>
      /// <param name="transaction">The transaction.</param>
      /// <param name="path">The directory path.</param>
      /// <param name="searchPattern">
      /// <para>The search string to match against the names of directories in path. This parameter can contain a</para>
      /// <para>combination of valid literal path and wildcard (<see cref="Path.WildcardStarMatchAll"/> and <see cref="Path.WildcardQuestion"/>)</para>
      /// <para>characters, but does not support regular expressions.</para>
      /// </param>
      /// <param name="directoryEnumerationOptions"><see cref="DirectoryEnumerationOptions"/> flags that specify how the directory is to be enumerated.</param>
      /// <param name="pathFormat">Indicates the format of the path parameter(s).</param>
      /// <returns>The counted number of file system objects.</returns>
      /// <exception cref="System.UnauthorizedAccessException">An exception is thrown case of access errors.</exception>
      [SecurityCritical]
      public static long CountFileSystemObjects(KernelTransaction transaction, string path, string searchPattern, DirectoryEnumerationOptions directoryEnumerationOptions, PathFormat pathFormat)
      {
         return EnumerateFileSystemEntryInfosInternal<string>(transaction, path, searchPattern, directoryEnumerationOptions, pathFormat).Count();
      }

      #endregion // IsFullPath

      /// <summary>[AlphaFS] Counts file system objects: files, folders or both) in a given directory.</summary>
      /// <param name="transaction">The transaction.</param>
      /// <param name="path">The directory path.</param>
      /// <param name="directoryEnumerationOptions"><see cref="DirectoryEnumerationOptions"/> flags that specify how the directory is to be enumerated.</param>
      /// <returns>The counted number of file system objects.</returns>
      /// <exception cref="System.UnauthorizedAccessException">An exception is thrown case of access errors.</exception>
      [SecurityCritical]
      public static long CountFileSystemObjects(KernelTransaction transaction, string path, DirectoryEnumerationOptions directoryEnumerationOptions)
      {
         return EnumerateFileSystemEntryInfosInternal<string>(transaction, path, Path.WildcardStarMatchAll, directoryEnumerationOptions, PathFormat.Relative).Count();
      }

      /// <summary>[AlphaFS] Counts file system objects: files, folders or both) in a given directory.</summary>
      /// <param name="transaction">The transaction.</param>
      /// <param name="path">The directory path.</param>
      /// <param name="searchPattern">
      /// <para>The search string to match against the names of directories in path. This parameter can contain a</para>
      /// <para>combination of valid literal path and wildcard (<see cref="Path.WildcardStarMatchAll"/> and <see cref="Path.WildcardQuestion"/>)</para>
      /// <para>characters, but does not support regular expressions.</para>
      /// </param>
      /// <param name="directoryEnumerationOptions"><see cref="DirectoryEnumerationOptions"/> flags that specify how the directory is to be enumerated.</param>
      /// <returns>The counted number of file system objects.</returns>
      /// <exception cref="System.UnauthorizedAccessException">An exception is thrown case of access errors.</exception>
      [SecurityCritical]
      public static long CountFileSystemObjects(KernelTransaction transaction, string path, string searchPattern, DirectoryEnumerationOptions directoryEnumerationOptions)
      {
         return EnumerateFileSystemEntryInfosInternal<string>(transaction, path, searchPattern, directoryEnumerationOptions, PathFormat.Relative).Count();
      }

      #endregion // Transacted

      #endregion // CountFileSystemObjects

      #region DisableCompression

      #region IsFullPath

      /// <summary>[AlphaFS] Disables NTFS compression of the specified directory and the files in it.</summary>
      /// <param name="path">A path to a directory to decompress.</param>
      /// <param name="pathFormat">Indicates the format of the path parameter(s).</param>
      /// <remarks>This method disables the directory-compression attribute. It will not decompress the current contents of the directory.
      /// However, newly created files and directories will be uncompressed.</remarks>
      [SecurityCritical]
      public static void DisableCompression(string path, PathFormat pathFormat)
      {
         Device.ToggleCompressionInternal(true, null, path, false, pathFormat);
      }

      #endregion // IsFullPath

      /// <summary>[AlphaFS] Disables NTFS compression of the specified directory and the files in it.</summary>
      /// <param name="path">A path to a directory to decompress.</param>
      /// <remarks>This method disables the directory-compression attribute. It will not decompress the current contents of the directory.
      /// However, newly created files and directories will be uncompressed.</remarks>
      [SecurityCritical]
      public static void DisableCompression(string path)
      {
         Device.ToggleCompressionInternal(true, null, path, false, PathFormat.Relative);
      }

      #region Transacted

      #region IsFullPath

      /// <summary>[AlphaFS] Disables NTFS compression of the specified directory and the files in it.</summary>
      /// <param name="transaction">The transaction.</param>
      /// <param name="pathFormat">Indicates the format of the path parameter(s).</param>
      /// <param name="path">A path to a directory to decompress.</param>
      /// <remarks>This method disables the directory-compression attribute. It will not decompress the current contents of the directory.
      /// However, newly created files and directories will be uncompressed.</remarks>
      [SecurityCritical]
      public static void DisableCompression(KernelTransaction transaction, string path, PathFormat pathFormat)
      {
         Device.ToggleCompressionInternal(true, transaction, path, false, pathFormat);
      }

      #endregion // IsFullPath

      /// <summary>[AlphaFS] Disables NTFS compression of the specified directory and the files in it.</summary>
      /// <param name="transaction">The transaction.</param>
      /// <param name="path">A path to a directory to decompress.</param>
      /// <remarks>This method disables the directory-compression attribute. It will not decompress the current contents of the directory.
      /// However, newly created files and directories will be uncompressed.</remarks>
      [SecurityCritical]
      public static void DisableCompression(KernelTransaction transaction, string path)
      {
         Device.ToggleCompressionInternal(true, transaction, path, false, PathFormat.Relative);
      }

      #endregion // Transacted

      #endregion // DisableCompression

      #region Decompress

      #region IsFullPath

      /// <summary>[AlphaFS] Decompresses an NTFS compressed directory.</summary>
      /// <param name="path">A path that describes a directory to decompress.</param>
      /// <param name="pathFormat">Indicates the format of the path parameter(s).</param>
      /// <remarks>This will only decompress the root items, non recursive.</remarks>
      [SecurityCritical]
      public static void Decompress(string path, PathFormat pathFormat)
      {
         CompressDecompressInternal(null, path, Path.WildcardStarMatchAll, DirectoryEnumerationOptions.FilesAndFolders, false, pathFormat);
      }

      /// <summary>[AlphaFS] Decompresses an NTFS compressed directory.</summary>
      /// <param name="path">A path that describes a directory to decompress.</param>
      /// <param name="directoryEnumerationOptions"><see cref="DirectoryEnumerationOptions"/> flags that specify how the directory is to be enumerated.</param>
      /// <param name="pathFormat">Indicates the format of the path parameter(s).</param>
      [SecurityCritical]
      public static void Decompress(string path, DirectoryEnumerationOptions directoryEnumerationOptions, PathFormat pathFormat)
      {
         CompressDecompressInternal(null, path, Path.WildcardStarMatchAll, directoryEnumerationOptions, false, pathFormat);
      }

      #endregion // IsFullPath

      /// <summary>[AlphaFS] Decompresses an NTFS compressed directory.</summary>
      /// <param name="path">A path that describes a directory to decompress.</param>
      /// <remarks>This will only decompress the root items, non recursive.</remarks>
      [SecurityCritical]
      public static void Decompress(string path)
      {
         CompressDecompressInternal(null, path, Path.WildcardStarMatchAll, DirectoryEnumerationOptions.FilesAndFolders, false, PathFormat.Relative);
      }

      /// <summary>[AlphaFS] Decompresses an NTFS compressed directory.</summary>
      /// <param name="path">A path that describes a directory to decompress.</param>
      /// <param name="directoryEnumerationOptions"><see cref="DirectoryEnumerationOptions"/> flags that specify how the directory is to be enumerated.</param>
      [SecurityCritical]
      public static void Decompress(string path, DirectoryEnumerationOptions directoryEnumerationOptions)
      {
         CompressDecompressInternal(null, path, Path.WildcardStarMatchAll, directoryEnumerationOptions, false, PathFormat.Relative);
      }

      #region Transacted

      #region IsFullPath

      /// <summary>[AlphaFS] Decompresses an NTFS compressed directory.</summary>
      /// <param name="transaction">The transaction.</param>
      /// <param name="path">A path that describes a directory to decompress.</param>
      /// <param name="pathFormat">Indicates the format of the path parameter(s).</param>
      /// <remarks>This will only decompress the root items, non recursive.</remarks>
      [SecurityCritical]
      public static void Decompress(KernelTransaction transaction, string path, PathFormat pathFormat)
      {
         CompressDecompressInternal(transaction, path, Path.WildcardStarMatchAll, DirectoryEnumerationOptions.FilesAndFolders, false, pathFormat);
      }

      /// <summary>[AlphaFS] Decompresses an NTFS compressed directory.</summary>
      /// <param name="transaction">The transaction.</param>
      /// <param name="path">A path that describes a directory to decompress.</param>
      /// <param name="directoryEnumerationOptions"><see cref="DirectoryEnumerationOptions"/> flags that specify how the directory is to be enumerated.</param>
      /// <param name="pathFormat">Indicates the format of the path parameter(s).</param>
      [SecurityCritical]
      public static void Decompress(KernelTransaction transaction, string path, DirectoryEnumerationOptions directoryEnumerationOptions, PathFormat pathFormat)
      {
         CompressDecompressInternal(transaction, path, Path.WildcardStarMatchAll, directoryEnumerationOptions, false, pathFormat);
      }

      #endregion // IsFullPath

      /// <summary>[AlphaFS] Decompresses an NTFS compressed directory.</summary>
      /// <param name="transaction">The transaction.</param>
      /// <param name="path">A path that describes a directory to decompress.</param>
      /// <remarks>This will only decompress the root items, non recursive.</remarks>
      [SecurityCritical]
      public static void Decompress(KernelTransaction transaction, string path)
      {
         CompressDecompressInternal(transaction, path, Path.WildcardStarMatchAll, DirectoryEnumerationOptions.FilesAndFolders, false, PathFormat.Relative);
      }

      /// <summary>[AlphaFS] Decompresses an NTFS compressed directory.</summary>
      /// <param name="transaction">The transaction.</param>
      /// <param name="path">A path that describes a directory to decompress.</param>
      /// <param name="directoryEnumerationOptions"><see cref="DirectoryEnumerationOptions"/> flags that specify how the directory is to be enumerated.</param>
      [SecurityCritical]
      public static void Decompress(KernelTransaction transaction, string path, DirectoryEnumerationOptions directoryEnumerationOptions)
      {
         CompressDecompressInternal(transaction, path, Path.WildcardStarMatchAll, directoryEnumerationOptions, false, PathFormat.Relative);
      }

      #endregion // Transacted

      #endregion // Decompress

      #region Decrypt

      #region IsFullPath

      /// <summary>[AlphaFS] Decrypts a directory that was encrypted by the current account using the Encrypt method.</summary>
      /// <param name="path">A path that describes a directory to decrypt.</param>
      /// <param name="pathFormat">Indicates the format of the path parameter(s).</param>
      [SecurityCritical]
      public static void Decrypt(string path, PathFormat pathFormat)
      {
         EncryptDecryptDirectoryInternal(path, false, false, pathFormat);
      }

      /// <summary>[AlphaFS] Decrypts a directory that was encrypted by the current account using the Encrypt method.</summary>
      /// <param name="path">A path that describes a directory to decrypt.</param>
      /// <param name="recursive"><see langword="true"/> to decrypt the directory recursively. <see langword="false"/> only decrypt files and directories in the root of <paramref name="path"/>.</param>
      /// <param name="pathFormat">Indicates the format of the path parameter(s).</param>
      [SecurityCritical]
      public static void Decrypt(string path, bool recursive, PathFormat pathFormat)
      {
         EncryptDecryptDirectoryInternal(path, false, recursive, pathFormat);
      }

      #endregion // IsFullPath

      /// <summary>[AlphaFS] Decrypts a directory that was encrypted by the current account using the Encrypt method.</summary>
      /// <param name="path">A path that describes a directory to decrypt.</param>
      [SecurityCritical]
      public static void Decrypt(string path)
      {
         EncryptDecryptDirectoryInternal(path, false, false, PathFormat.Relative);
      }

      /// <summary>[AlphaFS] Decrypts a directory that was encrypted by the current account using the Encrypt method.</summary>
      /// <param name="path">A path that describes a directory to decrypt.</param>
      /// <param name="recursive"><see langword="true"/> to decrypt the directory recursively. <see langword="false"/> only decrypt files and directories in the root of <paramref name="path"/>.</param>
      [SecurityCritical]
      public static void Decrypt(string path, bool recursive)
      {
         EncryptDecryptDirectoryInternal(path, false, recursive, PathFormat.Relative);
      }

      #endregion // Decrypt

      #region DeleteEmpty

      #region IsFullPath

      /// <summary>[AlphaFS] Deletes empty subdirectores from the specified directory.</summary>
      /// <param name="path">The name of the directory to remove empty subdirectories from.</param>
      /// <param name="recursive"><see langword="true"/> deletes empty subdirectories from this directory and its subdirectories.</param>
      /// <param name="ignoreReadOnly"><see langword="true"/> overrides read only <see cref="FileAttributes"/> of empty directories.</param>
      /// <param name="pathFormat">Indicates the format of the path parameter(s).</param>
      [SecurityCritical]
      public static void DeleteEmpty(string path, bool recursive, bool ignoreReadOnly, PathFormat pathFormat)
      {
         DeleteEmptyDirectoryInternal(null, null, path, recursive, ignoreReadOnly, true, pathFormat);
      }

      #endregion // IsFullPath

      /// <summary>[AlphaFS] Deletes empty subdirectores from the specified directory.</summary>
      /// <param name="path">The name of the directory to remove empty subdirectories from.</param>
      /// <param name="recursive"><see langword="true"/> deletes empty subdirectories from this directory and its subdirectories.</param>
      [SecurityCritical]
      public static void DeleteEmpty(string path, bool recursive)
      {
         DeleteEmptyDirectoryInternal(null, null, path, recursive, false, true, PathFormat.Relative);
      }

      /// <summary>[AlphaFS] Deletes empty subdirectores from the specified directory.</summary>
      /// <param name="path">The name of the directory to remove empty subdirectories from.</param>
      /// <param name="recursive"><see langword="true"/> deletes empty subdirectories from this directory and its subdirectories.</param>
      /// <param name="ignoreReadOnly"><see langword="true"/> overrides read only <see cref="FileAttributes"/> of empty directories.</param>
      [SecurityCritical]
      public static void DeleteEmpty(string path, bool recursive, bool ignoreReadOnly)
      {
         DeleteEmptyDirectoryInternal(null, null, path, recursive, ignoreReadOnly, true, PathFormat.Relative);
      }

      #region Transacted

      #region IsFullPath

      /// <summary>[AlphaFS] Deletes empty subdirectores from the specified directory.</summary>
      /// <param name="transaction">The transaction.</param>
      /// <param name="path">The name of the directory to remove empty subdirectories from.</param>
      /// <param name="recursive"><see langword="true"/> deletes empty subdirectories from this directory and its subdirectories.</param>
      /// <param name="ignoreReadOnly"><see langword="true"/> overrides read only <see cref="FileAttributes"/> of empty directories.</param>
      /// <param name="pathFormat">Indicates the format of the path parameter(s).</param>
      [SecurityCritical]
      public static void DeleteEmpty(KernelTransaction transaction, string path, bool recursive, bool ignoreReadOnly, PathFormat pathFormat)
      {
         DeleteEmptyDirectoryInternal(null, transaction, path, recursive, ignoreReadOnly, true, pathFormat);
      }

      #endregion // IsFullPath

      /// <summary>[AlphaFS] Deletes empty subdirectores from the specified directory.</summary>
      /// <param name="transaction">The transaction.</param>
      /// <param name="path">The name of the directory to remove empty subdirectories from.</param>
      /// <param name="recursive"><see langword="true"/> deletes empty subdirectories from this directory and its subdirectories.</param>
      [SecurityCritical]
      public static void DeleteEmpty(KernelTransaction transaction, string path, bool recursive)
      {
         DeleteEmptyDirectoryInternal(null, transaction, path, recursive, false, true, PathFormat.Relative);
      }

      /// <summary>[AlphaFS] Deletes empty subdirectores from the specified directory.</summary>
      /// <param name="transaction">The transaction.</param>
      /// <param name="path">The name of the directory to remove empty subdirectories from.</param>
      /// <param name="recursive"><see langword="true"/> deletes empty subdirectories from this directory and its subdirectories.</param>
      /// <param name="ignoreReadOnly"><see langword="true"/> overrides read only <see cref="FileAttributes"/> of empty directories.</param>
      [SecurityCritical]
      public static void DeleteEmpty(KernelTransaction transaction, string path, bool recursive, bool ignoreReadOnly)
      {
         DeleteEmptyDirectoryInternal(null, transaction, path, recursive, ignoreReadOnly, true, PathFormat.Relative);
      }

      #endregion // Transacted

      #endregion // DeleteEmpty

      #region DisableEncryption

      #region IsFullPath

      /// <summary>[AlphaFS] Disables encryption of the specified directory and the files in it. It does not affect encryption of subdirectories below the indicated directory.</summary>
      /// <param name="path">The name of the directory for which to disable encryption.</param>
      /// <param name="pathFormat">Indicates the format of the path parameter(s).</param>
      /// <remarks>This method will create/change the file "Desktop.ini" and wil set Encryption value: "Disable=0"</remarks>
      [SecurityCritical]
      public static void DisableEncryption(string path, PathFormat pathFormat)
      {
         EnableDisableEncryptionInternal(path, false, pathFormat);
      }

      #endregion // IsFullPath

      /// <summary>[AlphaFS] Disables encryption of the specified directory and the files in it. It does not affect encryption of subdirectories below the indicated directory.</summary>
      /// <param name="path">The name of the directory for which to disable encryption.</param>
      /// <remarks>This method will create/change the file "Desktop.ini" and wil set Encryption value: "Disable=0"</remarks>
      [SecurityCritical]
      public static void DisableEncryption(string path)
      {
         EnableDisableEncryptionInternal(path, false, PathFormat.Relative);
      }

      #endregion // DisableEncryption

      #region EnableCompression

      #region IsFullPath

      /// <summary>[AlphaFS] Enables NTFS compression of the specified directory and the files in it.</summary>
      /// <param name="path">A path to a directory to compress.</param>
      /// <param name="pathFormat">Indicates the format of the path parameter(s).</param>
      /// <remarks>This method enables the directory-compression attribute. It will not compress the current contents of the directory.
      /// However, newly created files and directories will be compressed.</remarks>
      [SecurityCritical]
      public static void EnableCompression(string path, PathFormat pathFormat)
      {
         Device.ToggleCompressionInternal(true, null, path, true, pathFormat);
      }

      #endregion // IsFullPath

      /// <summary>[AlphaFS] Enables NTFS compression of the specified directory and the files in it.</summary>
      /// <param name="path">A path to a directory to compress.</param>
      /// <remarks>This method enables the directory-compression attribute. It will not compress the current contents of the directory.
      /// However, newly created files and directories will be compressed.</remarks>
      [SecurityCritical]
      public static void EnableCompression(string path)
      {
         Device.ToggleCompressionInternal(true, null, path, true, PathFormat.Relative);
      }

      #region Transacted

      #region IsFullPath

      /// <summary>[AlphaFS] Enables NTFS compression of the specified directory and the files in it.</summary>
      /// <param name="transaction">The transaction.</param>
      /// <param name="path">A path to a directory to compress.</param>
      /// <param name="pathFormat">Indicates the format of the path parameter(s).</param>
      /// <remarks>This method enables the directory-compression attribute. It will not compress the current contents of the directory.
      /// However, newly created files and directories will be compressed.</remarks>
      [SecurityCritical]
      public static void EnableCompression(KernelTransaction transaction, string path, PathFormat pathFormat)
      {
         Device.ToggleCompressionInternal(true, transaction, path, true, pathFormat);
      }

      #endregion // IsFullPath

      /// <summary>[AlphaFS] Enables NTFS compression of the specified directory and the files in it.</summary>
      /// <param name="transaction">The transaction.</param>
      /// <param name="path">A path to a directory to compress.</param>
      /// <remarks>This method enables the directory-compression attribute. It will not compress the current contents of the directory.
      /// However, newly created files and directories will be compressed.</remarks>
      [SecurityCritical]
      public static void EnableCompression(KernelTransaction transaction, string path)
      {
         Device.ToggleCompressionInternal(true, transaction, path, true, PathFormat.Relative);
      }

      #endregion // Transacted

      #endregion //EnableCompression

      #region EnableEncryption

      #region IsFullPath

      /// <summary>[AlphaFS] Enables encryption of the specified directory and the files in it. It does not affect encryption of subdirectories below the indicated directory.</summary>
      /// <param name="path">The name of the directory for which to enable encryption.</param>
      /// <param name="pathFormat">Indicates the format of the path parameter(s).</param>
      /// <remarks>This method will create/change the file "Desktop.ini" and wil set Encryption value: "Disable=1"</remarks>
      [SecurityCritical]
      public static void EnableEncryption(string path, PathFormat pathFormat)
      {
         EnableDisableEncryptionInternal(path, true, pathFormat);
      }

      #endregion // IsFullPath

      /// <summary>[AlphaFS] Enables encryption of the specified directory and the files in it. It does not affect encryption of subdirectories below the indicated directory.</summary>
      /// <param name="path">The name of the directory for which to enable encryption.</param>
      /// <remarks>This method will create/change the file "Desktop.ini" and wil set Encryption value: "Disable=1"</remarks>
      [SecurityCritical]
      public static void EnableEncryption(string path)
      {
         EnableDisableEncryptionInternal(path, true, PathFormat.Relative);
      }

      #endregion // EnableEncryption

      #region EnumerateFileIdBothDirectoryInfo

      #region IsFullPath

      /// <summary>[AlphaFS] Retrieves information about files in the directory specified by <paramref name="path"/> in <see cref="FileShare.ReadWrite"/> mode.</summary>
      /// <param name="path">A path to a directory from which to retrieve information.</param>
      /// <param name="pathFormat">Indicates the format of the path parameter(s).</param>
      /// <returns>An enumeration of <see cref="FileIdBothDirectoryInfo"/> records for each file system entry in the specified diretory.</returns>
      [SecurityCritical]
      public static IEnumerable<FileIdBothDirectoryInfo> EnumerateFileIdBothDirectoryInfo(string path, PathFormat pathFormat)
      {
         return EnumerateFileIdBothDirectoryInfoInternal(null, null, path, FileShare.ReadWrite, false, pathFormat);
      }

      /// <summary>[AlphaFS] Retrieves information about files in the directory specified by <paramref name="path"/> in specified <see cref="FileShare"/> mode.</summary>
      /// <param name="path">A path to a directory from which to retrieve information.</param>
      /// <param name="shareMode">The <see cref="FileShare"/> mode with which to open a handle to the directory.</param>
      /// <param name="pathFormat">Indicates the format of the path parameter(s).</param>
      /// <returns>An enumeration of <see cref="FileIdBothDirectoryInfo"/> records for each file system entry in the specified diretory.</returns>      
      [SecurityCritical]
      public static IEnumerable<FileIdBothDirectoryInfo> EnumerateFileIdBothDirectoryInfo(string path, FileShare shareMode, PathFormat pathFormat)
      {
         return EnumerateFileIdBothDirectoryInfoInternal(null, null, path, shareMode, false, pathFormat);
      }

      #endregion // IsFullPath

      /// <summary>[AlphaFS] Retrieves information about files in the directory specified by <paramref name="path"/> in <see cref="FileShare.ReadWrite"/> mode.</summary>
      /// <param name="path">A path to a directory from which to retrieve information.</param>
      /// <returns>An enumeration of <see cref="FileIdBothDirectoryInfo"/> records for each file system entry in the specified diretory.</returns>
      [SecurityCritical]
      public static IEnumerable<FileIdBothDirectoryInfo> EnumerateFileIdBothDirectoryInfo(string path)
      {
         return EnumerateFileIdBothDirectoryInfoInternal(null, null, path, FileShare.ReadWrite, false, PathFormat.Relative);
      }

      /// <summary>[AlphaFS] Retrieves information about files in the directory specified by <paramref name="path"/> in specified <see cref="FileShare"/> mode.</summary>
      /// <param name="path">A path to a directory from which to retrieve information.</param>
      /// <param name="shareMode">The <see cref="FileShare"/> mode with which to open a handle to the directory.</param>
      /// <returns>An enumeration of <see cref="FileIdBothDirectoryInfo"/> records for each file system entry in the specified diretory.</returns>      
      [SecurityCritical]
      public static IEnumerable<FileIdBothDirectoryInfo> EnumerateFileIdBothDirectoryInfo(string path, FileShare shareMode)
      {
         return EnumerateFileIdBothDirectoryInfoInternal(null, null, path, shareMode, false, PathFormat.Relative);
      }

      /// <summary>[AlphaFS] Retrieves information about files in the directory handle specified.</summary>
      /// <param name="handle">An open handle to the directory from which to retrieve information.</param>
      /// <returns>An IEnumerable of <see cref="FileIdBothDirectoryInfo"/> records for each file system entry in the specified diretory.</returns>    
      [SecurityCritical]
      public static IEnumerable<FileIdBothDirectoryInfo> EnumerateFileIdBothDirectoryInfo(SafeFileHandle handle)
      {
         // FileShare has no effect since a handle is already opened.
         return EnumerateFileIdBothDirectoryInfoInternal(null, handle, null, FileShare.ReadWrite, false, PathFormat.Relative);
      }

      #region Transacted

      #region IsFullPath

      /// <summary>[AlphaFS] Retrieves information about files in the directory specified by <paramref name="path"/> in <see cref="FileShare.ReadWrite"/> mode.</summary>
      /// <param name="transaction">The transaction.</param>
      /// <param name="path">A path to a directory from which to retrieve information.</param>
      /// <param name="pathFormat">Indicates the format of the path parameter(s).</param>
      /// <returns>An enumeration of <see cref="FileIdBothDirectoryInfo"/> records for each file system entry in the specified diretory.</returns>
      [SecurityCritical]
      public static IEnumerable<FileIdBothDirectoryInfo> EnumerateFileIdBothDirectoryInfo(KernelTransaction transaction, string path, PathFormat pathFormat)
      {
         return EnumerateFileIdBothDirectoryInfoInternal(transaction, null, path, FileShare.ReadWrite, false, pathFormat);
      }

      /// <summary>[AlphaFS] Retrieves information about files in the directory specified by <paramref name="path"/> in specified <see cref="FileShare"/> mode.</summary>
      /// <param name="transaction">The transaction.</param>
      /// <param name="path">A path to a directory from which to retrieve information.</param>
      /// <param name="shareMode">The <see cref="FileShare"/> mode with which to open a handle to the directory.</param>
      /// <param name="pathFormat">Indicates the format of the path parameter(s).</param>
      /// <returns>An enumeration of <see cref="FileIdBothDirectoryInfo"/> records for each file system entry in the specified diretory.</returns>
      [SecurityCritical]
      public static IEnumerable<FileIdBothDirectoryInfo> EnumerateFileIdBothDirectoryInfo(KernelTransaction transaction, string path, FileShare shareMode, PathFormat pathFormat)
      {
         return EnumerateFileIdBothDirectoryInfoInternal(transaction, null, path, shareMode, false, pathFormat);
      }

      #endregion // IsFullPath

      /// <summary>[AlphaFS] Retrieves information about files in the directory specified by <paramref name="path"/> in <see cref="FileShare.ReadWrite"/> mode.</summary>
      /// <param name="transaction">The transaction.</param>
      /// <param name="path">A path to a directory from which to retrieve information.</param>
      /// <returns>An enumeration of <see cref="FileIdBothDirectoryInfo"/> records for each file system entry in the specified diretory.</returns>
      [SecurityCritical]
      public static IEnumerable<FileIdBothDirectoryInfo> EnumerateFileIdBothDirectoryInfo(KernelTransaction transaction, string path)
      {
         return EnumerateFileIdBothDirectoryInfoInternal(transaction, null, path, FileShare.ReadWrite, false, PathFormat.Relative);
      }

      /// <summary>[AlphaFS] Retrieves information about files in the directory specified by <paramref name="path"/> in specified <see cref="FileShare"/> mode.</summary>
      /// <param name="transaction">The transaction.</param>
      /// <param name="path">A path to a directory from which to retrieve information.</param>
      /// <param name="shareMode">The <see cref="FileShare"/> mode with which to open a handle to the directory.</param>
      /// <returns>An enumeration of <see cref="FileIdBothDirectoryInfo"/> records for each file system entry in the specified diretory.</returns>
      [SecurityCritical]
      public static IEnumerable<FileIdBothDirectoryInfo> EnumerateFileIdBothDirectoryInfo(KernelTransaction transaction, string path, FileShare shareMode)
      {
         return EnumerateFileIdBothDirectoryInfoInternal(transaction, null, path, shareMode, false, PathFormat.Relative);
      }

      #endregion // Transacted

      #endregion // EnumerateFileIdBothDirectoryInfo

      #region EnumerateFileSystemEntryInfos

      #region IsFullPath

      /// <summary>
      /// [AlphaFS] Returns an enumerable collection of file system entries in a specified path.
      /// </summary>
      /// <typeparam name="T"></typeparam>
      /// <param name="path">The directory to search.</param>
      /// <param name="pathFormat">Indicates the format of the path parameter(s).</param>
      /// <returns>
      ///    The matching file system entries. The type of the items is determined by the type <typeparamref name="T"/>.
      /// </returns>
      /// <exception cref="ArgumentException"></exception>
      /// <exception cref="ArgumentNullException"></exception>
      [SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Infos")]
      [SecurityCritical]
      public static IEnumerable<T> EnumerateFileSystemEntryInfos<T>(string path, PathFormat pathFormat)
      {
         return EnumerateFileSystemEntryInfosInternal<T>(null, path, Path.WildcardStarMatchAll, DirectoryEnumerationOptions.FilesAndFolders, pathFormat);
      }

      /// <summary>
      ///   [AlphaFS] Returns an enumerable collection of file system entries that match a
      ///   <paramref name="searchPattern"/> in a specified path.
      /// </summary>
      /// <typeparam name="T">
      ///   The type to return. This may be one of the following types:
      ///   <list type="definition">
      ///   <item>
      ///      <term>
      ///        <see cref="FileSystemInfo"/>
      ///      </term>
      ///      <description>
      ///        This method will return instances of <see cref="DirectoryInfo"/>,
      ///        <see cref="FileInfo"/> and <see cref="FileSystemEntryInfo"/> instances.
      ///      </description>
      ///   </item>
      ///   <item>
      ///      <term>
      ///        <see cref="string"/>
      ///      </term>
      ///      <description>
      ///        This method will return the full path of each item.
      ///      </description>
      ///   </item>
      ///   </list>
      /// </typeparam>
      /// <param name="path">The directory to search.</param>
      /// <param name="searchPattern">
      ///   <para>The search string to match against the names of directories in
      ///   <paramref name="path"/>. This parameter can contain a combination of valid literal path and
      ///   wildcard
      ///   (<see cref="Path.WildcardStarMatchAll"/> and <see cref="Path.WildcardQuestion"/>)
      ///   characters, but doesn't support regular expressions.</para>
      /// </param>
      /// <param name="pathFormat">Indicates the format of the path parameter(s).</param>
      /// <returns>
      ///    The matching file system entries. The type of the items is determined by the type <typeparamref name="T"/>.
      /// </returns>
      [SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Infos")]
      [SecurityCritical]
      public static IEnumerable<T> EnumerateFileSystemEntryInfos<T>(string path, string searchPattern, PathFormat pathFormat)
      {
         return EnumerateFileSystemEntryInfosInternal<T>(null, path, searchPattern, DirectoryEnumerationOptions.FilesAndFolders, pathFormat);
      }

      /// <summary>
      ///   [AlphaFS] Returns an enumerable collection of file system entries that match a
      ///   <paramref name="searchPattern"/> in a specified path using
      ///   <see cref="DirectoryEnumerationOptions"/>.
      /// </summary>
      /// <typeparam name="T">
      ///   The type to return. This may be one of the following types:
      ///   <list type="definition">
      ///   <item>
      ///      <term>
      ///        <see cref="FileSystemInfo"/>
      ///      </term>
      ///      <description>
      ///        This method will return instances of <see cref="DirectoryInfo"/>,
      ///        <see cref="FileInfo"/> and <see cref="FileSystemEntryInfo"/> instances.
      ///      </description>
      ///   </item>
      ///   <item>
      ///      <term>
      ///        <see cref="string"/>
      ///      </term>
      ///      <description>
      ///        This method will return the full path of each item.
      ///      </description>
      ///   </item>
      ///   </list>
      /// </typeparam>
      /// <param name="path">The directory to search.</param>
      /// <param name="searchPattern">
      ///   <para>The search string to match against the names of directories in
      ///   <paramref name="path"/>. This parameter can contain a</para>
      ///   <para>combination of valid literal path and wildcard
      ///   (<see cref="Path.WildcardStarMatchAll"/> and <see cref="Path.WildcardQuestion"/>)</para>
      ///   <para>characters, but doesn't support regular expressions.</para>
      /// </param>
      /// <param name="directoryEnumerationOptions">
      ///   <see cref="DirectoryEnumerationOptions"/> flags that specify how the directory is to be
      ///   enumerated.
      /// </param>
      /// <param name="pathFormat">Indicates the format of the path parameter(s).</param>
      /// <returns>
      ///    The matching file system entries. The type of the items is determined by the type <typeparamref name="T"/>.
      /// </returns>
      /// <exception cref="ArgumentException">.</exception>
      /// <exception cref="ArgumentNullException">.</exception>
      [SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Infos")]
      [SecurityCritical]
      public static IEnumerable<T> EnumerateFileSystemEntryInfos<T>(string path, string searchPattern, DirectoryEnumerationOptions directoryEnumerationOptions, PathFormat pathFormat)
      {
         return EnumerateFileSystemEntryInfosInternal<T>(null, path, searchPattern, directoryEnumerationOptions, pathFormat);
      }

      #endregion // IsFullPath

      /// <summary>
      /// [AlphaFS] Returns an enumerable collection of file system entries in a specified path.
      /// </summary>
      /// <typeparam name="T">
      ///    The type to return. This may be one of the following types:
      ///    <list type="definition">
      ///    <item>
      ///       <term>
      ///         <see cref="FileSystemInfo"/>
      ///       </term>
      ///       <description>
      ///         This method will return instances of <see cref="DirectoryInfo"/>, <see cref="FileInfo"/> and <see cref="FileSystemEntryInfo"/> instances.
      ///       </description>
      ///    </item>
      ///    <item>
      ///       <term>
      ///         <see cref="string"/>
      ///       </term>
      ///       <description>
      ///         This method will return the full path of each item.
      ///       </description>
      ///    </item>
      /// </list>
      /// </typeparam>
      /// <param name="path">The directory to search.</param>
      /// <returns>
      ///    The matching file system entries. The type of the items is determined by the type <typeparamref name="T"/>.
      /// </returns>
      /// <exception cref="ArgumentException"></exception>
      /// <exception cref="ArgumentNullException"></exception>
      [SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Infos")]
      [SecurityCritical]
      public static IEnumerable<T> EnumerateFileSystemEntryInfos<T>(string path)
      {
         return EnumerateFileSystemEntryInfosInternal<T>(null, path, Path.WildcardStarMatchAll, DirectoryEnumerationOptions.FilesAndFolders, PathFormat.Relative);
      }

      /// <summary>
      /// [AlphaFS] Returns an enumerable collection of file system entries that match a <paramref name="searchPattern" /> in a specified path.
      /// </summary>
      /// <typeparam name="T">
      ///    The type to return. This may be one of the following types:
      ///    <list type="definition">
      ///    <item>
      ///       <term>
      ///         <see cref="FileSystemInfo"/>
      ///       </term>
      ///       <description>
      ///         This method will return instances of <see cref="DirectoryInfo"/>, <see cref="FileInfo"/> and <see cref="FileSystemEntryInfo"/> instances.
      ///       </description>
      ///    </item>
      ///    <item>
      ///       <term>
      ///         <see cref="string"/>
      ///       </term>
      ///       <description>
      ///         This method will return the full path of each item.
      ///       </description>
      ///    </item>
      /// </list>
      /// </typeparam>
      /// <param name="path">The directory to search.</param>
      /// <param name="searchPattern"><para>The search string to match against the names of directories in <paramref name="path" />. This parameter can contain a</para>
      /// <para>combination of valid literal path and wildcard (<see cref="Path.WildcardStarMatchAll" /> and <see cref="Path.WildcardQuestion" />)</para>
      /// <para>characters, but doesn't support regular expressions.</para></param>
      /// <returns>
      ///    The matching file system entries. The type of the items is determined by the type <typeparamref name="T"/>.
      /// </returns>
      /// <exception cref="ArgumentException"></exception>
      /// <exception cref="ArgumentNullException"></exception>
      [SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Infos")]
      [SecurityCritical]
      public static IEnumerable<T> EnumerateFileSystemEntryInfos<T>(string path, string searchPattern)
      {
         return EnumerateFileSystemEntryInfosInternal<T>(null, path, searchPattern, DirectoryEnumerationOptions.FilesAndFolders, PathFormat.Relative);
      }

      /// <summary>
      ///   [AlphaFS] Returns an enumerable collection of file system entries that match a
      ///   <paramref name="searchPattern"/> in a specified path using
      ///   <see cref="DirectoryEnumerationOptions"/>.
      /// </summary>
      /// <typeparam name="T">
      ///   The type to return. This may be one of the following types:
      ///   <list type="definition">
      ///   <item>
      ///      <term>
      ///        <see cref="FileSystemInfo"/>
      ///      </term>
      ///      <description>
      ///        This method will return instances of <see cref="DirectoryInfo"/>,
      ///        <see cref="FileInfo"/> and <see cref="FileSystemEntryInfo"/> instances.
      ///      </description>
      ///   </item>
      ///   <item>
      ///      <term>
      ///        <see cref="string"/>
      ///      </term>
      ///      <description>
      ///        This method will return the full path of each item.
      ///      </description>
      ///   </item>
      ///   </list>
      /// </typeparam>
      /// <param name="path">The directory to search.</param>
      /// <param name="searchPattern">
      ///   The search string to match against the names of directories in
      ///   <paramref name="path"/>. This parameter can contain a
      ///   combination of valid literal path and wildcard (<see cref="Path.WildcardStarMatchAll"/> and
      ///   <see cref="Path.WildcardQuestion"/>)
      ///   characters, but doesn't support regular expressions.
      /// </param>
      /// <param name="directoryEnumerationOptions">
      ///   <see cref="DirectoryEnumerationOptions"/> flags that specify how the directory is to be
      ///   enumerated.
      /// </param>
      /// <returns>
      ///   The matching file system entries. The type of the items is determined by the type
      ///   <typeparamref name="T"/>.
      /// </returns>
      [SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Infos")]
      [SecurityCritical]
      public static IEnumerable<T> EnumerateFileSystemEntryInfos<T>(string path, string searchPattern, DirectoryEnumerationOptions directoryEnumerationOptions)
      {
         return EnumerateFileSystemEntryInfosInternal<T>(null, path, searchPattern, directoryEnumerationOptions, PathFormat.Relative);
      }

      #region Transacted

      #region IsFullPath

      /// <summary>[AlphaFS] Returns an enumerable collection of file system entries in a specified path.</summary>
      /// <typeparam name="T">
      ///    The type to return. This may be one of the following types:
      ///    <list type="definition">
      ///    <item>
      ///       <term>
      ///         <see cref="FileSystemInfo"/>
      ///       </term>
      ///       <description>
      ///         This method will return instances of <see cref="DirectoryInfo"/>, <see cref="FileInfo"/> and <see cref="FileSystemEntryInfo"/> instances.
      ///       </description>
      ///    </item>
      ///    <item>
      ///       <term>
      ///         <see cref="string"/>
      ///       </term>
      ///       <description>
      ///         This method will return the full path of each item.
      ///       </description>
      ///    </item>
      /// </list>
      /// </typeparam>
      /// <returns>
      ///   The matching file system entries. The type of the items is determined by the type
      ///   <typeparamref name="T"/>.
      /// </returns>
      /// <exception cref="ArgumentException"></exception>
      /// <exception cref="ArgumentNullException"></exception>
      /// <param name="transaction">The transaction.</param>
      /// <param name="path">The directory to search.</param>
      /// <param name="pathFormat">Indicates the format of the path parameter(s).</param>
      [SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Infos")]
      [SecurityCritical]
      public static IEnumerable<T> EnumerateFileSystemEntryInfos<T>(KernelTransaction transaction, string path, PathFormat pathFormat)
      {
         return EnumerateFileSystemEntryInfosInternal<T>(transaction, path, Path.WildcardStarMatchAll, DirectoryEnumerationOptions.FilesAndFolders, pathFormat);
      }

      /// <summary>[AlphaFS] Returns an enumerable collection of file system entries that match a <paramref name="searchPattern"/> in a specified path.
      /// </summary>
      /// <typeparam name="T">
      ///    The type to return. This may be one of the following types:
      ///    <list type="definition">
      ///    <item>
      ///       <term>
      ///         <see cref="FileSystemInfo"/>
      ///       </term>
      ///       <description>
      ///         This method will return instances of <see cref="DirectoryInfo"/>, <see cref="FileInfo"/> and <see cref="FileSystemEntryInfo"/> instances.
      ///       </description>
      ///    </item>
      ///    <item>
      ///       <term>
      ///         <see cref="string"/>
      ///       </term>
      ///       <description>
      ///         This method will return the full path of each item.
      ///       </description>
      ///    </item>
      /// </list>
      /// </typeparam>
      /// <returns>
      ///   The matching file system entries. The type of the items is determined by the type
      ///   <typeparamref name="T"/>.
      /// </returns>
      /// <exception cref="ArgumentException"></exception>
      /// <exception cref="ArgumentNullException"></exception>
      /// <param name="transaction">The transaction.</param>
      /// <param name="path">The directory to search.</param>
      /// <param name="searchPattern">
      /// <para>The search string to match against the names of directories in <paramref name="path"/>. This parameter can contain a</para>
      /// <para>combination of valid literal path and wildcard (<see cref="Path.WildcardStarMatchAll"/> and <see cref="Path.WildcardQuestion"/>)</para>
      /// <para>characters, but does not support regular expressions.</para>
      /// </param>
      /// <param name="pathFormat">Indicates the format of the path parameter(s).</param>
      [SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Infos")]
      [SecurityCritical]
      public static IEnumerable<T> EnumerateFileSystemEntryInfos<T>(KernelTransaction transaction, string path, string searchPattern, PathFormat pathFormat)
      {
         return EnumerateFileSystemEntryInfosInternal<T>(transaction, path, searchPattern, DirectoryEnumerationOptions.FilesAndFolders, pathFormat);
      }

      /// <summary>[AlphaFS] Returns an enumerable collection of file system entries that match a <paramref name="searchPattern"/> in a specified path using <see cref="DirectoryEnumerationOptions"/>.</summary>
      /// <typeparam name="T">
      ///    The type to return. This may be one of the following types:
      ///    <list type="definition">
      ///    <item>
      ///       <term>
      ///         <see cref="FileSystemInfo"/>
      ///       </term>
      ///       <description>
      ///         This method will return instances of <see cref="DirectoryInfo"/>, <see cref="FileInfo"/> and <see cref="FileSystemEntryInfo"/> instances.
      ///       </description>
      ///    </item>
      ///    <item>
      ///       <term>
      ///         <see cref="string"/>
      ///       </term>
      ///       <description>
      ///         This method will return the full path of each item.
      ///       </description>
      ///    </item>
      /// </list>
      /// </typeparam>
      /// <returns>
      ///   The matching file system entries. The type of the items is determined by the type
      ///   <typeparamref name="T"/>.
      /// </returns>
      /// <exception cref="ArgumentException"></exception>
      /// <exception cref="ArgumentNullException"></exception>
      /// <param name="transaction">The transaction.</param>
      /// <param name="path">The directory to search.</param>
      /// <param name="searchPattern">
      /// <para>The search string to match against the names of directories in <paramref name="path"/>. This parameter can contain a</para>
      /// <para>combination of valid literal path and wildcard (<see cref="Path.WildcardStarMatchAll"/> and <see cref="Path.WildcardQuestion"/>)</para>
      /// <para>characters, but does not support regular expressions.</para>
      /// </param>
      /// <param name="directoryEnumerationOptions"><see cref="DirectoryEnumerationOptions"/> flags that specify how the directory is to be enumerated.</param>
      /// <param name="pathFormat">Indicates the format of the path parameter(s).</param>
      [SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Infos")]
      [SecurityCritical]
      public static IEnumerable<T> EnumerateFileSystemEntryInfos<T>(KernelTransaction transaction, string path, string searchPattern, DirectoryEnumerationOptions directoryEnumerationOptions, PathFormat pathFormat)
      {
         return EnumerateFileSystemEntryInfosInternal<T>(transaction, path, searchPattern, directoryEnumerationOptions, pathFormat);
      }

      #endregion // IsFullPath

      /// <summary>[AlphaFS] Returns an enumerable collection of file system entries in a specified path.</summary>
      /// <typeparam name="T">
      ///    The type to return. This may be one of the following types:
      ///    <list type="definition">
      ///    <item>
      ///       <term>
      ///         <see cref="FileSystemInfo"/>
      ///       </term>
      ///       <description>
      ///         This method will return instances of <see cref="DirectoryInfo"/>, <see cref="FileInfo"/> and <see cref="FileSystemEntryInfo"/> instances.
      ///       </description>
      ///    </item>
      ///    <item>
      ///       <term>
      ///         <see cref="string"/>
      ///       </term>
      ///       <description>
      ///         This method will return the full path of each item.
      ///       </description>
      ///    </item>
      /// </list>
      /// </typeparam>
      /// <returns>
      ///   The matching file system entries. The type of the items is determined by the type
      ///   <typeparamref name="T"/>.
      /// </returns>
      /// <exception cref="ArgumentException"></exception>
      /// <exception cref="ArgumentNullException"></exception>
      /// <param name="transaction">The transaction.</param>
      /// <param name="path">The directory to search.</param>
      [SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Infos")]
      [SecurityCritical]
      public static IEnumerable<T> EnumerateFileSystemEntryInfos<T>(KernelTransaction transaction, string path)
      {
         return EnumerateFileSystemEntryInfosInternal<T>(transaction, path, Path.WildcardStarMatchAll, DirectoryEnumerationOptions.FilesAndFolders, PathFormat.Relative);
      }

      /// <summary>[AlphaFS] Returns an enumerable collection of file system entries that match a <paramref name="searchPattern"/> in a specified path.</summary>
      /// <typeparam name="T">
      ///    The type to return. This may be one of the following types:
      ///    <list type="definition">
      ///    <item>
      ///       <term>
      ///         <see cref="FileSystemInfo"/>
      ///       </term>
      ///       <description>
      ///         This method will return instances of <see cref="DirectoryInfo"/>, <see cref="FileInfo"/> and <see cref="FileSystemEntryInfo"/> instances.
      ///       </description>
      ///    </item>
      ///    <item>
      ///       <term>
      ///         <see cref="string"/>
      ///       </term>
      ///       <description>
      ///         This method will return the full path of each item.
      ///       </description>
      ///    </item>
      /// </list>
      /// </typeparam>
      /// <returns>
      ///   The matching file system entries. The type of the items is determined by the type
      ///   <typeparamref name="T"/>.
      /// </returns>
      /// <exception cref="ArgumentException"></exception>
      /// <exception cref="ArgumentNullException"></exception>
      /// <param name="transaction">The transaction.</param>
      /// <param name="path">The directory to search.</param>
      /// <param name="searchPattern">
      /// <para>The search string to match against the names of directories in <paramref name="path"/>. This parameter can contain a</para>
      /// <para>combination of valid literal path and wildcard (<see cref="Path.WildcardStarMatchAll"/> and <see cref="Path.WildcardQuestion"/>)</para>
      /// <para>characters, but does not support regular expressions.</para>
      /// </param>
      [SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Infos")]
      [SecurityCritical]
      public static IEnumerable<T> EnumerateFileSystemEntryInfos<T>(KernelTransaction transaction, string path, string searchPattern)
      {
         return EnumerateFileSystemEntryInfosInternal<T>(transaction, path, searchPattern, DirectoryEnumerationOptions.FilesAndFolders, PathFormat.Relative);
      }

      /// <summary>[AlphaFS] Returns an enumerable collection of file system entries that match a <paramref name="searchPattern"/> in a specified path using <see cref="DirectoryEnumerationOptions"/>.</summary>
      /// <typeparam name="T">
      ///    The type to return. This may be one of the following types:
      ///    <list type="definition">
      ///    <item>
      ///       <term>
      ///         <see cref="FileSystemInfo"/>
      ///       </term>
      ///       <description>
      ///         This method will return instances of <see cref="DirectoryInfo"/>, <see cref="FileInfo"/> and <see cref="FileSystemEntryInfo"/> instances.
      ///       </description>
      ///    </item>
      ///    <item>
      ///       <term>
      ///         <see cref="string"/>
      ///       </term>
      ///       <description>
      ///         This method will return the full path of each item.
      ///       </description>
      ///    </item>
      /// </list>
      /// </typeparam>
      /// <returns>
      ///   The matching file system entries. The type of the items is determined by the type
      ///   <typeparamref name="T"/>.
      /// </returns>
      /// <exception cref="ArgumentException"></exception>
      /// <exception cref="ArgumentNullException"></exception>
      /// <param name="transaction">The transaction.</param>
      /// <param name="path">The directory to search.</param>
      /// <param name="searchPattern">
      /// <para>The search string to match against the names of directories in <paramref name="path"/>. This parameter can contain a</para>
      /// <para>combination of valid literal path and wildcard (<see cref="Path.WildcardStarMatchAll"/> and <see cref="Path.WildcardQuestion"/>)</para>
      /// <para>characters, but does not support regular expressions.</para>
      /// </param>
      /// <param name="directoryEnumerationOptions"><see cref="DirectoryEnumerationOptions"/> flags that specify how the directory is to be enumerated.</param>
      [SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Infos")]
      [SecurityCritical]
      public static IEnumerable<T> EnumerateFileSystemEntryInfos<T>(KernelTransaction transaction, string path, string searchPattern, DirectoryEnumerationOptions directoryEnumerationOptions)
      {
         return EnumerateFileSystemEntryInfosInternal<T>(transaction, path, searchPattern, directoryEnumerationOptions, PathFormat.Relative);
      }

      #endregion // Transacted

      #endregion // EnumerateFileSystemEntryInfos

      #region EnumerateLogicalDrives

      /// <summary>[AlphaFS] Enumerates the drive names of all logical drives on a computer.</summary>
      /// <param name="fromEnvironment">Retrieve logical drives as known by the Environment.</param>
      /// <param name="isReady">Retrieve only when accessible (IsReady) logical drives.</param>
      /// <returns>An IEnumerable of type <see cref="Alphaleonis.Win32.Filesystem.DriveInfo"/> that represents the logical drives on a computer.</returns>
      [SecurityCritical]
      public static IEnumerable<DriveInfo> EnumerateLogicalDrives(bool fromEnvironment, bool isReady)
      {
         return EnumerateLogicalDrivesInternal(fromEnvironment, isReady);
      }

      #endregion // EnumerateLogicalDrives

      #region EnumerateStreams

      #region IsFullPath

      /// <summary>[AlphaFS] Returns an enumerable collection of <see cref="AlternateDataStreamInfo"/> instances for the directory specified by <paramref name="path"/>.</summary>
      /// <param name="path">The file to search.</param>
      /// <param name="pathFormat">Indicates the format of the path parameter(s).</param>
      /// <returns>An enumerable collection of <see cref="AlternateDataStreamInfo"/> instances for the directory specified by <paramref name="path"/>.</returns>
      [SecurityCritical]
      public static IEnumerable<AlternateDataStreamInfo> EnumerateStreams(string path, PathFormat pathFormat)
      {
         return AlternateDataStreamInfo.EnumerateStreamsInternal(null, null, null, path, null, null, pathFormat);
      }

      /// <summary>[AlphaFS] Returns an enumerable collection of <see cref="AlternateDataStreamInfo"/> of type <see cref="StreamType"/> instances for the directory specified by <paramref name="path"/>.</summary>
      /// <param name="path">The file to search.</param>
      /// <param name="streamType">The type of stream to retrieve.</param>
      /// <param name="pathFormat">Indicates the format of the path parameter(s).</param>
      /// <returns>An enumerable collection of <see cref="AlternateDataStreamInfo"/> of type <see cref="StreamType"/> instances for the directory specified by <paramref name="path"/>.</returns>
      [SecurityCritical]
      public static IEnumerable<AlternateDataStreamInfo> EnumerateStreams(string path, StreamType streamType, PathFormat pathFormat)
      {
         return AlternateDataStreamInfo.EnumerateStreamsInternal(null, null, null, path, null, streamType, pathFormat);
      }

      #endregion // IsFullPath

      /// <summary>[AlphaFS] Returns an enumerable collection of <see cref="AlternateDataStreamInfo"/> instances for the directory specified by <paramref name="path"/>.</summary>
      /// <param name="path">The file to search.</param>
      /// <returns>An enumerable collection of <see cref="AlternateDataStreamInfo"/> instances for the directory specified by <paramref name="path"/>.</returns>
      [SecurityCritical]
      public static IEnumerable<AlternateDataStreamInfo> EnumerateStreams(string path)
      {
         return AlternateDataStreamInfo.EnumerateStreamsInternal(null, null, null, path, null, null, PathFormat.Relative);
      }

      /// <summary>[AlphaFS] Returns an enumerable collection of <see cref="AlternateDataStreamInfo"/> of type <see cref="StreamType"/> instances for the directory specified by <paramref name="path"/>.</summary>
      /// <param name="path">The file to search.</param>
      /// <param name="streamType">The type of stream to retrieve.</param>
      /// <returns>An enumerable collection of <see cref="AlternateDataStreamInfo"/> of type <see cref="StreamType"/> instances for the directory specified by <paramref name="path"/>.</returns>
      [SecurityCritical]
      public static IEnumerable<AlternateDataStreamInfo> EnumerateStreams(string path, StreamType streamType)
      {
         return AlternateDataStreamInfo.EnumerateStreamsInternal(null, null, null, path, null, streamType, PathFormat.Relative);
      }

      /// <summary>[AlphaFS] Returns an enumerable collection of <see cref="AlternateDataStreamInfo"/> instances for the handle specified by <paramref name="handle"/>.</summary>
      /// <param name="handle">A <see cref="SafeFileHandle"/> connected to the file from which to retrieve the information.</param>
      /// <returns>An enumerable collection of <see cref="AlternateDataStreamInfo"/> instances for the handle specified by <paramref name="handle"/>.</returns>
      [SecurityCritical]
      public static IEnumerable<AlternateDataStreamInfo> EnumerateStreams(SafeFileHandle handle)
      {
         return AlternateDataStreamInfo.EnumerateStreamsInternal(null, null, handle, null, null, null, PathFormat.LongFullPath);
      }

      #region Transacted

      #region IsFullPath

      /// <summary>[AlphaFS] Returns an enumerable collection of <see cref="AlternateDataStreamInfo"/> instances for the directory specified by <paramref name="path"/>.</summary>
      /// <param name="transaction">The transaction.</param>
      /// <param name="path">The file to search.</param>
      /// <param name="pathFormat">Indicates the format of the path parameter(s).</param>
      /// <returns>An enumerable collection of <see cref="AlternateDataStreamInfo"/> instances for the directory specified by <paramref name="path"/>.</returns>
      [SecurityCritical]
      public static IEnumerable<AlternateDataStreamInfo> EnumerateStreams(KernelTransaction transaction, string path, PathFormat pathFormat)
      {
         return AlternateDataStreamInfo.EnumerateStreamsInternal(null, transaction, null, path, null, null, pathFormat);
      }

      /// <summary>[AlphaFS] Returns an enumerable collection of <see cref="AlternateDataStreamInfo"/> of type <see cref="StreamType"/> instances for the directory specified by <paramref name="path"/>.</summary>
      /// <param name="transaction">The transaction.</param>
      /// <param name="path">The file to search.</param>
      /// <param name="streamType">The type of stream to retrieve.</param>
      /// <param name="pathFormat">Indicates the format of the path parameter(s).</param>
      /// <returns>An enumerable collection of <see cref="AlternateDataStreamInfo"/> of type <see cref="StreamType"/> instances for the directory specified by <paramref name="path"/>.</returns>
      [SecurityCritical]
      public static IEnumerable<AlternateDataStreamInfo> EnumerateStreams(KernelTransaction transaction, string path, StreamType streamType, PathFormat pathFormat)
      {
         return AlternateDataStreamInfo.EnumerateStreamsInternal(null, transaction, null, path, null, streamType, pathFormat);
      }

      #endregion // IsFullPath

      /// <summary>[AlphaFS] Returns an enumerable collection of <see cref="AlternateDataStreamInfo"/> instances for the directory specified by <paramref name="path"/>.</summary>
      /// <param name="transaction">The transaction.</param>
      /// <param name="path">The file to search.</param>
      /// <returns>An enumerable collection of <see cref="AlternateDataStreamInfo"/> instances for the directory specified by <paramref name="path"/>.</returns>
      [SecurityCritical]
      public static IEnumerable<AlternateDataStreamInfo> EnumerateStreams(KernelTransaction transaction, string path)
      {
         return AlternateDataStreamInfo.EnumerateStreamsInternal(null, transaction, null, path, null, null, PathFormat.Relative);
      }

      /// <summary>[AlphaFS] Returns an enumerable collection of <see cref="AlternateDataStreamInfo"/> of type <see cref="StreamType"/> instances for the directory specified by <paramref name="path"/>.</summary>
      /// <param name="transaction">The transaction.</param>
      /// <param name="path">The file to search.</param>
      /// <param name="streamType">The type of stream to retrieve.</param>
      /// <returns>An enumerable collection of <see cref="AlternateDataStreamInfo"/> of type <see cref="StreamType"/> instances for the directory specified by <paramref name="path"/>.</returns>
      [SecurityCritical]
      public static IEnumerable<AlternateDataStreamInfo> EnumerateStreams(KernelTransaction transaction, string path, StreamType streamType)
      {
         return AlternateDataStreamInfo.EnumerateStreamsInternal(null, transaction, null, path, null, streamType, PathFormat.Relative);
      }

      #endregion // Transacted

      #endregion // EnumerateStreams

      #region Encrypt

      #region IsFullPath

      /// <summary>[AlphaFS] Encrypts a directory so that only the account used to encrypt the directory can decrypt it.</summary>
      /// <param name="path">A path that describes a directory to encrypt.</param>
      /// <param name="pathFormat">Indicates the format of the path parameter(s).</param>
      [SecurityCritical]
      public static void Encrypt(string path, PathFormat pathFormat)
      {
         EncryptDecryptDirectoryInternal(path, true, false, pathFormat);
      }

      /// <summary>[AlphaFS] Encrypts a directory so that only the account used to encrypt the directory can decrypt it.</summary>
      /// <param name="path">A path that describes a directory to encrypt.</param>
      /// <param name="recursive"><see langword="true"/> to encrypt the directory recursively. <see langword="false"/> only encrypt files and directories in the root of <paramref name="path"/>.</param>
      /// <param name="pathFormat">Indicates the format of the path parameter(s).</param>
      [SecurityCritical]
      public static void Encrypt(string path, bool recursive, PathFormat pathFormat)
      {
         EncryptDecryptDirectoryInternal(path, true, recursive, pathFormat);
      }

      #endregion // IsFullPath

      /// <summary>[AlphaFS] Encrypts a directory so that only the account used to encrypt the directory can decrypt it.</summary>
      /// <param name="path">A path that describes a directory to encrypt.</param>
      [SecurityCritical]
      public static void Encrypt(string path)
      {
         EncryptDecryptDirectoryInternal(path, true, false, PathFormat.Relative);
      }

      /// <summary>[AlphaFS] Encrypts a directory so that only the account used to encrypt the directory can decrypt it.</summary>
      /// <param name="path">A path that describes a directory to encrypt.</param>
      /// <param name="recursive"><see langword="true"/> to encrypt the directory recursively. <see langword="false"/> only encrypt files and directories in the root of <paramref name="path"/>.</param>
      [SecurityCritical]
      public static void Encrypt(string path, bool recursive)
      {
         EncryptDecryptDirectoryInternal(path, true, recursive, PathFormat.Relative);
      }

      #endregion // Encrypt

      #region GetChangeTime

      #region IsFullPath

      /// <summary>Gets the change date and time of the specified directory.</summary>
      /// <param name="path">
      ///   The directory for which to obtain creation date and time information.
      /// </param>
      /// <param name="pathFormat">Indicates the format of the path parameter(s).</param>
      /// <returns>
      ///   A <see cref="System.DateTime"/> structure set to the change date and time for the specified
      ///   directory. This value is expressed in local time.
      /// </returns>
      [SecurityCritical]
      public static DateTime GetChangeTime(string path, PathFormat pathFormat)
      {
         return File.GetChangeTimeInternal(true, null, null, path, false, pathFormat);
      }

      #endregion // IsFullPath

      /// <summary>Gets the change date and time of the specified directory.</summary>
      /// <returns>A <see cref="System.DateTime"/> structure set to the change date and time for the specified directory. This value is expressed in local time.</returns>
      /// <param name="path">The directory for which to obtain creation date and time information.</param>
      [SecurityCritical]
      public static DateTime GetChangeTime(string path)
      {
         return File.GetChangeTimeInternal(true, null, null, path, false, PathFormat.Relative);
      }

      /// <summary>Gets the change date and time of the specified directory.</summary>
      /// <param name="safeHandle">
      ///   An open handle to the directory from which to retrieve information.
      /// </param>
      /// <returns>
      ///   A <see cref="System.DateTime"/> structure set to the change date and time for the specified
      ///   directory. This value is expressed in local time.
      /// </returns>
      [SecurityCritical]
      public static DateTime GetChangeTime(SafeFileHandle safeHandle)
      {
         return File.GetChangeTimeInternal(true, null, safeHandle, null, false, PathFormat.Relative);
      }

      #region Transacted

      #region IsFullPath

      /// <summary>Gets the change date and time of the specified directory.</summary>
      /// <returns>A <see cref="System.DateTime"/> structure set to the change date and time for the specified directory. This value is expressed in local time.</returns>
      /// <param name="transaction">The transaction.</param>
      /// <param name="path">The directory for which to obtain creation date and time information.</param>
      /// <param name="pathFormat">Indicates the format of the path parameter(s).</param>
      [SecurityCritical]
      public static DateTime GetChangeTime(KernelTransaction transaction, string path, PathFormat pathFormat)
      {
         return File.GetChangeTimeInternal(true, transaction, null, path, false, pathFormat);
      }

      #endregion // IsFullPath

      /// <summary>Gets the change date and time of the specified directory.</summary>
      /// <returns>A <see cref="System.DateTime"/> structure set to the change date and time for the specified directory. This value is expressed in local time.</returns>
      /// <param name="transaction">The transaction.</param>
      /// <param name="path">The directory for which to obtain creation date and time information.</param>
      [SecurityCritical]
      public static DateTime GetChangeTime(KernelTransaction transaction, string path)
      {
         return File.GetChangeTimeInternal(true, transaction, null, path, false, PathFormat.Relative);
      }

      #endregion // Transacted

      #endregion // GetChangeTime

      #region GetChangeTimeUtc

      #region IsFullPath

      /// <summary>Gets the change date and time, in Coordinated Universal Time (UTC) format, of the specified directory.</summary>
      /// <returns>A <see cref="System.DateTime"/> structure set to the change date and time for the specified directory. This value is expressed in UTC time.</returns>
      /// <param name="path">The file for which to obtain change date and time information, in Coordinated Universal Time (UTC) format.</param>
      /// <param name="pathFormat">Indicates the format of the path parameter(s).</param>
      [SecurityCritical]
      public static DateTime GetChangeTimeUtc(string path, PathFormat pathFormat)
      {
         return File.GetChangeTimeInternal(true, null, null, path, true, pathFormat);
      }

      #endregion // IsFullPath

      /// <summary>Gets the change date and time, in Coordinated Universal Time (UTC) format, of the specified directory.</summary>
      /// <returns>A <see cref="System.DateTime"/> structure set to the change date and time for the specified directory. This value is expressed in UTC time.</returns>
      /// <param name="path">The file for which to obtain change date and time information, in Coordinated Universal Time (UTC) format.</param>
      [SecurityCritical]
      public static DateTime GetChangeTimeUtc(string path)
      {
         return File.GetChangeTimeInternal(true, null, null, path, true, PathFormat.Relative);
      }

      /// <summary>
      ///   Gets the change date and time, in Coordinated Universal Time (UTC) format, of the specified
      ///   directory.
      /// </summary>
      /// <param name="safeHandle">
      ///   An open handle to the directory from which to retrieve information.
      /// </param>
      /// <returns>
      ///   A <see cref="System.DateTime"/> structure set to the change date and time for the specified
      ///   directory. This value is expressed in UTC time.
      /// </returns>
      [SecurityCritical]
      public static DateTime GetChangeTimeUtc(SafeFileHandle safeHandle)
      {
         return File.GetChangeTimeInternal(true, null, safeHandle, null, true, PathFormat.Relative);
      }

      #region Transacted

      #region IsFullPath

      /// <summary>Gets the change date and time, in Coordinated Universal Time (UTC) format, of the specified directory.</summary>
      /// <returns>A <see cref="System.DateTime"/> structure set to the change date and time for the specified directory. This value is expressed in UTC time.</returns>
      /// <param name="transaction">The transaction.</param>
      /// <param name="path">The file for which to obtain change date and time information, in Coordinated Universal Time (UTC) format.</param>
      /// <param name="pathFormat">Indicates the format of the path parameter(s).</param>
      [SecurityCritical]
      public static DateTime GetChangeTimeUtc(KernelTransaction transaction, string path, PathFormat pathFormat)
      {
         return File.GetChangeTimeInternal(true, transaction, null, path, true, pathFormat);
      }

      #endregion // IsFullPath

      /// <summary>Gets the change date and time, in Coordinated Universal Time (UTC) format, of the specified directory.</summary>
      /// <returns>A <see cref="System.DateTime"/> structure set to the change date and time for the specified directory. This value is expressed in UTC time.</returns>
      /// <param name="transaction">The transaction.</param>
      /// <param name="path">The file for which to obtain change date and time information, in Coordinated Universal Time (UTC) format.</param>
      [SecurityCritical]
      public static DateTime GetChangeTimeUtc(KernelTransaction transaction, string path)
      {
         return File.GetChangeTimeInternal(true, transaction, null, path, true, PathFormat.Relative);
      }

      #endregion // Transacted

      #endregion // GetChangeTimeUtc

      #region GetProperties

      #region IsFullPath

      /// <summary>[AlphaFS] Gets the properties of the particular directory without following any symbolic links or mount points.
      /// Properties include aggregated info from <see cref="FileAttributes"/> of each encountered file system object.
      /// Plus additional ones: Total, File, Size, Error
      /// <para><b>Total:</b> is the total number of enumerated objects.</para>
      /// <para><b>File:</b> is the total number of files. File is considered when object is neither <see cref="FileAttributes.Directory"/> nor <see cref="FileAttributes.ReparsePoint"/>.</para>
      /// <para><b>Size:</b> is the total size of enumerated objects.</para>
      /// <para><b>Error:</b> is the total number of errors encountered during enumeration.</para>
      /// </summary>
      /// <remarks><b>Directory:</b> is an object which has <see cref="FileAttributes.Directory"/> attribute without <see cref="FileAttributes.ReparsePoint"/> one.</remarks>
      /// <param name="path">The target directory.</param>
      /// <param name="pathFormat">Indicates the format of the path parameter(s).</param>
      /// <returns>A dictionary mapping the keys mentioned above to their respective aggregated values.</returns>
      [SecurityCritical]
      public static Dictionary<string, long> GetProperties(string path, PathFormat pathFormat)
      {
         return GetPropertiesInternal(null, path, DirectoryEnumerationOptions.FilesAndFolders, pathFormat);
      }

      /// <summary>[AlphaFS] Gets the properties of the particular directory without following any symbolic links or mount points.
      /// Properties include aggregated info from <see cref="FileAttributes"/> of each encountered file system object.
      /// Plus additional ones: Total, File, Size, Error
      /// <para><b>Total:</b> is the total number of enumerated objects.</para>
      /// <para><b>File:</b> is the total number of files. File is considered when object is neither <see cref="FileAttributes.Directory"/> nor <see cref="FileAttributes.ReparsePoint"/>.</para>
      /// <para><b>Size:</b> is the total size of enumerated objects.</para>
      /// <para><b>Error:</b> is the total number of errors encountered during enumeration.</para>
      /// </summary>
      /// <remarks><b>Directory:</b> is an object which has <see cref="FileAttributes.Directory"/> attribute without <see cref="FileAttributes.ReparsePoint"/> one.</remarks>
      /// <param name="path">The target directory.</param>
      /// <param name="directoryEnumerationOptions"><see cref="DirectoryEnumerationOptions"/> flags that specify how the directory is to be enumerated.</param>
      /// <param name="pathFormat">Indicates the format of the path parameter(s).</param>
      /// <returns>A dictionary mapping the keys mentioned above to their respective aggregated values.</returns>
      [SecurityCritical]
      public static Dictionary<string, long> GetProperties(string path, DirectoryEnumerationOptions directoryEnumerationOptions, PathFormat pathFormat)
      {
         return GetPropertiesInternal(null, path, directoryEnumerationOptions, pathFormat);
      }

      #endregion // IsFullPath

      /// <summary>[AlphaFS] Gets the properties of the particular directory without following any symbolic links or mount points.
      /// <para>Properties include aggregated info from <see cref="FileAttributes"/> of each encountered file system object,</para>
      /// <para>plus additional ones: Total, File, Size, Error</para>
      /// <para><b>Total:</b> is the total number of enumerated objects.</para>
      /// <para><b>File:</b> is the total number of files. File is considered when object is neither <see cref="FileAttributes.Directory"/> nor <see cref="FileAttributes.ReparsePoint"/>.</para>
      /// <para><b>Size:</b> is the total size of enumerated objects.</para>
      /// <para><b>Error:</b> is the total number of errors encountered during enumeration.</para>
      /// </summary>
      /// <remarks><b>Directory:</b> is an object which has <see cref="FileAttributes.Directory"/> attribute without <see cref="FileAttributes.ReparsePoint"/> one.</remarks>
      /// <param name="path">The target directory.</param>
      /// <returns>A dictionary mapping the keys mentioned above to their respective aggregated values.</returns>
      [SecurityCritical]
      public static Dictionary<string, long> GetProperties(string path)
      {
         return GetPropertiesInternal(null, path, DirectoryEnumerationOptions.FilesAndFolders, PathFormat.Relative);
      }

      /// <summary>[AlphaFS] Gets the properties of the particular directory without following any symbolic links or mount points.
      /// Properties include aggregated info from <see cref="FileAttributes"/> of each encountered file system object.
      /// Plus additional ones: Total, File, Size, Error
      /// <para><b>Total:</b> is the total number of enumerated objects.</para>
      /// <para><b>File:</b> is the total number of files. File is considered when object is neither <see cref="FileAttributes.Directory"/> nor <see cref="FileAttributes.ReparsePoint"/>.</para>
      /// <para><b>Size:</b> is the total size of enumerated objects.</para>
      /// <para><b>Error:</b> is the total number of errors encountered during enumeration.</para>
      /// </summary>
      /// <remarks><b>Directory:</b> is an object which has <see cref="FileAttributes.Directory"/> attribute without <see cref="FileAttributes.ReparsePoint"/> one.</remarks>
      /// <param name="path">The target directory.</param>
      /// <param name="directoryEnumerationOptions"><see cref="DirectoryEnumerationOptions"/> flags that specify how the directory is to be enumerated.</param>
      /// <returns>A dictionary mapping the keys mentioned above to their respective aggregated values.</returns>
      [SecurityCritical]
      public static Dictionary<string, long> GetProperties(string path, DirectoryEnumerationOptions directoryEnumerationOptions)
      {
         return GetPropertiesInternal(null, path, directoryEnumerationOptions, PathFormat.Relative);
      }

      #region Transacted

      #region IsFullPath

      /// <summary>[AlphaFS] Gets the properties of the particular directory without following any symbolic links or mount points.
      /// Properties include aggregated info from <see cref="FileAttributes"/> of each encountered file system object.
      /// Plus additional ones: Total, File, Size, Error
      /// <para><b>Total:</b> is the total number of enumerated objects.</para>
      /// <para><b>File:</b> is the total number of files. File is considered when object is neither <see cref="FileAttributes.Directory"/> nor <see cref="FileAttributes.ReparsePoint"/>.</para>
      /// <para><b>Size:</b> is the total size of enumerated objects.</para>
      /// <para><b>Error:</b> is the total number of errors encountered during enumeration.</para>
      /// </summary>
      /// <remarks><b>Directory:</b> is an object which has <see cref="FileAttributes.Directory"/> attribute without <see cref="FileAttributes.ReparsePoint"/> one.</remarks>
      /// <param name="transaction">The transaction.</param>
      /// <param name="path">The target directory.</param>
      /// <param name="pathFormat">Indicates the format of the path parameter(s).</param>
      /// <returns>A dictionary mapping the keys mentioned above to their respective aggregated values.</returns>
      [SecurityCritical]
      public static Dictionary<string, long> GetProperties(KernelTransaction transaction, string path, PathFormat pathFormat)
      {
         return GetPropertiesInternal(transaction, path, DirectoryEnumerationOptions.FilesAndFolders, pathFormat);
      }

      /// <summary>[AlphaFS] Gets the properties of the particular directory without following any symbolic links or mount points.
      /// Properties include aggregated info from <see cref="FileAttributes"/> of each encountered file system object.
      /// Plus additional ones: Total, File, Size, Error
      /// <para><b>Total:</b> is the total number of enumerated objects.</para>
      /// <para><b>File:</b> is the total number of files. File is considered when object is neither <see cref="FileAttributes.Directory"/> nor <see cref="FileAttributes.ReparsePoint"/>.</para>
      /// <para><b>Size:</b> is the total size of enumerated objects.</para>
      /// <para><b>Error:</b> is the total number of errors encountered during enumeration.</para>
      /// </summary>
      /// <remarks><b>Directory:</b> is an object which has <see cref="FileAttributes.Directory"/> attribute without <see cref="FileAttributes.ReparsePoint"/> one.</remarks>
      /// <param name="transaction">The transaction.</param>
      /// <param name="path">The target directory.</param>
      /// <param name="directoryEnumerationOptions"><see cref="DirectoryEnumerationOptions"/> flags that specify how the directory is to be enumerated.</param>
      /// <param name="pathFormat">Indicates the format of the path parameter(s).</param>
      /// <returns>A dictionary mapping the keys mentioned above to their respective aggregated values.</returns>
      [SecurityCritical]
      public static Dictionary<string, long> GetProperties(KernelTransaction transaction, string path, DirectoryEnumerationOptions directoryEnumerationOptions, PathFormat pathFormat)
      {
         return GetPropertiesInternal(transaction, path, directoryEnumerationOptions, pathFormat);
      }

      #endregion // IsFullPath

      /// <summary>[AlphaFS] Gets the properties of the particular directory without following any symbolic links or mount points.
      /// Properties include aggregated info from <see cref="FileAttributes"/> of each encountered file system object.
      /// Plus additional ones: Total, File, Size, Error
      /// <para><b>Total:</b> is the total number of enumerated objects.</para>
      /// <para><b>File:</b> is the total number of files. File is considered when object is neither <see cref="FileAttributes.Directory"/> nor <see cref="FileAttributes.ReparsePoint"/>.</para>
      /// <para><b>Size:</b> is the total size of enumerated objects.</para>
      /// <para><b>Error:</b> is the total number of errors encountered during enumeration.</para>
      /// </summary>
      /// <remarks><b>Directory:</b> is an object which has <see cref="FileAttributes.Directory"/> attribute without <see cref="FileAttributes.ReparsePoint"/> one.</remarks>
      /// <param name="transaction">The transaction.</param>
      /// <param name="path">The target directory.</param>
      /// <returns>A dictionary mapping the keys mentioned above to their respective aggregated values.</returns>
      [SecurityCritical]
      public static Dictionary<string, long> GetProperties(KernelTransaction transaction, string path)
      {
         return GetPropertiesInternal(transaction, path, DirectoryEnumerationOptions.FilesAndFolders, PathFormat.Relative);
      }

      /// <summary>[AlphaFS] Gets the properties of the particular directory without following any symbolic links or mount points.
      /// Properties include aggregated info from <see cref="FileAttributes"/> of each encountered file system object.
      /// Plus additional ones: Total, File, Size, Error
      /// <para><b>Total:</b> is the total number of enumerated objects.</para>
      /// <para><b>File:</b> is the total number of files. File is considered when object is neither <see cref="FileAttributes.Directory"/> nor <see cref="FileAttributes.ReparsePoint"/>.</para>
      /// <para><b>Size:</b> is the total size of enumerated objects.</para>
      /// <para><b>Error:</b> is the total number of errors encountered during enumeration.</para>
      /// </summary>
      /// <remarks><b>Directory:</b> is an object which has <see cref="FileAttributes.Directory"/> attribute without <see cref="FileAttributes.ReparsePoint"/> one.</remarks>
      /// <param name="transaction">The transaction.</param>
      /// <param name="path">The target directory.</param>
      /// <param name="directoryEnumerationOptions"><see cref="DirectoryEnumerationOptions"/> flags that specify how the directory is to be enumerated.</param>
      /// <returns>A dictionary mapping the keys mentioned above to their respective aggregated values.</returns>
      [SecurityCritical]
      public static Dictionary<string, long> GetProperties(KernelTransaction transaction, string path, DirectoryEnumerationOptions directoryEnumerationOptions)
      {
         return GetPropertiesInternal(transaction, path, directoryEnumerationOptions, PathFormat.Relative);
      }

      #endregion // Transacted

      #endregion // GetProperties

      #region GetStreamSize

      #region IsFullPath

      /// <summary>[AlphaFS] Retrieves the actual number of bytes of disk storage used by all data streams (NTFS ADS).</summary>
      /// <param name="path">The path to an existing directory.</param>
      /// <param name="pathFormat">Indicates the format of the path parameter(s).</param>
      /// <returns>The number of bytes used by all data streams.</returns>
      [SecurityCritical]
      public static long GetStreamSize(string path, PathFormat pathFormat)
      {
         return AlternateDataStreamInfo.GetStreamSizeInternal(true, null, null, path, null, null, pathFormat);
      }

      /// <summary>[AlphaFS] Retrieves the actual number of bytes of disk storage used by a named data streams (NTFS ADS).</summary>
      /// <param name="path">The path to an existing directory.</param>
      /// <param name="name">The name of the stream to retrieve.</param>
      /// <param name="pathFormat">Indicates the format of the path parameter(s).</param>
      /// <returns>The number of bytes used by a named stream.</returns>
      [SecurityCritical]
      public static long GetStreamSize(string path, string name, PathFormat pathFormat)
      {
         return AlternateDataStreamInfo.GetStreamSizeInternal(true, null, null, path, name, StreamType.Data, pathFormat);
      }

      /// <summary>[AlphaFS] Retrieves the actual number of bytes of disk storage used by a <see cref="StreamType"/> data streams (NTFS ADS).</summary>
      /// <param name="path">The path to an existing directory.</param>
      /// <param name="type">The <see cref="StreamType"/> of the stream to retrieve.</param>
      /// <param name="pathFormat">Indicates the format of the path parameter(s).</param>
      /// <returns>The number of bytes used by stream of type <see cref="StreamType"/>.</returns>
      [SecurityCritical]
      public static long GetStreamSize(string path, StreamType type, PathFormat pathFormat)
      {
         return AlternateDataStreamInfo.GetStreamSizeInternal(true, null, null, path, null, type, pathFormat);
      }

      #endregion // IsFullPath

      /// <summary>[AlphaFS] Retrieves the actual number of bytes of disk storage used by all data streams (NTFS ADS).</summary>
      /// <param name="path">The path to an existing directory.</param>
      /// <returns>The number of bytes used by all data streams.</returns>
      [SecurityCritical]
      public static long GetStreamSize(string path)
      {
         return AlternateDataStreamInfo.GetStreamSizeInternal(true, null, null, path, null, null, PathFormat.Relative);
      }

      /// <summary>[AlphaFS] Retrieves the actual number of bytes of disk storage used by a named data streams (NTFS ADS).</summary>
      /// <param name="path">The path to an existing directory.</param>
      /// <param name="name">The name of the stream to retrieve.</param>
      /// <returns>The number of bytes used by a named stream.</returns>
      [SecurityCritical]
      public static long GetStreamSize(string path, string name)
      {
         return AlternateDataStreamInfo.GetStreamSizeInternal(true, null, null, path, name, StreamType.Data, PathFormat.Relative);
      }

      /// <summary>[AlphaFS] Retrieves the actual number of bytes of disk storage used by a <see cref="StreamType"/> data streams (NTFS ADS).</summary>
      /// <param name="path">The path to an existing directory.</param>
      /// <param name="type">The <see cref="StreamType"/> of the stream to retrieve.</param>
      /// <returns>The number of bytes used by stream of type <see cref="StreamType"/>.</returns>
      [SecurityCritical]
      public static long GetStreamSize(string path, StreamType type)
      {
         return AlternateDataStreamInfo.GetStreamSizeInternal(true, null, null, path, null, type, PathFormat.Relative);
      }

      /// <summary>[AlphaFS] Retrieves the actual number of bytes of disk storage used by all data streams (NTFS ADS).</summary>
      /// <param name="handle">The <see cref="SafeFileHandle"/> to the directory.</param>
      /// <param name="name">The name of the stream to retrieve.</param>
      /// <returns>The number of bytes used by a named stream.</returns>
      [SecurityCritical]
      public static long GetStreamSize(SafeFileHandle handle, string name)
      {
         return AlternateDataStreamInfo.GetStreamSizeInternal(true, null, handle, null, name, StreamType.Data, PathFormat.LongFullPath);
      }

      /// <summary>[AlphaFS] Retrieves the actual number of bytes of disk storage used by a <see cref="StreamType"/> data streams (NTFS ADS).</summary>
      /// <param name="handle">The <see cref="SafeFileHandle"/> to the directory.</param>
      /// <param name="type">The <see cref="StreamType"/> of the stream to retrieve.</param>
      /// <returns>The number of bytes used by stream of type <see cref="StreamType"/>.</returns>
      [SecurityCritical]
      public static long GetStreamSize(SafeFileHandle handle, StreamType type)
      {
         return AlternateDataStreamInfo.GetStreamSizeInternal(true, null, handle, null, null, type, PathFormat.LongFullPath);
      }

      #region Transacted

      #region IsFullPath

      /// <summary>[AlphaFS] Retrieves the actual number of bytes of disk storage used by all data streams (NTFS ADS).</summary>
      /// <param name="transaction">The transaction.</param>
      /// <param name="path">The path to an existing directory.</param>
      /// <param name="pathFormat">Indicates the format of the path parameter(s).</param>
      /// <returns>The number of bytes used by all data streams.</returns>
      [SecurityCritical]
      public static long GetStreamSize(KernelTransaction transaction, string path, PathFormat pathFormat)
      {
         return AlternateDataStreamInfo.GetStreamSizeInternal(true, transaction, null, path, null, null, pathFormat);
      }

      /// <summary>[AlphaFS] Retrieves the actual number of bytes of disk storage used by a named data streams (NTFS ADS).</summary>
      /// <param name="transaction">The transaction.</param>
      /// <param name="path">The path to an existing directory.</param>
      /// <param name="name">The name of the stream to retrieve.</param>
      /// <param name="pathFormat">Indicates the format of the path parameter(s).</param>
      /// <returns>The number of bytes used by a named stream.</returns>
      [SecurityCritical]
      public static long GetStreamSize(KernelTransaction transaction, string path, string name, PathFormat pathFormat)
      {
         return AlternateDataStreamInfo.GetStreamSizeInternal(true, transaction, null, path, name, StreamType.Data, pathFormat);
      }

      /// <summary>[AlphaFS] Retrieves the actual number of bytes of disk storage used by a <see cref="StreamType"/> data streams (NTFS ADS).</summary>
      /// <param name="transaction">The transaction.</param>
      /// <param name="path">The path to an existing directory.</param>
      /// <param name="type">The <see cref="StreamType"/> of the stream to retrieve.</param>
      /// <param name="pathFormat">Indicates the format of the path parameter(s).</param>
      /// <returns>The number of bytes used by stream of type <see cref="StreamType"/>.</returns>
      [SecurityCritical]
      public static long GetStreamSize(KernelTransaction transaction, string path, StreamType type, PathFormat pathFormat)
      {
         return AlternateDataStreamInfo.GetStreamSizeInternal(true, transaction, null, path, null, type, pathFormat);
      }

      #endregion // IsFullPath

      /// <summary>[AlphaFS] Retrieves the actual number of bytes of disk storage used by all data streams (NTFS ADS).</summary>
      /// <param name="transaction">The transaction.</param>
      /// <param name="path">The path to an existing directory.</param>
      /// <returns>The number of bytes used by all data streams.</returns>
      [SecurityCritical]
      public static long GetStreamSize(KernelTransaction transaction, string path)
      {
         return AlternateDataStreamInfo.GetStreamSizeInternal(true, transaction, null, path, null, null, PathFormat.Relative);
      }

      /// <summary>[AlphaFS] Retrieves the actual number of bytes of disk storage used by a named data streams (NTFS ADS).</summary>
      /// <param name="transaction">The transaction.</param>
      /// <param name="path">The path to an existing directory.</param>
      /// <param name="name">The name of the stream to retrieve.</param>
      /// <returns>The number of bytes used by a named stream.</returns>
      [SecurityCritical]
      public static long GetStreamSize(KernelTransaction transaction, string path, string name)
      {
         return AlternateDataStreamInfo.GetStreamSizeInternal(true, transaction, null, path, name, null, PathFormat.Relative);
      }

      /// <summary>[AlphaFS] Retrieves the actual number of bytes of disk storage used by all data streams (NTFS ADS).</summary>
      /// <param name="transaction">The transaction.</param>
      /// <param name="path">The path to an existing directory.</param>
      /// <param name="type">The <see cref="StreamType"/> of the stream to retrieve.</param>
      /// <returns>The number of bytes used by stream of type <see cref="StreamType"/>.</returns>
      [SecurityCritical]
      public static long GetStreamSize(KernelTransaction transaction, string path, StreamType type)
      {
         return AlternateDataStreamInfo.GetStreamSizeInternal(true, transaction, null, path, null, type, PathFormat.Relative);
      }

      #endregion // Transacted

      #endregion GetStreamSize

      #region HasInheritedPermissions

      #region IsFullPath

      /// <summary>[AlphaFS] Check if the directory has permission inheritance enabled.</summary>
      /// <returns><see langword="true"/> if permission inheritance is enabled, <see langword="false"/> if permission inheritance is disabled.</returns>
      /// <param name="path">The full path to the directory to check.</param>
      /// <param name="pathFormat">Indicates the format of the path parameter(s).</param>
      public static bool HasInheritedPermissions(string path, PathFormat pathFormat)
      {
         if (Utils.IsNullOrWhiteSpace(path))
            throw new ArgumentNullException("path");

         //DirectorySecurity acl = GetAccessControl(directoryPath);
         DirectorySecurity acl = File.GetAccessControlInternal<DirectorySecurity>(true, path, AccessControlSections.Access | AccessControlSections.Group | AccessControlSections.Owner, pathFormat);

         return acl.GetAccessRules(false, true, typeof(SecurityIdentifier)).Count > 0;
      }

      #endregion // IsFullPath

      /// <summary>[AlphaFS] Check if the directory has permission inheritance enabled.</summary>
      /// <param name="path">The full path to the directory to check.</param>
      /// <returns><see langword="true"/> if permission inheritance is enabled, <see langword="false"/> if permission inheritance is disabled.</returns>
      public static bool HasInheritedPermissions(string path)
      {
         if (Utils.IsNullOrWhiteSpace(path))
            throw new ArgumentNullException("path");

         DirectorySecurity acl = File.GetAccessControlInternal<DirectorySecurity>(true, path, AccessControlSections.Access | AccessControlSections.Group | AccessControlSections.Owner, PathFormat.Relative);

         return acl.GetAccessRules(false, true, typeof(SecurityIdentifier)).Count > 0;
      }

      #endregion // HasInheritedPermissions

      #region Move1

      #region IsFullPath

      /// <summary>[AlphaFS] Moves a file or a directory and its contents to a new location, <see cref="MoveOptions"/> can be specified.</summary>
      /// <remarks>
      /// <para>This method does not work across disk volumes unless <paramref name="moveOptions"/> contains <see cref="MoveOptions.CopyAllowed"/>.</para>
      /// <para>Whenever possible, avoid using short file names (such as XXXXXX~1.XXX) with this method.</para>
      /// <para>If two directories have equivalent short file names then this method may fail and raise an exception and/or result in undesirable behavior.</para>
      /// </remarks>
      /// <exception cref="ArgumentException">The path parameter contains invalid characters, is empty, or contains only white spaces.</exception>
      /// <exception cref="ArgumentNullException">path is <see langword="null"/>.</exception>
      /// <exception cref="DirectoryNotFoundException"/>
      /// <exception cref="IOException"/>
      /// <exception cref="NotSupportedException"/>
      /// <exception cref="UnauthorizedAccessException"/>
      /// <param name="sourcePath">The source directory path.</param>
      /// <param name="destinationPath">The destination directory path.</param>
      /// <param name="moveOptions"><see cref="MoveOptions"/> that specify how the directory is to be moved. This parameter can be <see langword="null"/>.</param>
      /// <param name="pathFormat">Indicates the format of the path parameter(s).</param>
      [SecurityCritical]
      public static void Move1(string sourcePath, string destinationPath, MoveOptions moveOptions, PathFormat pathFormat)
      {
         CopyMoveInternal(null, sourcePath, destinationPath, null, moveOptions, null, null, pathFormat);
      }

      /// <summary>[AlphaFS] Moves a file or a directory and its contents to a new location, <see cref="MoveOptions"/> can be specified,
      /// <para>and the possibility of notifying the application of its progress through a callback function.</para>
      /// </summary>
      /// <returns>Returns a <see cref="CopyMoveResult"/> class with the status of the Move action.</returns>
      /// <remarks>
      /// <para>This method does not work across disk volumes unless <paramref name="moveOptions"/> contains <see cref="MoveOptions.CopyAllowed"/>.</para>
      /// <para>Whenever possible, avoid using short file names (such as XXXXXX~1.XXX) with this method.</para>
      /// <para>If two directories have equivalent short file names then this method may fail and raise an exception and/or result in undesirable behavior.</para>
      /// </remarks>
      /// <exception cref="ArgumentException">The path parameter contains invalid characters, is empty, or contains only white spaces.</exception>
      /// <exception cref="ArgumentNullException">path is <see langword="null"/>.</exception>
      /// <exception cref="DirectoryNotFoundException"/>
      /// <exception cref="IOException"/>
      /// <exception cref="NotSupportedException"/>
      /// <exception cref="UnauthorizedAccessException"/>
      /// <param name="sourcePath">The source directory path.</param>
      /// <param name="destinationPath">The destination directory path.</param>
      /// <param name="moveOptions"><see cref="MoveOptions"/> that specify how the directory is to be moved. This parameter can be <see langword="null"/>.</param>
      /// <param name="progressHandler">A callback function that is called each time another portion of the directory has been moved. This parameter can be <see langword="null"/>.</param>
      /// <param name="userProgressData">The argument to be passed to the callback function. This parameter can be <see langword="null"/>.</param>
      /// <param name="pathFormat">Indicates the format of the path parameter(s).</param>
      [SecurityCritical]
      public static CopyMoveResult Move1(string sourcePath, string destinationPath, MoveOptions moveOptions, CopyMoveProgressRoutine progressHandler, object userProgressData, PathFormat pathFormat)
      {
         return CopyMoveInternal(null, sourcePath, destinationPath, null, moveOptions, progressHandler, userProgressData, pathFormat);
      }

      #endregion // IsFullPath

      /// <summary>[AlphaFS] Moves a file or a directory and its contents to a new location, <see cref="MoveOptions"/> can be specified.</summary>
      /// <remarks>
      /// <para>This method does not work across disk volumes unless <paramref name="moveOptions"/> contains <see cref="MoveOptions.CopyAllowed"/>.</para>
      /// <para>Whenever possible, avoid using short file names (such as XXXXXX~1.XXX) with this method.</para>
      /// <para>If two directories have equivalent short file names then this method may fail and raise an exception and/or result in undesirable behavior.</para>
      /// </remarks>
      /// <exception cref="ArgumentException">The path parameter contains invalid characters, is empty, or contains only white spaces.</exception>
      /// <exception cref="ArgumentNullException">path is <see langword="null"/>.</exception>
      /// <exception cref="DirectoryNotFoundException"/>
      /// <exception cref="IOException"/>
      /// <exception cref="NotSupportedException"/>
      /// <exception cref="UnauthorizedAccessException"/>
      /// <param name="sourcePath">The source directory path.</param>
      /// <param name="destinationPath">The destination directory path.</param>
      /// <param name="moveOptions"><see cref="MoveOptions"/> that specify how the directory is to be moved. This parameter can be <see langword="null"/>.</param>
      [SecurityCritical]
      public static void Move1(string sourcePath, string destinationPath, MoveOptions moveOptions)
      {
         CopyMoveInternal(null, sourcePath, destinationPath, null, moveOptions, null, null, PathFormat.Relative);
      }

      /// <summary>[AlphaFS] Moves a file or a directory and its contents to a new location, <see cref="MoveOptions"/> can be specified,
      /// <para>and the possibility of notifying the application of its progress through a callback function.</para>
      /// </summary>
      /// <returns>Returns a <see cref="CopyMoveResult"/> class with the status of the Move action.</returns>
      /// <remarks>
      /// <para>This method does not work across disk volumes unless <paramref name="moveOptions"/> contains <see cref="MoveOptions.CopyAllowed"/>.</para>
      /// <para>Whenever possible, avoid using short file names (such as XXXXXX~1.XXX) with this method.</para>
      /// <para>If two directories have equivalent short file names then this method may fail and raise an exception and/or result in undesirable behavior.</para>
      /// </remarks>
      /// <exception cref="ArgumentException">The path parameter contains invalid characters, is empty, or contains only white spaces.</exception>
      /// <exception cref="ArgumentNullException">path is <see langword="null"/>.</exception>
      /// <exception cref="DirectoryNotFoundException"/>
      /// <exception cref="IOException"/>
      /// <exception cref="NotSupportedException"/>
      /// <exception cref="UnauthorizedAccessException"/>
      /// <param name="sourcePath">The source directory path.</param>
      /// <param name="destinationPath">The destination directory path.</param>
      /// <param name="moveOptions"><see cref="MoveOptions"/> that specify how the directory is to be moved. This parameter can be <see langword="null"/>.</param>
      /// <param name="progressHandler">A callback function that is called each time another portion of the directory has been moved. This parameter can be <see langword="null"/>.</param>
      /// <param name="userProgressData">The argument to be passed to the callback function. This parameter can be <see langword="null"/>.</param>
      [SecurityCritical]
      public static CopyMoveResult Move1(string sourcePath, string destinationPath, MoveOptions moveOptions, CopyMoveProgressRoutine progressHandler, object userProgressData)
      {
         return CopyMoveInternal(null, sourcePath, destinationPath, null, moveOptions, progressHandler, userProgressData, PathFormat.Relative);
      }

      #region Transacted

      #region IsFullPath

      /// <summary>[AlphaFS] Moves a file or a directory and its contents to a new location, <see cref="MoveOptions"/> can be specified.</summary>
      /// <remarks>
      /// <para>This method does not work across disk volumes unless <paramref name="moveOptions"/> contains <see cref="MoveOptions.CopyAllowed"/>.</para>
      /// <para>Whenever possible, avoid using short file names (such as XXXXXX~1.XXX) with this method.</para>
      /// <para>If two directories have equivalent short file names then this method may fail and raise an exception and/or result in undesirable behavior.</para>
      /// </remarks>
      /// <exception cref="ArgumentException">The path parameter contains invalid characters, is empty, or contains only white spaces.</exception>
      /// <exception cref="ArgumentNullException">path is <see langword="null"/>.</exception>
      /// <exception cref="DirectoryNotFoundException"/>
      /// <exception cref="IOException"/>
      /// <exception cref="NotSupportedException"/>
      /// <exception cref="UnauthorizedAccessException"/>
      /// <param name="transaction">The transaction.</param>
      /// <param name="sourcePath">The source directory path.</param>
      /// <param name="destinationPath">The destination directory path.</param>
      /// <param name="moveOptions"><see cref="MoveOptions"/> that specify how the directory is to be moved. This parameter can be <see langword="null"/>.</param>
      /// <param name="pathFormat">Indicates the format of the path parameter(s).</param>
      [SecurityCritical]
      public static void Move1(KernelTransaction transaction, string sourcePath, string destinationPath, MoveOptions moveOptions, PathFormat pathFormat)
      {
         CopyMoveInternal(transaction, sourcePath, destinationPath, null, moveOptions, null, null, pathFormat);
      }

      /// <summary>[AlphaFS] Moves a file or a directory and its contents to a new location, <see cref="MoveOptions"/> can be specified,
      /// <para>and the possibility of notifying the application of its progress through a callback function.</para>
      /// </summary>
      /// <returns>Returns a <see cref="CopyMoveResult"/> class with the status of the Move action.</returns>
      /// <remarks>
      /// <para>This method does not work across disk volumes unless <paramref name="moveOptions"/> contains <see cref="MoveOptions.CopyAllowed"/>.</para>
      /// <para>Whenever possible, avoid using short file names (such as XXXXXX~1.XXX) with this method.</para>
      /// <para>If two directories have equivalent short file names then this method may fail and raise an exception and/or result in undesirable behavior.</para>
      /// </remarks>
      /// <exception cref="ArgumentException">The path parameter contains invalid characters, is empty, or contains only white spaces.</exception>
      /// <exception cref="ArgumentNullException">path is <see langword="null"/>.</exception>
      /// <exception cref="DirectoryNotFoundException"/>
      /// <exception cref="IOException"/>
      /// <exception cref="NotSupportedException"/>
      /// <exception cref="UnauthorizedAccessException"/>
      /// <param name="transaction">The transaction.</param>
      /// <param name="sourcePath">The source directory path.</param>
      /// <param name="destinationPath">The destination directory path.</param>
      /// <param name="moveOptions"><see cref="MoveOptions"/> that specify how the directory is to be moved. This parameter can be <see langword="null"/>.</param>
      /// <param name="progressHandler">A callback function that is called each time another portion of the directory has been moved. This parameter can be <see langword="null"/>.</param>
      /// <param name="userProgressData">The argument to be passed to the callback function. This parameter can be <see langword="null"/>.</param>
      /// <param name="pathFormat">Indicates the format of the path parameter(s).</param>
      [SecurityCritical]
      public static CopyMoveResult Move1(KernelTransaction transaction, string sourcePath, string destinationPath, MoveOptions moveOptions, CopyMoveProgressRoutine progressHandler, object userProgressData, PathFormat pathFormat)
      {
         return CopyMoveInternal(transaction, sourcePath, destinationPath, null, moveOptions, progressHandler, userProgressData, pathFormat);
      }

      #endregion // IsFullPath

      /// <summary>[AlphaFS] Moves a file or a directory and its contents to a new location, <see cref="MoveOptions"/> can be specified.</summary>
      /// <remarks>
      /// <para>This method does not work across disk volumes unless <paramref name="moveOptions"/> contains <see cref="MoveOptions.CopyAllowed"/>.</para>
      /// <para>Whenever possible, avoid using short file names (such as XXXXXX~1.XXX) with this method.</para>
      /// <para>If two directories have equivalent short file names then this method may fail and raise an exception and/or result in undesirable behavior.</para>
      /// </remarks>
      /// <exception cref="ArgumentException">The path parameter contains invalid characters, is empty, or contains only white spaces.</exception>
      /// <exception cref="ArgumentNullException">path is <see langword="null"/>.</exception>
      /// <exception cref="DirectoryNotFoundException"/>
      /// <exception cref="IOException"/>
      /// <exception cref="NotSupportedException"/>
      /// <exception cref="UnauthorizedAccessException"/>
      /// <param name="transaction">The transaction.</param>
      /// <param name="sourcePath">The source directory path.</param>
      /// <param name="destinationPath">The destination directory path.</param>
      /// <param name="moveOptions"><see cref="MoveOptions"/> that specify how the directory is to be moved. This parameter can be <see langword="null"/>.</param>
      [SecurityCritical]
      public static void Move1(KernelTransaction transaction, string sourcePath, string destinationPath, MoveOptions moveOptions)
      {
         CopyMoveInternal(transaction, sourcePath, destinationPath, null, moveOptions, null, null, PathFormat.Relative);
      }

      /// <summary>[AlphaFS] Moves a file or a directory and its contents to a new location, <see cref="MoveOptions"/> can be specified,
      /// <para>and the possibility of notifying the application of its progress through a callback function.</para>
      /// </summary>
      /// <returns>Returns a <see cref="CopyMoveResult"/> class with the status of the Move action.</returns>
      /// <remarks>
      /// <para>This method does not work across disk volumes unless <paramref name="moveOptions"/> contains <see cref="MoveOptions.CopyAllowed"/>.</para>
      /// <para>Whenever possible, avoid using short file names (such as XXXXXX~1.XXX) with this method.</para>
      /// <para>If two directories have equivalent short file names then this method may fail and raise an exception and/or result in undesirable behavior.</para>
      /// </remarks>
      /// <exception cref="ArgumentException">The path parameter contains invalid characters, is empty, or contains only white spaces.</exception>
      /// <exception cref="ArgumentNullException">path is <see langword="null"/>.</exception>
      /// <exception cref="DirectoryNotFoundException"/>
      /// <exception cref="IOException"/>
      /// <exception cref="NotSupportedException"/>
      /// <exception cref="UnauthorizedAccessException"/>
      /// <param name="transaction">The transaction.</param>
      /// <param name="sourcePath">The source directory path.</param>
      /// <param name="destinationPath">The destination directory path.</param>
      /// <param name="moveOptions"><see cref="MoveOptions"/> that specify how the directory is to be moved. This parameter can be <see langword="null"/>.</param>
      /// <param name="progressHandler">A callback function that is called each time another portion of the directory has been moved. This parameter can be <see langword="null"/>.</param>
      /// <param name="userProgressData">The argument to be passed to the callback function. This parameter can be <see langword="null"/>.</param>
      [SecurityCritical]
      public static CopyMoveResult Move1(KernelTransaction transaction, string sourcePath, string destinationPath, MoveOptions moveOptions, CopyMoveProgressRoutine progressHandler, object userProgressData)
      {
         return CopyMoveInternal(transaction, sourcePath, destinationPath, null, moveOptions, progressHandler, userProgressData, PathFormat.Relative);
      }

      #endregion // Transacted

      #endregion // Move1

      #region RemoveStream

      #region IsFullPath

      /// <summary>[AlphaFS] Removes all alternate data streams (NTFS ADS) from an existing directory.</summary>
      /// <param name="path">The path to an existing directory.</param>
      /// <param name="pathFormat">Indicates the format of the path parameter(s).</param>
      /// <remarks>This method only removes streams of type <see cref="StreamType.AlternateData"/>.</remarks>
      /// <remarks>No Exception is thrown if the stream does not exist.</remarks>
      [SecurityCritical]
      public static void RemoveStream(string path, PathFormat pathFormat)
      {
         AlternateDataStreamInfo.RemoveStreamInternal(true, null, path, null, pathFormat);
      }

      /// <summary>[AlphaFS] Removes an alternate data stream (NTFS ADS) from an existing directory.</summary>
      /// <param name="path">The path to an existing directory.</param>
      /// <param name="name">The name of the stream to remove.</param>
      /// <param name="pathFormat">Indicates the format of the path parameter(s).</param>
      /// <remarks>This method only removes streams of type <see cref="StreamType.AlternateData"/>.</remarks>
      /// <remarks>No Exception is thrown if the stream does not exist.</remarks>
      [SecurityCritical]
      public static void RemoveStream(string path, string name, PathFormat pathFormat)
      {
         AlternateDataStreamInfo.RemoveStreamInternal(true, null, path, name, pathFormat);
      }

      #endregion // IsFullPath

      /// <summary>[AlphaFS] Removes all alternate data streams (NTFS ADS) from an existing directory.</summary>
      /// <param name="path">The path to an existing directory.</param>
      /// <remarks>This method only removes streams of type <see cref="StreamType.AlternateData"/>.</remarks>
      /// <remarks>No Exception is thrown if the stream does not exist.</remarks>
      [SecurityCritical]
      public static void RemoveStream(string path)
      {
         AlternateDataStreamInfo.RemoveStreamInternal(true, null, path, null, PathFormat.Relative);
      }

      /// <summary>[AlphaFS] Removes an alternate data stream (NTFS ADS) from an existing directory.</summary>
      /// <param name="path">The path to an existing directory.</param>
      /// <param name="name">The name of the stream to remove.</param>
      /// <remarks>This method only removes streams of type <see cref="StreamType.AlternateData"/>.</remarks>
      /// <remarks>No Exception is thrown if the stream does not exist.</remarks>
      [SecurityCritical]
      public static void RemoveStream(string path, string name)
      {
         AlternateDataStreamInfo.RemoveStreamInternal(true, null, path, name, PathFormat.Relative);
      }

      #region Transacted

      #region IsFullPath

      /// <summary>[AlphaFS] Removes all alternate data streams (NTFS ADS) from an existing directory.</summary>
      /// <param name="transaction">The transaction.</param>
      /// <param name="path">The path to an existing directory.</param>
      /// <param name="pathFormat">Indicates the format of the path parameter(s).</param>
      /// <remarks>This method only removes streams of type <see cref="StreamType.AlternateData"/>.</remarks>
      /// <remarks>No Exception is thrown if the stream does not exist.</remarks>
      [SecurityCritical]
      public static void RemoveStream(KernelTransaction transaction, string path, PathFormat pathFormat)
      {
         AlternateDataStreamInfo.RemoveStreamInternal(true, transaction, path, null, pathFormat);
      }

      /// <summary>[AlphaFS] Removes an alternate data stream (NTFS ADS) from an existing directory.</summary>
      /// <param name="transaction">The transaction.</param>
      /// <param name="path">The path to an existing directory.</param>
      /// <param name="name">The name of the stream to remove.</param>
      /// <param name="pathFormat">Indicates the format of the path parameter(s).</param>
      /// <remarks>This method only removes streams of type <see cref="StreamType.AlternateData"/>.</remarks>
      /// <remarks>No Exception is thrown if the stream does not exist.</remarks>
      [SecurityCritical]
      public static void RemoveStream(KernelTransaction transaction, string path, string name, PathFormat pathFormat)
      {
         AlternateDataStreamInfo.RemoveStreamInternal(true, transaction, path, name, pathFormat);
      }

      #endregion // IsFullPath

      /// <summary>[AlphaFS] Removes all alternate data streams (NTFS ADS) from an existing directory.</summary>
      /// <param name="transaction">The transaction.</param>
      /// <param name="path">The path to an existing directory.</param>
      /// <remarks>This method only removes streams of type <see cref="StreamType.AlternateData"/>.</remarks>
      /// <remarks>No Exception is thrown if the stream does not exist.</remarks>
      [SecurityCritical]
      public static void RemoveStream(KernelTransaction transaction, string path)
      {
         AlternateDataStreamInfo.RemoveStreamInternal(true, transaction, path, null, PathFormat.Relative);
      }

      /// <summary>[AlphaFS] Removes an alternate data stream (NTFS ADS) from an existing directory.</summary>
      /// <param name="transaction">The transaction.</param>
      /// <param name="path">The path to an existing directory.</param>
      /// <param name="name">The name of the stream to remove.</param>
      /// <remarks>This method only removes streams of type <see cref="StreamType.AlternateData"/>.</remarks>
      /// <remarks>No Exception is thrown if the stream does not exist.</remarks>
      [SecurityCritical]
      public static void RemoveStream(KernelTransaction transaction, string path, string name)
      {
         AlternateDataStreamInfo.RemoveStreamInternal(true, transaction, path, name, PathFormat.Relative);
      }

      #endregion Transacted

      #endregion // RemoveStream

      #region SetTimestamps

      #region IsFullPath

      /// <summary>[AlphaFS] Sets all the date and time stamps for the specified directory, at once.</summary>
      /// <param name="path">The directory for which to set the dates and times information.</param>
      /// <param name="creationTime">A <see cref="System.DateTime"/> containing the value to set for the creation date and time of <paramref name="path"/>. This value is expressed in local time.</param>
      /// <param name="lastAccessTime">A <see cref="System.DateTime"/> containing the value to set for the last access date and time of <paramref name="path"/>. This value is expressed in local time.</param>
      /// <param name="lastWriteTime">A <see cref="System.DateTime"/> containing the value to set for the last write date and time of <paramref name="path"/>. This value is expressed in local time.</param>
      /// <param name="pathFormat">Indicates the format of the path parameter(s).</param>
      [SecurityCritical]
      public static void SetTimestamps(string path, DateTime creationTime, DateTime lastAccessTime, DateTime lastWriteTime, PathFormat pathFormat)
      {
         File.SetFsoDateTimeInternal(true, null, path, creationTime.ToUniversalTime(), lastAccessTime.ToUniversalTime(), lastWriteTime.ToUniversalTime(), pathFormat);
      }

      #endregion // IsFullPath

      /// <summary>[AlphaFS] Sets all the date and time stamps for the specified directory, at once.</summary>
      /// <param name="path">The directory for which to set the dates and times information.</param>
      /// <param name="creationTime">A <see cref="System.DateTime"/> containing the value to set for the creation date and time of <paramref name="path"/>. This value is expressed in local time.</param>
      /// <param name="lastAccessTime">A <see cref="System.DateTime"/> containing the value to set for the last access date and time of <paramref name="path"/>. This value is expressed in local time.</param>
      /// <param name="lastWriteTime">A <see cref="System.DateTime"/> containing the value to set for the last write date and time of <paramref name="path"/>. This value is expressed in local time.</param>
      [SecurityCritical]
      public static void SetTimestamps(string path, DateTime creationTime, DateTime lastAccessTime, DateTime lastWriteTime)
      {
         File.SetFsoDateTimeInternal(true, null, path, creationTime.ToUniversalTime(), lastAccessTime.ToUniversalTime(), lastWriteTime.ToUniversalTime(), PathFormat.Relative);
      }

      #region Transacted

      #region IsFullPath

      /// <summary>[AlphaFS] Sets all the date and time stamps for the specified directory, at once.</summary>
      /// <param name="transaction">The transaction.</param>
      /// <param name="path">The directory for which to set the dates and times information.</param>
      /// <param name="creationTime">A <see cref="System.DateTime"/> containing the value to set for the creation date and time of <paramref name="path"/>. This value is expressed in local time.</param>
      /// <param name="lastAccessTime">A <see cref="System.DateTime"/> containing the value to set for the last access date and time of <paramref name="path"/>. This value is expressed in local time.</param>
      /// <param name="lastWriteTime">A <see cref="System.DateTime"/> containing the value to set for the last write date and time of <paramref name="path"/>. This value is expressed in local time.</param>
      /// <param name="pathFormat">Indicates the format of the path parameter(s).</param>
      [SecurityCritical]
      public static void SetTimestamps(KernelTransaction transaction, string path, DateTime creationTime, DateTime lastAccessTime, DateTime lastWriteTime, PathFormat pathFormat)
      {
         File.SetFsoDateTimeInternal(true, transaction, path, creationTime.ToUniversalTime(), lastAccessTime.ToUniversalTime(), lastWriteTime.ToUniversalTime(), pathFormat);
      }

      #endregion // IsFullPath

      /// <summary>[AlphaFS] Sets all the date and time stamps for the specified directory, at once.</summary>
      /// <param name="transaction">The transaction.</param>
      /// <param name="path">The directory for which to set the dates and times information.</param>
      /// <param name="creationTime">A <see cref="System.DateTime"/> containing the value to set for the creation date and time of <paramref name="path"/>. This value is expressed in local time.</param>
      /// <param name="lastAccessTime">A <see cref="System.DateTime"/> containing the value to set for the last access date and time of <paramref name="path"/>. This value is expressed in local time.</param>
      /// <param name="lastWriteTime">A <see cref="System.DateTime"/> containing the value to set for the last write date and time of <paramref name="path"/>. This value is expressed in local time.</param>
      [SecurityCritical]
      public static void SetTimestamps(KernelTransaction transaction, string path, DateTime creationTime, DateTime lastAccessTime, DateTime lastWriteTime)
      {
         File.SetFsoDateTimeInternal(true, transaction, path, creationTime.ToUniversalTime(), lastAccessTime.ToUniversalTime(), lastWriteTime.ToUniversalTime(), PathFormat.Relative);
      }

      #endregion // Transacted

      #endregion // SetTimestamps

      #region SetTimestampsUtc

      #region IsFullPath

      /// <summary>[AlphaFS] Sets all the date and time stamps, in coordinated universal time (UTC), for the specified directory, at once.</summary>
      /// <param name="path">The directory for which to set the dates and times information.</param>
      /// <param name="creationTimeUtc">A <see cref="System.DateTime"/> containing the value to set for the creation date and time of <paramref name="path"/>. This value is expressed in UTC time.</param>
      /// <param name="lastAccessTimeUtc">A <see cref="System.DateTime"/> containing the value to set for the last access date and time of <paramref name="path"/>. This value is expressed in UTC time.</param>
      /// <param name="lastWriteTimeUtc">A <see cref="System.DateTime"/> containing the value to set for the last write date and time of <paramref name="path"/>. This value is expressed in UTC time.</param>
      /// <param name="pathFormat">Indicates the format of the path parameter(s).</param>
      [SecurityCritical]
      public static void SetTimestampsUtc(string path, DateTime creationTimeUtc, DateTime lastAccessTimeUtc, DateTime lastWriteTimeUtc, PathFormat pathFormat)
      {
         File.SetFsoDateTimeInternal(true, null, path, creationTimeUtc, lastAccessTimeUtc, lastWriteTimeUtc, pathFormat);
      }

      #endregion // IsFullPath

      /// <summary>[AlphaFS] Sets all the date and time stamps, in coordinated universal time (UTC), for the specified directory, at once.</summary>
      /// <param name="path">The directory for which to set the dates and times information.</param>
      /// <param name="creationTimeUtc">A <see cref="System.DateTime"/> containing the value to set for the creation date and time of <paramref name="path"/>. This value is expressed in UTC time.</param>
      /// <param name="lastAccessTimeUtc">A <see cref="System.DateTime"/> containing the value to set for the last access date and time of <paramref name="path"/>. This value is expressed in UTC time.</param>
      /// <param name="lastWriteTimeUtc">A <see cref="System.DateTime"/> containing the value to set for the last write date and time of <paramref name="path"/>. This value is expressed in UTC time.</param>
      [SecurityCritical]
      public static void SetTimestampsUtc(string path, DateTime creationTimeUtc, DateTime lastAccessTimeUtc, DateTime lastWriteTimeUtc)
      {
         File.SetFsoDateTimeInternal(true, null, path, creationTimeUtc, lastAccessTimeUtc, lastWriteTimeUtc, PathFormat.Relative);
      }

      #region Transacted

      #region IsFullPath

      /// <summary>[AlphaFS] Sets all the date and time stamps, in coordinated universal time (UTC), for the specified directory, at once.</summary>
      /// <param name="transaction">The transaction.</param>
      /// <param name="path">The directory for which to set the dates and times information.</param>
      /// <param name="creationTimeUtc">A <see cref="System.DateTime"/> containing the value to set for the creation date and time of <paramref name="path"/>. This value is expressed in UTC time.</param>
      /// <param name="lastAccessTimeUtc">A <see cref="System.DateTime"/> containing the value to set for the last access date and time of <paramref name="path"/>. This value is expressed in UTC time.</param>
      /// <param name="lastWriteTimeUtc">A <see cref="System.DateTime"/> containing the value to set for the last write date and time of <paramref name="path"/>. This value is expressed in UTC time.</param>
      /// <param name="pathFormat">Indicates the format of the path parameter(s).</param>
      [SecurityCritical]
      public static void SetTimestampsUtc(KernelTransaction transaction, string path, DateTime creationTimeUtc, DateTime lastAccessTimeUtc, DateTime lastWriteTimeUtc, PathFormat pathFormat)
      {
         File.SetFsoDateTimeInternal(true, transaction, path, creationTimeUtc, lastAccessTimeUtc, lastWriteTimeUtc, pathFormat);
      }

      #endregion // IsFullPath

      /// <summary>[AlphaFS] Sets all the date and time stamps, in coordinated universal time (UTC), for the specified directory, at once.</summary>
      /// <param name="transaction">The transaction.</param>
      /// <param name="path">The directory for which to set the dates and times information.</param>
      /// <param name="creationTimeUtc">A <see cref="System.DateTime"/> containing the value to set for the creation date and time of <paramref name="path"/>. This value is expressed in UTC time.</param>
      /// <param name="lastAccessTimeUtc">A <see cref="System.DateTime"/> containing the value to set for the last access date and time of <paramref name="path"/>. This value is expressed in UTC time.</param>
      /// <param name="lastWriteTimeUtc">A <see cref="System.DateTime"/> containing the value to set for the last write date and time of <paramref name="path"/>. This value is expressed in UTC time.</param>
      [SecurityCritical]
      public static void SetTimestampsUtc(KernelTransaction transaction, string path, DateTime creationTimeUtc, DateTime lastAccessTimeUtc, DateTime lastWriteTimeUtc)
      {
         File.SetFsoDateTimeInternal(true, transaction, path, creationTimeUtc, lastAccessTimeUtc, lastWriteTimeUtc, PathFormat.Relative);
      }

      #endregion // Transacted

      #endregion // SetTimestampsUtc

      #region TransferTimestamps

      #region IsFullPath

      /// <summary>[AlphaFS] Transfers the date and time stamps for the specified directories.</summary>
      /// <param name="sourcePath">The source directory to get the date and time stamps from.</param>
      /// <param name="destinationPath">The destination directory to set the date and time stamps.</param>
      /// <param name="pathFormat">Indicates the format of the path parameter(s).</param>
      /// <remarks>This method uses BackupSemantics flag to get Timestamp changed for directories.</remarks>
      [SecurityCritical]
      public static void TransferTimestamps(string sourcePath, string destinationPath, PathFormat pathFormat)
      {
         File.TransferTimestampsInternal(true, null, sourcePath, destinationPath, pathFormat);
      }

      #endregion // IsFullPath

      /// <summary>[AlphaFS] Transfers the date and time stamps for the specified directories.</summary>
      /// <param name="sourcePath">The source directory to get the date and time stamps from.</param>
      /// <param name="destinationPath">The destination directory to set the date and time stamps.</param>
      /// <remarks>This method uses BackupSemantics flag to get Timestamp changed for directories.</remarks>
      [SecurityCritical]
      public static void TransferTimestamps(string sourcePath, string destinationPath)
      {
         File.TransferTimestampsInternal(true, null, sourcePath, destinationPath, PathFormat.Relative);
      }

      #region Transacted

      #region IsFullPath

      /// <summary>[AlphaFS] Transfers the date and time stamps for the specified directories.</summary>
      /// <param name="transaction">The transaction.</param>
      /// <param name="sourcePath">The source directory to get the date and time stamps from.</param>
      /// <param name="destinationPath">The destination directory to set the date and time stamps.</param>
      /// <param name="pathFormat">Indicates the format of the path parameter(s).</param>
      /// <remarks>This method uses BackupSemantics flag to get Timestamp changed for directories.</remarks>
      [SecurityCritical]
      public static void TransferTimestamps(KernelTransaction transaction, string sourcePath, string destinationPath, PathFormat pathFormat)
      {
         File.TransferTimestampsInternal(true, transaction, sourcePath, destinationPath, pathFormat);
      }

      #endregion // IsFullPath

      /// <summary>[AlphaFS] Transfers the date and time stamps for the specified directories.</summary>
      /// <param name="transaction">The transaction.</param>
      /// <param name="sourcePath">The source directory to get the date and time stamps from.</param>
      /// <param name="destinationPath">The destination directory to set the date and time stamps.</param>
      /// <remarks>This method uses BackupSemantics flag to get Timestamp changed for directories.</remarks>
      [SecurityCritical]
      public static void TransferTimestamps(KernelTransaction transaction, string sourcePath, string destinationPath)
      {
         File.TransferTimestampsInternal(true, transaction, sourcePath, destinationPath, PathFormat.Relative);
      }

      #endregion // Transacted

      #endregion // TransferTimestamps


      #region Unified Internals

      #region CompressDecompressInternal

      /// <summary>[AlphaFS] Unified method CompressDecompressInternal() to compress/decompress Non-/Transacted files/directories.</summary>
      /// <param name="transaction">The transaction.</param>
      /// <param name="path">A path that describes a directory to compress.</param>
      /// <param name="searchPattern">
      ///    <para>The search string to match against the names of directories in <paramref name="path"/>. This parameter can contain a</para>
      ///    <para>combination of valid literal path and wildcard (<see cref="Path.WildcardStarMatchAll"/> and <see cref="Path.WildcardQuestion"/>)</para>
      ///    <para>characters, but does not support regular expressions.</para>
      /// </param>
      /// <param name="directoryEnumerationOptions"><see cref="DirectoryEnumerationOptions"/> flags that specify how the directory is to be enumerated.</param>
      /// <param name="compress"><see langword="true"/> compress, when <see langword="false"/> decompress.</param>
      /// <param name="pathFormat">Indicates the format of the path parameter(s).</param>
      [SecurityCritical]
      internal static void CompressDecompressInternal(KernelTransaction transaction, string path, string searchPattern, DirectoryEnumerationOptions directoryEnumerationOptions, bool compress, PathFormat pathFormat)
      {
         string pathLp = Path.GetExtendedLengthPathInternal(transaction, path, pathFormat, GetFullPathOptions.RemoveTrailingDirectorySeparator | GetFullPathOptions.CheckInvalidPathChars | GetFullPathOptions.CheckAdditional);

         // Process directories and files.
         foreach (string fso in EnumerateFileSystemEntryInfosInternal<string>(transaction, pathLp, searchPattern, directoryEnumerationOptions | DirectoryEnumerationOptions.AsLongPath, PathFormat.LongFullPath))
            Device.ToggleCompressionInternal(true, transaction, fso, compress, PathFormat.LongFullPath);

         // Compress the root directory, the given path.
         Device.ToggleCompressionInternal(true, transaction, pathLp, compress, PathFormat.LongFullPath);
      }

      #endregion // CompressDecompressInternal

      #region CopyMoveInternal

      /// <summary>[AlphaFS] Unified method CopyMoveInternal() to copy/move a Non-/Transacted file or directory including its children to a new location,
      /// <para><see cref="CopyOptions"/> or <see cref="MoveOptions"/> can be specified,</para>
      /// <para>and the possibility of notifying the application of its progress through a callback function.</para>
      /// </summary>
      /// <returns>Returns a <see cref="CopyMoveResult"/> class with the status of the Copy or Move action.</returns>
      /// <remarks>
      /// <para>Option <see cref="CopyOptions.NoBuffering"/> is recommended for very large file transfers.</para>
      /// <para>You cannot use the Move method to overwrite an existing file, unless <paramref name="moveOptions"/> contains <see cref="MoveOptions.ReplaceExisting"/>.</para>
      /// <para>This Move method works across disk volumes, and it does not throw an exception if the source and destination are the same. </para>
      /// <para>Note that if you attempt to replace a file by moving a file of the same name into that directory, you get an IOException.</para>
      /// </remarks>
      /// <exception cref="ArgumentException">The path parameter contains invalid characters, is empty, or contains only white spaces.</exception>
      /// <exception cref="ArgumentNullException">path is <see langword="null"/>.</exception>
      /// <exception cref="DirectoryNotFoundException"/>
      /// <exception cref="IOException"/>
      /// <exception cref="NotSupportedException"/>
      /// <exception cref="UnauthorizedAccessException"/>
      /// <param name="transaction">The transaction.</param>
      /// <param name="sourcePath">The source directory path.</param>
      /// <param name="destinationPath">The destination directory path.</param>
      /// <param name="copyOptions"><see cref="CopyOptions"/> that specify how the directory is to be copied. This parameter can be <see langword="null"/>.</param>
      /// <param name="moveOptions"><see cref="MoveOptions"/> that specify how the directory is to be moved. This parameter can be <see langword="null"/>.</param>
      /// <param name="progressHandler">A callback function that is called each time another portion of the file has been copied/moved. This parameter can be <see langword="null"/>.</param>
      /// <param name="userProgressData">The argument to be passed to the callback function. This parameter can be <see langword="null"/>.</param>
      /// <param name="pathFormat">Indicates the format of the path parameter(s).</param>
      [SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
      [SecurityCritical]
      internal static CopyMoveResult CopyMoveInternal(KernelTransaction transaction, string sourcePath, string destinationPath, CopyOptions? copyOptions, MoveOptions? moveOptions, CopyMoveProgressRoutine progressHandler, object userProgressData, PathFormat pathFormat)
      {
         #region Setup

         if (pathFormat == PathFormat.Relative)            
         {
            Path.CheckValidPath(sourcePath, true, true);
            Path.CheckValidPath(destinationPath, true, true);
         }
         else
         {
            // MSDN:. NET 3.5+: NotSupportedException: Path contains a colon character (:) that is not part of a drive label ("C:\").
            Path.CheckValidPath(sourcePath, false, false);
            Path.CheckValidPath(destinationPath, false, false);
         }

         // MSDN: .NET 4+ Trailing spaces are removed from the end of the path parameters before moving the directory.
         // TrimEnd() is also applied for AlphaFS implementation of method Directory.Copy(), .NET does not have this method.

         string sourcePathLp = Path.GetExtendedLengthPathInternal(transaction, sourcePath, pathFormat, GetFullPathOptions.TrimEnd | GetFullPathOptions.RemoveTrailingDirectorySeparator);
         string destinationPathLp = Path.GetExtendedLengthPathInternal(transaction, destinationPath, pathFormat, GetFullPathOptions.TrimEnd | GetFullPathOptions.RemoveTrailingDirectorySeparator);

         // MSDN: .NET3.5+: IOException: The sourceDirName and destDirName parameters refer to the same file or directory.
         if (sourcePathLp.Equals(destinationPathLp, StringComparison.OrdinalIgnoreCase))
            NativeError.ThrowException(Win32Errors.ERROR_SAME_DRIVE, destinationPathLp, true);


         // Determine Copy or Move action.
         bool doCopy = copyOptions != null;
         bool doMove = !doCopy && moveOptions != null;

         if ((!doCopy && !doMove) || (doCopy && doMove))
            throw new NotSupportedException(Resources.UndeterminedCopyMoveAction);

         bool overwrite = doCopy
            ? (((CopyOptions)copyOptions & CopyOptions.FailIfExists) != CopyOptions.FailIfExists)
            : (((MoveOptions)moveOptions & MoveOptions.ReplaceExisting) == MoveOptions.ReplaceExisting);

         var cmr = new CopyMoveResult(sourcePathLp, destinationPathLp, true, doMove, false, (int)Win32Errors.ERROR_SUCCESS);

         #endregion //Setup

         #region Copy

         if (doCopy)
         {
            CreateDirectoryInternal(transaction, destinationPathLp, null, null, false, PathFormat.LongFullPath);

            foreach (FileSystemEntryInfo fsei in EnumerateFileSystemEntryInfosInternal<FileSystemEntryInfo>(transaction, sourcePathLp, Path.WildcardStarMatchAll, DirectoryEnumerationOptions.FilesAndFolders, PathFormat.LongFullPath))
            {
               string newDestinationPathLp = Path.CombineInternal(false, destinationPathLp, fsei.FileName);

               cmr = fsei.IsDirectory
                  ? CopyMoveInternal(transaction, fsei.LongFullPath, newDestinationPathLp, copyOptions, null, progressHandler, userProgressData, PathFormat.LongFullPath)
                  : File.CopyMoveInternal(false, transaction, fsei.LongFullPath, newDestinationPathLp, false, copyOptions, null, progressHandler, userProgressData, PathFormat.LongFullPath);

               if (cmr.IsCanceled)
                  return cmr;
            }
         }

         #endregion // Copy

         #region Move

         else
         {
            // MSDN: .NET3.5+: IOException: An attempt was made to move a directory to a different volume.
            if (((MoveOptions)moveOptions & MoveOptions.CopyAllowed) != MoveOptions.CopyAllowed)
               if (!Path.GetPathRoot(sourcePathLp, false).Equals(Path.GetPathRoot(destinationPathLp, false), StringComparison.OrdinalIgnoreCase))
                  NativeError.ThrowException(Win32Errors.ERROR_NOT_SAME_DEVICE, destinationPathLp, true);


            // MoveOptions.ReplaceExisting: This value cannot be used if lpNewFileName or lpExistingFileName names a directory.
            if (overwrite && File.ExistsInternal(true, transaction, destinationPathLp, PathFormat.LongFullPath))
               DeleteDirectoryInternal(null, transaction, destinationPathLp, true, true, false, true, PathFormat.LongFullPath);


            // Moves a file or directory, including its children.
            // Copies an existing directory, including its children to a new directory.
            cmr = File.CopyMoveInternal(true, transaction, sourcePathLp, destinationPathLp, false, null, moveOptions, progressHandler, userProgressData, PathFormat.LongFullPath);
         }

         #endregion // Move

         // The copy/move operation succeeded or was canceled.
         return cmr;
      }

      #endregion // CopyMoveInternal


      #region GetDirectoryRootInternal

      /// <summary>[AlphaFS] Unified method GetDirectoryRootInternal() to return the volume information, root information, or both for the specified path.
      /// <returns>
      /// <para>Returns the volume information, root information, or both for the specified path,</para>
      /// <para> or <see langword="null"/> if <paramref name="path"/> path does not contain root directory information.</para>
      /// </returns>
      /// </summary>
      /// <param name="transaction">The transaction.</param>
      /// <param name="path">The path of a file or directory.</param>
      /// <param name="pathFormat">Indicates the format of the path parameter(s).</param>
      [SecurityCritical]
      internal static string GetDirectoryRootInternal(KernelTransaction transaction, string path, PathFormat pathFormat)
      {
         string pathLp = Path.GetExtendedLengthPathInternal(transaction, path, pathFormat, GetFullPathOptions.CheckInvalidPathChars);
         pathLp = Path.GetRegularPathInternal(pathLp, false, false, false, false);
         string rootPath = Path.GetPathRoot(pathLp, false);

         return Utils.IsNullOrWhiteSpace(rootPath) ? null : rootPath;
      }

      #endregion // GetDirectoryRootInternal

      #region GetParentInternal

      /// <summary>[AlphaFS] Unified method GetParent() to retrieve the parent directory of the specified path, including both absolute and relative paths.</summary>
      /// <returns>
      ///   Returns the parent directory, or <see langword="null"/> if <paramref name="path"/> is the root directory, including the root of a
      ///   UNC server or share name.
      /// </returns>
      /// <param name="transaction">The transaction.</param>
      /// <param name="path">The path for which to retrieve the parent directory.</param>
      /// <param name="pathFormat">Indicates the format of the path parameter(s).</param>
      [SecurityCritical]
      internal static DirectoryInfo GetParentInternal(KernelTransaction transaction, string path, PathFormat pathFormat)
      {
         string pathLp = Path.GetExtendedLengthPathInternal(transaction, path, pathFormat, GetFullPathOptions.CheckInvalidPathChars);

         pathLp = Path.GetRegularPathInternal(pathLp, false, false, false, false);
         string dirName = Path.GetDirectoryName(pathLp, false);

         return Utils.IsNullOrWhiteSpace(dirName) ? null : new DirectoryInfo(transaction, dirName, PathFormat.Relative);
      }

      #endregion // GetParentInternal


      #region DeleteEmptyDirectoryInternal

      /// <summary>[AlphaFS] Unified method DeleteEmptyDirectoryInternal() to delete empty subdirectores from the specified directory.</summary>
      /// <remarks>Trailing spaces are removed from the end of the <paramref name="path"/> parameter before deleting the empty directory.</remarks>
      /// <exception cref="ArgumentException">The path parameter contains invalid characters, is empty, or contains only white spaces.</exception>
      /// <exception cref="ArgumentNullException">path is <see langword="null"/>.</exception>
      /// <exception cref="DirectoryNotFoundException ">path is <see langword="null"/>.</exception>
      /// <param name="fileSystemEntryInfo">A FileSystemEntryInfo instance. Use either <paramref name="fileSystemEntryInfo"/> or <paramref name="path"/>, not both.</param>
      /// <param name="transaction">The transaction.</param>
      /// <param name="path">The name of the directory to remove empty subdirectories from. Use either <paramref name="path"/> or <paramref name="fileSystemEntryInfo"/>, not both.</param>
      /// <param name="recursive"><see langword="true"/> deletes empty subdirectories from this directory and its subdirectories.</param>
      /// <param name="ignoreReadOnly"><see langword="true"/> overrides read only <see cref="FileAttributes"/> of empty directories.</param>
      /// <param name="initialize">When <see langword="true"/> indicates the method is called externally.</param>
      /// <param name="pathFormat">Indicates the format of the path parameter(s).</param>
      [SecurityCritical]
      internal static void DeleteEmptyDirectoryInternal(FileSystemEntryInfo fileSystemEntryInfo, KernelTransaction transaction, string path, bool recursive, bool ignoreReadOnly, bool initialize, PathFormat pathFormat)
      {
         #region Setup

         if (pathFormat == PathFormat.Relative)
            Path.CheckValidPath(path, true, true);

         if (fileSystemEntryInfo == null)
         {
            if (!File.ExistsInternal(true, transaction, path, pathFormat))
               NativeError.ThrowException(Win32Errors.ERROR_PATH_NOT_FOUND, path);

            fileSystemEntryInfo = File.GetFileSystemEntryInfoInternal(transaction,
               Path.GetExtendedLengthPathInternal(transaction, path, pathFormat, GetFullPathOptions.TrimEnd | GetFullPathOptions.RemoveTrailingDirectorySeparator | GetFullPathOptions.CheckInvalidPathChars | GetFullPathOptions.CheckAdditional)
               , false, PathFormat.LongFullPath);
         }

         if (fileSystemEntryInfo == null)
            throw new ArgumentNullException("path");

         string pathLp = fileSystemEntryInfo.LongFullPath;

         #endregion // Setup

         // Ensure path is a directory.
         if (!fileSystemEntryInfo.IsDirectory)
            throw new IOException(String.Format(CultureInfo.CurrentCulture, Resources.FileExistsWithSameNameSpecifiedByPath, pathLp));

         DirectoryEnumerationOptions dirEnumOptions = DirectoryEnumerationOptions.Folders;
         if (recursive)
            dirEnumOptions |= DirectoryEnumerationOptions.Recursive;

         foreach (FileSystemEntryInfo fsei in EnumerateFileSystemEntryInfosInternal<FileSystemEntryInfo>(transaction, pathLp, Path.WildcardStarMatchAll, dirEnumOptions, PathFormat.LongFullPath))
            DeleteEmptyDirectoryInternal(fsei, transaction, null, recursive, ignoreReadOnly, false, PathFormat.LongFullPath);


         if (!EnumerateFileSystemEntryInfosInternal<string>(transaction, pathLp, Path.WildcardStarMatchAll, DirectoryEnumerationOptions.FilesAndFolders, PathFormat.LongFullPath).Any())
         {
            // Prevent deleting path itself.
            if (!initialize)
               DeleteDirectoryInternal(fileSystemEntryInfo, transaction, null, false, ignoreReadOnly, true, true, PathFormat.LongFullPath);
         }
      }

      #endregion // DeleteEmptyDirectoryInternal

      #region EnableDisableEncryptionInternal

      /// <summary>[AlphaFS] Enables encryption of the specified directory and the files in it. It does not affect encryption of subdirectories below the indicated directory.</summary>
      /// <param name="path">The name of the directory for which to enable encryption.</param>
      /// <param name="enable"><see langword="true"/> enabled encryption, <see langword="false"/> disables encryption.</param>
      /// <param name="pathFormat">Indicates the format of the path parameter(s).</param>
      /// <remarks>This method will create/change the file "Desktop.ini" and wil set Encryption value: "Disable=0 | 1"</remarks>
      [SecurityCritical]
      internal static void EnableDisableEncryptionInternal(string path, bool enable, PathFormat pathFormat)
      {
         if (Utils.IsNullOrWhiteSpace(path))
            throw new ArgumentNullException("path");

         string pathLp = Path.GetExtendedLengthPathInternal(null, path, pathFormat, GetFullPathOptions.RemoveTrailingDirectorySeparator | GetFullPathOptions.CheckInvalidPathChars | GetFullPathOptions.CheckAdditional);

         // EncryptionDisable()
         // In the ANSI version of this function, the name is limited to 248 characters.
         // To extend this limit to 32,767 wide characters, call the Unicode version of the function and prepend "\\?\" to the path.
         // 2013-01-13: MSDN does not confirm LongPath usage but a Unicode version of this function exists.

         if (!NativeMethods.EncryptionDisable(pathLp, !enable))
            NativeError.ThrowException(pathLp);
      }

      #endregion // EnableDisableEncryptionInternal

      #region EncryptDecryptDirectoryInternal

      /// <summary>[AlphaFS] Unified method EncryptDecryptFileInternal() to decrypt/encrypt a directory recursively so that only the account used to encrypt the directory can decrypt it.</summary>
      /// <param name="path">A path that describes a directory to encrypt.</param>
      /// <param name="encrypt"><see langword="true"/> encrypt, <see langword="false"/> decrypt.</param>
      /// <param name="recursive"><see langword="true"/> to decrypt the directory recursively. <see langword="false"/> only decrypt files and directories in the root of <paramref name="path"/>.</param>
      /// <param name="pathFormat">Indicates the format of the path parameter(s).</param>
      [SecurityCritical]
      internal static void EncryptDecryptDirectoryInternal(string path, bool encrypt, bool recursive, PathFormat pathFormat)
      {
         string pathLp = Path.GetExtendedLengthPathInternal(null, path, pathFormat, GetFullPathOptions.RemoveTrailingDirectorySeparator | GetFullPathOptions.CheckInvalidPathChars | GetFullPathOptions.CheckAdditional);

         var directoryEnumerationOptions = DirectoryEnumerationOptions.FilesAndFolders | DirectoryEnumerationOptions.AsLongPath;

         if (recursive)
            directoryEnumerationOptions |= DirectoryEnumerationOptions.Recursive;


         // Process folders and files.
         foreach (string fso in EnumerateFileSystemEntryInfosInternal<string>(null, pathLp, Path.WildcardStarMatchAll, directoryEnumerationOptions, PathFormat.LongFullPath))
            File.EncryptDecryptFileInternal(true, fso, encrypt, PathFormat.LongFullPath);

         // Process the root folder, the given path.
         File.EncryptDecryptFileInternal(true, pathLp, encrypt, PathFormat.LongFullPath);
      }

      #endregion // EncryptDecryptDirectoryInternal

      #region EnumerateFileIdBothDirectoryInfoInternal

      /// <summary>[AlphaFS] Unified method EnumerateFileIdBothDirectoryInfoInternal() to return an enumerable collection of information about files in the directory handle specified.</summary>
      /// <param name="transaction">The transaction.</param>
      /// <param name="safeHandle">An open handle to the directory from which to retrieve information.</param>
      /// <param name="path">A path to the directory.</param>
      /// <param name="shareMode">The <see cref="FileShare"/> mode with which to open a handle to the directory.</param>
      /// <param name="continueOnException">
      /// <para><see langword="true"/> suppress any Exception that might be thrown a result from a failure,</para>
      /// <para>such as ACLs protected directories or non-accessible reparse points.</para>
      /// </param>
      /// <param name="pathFormat">Indicates the format of the path parameter(s).</param>
      /// <returns>An IEnumerable of <see cref="FileIdBothDirectoryInfo"/> records for each file system entry in the specified diretory.</returns>    
      /// <remarks>Either use <paramref name="path"/> or <paramref name="safeHandle"/>, not both.</remarks>
      [SecurityCritical]
      internal static IEnumerable<FileIdBothDirectoryInfo> EnumerateFileIdBothDirectoryInfoInternal(KernelTransaction transaction, SafeFileHandle safeHandle, string path, FileShare shareMode, bool continueOnException, PathFormat pathFormat)
      {
         if (!NativeMethods.IsAtLeastWindowsVista)
            throw new PlatformNotSupportedException(Resources.RequiresWindowsVistaOrHigher);

         bool callerHandle = safeHandle != null;
         if (!callerHandle)
         {
            if (Utils.IsNullOrWhiteSpace(path))
               throw new ArgumentNullException("path");

            string pathLp = Path.GetExtendedLengthPathInternal(transaction, path, pathFormat, GetFullPathOptions.RemoveTrailingDirectorySeparator | GetFullPathOptions.CheckInvalidPathChars | GetFullPathOptions.CheckAdditional);
            safeHandle = File.CreateFileInternal(transaction, pathLp, ExtendedFileAttributes.BackupSemantics, null, FileMode.Open, FileSystemRights.ReadData, shareMode, true, PathFormat.LongFullPath);
         }


         try
         {
            if (!NativeMethods.IsValidHandle(safeHandle, Marshal.GetLastWin32Error(), !continueOnException))
               yield break;

            // 2014-10-16: Number of returned items depends on the size of the buffer.
            // That does not seem right, investigate.
            using (SafeGlobalMemoryBufferHandle safeBuffer = new SafeGlobalMemoryBufferHandle(NativeMethods.DefaultFileBufferSize))
            {
               NativeMethods.IsValidHandle(safeBuffer, Marshal.GetLastWin32Error());

               long fileNameOffset = Marshal.OffsetOf(typeof(NativeMethods.FileIdBothDirInfo), "FileName").ToInt64();

               while (NativeMethods.GetFileInformationByHandleEx(safeHandle, NativeMethods.FileInfoByHandleClass.FileIdBothDirectoryInfo, safeBuffer, NativeMethods.DefaultFileBufferSize))
               {
                  // CA2001:AvoidCallingProblematicMethods

                  IntPtr buffer = IntPtr.Zero;
                  bool successRef = false;
                  safeBuffer.DangerousAddRef(ref successRef);

                  // MSDN: The DangerousGetHandle method poses a security risk because it can return a handle that is not valid.
                  if (successRef)
                     buffer = safeBuffer.DangerousGetHandle();

                  safeBuffer.DangerousRelease();

                  if (buffer == IntPtr.Zero)
                     NativeError.ThrowException(Resources.HandleDangerousRef);

                  // CA2001:AvoidCallingProblematicMethods


                  while (buffer != IntPtr.Zero)
                  {
                     NativeMethods.FileIdBothDirInfo fibdi = Utils.MarshalPtrToStructure<NativeMethods.FileIdBothDirInfo>(0, buffer);

                     string fileName = Marshal.PtrToStringUni(new IntPtr(fileNameOffset + buffer.ToInt64()), (int)(fibdi.FileNameLength / 2));

                     if (!Utils.IsNullOrWhiteSpace(fileName) &&
                         !fileName.Equals(Path.CurrentDirectoryPrefix, StringComparison.OrdinalIgnoreCase) &&
                         !fileName.Equals(Path.ParentDirectoryPrefix, StringComparison.OrdinalIgnoreCase))
                        yield return new FileIdBothDirectoryInfo(fibdi, fileName);


                     buffer = fibdi.NextEntryOffset == 0
                        ? IntPtr.Zero
                        : new IntPtr(buffer.ToInt64() + fibdi.NextEntryOffset);
                  }
               }

               int lastError = Marshal.GetLastWin32Error();
               switch ((uint)lastError)
               {
                  case Win32Errors.ERROR_SUCCESS:
                  case Win32Errors.ERROR_NO_MORE_FILES:
                  case Win32Errors.ERROR_HANDLE_EOF:
                     yield break;

                  default:
                     NativeError.ThrowException(lastError, path);
                     break;
               }
            }
         }
         finally
         {
            // Handle is ours, dispose.
            if (!callerHandle && safeHandle != null)
               safeHandle.Close();
         }
      }

      #endregion // EnumerateFileIdBothDirectoryInfoInternal

      #region EnumerateLogicalDrivesInternal

      /// <summary>[AlphaFS] Unified method EnumerateLogicalDrivesInternal() to enumerate the drive names of all logical drives on a computer.</summary>
      /// <param name="fromEnvironment">Retrieve logical drives as known by the Environment.</param>
      /// <param name="isReady">Retrieve only when accessible (IsReady) logical drives.</param>
      /// <returns>An IEnumerable of type <see cref="Alphaleonis.Win32.Filesystem.DriveInfo"/> that represents the logical drives on a computer.</returns>
      [SecurityCritical]
      internal static IEnumerable<DriveInfo> EnumerateLogicalDrivesInternal(bool fromEnvironment, bool isReady)
      {
         #region Get from Environment

         if (fromEnvironment)
         {
            IEnumerable<string> drivesEnv = isReady
               ? Environment.GetLogicalDrives().Where(ld => File.ExistsInternal(true, null, ld, PathFormat.FullPath))
               : Environment.GetLogicalDrives().Select(ld => ld);

            foreach (string drive in drivesEnv)
            {
               // Optionally check Drive .IsReady.
               if (isReady)
               {
                  if (File.ExistsInternal(true, null, drive, PathFormat.FullPath))
                     yield return new DriveInfo(drive);
               }
               else
                  yield return new DriveInfo(drive);
            }

            yield break;
         }

         #endregion // Get from Environment

         #region Get through NativeMethod

         uint lastError = NativeMethods.GetLogicalDrives();
         if (lastError == Win32Errors.ERROR_SUCCESS)
            // Throws IOException.
            NativeError.ThrowException((int)lastError, true);

         uint drives = lastError;
         int count = 0;
         while (drives != 0)
         {
            if ((drives & 1) != 0)
               ++count;

            drives >>= 1;
         }

         string[] result = new string[count];
         char[] root = { 'A', Path.VolumeSeparatorChar };

         drives = lastError;
         count = 0;

         while (drives != 0)
         {
            if ((drives & 1) != 0)
            {
               string drive = new string(root);

               if (isReady)
               {
                  // Optionally check Drive .IsReady.
                  if (File.ExistsInternal(true, null, drive, PathFormat.FullPath))
                     yield return new DriveInfo(drive);
               }
               else
               {
                  // Ready or not.
                  yield return new DriveInfo(drive);
               }

               result[count++] = drive;
            }

            drives >>= 1;
            root[0]++;
         }

         #endregion // Get through NativeMethod
      }

      #endregion // EnumerateLogicalDrivesInternal

      #region GetPropertiesInternal

      /// <summary>[AlphaFS] Unified method GetPropertiesInternal() to gets the properties of the particular directory without following any symbolic links or mount points.
      /// Properties include aggregated info from <see cref="FileAttributes"/> of each encountered file system object.
      /// Plus additional ones: "Total", "File", "Size" and "SizeCompressed".
      /// <para><b>Total:</b> is the total number of enumerated objects.</para>
      /// <para><b>File:</b> is the total number of files. File is considered when object is neither <see cref="FileAttributes.Directory"/> nor <see cref="FileAttributes.ReparsePoint"/>.</para>
      /// <para><b>Size:</b> is the total size of enumerated objects.</para>
      /// <para><b>Size:</b> is the total compressed size of enumerated objects.</para>
      /// <para><b>Error:</b> is the total number of errors encountered during enumeration.</para>
      /// </summary>
      /// <remarks><b>Directory:</b> is an object which has <see cref="FileAttributes.Directory"/> attribute without <see cref="FileAttributes.ReparsePoint"/> one.</remarks>
      /// <param name="transaction">The transaction.</param>
      /// <param name="path">The target directory.</param>
      /// <param name="directoryEnumerationOptions"><see cref="DirectoryEnumerationOptions"/> flags that specify how the directory is to be enumerated.</param>
      /// <param name="pathFormat">Indicates the format of the path parameter(s).</param>
      /// <returns>A dictionary mapping the keys mentioned above to their respective aggregated values.</returns>
      [SecurityCritical]
      internal static Dictionary<string, long> GetPropertiesInternal(KernelTransaction transaction, string path, DirectoryEnumerationOptions directoryEnumerationOptions, PathFormat pathFormat)
      {
         const string propFile = "File";
         const string propTotal = "Total";
         const string propSize = "Size";
         long total = 0;
         long size = 0;
         Type typeOfAttrs = typeof(FileAttributes);
         Array attributes = Enum.GetValues(typeOfAttrs);
         Dictionary<string, long> props = Enum.GetNames(typeOfAttrs).OrderBy(attrs => attrs).ToDictionary<string, string, long>(name => name, name => 0);

         string pathLp = Path.GetExtendedLengthPathInternal(transaction, path, pathFormat, GetFullPathOptions.RemoveTrailingDirectorySeparator | GetFullPathOptions.CheckInvalidPathChars | GetFullPathOptions.CheckAdditional);

         foreach (FileSystemEntryInfo fsei in EnumerateFileSystemEntryInfosInternal<FileSystemEntryInfo>(transaction, pathLp, Path.WildcardStarMatchAll, directoryEnumerationOptions, PathFormat.LongFullPath))
         {
            total++;

            if (!fsei.IsDirectory)
               size += fsei.FileSize;

            foreach (FileAttributes attributeMarker in attributes)
            {
               // Marker exists in flags.
               if ((fsei.Attributes & attributeMarker) == attributeMarker)

                  // Regular directory that will go to stack, adding directory flag ++
                  props[(((attributeMarker & FileAttributes.Directory) == FileAttributes.Directory) ? FileAttributes.Directory : attributeMarker).ToString()]++;
            }
         }

         // Adjust regular files count.
         props.Add(propFile, total - props[FileAttributes.Directory.ToString()] - props[FileAttributes.ReparsePoint.ToString()]);
         props.Add(propTotal, total);
         props.Add(propSize, size);

         return props;
      }

      #endregion // GetPropertiesInternal

      #endregion // Unified Internals

      #endregion // AlphaFS
   }
}