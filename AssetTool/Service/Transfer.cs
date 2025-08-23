using System.Text;

namespace AssetTool
{
    public abstract class Transfer
    {
        public BinaryReader reader;
        public BinaryWriter writer;
        public bool IsMoveStream { get; set; }
        public GlobalNames GlobalNames { get; set; } = new();
        public GlobalObjects GlobalObjects { get; set; } = new();
        public Supports Supports { get; set; }
        public SupportsAfter SupportsAfter { get; set; }

        public void Initialize(Transfer other)
        {
            GlobalNames = other?.GlobalNames ?? GlobalNames;
            GlobalObjects = other?.GlobalObjects ?? GlobalObjects;
            Supports = new Supports(other ?? this);
            SupportsAfter = new SupportsAfter(other ?? this);
        }

        public abstract bool IsReading { get; }
        public abstract bool IsWriting { get; }
        public abstract bool FromJson { get; init; }
        public abstract long Position { get; set; }
        public abstract long Length { get; }
        public abstract long Counter { get; set; }
        public abstract long BaseOffset { get; set; }
        public abstract Stream Stream { get; }

        public abstract void MoveConst(Int32 value);

        public abstract void MoveAsUInt16(ref Int32 value);
        public abstract void MoveAsUInt16(ref Int32? value);

        public abstract void MoveAsByte(ref UInt16 value);
        public abstract void MoveAsByte(ref UInt16? value);

        public abstract void MoveAsInt(ref Int64 value);
        public abstract void MoveAsInt(ref Int64? value);

        public abstract void MoveEnum<T>(ref T value) where T : struct;
        public abstract void MoveEnum<T>(ref T? value) where T : struct;
        public abstract void MoveEnum<T>(ref T[] value) where T : struct;
        public abstract void MoveEnum<T>(ref T[] value, int index) where T : struct;

        public abstract void MoveFloat(ref double value);
        public abstract void MoveFloat(ref double? value);

        public abstract void Move(ref bool value);
        public abstract void Move(ref bool? value);

        public abstract void Move(ref sbyte value);
        public abstract void Move(ref sbyte? value);

        public abstract void Move(ref byte value);
        public abstract void Move(ref byte? value);

        public abstract void Move(ref short value);
        public abstract void Move(ref short? value);

        public abstract void Move(ref ushort value);
        public abstract void Move(ref ushort? value);

        public abstract void Move(ref int value);
        public abstract void Move(ref int? value);

        public abstract void Move(ref uint value);
        public abstract void Move(ref uint? value);

        public abstract void Move(ref long value);
        public abstract void Move(ref long? value);

        public abstract void Move(ref ulong value);
        public abstract void Move(ref ulong? value);

        public abstract void Move(ref float value);
        public abstract void Move(ref float? value);

        public abstract void Move(ref double value);
        public abstract void Move(ref double? value);

        public abstract void MoveSingleOrDouble(ref double value);
        public abstract void MoveSingleOrDouble(ref double? value);

        public abstract void Move(ref float[] value, int count);
        public abstract void Move(ref byte[] value, int count);
        public abstract void Move(ref Int16[] value, int count);
        public abstract void Move(ref UInt16[] value, int count);
        public abstract void Move(ref UInt32[] value, int count);

        public abstract void Move(ref byte[] value);
        public abstract void Move(ref UInt16[] value);
        public abstract void Move(ref Int32[] value);
        public abstract void Move(ref UInt32[] value);
        public abstract void Move(ref Int64[] value);
        public abstract void Move(ref UInt64[] value);
        public abstract void Move(ref float[] value);
        public abstract void Move(ref double[] value);

        public abstract void Move<T>(ref T value, Action<T> action) where T : new();

        public abstract void Move<T>(ref T value) where T : ITransferible, new();
        public abstract void Move<T, T1>(ref T value, T1 arg1) where T : ITransferible<T1>, new();
        public abstract void Move<T, T1, T2>(ref T value, T1 arg1, T2 arg2) where T : ITransferible<T1, T2>, new();
        public abstract void Move<T, T1, T2, T3>(ref T value, T1 arg1, T2 arg2, T3 arg3) where T : ITransferible<T1, T2, T3>, new();

        public abstract void MoveRaw<T>(ref T value) where T : struct;
        public abstract void MoveRaw<T>(ref T[] value) where T : struct;

        public abstract void Move<T>(ref List<T> value) where T : ITransferible, new();
        public abstract void Move<T, T1, T2>(ref List<T> value, T1 a, T2 b) where T : ITransferible<T1, T2>, new();
        public abstract void Move<T>(ref List<List<T>> value) where T : ITransferible, new();
        public abstract void Move<T>(ref List<List<T>> value, int count) where T : ITransferible, new();
        public abstract void Move<T>(ref List<T> value, int count) where T : ITransferible, new();
        public abstract void Move<T>(ref T[] value) where T : ITransferible, new();
        public abstract void Move<T>(ref T[] value, int count) where T : ITransferible, new();

