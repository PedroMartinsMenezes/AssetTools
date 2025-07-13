namespace AssetTool
{
    [JsonAsset("HTNBrainComponent")]
    public class UHTNBrainComponent : UBrainComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}