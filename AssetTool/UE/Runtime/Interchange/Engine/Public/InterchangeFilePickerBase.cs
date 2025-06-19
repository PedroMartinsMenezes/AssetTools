namespace AssetTool
{
    [JsonAsset("InterchangeFilePickerBase")]
    public class UInterchangeFilePickerBase : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}