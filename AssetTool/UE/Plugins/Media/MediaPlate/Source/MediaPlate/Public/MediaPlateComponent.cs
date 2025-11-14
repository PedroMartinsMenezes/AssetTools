namespace AssetTool
{
    [JsonAsset("MediaPlateComponent")]
    public class UMediaPlateComponent : UActorComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}