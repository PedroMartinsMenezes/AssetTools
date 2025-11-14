namespace AssetTool
{
    [JsonAsset("LensComponent")]
    public class ULensComponent : UActorComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}