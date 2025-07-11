namespace AssetTool
{
    //TODO Remove this workaround
    [JsonAsset("UObjectWithPad")]
    public class UObjectWithPad : UObject
    {
        public const string TypeName = "UObjectWithPad";

        public TUInt8[] PadData;

        public override ITransferible Move(Transfer transfer)
        {
            base.Move(transfer);
            if (transfer.GlobalObjects.CurrentObject.Size > (transfer.Position - transfer.GlobalObjects.CurrentObject.Offset))
            {
                long size = transfer.GlobalObjects.CurrentObject.Size - (transfer.Position - transfer.GlobalObjects.CurrentObject.Offset);
                transfer.Move(ref PadData, (int)size);
            }
            return this;
        }
    }
}
