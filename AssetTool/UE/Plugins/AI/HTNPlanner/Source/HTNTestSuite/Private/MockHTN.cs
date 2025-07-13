namespace AssetTool
{
    [JsonAsset("MockHTNComponent")]
    public class UMockHTNComponent : UHTNBrainComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}