        public abstract void Move<T1, T2>(ref Dictionary<T1, T2> value) where T1 : ITransferible, new() where T2 : ITransferible, new();
        public abstract void Move<T1, T2>(ref Dictionary<T1, T2> value, int count) where T1 : ITransferible, new() where T2 : ITransferible, new();
        public abstract void Move<T1, T2>(ref Dictionary<T1, List<T2>> value) where T1 : ITransferible, new() where T2 : ITransferible, new();
        public abstract void Move<T1, T2, T3>(ref Dictionary<T1, Dictionary<T2, T3>> value) where T1 : ITransferible, new() where T2 : ITransferible, new() where T3 : ITransferible, new();
        public abstract void Move<T1, T2>(ref Dictionary<T1, T2> value, Action<T2> valueAction) where T1 : ITransferible, new() where T2 : ITransferible, new();

        public abstract void Move<T>(ref List<T> value, Action<T> action) where T : new();
        public abstract void Move<T>(ref List<T> value, int count, Action<T> action) where T : new();

        public abstract void MoveWhile<T>(ref List<T> value, Func<bool> condition, Action<T> action) where T : new();

        public abstract void Move(ref FBool value);
        public abstract void Move(ref FBool? value);
        public abstract FGuid Move(FGuid value);
        public abstract void Move(ref FGuid value);
        public abstract void Move(ref FGuid? value);
        public abstract FName Move(FName value);
        public abstract void Move(ref FName value);
        public abstract FString Move(FString value);
        public abstract void Move(ref FString value);
        public abstract FText Move(FText value);
        public abstract void Move(ref FText value);
        public abstract void Move(ref FTextKey value);

        public abstract void Resize<T>(ref List<T> value, bool withNull = false) where T : new();
        public abstract void Resize<T>(ref List<T> value, int count, bool withNull = false) where T : new();
        public abstract void Resize<T>(ref T[] value, int count, bool withNull = false) where T : new();

        public bool AutoCheck<T>(string name, T self, Func<object> action) where T : ITransferible, new()
        {
            string msg = string.Empty;
            Stream source = IsReading ? this.reader.BaseStream : this.writer.BaseStream;
            long before = source.Position;
            action();
            if (IsWriting) return true;
            long after = source.Position;
            long[] offsets = [before, after];

            byte[] sourceBytes = new byte[offsets[1] - offsets[0]];
            using BinaryReader newReader = new BinaryReader(source, Encoding.Default, true);

            newReader.BaseStream.Position = offsets[0];
            newReader.Read(sourceBytes);

            Log.WriteFileNumber = Log.WriteFileNumber == 0 ? 0 : 1;
            using MemoryStream dest = new();
            using BinaryWriter writer1 = new BinaryWriter(dest);
            using TransferWriter transferWriter = new TransferWriter(writer1, this);
            self.Move(transferWriter);

            byte[] destBytes = new byte[offsets[1] - offsets[0]];
            dest.Position = 0;
            _ = dest.Read(destBytes);

            if (!CompareBytes(sourceBytes, destBytes, offsets[0]))
                msg = $"    Binary Difference Found for {name}";

            var self2 = self.ToJsonThenToObjectFast(this);
            Log.WriteFileNumber = Log.WriteFileNumber == 0 ? 0 : 2;
            using MemoryStream dest2 = new();
            using BinaryWriter writer2 = new BinaryWriter(dest2);
            using TransferWriter transferWriter2 = new TransferWriter(writer2, this, true);
            self2.Move(transferWriter2);

            byte[] destBytes2 = new byte[offsets[1] - offsets[0]];
            dest2.Position = 0;
            _ = dest2.Read(destBytes2);

            if (msg.Length == 0 && !CompareBytes(sourceBytes, destBytes2, offsets[0]))
                msg = $"    Json Difference Found for {name}";

            if (msg.Length > 0)
            {
                Log.Error(msg);
                throw new InvalidOperationException(msg);
            }
            return msg.Length == 0;
        }

        private static bool CompareBytes(byte[] bytes1, byte[] bytes2, long offset)
        {
            if (bytes1.Length != bytes2.Length)
            {
                return false;
            }
            for (int i = 0; i < bytes1.Length; i++)
            {
                if (bytes1[i] != bytes2[i])
                {
                    Log.Enabled = true;
                    Log.Error($"\n    Wrong byte at {offset + i}. Expected: 0x{bytes1[i]:X}. Actual: 0x{bytes2[i]:X}");
                    return false;
                }
            }
            return true;
        }

        public void UpdateNameToIndexMap(FName name)
        {
            if (name.Number > 0)
            {
                GlobalNames.NameToIndexMap[name.DisplayValue] = (name.ComparisonIndex.Value, name.Number);
            }
        }
    }
}
