namespace AssetTool
{
    [JsonAsset("AvaNullComponent")]
    public class UAvaNullComponent : USceneComponent
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}