namespace AssetTool
{
    [JsonAsset("MockHTNComponent")]
    public class UMockHTNComponent : UHTNBrainComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}