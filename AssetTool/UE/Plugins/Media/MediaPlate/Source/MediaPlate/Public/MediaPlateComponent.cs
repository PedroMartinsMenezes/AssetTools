namespace AssetTool
{
    [JsonAsset("MediaPlateComponent")]
    public class UMediaPlateComponent : UActorComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}