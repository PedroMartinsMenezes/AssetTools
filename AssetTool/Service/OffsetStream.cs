namespace AssetTool
{
    /// <summary>
    /// Writable stream whose positions start at <see cref="BaseOffset"/>, storing only the bytes from there on.
    /// Lets an export be written on its own (in parallel) with the same absolute positions it has in the package.
    /// </summary>
    public sealed class OffsetStream : Stream
    {
        private readonly MemoryStream inner = new();

        public OffsetStream(long baseOffset)
        {
            BaseOffset = baseOffset;
        }

        public long BaseOffset { get; }

        /// <summary>The bytes written, starting at <see cref="BaseOffset"/>.</summary>
        public ReadOnlySpan<byte> WrittenBytes => new(inner.GetBuffer(), 0, (int)inner.Length);

        public override bool CanRead => true;
        public override bool CanSeek => true;
        public override bool CanWrite => true;
        public override long Length => BaseOffset + inner.Length;

        public override long Position
        {
            get => BaseOffset + inner.Position;
            set => inner.Position = value - BaseOffset;
        }

        public override long Seek(long offset, SeekOrigin origin)
        {
            if (origin == SeekOrigin.Begin)
                Position = offset;
            else
                inner.Seek(offset, origin);
            return Position;
        }

        public override void SetLength(long value) => inner.SetLength(value - BaseOffset);
        public override void Flush() => inner.Flush();

        public override int Read(byte[] buffer, int offset, int count) => inner.Read(buffer, offset, count);
        public override int Read(Span<byte> buffer) => inner.Read(buffer);
        public override int ReadByte() => inner.ReadByte();

        public override void Write(byte[] buffer, int offset, int count) => inner.Write(buffer, offset, count);
        public override void Write(ReadOnlySpan<byte> buffer) => inner.Write(buffer);
        public override void WriteByte(byte value) => inner.WriteByte(value);

        protected override void Dispose(bool disposing)
        {
            if (disposing)
                inner.Dispose();
            base.Dispose(disposing);
        }
    }
}
