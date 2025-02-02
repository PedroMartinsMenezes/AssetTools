using System.Text;

namespace AssetTool
{
    public class TransferReader : Transfer
    {
        public TransferReader(BinaryReader reader)
        {
            this.reader = reader;
        }

        public override bool IsReading => true;
        public override bool IsWriting => false;
        public override bool FromJson { get; init; } = false;
        public override long Position { get { return reader.BaseStream.Position; } set { reader.BaseStream.Position = value; } }
        public override long Length => reader.BaseStream.Length;
        public override long Counter { get; set; }
        public override Stream Stream => reader.BaseStream;

        #region
        public override void MoveFloat(ref double value) => value = reader.ReadSingle();
        public override void Move(ref sbyte value) => reader.Read(ref value);
        public override void Move(ref byte value) => reader.Read(ref value);
        public override void Move(ref short value) => reader.Read(ref value);
        public override void Move(ref ushort value) => reader.Read(ref value);
        public override void Move(ref int value) => reader.Read(ref value);
        public override void Move(ref uint value) => reader.Read(ref value);
        public override void Move(ref long value) => reader.Read(ref value);
        public override void Move(ref ulong value) => reader.Read(ref value);
        public override void Move(ref float value) => reader.Read(ref value);
        public override void Move(ref double value) => reader.Read(ref value);
        public override void MoveSingleOrDouble(ref double value) => value = Supports.LARGE_WORLD_COORDINATES ? reader.ReadDouble() : (double)reader.ReadSingle();
        #endregion

        #region
        public override sbyte Move(sbyte value) => reader.Read(ref value);
        public override byte Move(byte value) => reader.Read(ref value);
        public override short Move(short value) => reader.Read(ref value);
        public override ushort Move(ushort value) => reader.Read(ref value);
        public override int Move(int value) => reader.Read(ref value);
        public override uint Move(uint value) => reader.Read(ref value);
        public override long Move(long value) => reader.Read(ref value);
        public override ulong Move(ulong value) => reader.Read(ref value);
        public override float Move(float value) => reader.Read(ref value);
        public override double Move(double value) => reader.Read(ref value);

        public override void Move(ref float[] value, int size) => value = Enumerable.Range(0, size).Select(x => reader.ReadSingle()).ToArray();
        public override void Move(ref byte[] value, int size) => value = Enumerable.Range(0, size).Select(x => reader.ReadByte()).ToArray();
        public override void Move(ref Int16[] value, int size) => value = Enumerable.Range(0, size).Select(x => reader.ReadInt16()).ToArray();
        public override void Move(ref UInt16[] value, int size) => value = Enumerable.Range(0, size).Select(x => reader.ReadUInt16()).ToArray();
        public override void Move(ref UInt32[] value, int size) => value = Enumerable.Range(0, size).Select(x => reader.ReadUInt32()).ToArray();
        public override void Move(ref byte[] value) => value = Enumerable.Range(0, reader.ReadInt32()).Select(x => reader.ReadByte()).ToArray();
        #endregion

        public override void MoveObject<T>(ref T value)
        {
            value ??= Activator.CreateInstance<T>();
            value.Move(this);
        }

        #region ITransferibleRaw
        public override void MoveRaw<T>(ref T value)
        {
            value ??= Activator.CreateInstance<T>();
            value.MoveRaw(this);
        }
        #endregion

        #region ITransferible
        public override void Move<T>(ref T value)
        {
            value ??= Activator.CreateInstance<T>();
            value.Move(this);
        }
        public override void Move<T>(ref List<T> value)
        {
            value ??= new();
            value.Resize(this);
            value.ForEach(item => item.Move(this));
        }
        public override void Move<T>(ref List<T> value, ref int elementSize)
        {
            value ??= new();
            this.Move(ref elementSize);
            value.Resize(this);
            value.ForEach(item => item.Move(this));
        }
        public override void Move<T>(ref List<T> value, int count)
        {
            value ??= new();
            value.Resize(this, count);
            value.ForEach(item => item.Move(this));
        }
        public override void Move<T>(ref T[] value)
        {
            for (int i = 0; i < value.Length; i++)
            {
                value[i].Move(this);
            }
        }
        public override void Move<T>(ref T[] value, int size)
        {
            value ??= new T[size];
            for (int i = 0; i < value.Length; i++)
            {
                value[i] ??= Activator.CreateInstance<T>();
                value[i].Move(this);
            }
        }

        public override void Move<T1, T2>(ref Dictionary<T1, T2> value)
        {
            value ??= new();
            value.Resize(this);
            foreach (var pair in value)
            {
                pair.Key.Move(this);
                pair.Value.Move(this);
            }
        }
        public override void Move<T1, T2>(ref Dictionary<T1, List<T2>> value)
        {
            value ??= new();
            value.Resize(this);
            foreach (var pair in value)
            {
                pair.Key.Move(this);
                pair.Value.Resize(this);
                pair.Value.ForEach(item => item.Move(this));
            }
        }
        #endregion

