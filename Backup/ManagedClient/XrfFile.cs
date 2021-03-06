﻿/* XrfFile.cs
 */

#region Using directives

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

#endregion

namespace ManagedClient
{
    /// <summary>
    /// Файл перекрестных ссылок XRF представляет собой
    /// таблицу ссылок на записи файла документов.
    /// Первая ссылка соответствует записи файла документов
    /// с номером 1, вторая – 2  и тд.
    /// </summary>
    public sealed class XrfFile
        : IDisposable
    {
        #region Constants
        #endregion

        #region Properties

        public string FileName { get; private set; }

        public bool InMemory { get; private set; }

        #endregion

        #region Construction

        public XrfFile
            (
                string fileName,
                bool inMemory
            )
        {
            FileName = fileName;
            InMemory = inMemory;

            _stream = new FileStream
                (
                    fileName,
                    FileMode.Open,
                    FileAccess.Read,
                   FileShare.ReadWrite
                );

            if (InMemory)
            {
                byte[] buffer = new byte[(int)_stream.Length];
                Stream memory = new MemoryStream(buffer);
                _stream.Read(buffer, 0, buffer.Length);
                _stream.Close();
                _stream = memory;
            }
        }

        #endregion

        #region Private members

        private Stream _stream;

        private long _GetOffset
            (
                int mfn
            )
        {
            long result = unchecked(XrfRecord.RecordSize * (mfn - 1));
            return result;
        }

        #endregion

        #region Public methods

        public XrfRecord ReadRecord
            (
                int mfn
            )
        {
            if (mfn <= 0)
            {
                throw new ArgumentOutOfRangeException("mfn");
            }

            long offset = _GetOffset(mfn);
            if (offset >= _stream.Length)
            {
                throw new ArgumentOutOfRangeException("mfn");
            }

            if (_stream.Seek(offset, SeekOrigin.Begin) != offset)
            {
                throw new IOException();
            }

            long ofs = _stream.ReadInt64Network();
            int flags = _stream.ReadInt32Network();

            XrfRecord result = new XrfRecord
                                   {
                                       Mfn = mfn,
                                       Offset = ofs,
                                       Status = (RecordStatus)flags
                                   };

            return result;
        }

        public void WriteRecord
            (
                XrfRecord record
            )
        {
            if (record == null)
            {
                throw new ArgumentNullException("record");
            }

        }

        public void LockRecord
            (
                int mfn,
                bool flag
            )
        {
            XrfRecord record = ReadRecord(mfn);
            if (flag != record.Locked)
            {
                WriteRecord(record);
            }
        }

        #endregion

        #region IDisposable members

        public void Dispose()
        {
            if (_stream != null)
            {
                _stream.Dispose();
                _stream = null;
            }
        }

        #endregion
    }
}
