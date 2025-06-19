namespace AssetTool
{
    [JsonAsset("AvaNullComponent")]
    public class UAvaNullComponent : USceneComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}