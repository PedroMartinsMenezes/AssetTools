namespace AssetTool
{
    [JsonAsset("CommonGameDialogDescriptor")]
    public class UCommonGameDialogDescriptor : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("CommonGameDialog")]
    public class UCommonGameDialog : UCommonActivatableWidget
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}