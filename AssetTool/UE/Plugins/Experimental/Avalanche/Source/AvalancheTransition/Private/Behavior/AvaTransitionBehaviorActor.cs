namespace AssetTool
{
    [JsonAsset("AvaTransitionBehaviorActor")]
    public class AAvaTransitionBehaviorActor : AActor
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}