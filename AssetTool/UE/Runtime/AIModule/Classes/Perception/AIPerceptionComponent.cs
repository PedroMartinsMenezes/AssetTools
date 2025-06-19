namespace AssetTool
{
    [JsonAsset("AIPerceptionComponent")]
    public class UAIPerceptionComponent : UActorComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}