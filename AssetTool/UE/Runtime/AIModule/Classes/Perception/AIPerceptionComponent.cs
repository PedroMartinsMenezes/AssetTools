namespace AssetTool
{
    [JsonAsset("AIPerceptionComponent")]
    public class UAIPerceptionComponent : UActorComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}