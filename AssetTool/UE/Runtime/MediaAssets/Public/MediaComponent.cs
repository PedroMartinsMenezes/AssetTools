namespace AssetTool
{
    [JsonAsset("MediaComponent")]
    public class UMediaComponent : UActorComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}