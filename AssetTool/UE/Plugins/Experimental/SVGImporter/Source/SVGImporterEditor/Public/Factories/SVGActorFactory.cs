namespace AssetTool
{
    [JsonAsset("SVGActorFactory")]
    public class USVGActorFactory : UActorFactory
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}