namespace AssetTool
{
    [JsonAsset("MassAgentComponent")]
    public class UMassAgentComponent : UActorComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}