namespace AssetTool
{
    [JsonAsset("WrapBoxSlot")]
    public class UWrapBoxSlot : UPanelSlot
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}