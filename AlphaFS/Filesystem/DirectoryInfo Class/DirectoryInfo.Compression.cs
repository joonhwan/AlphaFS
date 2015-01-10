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

using System.Security;

namespace Alphaleonis.Win32.Filesystem
{
   partial class DirectoryInfo
   {
      #region AlphaFS

      #region Compress

      /// <summary>[AlphaFS] Compresses a directory using NTFS compression.</summary>
      /// <remarks>This will only compress the root items, non recursive.</remarks>
      [SecurityCritical]
      public void Compress()
      {
         Directory.CompressDecompressInternal(Transaction, LongFullName, Path.WildcardStarMatchAll, DirectoryEnumerationOptions.FilesAndFolders, true, PathFormat.LongFullPath);
      }

      /// <summary>[AlphaFS] Compresses a directory using NTFS compression.</summary>
      /// <param name="directoryEnumerationOptions"><see cref="DirectoryEnumerationOptions"/> flags that specify how the directory is to be enumerated.</param>
      [SecurityCritical]
      public void Compress(DirectoryEnumerationOptions directoryEnumerationOptions)
      {
         Directory.CompressDecompressInternal(Transaction, LongFullName, Path.WildcardStarMatchAll, directoryEnumerationOptions, true, PathFormat.LongFullPath);
      }

      #endregion // Compress

      #region Decompress

      /// <summary>[AlphaFS] Decompresses an NTFS compressed directory.</summary>
      /// <remarks>This will only decompress the root items, non recursive.</remarks>
      [SecurityCritical]
      public void Decompress()
      {
         Directory.CompressDecompressInternal(Transaction, LongFullName, Path.WildcardStarMatchAll, DirectoryEnumerationOptions.FilesAndFolders, false, PathFormat.LongFullPath);
      }

      /// <summary>[AlphaFS] Decompresses an NTFS compressed directory.</summary>
      /// <param name="directoryEnumerationOptions"><see cref="DirectoryEnumerationOptions"/> flags that specify how the directory is to be enumerated.</param>
      [SecurityCritical]
      public void Decompress(DirectoryEnumerationOptions directoryEnumerationOptions)
      {
         Directory.CompressDecompressInternal(Transaction, LongFullName, Path.WildcardStarMatchAll, directoryEnumerationOptions, false, PathFormat.LongFullPath);
      }

      #endregion // Decompress

      #region DisableCompression

      /// <summary>[AlphaFS] Disables compression of the specified directory and the files in it.</summary>
      /// <remarks>
      /// This method disables the directory-compression attribute. It will not decompress the current contents of the directory.
      /// However, newly created files and directories will be uncompressed.
      /// </remarks>
      [SecurityCritical]
      public void DisableCompression()
      {
         Device.ToggleCompressionInternal(true, Transaction, LongFullName, false, PathFormat.LongFullPath);
      }

      #endregion // DisableCompression

      #region EnableCompression

      /// <summary>[AlphaFS] Enables compression of the specified directory and the files in it.</summary>
      /// <remarks>
      /// This method enables the directory-compression attribute. It will not compress the current contents of the directory.
      /// However, newly created files and directories will be compressed.
      /// </remarks>
      [SecurityCritical]
      public void EnableCompression()
      {
         Device.ToggleCompressionInternal(true, Transaction, LongFullName, true, PathFormat.LongFullPath);
      }

      #endregion // EnableCompression

      #endregion // AlphaFS
   }
}