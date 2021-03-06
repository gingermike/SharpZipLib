using System;
#if NET45
using System.Runtime.Serialization;
#endif

namespace ICSharpCode.SharpZipLib.Zip
{
    /// <summary>
    /// ZipException represents exceptions specific to Zip classes and code.
    /// </summary>
#if NET45
	[Serializable]
#endif
	public class ZipException : SharpZipBaseException
	{

#if NET45
        /// <summary>
        /// Deserialization constructor 
        /// </summary>
        /// <param name="info"><see cref="SerializationInfo"/> for this constructor</param>
        /// <param name="context"><see cref="StreamingContext"/> for this constructor</param>
        protected ZipException(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
		}

#endif

		/// <summary>
		/// Initialise a new instance of <see cref="ZipException" />.
		/// </summary>
		public ZipException()
		{
		}

		/// <summary>
		/// Initialise a new instance of <see cref="ZipException" /> with its message string.
		/// </summary>
		/// <param name="message">A <see cref="string"/> that describes the error.</param>
		public ZipException(string message)
			: base(message)
		{
		}

		/// <summary>
		/// Initialise a new instance of <see cref="ZipException" />.
		/// </summary>
		/// <param name="message">A <see cref="string"/> that describes the error.</param>
		/// <param name="innerException">The <see cref="Exception"/> that caused this exception.</param>
		public ZipException(string message, Exception innerException)
			: base(message, innerException)
		{
		}
	}
}