        #region List
        public override void Move(ref List<sbyte> value) => value = Enumerable.Range(0, reader.ReadInt32()).Select(x => reader.ReadSByte()).ToList();
        public override void Move(ref List<byte> value) => value = Enumerable.Range(0, reader.ReadInt32()).Select(x => reader.ReadByte()).ToList();
        public override void Move(ref List<Int16> value) => value = Enumerable.Range(0, reader.ReadInt32()).Select(x => reader.ReadInt16()).ToList();
        public override void Move(ref List<UInt16> value) => value = Enumerable.Range(0, reader.ReadInt32()).Select(x => reader.ReadUInt16()).ToList();
        public override void Move(ref List<Int32> value) => value = Enumerable.Range(0, reader.ReadInt32()).Select(x => reader.ReadInt32()).ToList();
        public override void Move(ref List<UInt32> value) => value = Enumerable.Range(0, reader.ReadInt32()).Select(x => reader.ReadUInt32()).ToList();
        public override void Move(ref List<float> value) => value = Enumerable.Range(0, reader.ReadInt32()).Select(x => reader.ReadSingle()).ToList();
        public override void Move<T>(ref List<T> value, Action<T> action)
        {
            value ??= new();
            value.Resize(this);
            value.ForEach(item => action(item));
        }
        #endregion

        #region Dictionary
        public override void Move<T1, T2>(ref Dictionary<T1, T2> value, Action<T1> act1, Action<T2> act2)
        {
            value ??= new();
            value.Resize(this);
            foreach (var pair in value)
            {
                act1(pair.Key);
                act2(pair.Value);
            }
        }
        #endregion

        #region
        public override FBool Move(FBool value)
        {
            value ??= new();
            value.Value = reader.ReadInt32() == 1;
            return value;
        }
        public override void Move(ref FBool value)
        {
            int number = reader.ReadInt32();
            if (number > 1)
                Log.Error($"    [Warning] Wrong bool value {number} at {reader.BaseStream.Position}");
            value = new FBool(number);
        }
        public override FGuid Move(FGuid value)
        {
            byte[] bytes = reader.ReadBytes(16);
            value.Value = new FGuid(bytes).Value;
            return value;
        }
        public override void Move(ref FGuid value)
        {
            byte[] bytes = reader.ReadBytes(16);
            value = Array.Exists(bytes, x => x != 0) ? new FGuid(bytes) : null;
        }
        public override FName Move(FName value)
        {
            var transfer = GlobalObjects.Transfer;
            value ??= new();

            value.ComparisonIndex.Move(transfer);

            if (!GlobalNames.IsValid(value.ComparisonIndex))
                throw new InvalidOperationException($"Invalid name index {value.ComparisonIndex.Value}");

            reader.Read(ref value.Number);
            return value;
        }
        public override void Move(ref FName value)
        {
            var transfer = GlobalObjects.Transfer;
            value ??= new();

            value.ComparisonIndex.Move(transfer);

            if (!GlobalNames.IsValid(value.ComparisonIndex))
                throw new InvalidOperationException($"Invalid name index {value.ComparisonIndex.Value}");

            reader.Read(ref value.Number);
        }
        public override FString Move(FString value)
        {
            Move(ref value);
            return value;
        }
        public override void Move(ref FString value)
        {
            int size = reader.ReadInt32();
            if (size > 1024 * 1024) throw new InvalidOperationException("FString to big");
            bool bLoadUnicodeChar = size < 0;
            if (bLoadUnicodeChar)
                size = -2 * size;
            if (size > 0)
            {
                value ??= new();
                if (bLoadUnicodeChar)
                {
                    value.IsUnicode = true;
                    byte[] bytes = new byte[size];
                    reader.Read(bytes, 0, size);
                    string text = Encoding.Unicode.GetString(bytes);
                    value.Value = text;
                    if (AppConfig.DebugUnicodeStrings)
                    {
                        GlobalObjects.UnicodeStrings.Add(text);
                    }
                }
                else
                {
                    byte[] bytes = size == 1 ? [0] : new byte[size - 1];
                    reader.Read(bytes, 0, size - 1);
                    string text = Encoding.ASCII.GetString(bytes);
                    _ = reader.ReadByte();
                    value.Value = text;
                }
            }
        }
        public override FText Move(FText value)
        {
            value ??= new();
            value.Move(this);
            return value;
        }
        public override void Move(ref FText value)
        {
            value ??= new();
            value.Move(this);
        }
        public override void Move(ref FTextKey value)
        {
            int size = reader.ReadInt32();
            if (size > 1024)
            {
                throw new InvalidOperationException("FTextKey to big");
            }
            if (size > 0)
            {
                value ??= new();
                byte[] bytes = new byte[size - 1];

                reader.Read(bytes, 0, size - 1);
                _ = reader.ReadByte();

                value.Value = Encoding.ASCII.GetString(bytes);
            }
        }
        #endregion
    }
}
