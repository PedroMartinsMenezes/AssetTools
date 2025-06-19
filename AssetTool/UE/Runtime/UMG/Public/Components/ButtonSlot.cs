namespace AssetTool
{
    [JsonAsset("ButtonSlot")]
    public class UButtonSlot : UPanelSlot
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}