namespace AssetTool
{
    [JsonAsset("NamedSlot")]
    public class UNamedSlot : UContentWidget
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}