namespace AssetTool
{
    [JsonAsset("BrainComponent")]
    public class UBrainComponent : UActorComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}