namespace AssetTool
{
    [JsonAsset("NavRelevantComponent")]
    public class UNavRelevantComponent : UActorComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}