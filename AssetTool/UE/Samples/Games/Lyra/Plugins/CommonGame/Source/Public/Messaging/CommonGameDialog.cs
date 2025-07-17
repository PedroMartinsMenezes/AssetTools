namespace AssetTool
{
    [JsonAsset("CommonGameDialogDescriptor")]
    public class UCommonGameDialogDescriptor : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("CommonGameDialog")]
    public class UCommonGameDialog : UCommonActivatableWidget
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}