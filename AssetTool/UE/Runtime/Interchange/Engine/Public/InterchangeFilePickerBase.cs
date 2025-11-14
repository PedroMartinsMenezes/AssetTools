namespace AssetTool
{
    [JsonAsset("InterchangeFilePickerBase")]
    public class UInterchangeFilePickerBase : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}