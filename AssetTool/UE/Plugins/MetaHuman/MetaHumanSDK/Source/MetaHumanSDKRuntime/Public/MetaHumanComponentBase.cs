namespace AssetTool
{
    [JsonAsset("MetaHumanComponentBase")]
    public class UMetaHumanComponentBase : UActorComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}