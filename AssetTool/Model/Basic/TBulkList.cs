using System.Diagnostics;
using System.Text.Json.Serialization;

namespace AssetTool
{
    [DebuggerDisplay("ElementSize({ElementSize}) ElementCount({ElementCount})")]
    public class TBulkList<T> : ITransferible where T : ITransferible, new()
    {
        [JsonIgnore] public int Count => Items.Length;
        public int ElementSize;
        public int ElementCount;
        public T[] Items;

        public ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref ElementSize);

            if (ElementSize <= 0)
                throw new InvalidOperationException();

            transfer.Move(ref ElementCount);
            transfer.Move(ref Items, ElementCount);
            return this;
        }

        public ITransferible Move(Transfer transfer, bool bForcePerElementSerialization)
        {
            if (bForcePerElementSerialization)
            {
                transfer.Move(ref Items);
                return this;
            }
            else
            {
                return Move(transfer);
            }
        }
    }
}
