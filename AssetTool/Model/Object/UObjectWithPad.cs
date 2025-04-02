namespace AssetTool
{
    [JsonAsset("UObjectWithPad")]
    public class UObjectWithPad : UObject
    {
        public const string TypeName = "UObjectWithPad";

        public UInt32 Pad1;

        public override UObject Move(Transfer transfer)
        {
            base.Move(transfer);
            if (transfer.GlobalObjects.CurrentObject.Size > (transfer.Position - transfer.GlobalObjects.CurrentObject.Offset))
            {
                transfer.Move(ref Pad1);
            }
            return this;
        }
    }
}
