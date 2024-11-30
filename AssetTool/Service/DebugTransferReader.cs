namespace AssetTool
{
    public class DebugTransferReader : TransferReader
    {
        public DebugTransferReader(BinaryReader reader) : base(reader) { }

        static DebugTransferReader()
        {
            File.WriteAllText("C:/Temp/DebugTransferReader.log", "");
        }

        private void Log(long position1, long position2)
        {
            if (position2 > position1)
            {
                byte[] bytes = new byte[position2 - position1];
                Position = position1;
                reader.Read(bytes, 0, (int)(position2 - position1));
                string content = BitConverter.ToString(bytes).Replace("-", "");
                File.AppendAllLines("C:/Temp/DebugTransferReader.log", [content]);
            }
        }

        private T Log<T>(Func<T> func)
        {
            long position1 = Position;
            T result = func();
            long position2 = Position;
            if (Position > position1)
            {
                byte[] bytes = new byte[position2 - position1];
                Position = position1;
                reader.Read(bytes, 0, (int)(position2 - position1));
                string content = BitConverter.ToString(bytes).Replace("-", "");
                File.AppendAllLines("C:/Temp/DebugTransferReader.log", [content]);
            }
            return result;
        }

        public override void Move(ref sbyte value)
        {
            long pos = Position;
            base.Move(ref value);
            Log(pos, Position);
        }

        public override void Move(ref byte value)
        {
            long pos = Position;
            base.Move(ref value);
            Log(pos, Position);
        }

        public override void Move(ref short value)
        {
            long pos = Position;
            base.Move(ref value);
            Log(pos, Position);
        }

        public override void Move(ref ushort value)
        {
            long pos = Position;
            base.Move(ref value);
            Log(pos, Position);
        }

        public override void Move(ref int value)
        {
            long pos = Position;
            base.Move(ref value);
            Log(pos, Position);
        }

        public override void Move(ref uint value)
        {
            long pos = Position;
            base.Move(ref value);
            Log(pos, Position);
        }

        public override void Move(ref long value)
        {
            long pos = Position;
            base.Move(ref value);
            Log(pos, Position);
        }

        public override void Move(ref ulong value)
        {
            long pos = Position;
            base.Move(ref value);
            Log(pos, Position);
        }

        public override void Move(ref float value)
        {
            long pos = Position;
            base.Move(ref value);
            Log(pos, Position);
        }

        public override void Move(ref double value)
        {
            long pos = Position;
            base.Move(ref value);
            Log(pos, Position);
        }

        public override sbyte Move(sbyte value)
        {
            return Log(() => base.Move(value));
        }

        public override byte Move(byte value)
        {
            return Log(() => base.Move(value));
        }

        public override short Move(short value)
        {
            return Log(() => base.Move(value));
        }

        public override ushort Move(ushort value)
        {
            return Log(() => base.Move(value));
        }

        public override int Move(int value)
        {
            return Log(() => base.Move(value));
        }

        public override uint Move(uint value)
        {
            return Log(() => base.Move(value));
        }

        public override long Move(long value)
        {
            return Log(() => base.Move(value));
        }

        public override ulong Move(ulong value)
        {
            return Log(() => base.Move(value));
        }

        public override float Move(float value)
        {
            return Log(() => base.Move(value));
        }

        public override double Move(double value)
        {
            return Log(() => base.Move(value));
        }

        public override void Move(ref float[] value, int size)
        {
            long pos = Position;
            base.Move(ref value, size);
            Log(pos, Position);
        }

        public override void Move(ref byte[] value, int size)
        {
            long pos = Position;
            base.Move(ref value, size);
            Log(pos, Position);
        }

        public override void Move(ref short[] value, int size)
        {
            long pos = Position;
            base.Move(ref value, size);
            Log(pos, Position);
        }

        public override void Move(ref ushort[] value, int size)
        {
            long pos = Position;
            base.Move(ref value, size);
            Log(pos, Position);
        }

        public override void Move(ref uint[] value, int size)
        {
            long pos = Position;
            base.Move(ref value, size);
            Log(pos, Position);
        }

        public override void Move(ref byte[] value)
        {
            long pos = Position;
            base.Move(ref value);
            Log(pos, Position);
        }

        public override void Move<T>(ref T value)
        {
            long pos = Position;
            base.Move(ref value);
            Log(pos, Position);
        }

        public override void Move<T>(ref List<T> value)
        {
            long pos = Position;
            base.Move(ref value);
            Log(pos, Position);
        }

        public override void Move<T>(ref List<T> value, ref int elementSize)
        {
            long pos = Position;
            base.Move(ref value);
            Log(pos, Position);
        }

        public override void Move<T>(ref List<T> value, int count)
        {
            long pos = Position;
            base.Move(ref value);
            Log(pos, Position);
        }

        public override void Move<T>(ref T[] value)
        {
            long pos = Position;
            base.Move(ref value);
            Log(pos, Position);
        }

        public override void Move<T1, T2>(ref Dictionary<T1, T2> value)
        {
            long pos = Position;
            base.Move(ref value);
            Log(pos, Position);
        }

        public override void Move<T1, T2>(ref Dictionary<T1, List<T2>> value)
        {
            long pos = Position;
            base.Move(ref value);
            Log(pos, Position);
        }

        public override void Move(ref List<sbyte> value)
        {
            long pos = Position;
            base.Move(ref value);
            Log(pos, Position);
        }

        public override void Move(ref List<byte> value)
        {
            long pos = Position;
            base.Move(ref value);
            Log(pos, Position);
        }

        public override void Move(ref List<short> value)
        {
            long pos = Position;
            base.Move(ref value);
            Log(pos, Position);
        }

        public override void Move(ref List<ushort> value)
        {
            long pos = Position;
            base.Move(ref value);
            Log(pos, Position);
        }

        public override void Move(ref List<int> value)
        {
            long pos = Position;
            base.Move(ref value);
            Log(pos, Position);
        }

        public override void Move(ref List<uint> value)
        {
            long pos = Position;
            base.Move(ref value);
            Log(pos, Position);
        }

        public override void Move(ref List<float> value)
        {
            long pos = Position;
            base.Move(ref value);
            Log(pos, Position);
        }

        public override void Move<T>(ref List<T> value, Action<T> action)
        {
            long pos = Position;
            base.Move(ref value, action);
            Log(pos, Position);
        }

        public override void Move<T1, T2>(ref Dictionary<T1, T2> value, Action<T1> act1, Action<T2> act2)
        {
            long pos = Position;
            base.Move(ref value, act1, act2);
            Log(pos, Position);
        }

        public override FBool Move(FBool value)
        {
            return Log(() => base.Move(value));
        }

        public override void Move(ref FBool value)
        {
            long pos = Position;
            base.Move(ref value);
            Log(pos, Position);
        }

        public override FGuid Move(FGuid value)
        {
            return Log(() => base.Move(value));
        }

        public override void Move(ref FGuid value)
        {
            long pos = Position;
            base.Move(ref value);
            Log(pos, Position);
        }

        public override FName Move(FName value)
        {
            return Log(() => base.Move(value));
        }

        public override void Move(ref FName value)
        {
            long pos = Position;
            base.Move(ref value);
            Log(pos, Position);
        }

        public override FString Move(FString value)
        {
            return Log(() => base.Move(value));
        }

        public override void Move(ref FString value)
        {
            long pos = Position;
            base.Move(ref value);
            Log(pos, Position);
        }

        public override FText Move(FText value)
        {
            return Log(() => base.Move(value));
        }

        public override void Move(ref FText value)
        {
            long pos = Position;
            base.Move(ref value);
            Log(pos, Position);
        }

        public override void Move(ref FTextKey value)
        {
            long pos = Position;
            base.Move(ref value);
            Log(pos, Position);
        }

        public override void MoveFloat(ref double value)
        {
            long pos = Position;
            base.MoveFloat(ref value);
            Log(pos, Position);
        }

        public override void MoveObject<T>(ref T value)
        {
            long pos = Position;
            base.MoveObject(ref value);
            Log(pos, Position);
        }

        public override void MoveRaw<T>(ref T value)
        {
            long pos = Position;
            base.MoveRaw(ref value);
            Log(pos, Position);
        }
    }
}
