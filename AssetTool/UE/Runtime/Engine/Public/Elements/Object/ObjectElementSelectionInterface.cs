namespace AssetTool
{
    [JsonAsset("ObjectElementSelectionInterface")]
    public class UObjectElementSelectionInterface : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}