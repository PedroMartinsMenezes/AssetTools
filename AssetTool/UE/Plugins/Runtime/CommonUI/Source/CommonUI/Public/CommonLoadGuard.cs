namespace AssetTool
{
    [JsonAsset("LoadGuardSlot")]
    public class ULoadGuardSlot : UPanelSlot
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("CommonLoadGuard")]
    public class UCommonLoadGuard : UContentWidget
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}