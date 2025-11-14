namespace AssetTool
{
    [JsonAsset("MassAgentComponent")]
    public class UMassAgentComponent : UActorComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}