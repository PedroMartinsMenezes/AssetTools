namespace AssetTool
{
    [JsonAsset("LoadGuardSlot")]
    public class ULoadGuardSlot : UPanelSlot
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("CommonLoadGuard")]
    public class UCommonLoadGuard : UContentWidget
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}