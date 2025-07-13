namespace AssetTool
{
    [JsonAsset("InterchangeFilePickerGeneric")]
    public class UInterchangeFilePickerGeneric : UInterchangeFilePickerBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}