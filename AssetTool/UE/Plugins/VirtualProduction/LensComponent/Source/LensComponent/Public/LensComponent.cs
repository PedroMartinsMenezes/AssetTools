namespace AssetTool
{
    [JsonAsset("LensComponent")]
    public class ULensComponent : UActorComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}