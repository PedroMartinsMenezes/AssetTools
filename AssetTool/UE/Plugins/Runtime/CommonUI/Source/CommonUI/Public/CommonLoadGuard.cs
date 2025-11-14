namespace AssetTool
{
    [JsonAsset("LoadGuardSlot")]
    public class ULoadGuardSlot : UPanelSlot
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("CommonLoadGuard")]
    public class UCommonLoadGuard : UContentWidget
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}