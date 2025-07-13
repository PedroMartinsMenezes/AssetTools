namespace AssetTool
{
    [JsonAsset("ModelingSelectionInteraction")]
    public class UModelingSelectionInteraction : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("PathSelectionInteraction")]
    public class UPathSelectionInteraction : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}