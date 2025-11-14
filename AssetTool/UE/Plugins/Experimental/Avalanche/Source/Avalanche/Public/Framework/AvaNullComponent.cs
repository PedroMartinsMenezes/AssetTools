namespace AssetTool
{
    [JsonAsset("AvaNullComponent")]
    public class UAvaNullComponent : USceneComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}