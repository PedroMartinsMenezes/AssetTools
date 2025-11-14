namespace AssetTool
{
    [JsonAsset("HTNBrainComponent")]
    public class UHTNBrainComponent : UBrainComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}