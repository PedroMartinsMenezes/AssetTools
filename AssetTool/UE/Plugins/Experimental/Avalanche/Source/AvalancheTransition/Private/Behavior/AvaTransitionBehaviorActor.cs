namespace AssetTool
{
    [JsonAsset("AvaTransitionBehaviorActor")]
    public class AAvaTransitionBehaviorActor : AActor
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}