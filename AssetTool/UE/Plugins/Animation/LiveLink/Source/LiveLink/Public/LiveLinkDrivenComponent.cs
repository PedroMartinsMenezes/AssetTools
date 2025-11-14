namespace AssetTool
{
    [JsonAsset("LiveLinkDrivenComponent")]
    public class UDEPRECATED_LiveLinkDrivenComponent : UActorComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}