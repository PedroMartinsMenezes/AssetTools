namespace AssetTool
{
    [JsonAsset("SVGActorFactory")]
    public class USVGActorFactory : UActorFactory
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}