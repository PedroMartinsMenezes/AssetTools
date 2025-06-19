namespace AssetTool
{
    [JsonAsset("NavRelevantComponent")]
    public class UNavRelevantComponent : UActorComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}