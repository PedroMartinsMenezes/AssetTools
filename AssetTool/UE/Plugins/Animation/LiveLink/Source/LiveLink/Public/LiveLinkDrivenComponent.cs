namespace AssetTool
{
    [JsonAsset("DEPRECATED_LiveLinkDrivenComponent")]
    public class UDEPRECATED_LiveLinkDrivenComponent : UActorComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}