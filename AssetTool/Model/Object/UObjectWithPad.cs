namespace AssetTool
{
    [JsonAsset("UObjectWithPad")]
    [Obsolete("Remove this workaround")]
    public class UObjectWithPad : UObject
    {
        public const string TypeName = "UObjectWithPad";

        public TUInt8[] PadData;

        public override ITransferible Move(Transfer transfer)
        {
            long before = transfer.Position;
            base.Move(transfer);
            long size = transfer.Position - before;
            long remaining = transfer.GlobalObjects.CurrentObject.Size - size;
            if (remaining > 0)
            {
                transfer.Move(ref PadData, (int)remaining);
            }
            return this;
        }
    }
}
