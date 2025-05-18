namespace AssetTool
{
    [JsonAsset("InteractiveToolPropertySet")]
    public class UInteractiveToolPropertySet : UObject
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("InteractiveTool")]
    public class UInteractiveTool : UObject
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}