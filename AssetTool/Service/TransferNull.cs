namespace AssetTool
{
    public class TransferNull : Transfer
    {
        public TransferNull(Transfer other)
        {
            Initialize(other);
        }

        public override bool IsReading => default;
        public override bool IsWriting => default;
        public override bool FromJson { get; init; }
        public override bool FromAutoCheck { get; init; }
        public override long Position { get; set; }
        public override long Length => default;
        public override long Counter { get; set; }
        public override long BaseOffset { get; set; }
        public override Stream Stream => default;

        public override void Move(ref bool value) { }
        public override void Move(ref bool? value) { }

        public override void Move(ref sbyte value) { }
        public override void Move(ref sbyte? value) { }

        public override void Move(ref byte value) { }
        public override void Move(ref byte? value) { }

        public override void Move(ref short value) { }
        public override void Move(ref short? value) { }

        public override void Move(ref ushort value) { }
        public override void Move(ref ushort? value) { }

        public override void Move(ref int value) { }
        public override void Move(ref int? value) { }

        public override void Move(ref uint value) { }
        public override void Move(ref uint? value) { }

        public override void Move(ref long value) { }
        public override void Move(ref long? value) { }

        public override void Move(ref ulong value) { }
        public override void Move(ref ulong? value) { }

        public override void Move(ref float value) { }
        public override void Move(ref float? value) { }

        public override void Move(ref double value) { }
        public override void Move(ref double? value) { }

        public override void Move(ref float[] value, int count) { }
        public override void Move(ref double[] value, int count) { }
        public override void Move(ref byte[] value, int count) { }
        public override void Move(ref short[] value, int count) { }
        public override void Move(ref ushort[] value, int count) { }
        public override void Move(ref uint[] value, int count) { }
        public override void Move(ref byte[] value) { }
        public override void Move(ref ushort[] value) { }
        public override void Move(ref int[] value) { }
        public override void Move(ref uint[] value) { }
        public override void Move(ref long[] value) { }
        public override void Move(ref ulong[] value) { }
        public override void Move(ref float[] value) { }
        public override void Move(ref double[] value) { }
        public override void Move<T>(ref T value, Action<T> action) { }
        public override void Move<T>(ref T value) { }
        public override void Move<T, T1>(ref T value, T1 arg1) { }
        public override void Move<T, T1, T2>(ref T value, T1 arg1, T2 arg2) { }
        public override void Move<T, T1, T2, T3>(ref T value, T1 arg1, T2 arg2, T3 arg3) { }
        public override void Move<T>(ref List<T> value) { }
        public override void Move<T, T1, T2>(ref List<T> value, T1 a, T2 b) { }
        public override void Move<T>(ref List<List<T>> value) { }
        public override void Move<T>(ref List<List<T>> value, int count) { }
        public override void Move<T>(ref List<T> value, int count) { }
        public override void Move<T>(ref T[] value) { }
        public override void Move<T>(ref T[] value, int count) { }
        public override void Move<T1, T2>(ref Dictionary<T1, T2> value) { }
        public override void Move<T1, T2>(ref Dictionary<T1, T2> value, int count) { }
        public override void Move<T1, T2>(ref Dictionary<T1, List<T2>> value) { }
        public override void Move<T1, T2, T3>(ref Dictionary<T1, Dictionary<T2, T3>> value) { }
        public override void Move<T1, T2>(ref Dictionary<T1, T2> value, Action<T2> valueAction) { }
        public override void Move<T>(ref List<T> value, Action<T> action) { }
        public override void Move<T>(ref List<T> value, int count, Action<T> action) { }
        public override void Move(ref FBool value) { }
        public override void Move(ref FBool? value) { }
        public override FGuid Move(FGuid value) => default;
        public override void Move(ref FGuid value) { }
        public override void Move(ref FGuid? value) { }
        public override FName Move(FName value) => default;
        public override void Move(ref FName value) { }
        public override FString Move(FString value) => default;
        public override void Move(ref FString value) { }
        public override FText Move(FText value) => default;
        public override void Move(ref FText value) { }
        public override void Move(ref FTextKey value) { }

        public override void SeekTo(long position) { }
        public override void MoveConst(Int32 value) { }

        public override void MoveAsUInt16(ref Int32 value) { }
        public override void MoveAsUInt16(ref Int32? value) { }

        public override void MoveAsByte(ref UInt16 value) { }
        public override void MoveAsByte(ref UInt16? value) { }

        public override void MoveAsInt(ref Int64 value) { }
        public override void MoveAsInt(ref Int64? value) { }

        public override void MoveEnum<T>(ref T value) { }
        public override void MoveEnum<T>(ref T? value) { }
        public override void MoveEnum<T>(ref T[] value) { }
        public override void MoveEnum<T>(ref T[] value, int index) { }

        public override void MoveFloat(ref double value) { }
        public override void MoveFloat(ref double? value) { }

        public override void MoveRaw<T>(ref T value) { }
        public override void MoveRaw<T>(ref T[] value) { }

        public override void MoveSingleOrDouble(ref double value) { }
        public override void MoveSingleOrDouble(ref double? value) { }

        public override void MoveWhile<T>(ref List<T> value, Func<bool> condition, Action<T> action) { }
        public override void Resize<T>(ref List<T> value, bool withNull = false) { }
        public override void Resize<T>(ref List<T> value, int count, bool withNull = false) { }
        public override void Resize<T>(ref T[] value, int count, bool withNull = false) { }
    }
}