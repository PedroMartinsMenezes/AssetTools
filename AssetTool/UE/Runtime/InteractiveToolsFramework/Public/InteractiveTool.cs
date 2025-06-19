namespace AssetTool
{
    [JsonAsset("InteractiveToolPropertySet")]
    public class UInteractiveToolPropertySet : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("InteractiveTool")]
    public class UInteractiveTool : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}