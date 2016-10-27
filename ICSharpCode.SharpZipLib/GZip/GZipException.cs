using System;
#if NET45
using System.Runtime.Serialization;
#endif

namespace ICSharpCode.SharpZipLib.GZip
{
    /// <summary>
    /// GZipException represents exceptions specific to GZip classes and code.
    /// </summary>
#if NET45
	[Serializable]
#endif
	public class GZipException : SharpZipBaseException
	{

#if NET45
        /// <summary>
        /// Deserialization constructor 
        /// </summary>
        /// <param name="info"><see cref="SerializationInfo"/> for this constructor</param>
        /// <param name="context"><see cref="StreamingContext"/> for this constructor</param>
        protected GZipException(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
		}
#endif

		/// <summary>
		/// Initialise a new instance of <see cref="GZipException" />.
		/// </summary>
		public GZipException()
		{
		}

		/// <summary>
		/// Initialise a new instance of <see cref="GZipException" /> with its message string.
		/// </summary>
		/// <param name="message">A <see cref="string"/> that describes the error.</param>
		public GZipException(string message)
			: base(message)
		{
		}

		/// <summary>
		/// Initialise a new instance of <see cref="GZipException" />.
		/// </summary>
		/// <param name="message">A <see cref="string"/> that describes the error.</param>
		/// <param name="innerException">The <see cref="Exception"/> that caused this exception.</param>
		public GZipException(string message, Exception innerException)
			: base(message, innerException)
		{
		}
	}
}